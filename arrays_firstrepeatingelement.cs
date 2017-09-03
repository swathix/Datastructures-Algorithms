
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
int min=-1;
Hashtable ht = new Hashtable();
for(int i=arr.Length-1; i>=0;i--)
{
if (ht.Contains(arr[i]))
min = i;
else
ht.Add(arr[i], 1);
}
if (min != -1)
Console.WriteLine(arr[min]);
else
Console.WriteLine("No repeating elements");
　
}
}
}

Time complexity is O(n)
Space complexity is O(1).





