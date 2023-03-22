// See https://aka.ms/new-console-template for more information
namespace BossFight
{

    internal class Program
    {

        public static void Main(string[] args)
        {
            var hero = new Hero();
            var boss = new Boss();
            StartFight(boss, hero);
        }
        private static void StartFight(GameCharacter boss, GameCharacter hero)
        {
            bool fighting = true;

            while (fighting)
            {
                hero.Action(boss);
                fighting = boss.IsAlive();
                if (!fighting)
                {
                    break;
                }
                boss.Action(hero);
                fighting = hero.IsAlive();

            }
        }

    }



}
