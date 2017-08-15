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
int[] arr = { 1, 2, 4, 6 }; //taken an integer array
int sum = 6;
int res;
for (int i = 0; i < arr.Length; i++)
{
for (int j = i + 1; j < arr.Length; j++)
{
res = arr[i] + arr[j];
if (sum == res)
{
Console.WriteLine("{0} {1}", arr[i], arr[j]);
}
}
}
}
}
}






