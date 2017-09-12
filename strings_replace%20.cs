
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text;
using System.Collections;
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
string s1 = "swathiii is ok";
string[] s2 = s1.Split();
StringBuilder sent = new StringBuilder(s2[0]);
for(int i=1; i<s2.Length; ++i)
{
sent.Append("%20");
sent.Append(s2[i]);
　
}
Console.WriteLine(sent.ToString());
}
}
}
Output
swathiii%20is%20ok

Time complexity is O(n)
Space complexity is O(n)



