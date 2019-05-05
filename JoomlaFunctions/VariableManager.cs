using JoomlaFunctions.Json;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace JoomlaFunctions
{
	public class VariableManager
	{
		public string VariableFile => "Variables.json";

		public void SaveVars(Variable variable)
		{
			var json = JsonConvert.SerializeObject(variable);
			File.WriteAllText(VariableFile, json);
		}

		/// <summary>
		/// Ophalen van variables
		/// </summary>
		/// <returns></returns>
		public Variable GetVars(bool getResolved = false)
		{
			if (File.Exists(VariableFile))
			{
				var fileData = File.ReadAllText(VariableFile);
				var elements = JsonConvert.DeserializeObject<Variable>(fileData);
				if (!getResolved)
					return elements;
				else
				{
					var temp = elements.Variables;
					var vars = new List<VariableItem>();
					foreach (var i in temp)
					{
						var waarde = i.Value;
						if (waarde.Contains("%"))
						{
							foreach (var a in temp)
							{
								if (waarde.Contains(a.Var))
									waarde = waarde.Replace(a.Var, a.Value);
							}
						}
						vars.Add(new VariableItem { Var = i.Var, Value = waarde });
					}
					return new Variable { Variables = vars };
				}
			}
			else
				throw new Exception("Kan variables bestand niet vinden!");
		}
	}
}
