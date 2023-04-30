namespace THA_W8_EKA_Y
{
    partial class Find_Match
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
            this.t1 = new System.Windows.Forms.DataGridView();
            this.comb_teamhome = new System.Windows.Forms.ComboBox();
            this.comb_teamfight = new System.Windows.Forms.ComboBox();
            this.t2 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.lbl_teamhome = new System.Windows.Forms.Label();
            this.lbl_homescore = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_teamaway = new System.Windows.Forms.Label();
            this.lbl_awayscore = new System.Windows.Forms.Label();
            this.lbl_ref = new System.Windows.Forms.Label();
            this.lbl_referee = new System.Windows.Forms.Label();
            this.lbl_date1 = new System.Windows.Forms.Label();
            this.lbl_teamn = new System.Windows.Forms.Label();
            this.lbl_match = new System.Windows.Forms.Label();
            this.lbl_score1 = new System.Windows.Forms.Label();
            this.lbl_score2 = new System.Windows.Forms.Label();
            this.btn_match = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.t1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // t1
            // 
            this.t1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.t1.Location = new System.Drawing.Point(19, 91);
            this.t1.Name = "t1";
            this.t1.Size = new System.Drawing.Size(168, 318);
            this.t1.TabIndex = 0;
            this.t1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_match_CellContentClick);
            // 
            // comb_teamhome
            // 
            this.comb_teamhome.FormattingEnabled = true;
            this.comb_teamhome.Location = new System.Drawing.Point(19, 33);
            this.comb_teamhome.Name = "comb_teamhome";
            this.comb_teamhome.Size = new System.Drawing.Size(121, 21);
            this.comb_teamhome.TabIndex = 1;
            this.comb_teamhome.SelectionChangeCommitted += new System.EventHandler(this.comb_teamhome_SelectionChangeCommitted);
            // 
            // comb_teamfight
            // 
            this.comb_teamfight.FormattingEnabled = true;
            this.comb_teamfight.Location = new System.Drawing.Point(262, 31);
            this.comb_teamfight.Name = "comb_teamfight";
            this.comb_teamfight.Size = new System.Drawing.Size(231, 21);
            this.comb_teamfight.TabIndex = 3;
            this.comb_teamfight.SelectionChangeCommitted += new System.EventHandler(this.comb_teamfight_SelectionChangeCommitted);
            // 
            // t2
            // 
            this.t2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.t2.Location = new System.Drawing.Point(206, 91);
            this.t2.Name = "t2";
            this.t2.Size = new System.Drawing.Size(168, 318);
            this.t2.TabIndex = 4;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(390, 193);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(376, 216);
            this.dataGridView2.TabIndex = 5;
            // 
            // lbl_teamhome
            // 
            this.lbl_teamhome.AutoSize = true;
            this.lbl_teamhome.Location = new System.Drawing.Point(408, 90);
            this.lbl_teamhome.Name = "lbl_teamhome";
            this.lbl_teamhome.Size = new System.Drawing.Size(68, 13);
            this.lbl_teamhome.TabIndex = 6;
            this.lbl_teamhome.Text = "Team Home:";
            // 
            // lbl_homescore
            // 
            this.lbl_homescore.AutoSize = true;
            this.lbl_homescore.Location = new System.Drawing.Point(447, 114);
            this.lbl_homescore.Name = "lbl_homescore";
            this.lbl_homescore.Size = new System.Drawing.Size(33, 13);
            this.lbl_homescore.TabIndex = 7;
            this.lbl_homescore.Text = "score";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Location = new System.Drawing.Point(479, 165);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(28, 13);
            this.lbl_date.TabIndex = 8;
            this.lbl_date.Text = "date";
            // 
            // lbl_teamaway
            // 
            this.lbl_teamaway.AutoSize = true;
            this.lbl_teamaway.Location = new System.Drawing.Point(514, 90);
            this.lbl_teamaway.Name = "lbl_teamaway";
            this.lbl_teamaway.Size = new System.Drawing.Size(66, 13);
            this.lbl_teamaway.TabIndex = 9;
            this.lbl_teamaway.Text = "Team Away:";
            // 
            // lbl_awayscore
            // 
            this.lbl_awayscore.AutoSize = true;
            this.lbl_awayscore.Location = new System.Drawing.Point(558, 114);
            this.lbl_awayscore.Name = "lbl_awayscore";
            this.lbl_awayscore.Size = new System.Drawing.Size(33, 13);
            this.lbl_awayscore.TabIndex = 10;
            this.lbl_awayscore.Text = "score";
            // 
            // lbl_ref
            // 
            this.lbl_ref.AutoSize = true;
            this.lbl_ref.Location = new System.Drawing.Point(479, 138);
            this.lbl_ref.Name = "lbl_ref";
            this.lbl_ref.Size = new System.Drawing.Size(19, 13);
            this.lbl_ref.TabIndex = 11;
            this.lbl_ref.Text = "ref";
            // 
            // lbl_referee
            // 
            this.lbl_referee.AutoSize = true;
            this.lbl_referee.Location = new System.Drawing.Point(408, 138);
            this.lbl_referee.Name = "lbl_referee";
            this.lbl_referee.Size = new System.Drawing.Size(48, 13);
            this.lbl_referee.TabIndex = 12;
            this.lbl_referee.Text = "Referee:";
            // 
            // lbl_date1
            // 
            this.lbl_date1.AutoSize = true;
            this.lbl_date1.Location = new System.Drawing.Point(408, 165);
            this.lbl_date1.Name = "lbl_date1";
            this.lbl_date1.Size = new System.Drawing.Size(33, 13);
            this.lbl_date1.TabIndex = 13;
            this.lbl_date1.Text = "Date:";
            // 
            // lbl_teamn
            // 
            this.lbl_teamn.AutoSize = true;
            this.lbl_teamn.Location = new System.Drawing.Point(16, 17);
            this.lbl_teamn.Name = "lbl_teamn";
            this.lbl_teamn.Size = new System.Drawing.Size(37, 13);
            this.lbl_teamn.TabIndex = 14;
            this.lbl_teamn.Text = "Team:";
            // 
            // lbl_match
            // 
            this.lbl_match.AutoSize = true;
            this.lbl_match.Location = new System.Drawing.Point(259, 15);
            this.lbl_match.Name = "lbl_match";
            this.lbl_match.Size = new System.Drawing.Size(40, 13);
            this.lbl_match.TabIndex = 15;
            this.lbl_match.Text = "Match:";
            // 
            // lbl_score1
            // 
            this.lbl_score1.AutoSize = true;
            this.lbl_score1.Location = new System.Drawing.Point(408, 114);
            this.lbl_score1.Name = "lbl_score1";
            this.lbl_score1.Size = new System.Drawing.Size(38, 13);
            this.lbl_score1.TabIndex = 16;
            this.lbl_score1.Text = "Score:";
            // 
            // lbl_score2
            // 
            this.lbl_score2.AutoSize = true;
            this.lbl_score2.Location = new System.Drawing.Point(514, 114);
            this.lbl_score2.Name = "lbl_score2";
            this.lbl_score2.Size = new System.Drawing.Size(38, 13);
            this.lbl_score2.TabIndex = 17;
            this.lbl_score2.Text = "Score:";
            // 
            // btn_match
            // 
            this.btn_match.Location = new System.Drawing.Point(146, 31);
            this.btn_match.Name = "btn_match";
            this.btn_match.Size = new System.Drawing.Size(75, 23);
            this.btn_match.TabIndex = 18;
            this.btn_match.Text = "Match";
            this.btn_match.UseVisualStyleBackColor = true;
            this.btn_match.Click += new System.EventHandler(this.btn_match_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Team Home:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Team Away:";
            // 
            // Find_Match
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_match);
            this.Controls.Add(this.lbl_score2);
            this.Controls.Add(this.lbl_score1);
            this.Controls.Add(this.lbl_match);
            this.Controls.Add(this.lbl_teamn);
            this.Controls.Add(this.lbl_date1);
            this.Controls.Add(this.lbl_referee);
            this.Controls.Add(this.lbl_ref);
            this.Controls.Add(this.lbl_awayscore);
            this.Controls.Add(this.lbl_teamaway);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.lbl_homescore);
            this.Controls.Add(this.lbl_teamhome);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.t2);
            this.Controls.Add(this.comb_teamfight);
            this.Controls.Add(this.comb_teamhome);
            this.Controls.Add(this.t1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Find_Match";
            this.Text = "Find_Match";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Find_Match_Load);
            ((System.ComponentModel.ISupportInitialize)(this.t1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView t1;
        private System.Windows.Forms.ComboBox comb_teamhome;
        private System.Windows.Forms.ComboBox comb_teamfight;
        private System.Windows.Forms.DataGridView t2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label lbl_teamhome;
        private System.Windows.Forms.Label lbl_homescore;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_teamaway;
        private System.Windows.Forms.Label lbl_awayscore;
        private System.Windows.Forms.Label lbl_ref;
        private System.Windows.Forms.Label lbl_referee;
        private System.Windows.Forms.Label lbl_date1;
        private System.Windows.Forms.Label lbl_teamn;
        private System.Windows.Forms.Label lbl_match;
        private System.Windows.Forms.Label lbl_score1;
        private System.Windows.Forms.Label lbl_score2;
        private System.Windows.Forms.Button btn_match;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}