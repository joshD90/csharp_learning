
// See https://aka.ms/new-console-template for more information


//literal vs verbatim
//literal strings include escaped sequences, a verbatim string will not - verbatim = @"something something"


//we see that even though strings are objects and are stored by reference, they are still immutable meaning
//that every time a string is changed, it now occupies a new position in memory and the old address is disposed of
//by the garbage collector
using System.Text;

string s1 = "hello";
string s2 = s1;
s1 += "world";
Console.WriteLine(s2);
Console.WriteLine(s1);

//string interpolation and composit formatting
string firstName = "Joshua";
string lastName = "Dancey";

//string interpolation is like template literals in js
Console.WriteLine($"My Name is {firstName} {lastName}");


//composite formatting - works a little by like mysql2
Console.WriteLine("My name is {0} {1}",firstName, lastName);

//String Builder
//if you are performing thousands of iterations on a list or array of strings
var sb = new StringBuilder();

var newString = sb.Append(firstName);
Console.WriteLine(newString);

StringBuilder sb1 = new StringBuilder();
string baseString = "Hello ";

for (int i = 0; i < 1000; i++)
{
    sb1.Append(baseString);
}

Console.WriteLine(sb.ToString());
