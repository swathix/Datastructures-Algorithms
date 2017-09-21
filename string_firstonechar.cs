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
string str = "swataahi";
bool dup;
for(int i=0; i<str.Length;i++)
{
dup = false;
for(int j=0; j<str.Length; j++)
{
if((str[i]==str[j])&&i!=j)
{
dup = true;
break;
}
}
if(!dup)
{
Console.WriteLine(str[i]);
}
}
}
}
}

Timecomplexity is O(n2)
Space complexity is O(n).



