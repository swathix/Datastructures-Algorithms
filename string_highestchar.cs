ing System;
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
string str = "swataaaahi";
int i;
int count=0;
Dictionary<char, int> dict = new Dictionary<char, int>();
foreach (char c in str)
{
dict.TryGetValue(c, out i);
i++;
if (i > count)
{
count = i;
}
dict[c] = i;
}
foreach (KeyValuePair<char, int> chars in dict)
{
if (chars.Value == count)
{
Console.WriteLine("{0} {1}", chars.Key, chars.Value);
}
　
}
　
}
}
}






