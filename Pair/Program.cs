// See https://aka.ms/new-console-template for more information




using Pair;
using System.Text;

var clothes1 = new Jacket() { Cost = "10000", Size = 26 };
var clothes2 = new T_shirt() { Cost = "9100", Size = 28 };
var clothes3 = new T_shirt() { Cost = "820", Size = 29 };
var clothes4 = new Jacket() { Cost = "9300", Size = 30 };
var clothes5 = new T_shirt() { Cost = "9400", Size = 28 };
var clothes6 = new T_shirt() { Cost = "9500", Size = 28 };
var clothes7 = new T_shirt() { Cost = "9500000", Size = 280000 };

var list = new Magazine((x) => Console.WriteLine(x));
var mgView = new MagazineView();

list.OnStorageFull += (x) => Console.WriteLine(x);

list.AddClothes(clothes1);
list.AddClothes(clothes2); 
list.AddClothes(clothes3);
list.AddClothes(clothes4);
list.AddClothes(clothes5);
list.AddClothes(clothes6);

list.UpdateClothes(clothes1, "1000000");
list.UpdateClothes(clothes5, "1000000");

list.DeleteClothes(clothes2);
list.DeleteClothes(clothes7);

list.GetPopular();

list.GetAllClothes();

public class Magazine
{
    List<Clothes> clothes = new List<Clothes>();
    private Action<string> output;
    public event Action<string> OnStorageFull;
    public Magazine(Action<string> action) {
        output = action;
    }
    public void AddClothes(Clothes clothes)
    {
        try
        {     
            if (this.clothes.Count >= 2) { throw new OnStorageFullException("Storage is full"); }
            this.clothes.Add(clothes);
            output($"Clothe added: {clothes.GetInfo()}");
        }
        catch (OnStorageFullException ex)
        {
            OnStorageFull(ex.Message);
        }
    }
    public void DeleteClothes(Clothes clothes)
    {
        try
        {
            if (!this.clothes.Remove(clothes)) { throw new OnDeleteException($"Clothe not in the list: {clothes.GetInfo()}"); }
            
            output($"Clothe deleted: {clothes.GetInfo()}");
        }
        catch (OnDeleteException ex)
        {
            output(ex.Message);
        }
    }

    public void UpdateClothes(Clothes clothes, string newValue )
    {
        try
        {
            int i = this.clothes.IndexOf(clothes);
            if (i == -1) { throw new OnUpdateException($"Clothe not in the list: {clothes.GetInfo()} update failed"); }
            this.clothes[i].UpdateCost(newValue);
            output($"Clothe updated: {this.clothes[i].GetInfo()}");
        }
        catch (OnUpdateException ex)
        {
            output(ex.Message);
        }
    }

    public void GetPopular()
    {
        int[] array = new int[this.clothes.Count];
        int i = 0;
        foreach (var ch in this.clothes)
        {
            array[i] = ch.Size;
            i++;
        }
        var result = array.GroupBy(x => x).OrderByDescending(x => x.Count()).FirstOrDefault().Key;
        output($"Most popular size : {result}\n");
    }
    public void GetAllClothes()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("List of all clothes:\n");
        foreach (var ch in this.clothes)
        {
           sb.Append(ch.GetInfo());
        }
        output(sb.ToString());
    }

}
