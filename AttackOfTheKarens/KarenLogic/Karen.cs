using System.Linq;
using System.Windows.Forms;

namespace KarenLogic {
  /// <summary>
  /// TODO: write a comment here
  /// </summary>
  public class Karen {
    /// <summary>
    /// The pixel location of the row Karen is on
    /// </summary>
    public int Row { get; set; }
    public int Col { get; set; }
    public int DefaultHealth { get; private set; }
    public int CurrHealth { get; private set; }
    public bool IsPresent { get; private set; }

    /// <summary>
    /// This is the image of Karen
    /// </summary>
    public PictureBox pic;
    public ProgressBar progbar;
    public Label label;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="pic">The PictureBox container for Karen</param>
        /// <param name="progbar"></param>
        /// <param name="label"></param>

    public Karen(PictureBox pic, ProgressBar progbar, Label label) { 
      this.DefaultHealth = 10;
      this.pic = pic;
      this.pic.Visible = false;
      this.progbar = progbar;
      this.progbar.Visible = false;
      this.label = label;
      this.label.Visible = false;
      this.IsPresent = false;
      }

    public void Appear() {
      this.CurrHealth = this.DefaultHealth;
      this.progbar.Maximum = this.CurrHealth;
      this.progbar.Value = this.CurrHealth;
      this.label.Text = this.CurrHealth.ToString();
      this.pic.Visible = true;
      this.progbar.Visible = true;
      this.label.Visible = true;
      this.IsPresent = true;
      this.label.BringToFront();
      this.progbar.BringToFront();
      this.pic.BringToFront();
    }

    public void Damage(int amount) {
      CurrHealth -= amount;
      if (CurrHealth <= 0) {
        if (Game.KarensOffended > 10)
            Game.AddToScore(10);
        else if (Game.KarensOffended > 50)
            Game.AddToScore(20);
        else 
            Game.AddToScore(5);
        this.pic.Visible = false;
        this.IsPresent = false;
        this.progbar.Visible = false;
        this.label.Visible = false;
        this.CurrHealth = this.DefaultHealth+10;
        this.DefaultHealth = this.CurrHealth;
        this.progbar.Maximum = this.CurrHealth;
      }
      this.progbar.Value = this.CurrHealth;
      this.label.Text = this.CurrHealth.ToString();
    }
  }
}
