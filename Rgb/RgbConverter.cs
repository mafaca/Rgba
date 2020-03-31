using System;

namespace Rgb
{
	public static class RgbConverter
	{
		public static byte[] A8ToBGRA32(byte[] input, int width, int height)
		{
			byte[] output = new byte[width * height * 4];
			A8ToBGRA32(input, width, height, output);
			return output;
		}

		public unsafe static void A8ToBGRA32(byte[] input, int width, int height, byte[] output)
		{
			fixed (byte* inputPtr = input)
			{
				fixed (byte* outputPtr = output)
				{
					A8ToBGRA32(inputPtr, width, height, outputPtr);
				}
			}
		}

		public unsafe static void A8ToBGRA32(byte* input, int width, int height, byte* output)
		{
			for (int i = 0; i < width; i++)
			{
				for (int j = 0; j < height; j++)
				{
					output[0] = 0;		// b
					output[1] = 0;		// g
					output[2] = 0;		// r
					output[3] = *input;	// a
					output += 4;
					input++;
				}
			}
		}

		public static byte[] ARGB16ToBGRA32(byte[] input, int width, int height)
		{
			byte[] output = new byte[width * height * 4];
			ARGB16ToBGRA32(input, width, height, output);
			return output;
		}

		public unsafe static void ARGB16ToBGRA32(byte[] input, int width, int height, byte[] output)
		{
			fixed (byte* inputPtr = input)
			{
				fixed (byte* outputPtr = output)
				{
					ARGB16ToBGRA32(inputPtr, width, height, outputPtr);
				}
			}
		}

		public unsafe static void ARGB16ToBGRA32(byte* input, int width, int height, byte* output)
		{
			for (int i = 0; i < width; i++)
			{
				for (int j = 0; j < height; j++)
				{
					output[0] = unchecked((byte)(input[0] << 4));	// b
					output[1] = (byte)(input[0] & 0xF0);			// g	
					output[2] = unchecked((byte)(input[1] << 4));	// r
					output[3] = (byte)(input[1] & 0xF0);			// a
					input += 2;
					output += 4;
				}
			}
		}

		public static byte[] RGB24ToBGRA32(byte[] input, int width, int height)
		{
			byte[] output = new byte[width * height * 4];
			RGB24ToBGRA32(input, width, height, output);
			return output;
		}

		public unsafe static void RGB24ToBGRA32(byte[] input, int width, int height, byte[] output)
		{
			fixed (byte* inputPtr = input)
			{
				fixed (byte* outputPtr = output)
				{
					RGB24ToBGRA32(inputPtr, width, height, outputPtr);
				}
			}
		}

		public unsafe static void RGB24ToBGRA32(byte* input, int width, int height, byte* output)
		{
			for (int i = 0; i < width; i++)
			{
				for (int j = 0; j < height; j++)
				{
					output[0] = input[2];	// b
					output[1] = input[1];	// g
					output[2] = input[0];	// r
					output[3] = 255;		// a
					input += 3;
					output += 4;
				}
			}
		}

		public static byte[] RGBA32ToBGRA32(byte[] input, int width, int height)
		{
			byte[] output = new byte[width * height * 4];
			RGBA32ToBGRA32(input, width, height, output);
			return output;
		}

		public unsafe static void RGBA32ToBGRA32(byte[] input, int width, int height, byte[] output)
		{
			fixed (byte* inputPtr = input)
			{
				fixed (byte* outputPtr = output)
				{
					RGBA32ToBGRA32(inputPtr, width, height, outputPtr);
				}
			}
		}

		public unsafe static void RGBA32ToBGRA32(byte* input, int width, int height, byte* output)
		{
			for (int i = 0; i < width; i++)
			{
				for (int j = 0; j < height; j++)
				{
					output[0] = input[2]; // b
					output[1] = input[1]; // g
					output[2] = input[0]; // r
					output[3] = input[3]; // a
					input += 4;
					output += 4;
				}
			}
		}

		public static byte[] ARGB32ToBGRA32(byte[] input, int width, int height)
		{
			byte[] output = new byte[width * height * 4];
			ARGB32ToBGRA32(input, width, height, output);
			return output;
		}

