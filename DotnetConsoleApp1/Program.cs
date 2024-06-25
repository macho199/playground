// See https://aka.ms/new-console-template for more information
using DotnetConsoleApp1;

Console.WriteLine("Hello, World!");

//string[] a = ["aaa", "bbb"];
string[] a = { "aaa", "bbb" };

Console.WriteLine(string.Join("|", a));


List<string> bb = new();
bb.Add("ccc");
bb.Add("ddd");

Console.WriteLine(string.Join("|", bb));