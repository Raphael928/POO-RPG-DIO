
namespace game_rpg_dio.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string pName, int pLevel, string pHeroType) : base(pName, pLevel, pHeroType)
        {
            this.Name = pName;
            this.Level = pLevel;
            this.HeroType = pHeroType;
        }

        public override string Attak()
        {
            return this.Name + " Lançou magia!";
        }

        public string Attak(int pBonus)
        {
            if (pBonus > 6)
                return this.Name + " Lançou uma super magia, com bonus de " + pBonus;
            else
                return this.Name + " Lançou magia, com bonus de " + pBonus;
        }
    }
}