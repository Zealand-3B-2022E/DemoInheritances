// See https://aka.ms/new-console-template for more information
using DemoInheritances;

Console.WriteLine("Hello, World!");

//var baseclass = new baseclass("mybaseprop");

//Console.WriteLine( baseclass.MyBaseMethod());

var specialized = new mySpecializedClass("myspecprop");

Console.WriteLine(specialized.MyBaseMethod());
