using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;
using System.Web.Script.Serialization;
using System.Globalization;
using System.Collections;
using System.Runtime.InteropServices;
using System.Windows.Controls;

namespace RiotAPI
{
    public partial class MenuForm : Form
    {
        #region Global Variables
        RiotAPI.Properties.Settings ps = Properties.Settings.Default;
        // RiotAPI.Properties.Resources pr = Properties.Resources;
        public string aeroAPI = "701861ef-5e64-4c90-af18-fced09acb770";
        Color grey = Color.FromArgb(64, 64, 64);
        Color lblue = Color.FromArgb(46, 123, 175);
        bool isSoloClicked;
        ToolTip tt = new ToolTip();
        string selectedLeague;
        #endregion

        #region Constructor
        public MenuForm()
        {
            InitializeComponent();

            // Initialize Properties
            txtEnterAPI.Text = ps.saveAPI;
            lblLvl.Parent = pboSumIcon;
            lbl5v5.Enabled = false; // Not Yet Active
            lbl3v3.Enabled = false; // Not Yet Active
            cboLeaguesQueueType.Items.Add("Solo/Duo Queue");
            //cboLeaguesQueueType.Items.Add("5v5"); // Not Yet Active
            //cboLeaguesQueueType.Items.Add("3v3"); // Not Yet Active

            // Call Methods
            try
            {
                GetWebRequest();
                SetSummonerRankPicture();
                SetSoloWinsAndLosses();
                SetSoloLeaguePoints();
                SetSoloLeagueStatuses();
                SetSoloLeagueName();
                SetLeaguesTab();
            }
            catch (Exception ex)
            {
                this.Close();
            }
        }
        #endregion

        #region Methods
        private void CycleThroughLeagues(string L)
        {
            lvLeagues.Items.Clear();
            var newList = APIRequest.MySummoner.LeagueItemList.OrderByDescending(
                o => o["leaguePoints"])
                .ThenByDescending(o => o["wins"])
                .ToList();
            int i = 1;
            foreach (Dictionary<string, object> obj in newList)
            {
                ListViewItem item = new ListViewItem(i.ToString(), 0);
                item.SubItems.Add(obj["playerOrTeamName"].ToString());
                item.SubItems.Add("");
                item.SubItems.Add(obj["wins"].ToString());
                item.SubItems.Add(obj["leaguePoints"].ToString());
                lvLeagues.Items.AddRange(new ListViewItem[] { item });
                if (obj["rank"].ToString() != L)
                {
                    lvLeagues.Items.Remove(item);
                    i--;
                }
                i++;
            }
        }

        private void SetLeaguesTab()
        {
            pboLeaguesTier.Image = pboRanking.Image;
            lblLeaguesRank.Text = APIRequest.MySummoner.SoloRank;
            if (lblRanking.Text.ToLower() == "challenger i")
            {
                btnDownArrow.Visible = false;
                btnUpArrow.Visible = false;
                lblLeaguesRank.Visible = false;
            }
            if (lblLeaguesRank.Text == "I")
            {
                btnUpArrow.Enabled = false;
            }
            else if (lblLeaguesRank.Text == "V")
            {
                btnDownArrow.Enabled = false;
            }

            lblLeaguesLeagueName.Text = lblLeagueName.Text;
            lblLeaguesTierTitle.Text = lblRanking.Text;
        }
        
        private void SetSoloLeagueName()
        {
            lblLeagueName.Text = APIRequest.MySummoner.SoloLeagueName;
        }

        private void SetSoloLeagueStatuses()
        {
            if (APIRequest.MySummoner.isSoloFreshBlood == true)
                pboFreshBlood.Visible = true;
            else
                pboFreshBlood.Visible = false;
            if (APIRequest.MySummoner.isSoloHotStreak == true)
                pboHotStreak.Visible = true;
            else
                pboHotStreak.Visible = false;
            if (APIRequest.MySummoner.isSoloVeteran == true)
                pboVeteran.Visible = true;
            else
                pboVeteran.Visible = false;
            if (APIRequest.MySummoner.isSoloInactive == true && lblNormal.BackColor == grey)
                lblRanking.ForeColor = Color.Black;
            else
                lblRanking.ForeColor = Color.White;
        }

