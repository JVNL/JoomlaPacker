using System;
using System.IO;

namespace JoomlaFunctions
{
	internal static class FolderFunctions
	{
		public static void RemoveFolder(string path)
		{
			if (Directory.Exists(path))
			{
				ClearFilesInFolder(path);
				Directory.Delete(path);
			}
		}

		public static void CreateFolder(string path)
		{
			if (!Directory.Exists(path))
				Directory.CreateDirectory(path);
		}

		public static void CopyAll(string sourcePath, string targetPath)
		{
			CreateFolder(targetPath);
			foreach (var dirPath in Directory.GetDirectories(sourcePath, "*", SearchOption.AllDirectories))
				Directory.CreateDirectory(dirPath.Replace(sourcePath, targetPath));
			foreach (var newPath in Directory.GetFiles(sourcePath, "*", SearchOption.AllDirectories))
				File.Copy(newPath, newPath.Replace(sourcePath, targetPath), true);
		}

		public static void ClearFilesInFolder(string folder)
		{
			try
			{
				var di = new DirectoryInfo(folder);

				foreach (var file in di.GetFiles())
				{
					file.Delete();
				}
				foreach (var dir in di.GetDirectories())
				{
					dir.Delete(true);
				}
			}
			catch (Exception)
			{
				// ignore
			}
		}
	}
}
