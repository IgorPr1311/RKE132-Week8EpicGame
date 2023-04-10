using System.Runtime.CompilerServices;

string path = @"C:\Users\Igor\Desktop\Data2";
string fileName = "chuck.txt";
string[] lines = File.ReadAllLines(Path.Combine(path, fileName));

ShowFileContent();

static int ShowFileContent(string[] fileContentArray) 
{
    int i = 0;
    foreach(CallerLineNumberAttribute in fileContentArray);
}