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
int longest=0;
for(int i=0; i<arr.Length; i++)
{
for(int j=i+1; j<arr.Length; j++)
{
if(Math.Abs(arr[j]-arr[j-1])==1)
{
if(j-i>longest)
{
longest = j - i;
}
}
else
{
break;
}
}
}
Console.WriteLine(longest + 1);
}
}
}

Output:3



