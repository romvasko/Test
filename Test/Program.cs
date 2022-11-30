// See https://aka.ms/new-console-template for more information
Console.WriteLine("false false " + Arrow(false,false));
Console.WriteLine("false true  " + Arrow(false,true));
Console.WriteLine("true  false " + Arrow(true,false));
Console.WriteLine("true  true  " + Arrow(true,true));  

bool Arrow(bool x, bool y)
{ 
    return !x & !y;

}