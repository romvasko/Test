// See https://aka.ms/new-console-template for more information
string str = Console.ReadLine();
string[] str1;
str1 = str.Split(' ');
LongShort();
Palindrome();
Copy();
Dis();
void LongShort()
{
    
    //int strMin = str1[0].Length;
    //int strMax = str1[0].Length;
    string tempMin = str1[0];
    string tempMax = str1[0];
    for (int i = 0; i < str1.Length; i++)
    {
        if (str1[i].Length > tempMax.Length)
        {
            tempMax = str1[i];
        }
        if (str1[i].Length < tempMin.Length)
        {
            tempMin = str1[i];
        }
    }
    Console.WriteLine($"max word: {tempMax}, min word: {tempMin}");
}

void Palindrome()
{
   string temp1 = str1[0];
    char[] temp = str1[0].ToCharArray();
    Array.Reverse(temp);
    string temp2 = new string(temp) ;
    Console.WriteLine(temp2 + " " +temp2);
    if(temp1 == temp2)
    {
        Console.WriteLine($"word {str1[0]} is palindrome");
    }
    else
    {
        Console.WriteLine($"word {str1[0]} is not palindrome");
    }
}
void Copy()
{
    string temp = "";
    for(int i = 0; i < str.Length; i++)
    {
        if (Char.IsLetter(str[i]))
        {
            temp += str[i];
            temp += str[i];
        } else
        {
            temp += str[i];
        }
    }
    Console.WriteLine(temp);
}

void Dis()
{
    int temp = str1[0].Distinct().Count();
    string temp2 = str1[0];
    foreach(string str2 in str1)
    {
        int temp1 = str2.Distinct().Count();

        if (temp>temp1)
        {
            temp2 = str2;
        }
    }
    Console.WriteLine(temp2);
}