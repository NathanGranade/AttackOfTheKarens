namespace KarenLogic
{
    public class Store
    {
        private Karen karen;
        private bool containsOwner;
        private float LevelScore;
        private float Lvl;

        public Store(Karen karen)
        {
            this.karen = karen;
            this.LevelScore = 0;
            this.Lvl = 0;
        }

        public void ActivateTheKaren()
        {
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
                karen.Damage(1);
                karen.LvlUp((int)Lvl);
                if (Game.Score >= this.LevelScore + 5)
                    this.Lvl++;
                LevelScore = Game.Score;
            }
        }
    }
}
