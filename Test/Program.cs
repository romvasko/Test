// See https://aka.ms/new-console-template for more information
Console.WriteLine("false false " + Arrow(false,false));
Console.WriteLine("true false  " + Arrow(false,true));
Console.WriteLine("false true  " + Arrow(true,false));
Console.WriteLine("true  true  " + Arrow(true,true));  

bool Arrow(bool x, bool y)
{ 
    return x==false && y==false? true: false;

}