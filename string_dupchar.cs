
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
string str = "swathiaa";
Dictionary<char, int> dic = new Dictionary<char, int>();
foreach (char m in str)
{
if (!dic.ContainsKey(m))
{
dic.Add(m, 0);
}
dic[m]++;
}
foreach (var val in dic)
{
　
if (val.Value > 1)
{
Console.WriteLine("duplicate characters are {0}", val.Key);
}
　
　
}
}
}
}


Time complexity is O(n)
Space complexity is O(1).




