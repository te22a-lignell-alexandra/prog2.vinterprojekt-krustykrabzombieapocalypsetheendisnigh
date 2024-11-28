using System.Runtime.InteropServices;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;

public class Gary : Character
{
    private int charType = 1;
    private int damage = 0;
    private bool missionComplete = false;
    private List<Item> inventory = new ();
    public Gary(string Name, int Hp, int InfectionLevel, int Hit, int Dodge) : base(Name, Hp, InfectionLevel, Hit, Dodge) 
    {}
    public void AddToInventory(Item coolStuff)
    {
        inventory.Add(coolStuff);
    }a
    public void GetInventory()
    {
        for (int i = 0; i < inventory.Count; i++)
        {
            System.Console.WriteLine(inventory[i-1]);
        }
    }
    public int GetType()
    {
        return charType;
    }
    public int GetDamage()
    {
        return damage;
    }
    public string Death(int currentHp, int infectionLevel)
    {
        if (currentHp <= 0)
        {
            return "you die by hurt";
        }
        if (infectionLevel <= 10)
        {
            return "zombie gary";
        }
        else return "?";
    }
    public string Win()
    {
        if (missionComplete == true) 
        {
            return "you win :D";
        }
        else return "?";
    }
}
