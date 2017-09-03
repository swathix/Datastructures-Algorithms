
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
int[] arr = { 1, 2, -1, 3, 4, 3, 5 };
int sum = 0;
for(int i =0; i<arr.Length; i++)
{
for(int j=i+1; j<arr.Length-1; j++)
{
if(arr[i]+arr[j]==sum)
{
Console.WriteLine("{0} {1}", arr[i], arr[j]);
}
　
}
}
Console.WriteLine("Not equal");
}
}
}

Time complexity is O(n2)
Space complexity is O(n)--input is not constant



