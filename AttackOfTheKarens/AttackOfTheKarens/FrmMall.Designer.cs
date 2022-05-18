namespace AttackOfTheKarens
{
    partial class FrmMall
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panMall = new System.Windows.Forms.Panel();
            this.tmrKarenSpawner = new System.Windows.Forms.Timer(this.components);
            this.tmrUpdateKarens = new System.Windows.Forms.Timer(this.components);
            this.tmrMoveOwner = new System.Windows.Forms.Timer(this.components);
            this.lblMoneySaved = new System.Windows.Forms.Label();
            this.lblMoneySavedLabel = new System.Windows.Forms.Label();
            this.tmrUpdateGame = new System.Windows.Forms.Timer(this.components);
            this.tmrDamageBoost = new System.Windows.Forms.Timer(this.components);
            this.lblLevelUp = new System.Windows.Forms.Label();
            this.lblLevelUpLabel = new System.Windows.Forms.Label();
            this.lblKarensOffendedLabel = new System.Windows.Forms.Label();
            this.lblKarensOffended = new System.Windows.Forms.Label();
            this.btnMoneyUpgrade = new System.Windows.Forms.Button();
            this.btnDamageUpgrade = new System.Windows.Forms.Button();
            this.lblKarenWorthLabel = new System.Windows.Forms.Label();
            this.lblDamageLabel = new System.Windows.Forms.Label();
            this.lblKarenWorth = new System.Windows.Forms.Label();
            this.lblDamage = new System.Windows.Forms.Label();
            this.btnDemo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panMall
            // 
            this.panMall.BackColor = System.Drawing.Color.Transparent;
            this.panMall.BackgroundImage = global::AttackOfTheKarens.Properties.Resources.mall_bg;
            this.panMall.Location = new System.Drawing.Point(14, 16);
            this.panMall.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panMall.Name = "panMall";
            this.panMall.Size = new System.Drawing.Size(641, 719);
            this.panMall.TabIndex = 0;
            // 
            // tmrKarenSpawner
            // 
            this.tmrKarenSpawner.Tick += new System.EventHandler(this.tmrKarenSpawner_Tick);
            // 
            // tmrUpdateKarens
            // 
            this.tmrUpdateKarens.Enabled = true;
            this.tmrUpdateKarens.Interval = 40;
            this.tmrUpdateKarens.Tick += new System.EventHandler(this.tmrUpdateKarens_Tick);
            // 
            // tmrMoveOwner
            // 
            this.tmrMoveOwner.Enabled = true;
            this.tmrMoveOwner.Interval = 120;
            this.tmrMoveOwner.Tick += new System.EventHandler(this.tmrMoveOwner_Tick);
            // 
            // lblMoneySaved
            // 
            this.lblMoneySaved.AutoSize = true;
            this.lblMoneySaved.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMoneySaved.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblMoneySaved.Location = new System.Drawing.Point(1213, 19);
            this.lblMoneySaved.Name = "lblMoneySaved";
            this.lblMoneySaved.Size = new System.Drawing.Size(119, 41);
            this.lblMoneySaved.TabIndex = 1;
            this.lblMoneySaved.Text = "$ 00.00";
            this.lblMoneySaved.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMoneySavedLabel
            // 
            this.lblMoneySavedLabel.AutoSize = true;
            this.lblMoneySavedLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMoneySavedLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblMoneySavedLabel.Location = new System.Drawing.Point(1039, 19);
            this.lblMoneySavedLabel.Name = "lblMoneySavedLabel";
            this.lblMoneySavedLabel.Size = new System.Drawing.Size(174, 32);
            this.lblMoneySavedLabel.TabIndex = 2;
            this.lblMoneySavedLabel.Text = "Money Saved:";
            this.lblMoneySavedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tmrUpdateGame
            // 
            this.tmrUpdateGame.Enabled = true;
            this.tmrUpdateGame.Tick += new System.EventHandler(this.tmrUpdateGame_Tick);
            // 
            // lblLevelUp
            // 
            this.lblLevelUp.AutoSize = true;
            this.lblLevelUp.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLevelUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblLevelUp.Location = new System.Drawing.Point(1213, 68);
            this.lblLevelUp.Name = "lblLevelUp";
            this.lblLevelUp.Size = new System.Drawing.Size(35, 41);
            this.lblLevelUp.TabIndex = 1;
            this.lblLevelUp.Text = "0";
            this.lblLevelUp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLevelUpLabel
            // 
            this.lblLevelUpLabel.AutoSize = true;
            this.lblLevelUpLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLevelUpLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblLevelUpLabel.Location = new System.Drawing.Point(1125, 76);
            this.lblLevelUpLabel.Name = "lblLevelUpLabel";
            this.lblLevelUpLabel.Size = new System.Drawing.Size(79, 32);
            this.lblLevelUpLabel.TabIndex = 2;
            this.lblLevelUpLabel.Text = "Level:";
            this.lblLevelUpLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblKarensOffendedLabel
            // 
            this.lblKarensOffendedLabel.AutoSize = true;
            this.lblKarensOffendedLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblKarensOffendedLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblKarensOffendedLabel.Location = new System.Drawing.Point(1006, 135);
            this.lblKarensOffendedLabel.Name = "lblKarensOffendedLabel";
            this.lblKarensOffendedLabel.Size = new System.Drawing.Size(213, 32);
            this.lblKarensOffendedLabel.TabIndex = 3;
            this.lblKarensOffendedLabel.Text = "Karens Offended:";
            this.lblKarensOffendedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblKarensOffended
            // 
            this.lblKarensOffended.AutoSize = true;
            this.lblKarensOffended.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblKarensOffended.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblKarensOffended.Location = new System.Drawing.Point(1213, 127);
            this.lblKarensOffended.Name = "lblKarensOffended";
            this.lblKarensOffended.Size = new System.Drawing.Size(35, 41);
            this.lblKarensOffended.TabIndex = 4;
            this.lblKarensOffended.Text = "0";
            this.lblKarensOffended.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnMoneyUpgrade
            // 
            this.btnMoneyUpgrade.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMoneyUpgrade.Location = new System.Drawing.Point(1154, 497);
            this.btnMoneyUpgrade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMoneyUpgrade.Name = "btnMoneyUpgrade";
            this.btnMoneyUpgrade.Size = new System.Drawing.Size(170, 69);
            this.btnMoneyUpgrade.TabIndex = 5;
            this.btnMoneyUpgrade.Text = "Upgrade Money Gained";
            this.btnMoneyUpgrade.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMoneyUpgrade.UseVisualStyleBackColor = true;
            this.btnMoneyUpgrade.Click += new System.EventHandler(this.btnMoneyUpgrade_Click);
            // 
            // btnDamageUpgrade
            // 
            this.btnDamageUpgrade.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDamageUpgrade.Location = new System.Drawing.Point(1154, 609);
            this.btnDamageUpgrade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDamageUpgrade.Name = "btnDamageUpgrade";
            this.btnDamageUpgrade.Size = new System.Drawing.Size(170, 68);
            this.btnDamageUpgrade.TabIndex = 6;
            this.btnDamageUpgrade.Text = "Upgrade Damage Dealt";
            this.btnDamageUpgrade.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDamageUpgrade.UseVisualStyleBackColor = true;
            this.btnDamageUpgrade.Click += new System.EventHandler(this.btnDamageUpgrade_Click);
            // 
            // lblKarenWorthLabel
            // 
            this.lblKarenWorthLabel.AutoSize = true;
            this.lblKarenWorthLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblKarenWorthLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblKarenWorthLabel.Location = new System.Drawing.Point(1046, 191);
            this.lblKarenWorthLabel.Name = "lblKarenWorthLabel";
            this.lblKarenWorthLabel.Size = new System.Drawing.Size(167, 32);
            this.lblKarenWorthLabel.TabIndex = 7;
            this.lblKarenWorthLabel.Text = "Karen Worth:";
            this.lblKarenWorthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDamageLabel
            // 
            this.lblDamageLabel.AutoSize = true;
            this.lblDamageLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDamageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblDamageLabel.Location = new System.Drawing.Point(1093, 249);
            this.lblDamageLabel.Name = "lblDamageLabel";
            this.lblDamageLabel.Size = new System.Drawing.Size(115, 32);
            this.lblDamageLabel.TabIndex = 8;
            this.lblDamageLabel.Text = "Damage:";
            this.lblDamageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblKarenWorth
            // 
            this.lblKarenWorth.AutoSize = true;
            this.lblKarenWorth.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblKarenWorth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblKarenWorth.Location = new System.Drawing.Point(1213, 183);
            this.lblKarenWorth.Name = "lblKarenWorth";
            this.lblKarenWorth.Size = new System.Drawing.Size(119, 41);
            this.lblKarenWorth.TabIndex = 9;
            this.lblKarenWorth.Text = "$ 00.00";
            this.lblKarenWorth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDamage
            // 
            this.lblDamage.AutoSize = true;
            this.lblDamage.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDamage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblDamage.Location = new System.Drawing.Point(1213, 241);
            this.lblDamage.Name = "lblDamage";
            this.lblDamage.Size = new System.Drawing.Size(35, 41);
            this.lblDamage.TabIndex = 10;
            this.lblDamage.Text = "0";
            this.lblDamage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnDemo
            // 
            this.btnDemo.Location = new System.Drawing.Point(2, 3);
            this.btnDemo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDemo.Name = "btnDemo";
            this.btnDemo.Size = new System.Drawing.Size(101, 31);
            this.btnDemo.TabIndex = 11;
            this.btnDemo.Text = "Demo Mode";
            this.btnDemo.UseVisualStyleBackColor = true;
            this.btnDemo.Click += new System.EventHandler(this.btnDemo_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1195, 700);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 35);
            this.button1.TabIndex = 12;
            this.button1.Text = "Up";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.Location = new System.Drawing.Point(1195, 743);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 35);
            this.button2.TabIndex = 13;
            this.button2.Text = "Down";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(475, 20);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(500, 40);
            this.button3.TabIndex = 0;
            this.button3.Text = "Buy some Jordan\'s +1 speed: Cost $300";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(200, 20);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(450, 40);
            this.button4.TabIndex = 14;
            this.button4.Text = "Kill All Karen\'s with a COD Nuke: Cost $2500";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(700, 20);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(500, 40);
            this.button5.TabIndex = 15;
            this.button5.Text = "Temporary Damage Boost X2 Damage: Cost $1250";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Visible = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // FrmMall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1338, 931);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDemo);
            this.Controls.Add(this.lblDamage);
            this.Controls.Add(this.lblKarenWorth);
            this.Controls.Add(this.lblDamageLabel);
            this.Controls.Add(this.lblKarenWorthLabel);
            this.Controls.Add(this.btnDamageUpgrade);
            this.Controls.Add(this.btnMoneyUpgrade);
            this.Controls.Add(this.lblKarensOffended);
            this.Controls.Add(this.lblKarensOffendedLabel);
            this.Controls.Add(this.lblMoneySavedLabel);
            this.Controls.Add(this.lblMoneySaved);
            this.Controls.Add(this.lblLevelUpLabel);
            this.Controls.Add(this.lblLevelUp);
            this.Controls.Add(this.panMall);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmMall";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Attack of the Karens!!";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMall_FormClosed);
            this.Load += new System.EventHandler(this.FrmMall_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmMall_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panMall;
        private System.Windows.Forms.Timer tmrKarenSpawner;
        private System.Windows.Forms.Timer tmrUpdateKarens;
        private System.Windows.Forms.Timer tmrMoveOwner;
        private System.Windows.Forms.Label lblMoneySaved;
        private System.Windows.Forms.Label lblMoneySavedLabel;
        private System.Windows.Forms.Timer tmrUpdateGame;
        private System.Windows.Forms.Timer tmrDamageBoost;
        // Level Up Design Features
        private System.Windows.Forms.Label lblLevelUp;
        private System.Windows.Forms.Label lblLevelUpLabel;
        private System.Windows.Forms.Label lblKarensOffendedLabel;
        private System.Windows.Forms.Label lblKarensOffended;
        private System.Windows.Forms.Button btnMoneyUpgrade;
        private System.Windows.Forms.Button btnDamageUpgrade;
        private System.Windows.Forms.Label lblKarenWorthLabel;
        private System.Windows.Forms.Label lblDamageLabel;
        private System.Windows.Forms.Label lblKarenWorth;
        private System.Windows.Forms.Label lblDamage;
        private System.Windows.Forms.Button btnDemo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}
