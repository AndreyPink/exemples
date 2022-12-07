//=====Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы “к” заменить большими “К”,
// а большие “С” маленькими “с”.
// Ясна ли задача?

string text = "— Я думаю, — сказал князь, улыбаясь,"
 +"— что,ежели бы вас послали вместо нашего милого Винценгероде,"
  +"вы бы взяли приступом согласие прусского короля."
  +"Вы так красноречивы. Вы дадите мне чаю?";

string Replace(string str, char oldValue, char newValue)
{
string result = String.Empty;
int length = str.Length;
for(int i = 0; i < length; i++)
{
    if(str[i] == oldValue) result += $"{newValue}"; 
    else result += $"{str[i]}";
}
return result;
}

string newText = Replace(text, ' ', '|');
newText = Replace(newText, 'к', 'К');
newText = Replace(newText, 'С', 'с');
Console.WriteLine(newText);


//    text = text.Replace(" ", "_");
//    text = text.Replace("к", "К");
//    text = text.Replace("С", "с");
// Console.WriteLine(text);


