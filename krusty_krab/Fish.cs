public class Fish : Character
{
    public Fish(string Name, int Hp, int InfectionLevel, int Hit, int Dodge) : base(Name, Hp, InfectionLevel, Hit, Dodge)
    {}
    public int Infect()
    {
        int infectionDamage = Random.Shared.Next(GetInfectionLevel());
        return infectionDamage;
    }
}
