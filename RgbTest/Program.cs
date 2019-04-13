using Rgb;
using System;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.IO;

namespace RgbTest
{
	public static class Program
	{
		public static void Main(string[] args)
		{
			if (args.Length < 4)
			{
				Console.WriteLine("Format: {fileName} {width} {height} {mode}");
				Console.WriteLine("mode:");
				Console.WriteLine("0 - Alpha8");
				Console.WriteLine("1 - Argb4444");
				Console.WriteLine("2 - Rgb24");
				Console.WriteLine("3 - Rgba32");
				Console.WriteLine("4 - Argb32");
				Console.WriteLine("5 - Rbg16");
				Console.WriteLine("6 - R16");
				Console.WriteLine("7 - Rgba4444");
				Console.WriteLine("8 - Bgra32");
				Console.WriteLine("9 - Rg16");
				Console.WriteLine("10 - R8");
				Console.ReadKey();
				return;
			}

			string path = args[0];
			int width = int.Parse(args[1]);
			int height = int.Parse(args[2]);
			int mode = int.Parse(args[3]);

			using (DirectBitmap bitmap = new DirectBitmap(width, height))
			{
				byte[] data = File.ReadAllBytes(path);
				Stopwatch stopwatch = new Stopwatch();
				for (int i = 0; i < 5; i++)
				{
					stopwatch.Start();
					for (int j = 0; j < 5; j++)
					{
						switch (mode)
						{
							case 0:
								RgbConverter.A8ToBGRA32(data, width, height, bitmap.Bits);
								break;
							case 1:
								RgbConverter.ARGB16ToBGRA32(data, width, height, bitmap.Bits);
								break;
							case 2:
								RgbConverter.RGB24ToBGRA32(data, width, height, bitmap.Bits);
								break;
							case 3:
								RgbConverter.RGBA32ToBGRA32(data, width, height, bitmap.Bits);
								break;
							case 4:
								RgbConverter.ARGB32ToBGRA32(data, width, height, bitmap.Bits);
								break;
							case 5:
								RgbConverter.RGB16ToBGRA32(data, width, height, bitmap.Bits);
								break;
							case 6:
								RgbConverter.R16ToBGRA32(data, width, height, bitmap.Bits);
								break;
							case 7:
								RgbConverter.RGBA16ToBGRA32(data, width, height, bitmap.Bits);
								break;
							case 8:
								Buffer.BlockCopy(data, 0, bitmap.Bits, 0, bitmap.Bits.Length);
								break;
							case 9:
								RgbConverter.RG16ToBGRA32(data, width, height, bitmap.Bits);
								break;
							case 10:
								RgbConverter.R8ToBGRA32(data, width, height, bitmap.Bits);
								break;

							default:
								throw new Exception(mode.ToString());
						}
					}
					stopwatch.Stop();

					Console.WriteLine("Processed " + stopwatch.ElapsedMilliseconds);
					stopwatch.Reset();
				}

				string dirPath = Path.GetDirectoryName(path);
				string fileName = Path.GetFileNameWithoutExtension(path);
				string outPath = Path.Combine(dirPath, fileName + ".png");
				bitmap.Bitmap.RotateFlip(System.Drawing.RotateFlipType.RotateNoneFlipY);
				bitmap.Bitmap.Save(outPath, ImageFormat.Png);
			}

			Console.WriteLine("Finished!");
		}
	}
}
