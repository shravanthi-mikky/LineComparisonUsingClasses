// See https://aka.ms/new-console-template for more information
using LineComparison_Using_Classes;
/*
Console.WriteLine("Welcome To Line COmparison Using Classes and Methods!");
Console.WriteLine("Please Enter x1 and y1 coordinates ");
var x1 = Convert.ToDouble(Console.ReadLine());
var y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Please Enter x2 and y2 coordinates ");
var x2 = Convert.ToDouble(Console.ReadLine());
var y2 = Convert.ToDouble(Console.ReadLine());
*/

UC1 uc1 = new();

double x1 = uc1.Input();
double x2 = uc1.Input();
double y1 = uc1.Input();
double y2 = uc1.Input();
double finalResult = uc1.Distance(x1, x2, y1, y2);
Console.WriteLine("Distance between {0},{1} and {2},{3} is {4:F}", x1, y1, x2, y2, finalResult);