		public unsafe static void ARGB32ToBGRA32(byte[] input, int width, int height, byte[] output)
		{
			fixed (byte* inputPtr = input)
			{
				fixed (byte* outputPtr = output)
				{
					ARGB32ToBGRA32(inputPtr, width, height, outputPtr);
				}
			}
		}

		public unsafe static void ARGB32ToBGRA32(byte* input, int width, int height, byte* output)
		{
			for (int i = 0; i < width; i++)
			{
				for (int j = 0; j < height; j++)
				{
					output[0] = input[3]; // b
					output[1] = input[2]; // g
					output[2] = input[1]; // r
					output[3] = input[0]; // a
					input += 4;
					output += 4;
				}
			}
		}

		public static byte[] RGB16ToBGRA32(byte[] input, int width, int height)
		{
			byte[] output = new byte[width * height * 4];
			RGB16ToBGRA32(input, width, height, output);
			return output;
		}

		public unsafe static void RGB16ToBGRA32(byte[] input, int width, int height, byte[] output)
		{
			fixed (byte* inputPtr = input)
			{
				fixed (byte* outputPtr = output)
				{
					RGB16ToBGRA32(inputPtr, width, height, outputPtr);
				}
			}
		}

		public unsafe static void RGB16ToBGRA32(byte* input, int width, int height, byte* output)
		{
			for (int i = 0; i < width; i++)
			{
				for (int j = 0; j < height; j++)
				{
					byte r = (byte)(input[1] & 0xF8);
					byte g = unchecked((byte)((input[1] << 5) | ((input[0] & 0xE0) >> 3)));
					byte b = unchecked((byte)(input[0] << 3));
					output[0] = b;		// b
					output[1] = g;		// g
					output[2] = r;		// r
					output[3] = 255;	// a
					input += 2;
					output += 4;
				}
			}
		}

		public static byte[] R16ToBGRA32(byte[] input, int width, int height)
		{
			byte[] output = new byte[width * height * 4];
			R16ToBGRA32(input, width, height, output);
			return output;
		}

		public unsafe static void R16ToBGRA32(byte[] input, int width, int height, byte[] output)
		{
			fixed (byte* inputPtr = input)
			{
				fixed (byte* outputPtr = output)
				{
					R16ToBGRA32(inputPtr, width, height, outputPtr);
				}
			}
		}

		public unsafe static void R16ToBGRA32(byte* input, int width, int height, byte* output)
		{
			for (int i = 0; i < width; i++)
			{
				for (int j = 0; j < height; j++)
				{
					output[0] = 0;			// b
					output[1] = 0;			// g
					output[2] = input[1];	// r
					output[3] = 255;		// a
					input += 2;
					output += 4;
				}
			}
		}

		public static byte[] RGBA16ToBGRA32(byte[] input, int width, int height)
		{
			byte[] output = new byte[width * height * 4];
			RGBA16ToBGRA32(input, width, height, output);
			return output;
		}

		public unsafe static void RGBA16ToBGRA32(byte[] input, int width, int height, byte[] output)
		{
			fixed (byte* inputPtr = input)
			{
				fixed (byte* outputPtr = output)
				{
					RGBA16ToBGRA32(inputPtr, width, height, outputPtr);
				}
			}
		}

		public unsafe static void RGBA16ToBGRA32(byte* input, int width, int height, byte* output)
		{
			for (int i = 0; i < width; i++)
			{
				for (int j = 0; j < height; j++)
				{
					output[0] = (byte)(input[0] & 0xF0);			// b
					output[1] = unchecked((byte)(input[1] << 4));	// g	
					output[2] = (byte)(input[1] & 0xF0);			// r
					output[3] = unchecked((byte)(input[0] << 4));	// a
					input += 2;
					output += 4;
				}
			}
		}

		public static byte[] RG16ToBGRA32(byte[] input, int width, int height)
		{
			byte[] output = new byte[width * height * 4];
			RG16ToBGRA32(input, width, height, output);
			return output;
		}

