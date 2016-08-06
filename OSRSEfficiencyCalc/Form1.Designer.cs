namespace OSRSEfficiencyCalc
{
    partial class Form1
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Attack");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Hitpoints");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Mining");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("Strength");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("Agility");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("Smithing");
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("Defence");
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("Herblore");
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem("Fishing");
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem("Ranged");
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem("Thieving");
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem("Cooking");
            System.Windows.Forms.ListViewItem listViewItem13 = new System.Windows.Forms.ListViewItem("Prayer");
            System.Windows.Forms.ListViewItem listViewItem14 = new System.Windows.Forms.ListViewItem("Crafting");
            System.Windows.Forms.ListViewItem listViewItem15 = new System.Windows.Forms.ListViewItem("Firemaking");
            System.Windows.Forms.ListViewItem listViewItem16 = new System.Windows.Forms.ListViewItem("Magic");
            System.Windows.Forms.ListViewItem listViewItem17 = new System.Windows.Forms.ListViewItem("Fletching");
            System.Windows.Forms.ListViewItem listViewItem18 = new System.Windows.Forms.ListViewItem("Woodcutting");
            System.Windows.Forms.ListViewItem listViewItem19 = new System.Windows.Forms.ListViewItem("Runecrafting");
            System.Windows.Forms.ListViewItem listViewItem20 = new System.Windows.Forms.ListViewItem("Slayer");
            System.Windows.Forms.ListViewItem listViewItem21 = new System.Windows.Forms.ListViewItem("Farming");
            System.Windows.Forms.ListViewItem listViewItem22 = new System.Windows.Forms.ListViewItem("Construction");
            System.Windows.Forms.ListViewItem listViewItem23 = new System.Windows.Forms.ListViewItem("Hunter");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.playerText = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Skill = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Level = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Experience = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Remaining = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.itemView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.craftingCalculate = new System.Windows.Forms.Button();
            this.craftingList = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.bestgpText = new System.Windows.Forms.TextBox();
            this.craftingRadioLevel = new System.Windows.Forms.RadioButton();
            this.craftingRadioXp = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.craftingTargetLevel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.craftingCurLevel = new System.Windows.Forms.TextBox();
            this.craftingLoadPlayer = new System.Windows.Forms.TextBox();
            this.craftingLoad = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(394, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 25);
            this.button1.TabIndex = 0;
            this.button1.Text = "Load Player";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // playerText
            // 
            this.playerText.Location = new System.Drawing.Point(264, 9);
            this.playerText.Name = "playerText";
            this.playerText.Size = new System.Drawing.Size(100, 20);
            this.playerText.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(798, 500);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listView1);
            this.tabPage1.Controls.Add(this.playerText);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(790, 474);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Stats";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Skill,
            this.Level,
            this.Experience,
            this.Remaining});
            this.listView1.GridLines = true;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8,
            listViewItem9,
            listViewItem10,
            listViewItem11,
            listViewItem12,
            listViewItem13,
            listViewItem14,
            listViewItem15,
            listViewItem16,
            listViewItem17,
            listViewItem18,
            listViewItem19,
            listViewItem20,
            listViewItem21,
            listViewItem22,
            listViewItem23});
            this.listView1.Location = new System.Drawing.Point(213, 35);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(342, 422);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Skill
            // 
            this.Skill.Text = "Skill";
            this.Skill.Width = 90;
            // 
            // Level
            // 
            this.Level.Text = "Level";
            this.Level.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Level.Width = 40;
            // 
            // Experience
            // 
            this.Experience.Text = "Experience";
            this.Experience.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Experience.Width = 100;
            // 
            // Remaining
            // 
            this.Remaining.Text = "Xp Remaining";
            this.Remaining.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Remaining.Width = 100;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.buttonRefresh);
            this.tabPage3.Controls.Add(this.textBoxSearch);
            this.tabPage3.Controls.Add(this.itemView);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(790, 474);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Item Pricing";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(614, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Search:";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(28, 6);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(92, 23);
            this.buttonRefresh.TabIndex = 6;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(658, 8);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(100, 20);
            this.textBoxSearch.TabIndex = 4;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // itemView
            // 
            this.itemView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.itemView.GridLines = true;
            this.itemView.Location = new System.Drawing.Point(28, 34);
            this.itemView.Name = "itemView";
            this.itemView.Size = new System.Drawing.Size(730, 429);
            this.itemView.TabIndex = 3;
            this.itemView.UseCompatibleStateImageBehavior = false;
            this.itemView.View = System.Windows.Forms.View.Details;
            this.itemView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.itemView_ColumnClick);
            this.itemView.DoubleClick += new System.EventHandler(this.itemView_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 217;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Buy Price";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 109;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Sell Price";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 108;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Margin";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 68;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.craftingCalculate);
            this.tabPage2.Controls.Add(this.craftingList);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.bestgpText);
            this.tabPage2.Controls.Add(this.craftingRadioLevel);
            this.tabPage2.Controls.Add(this.craftingRadioXp);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.craftingTargetLevel);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.craftingCurLevel);
            this.tabPage2.Controls.Add(this.craftingLoadPlayer);
            this.tabPage2.Controls.Add(this.craftingLoad);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(790, 474);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Crafting";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // craftingCalculate
            // 
            this.craftingCalculate.Location = new System.Drawing.Point(630, 15);
            this.craftingCalculate.Name = "craftingCalculate";
            this.craftingCalculate.Size = new System.Drawing.Size(105, 25);
            this.craftingCalculate.TabIndex = 17;
            this.craftingCalculate.Text = "Calculate";
            this.craftingCalculate.UseVisualStyleBackColor = true;
            this.craftingCalculate.Click += new System.EventHandler(this.craftingCalculate_Click);
            // 
            // craftingList
            // 
            this.craftingList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.craftingList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader12,
            this.columnHeader11});
            this.craftingList.GridLines = true;
            this.craftingList.Location = new System.Drawing.Point(6, 58);
            this.craftingList.Name = "craftingList";
            this.craftingList.Size = new System.Drawing.Size(778, 396);
            this.craftingList.TabIndex = 16;
            this.craftingList.UseCompatibleStateImageBehavior = false;
            this.craftingList.View = System.Windows.Forms.View.Details;
            this.craftingList.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.craftingView_ColumnClick);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Method";
            this.columnHeader5.Width = 160;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Buy Price";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Sell Price";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "XP per Hour";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader8.Width = 80;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "GP/XP";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Total Cost";
            this.columnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader10.Width = 110;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Time Earning Money";
            this.columnHeader12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader12.Width = 110;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Total Time";
            this.columnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader11.Width = 130;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(209, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 26);
            this.label4.TabIndex = 15;
            this.label4.Text = "Best gp/hr\r\n(ex. \"2.3\" mil)";
            // 
            // bestgpText
            // 
            this.bestgpText.Location = new System.Drawing.Point(285, 15);
            this.bestgpText.Name = "bestgpText";
            this.bestgpText.Size = new System.Drawing.Size(53, 20);
            this.bestgpText.TabIndex = 14;
            this.bestgpText.Text = "1.0";
            // 
            // craftingRadioLevel
            // 
            this.craftingRadioLevel.AutoSize = true;
            this.craftingRadioLevel.Checked = true;
            this.craftingRadioLevel.Location = new System.Drawing.Point(374, 17);
            this.craftingRadioLevel.Name = "craftingRadioLevel";
            this.craftingRadioLevel.Size = new System.Drawing.Size(51, 17);
            this.craftingRadioLevel.TabIndex = 13;
            this.craftingRadioLevel.TabStop = true;
            this.craftingRadioLevel.Text = "Level";
            this.craftingRadioLevel.UseVisualStyleBackColor = true;
            this.craftingRadioLevel.CheckedChanged += new System.EventHandler(this.craftingRadioLevel_CheckedChanged);
            // 
            // craftingRadioXp
            // 
            this.craftingRadioXp.AutoSize = true;
            this.craftingRadioXp.Location = new System.Drawing.Point(430, 17);
            this.craftingRadioXp.Name = "craftingRadioXp";
            this.craftingRadioXp.Size = new System.Drawing.Size(39, 17);
            this.craftingRadioXp.TabIndex = 12;
            this.craftingRadioXp.Text = "XP";
            this.craftingRadioXp.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(482, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Target:";
            // 
            // craftingTargetLevel
            // 
            this.craftingTargetLevel.Location = new System.Drawing.Point(524, 32);
            this.craftingTargetLevel.Name = "craftingTargetLevel";
            this.craftingTargetLevel.Size = new System.Drawing.Size(53, 20);
            this.craftingTargetLevel.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(478, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Current:";
            // 
            // craftingCurLevel
            // 
            this.craftingCurLevel.Location = new System.Drawing.Point(524, 6);
            this.craftingCurLevel.Name = "craftingCurLevel";
            this.craftingCurLevel.Size = new System.Drawing.Size(53, 20);
            this.craftingCurLevel.TabIndex = 8;
            // 
            // craftingLoadPlayer
            // 
            this.craftingLoadPlayer.Location = new System.Drawing.Point(6, 15);
            this.craftingLoadPlayer.Name = "craftingLoadPlayer";
            this.craftingLoadPlayer.Size = new System.Drawing.Size(100, 20);
            this.craftingLoadPlayer.TabIndex = 3;
            // 
            // craftingLoad
            // 
            this.craftingLoad.Location = new System.Drawing.Point(112, 13);
            this.craftingLoad.Name = "craftingLoad";
            this.craftingLoad.Size = new System.Drawing.Size(72, 25);
            this.craftingLoad.TabIndex = 2;
            this.craftingLoad.Text = "Load Player";
            this.craftingLoad.UseVisualStyleBackColor = true;
            this.craftingLoad.Click += new System.EventHandler(this.craftingLoad_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 538);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "OSRS Efficiency Calc";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox playerText;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Skill;
        private System.Windows.Forms.ColumnHeader Level;
        private System.Windows.Forms.ColumnHeader Experience;
        private System.Windows.Forms.ColumnHeader Remaining;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListView itemView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox craftingTargetLevel;
        private System.Windows.Forms.TextBox craftingLoadPlayer;
        private System.Windows.Forms.Button craftingLoad;
        private System.Windows.Forms.RadioButton craftingRadioLevel;
        private System.Windows.Forms.RadioButton craftingRadioXp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox bestgpText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox craftingCurLevel;
        private System.Windows.Forms.ListView craftingList;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.Button craftingCalculate;
        private System.Windows.Forms.ColumnHeader columnHeader12;
    }
}

