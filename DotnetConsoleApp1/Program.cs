// See https://aka.ms/new-console-template for more information
using DotnetConsoleApp1;

Console.WriteLine("Hello, World!");

string[] a = ["asdf"];

Console.WriteLine(a[0]);

var hong = new Person();
hong.Id = 1;
hong.Name = "honggildong";


var jong = hong;
jong.Id = 2;
jong.Name = "jongseong";

Console.WriteLine($"hong: {nameof(hong.Id)}: {hong.Id}, {nameof(hong.Name)}: {hong.Name}");