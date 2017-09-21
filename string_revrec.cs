namespace stringsample
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
// Application.Run(new Form1());
　
Console.WriteLine( Program.reversewords("This is swathi"));
}
public static string reversewords(string sentence) //pass the string
{
string output = string.Empty; //taking output and word as of now empty
string word = string.Empty;
foreach(char c in sentence) // This is sentence c=t,h,i,s  i, s s, w,a, t, h,i
{
if (c == ' ') //jumps here //jumps here  this  1st jump  is  2nd jump
{
output = word + ' ' + output; //output=this (bcz word contains this) //output =is This
word = string.Empty; //this //is
}
else
{
word = word + c; //jumps here the value of c is t , th, thi,this i, is, s,sw,swa,swat,swath,swathi
//by this time it has only swathi
}
}
output = word + ' ' + output; // swathi(word) this is (from output)
return output;
}
　
}
}





