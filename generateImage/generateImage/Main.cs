
using System;
//http://msdn.microsoft.com/en-us/library/ms533846.aspx
using System.Drawing;
namespace generateImage
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Bitmap bmp = new Bitmap(50,50);
	
			EncoderParameters parameters = new EncoderParameters(1);   
			parameters.Param[0] = new EncoderParameter(Encoder.ColorDepth, 8);
			bmp.Save("",ImageFormat.tiff, parameters);
			Console.WriteLine ("Hello World!");
		}
	}
}
