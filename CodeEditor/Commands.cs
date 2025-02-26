using System.Text;
using System.Windows.Input;

namespace CodeEditor
{
	static class Commands
	{
		public static readonly string PING_GOOGLE = "ping google.com";
		public static readonly string GPP = "g++";
		public static readonly string SPACE = " ";
		public static readonly string DOT_EXE = ".exe";
		public static readonly string DOT_CPP = ".cpp";
		public static string CreateCompileCommand(string fileName)
		{
			return
				new StringBuilder()
				.Append(GPP)
				.Append(SPACE)
				.Append("-o")
				.Append(SPACE)
				.Append(fileName)
				.Append(DOT_EXE)
				.Append(SPACE)
				.Append(fileName)
				.Append(DOT_CPP)
				.ToString();
		}
		public static string CreateRunCommand(string fileName)
		{
			return
				new StringBuilder()
				.Append(fileName)
				.ToString();
		}
	}
}
