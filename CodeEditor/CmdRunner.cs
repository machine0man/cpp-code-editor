using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeEditor
{
	class CmdRunner
    {
		string WorkingDir = @"C:\Users\harjo\OneDrive\Desktop\CodeEditor";

		public CmdRunner(string a_workingDir)
		{
			WorkingDir = a_workingDir;
		}
		public CmdRunner() { }
		public void Run(string command, out string output, out string error, bool showWindow = false)
		{
			Process process = new Process
			{
				StartInfo = new ProcessStartInfo
				{
					FileName = "cmd.exe",
					UseShellExecute = false,
					RedirectStandardOutput = true,
					RedirectStandardError = true,
					RedirectStandardInput = true,
					Arguments = "/c" + command,
					CreateNoWindow = !showWindow,
					WorkingDirectory = WorkingDir ?? string.Empty
				}
			};

			process.Start();
			process.WaitForExit();
			output = process.StandardOutput.ReadToEnd();
			error = process.StandardError.ReadToEnd();

		}
		public void Run(string command, bool showWindow = false)
		{
			Process process = new Process
			{
				StartInfo = new ProcessStartInfo
				{
					FileName = "cmd.exe",
					UseShellExecute = false,
					Arguments = "/c" + command,
					CreateNoWindow = !showWindow,
					WorkingDirectory = WorkingDir ?? string.Empty
				}
			};

			process.Start();
			process.WaitForExit();
		}


	}
}
