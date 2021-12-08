namespace Riot_API_Winforms
{
    partial class Summoner_Search
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Summoner_Search));
            this.APITextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.credentialsGroupBox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.summonerTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.regionComboBox = new System.Windows.Forms.ComboBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.puuidTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.recentMatchGroupBox = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.losersListBox = new System.Windows.Forms.ListBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.winnersListBox = new System.Windows.Forms.ListBox();
            this.matchesListBox = new System.Windows.Forms.ListBox();
            this.winsTextBox = new System.Windows.Forms.TextBox();
            this.losesTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.levelTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.badgePictureBox = new System.Windows.Forms.PictureBox();
            this.summonerDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.credentialsGroupBox.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.recentMatchGroupBox.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.badgePictureBox)).BeginInit();
            this.summonerDetailsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // APITextBox
            // 
            this.APITextBox.Location = new System.Drawing.Point(6, 47);
            this.APITextBox.Name = "APITextBox";
            this.APITextBox.Size = new System.Drawing.Size(313, 20);
            this.APITextBox.TabIndex = 0;
            this.APITextBox.Text = "RGAPI-6b79bca0-b415-4830-80b6-f42490efb2d3";
            this.APITextBox.TextChanged += new System.EventHandler(this.APITextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "API Key";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // credentialsGroupBox
            // 
            this.credentialsGroupBox.Controls.Add(this.label3);
            this.credentialsGroupBox.Controls.Add(this.summonerTextBox);
            this.credentialsGroupBox.Controls.Add(this.label2);
            this.credentialsGroupBox.Controls.Add(this.regionComboBox);
            this.credentialsGroupBox.Controls.Add(this.searchButton);
            this.credentialsGroupBox.Controls.Add(this.clearButton);
            this.credentialsGroupBox.Controls.Add(this.label1);
            this.credentialsGroupBox.Controls.Add(this.APITextBox);
            this.credentialsGroupBox.Location = new System.Drawing.Point(13, 13);
            this.credentialsGroupBox.Name = "credentialsGroupBox";
            this.credentialsGroupBox.Size = new System.Drawing.Size(772, 105);
            this.credentialsGroupBox.TabIndex = 0;
            this.credentialsGroupBox.TabStop = false;
            this.credentialsGroupBox.Text = "Credentials";
            this.credentialsGroupBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(465, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Summoner Name";
            // 
            // summonerTextBox
            // 
            this.summonerTextBox.Location = new System.Drawing.Point(465, 46);
            this.summonerTextBox.Name = "summonerTextBox";
            this.summonerTextBox.Size = new System.Drawing.Size(279, 20);
            this.summonerTextBox.TabIndex = 6;
            this.summonerTextBox.TextChanged += new System.EventHandler(this.summonerTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(349, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Region";
            // 
            // regionComboBox
            // 
            this.regionComboBox.FormattingEnabled = true;
            this.regionComboBox.Items.AddRange(new object[] {
            "BR1",
            "EUN1",
            "EUW1",
            "JP1",
            "KR",
            "LA1",
            "LA2",
            "NA1",
            "OC1",
            "RU",
            "TR1"});
            this.regionComboBox.Location = new System.Drawing.Point(349, 46);
            this.regionComboBox.Name = "regionComboBox";
            this.regionComboBox.Size = new System.Drawing.Size(61, 21);
            this.regionComboBox.TabIndex = 4;
            this.regionComboBox.SelectedIndexChanged += new System.EventHandler(this.regionComboBox_SelectedIndexChanged);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(669, 76);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(568, 76);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // puuidTextBox
            // 
            this.puuidTextBox.Location = new System.Drawing.Point(75, 28);
            this.puuidTextBox.Name = "puuidTextBox";
            this.puuidTextBox.ReadOnly = true;
            this.puuidTextBox.Size = new System.Drawing.Size(623, 20);
            this.puuidTextBox.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Puuid";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.puuidTextBox);
            this.groupBox3.Location = new System.Drawing.Point(12, 124);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(773, 65);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "PUUID";
            // 
            // recentMatchGroupBox
            // 
            this.recentMatchGroupBox.Controls.Add(this.groupBox6);
            this.recentMatchGroupBox.Controls.Add(this.groupBox5);
            this.recentMatchGroupBox.Controls.Add(this.matchesListBox);
            this.recentMatchGroupBox.Location = new System.Drawing.Point(317, 196);
            this.recentMatchGroupBox.Name = "recentMatchGroupBox";
            this.recentMatchGroupBox.Size = new System.Drawing.Size(468, 229);
            this.recentMatchGroupBox.TabIndex = 6;
            this.recentMatchGroupBox.TabStop = false;
            this.recentMatchGroupBox.Text = "Recent Match";
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.Salmon;
            this.groupBox6.Controls.Add(this.losersListBox);
            this.groupBox6.Location = new System.Drawing.Point(305, 20);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(157, 199);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Losers";
            // 
            // losersListBox
            // 
            this.losersListBox.FormattingEnabled = true;
            this.losersListBox.Location = new System.Drawing.Point(6, 20);
            this.losersListBox.Name = "losersListBox";
            this.losersListBox.Size = new System.Drawing.Size(144, 173);
            this.losersListBox.TabIndex = 1;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox5.Controls.Add(this.winnersListBox);
            this.groupBox5.Location = new System.Drawing.Point(129, 20);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(157, 199);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Winners";
            // 
            // winnersListBox
            // 
            this.winnersListBox.FormattingEnabled = true;
            this.winnersListBox.Location = new System.Drawing.Point(7, 23);
            this.winnersListBox.Name = "winnersListBox";
            this.winnersListBox.Size = new System.Drawing.Size(144, 173);
            this.winnersListBox.TabIndex = 0;
            // 
            // matchesListBox
            // 
            this.matchesListBox.FormattingEnabled = true;
            this.matchesListBox.Location = new System.Drawing.Point(7, 20);
            this.matchesListBox.Name = "matchesListBox";
            this.matchesListBox.Size = new System.Drawing.Size(115, 199);
            this.matchesListBox.TabIndex = 0;
            // 
            // winsTextBox
            // 
            this.winsTextBox.Location = new System.Drawing.Point(7, 111);
            this.winsTextBox.Name = "winsTextBox";
            this.winsTextBox.ReadOnly = true;
            this.winsTextBox.Size = new System.Drawing.Size(208, 20);
            this.winsTextBox.TabIndex = 8;
            // 
            // losesTextBox
            // 
            this.losesTextBox.Location = new System.Drawing.Point(7, 153);
            this.losesTextBox.Name = "losesTextBox";
            this.losesTextBox.ReadOnly = true;
            this.losesTextBox.Size = new System.Drawing.Size(208, 20);
            this.losesTextBox.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Wins";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Losses";
            // 
            // levelTextBox
            // 
            this.levelTextBox.Location = new System.Drawing.Point(7, 192);
            this.levelTextBox.Name = "levelTextBox";
            this.levelTextBox.ReadOnly = true;
            this.levelTextBox.Size = new System.Drawing.Size(208, 20);
            this.levelTextBox.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 176);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Level";
            // 
            // badgePictureBox
            // 
            this.badgePictureBox.Location = new System.Drawing.Point(225, 20);
            this.badgePictureBox.Name = "badgePictureBox";
            this.badgePictureBox.Size = new System.Drawing.Size(67, 69);
            this.badgePictureBox.TabIndex = 14;
            this.badgePictureBox.TabStop = false;
            // 
            // summonerDetailsGroupBox
            // 
            this.summonerDetailsGroupBox.Controls.Add(this.badgePictureBox);
            this.summonerDetailsGroupBox.Controls.Add(this.label9);
            this.summonerDetailsGroupBox.Controls.Add(this.levelTextBox);
            this.summonerDetailsGroupBox.Controls.Add(this.label8);
            this.summonerDetailsGroupBox.Controls.Add(this.label7);
            this.summonerDetailsGroupBox.Controls.Add(this.losesTextBox);
            this.summonerDetailsGroupBox.Controls.Add(this.winsTextBox);
            this.summonerDetailsGroupBox.Location = new System.Drawing.Point(12, 195);
            this.summonerDetailsGroupBox.Name = "summonerDetailsGroupBox";
            this.summonerDetailsGroupBox.Size = new System.Drawing.Size(298, 217);
            this.summonerDetailsGroupBox.TabIndex = 1;
            this.summonerDetailsGroupBox.TabStop = false;
            this.summonerDetailsGroupBox.Text = "Summoner Details";
            this.summonerDetailsGroupBox.Enter += new System.EventHandler(this.summonerDetailsGroupBox_Enter);
            // 
            // Summoner_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 429);
            this.Controls.Add(this.recentMatchGroupBox);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.summonerDetailsGroupBox);
            this.Controls.Add(this.credentialsGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Summoner_Search";
            this.Text = "Summoner Search";
            this.credentialsGroupBox.ResumeLayout(false);
            this.credentialsGroupBox.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.recentMatchGroupBox.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.badgePictureBox)).EndInit();
            this.summonerDetailsGroupBox.ResumeLayout(false);
            this.summonerDetailsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox APITextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox credentialsGroupBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox summonerTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox regionComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox puuidTextBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox recentMatchGroupBox;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListBox matchesListBox;
        private System.Windows.Forms.ListBox losersListBox;
        private System.Windows.Forms.ListBox winnersListBox;
        private System.Windows.Forms.TextBox winsTextBox;
        private System.Windows.Forms.TextBox losesTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox levelTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox badgePictureBox;
        private System.Windows.Forms.GroupBox summonerDetailsGroupBox;
    }
}

