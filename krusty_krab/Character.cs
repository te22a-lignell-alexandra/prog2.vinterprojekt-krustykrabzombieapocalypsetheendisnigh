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
    public bool Attack(int dodge)
    {
        bool success;
        int Hit = Random.Shared.Next(0, hit);
        int Dodge = Random.Shared.Next(0, dodge);

        if (Hit > Dodge) return success = true;
        else return success = false;
    }
}
