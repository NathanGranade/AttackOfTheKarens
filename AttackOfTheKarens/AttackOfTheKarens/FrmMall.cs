using KarenLogic;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Windows.Forms;
using System.Diagnostics;

namespace AttackOfTheKarens
{
    public partial class FrmMall : Form
    {
        // consts
        private const int PANEL_PADDING = 10;
        private const int FORM_PADDING = 60;
        private const int CELL_SIZE = 64;
        private readonly Random rand = new Random();
        private readonly Color[] colors = new Color[5] { Color.Red, Color.Green, Color.Blue, Color.Orange, Color.Yellow };

        // other privates
        private SoundPlayer player;
        private PictureBox picOwner;
        private int xOwner;
        private int yOwner;
        private char[][] map;
        private List<Store> stores;
        private bool button3Clicked;
        private bool button4Clicked;
        private bool button5Clicked;
        private Stopwatch timer = new Stopwatch();
        //added by Steve Baldwin
        string fileContents = File.ReadAllText("data/mall.txt");
        //will need later to determine maps
        enum Map
        {
            map,
            map1,
            map2,
            map3,
        }
        // sets the curent map to the first map
        Map current = Map.map;
        // ctor
        public FrmMall()
        {
            Game.openForms.Add(this);
            InitializeComponent();
        }

        // functions
        private void LoadMap(string x)
        {
            string[] lines = fileContents.Split(Environment.NewLine);
            map = new char[lines.Length][];
            for (int i = 0; i < lines.Length; i++)
            {
                map[i] = lines[i].ToCharArray();
            }
        }

        private PictureBox CreatePic(Image img, int top, int left)
        {
            return new PictureBox()
            {
                Image = img,
                Top = top,
                Left = left,
                Width = CELL_SIZE,
                Height = CELL_SIZE,
            };
        }
        // Added by Nathan Granade
        // Creates a progress bar to emulate a Karen health bar
        private ProgressBar CreateProgbar(int value, int top, int left)
        {
            return new ProgressBar()
            {
                Value = value,
                Top = top,
                Left = left,
                Maximum = value,
                Minimum = 0,
            };
        }

        // Added by Nathan Granade
        // Creates a label for Karen health
        private Label CreateLabel(string text, int top, int left)
        {
            return new Label()
            {
                Text = text,
                Top = top,
                Left = left,
                BackColor = Color.Transparent,
                ForeColor = Color.White,
                Font = new Font("ComicSans", 12, FontStyle.Bold)
            };
        }
        private PictureBox CreateWall(Color color, Image img, int top, int left)
        {
            PictureBox picWall = CreatePic(img, top, left);
            picWall.Image.Tint(color);
            return picWall;
        }

