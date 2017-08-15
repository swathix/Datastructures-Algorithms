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
int[] arr = { 1, 2,3, 4,3, 6 }; //taken an integer array
Hashtable ht=new Hashtable();
for (int i = 0; i < arr.Length; i++)
{
if (!ht.Contains(arr[i]))
{
ht.Add(arr[i], 0);
}
}
foreach (int m in ht.Keys)
{
Console.WriteLine(m);
}
}
}
}

B

