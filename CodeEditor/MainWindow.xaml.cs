using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CodeEditor;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }



		string dir = @"C:\Users\harjo\OneDrive\Desktop\CodeEditor";
		string filename = "main";
	private void OnBtnClicked_Compile(object sender, RoutedEventArgs e)
	{
		//Create a file

		string filePath = System.IO.Path.Combine(dir, filename + Commands.DOT_CPP);


		File.WriteAllText(filePath, tb_code.Text);


		//Run Command
		CmdRunner cmdRunner = new CmdRunner(dir);
		string output, error;

		//compile code
		string command = Commands.CreateCompileCommand(filename);
		cmdRunner.Run(command, out output, out error);

		lbl_logs.Text = $"{error??""}";



	}

	private void OnBtnClicked_Run(object sender, RoutedEventArgs e)
	{
		//Run Command
		CmdRunner cmdRunner = new CmdRunner(dir);
		string output, error;

		
		//run code
		string command = Commands.CreateRunCommand(filename);
		command = "run.bat";
		cmdRunner.Run(command, true );


	}


	private void tb_code_TextChanged(object sender, TextChangedEventArgs e)
	{

	}
}