        private void GenerateMall(Color color)
        {
            panMall.Controls.Clear();
            int top = 0;
            int left = 0;

            PictureBox pic = null;
            ProgressBar progbar = null;
            Label label = null;
            foreach (char[] array in map)
            {
                foreach (char c in array)
                {
                    switch (c)
                    {
                        case 'K':
                            pic = CreatePic(Properties.Resources.karen, top + 10, left + 10);
                            progbar = CreateProgbar(0, top - 20, left);
                            label = CreateLabel("", top - 20, left - 30);
                            Store s = new Store(new Karen(pic, progbar, label)
                            {
                                Row = top / CELL_SIZE,
                                Col = left / CELL_SIZE,
                            });
                            stores.Add(s);
                            break;
                        case 'o':
                            picOwner = CreatePic(Properties.Resources.owner, top, left);
                            xOwner = left / CELL_SIZE;
                            yOwner = top / CELL_SIZE;
                            panMall.Controls.Add(picOwner);
                            break;
                        case 'w': pic = CreatePic(Properties.Resources.water, top, left); break;
                        case '-': pic = CreateWall(color, Properties.Resources.hline, top, left); break;
                        case '|': pic = CreateWall(color, Properties.Resources.vline, top, left); break;
                        case 'a': pic = CreateWall(color, Properties.Resources.a, top, left); break;
                        case 'b': pic = CreateWall(color, Properties.Resources.b, top, left); break;
                        case 'c': pic = CreateWall(color, Properties.Resources.c, top, left); break;
                        case 'd': pic = CreateWall(color, Properties.Resources.d, top, left); break;
                        case 'e': pic = CreateWall(color, Properties.Resources.e, top, left); break;
                        case 'f': pic = CreateWall(color, Properties.Resources.f, top, left); break;
                        case 'g': pic = CreateWall(color, Properties.Resources.g, top, left); break;
                        case 'h': pic = CreateWall(color, Properties.Resources.h, top, left); break;
                    }
                    left += CELL_SIZE;
                    if (pic != null)
                    {
                        panMall.Controls.Add(pic);
                        panMall.Controls.Add(progbar);
                        panMall.Controls.Add(label);
                    }
                }
                left = 0;
                top += CELL_SIZE;
            }

            picOwner.BringToFront();
            panMall.Width = CELL_SIZE * map[0].Length + PANEL_PADDING;
            panMall.Height = CELL_SIZE * map.Length + PANEL_PADDING;
            this.Width = panMall.Width + FORM_PADDING + 150;
            this.Height = panMall.Height + FORM_PADDING;
            lblMoneySaved.Left = this.Width - lblMoneySaved.Width - 10;
            lblMoneySavedLabel.Left = this.Width - lblMoneySavedLabel.Width - 25;
            lblMoneySavedLabel.Top = 0;
            lblMoneySaved.Top = lblMoneySavedLabel.Height + 10;
            // Added by Jakira Williams
            // Set position for Level Up label
            lblLevelUp.Left = this.Width - lblLevelUp.Width - 25;
            lblLevelUpLabel.Left = this.Width - lblLevelUpLabel.Width - 25;
            lblLevelUpLabel.Top = 100;
            lblLevelUp.Top = lblLevelUpLabel.Height + 110;
            // Added by Nathan Granade
            // Positions label properly on the screen
            lblKarensOffended.Left = this.Width - lblKarensOffended.Width - 25;
            lblKarensOffendedLabel.Left = this.Width - lblKarensOffendedLabel.Width - 25;
            lblKarensOffendedLabel.Top = 200;
            lblKarensOffended.Top = lblKarensOffendedLabel.Height + 210;
            // Added by Nathan Granade
            // Positions label properly on the screen
            lblKarenWorth.Left = this.Width - lblKarenWorth.Width - 25;
            lblKarenWorthLabel.Left = this.Width - lblKarenWorthLabel.Width - 25;
            lblKarenWorthLabel.Top = 300;
            lblKarenWorth.Top = lblKarenWorthLabel.Height + 310;
            // Added by Nathan Granade
            // Positions label properly on the screen
            lblDamage.Left = this.Width - lblDamage.Width - 25;
            lblDamageLabel.Left = this.Width - lblDamageLabel.Width - 25;
            lblDamageLabel.Top = 400;
            lblDamage.Top = lblDamageLabel.Height + 410;
            // Added by Nathan Granade
            // Positions button properly on the screen
            btnMoneyUpgrade.Left = this.Width - btnMoneyUpgrade.Width - 25;
            btnMoneyUpgrade.Top = 500;
            // Added by Nathan Granade
            // Positions button properly on the screen
            btnDamageUpgrade.Left = this.Width - btnDamageUpgrade.Width - 25;
            btnDamageUpgrade.Top = 600;
            //Added by Steven Baldwin
            // Positions button properly on the screen
            button1.Left = this.Width - button1.Width - 25;
            button1.Top = 700;
            //Added by Steven Baldwin
            // Positions button properly on the screen
            button2.Left = this.Width - button2.Width - 25;
            button2.Top = 750;
        }

        private void FrmMall_Load(object sender, EventArgs e)
        {
            stores = new List<Store>();
            LoadMap(fileContents);
            GenerateMall(colors[rand.Next(colors.Length)]);
            tmrKarenSpawner.Interval = rand.Next(1000, 5000);
            tmrKarenSpawner.Enabled = true;
            tmrDamageBoost.Interval = 15000;
            player = new SoundPlayer();
            //player.SoundLocation = "data/mall music.wav";
            player.PlayLooping();
        }

        private bool IsInBounds(int newRow, int newCol)
        {
            return (newRow >= 0 && newRow < map.Length && newCol >= 0 && newCol < map[0].Length);
        }

        private bool IsWalkable(int newRow, int newCol)
        {
            char[] walkableTiles = new char[] { ' ', 'o', 'K', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'L' };
            return walkableTiles.Contains(map[newRow][newCol]);
        }

        private bool CanMove(Direction dir, out int newRow, out int newCol)
        {
            newRow = yOwner;
            newCol = xOwner;
            switch (dir)
            {
                case Direction.UP: newRow--; break;
                case Direction.DOWN: newRow++; break;
                case Direction.LEFT: newCol--; break;
                case Direction.RIGHT: newCol++; break;
            }
            return (IsInBounds(newRow, newCol) && IsWalkable(newRow, newCol));
        }

        private new void Move(Direction dir)
        {
            if (CanMove(dir, out int newRow, out int newCol))
            {
                yOwner = newRow;
                xOwner = newCol;
                picOwner.Top = yOwner * CELL_SIZE;
                picOwner.Left = xOwner * CELL_SIZE;
                char mapTile = map[newRow][newCol];
                switch (mapTile)
                {
                    case '0':
                    case '1':
                    case '2':
                    case '3':
                    case '4':
                    case '5':
                    case '6':
                    case '7':
                    case '8':
                    case '9':
                        stores[int.Parse(mapTile.ToString())].OwnerWalksIn();
                        break;
                    case 'L':
                        foreach (Store store in stores)
                        {
                            store.ResetOwner();
                        }
                        break;
                }
            }
        }

