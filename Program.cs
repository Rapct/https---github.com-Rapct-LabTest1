
using static System.Console;
Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, Mengtian Lin");
Console.WriteLine("Version: {0}", Environment.Version.ToString());

string text = System.IO.File.ReadAllText("text.txt");
Console.WriteLine(text);
