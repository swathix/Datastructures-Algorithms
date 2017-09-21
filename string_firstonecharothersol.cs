
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
string str = "swataahi";
int x = 1;
Hashtable ht = new Hashtable();
for(int i=0; i<str.Length; i++)
{
if (!ht.Contains(str[i]))
{
ht.Add(str[i], 1);
}
else
ht[str[i]] = (int)ht[str[i]] + 1;
}
foreach(var m in ht.Keys)
{
if(x==(int)ht[m])
{
Console.WriteLine(m);
}
}
}
}
}
　
Time Complexity O(n)
Space complexity is O(1).