        private void SetSoloLeaguePoints()
        {
            lblLP.Text = APIRequest.MySummoner.SoloLeaguePoints.ToString() + " League Points";
        }

        private void SetSoloWinsAndLosses()
        {
            lblWinsNum.Text = APIRequest.MySummoner.SoloWins.ToString();
            lblLossesNum.Text = APIRequest.MySummoner.SoloLosses.ToString();
            if (APIRequest.MySummoner.SoloLosses <= 0)
            {
                lblLossesNum.Visible = false;
                lblLossestitle.Visible = false;
            }
        }

        private void SetSummonerRankPicture()
        {
            switch (lblRanking.Text.Substring(0, lblRanking.Text.IndexOf(" ")).ToLower())
            {
                case "bronze":
                    pboRanking.Image = Properties.Resources.bronze;
                    break;
                case "silver":
                    pboRanking.Image = Properties.Resources.silver;
                    break;
                case "gold":
                    pboRanking.Image = Properties.Resources.gold;
                    break;
                case "platinum":
                    pboRanking.Image = Properties.Resources.platinum;
                    break;
                case "diamond":
                    pboRanking.Image = Properties.Resources.diamond;
                    break;
                case "challenger":
                    pboRanking.Image = Properties.Resources.challenger;
                    break;
                default:
                    pboRanking.Image = Properties.Resources.unranked;
                    break;
            }
        }

        private void GetWebRequest()
        {
            try
            {
                APIRequest.MySummoner.SummonerWebRequest();
                ps.summonerID = APIRequest.MySummoner.GetID();
                ps.Save();
                APIRequest.MySummoner.UpdateURLRequest();
                lblSumID.Text = "ID: " + ps.summonerID;
                lnklblSumName.Text = APIRequest.MySummoner.GetName();
                tabUser.Text = APIRequest.MySummoner.GetName();
                pboSumIcon.Image = APIRequest.MySummoner.GetIcon();
                APIRequest.MySummoner.GetLeagueInfo();
                var newList = APIRequest.MySummoner.LeagueItemList.OrderByDescending(
                    o => o["leaguePoints"])
                    .ThenByDescending(o => o["wins"])
                    .ToList();
                int i = 1;
                lvLeagues.Columns.Add("Rank", 60, HorizontalAlignment.Center);
                lvLeagues.Columns.Add("Summoner", 400, HorizontalAlignment.Left);
                lvLeagues.Columns.Add("Emblems", 100, HorizontalAlignment.Center);
                lvLeagues.Columns.Add("Wins", 90, HorizontalAlignment.Center);
                lvLeagues.Columns.Add("LP", -2, HorizontalAlignment.Center);
                foreach (Dictionary<string, object> obj in newList)
                {
                    ListViewItem item = new ListViewItem(i.ToString(), 0);
                    item.SubItems.Add(obj["playerOrTeamName"].ToString());
                    item.SubItems.Add("");
                    item.SubItems.Add(obj["wins"].ToString());
                    item.SubItems.Add(obj["leaguePoints"].ToString());
                    lvLeagues.Items.AddRange(new ListViewItem[] { item });
                    if (obj["rank"].ToString() != APIRequest.MySummoner.SoloRank)
                    {
                        lvLeagues.Items.Remove(item);
                        i--;
                    }
                    i++;
                }
                if (APIRequest.MySummoner.GetSummonerLevel() < 30)
                {
                    lblNormal_Click(null, null);
                    lbl5v5.Enabled = false;
                    lbl3v3.Enabled = false;
                    lblSoloDuo.Enabled = false;
                }
                else
                    lblSoloDuo_Click(null, null);
                lblRevisionDateStr.Text = "Last Revised: " + APIRequest.MySummoner.GetRevisionDate();
                lblLvl.Text = APIRequest.MySummoner.GetSummonerLevel().ToString();
            }
            catch (WebException ex)
            {
                MessageBox.Show("Server Request Timeout... Closing Application");
                Application.Restart();
            }
        }
        #endregion

        #region Event Handlers
        private void lklblSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://developer.riotgames.com/");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://developer.riotgames.com/guidelines");
        }

        private void btnSaveAPI_Click(object sender, EventArgs e)
        {
            if (txtEnterAPI != null)
            {
                ps.saveAPI = txtEnterAPI.Text;
                ps.Save();
                lblIsSaved.Visible = true;
            }
        }

