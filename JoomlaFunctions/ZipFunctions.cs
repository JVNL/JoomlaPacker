using System;
using System.IO;
using System.IO.Compression;

namespace JoomlaFunctions
{
	internal static class ZipFunctions
	{
		public static void Unzip(string zip, string unzipPath)
		{
			if (!File.Exists(zip))
				throw new Exception($"File not found: {zip}");
			try
			{
				ZipFile.ExtractToDirectory(zip, unzipPath);
			}
			catch (Exception)
			{
				// ignore
			}
		}

		public static void Zip(string source, string zip)
		{
			if (!Directory.Exists(source))
				throw new Exception($"Folder not found: {source}");
			FileFunctions.RemoveFile(zip);
			try
			{
				ZipFile.CreateFromDirectory(source, zip);
			}
			catch (Exception)
			{
				// ignore
			}
		}
	}
}
