namespace KarenLogic {
  public class Store {
    private Karen karen;
    private bool containsOwner;
    private int GameScore;
    private int Dmg;

    public Store(Karen karen) {
      this.karen = karen;
      this.GameScore = 0;
      this.Dmg = 1;
    }

    public void ActivateTheKaren() {
        if (!karen.IsPresent)
            karen.Appear();
    }

    public void OwnerWalksIn() {
      containsOwner = true;
    }

    public void ResetOwner() {
      containsOwner = false;
    }

    public void Update()
    {
        if (karen.IsPresent && containsOwner)
            karen.Damage(Dmg);
        if (Game.Score >= this.GameScore + 10)
            this.Dmg++;
            this.GameScore = Game.Score;
    }
  }
}
