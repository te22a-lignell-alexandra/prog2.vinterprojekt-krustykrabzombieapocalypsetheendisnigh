public class Character
{
    private string name;
    private int hp;
    private int currentHp;
    private int infectionLevel;
    private int hit;
    private int dodge;
    public Character(string Name, int Hp)
    {
        name = Name;
        hp = Hp;
        currentHp = hp;
    }
    public bool Attack(int hit, int dodge)
    {
        bool success;
        int Hit = Random.Shared.Next(0, hit);
        int Dodge = Random.Shared.Next(0, dodge);
        
        if (Hit > Dodge) return success = true;
        else return success = false;
    }
}
