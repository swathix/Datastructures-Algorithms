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
　
int[] arr = { 1, 2, 1, 3, 4, 3, 5 };
bool dup;
for (int i = 0; i < arr.Length; i++)
{
dup = false;
for (int j = 0; j < arr.Length; j++)
{
if ((arr[i] == arr[j]) && i != j)
{
dup = true;
break;
}
}
if (!dup)
{
Console.WriteLine(arr[i]);
}
}
}
}
}

Time complexity is O(n2)
Space complexity is O(1).


B


