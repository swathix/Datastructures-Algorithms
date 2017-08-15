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
int[] arr = { 1,3, 3,2,4,4,6, 6 }; //taken an integer array
Dictionary<int, int> dic = new Dictionary<int, int>();
foreach(int i in arr)
{
if (dic.ContainsKey(i))
{
dic[i] = dic[i] + 1;
}
else
dic.Add(i, 1);
}
foreach (var m in dic)
{
if(m.Value%2==1)
Console.WriteLine(m);
}
}
}
}


