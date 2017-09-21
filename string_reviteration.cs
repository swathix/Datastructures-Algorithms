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
for (int k = str.Length - 1; k >= 0; k--)
{
Console.Write(str[k] );
}
}
}
}
　
Time complexity is O(n).
Space complexity is O(1).


