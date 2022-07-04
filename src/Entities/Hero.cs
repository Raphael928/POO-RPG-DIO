namespace game_rpg_dio.src.Entities
{
    public abstract class Hero
    {
        public Hero(string pName, int pLevel, string pHeroType)
        {
            this.Name = pName;
            this.Level = pLevel;
            this.HeroType = pHeroType;
        }

        public string Name { get; set; }
        public int Level { get; set; }

        public string HeroType { get; set; }

        public override string ToString()
        {
            return "Name: " + this.Name + "\n" +
                   "Lvl: " + this.Level + "\n" +
                   "Hero Type: " + this.HeroType + "\n";
        }

        public virtual string Attak()
        {
            return this.Name + "Atacou com a Espada";
        }
    }
}