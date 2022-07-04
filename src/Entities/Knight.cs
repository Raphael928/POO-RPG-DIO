namespace game_rpg_dio.src.Entities
{
    public class Knight : Hero
    {
        public Knight(string pName, int pLevel, string pHeroType) : base(pName, pLevel, pHeroType)
        {
            this.Name = pName;
            this.Level = pLevel;
            this.HeroType = pHeroType;
        }

        public override string ToString()
        {
            return "Name: " + this.Name + "\n" +
                   "Lvl: " + this.Level + "\n" +
                   "Hero Type: " + this.HeroType + "\n";
        }

        public override string Attak()
        {
            return this.Name + " Atacou com a Espada";
        }
    }
}