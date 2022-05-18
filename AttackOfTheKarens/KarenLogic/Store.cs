namespace KarenLogic
{
    public class Store
    {
        private Karen karen;
        private bool containsOwner;
        private int LevelScore;
        private int Lvl;
        private int GameScore;

        public Store(Karen karen)
        {
            this.karen = karen;
            this.LevelScore = 0;
            this.Lvl = 0;
            this.GameScore = 0;
        }

        public void ActivateTheKaren()
        {
            if (!karen.IsPresent)
                karen.Appear();
        }

        public void OwnerWalksIn()
        {
            containsOwner = true;
        }

        public void ResetOwner()
        {
            containsOwner = false;
        }

        public void Update()
        {
            if (karen.IsPresent && containsOwner)
            {
                karen.Damage(Game.Dmg);
                karen.LvlUp(Lvl);
                Game.Level++;
                this.GameScore = Game.Score;
                LevelScore = Game.Score;
            }
        }

        public void TempUpdate()
        {
            if (karen.IsPresent && containsOwner)
            {
                karen.Damage(Game.Dmg *2); 
                karen.LvlUp(Lvl);
                Game.Level++;
                this.GameScore = Game.Score;
                LevelScore = Game.Score;
            }
        }

        public void NukeAllKarens()
        {
            karen.KillAllKarens();
        }
    }
}
