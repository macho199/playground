// See https://aka.ms/new-console-template for more information
using DotnetConsoleApp1;
using System.Text.RegularExpressions;

Console.WriteLine("Hello, World!");

//string[] a = ["aaa", "bbb"]; // .net 8의 c# 12 에서 새로 작성하는 리터럴 방식
string[] a = { "aaa", "bbb" }; // 전통 방식

string[] b = new[] { "cc" };

Console.WriteLine(string.Join("|", a));


List<string> bb = new();
bb.Add("ccc");
bb.Add("ddd");

Console.WriteLine(string.Join("|", bb));

string[] ccc = {"kk", "uu"};
Console.WriteLine(string.Join("|", ccc));

string input = "~!@#$%^&*()_+-=`";
string pattern = @"([\uD800-\uDBFF][\uDC00-\uDFFF])|([\u2600-\u26FF])|([\u2700-\u27BF])|([\u200D])|([\uFE0F])|([\p{Cs}\p{So}\p{Cn}\p{Co}\p{Sk}])";
input = Regex.Replace(input, pattern, String.Empty);

Console.WriteLine(input);

