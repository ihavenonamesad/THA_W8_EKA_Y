using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace THA_W8_EKA_Y
{
    public partial class Find_Match : Form
    {
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        string connectionstring;
        string sqlquery;
        DataTable dtmatch = new DataTable();
        DataTable dtteam = new DataTable();
        public Find_Match()
        {
            InitializeComponent();
        }

        private void Find_Match_Load(object sender, EventArgs e)
        {
            connectionstring = "server=localhost;uid=root;pwd=;database=premier_league";
            conn = new MySqlConnection(connectionstring);

            sqlquery = "SELECT team_name as 'Team Name', team_id as 'ID'from team";
            cmd = new MySqlCommand(sqlquery, conn);
            adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dtteam);
            comb_teamhome.DataSource = dtteam;
            comb_teamhome.ValueMember = "ID";
            comb_teamhome.DisplayMember = "Team Name";

        }

        private void dgv_match_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            
        }

        private void comb_teamfight_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataTable dtlblscores = new DataTable();
            string matchid = dtmatch.Rows[comb_teamfight.SelectedIndex][0].ToString();
            string teamid = dtmatch.Rows[comb_teamfight.SelectedIndex][2].ToString();
            string teamid2 = dtmatch.Rows[comb_teamfight.SelectedIndex][4].ToString();
            sqlquery = $"SELECT t.team_name as 'Team Home', tm.team_name as 'Team Away', m.goal_home, m.goal_away, m.match_date, r.referee_name FROM  team t, `match` m, team tm, referee r where t.team_id = m.team_home and tm.team_id = m.team_away and m.match_id = '{matchid}' and m.referee_id = r.referee_id union select t.team_name as 'Team Home', tm.team_name as 'Team Away', m.goal_home, m.goal_away, m.match_date, r.referee_name from  team t, `match` m, team tm, referee r where t.team_id = m.team_home and tm.team_id = m.team_away and m.match_id = '{matchid}' and m.referee_id = r.referee_id; ";
            cmd = new MySqlCommand(sqlquery, conn);
            adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dtlblscores);
            lbl_teamhome.Text = dtlblscores.Rows[0][0].ToString();
            lbl_teamaway.Text = dtlblscores.Rows[0][1].ToString();
            lbl_homescore.Text = dtlblscores.Rows[0][2].ToString();
            lbl_awayscore.Text = dtlblscores.Rows[0][3].ToString();
            lbl_date.Text = dtlblscores.Rows[0][4].ToString();
            lbl_ref.Text = dtlblscores.Rows[0][5].ToString();
            DataTable dtdmatch = new DataTable();
            sqlquery = $"select t.team_name as 'Team Name', p.player_name as 'Player Name', d.`type` as 'Type' ,d.`minute` as 'Minute' from team t, player p, dmatch d where p.player_id = d.player_id and t.team_id = d.team_id and d.match_id='{matchid}';";
            cmd = new MySqlCommand(sqlquery, conn);
            adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dtdmatch);
            dataGridView2.DataSource = dtdmatch;

            DataTable dtplayer = new DataTable();
            sqlquery = $"select t.team_name as 'Team Name', p.player_name as 'Player Name', p.playing_pos as 'Position' from player p, team t where t.team_id = '{teamid}' and p.team_id = '{teamid}';";
            cmd = new MySqlCommand(sqlquery, conn);
            adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dtplayer);
            t1.DataSource = dtplayer;

            DataTable dtplayer2 = new DataTable();
            sqlquery = $"select t.team_name as 'Team Name', p.player_name as 'Player Name', p.playing_pos as 'Position' from player p, team t where t.team_id = '{teamid2}' and p.team_id = '{teamid2}';";
            cmd = new MySqlCommand(sqlquery, conn);
            adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dtplayer2);
            t2.DataSource = dtplayer2;
        }

        private void comb_teamhome_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }

        private void btn_match_Click(object sender, EventArgs e)
        {
            dtmatch.Clear();
            dtmatch.Columns.Clear();
            comb_teamfight.Items.Clear();
            string simpan = comb_teamhome.Text;
            sqlquery = $"SELECT m.match_id as 'Match ID', t.team_name as 'Team Home', t.team_id as 'ID', tm.team_name as 'Team Away', tm.team_id as 'ID' FROM team t, `match` m, team tm where t.team_id = m.team_home and tm.team_id = m.team_away and t.team_name = '{simpan}' or t.team_id = m.team_home and tm.team_id = m.team_away and tm.team_name = '{simpan}' order by case when tm.team_name = '{simpan}' then 3 end";
            cmd = new MySqlCommand(sqlquery, conn);
            adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dtmatch);
            dtmatch.Columns.Add("title");
            for (int i = 0; i < dtmatch.Rows.Count; i++)
            {
                dtmatch.Rows[i][5] = dtmatch.Rows[i][1].ToString() + " vs " + dtmatch.Rows[i][3].ToString();
                comb_teamfight.Items.Add(dtmatch.Rows[i][5]);
            }
        }
    }
}