		public unsafe static void RG16ToBGRA32(byte[] input, int width, int height, byte[] output)
		{
			fixed (byte* inputPtr = input)
			{
				fixed (byte* outputPtr = output)
				{
					RG16ToBGRA32(inputPtr, width, height, outputPtr);
				}
			}
		}

		public unsafe static void RG16ToBGRA32(byte* input, int width, int height, byte* output)
		{
			for (int i = 0; i < width; i++)
			{
				for (int j = 0; j < height; j++)
				{
					output[0] = 0;			// b
					output[1] = input[1];	// g
					output[2] = input[0];	// r
					output[3] = 255;		// a
					input += 2;
					output += 4;
				}
			}
		}

		public static byte[] R8ToBGRA32(byte[] input, int width, int height)
		{
			byte[] output = new byte[width * height * 4];
			R8ToBGRA32(input, width, height, output);
			return output;
		}

		public unsafe static void R8ToBGRA32(byte[] input, int width, int height, byte[] output)
		{
			fixed (byte* inputPtr = input)
			{
				fixed (byte* outputPtr = output)
				{
					R8ToBGRA32(inputPtr, width, height, outputPtr);
				}
			}
		}

		public unsafe static void R8ToBGRA32(byte* input, int width, int height, byte* output)
		{
			for (int i = 0; i < width; i++)
			{
				for (int j = 0; j < height; j++)
				{
					output[0] = 0;			// b
					output[1] = 0;			// g
					output[2] = input[0];	// r
					output[3] = 255;		// a
					input += 1;
					output += 4;
				}
			}
		}

		public static byte[] RHalfToBGRA32(byte[] input, int width, int height)
		{
			byte[] output = new byte[width * height * 4];
			RHalfToBGRA32(input, width, height, output);
			return output;
		}

		public static void RHalfToBGRA32(byte[] input, int width, int height, byte[] output)
		{
			int io = 0;
			int oo = 0;
			for (int i = 0; i < width; i++)
			{
				for (int j = 0; j < height; j++)
				{
					byte r = Convert.ToByte(Math.Round(Half.ToHalf(input, io) * 255f));
					output[oo + 0] = 0;             // b
					output[oo + 1] = 0;             // g
					output[oo + 2] = r;				// r
					output[oo + 3] = 255;           // a
					io += 2;
					oo += 4;
				}
			}
		}

		public static byte[] RGHalfToBGRA32(byte[] input, int width, int height)
		{
			byte[] output = new byte[width * height * 4];
			RGHalfToBGRA32(input, width, height, output);
			return output;
		}

		public static void RGHalfToBGRA32(byte[] input, int width, int height, byte[] output)
		{
			int io = 0;
			int oo = 0;
			for (int i = 0; i < width; i++)
			{
				for (int j = 0; j < height; j++)
				{
					byte r = Convert.ToByte(Math.Round(Half.ToHalf(input, io + 0) * 255f));
					byte g = Convert.ToByte(Math.Round(Half.ToHalf(input, io + 2) * 255f));
					output[oo + 0] = 0;             // b
					output[oo + 1] = g;             // g
					output[oo + 2] = r;             // r
					output[oo + 3] = 255;           // a
					io += 4;
					oo += 4;
				}
			}
		}

		public static byte[] RGBAHalfToBGRA32(byte[] input, int width, int height)
		{
			byte[] output = new byte[width * height * 4];
			RGBAHalfToBGRA32(input, width, height, output);
			return output;
		}

		public static void RGBAHalfToBGRA32(byte[] input, int width, int height, byte[] output)
		{
			int io = 0;
			int oo = 0;
			for (int i = 0; i < width; i++)
			{
				for (int j = 0; j < height; j++)
				{
					byte r = Convert.ToByte(Math.Round(Half.ToHalf(input, io + 0) * 255f));
					byte g = Convert.ToByte(Math.Round(Half.ToHalf(input, io + 2) * 255f));
					byte b = Convert.ToByte(Math.Round(Half.ToHalf(input, io + 4) * 255f));
					byte a = Convert.ToByte(Math.Round(Half.ToHalf(input, io + 6) * 255f));
					output[oo + 0] = b;             // b
					output[oo + 1] = g;             // g
					output[oo + 2] = r;             // r
					output[oo + 3] = a;				// a
					io += 8;
					oo += 4;
				}
			}
		}

