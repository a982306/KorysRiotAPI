using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RiotAPI
{
    /// <summary>
    /// This program will utilize the Riot Development API beta to
    /// attend to the needs of summoners as they progress through the rift.
    /// API Key: 701861ef-5e64-4c90-af18-fced09acb770
    /// Rate Limits:
    /// 500 request(s) every 10 minutes(s)
    /// 10 request(s) every 10 seconds(s)
    /// </summary>
    public partial class SummonerNameForm : Form
    {
        #region Global Variables
        RiotAPI.Properties.Settings ps = Properties.Settings.Default;
        public bool isLoggedIn = false;
        public string aeroAPI = "701861ef-5e64-4c90-af18-fced09acb770";
        #endregion

        #region Constructor
        public SummonerNameForm()
        {
            InitializeComponent();

            // Intialize Properties
            txtBoxSumName.Text = ps.saveSummonerName;
            cbo_region.Text = ps.saveRegion;
            cbo_region.Items.Add("NA");
            cbo_region.Items.Add("EUW");
            cbo_region.Items.Add("EUNE");
            //cbo_region.Items.Add("BR");
            //cbo_region.Items.Add("TR");
            //cbo_region.Items.Add("RU");
            //cbo_region.Items.Add("LAN");
            //cbo_region.Items.Add("LAS");
            //cbo_region.Items.Add("OCE");

            // Initialize Settings
            if (ps.saveChkBox == true)
            {
                cbo_region.Text = ps.saveRegion;
                txtBoxSumName.Text = ps.saveSummonerName;
                chkSave.Checked = true;
            }
            else
            {
                cbo_region.Text = "NA";
                txtBoxSumName.Text = null;
                chkSave.Checked = false;
            }
        }
        #endregion

        #region Event Handlers
        // Event Handler Functions
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            isLoggedIn = true;
            this.Close();
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSave.Checked == true)
            {
                ps.saveChkBox = true;
                ps.Save();
                APIRequest.MySummoner.UpdateURLRequest();
            }
            else
            {
                ps.saveChkBox = false;
                ps.Save();
                APIRequest.MySummoner.UpdateURLRequest();
            }
        }

        private void txtBoxSumName_TextChanged(object sender, EventArgs e)
        {
            ps.saveSummonerName = txtBoxSumName.Text;
            ps.Save();
            APIRequest.MySummoner.UpdateURLRequest();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ps.saveRegion = cbo_region.Text.ToLower();
            ps.Save();
            APIRequest.MySummoner.UpdateURLRequest();
        }

        private void SummonerNameForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isLoggedIn == false)
                Application.Exit();
        }
        #endregion
    }
}
