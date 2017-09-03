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
int[] arr = {12,3,5,7,19};
int m1=0, m2=0;
foreach(int n in arr)
{
if(m1<n)
{
m2 = m1;
m1 = n;
}
else if(m2<n)
{
m2 = n;
}
}
Console.WriteLine(m1);
Console.WriteLine(m2);
}
}
}
Output
19
12



Time complexity is O(n)
Space complexity is O(n)




