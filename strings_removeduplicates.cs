using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
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
string s1 = "swathiii";
Hashtable ht = new Hashtable();
for(int i=0; i<s1.Length; i++)
{
if(!ht.Contains(s1[i]))
{
ht.Add(s1[i], 1);
}
}
foreach(var m in ht.Keys)
{
Console.WriteLine(m);
}
}
}
}

Time complexity is O(n)
Space complexity is O(1)
Output
T
S
A
I
H
w



