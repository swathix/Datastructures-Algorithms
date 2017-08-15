

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
int big = arr[0]; //assigning first element of array to big
int small = arr[0];//assigning first element of array to small too
for(int i=0; i<arr.Length; i++)//for all the elements in the array
{
if (arr[i] > big) //compare each element of array to big value
{
big = arr[i];//whenever the condition becomes true big value will be stored in big variable
}
else if (small < arr[i]) //same way compared to small value with array of value
small = arr[i]; //whenever condition becomes true the smallest value from array will be in small variable
}
Console.WriteLine("{0} {1}", big, small)//finally printing small and big values.
}
}
}





