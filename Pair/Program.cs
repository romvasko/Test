// See https://aka.ms/new-console-template for more information




using Pair;
using System.Text;

var clothes1 = new Jacket() { Cost = "10000", Size = 26 };
var clothes2 = new T_shirt() { Cost = "9100", Size = 28 };
var clothes3 = new T_shirt() { Cost = "820", Size = 29 };
var clothes4 = new Jacket() { Cost = "9300", Size = 30 };
var clothes5 = new T_shirt() { Cost = "9400", Size = 28 };
var clothes6 = new T_shirt() { Cost = "9500", Size = 28 };

Magazine list = new Magazine();
Console.WriteLine(list.AddClothes(clothes1));
Console.WriteLine(list.AddClothes(clothes2)); 
Console.WriteLine(list.AddClothes(clothes3));
Console.WriteLine(list.AddClothes(clothes4));
Console.WriteLine(list.AddClothes(clothes5));
Console.WriteLine(list.AddClothes(clothes6));

Console.WriteLine(list.UpdateClothes(clothes1, "1000000"));

Console.WriteLine(list.DeleteClothes(clothes6));

Console.WriteLine(list.GetPopular());
Console.WriteLine(list.GetAllClothes());
public class Magazine
{
    List<Clothes> clothes = new List<Clothes>();

    public string AddClothes(Clothes clothes)
    {
        this.clothes.Add(clothes);
        return $"Clothe added: {clothes.GetInfo()}";
    }
    public string DeleteClothes(Clothes clothes)
    {
        this.clothes.Remove(clothes);
        return $"Clothe deleted: {clothes.GetInfo()}";
    }

    public string UpdateClothes(Clothes clothes, string newValue)
    {
        int i = this.clothes.IndexOf(clothes);
        this.clothes[i].UpdateCost(newValue);
        return $"Clothe updated: {this.clothes[i].GetInfo()}";
    }

    public string GetPopular()
    {
        int[] array = new int[this.clothes.Count];
        int i = 0;
        foreach (var ch in this.clothes)
        {
            array[i] = ch.Size;
            i++;
        }
        var result = array.GroupBy(x => x).OrderByDescending(x => x.Count()).FirstOrDefault().Key;
        return $"Most popular size : {result}\n";
    }
    public string GetAllClothes()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("List of all clothes:\n");
        foreach (var ch in this.clothes)
        {
           sb.Append(ch.GetInfo());
        }
        return sb.ToString();
    }
}
