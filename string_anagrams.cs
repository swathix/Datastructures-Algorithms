

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
namespace array
{
static class Program
{
/// <summary>
/// The main entry point for the application.
/// </summary>
[STAThread]
static void Main()
{
Application.EnableVisualStyles();
Application.SetCompatibleTextRenderingDefault(false);
Application.Run(new Form1());
string str = "swathi";
string str1 = "wathis";
char[] s1=str.ToLower().ToCharArray(); //converting to character array
char[] s2=str1.ToLower().ToCharArray();
Array.Sort(s1); //sort
Array.Sort(s2);
if (s1.Length == s2.Length) //if both the strings are of same length and words after sorting
{
Console.WriteLine("The words are anagrams");
}
else
Console.WriteLine("Not anagrams");
　
}
}
}
//the same words and length of two strings should be same to say that those are anagrams.
//Time complexity is O(n), space complexity is O(1).



