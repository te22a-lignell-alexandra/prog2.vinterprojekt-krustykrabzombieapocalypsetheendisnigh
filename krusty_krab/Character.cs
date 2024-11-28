using System.ComponentModel.Design;
using System.Security.Authentication;

public class Character
{
    private string name;
    private int hp;
    private int currentHp;
    private int infectionLevel;
    private int hit;
    private int dodge;
    public Character(string Name, int Hp, int InfectionLevel, int Hit, int Dodge)
    {
        name = Name;
        hp = Hp;
        infectionLevel = InfectionLevel;
        hit = Hit;
        dodge = Dodge;
        currentHp = hp;

    }
    public int Attack(int charType, int dodge)
    {
        int Hit = Random.Shared.Next(0, hit);
        int Dodge = Random.Shared.Next(0, dodge);

        if (Hit > Dodge) 
        {
            if (charType == 1)
            {
                return GetDamage();
            }
        }
        else return 3;
    }
    public int GetDodge()
    {
        return dodge;
    }
    public int GetCurrentHp()
    {
        return currentHp;
    }
    public int GetInfectionLevel()
    {
        return infectionLevel;
    }
    public string GetName()
    {
        return name;
    }
}
