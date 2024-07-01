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
//string pattern = @"([\uD800-\uDBFF][\uDC00-\uDFFF])|([\u2600-\u26FF])|([\u2700-\u27BF])|([\u200D])|([\uFE0F])|([\p{Cs}\p{So}\p{Cn}\p{Co}\p{Sk}])";
// 모든 이모지, 특수 문자, ZWJ 시퀀스를 제거하는 정규 표현식 패턴 (단, ^는 제외)
//string pattern = @"([\uD800-\uDBFF][\uDC00-\uDFFF])|([\u2600-\u26FF])|([\u2700-\u27BF])|([\u200D])|([\uFE0F])|([\p{Cs}\p{So}\p{Cn}\p{Co}\p{Sk}]|[^\x00-\x7F&&[^\^]])";
//input = Regex.Replace(input, pattern, String.Empty);

// 이모지 및 특수 문자 제거 패턴 (단, ^는 제외)
//string pattern = @"([\uD800-\uDBFF][\uDC00-\uDFFF])|([\u2600-\u26FF])|([\u2700-\u27BF])|([\u200D])|([\uFE0F])|([\p{Cs}\p{So}\p{Cn}\p{Co}\p{Sk}])";
// 특수 문자 범위에서 ^를 제외한 문자 제거
//string specialPattern = @"[^\x00-\x7F^\^]";
//string result = Regex.Replace(input, pattern, String.Empty);
//result = Regex.Replace(result, specialPattern, String.Empty);

// 이모지 및 특수 문자 제거 패턴 (단, ^는 제외)
       // \u200D와 \uFE0F는 Zero Width Joiner 및 Variation Selector
       // Cs, So, Cn, Co, Sk는 이모지 및 심볼 관련 유니코드 카테고리
       string pattern = @"([\uD800-\uDBFF][\uDC00-\uDFFF])|([\u2600-\u26FF])|([\u2700-\u27BF])|([\u200D])|([\uFE0F])|([^\x00-\x7F&&[^\^]])";
       // 유니코드 블록 또는 범위를 포함하는 모든 문자 제거
       string result = Regex.Replace(input, pattern, String.Empty);

Console.WriteLine(result);

