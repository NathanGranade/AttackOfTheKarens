using System.Collections.Generic;
using System.Windows.Forms;

namespace KarenLogic
{
    public static class Game
    {
        public static int Score { get; set; }
        public static int Level { get; set; }
        public static int KarensOffended { get; set; }
        public static int KarenWorth { get; set; }
        public static int Dmg { get; set; }
        public static int DmgUpgrade { get; set; }
        public static int MoneyUpgrade { get; set; }
        public static List<Form> openForms;

        static Game()
        {
            openForms = new List<Form>();
            KarenWorth = 5;
            Dmg = 1;
            MoneyUpgrade = 20;
            DmgUpgrade = 10;
        }

        public static void AddToScore(int amount)
        {
            Score += amount;
            KarensOffended += 1;
        }
        // Added by Jakira Williams
        // Level increment
        public static void AddToLevel(int LevelUp)
        {
            Level += LevelUp;
        }
        public static void CloseAll()
        {
            for (int i = 0; i < openForms.Count; i++)
            {
                openForms[i].Close();
            }
        }
    }
}
