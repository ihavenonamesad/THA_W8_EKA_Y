using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace THA_W8_EKA_Y
{
    public partial class Player_Data : Form
    {
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        string connectionstring;
        string sqlquery;
        DataTable dtplayer = new DataTable();
        DataTable dtmatch = new DataTable();
        DataTable dtteam = new DataTable();
        public Player_Data()
        {
            InitializeComponent();
        }

        private void Player_Data_Load(object sender, EventArgs e)
        {
            connectionstring = "server=localhost;uid=root;pwd=;database=premier_league";
            conn = new MySqlConnection(connectionstring);

            sqlquery = "SELECT team_name as 'Team Name' , team_id as 'ID'from team";
            cmd = new MySqlCommand(sqlquery, conn);
            adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dtteam);
            comb_teams.DataSource = dtteam;
            comb_teams.ValueMember = "ID";
            comb_teams.DisplayMember = "Team Name";
            
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            DataTable dtpnames = new DataTable();
            sqlquery = $"SELECT player_name as 'Player Name', player_id as 'ID' from player p where team_id = '{comb_teams.SelectedValue.ToString()}';";
            cmd = new MySqlCommand(sqlquery, conn);
            adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dtpnames);
            comb_pnames.DataSource = dtpnames;
            comb_pnames.ValueMember = "ID";
            comb_pnames.DisplayMember = "Player Name";
            comb_pnames.Enabled = true;
            dtplayer.Clear();
            string simpan = comb_teams.Text;
            sqlquery = $"SELECT p.player_id as 'Player ID', p.player_name as 'Player Name', p.playing_pos as 'Position', p.team_number as 'Team Number', t.team_name as 'Team Name'" +
                $"from player p inner join team t on p.team_id = t.team_id where team_name ='{simpan}';";
            cmd = new MySqlCommand(sqlquery, conn);
            adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dtplayer);
            dgv_dtplayer.DataSource = dtplayer;

        }

        private void dgv_dtplayer_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }


        private void comb_pnames_SelectionChangeCommitted(object sender, EventArgs e)
        {
           
                
        }

        private void comb_teams_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }

        private void btn_ok2_Click(object sender, EventArgs e)
        {
            string playerid = comb_pnames.SelectedValue.ToString();
            DataTable dtstats = new DataTable();
            DataTable dttype = new DataTable();
            sqlquery = $"SELECT p.player_name as 'Player Name', p.playing_pos as 'Position', p.team_number 'Number', t.team_name as 'Team Name', n.nation from player p, team t, nationality n where p.team_id = t.team_id and p.nationality_id = n.nationality_id and player_id = '" + playerid + "';";
            cmd = new MySqlCommand(sqlquery, conn);
            adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dtstats);
            lbl_pnames.Text = dtstats.Rows[0][0].ToString();
            lbl_poss.Text = dtstats.Rows[0][1].ToString();
            lbl_numbers.Text = dtstats.Rows[0][2].ToString();
            lbl_tnames.Text = dtstats.Rows[0][3].ToString();
            lbl_nats.Text = dtstats.Rows[0][4].ToString();
            sqlquery = $"SELECT `type` from dmatch where player_id = '{comb_pnames.SelectedValue.ToString()}';";
            cmd = new MySqlCommand(sqlquery, conn);
            adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dttype);
            int GO = 0; int PM = 0; int CY = 0; int CR = 0; int GW = 0; int GP = 0;
            for (int i = 0; i < dttype.Rows.Count; i++)
            {
                if (dttype.Rows[i][0].ToString() == "GO")
                {
                    GO++;
                }
                else if (dttype.Rows[i][0].ToString() == "PM")
                {
                    PM++;
                }
                else if (dttype.Rows[i][0].ToString() == "CY")
                {
                    CY++;
                }
                else if (dttype.Rows[i][0].ToString() == "CR")
                {
                    CR++;
                }
                else if (dttype.Rows[i][0].ToString() == "GW")
                {
                    GW++;
                }
                else if (dttype.Rows[i][0].ToString() == "GP")
                {
                    GP++;
                }
            }
            lbl_goalss.Text = GO.ToString();
            lbl_GO.Text = GW.ToString();
            lbl_GP.Text = GP.ToString();
            lbl_pens.Text = PM.ToString();
            lbl_yells.Text = CY.ToString();
            lbl_reds.Text = CR.ToString();
        }
    }
}
