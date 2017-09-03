
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
int[] arr = { 4, 3, 2,1,3 };
int x = 1;
Hashtable ht = new Hashtable();
for(int i=0; i<arr.Length;i++)
{
if (!ht.Contains(arr[i]))
{
ht.Add(arr[i], 0);
}
}
foreach(var k in ht.Keys)
{
Console.WriteLine(k);
}
}
}
}

Time complexity is O(n)
Space complexity is O(1).


