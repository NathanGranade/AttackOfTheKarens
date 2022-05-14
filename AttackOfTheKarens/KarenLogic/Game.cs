using System.Collections.Generic;
using System.Windows.Forms;

namespace KarenLogic {
  public static class Game {
    public static int Score { get; set; }
    public static int KarensOffended { get; set; }
    public static List<Form> openForms;

    static Game() {
      openForms = new List<Form>(); 
    }

    public static void AddToScore(int amount) {
      Score += amount;
      KarensOffended += 1;
    }

    public static void CloseAll() {
      for (int i = 0; i < openForms.Count; i++) {
        openForms[i].Close();
      }
    }
  }
}
