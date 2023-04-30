namespace THA_W8_EKA_Y
{
    partial class Player_Data
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
            this.dgv_dtplayer = new System.Windows.Forms.DataGridView();
            this.comb_teams = new System.Windows.Forms.ComboBox();
            this.lbl_teamname = new System.Windows.Forms.Label();
            this.btn_ok = new System.Windows.Forms.Button();
            this.lbl_title = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_GP = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_GO = new System.Windows.Forms.Label();
            this.lbl_goalown = new System.Windows.Forms.Label();
            this.lbl_reds = new System.Windows.Forms.Label();
            this.lbl_yells = new System.Windows.Forms.Label();
            this.lbl_pens = new System.Windows.Forms.Label();
            this.lbl_goalss = new System.Windows.Forms.Label();
            this.lbl_nats = new System.Windows.Forms.Label();
            this.lbl_tnames = new System.Windows.Forms.Label();
            this.lbl_numbers = new System.Windows.Forms.Label();
            this.lbl_poss = new System.Windows.Forms.Label();
            this.lbl_pnames = new System.Windows.Forms.Label();
            this.lbl_red = new System.Windows.Forms.Label();
            this.lbl_yell = new System.Windows.Forms.Label();
            this.lbl_pena = new System.Windows.Forms.Label();
            this.lbl_goal = new System.Windows.Forms.Label();
            this.lbl_nat = new System.Windows.Forms.Label();
            this.lbl_career = new System.Windows.Forms.Label();
            this.lbl_tname = new System.Windows.Forms.Label();
            this.lbl_num = new System.Windows.Forms.Label();
            this.lbl_pos = new System.Windows.Forms.Label();
            this.lbl_pname = new System.Windows.Forms.Label();
            this.comb_pnames = new System.Windows.Forms.ComboBox();
            this.lbl_title2 = new System.Windows.Forms.Label();
            this.btn_ok2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dtplayer)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_dtplayer
            // 
            this.dgv_dtplayer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dtplayer.Location = new System.Drawing.Point(12, 90);
            this.dgv_dtplayer.Name = "dgv_dtplayer";
            this.dgv_dtplayer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgv_dtplayer.Size = new System.Drawing.Size(520, 323);
            this.dgv_dtplayer.TabIndex = 0;
            this.dgv_dtplayer.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_dtplayer_CellMouseClick);
            // 
            // comb_teams
            // 
            this.comb_teams.FormattingEnabled = true;
            this.comb_teams.Location = new System.Drawing.Point(19, 32);
            this.comb_teams.Name = "comb_teams";
            this.comb_teams.Size = new System.Drawing.Size(121, 21);
            this.comb_teams.TabIndex = 1;
            this.comb_teams.SelectionChangeCommitted += new System.EventHandler(this.comb_teams_SelectionChangeCommitted);
            // 
            // lbl_teamname
            // 
            this.lbl_teamname.AutoSize = true;
            this.lbl_teamname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_teamname.Location = new System.Drawing.Point(15, 9);
            this.lbl_teamname.Name = "lbl_teamname";
            this.lbl_teamname.Size = new System.Drawing.Size(99, 20);
            this.lbl_teamname.TabIndex = 2;
            this.lbl_teamname.Text = "Team Name:";
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(19, 61);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 3;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Location = new System.Drawing.Point(15, 11);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(63, 13);
            this.lbl_title.TabIndex = 4;
            this.lbl_title.Text = "Player Stats";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_GP);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbl_GO);
            this.panel1.Controls.Add(this.lbl_goalown);
            this.panel1.Controls.Add(this.lbl_reds);
            this.panel1.Controls.Add(this.lbl_yells);
            this.panel1.Controls.Add(this.lbl_pens);
            this.panel1.Controls.Add(this.lbl_goalss);
            this.panel1.Controls.Add(this.lbl_nats);
            this.panel1.Controls.Add(this.lbl_tnames);
            this.panel1.Controls.Add(this.lbl_numbers);
            this.panel1.Controls.Add(this.lbl_poss);
            this.panel1.Controls.Add(this.lbl_pnames);
            this.panel1.Controls.Add(this.lbl_red);
            this.panel1.Controls.Add(this.lbl_yell);
            this.panel1.Controls.Add(this.lbl_pena);
            this.panel1.Controls.Add(this.lbl_goal);
            this.panel1.Controls.Add(this.lbl_nat);
            this.panel1.Controls.Add(this.lbl_career);
            this.panel1.Controls.Add(this.lbl_tname);
            this.panel1.Controls.Add(this.lbl_num);
            this.panel1.Controls.Add(this.lbl_pos);
            this.panel1.Controls.Add(this.lbl_pname);
            this.panel1.Controls.Add(this.lbl_title);
            this.panel1.Location = new System.Drawing.Point(547, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 323);
            this.panel1.TabIndex = 5;
            // 
            // lbl_GP
            // 
            this.lbl_GP.AutoSize = true;
            this.lbl_GP.Location = new System.Drawing.Point(119, 222);
            this.lbl_GP.Name = "lbl_GP";
            this.lbl_GP.Size = new System.Drawing.Size(70, 13);
            this.lbl_GP.TabIndex = 27;
            this.lbl_GP.Text = "Goal Penalty:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Goal Penalty:";
            // 
            // lbl_GO
            // 
            this.lbl_GO.AutoSize = true;
            this.lbl_GO.Location = new System.Drawing.Point(119, 200);
            this.lbl_GO.Name = "lbl_GO";
            this.lbl_GO.Size = new System.Drawing.Size(69, 13);
            this.lbl_GO.TabIndex = 25;
            this.lbl_GO.Text = "Goal Owned:";
            // 
            // lbl_goalown
            // 
            this.lbl_goalown.AutoSize = true;
            this.lbl_goalown.Location = new System.Drawing.Point(28, 200);
            this.lbl_goalown.Name = "lbl_goalown";
            this.lbl_goalown.Size = new System.Drawing.Size(69, 13);
            this.lbl_goalown.TabIndex = 24;
            this.lbl_goalown.Text = "Goal Owned:";
            // 
            // lbl_reds
            // 
            this.lbl_reds.AutoSize = true;
            this.lbl_reds.Location = new System.Drawing.Point(119, 295);
            this.lbl_reds.Name = "lbl_reds";
            this.lbl_reds.Size = new System.Drawing.Size(60, 13);
            this.lbl_reds.TabIndex = 23;
            this.lbl_reds.Text = "Red Cards:";
            // 
            // lbl_yells
            // 
            this.lbl_yells.AutoSize = true;
            this.lbl_yells.Location = new System.Drawing.Point(119, 270);
            this.lbl_yells.Name = "lbl_yells";
            this.lbl_yells.Size = new System.Drawing.Size(71, 13);
            this.lbl_yells.TabIndex = 22;
            this.lbl_yells.Text = "Yellow Cards:";
            // 
            // lbl_pens
            // 
            this.lbl_pens.AutoSize = true;
            this.lbl_pens.Location = new System.Drawing.Point(119, 246);
            this.lbl_pens.Name = "lbl_pens";
            this.lbl_pens.Size = new System.Drawing.Size(81, 13);
            this.lbl_pens.TabIndex = 21;
            this.lbl_pens.Text = "Penalty Missed:";
            // 
            // lbl_goalss
            // 
            this.lbl_goalss.AutoSize = true;
            this.lbl_goalss.Location = new System.Drawing.Point(119, 178);
            this.lbl_goalss.Name = "lbl_goalss";
            this.lbl_goalss.Size = new System.Drawing.Size(37, 13);
            this.lbl_goalss.TabIndex = 20;
            this.lbl_goalss.Text = "Goals:";
            // 
            // lbl_nats
            // 
            this.lbl_nats.AutoSize = true;
            this.lbl_nats.Location = new System.Drawing.Point(119, 125);
            this.lbl_nats.Name = "lbl_nats";
            this.lbl_nats.Size = new System.Drawing.Size(59, 13);
            this.lbl_nats.TabIndex = 19;
            this.lbl_nats.Text = "Nationality:";
            // 
            // lbl_tnames
            // 
            this.lbl_tnames.AutoSize = true;
            this.lbl_tnames.Location = new System.Drawing.Point(119, 101);
            this.lbl_tnames.Name = "lbl_tnames";
            this.lbl_tnames.Size = new System.Drawing.Size(68, 13);
            this.lbl_tnames.TabIndex = 18;
            this.lbl_tnames.Text = "Team Name:";
            // 
            // lbl_numbers
            // 
            this.lbl_numbers.AutoSize = true;
            this.lbl_numbers.Location = new System.Drawing.Point(119, 78);
            this.lbl_numbers.Name = "lbl_numbers";
            this.lbl_numbers.Size = new System.Drawing.Size(47, 13);
            this.lbl_numbers.TabIndex = 17;
            this.lbl_numbers.Text = "Number:";
            // 
            // lbl_poss
            // 
            this.lbl_poss.AutoSize = true;
            this.lbl_poss.Location = new System.Drawing.Point(119, 56);
            this.lbl_poss.Name = "lbl_poss";
            this.lbl_poss.Size = new System.Drawing.Size(47, 13);
            this.lbl_poss.TabIndex = 16;
            this.lbl_poss.Text = "Position:";
            // 
            // lbl_pnames
            // 
            this.lbl_pnames.AutoSize = true;
            this.lbl_pnames.Location = new System.Drawing.Point(119, 33);
            this.lbl_pnames.Name = "lbl_pnames";
            this.lbl_pnames.Size = new System.Drawing.Size(70, 13);
            this.lbl_pnames.TabIndex = 15;
            this.lbl_pnames.Text = "Player Name:";
            // 
            // lbl_red
            // 
            this.lbl_red.AutoSize = true;
            this.lbl_red.Location = new System.Drawing.Point(28, 295);
            this.lbl_red.Name = "lbl_red";
            this.lbl_red.Size = new System.Drawing.Size(60, 13);
            this.lbl_red.TabIndex = 14;
            this.lbl_red.Text = "Red Cards:";
            // 
            // lbl_yell
            // 
            this.lbl_yell.AutoSize = true;
            this.lbl_yell.Location = new System.Drawing.Point(28, 270);
            this.lbl_yell.Name = "lbl_yell";
            this.lbl_yell.Size = new System.Drawing.Size(71, 13);
            this.lbl_yell.TabIndex = 13;
            this.lbl_yell.Text = "Yellow Cards:";
            // 
            // lbl_pena
            // 
            this.lbl_pena.AutoSize = true;
            this.lbl_pena.Location = new System.Drawing.Point(28, 246);
            this.lbl_pena.Name = "lbl_pena";
            this.lbl_pena.Size = new System.Drawing.Size(81, 13);
            this.lbl_pena.TabIndex = 12;
            this.lbl_pena.Text = "Penalty Missed:";
            // 
            // lbl_goal
            // 
            this.lbl_goal.AutoSize = true;
            this.lbl_goal.Location = new System.Drawing.Point(28, 178);
            this.lbl_goal.Name = "lbl_goal";
            this.lbl_goal.Size = new System.Drawing.Size(37, 13);
            this.lbl_goal.TabIndex = 11;
            this.lbl_goal.Text = "Goals:";
            // 
            // lbl_nat
            // 
            this.lbl_nat.AutoSize = true;
            this.lbl_nat.Location = new System.Drawing.Point(28, 125);
            this.lbl_nat.Name = "lbl_nat";
            this.lbl_nat.Size = new System.Drawing.Size(59, 13);
            this.lbl_nat.TabIndex = 10;
            this.lbl_nat.Text = "Nationality:";
            // 
            // lbl_career
            // 
            this.lbl_career.AutoSize = true;
            this.lbl_career.Location = new System.Drawing.Point(10, 155);
            this.lbl_career.Name = "lbl_career";
            this.lbl_career.Size = new System.Drawing.Size(65, 13);
            this.lbl_career.TabIndex = 9;
            this.lbl_career.Text = "Career Stats";
            // 
            // lbl_tname
            // 
            this.lbl_tname.AutoSize = true;
            this.lbl_tname.Location = new System.Drawing.Point(28, 101);
            this.lbl_tname.Name = "lbl_tname";
            this.lbl_tname.Size = new System.Drawing.Size(68, 13);
            this.lbl_tname.TabIndex = 8;
            this.lbl_tname.Text = "Team Name:";
            // 
            // lbl_num
            // 
            this.lbl_num.AutoSize = true;
            this.lbl_num.Location = new System.Drawing.Point(28, 78);
            this.lbl_num.Name = "lbl_num";
            this.lbl_num.Size = new System.Drawing.Size(47, 13);
            this.lbl_num.TabIndex = 7;
            this.lbl_num.Text = "Number:";
            // 
            // lbl_pos
            // 
            this.lbl_pos.AutoSize = true;
            this.lbl_pos.Location = new System.Drawing.Point(28, 56);
            this.lbl_pos.Name = "lbl_pos";
            this.lbl_pos.Size = new System.Drawing.Size(47, 13);
            this.lbl_pos.TabIndex = 6;
            this.lbl_pos.Text = "Position:";
            // 
            // lbl_pname
            // 
            this.lbl_pname.AutoSize = true;
            this.lbl_pname.Location = new System.Drawing.Point(28, 33);
            this.lbl_pname.Name = "lbl_pname";
            this.lbl_pname.Size = new System.Drawing.Size(70, 13);
            this.lbl_pname.TabIndex = 5;
            this.lbl_pname.Text = "Player Name:";
            // 
            // comb_pnames
            // 
            this.comb_pnames.Enabled = false;
            this.comb_pnames.FormattingEnabled = true;
            this.comb_pnames.Location = new System.Drawing.Point(547, 34);
            this.comb_pnames.Name = "comb_pnames";
            this.comb_pnames.Size = new System.Drawing.Size(121, 21);
            this.comb_pnames.TabIndex = 6;
            this.comb_pnames.SelectionChangeCommitted += new System.EventHandler(this.comb_pnames_SelectionChangeCommitted);
            // 
            // lbl_title2
            // 
            this.lbl_title2.AutoSize = true;
            this.lbl_title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title2.Location = new System.Drawing.Point(551, 11);
            this.lbl_title2.Name = "lbl_title2";
            this.lbl_title2.Size = new System.Drawing.Size(102, 20);
            this.lbl_title2.TabIndex = 7;
            this.lbl_title2.Text = "Player Name:";
            // 
            // btn_ok2
            // 
            this.btn_ok2.Location = new System.Drawing.Point(550, 61);
            this.btn_ok2.Name = "btn_ok2";
            this.btn_ok2.Size = new System.Drawing.Size(75, 23);
            this.btn_ok2.TabIndex = 8;
            this.btn_ok2.Text = "OK";
            this.btn_ok2.UseVisualStyleBackColor = true;
            this.btn_ok2.Click += new System.EventHandler(this.btn_ok2_Click);
            // 
            // Player_Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btn_ok2);
            this.Controls.Add(this.lbl_title2);
            this.Controls.Add(this.comb_pnames);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.lbl_teamname);
            this.Controls.Add(this.comb_teams);
            this.Controls.Add(this.dgv_dtplayer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Player_Data";
            this.Text = "Player_Data";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Player_Data_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dtplayer)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_dtplayer;
        private System.Windows.Forms.ComboBox comb_teams;
        private System.Windows.Forms.Label lbl_teamname;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_reds;
        private System.Windows.Forms.Label lbl_yells;
        private System.Windows.Forms.Label lbl_pens;
        private System.Windows.Forms.Label lbl_goalss;
        private System.Windows.Forms.Label lbl_nats;
        private System.Windows.Forms.Label lbl_tnames;
        private System.Windows.Forms.Label lbl_numbers;
        private System.Windows.Forms.Label lbl_poss;
        private System.Windows.Forms.Label lbl_pnames;
        private System.Windows.Forms.Label lbl_red;
        private System.Windows.Forms.Label lbl_yell;
        private System.Windows.Forms.Label lbl_pena;
        private System.Windows.Forms.Label lbl_goal;
        private System.Windows.Forms.Label lbl_nat;
        private System.Windows.Forms.Label lbl_career;
        private System.Windows.Forms.Label lbl_tname;
        private System.Windows.Forms.Label lbl_num;
        private System.Windows.Forms.Label lbl_pos;
        private System.Windows.Forms.Label lbl_pname;
        private System.Windows.Forms.ComboBox comb_pnames;
        private System.Windows.Forms.Label lbl_GP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_GO;
        private System.Windows.Forms.Label lbl_goalown;
        private System.Windows.Forms.Label lbl_title2;
        private System.Windows.Forms.Button btn_ok2;
    }
}