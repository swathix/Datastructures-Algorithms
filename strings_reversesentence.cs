using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace hack
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
string s1 = "This is swathi";
string[] s2 = s1.Split();
for(int m=s2.Length-1; m>=0; m--)
{
Console.WriteLine(s2[m]);
}
}
}
}

Time complexity is O(n)
Space complexity is O(1)---i/p is constant.


o/p

Swathi
Is
This


