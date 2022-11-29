// 'Hello' with 'if' and 'else'
Console.Write("Enter Username ");
string username = Console.ReadLine()!;
if(username.ToLower() == "masha") //ToLower() - convert username to lower font
{
    Console.WriteLine("Hello, This Masha!!");
}
else
{
    Console.Write("Hello,");
    Console.WriteLine(username);
}