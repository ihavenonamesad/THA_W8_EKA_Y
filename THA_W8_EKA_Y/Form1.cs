using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
namespace THA_W8_EKA_Y
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void playerDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Visible = true;
            Player_Data player = new Player_Data();
            panel1.Visible = true;
            player.Dock = DockStyle.Fill;
            player.TopLevel = false;
            this.panel1.Controls.Add(player);
            player.Show();
        }

        private void findMatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Visible = true;
            Find_Match find = new Find_Match();
            panel1.Visible = true;
            find.Dock = DockStyle.Fill;
            find.TopLevel = false;
            this.panel1.Controls.Add(find);
            find.Show();
        }
    }
}
