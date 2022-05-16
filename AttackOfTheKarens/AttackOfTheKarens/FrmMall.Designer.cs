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
            this.SuspendLayout();
            // 
            // panMall
            // 
            this.panMall.BackColor = System.Drawing.Color.Transparent;
            this.panMall.BackgroundImage = global::AttackOfTheKarens.Properties.Resources.mall_bg;
            this.panMall.Location = new System.Drawing.Point(12, 12);
            this.panMall.Name = "panMall";
            this.panMall.Size = new System.Drawing.Size(561, 539);
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
            this.lblMoneySaved.Location = new System.Drawing.Point(1061, 14);
            this.lblMoneySaved.Name = "lblMoneySaved";
            this.lblMoneySaved.Size = new System.Drawing.Size(98, 32);
            this.lblMoneySaved.TabIndex = 1;
            this.lblMoneySaved.Text = "$ 00.00";
            this.lblMoneySaved.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMoneySavedLabel
            // 
            this.lblMoneySavedLabel.AutoSize = true;
            this.lblMoneySavedLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMoneySavedLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblMoneySavedLabel.Location = new System.Drawing.Point(909, 14);
            this.lblMoneySavedLabel.Name = "lblMoneySavedLabel";
            this.lblMoneySavedLabel.Size = new System.Drawing.Size(137, 25);
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
            this.lblLevelUp.Location = new System.Drawing.Point(1061, 51);
            this.lblLevelUp.Name = "lblLevelUp";
            this.lblLevelUp.Size = new System.Drawing.Size(28, 32);
            this.lblLevelUp.TabIndex = 1;
            this.lblLevelUp.Text = "0";
            this.lblLevelUp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLevelUpLabel
            // 
            this.lblLevelUpLabel.AutoSize = true;
            this.lblLevelUpLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLevelUpLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblLevelUpLabel.Location = new System.Drawing.Point(984, 57);
            this.lblLevelUpLabel.Name = "lblLevelUpLabel";
            this.lblLevelUpLabel.Size = new System.Drawing.Size(62, 25);
            this.lblLevelUpLabel.TabIndex = 2;
            this.lblLevelUpLabel.Text = "Level:";
            this.lblLevelUpLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblKarensOffendedLabel
            // 
            this.lblKarensOffendedLabel.AutoSize = true;
            this.lblKarensOffendedLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblKarensOffendedLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblKarensOffendedLabel.Location = new System.Drawing.Point(880, 101);
            this.lblKarensOffendedLabel.Name = "lblKarensOffendedLabel";
            this.lblKarensOffendedLabel.Size = new System.Drawing.Size(166, 25);
            this.lblKarensOffendedLabel.TabIndex = 3;
            this.lblKarensOffendedLabel.Text = "Karens Offended:";
            this.lblKarensOffendedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblKarensOffended
            // 
            this.lblKarensOffended.AutoSize = true;
            this.lblKarensOffended.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblKarensOffended.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblKarensOffended.Location = new System.Drawing.Point(1061, 95);
            this.lblKarensOffended.Name = "lblKarensOffended";
            this.lblKarensOffended.Size = new System.Drawing.Size(28, 32);
            this.lblKarensOffended.TabIndex = 4;
            this.lblKarensOffended.Text = "0";
            this.lblKarensOffended.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnMoneyUpgrade
            // 
            this.btnMoneyUpgrade.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMoneyUpgrade.Location = new System.Drawing.Point(1010, 373);
            this.btnMoneyUpgrade.Name = "btnMoneyUpgrade";
            this.btnMoneyUpgrade.Size = new System.Drawing.Size(149, 52);
            this.btnMoneyUpgrade.TabIndex = 5;
            this.btnMoneyUpgrade.Text = "Upgrade Money Gained";
            this.btnMoneyUpgrade.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMoneyUpgrade.UseVisualStyleBackColor = true;
            // 
            // btnDamageUpgrade
            // 
            this.btnDamageUpgrade.Location = new System.Drawing.Point(1010, 457);
            this.btnDamageUpgrade.Name = "btnDamageUpgrade";
            this.btnDamageUpgrade.Size = new System.Drawing.Size(149, 51);
            this.btnDamageUpgrade.TabIndex = 6;
            this.btnDamageUpgrade.Text = "Upgrade Damage Dealt";
            this.btnDamageUpgrade.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDamageUpgrade.UseVisualStyleBackColor = true;
            // 
            // lblKarenWorthLabel
            // 
            this.lblKarenWorthLabel.AutoSize = true;
            this.lblKarenWorthLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblKarenWorthLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblKarenWorthLabel.Location = new System.Drawing.Point(915, 143);
            this.lblKarenWorthLabel.Name = "lblKarenWorthLabel";
            this.lblKarenWorthLabel.Size = new System.Drawing.Size(131, 25);
            this.lblKarenWorthLabel.TabIndex = 7;
            this.lblKarenWorthLabel.Text = "Karen Worth:";
            this.lblKarenWorthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDamageLabel
            // 
            this.lblDamageLabel.AutoSize = true;
            this.lblDamageLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDamageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblDamageLabel.Location = new System.Drawing.Point(956, 187);
            this.lblDamageLabel.Name = "lblDamageLabel";
            this.lblDamageLabel.Size = new System.Drawing.Size(90, 25);
            this.lblDamageLabel.TabIndex = 8;
            this.lblDamageLabel.Text = "Damage:";
            this.lblDamageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblKarenWorth
            // 
            this.lblKarenWorth.AutoSize = true;
            this.lblKarenWorth.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblKarenWorth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblKarenWorth.Location = new System.Drawing.Point(1061, 137);
            this.lblKarenWorth.Name = "lblKarenWorth";
            this.lblKarenWorth.Size = new System.Drawing.Size(98, 32);
            this.lblKarenWorth.TabIndex = 9;
            this.lblKarenWorth.Text = "$ 00.00";
            this.lblKarenWorth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDamage
            // 
            this.lblDamage.AutoSize = true;
            this.lblDamage.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDamage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblDamage.Location = new System.Drawing.Point(1061, 181);
            this.lblDamage.Name = "lblDamage";
            this.lblDamage.Size = new System.Drawing.Size(28, 32);
            this.lblDamage.TabIndex = 10;
            this.lblDamage.Text = "0";
            this.lblDamage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FrmMall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1171, 698);
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
    }
}
