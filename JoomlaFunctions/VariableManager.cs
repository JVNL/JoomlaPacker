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
		/// Get variables
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
						var value = i.Value;
						if (value.Contains("%"))
						{
							foreach (var a in temp)
							{
								if (value.Contains(a.Var))
									value = value.Replace(a.Var, a.Value);
							}
						}
						vars.Add(new VariableItem { Var = i.Var, Value = value });
					}
					return new Variable { Variables = vars };
				}
			}
			else
				throw new Exception("Variables file not found!");
		}
	}
}
