
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
int[] arr = {7,2,3,4,6,7};
for(int i=arr.Length-1; i>=0; i--)
{
Console.WriteLine(arr[i]);
}
}
}
}

o/p

7
6
4
3
2
7
Time complexity is O(n)
Space complexity is O(1).