		public static byte[] RFloatToBGRA32(byte[] input, int width, int height)
		{
			byte[] output = new byte[width * height * 4];
			RFloatToBGRA32(input, width, height, output);
			return output;
		}

		public static void RFloatToBGRA32(byte[] input, int width, int height, byte[] output)
		{
			int io = 0;
			int oo = 0;
			for (int i = 0; i < width; i++)
			{
				for (int j = 0; j < height; j++)
				{
					byte r = Convert.ToByte(Math.Round(BitConverter.ToSingle(input, io) * 255f));
					output[oo + 0] = 0;				// b
					output[oo + 1] = 0;				// g
					output[oo + 2] = r;				// r
					output[oo + 3] = 255;			// a
					io += 4;
					oo += 4;
				}
			}
		}

		public static byte[] RGFloatToBGRA32(byte[] input, int width, int height)
		{
			byte[] output = new byte[width * height * 4];
			RGFloatToBGRA32(input, width, height, output);
			return output;
		}

		public static void RGFloatToBGRA32(byte[] input, int width, int height, byte[] output)
		{
			int io = 0;
			int oo = 0;
			for (int i = 0; i < width; i++)
			{
				for (int j = 0; j < height; j++)
				{
					byte r = Convert.ToByte(Math.Round(BitConverter.ToSingle(input, io + 0) * 255f));
					byte g = Convert.ToByte(Math.Round(BitConverter.ToSingle(input, io + 4) * 255f));
					output[oo + 0] = 0;             // b
					output[oo + 1] = g;             // g
					output[oo + 2] = r;             // r
					output[oo + 3] = 255;           // a
					io += 8;
					oo += 4;
				}
			}
		}

		public static byte[] RGBAFloatToBGRA32(byte[] input, int width, int height)
		{
			byte[] output = new byte[width * height * 4];
			RGBAFloatToBGRA32(input, width, height, output);
			return output;
		}

		public static void RGBAFloatToBGRA32(byte[] input, int width, int height, byte[] output)
		{
			int io = 0;
			int oo = 0;
			for (int i = 0; i < width; i++)
			{
				for (int j = 0; j < height; j++)
				{
					byte r = Convert.ToByte(Math.Round(BitConverter.ToSingle(input, io + 0) * 255f));
					byte g = Convert.ToByte(Math.Round(BitConverter.ToSingle(input, io + 4) * 255f));
					byte b = Convert.ToByte(Math.Round(BitConverter.ToSingle(input, io + 8) * 255f));
					byte a = Convert.ToByte(Math.Round(BitConverter.ToSingle(input, io + 12) * 255f));
					output[oo + 0] = b;				// b
					output[oo + 1] = g;				// g
					output[oo + 2] = r;				// r
					output[oo + 3] = a;				// a
					io += 16;
					oo += 4;
				}
			}
		}

		public static byte[] RGB9e5FloatToBGRA32(byte[] input, int width, int height)
		{
			byte[] output = new byte[width * height * 4];
			RGB9e5FloatToBGRA32(input, width, height, output);
			return output;
		}

		public static void RGB9e5FloatToBGRA32(byte[] input, int width, int height, byte[] output)
		{
			int io = 0;
			int oo = 0;
			for (int i = 0; i < width; i++)
			{
				for (int j = 0; j < height; j++)
				{
					uint value = BitConverter.ToUInt32(input, io);
					double scale = Math.Pow(2, unchecked((int)(value >> 27) - 24));
					byte r = Convert.ToByte(Math.Round((value >> 0 & 0x1FF) * scale * 255.0));
					byte g = Convert.ToByte(Math.Round((value >> 9 & 0x1FF) * scale * 255.0));
					byte b = Convert.ToByte(Math.Round((value >> 18 & 0x1FF) * scale * 255.0));
					output[oo + 0] = b;             // b
					output[oo + 1] = g;             // g
					output[oo + 2] = r;             // r
					output[oo + 3] = 255;           // a
					io += 4;
					oo += 4;
				}
			}
		}
	}
}
