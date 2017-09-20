
ing System;
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
string str = "swathiaa";
int vowels=0, cons=0;
for(int i=0; i<str.Length; i++)
{
if(str[i]=='a'||str[i]=='e'||str[i]=='i'||str[i]=='0'||str[i]=='u')
{
vowels++;
}
else
cons++;
}
Console.WriteLine("vowels are {0} consonants are {1}", vowels, cons);
　
}
}
}
　
Time complexity is O(n)
Space complexity is O(1).




