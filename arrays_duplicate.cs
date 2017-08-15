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
int[] arr = { 1, 2, 3, 4, 5 ,4, 5}; //taken an integer array
Dictionary<int,int> dic=new Dictionary<int,int>(); //created a new dictionary
foreach (var num in arr) //for each number in array
{
if (!dic.ContainsKey(num)) //Checking whether it is present in dictinoary or not if not add it as a key and value is set to 0
{
dic.Add(num, 0);
}
dic[num]++; //if same number comes again as it is present in dictionary increase the value to 1
}
foreach(var val in dic) //for the value present in dictionary get the key and value of it to find the duplicate number
{
Console.WriteLine("{0} repeat times {1}", val.Key, val.Value);
if(val.Value>1)
{
Console.WriteLine( "duplicate numbers are {0}", val.Key);
}

}
}
}
}