        private void FrmMall_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up: Move(Direction.UP); break;
                case Keys.Down: Move(Direction.DOWN); break;
                case Keys.Left: Move(Direction.LEFT); break;
                case Keys.Right: Move(Direction.RIGHT); break;
            }
        }

        int karenActive = 0;
        private void tmrKarenSpawner_Tick(object sender, EventArgs e)
        {
            Store s = stores[rand.Next(stores.Count)];
            s.ActivateTheKaren();
            karenActive += 1;
            
        }

        private void FrmMall_FormClosed(object sender, FormClosedEventArgs e)
        {
            Game.openForms.Remove(this);
            Game.CloseAll();
        }

        private void tmrUpdateKarens_Tick(object sender, EventArgs e)
        {
            if (stores != null && stores.Count > 0)
            {
                foreach (Store store in stores)
                {
                    store.Update();
                }
            }

            //Temporary boost for the damage for time

            
            if (stores != null && stores.Count > 0 && button5Clicked == true)
            {
                int boostNumber = 5;
                for (int i = 0; i < boostNumber; i++)
                {
                    foreach (Store store in stores)
                    {
                        store.TempUpdate();

                    }
                }
                button5Clicked = false;

                
            }

        }

        private void tmrMoveOwner_Tick(object sender, EventArgs e)
        {
            Direction dir = (Direction)rand.Next(4);
            Move(dir);
            if(button3Clicked == true)
            {
                Direction bt3dir = (Direction)rand.Next(3);
                Move(bt3dir);
            }
        }

        

        private void tmrUpdateGame_Tick(object sender, EventArgs e)
        {
            lblMoneySaved.Text = Game.Score.ToString("$ #,#0.00");
            lblLevelUp.Text = Game.Level.ToString();
            lblKarensOffended.Text = Game.KarensOffended.ToString();
            lblKarenWorth.Text = Game.KarenWorth.ToString("$ #,#0.00");
            lblDamage.Text = Game.Dmg.ToString();
            btnMoneyUpgrade.Text = "Upgrade Money Gained\nCost: " + Game.MoneyUpgrade.ToString("$ #,#0.00");
            btnDamageUpgrade.Text = "Upgrade Damage Dealt\nCost: " + Game.DmgUpgrade.ToString("$ #,#0.00");
            //btnLevelUpgrade.Text = "Upgrade Level\nCost: " + Game.LvlUpgrade.ToString("$ #,#00.00");
        }

        private void btnMoneyUpgrade_Click(object sender, EventArgs e)
        {
            if (Game.Score >= Game.MoneyUpgrade)
            {
                Game.Score -= Game.MoneyUpgrade;
                Game.MoneyUpgrade *= 2;
                Game.KarenWorth += 5;
            }
        }

        private void btnDamageUpgrade_Click(object sender, EventArgs e)
        {
            if (Game.Score >= Game.DmgUpgrade)
            {
                Game.Score -= Game.DmgUpgrade;
                Game.DmgUpgrade *= 3;
                Game.Dmg *= 2;
            }
        }

        private void btnDemo_Click(object sender, EventArgs e)
        {
            Game.Score = 100000;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (current == Map.map)
            {
                current = Map.map1;
                fileContents = File.ReadAllText("data/mall1.txt");
                FrmMall_Load(null, null);
            }
            else if (current == Map.map1)
            {
                current = Map.map2;
                fileContents = File.ReadAllText("data/mall2.txt");
                FrmMall_Load(null, null);
            }
            else if (current == Map.map2)
            {
                current = Map.map3;
                fileContents = File.ReadAllText("data/mall3.txt");
                FrmMall_Load(null, null);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (current == Map.map3)
            {
                current = Map.map2;
                fileContents = File.ReadAllText("data/mall2.txt");
                FrmMall_Load(null, null);
            }
            else if (current == Map.map2)
            {
                current = Map.map1;
                fileContents = File.ReadAllText("data/mall1.txt");
                FrmMall_Load(null, null);
            }
            else if (current == Map.map1)
            {
                current = Map.map;
                fileContents = File.ReadAllText("data/mall.txt");
                FrmMall_Load(null, null);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(Game.Score >= 300)
            {
                Game.Score -= 300;
                button3Clicked = true;
                button3.Hide();
                button4.Show();
                button5.Show();
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Game.Score >= 1250)
            {
                button5Clicked = true;
                Game.Score -= 1250;
            }
          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Game.Score >= 2500)
            {
                
                Game.Score -= 2500;
                foreach (Store store in stores)
                {
                    store.NukeAllKarens();
                }

            }
            
        }

    }
}
