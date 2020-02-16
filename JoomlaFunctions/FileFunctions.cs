using System;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;

namespace JoomlaFunctions
{
	internal static class FileFunctions
	{
		public static void CopyFile(string source, string target)
		{
			if (string.IsNullOrWhiteSpace(source))
				throw new ArgumentException("Source file could not be empty.", nameof(source));

			if (string.IsNullOrWhiteSpace(target))
				throw new ArgumentNullException("Target file could not be empty.", nameof(target));

			if (!File.Exists(source))
				throw new Exception($"Source file does not exist: {source}");

			if (!File.Exists(target))
				File.WriteAllText(target, string.Empty);

			var fi = new FileInfo(source);
			fi.CopyTo(target, true);
		}

		public static void AppendToTextFile(string path, string text)
		{
			if (string.IsNullOrWhiteSpace(path))
				throw new ArgumentException("Path to file could not be empty.", nameof(path));

			if (string.IsNullOrWhiteSpace(text))
				throw new ArgumentException("Text to add could not be empty.", nameof(text));

			if (!File.Exists(path))
				throw new Exception($"Target file does not exist: {path}");

			using (var w = File.AppendText(path))
			{
				w.WriteLine(text);
			}
		}

		public static void EditFile(string fileName, string replacementValues, string saveFileName = "")
		{
			if (string.IsNullOrWhiteSpace(fileName))
				throw new ArgumentException("message", nameof(fileName));

			if (string.IsNullOrWhiteSpace(replacementValues))
				throw new ArgumentException("message", nameof(replacementValues));

			if (string.IsNullOrWhiteSpace(saveFileName))
				saveFileName = fileName;

			var reader = new StreamReader(fileName);
			var input = reader.ReadToEnd();
			reader.Close();

			using (var writer = new StreamWriter(saveFileName, true))
			{
				var regex = new Regex("\\[([^\\[\\]]*)\\]");
				var matches = regex.Matches(replacementValues);
				if (matches.Count > 0)
				{
					foreach (Match match in matches)
					{
						var items = match.Groups[1].Value.Split(';');
						if (items.Length != 2)
							throw new Exception($"Item does not contain two values separated by semicolon: [{match.Value}]");
						input = input.Replace(items[0], items[1]);
					}
				}
				writer.Write(input);
			}
		}

		public static void RemoveFile(string path)
		{
			if (File.Exists(path))
				File.Delete(path);
		}

		public static void DownloadFile(string url, string target)
		{
			RemoveFile(target);
			using (var client = new WebClient())
			{
				client.DownloadFile(url, target);
			}
		}
	}
}
