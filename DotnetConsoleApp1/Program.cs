// See https://aka.ms/new-console-template for more information
using DotnetConsoleApp1;

Console.WriteLine("Hello, World!");

//string[] a = ["aaa", "bbb"]; // .net 8의 c# 12 에서 새로 작성하는 리터럴 방식
string[] a = { "aaa", "bbb" }; // 전통 방식

string[] b = new[] { "cc" };

Console.WriteLine(string.Join("|", a));


List<string> bb = new();
bb.Add("ccc");
bb.Add("ddd");

Console.WriteLine(string.Join("|", bb));