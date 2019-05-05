using JoomlaFunctions.Json;
using Newtonsoft.Json;
using System;
using System.IO;

namespace JoomlaFunctions
{
	public class WorkflowManager
	{
		public string WorkflowFile => "Workflow.json";

		public void SaveWorkflow(Workflow workflow) {
			var json = JsonConvert.SerializeObject(workflow);
			File.WriteAllText(WorkflowFile, json);
		}

		/// <summary>
		/// Ophalen van workflow
		/// </summary>
		/// <returns></returns>
		public Workflow GetWorkflow()
		{
			if (File.Exists(WorkflowFile))
			{
				var fileData = File.ReadAllText(WorkflowFile);
				return JsonConvert.DeserializeObject<Workflow>(fileData);
			}
			else
				throw new Exception("Kan workflow bestand niet vinden!");
		}

		/// <summary>
		/// Uitvoeren van de workflow acties
		/// </summary>
		/// <param name="action"></param>
		/// <param name="arguments"></param>
		public void ExecuteWorkflowAction(Enums.Action action, string arguments)
		{
			// Check params
			if (string.IsNullOrWhiteSpace(arguments))
				throw new ArgumentException("Geen gevuld element voor: ", nameof(arguments));

			var args = SplitArguments(arguments);
			var aantalArgs = args.Length;

			// Execute
			switch (action)
			{
				case Enums.Action.CopyFile:
					if (aantalArgs != 2)
						ArgumentIncorrect(2, arguments);

					FileFunctions.CopyFile(args[0], args[1]);
					break;
				case Enums.Action.EditFile:
					if (aantalArgs != 2 && aantalArgs != 3)
						ArgumentIncorrect(2, arguments);

					if (aantalArgs == 2)
						FileFunctions.EditFile(args[1], args[0]);
					else
						FileFunctions.EditFile(args[1], args[0], args[2]);
					break;
				case Enums.Action.AppendToFile:
					if (aantalArgs != 2)
						ArgumentIncorrect(2, arguments);

					FileFunctions.AppendToTextFile(args[1], args[0]);
					break;
				case Enums.Action.RemoveFile:
					if (aantalArgs != 1)
						ArgumentIncorrect(1, arguments);

					FileFunctions.RemoveFile(args[0]);
					break;
				case Enums.Action.CreateFolder:
					if (aantalArgs != 1)
						ArgumentIncorrect(1, arguments);

					FolderFunctions.CreateFolder(args[0]);
					break;
				case Enums.Action.CopyFolder:
					if (aantalArgs != 2)
						ArgumentIncorrect(2, arguments);

					FolderFunctions.CopyAll(args[0], args[1]);
					break;
				case Enums.Action.RemoveFolder:
					if (aantalArgs != 1)
						ArgumentIncorrect(1, arguments);

					FolderFunctions.RemoveFolder(args[0]);
					break;
				case Enums.Action.ClearAllInFolder:
					if (aantalArgs != 1)
						ArgumentIncorrect(1, arguments);

					FolderFunctions.ClearFilesInFolder(args[0]);
					break;
				case Enums.Action.Zip:
					if (aantalArgs != 2)
						ArgumentIncorrect(2, arguments);

					ZipFunctions.Zip(args[0], args[1]);
					break;
				case Enums.Action.Unzip:
					if (aantalArgs != 2)
						ArgumentIncorrect(2, arguments);

					ZipFunctions.Unzip(args[0], args[1]);
					break;
				case Enums.Action.DownloadFile:
					if (aantalArgs != 2)
						ArgumentIncorrect(2, arguments);

					FileFunctions.DownloadFile(args[0], args[1]);
					break;
				default:
					// Geen actie uitvoeren
					break;
			}
		}

		/// <summary>
		/// Maak exception voor ongeldige regel.
		/// </summary>
		/// <param name="count"></param>
		/// <param name="arguments"></param>
		private void ArgumentIncorrect(int count, string arguments) => throw new Exception($"{count} argument{(count > 1 ? "en" : string.Empty)} verwacht, gekregen: '{arguments}'");

		/// <summary>
		/// Splitsen van args.
		/// </summary>
		/// <param name="arguments"></param>
		/// <returns></returns>
		private string[] SplitArguments(string arguments)
		{
			var splitted = arguments.Split('|');
			foreach (var item in splitted)
			{
				if (string.IsNullOrWhiteSpace(item))
					throw new ArgumentException($"Leeg argument gevonden in: '{arguments}'");
			}
			return splitted;
		}
	}
}