        private void txtEnterAPI_Click(object sender, EventArgs e)
        {
            txtEnterAPI.SelectAll();
        }

        private void lnklblReset_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtEnterAPI.Text = aeroAPI;
            ps.saveAPI = txtEnterAPI.Text;
            ps.Save();
        }

        private void tabAPIKey_Leave(object sender, EventArgs e)
        {
            lblIsSaved.Visible = false;
        }

        private void lnklblSumName_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(
                "http://www.lolking.net/summoner/" +
                ps.saveRegion + "/" +
                ps.summonerID);
        }

        private void lblSoloDuo_Click(object sender, EventArgs e)
        {
            isSoloClicked = true;

            lblLeagueName.Visible = true;
            lblWinsNum.Visible = true;
            lblwinstitle.Visible = true;

            lblSoloDuo.Font = new Font(lblSoloDuo.Font, FontStyle.Bold);
            lblSoloDuo.BackColor = lblue;

            lblRanking.Text = APIRequest.MySummoner.TierSolo + " " + APIRequest.MySummoner.SoloRank;
            SetSummonerRankPicture();
            SetSoloWinsAndLosses();
            SetSoloLeaguePoints();
            lblLP.Visible = true;

            lbl5v5.Font = new Font(lbl5v5.Font, FontStyle.Regular);
            lbl5v5.BackColor = grey;

            lbl3v3.Font = new Font(lbl5v5.Font, FontStyle.Regular);
            lbl3v3.BackColor = grey;

            lblNormal.Font = new Font(lblNormal.Font, FontStyle.Regular);
            lblNormal.BackColor = grey;

            SetSoloLeagueStatuses();
        }

        private void lbl5v5_Click(object sender, EventArgs e)
        {
            lblLP.Visible = true;
            lblSoloDuo.Font = new Font(lblSoloDuo.Font, FontStyle.Regular);
            lblSoloDuo.BackColor = grey;

            lbl5v5.Font = new Font(lbl5v5.Font, FontStyle.Bold);
            lbl5v5.BackColor = lblue;

            lbl3v3.Font = new Font(lbl5v5.Font, FontStyle.Regular);
            lbl3v3.BackColor = grey;

            lblNormal.Font = new Font(lblNormal.Font, FontStyle.Regular);
            lblNormal.BackColor = grey;

            SetSoloLeagueStatuses();
        }

        private void lbl3v3_Click(object sender, EventArgs e)
        {
            lblLP.Visible = true;
            lblSoloDuo.Font = new Font(lblSoloDuo.Font, FontStyle.Regular);
            lblSoloDuo.BackColor = grey;

            lbl5v5.Font = new Font(lbl5v5.Font, FontStyle.Regular);
            lbl5v5.BackColor = grey;

            lbl3v3.Font = new Font(lbl5v5.Font, FontStyle.Bold);
            lbl3v3.BackColor = lblue;

            lblNormal.Font = new Font(lblNormal.Font, FontStyle.Regular);
            lblNormal.BackColor = grey;

            SetSoloLeagueStatuses();
        }

        private void lblNormal_Click(object sender, EventArgs e)
        {
            isSoloClicked = false;

            SetSoloLeagueStatuses();
            lblLeagueName.Visible = false;
            lblwinstitle.Visible = false; // Not Yet Active
            lblWinsNum.Visible = false; // Not Yet Active

            lblRanking.ForeColor = Color.White;
            pboVeteran.Visible = false;
            pboHotStreak.Visible = false;
            pboFreshBlood.Visible = false;
            lblLP.Visible = false;
            pboRanking.Image = Properties.Resources.unranked;
            lblRanking.Text = "Level " + APIRequest.MySummoner.Level;

            lblSoloDuo.Font = new Font(lblSoloDuo.Font, FontStyle.Regular);
            lblSoloDuo.BackColor = grey;

            lbl5v5.Font = new Font(lbl5v5.Font, FontStyle.Regular);
            lbl5v5.BackColor = grey;

            lbl3v3.Font = new Font(lbl5v5.Font, FontStyle.Regular);
            lbl3v3.BackColor = grey;

            lblNormal.Font = new Font(lblNormal.Font, FontStyle.Bold);
            lblNormal.BackColor = lblue;
        }

        private void pboHotStreak_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.AutoPopDelay = 5000;
            tt.InitialDelay = 200;
            tt.SetToolTip(this.pboHotStreak, "Won 3 or more games in a row");
        }

        private void pboVeteran_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.AutoPopDelay = 5000;
            tt.InitialDelay = 200;
            tt.SetToolTip(this.pboVeteran, "Played 100 or more games in this League");
        }

        private void pboFreshBlood_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.AutoPopDelay = 5000;
            tt.InitialDelay = 200;
            tt.SetToolTip(this.pboFreshBlood, "Recently joined this League");
        }

        private void lblRanking_MouseHover(object sender, EventArgs e)
        {
            if (APIRequest.MySummoner.isSoloInactive == true && isSoloClicked == true)
            {
                tt.AutoPopDelay = 5000;
                tt.InitialDelay = 200;
                tt.SetToolTip(this.lblRanking, "Inactive");
            }
            else
            {
                tt.SetToolTip(this.lblRanking, "Active");
            }
        }

        private void btnDownArrow_Click(object sender, EventArgs e)
        {
            switch (lblLeaguesRank.Text)
            {
                case "I":
                    btnUpArrow.Enabled = true;
                    lblLeaguesRank.Text = "II";
                    lblLeaguesTierTitle.Text = APIRequest.MySummoner.TierSolo + " II";
                    selectedLeague = lblLeaguesRank.Text;
                    CycleThroughLeagues(selectedLeague);
                    break;
                case "II":
                    lblLeaguesRank.Text = "III";
                    lblLeaguesTierTitle.Text = APIRequest.MySummoner.TierSolo + " III";
                    selectedLeague = lblLeaguesRank.Text;
                    CycleThroughLeagues(selectedLeague);
                    break;
                case "III":
                    lblLeaguesRank.Text = "IV";
                    lblLeaguesTierTitle.Text = APIRequest.MySummoner.TierSolo + " IV";
                    selectedLeague = lblLeaguesRank.Text;
                    CycleThroughLeagues(selectedLeague);
                    break;
                case "IV":
                    lblLeaguesRank.Text = "V";
                    lblLeaguesTierTitle.Text = APIRequest.MySummoner.TierSolo + " V";
                    btnDownArrow.Enabled = false;
                    selectedLeague = lblLeaguesRank.Text;
                    CycleThroughLeagues(selectedLeague);
                    break;
            }
        }

        private void btnUpArrow_Click(object sender, EventArgs e)
        {
            switch (lblLeaguesRank.Text)
            {
                case "V":
                    btnDownArrow.Enabled = true;
                    lblLeaguesRank.Text = "IV";
                    lblLeaguesTierTitle.Text = APIRequest.MySummoner.TierSolo + " IV";
                    selectedLeague = lblLeaguesRank.Text;
                    CycleThroughLeagues(selectedLeague);
                    break;
                case "IV":
                    lblLeaguesRank.Text = "III";
                    lblLeaguesTierTitle.Text = APIRequest.MySummoner.TierSolo + " III";
                    selectedLeague = lblLeaguesRank.Text;
                    CycleThroughLeagues(selectedLeague);
                    break;
                case "III":
                    lblLeaguesRank.Text = "II";
                    lblLeaguesTierTitle.Text = APIRequest.MySummoner.TierSolo + " II";
                    selectedLeague = lblLeaguesRank.Text;
                    CycleThroughLeagues(selectedLeague);
                    break;
                case "II":
                    lblLeaguesRank.Text = "I";
                    lblLeaguesTierTitle.Text = APIRequest.MySummoner.TierSolo + " I";
                    selectedLeague = lblLeaguesRank.Text;
                    btnUpArrow.Enabled = false;
                    CycleThroughLeagues(selectedLeague);
                    break;
            }
        }
        #endregion
        #region Events Not Used
        private void pboLeague_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
        private void lblIsSaved_Leave(object sender, EventArgs e)
        {

        }
        private void tbcSums_ContextMenuStripChanged(object sender, EventArgs e)
        {

        }
        private void tabLeague_Click(object sender, EventArgs e)
        {

        }
        private void lvLeagues_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        #endregion}

        private void lvLeagues_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            
        }

        private void lvLeagues_DoubleClick(object sender, EventArgs e)
        {
            
        }
    }
}
