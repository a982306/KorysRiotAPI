namespace RiotAPI
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.tbcSums = new System.Windows.Forms.TabControl();
            this.tabUser = new System.Windows.Forms.TabPage();
            this.lblLeagueName = new System.Windows.Forms.Label();
            this.lblRanking = new System.Windows.Forms.Label();
            this.pboVeteran = new System.Windows.Forms.PictureBox();
            this.pboFreshBlood = new System.Windows.Forms.PictureBox();
            this.pboHotStreak = new System.Windows.Forms.PictureBox();
            this.lblNormal = new System.Windows.Forms.Label();
            this.lblLvl = new System.Windows.Forms.Label();
            this.lblRevisionDateStr = new System.Windows.Forms.Label();
            this.lblLP = new System.Windows.Forms.Label();
            this.lblWinsNum = new System.Windows.Forms.Label();
            this.lblLossesNum = new System.Windows.Forms.Label();
            this.lblLossestitle = new System.Windows.Forms.Label();
            this.lblwinstitle = new System.Windows.Forms.Label();
            this.lblSoloDuo = new System.Windows.Forms.Label();
            this.lbl3v3 = new System.Windows.Forms.Label();
            this.lbl5v5 = new System.Windows.Forms.Label();
            this.pboRanking = new System.Windows.Forms.PictureBox();
            this.lblSumID = new System.Windows.Forms.Label();
            this.lnklblSumName = new System.Windows.Forms.LinkLabel();
            this.pboSumIcon = new System.Windows.Forms.PictureBox();
            this.tabLeague = new System.Windows.Forms.TabPage();
            this.cboLeaguesQueueType = new System.Windows.Forms.ComboBox();
            this.lblLeaguesTierTitle = new System.Windows.Forms.Label();
            this.lblLeaguesLeagueName = new System.Windows.Forms.Label();
            this.btnDownArrow = new System.Windows.Forms.Button();
            this.btnUpArrow = new System.Windows.Forms.Button();
            this.lblLeaguesRank = new System.Windows.Forms.Label();
            this.pboLeaguesTier = new System.Windows.Forms.PictureBox();
            this.lvLeagues = new System.Windows.Forms.ListView();
            this.tabMatches = new System.Windows.Forms.TabPage();
            this.tabAPIKey = new System.Windows.Forms.TabPage();
            this.lnklblReset = new System.Windows.Forms.LinkLabel();
            this.lblIsSaved = new System.Windows.Forms.Label();
            this.lblAPIKeyTitle = new System.Windows.Forms.Label();
            this.btnSaveAPI = new System.Windows.Forms.Button();
            this.txtEnterAPI = new System.Windows.Forms.TextBox();
            this.lblGettingStartedInstructions = new System.Windows.Forms.Label();
            this.lblGettingStartedTitle = new System.Windows.Forms.Label();
            this.lblInstructionTitle = new System.Windows.Forms.Label();
            this.lnklblTnC = new System.Windows.Forms.LinkLabel();
            this.lklblSignUp = new System.Windows.Forms.LinkLabel();
            this.lblAPIInstructions = new System.Windows.Forms.Label();
            this.tbcSums.SuspendLayout();
            this.tabUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboVeteran)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboFreshBlood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboHotStreak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboRanking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboSumIcon)).BeginInit();
            this.tabLeague.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboLeaguesTier)).BeginInit();
            this.tabAPIKey.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcSums
            // 
            this.tbcSums.Controls.Add(this.tabUser);
            this.tbcSums.Controls.Add(this.tabLeague);
            this.tbcSums.Controls.Add(this.tabMatches);
            this.tbcSums.Controls.Add(this.tabAPIKey);
            this.tbcSums.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcSums.Location = new System.Drawing.Point(0, 0);
            this.tbcSums.Name = "tbcSums";
            this.tbcSums.SelectedIndex = 0;
            this.tbcSums.Size = new System.Drawing.Size(744, 425);
            this.tbcSums.TabIndex = 0;
            this.tbcSums.ContextMenuStripChanged += new System.EventHandler(this.tbcSums_ContextMenuStripChanged);
            // 
            // tabUser
            // 
            this.tabUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabUser.Controls.Add(this.lblLeagueName);
            this.tabUser.Controls.Add(this.lblRanking);
            this.tabUser.Controls.Add(this.pboVeteran);
            this.tabUser.Controls.Add(this.pboFreshBlood);
            this.tabUser.Controls.Add(this.pboHotStreak);
            this.tabUser.Controls.Add(this.lblNormal);
            this.tabUser.Controls.Add(this.lblLvl);
            this.tabUser.Controls.Add(this.lblRevisionDateStr);
            this.tabUser.Controls.Add(this.lblLP);
            this.tabUser.Controls.Add(this.lblWinsNum);
            this.tabUser.Controls.Add(this.lblLossesNum);
            this.tabUser.Controls.Add(this.lblLossestitle);
            this.tabUser.Controls.Add(this.lblwinstitle);
            this.tabUser.Controls.Add(this.lblSoloDuo);
            this.tabUser.Controls.Add(this.lbl3v3);
            this.tabUser.Controls.Add(this.lbl5v5);
            this.tabUser.Controls.Add(this.pboRanking);
            this.tabUser.Controls.Add(this.lblSumID);
            this.tabUser.Controls.Add(this.lnklblSumName);
            this.tabUser.Controls.Add(this.pboSumIcon);
            this.tabUser.Location = new System.Drawing.Point(4, 22);
            this.tabUser.Name = "tabUser";
            this.tabUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabUser.Size = new System.Drawing.Size(736, 399);
            this.tabUser.TabIndex = 0;
            this.tabUser.Text = "Summoner";
            // 
            // lblLeagueName
            // 
            this.lblLeagueName.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeagueName.ForeColor = System.Drawing.Color.Gold;
            this.lblLeagueName.Location = new System.Drawing.Point(532, 49);
            this.lblLeagueName.Name = "lblLeagueName";
            this.lblLeagueName.Size = new System.Drawing.Size(199, 22);
            this.lblLeagueName.TabIndex = 20;
            this.lblLeagueName.Text = "Skarner\'s Sorcerers";
            this.lblLeagueName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRanking
            // 
            this.lblRanking.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRanking.ForeColor = System.Drawing.Color.White;
            this.lblRanking.Location = new System.Drawing.Point(532, 226);
            this.lblRanking.Name = "lblRanking";
            this.lblRanking.Size = new System.Drawing.Size(200, 29);
            this.lblRanking.TabIndex = 4;
            this.lblRanking.Text = "Unranked";
            this.lblRanking.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRanking.MouseHover += new System.EventHandler(this.lblRanking_MouseHover);
            // 
            // pboVeteran
            // 
            this.pboVeteran.Image = global::RiotAPI.Properties.Resources.veteran;
            this.pboVeteran.Location = new System.Drawing.Point(695, 258);
            this.pboVeteran.Name = "pboVeteran";
            this.pboVeteran.Size = new System.Drawing.Size(25, 25);
            this.pboVeteran.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboVeteran.TabIndex = 19;
            this.pboVeteran.TabStop = false;
            this.pboVeteran.Visible = false;
            this.pboVeteran.MouseHover += new System.EventHandler(this.pboVeteran_MouseHover);
            // 
            // pboFreshBlood
            // 
            this.pboFreshBlood.Image = global::RiotAPI.Properties.Resources.freshblood;
            this.pboFreshBlood.Location = new System.Drawing.Point(695, 258);
            this.pboFreshBlood.Name = "pboFreshBlood";
            this.pboFreshBlood.Size = new System.Drawing.Size(25, 25);
            this.pboFreshBlood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboFreshBlood.TabIndex = 18;
            this.pboFreshBlood.TabStop = false;
            this.pboFreshBlood.Visible = false;
            this.pboFreshBlood.MouseHover += new System.EventHandler(this.pboFreshBlood_MouseHover);
            // 
            // pboHotStreak
            // 
            this.pboHotStreak.Image = global::RiotAPI.Properties.Resources.hotstreak;
            this.pboHotStreak.Location = new System.Drawing.Point(544, 258);
            this.pboHotStreak.Name = "pboHotStreak";
            this.pboHotStreak.Size = new System.Drawing.Size(25, 25);
            this.pboHotStreak.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboHotStreak.TabIndex = 17;
            this.pboHotStreak.TabStop = false;
            this.pboHotStreak.Visible = false;
            this.pboHotStreak.MouseHover += new System.EventHandler(this.pboHotStreak_MouseHover);
            // 
            // lblNormal
            // 
            this.lblNormal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNormal.ForeColor = System.Drawing.Color.White;
            this.lblNormal.Location = new System.Drawing.Point(561, 3);
            this.lblNormal.Name = "lblNormal";
            this.lblNormal.Size = new System.Drawing.Size(142, 20);
            this.lblNormal.TabIndex = 16;
            this.lblNormal.Text = "Normal";
            this.lblNormal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNormal.Click += new System.EventHandler(this.lblNormal_Click);
            // 
            // lblLvl
            // 
            this.lblLvl.BackColor = System.Drawing.Color.Transparent;
            this.lblLvl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLvl.ForeColor = System.Drawing.Color.White;
            this.lblLvl.Location = new System.Drawing.Point(45, 50);
            this.lblLvl.Name = "lblLvl";
            this.lblLvl.Size = new System.Drawing.Size(21, 15);
            this.lblLvl.TabIndex = 15;
            this.lblLvl.Text = "30";
            // 
            // lblRevisionDateStr
            // 
            this.lblRevisionDateStr.AutoSize = true;
            this.lblRevisionDateStr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRevisionDateStr.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lblRevisionDateStr.Location = new System.Drawing.Point(4, 75);
            this.lblRevisionDateStr.Name = "lblRevisionDateStr";
            this.lblRevisionDateStr.Size = new System.Drawing.Size(203, 15);
            this.lblRevisionDateStr.TabIndex = 13;
            this.lblRevisionDateStr.Text = "Last Login: 12/12/12 07:59 PM";
            this.lblRevisionDateStr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLP
            // 
            this.lblLP.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLP.ForeColor = System.Drawing.Color.White;
            this.lblLP.Location = new System.Drawing.Point(529, 258);
            this.lblLP.Name = "lblLP";
            this.lblLP.Size = new System.Drawing.Size(202, 18);
            this.lblLP.TabIndex = 12;
            this.lblLP.Text = "0 League Points";
            this.lblLP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWinsNum
            // 
            this.lblWinsNum.AutoSize = true;
            this.lblWinsNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinsNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblWinsNum.Location = new System.Drawing.Point(637, 287);
            this.lblWinsNum.Name = "lblWinsNum";
            this.lblWinsNum.Size = new System.Drawing.Size(18, 20);
            this.lblWinsNum.TabIndex = 11;
            this.lblWinsNum.Text = "0";
            // 
            // lblLossesNum
            // 
            this.lblLossesNum.AutoSize = true;
            this.lblLossesNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLossesNum.ForeColor = System.Drawing.Color.Red;
            this.lblLossesNum.Location = new System.Drawing.Point(637, 316);
            this.lblLossesNum.Name = "lblLossesNum";
            this.lblLossesNum.Size = new System.Drawing.Size(18, 20);
            this.lblLossesNum.TabIndex = 10;
            this.lblLossesNum.Text = "0";
            // 
            // lblLossestitle
            // 
            this.lblLossestitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLossestitle.ForeColor = System.Drawing.Color.Gold;
            this.lblLossestitle.Location = new System.Drawing.Point(486, 316);
            this.lblLossestitle.Name = "lblLossestitle";
            this.lblLossestitle.Size = new System.Drawing.Size(146, 20);
            this.lblLossestitle.TabIndex = 9;
            this.lblLossestitle.Text = "Losses:";
            this.lblLossestitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblwinstitle
            // 
            this.lblwinstitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwinstitle.ForeColor = System.Drawing.Color.Gold;
            this.lblwinstitle.Location = new System.Drawing.Point(505, 287);
            this.lblwinstitle.Name = "lblwinstitle";
            this.lblwinstitle.Size = new System.Drawing.Size(127, 20);
            this.lblwinstitle.TabIndex = 8;
            this.lblwinstitle.Text = "Wins:";
            this.lblwinstitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSoloDuo
            // 
            this.lblSoloDuo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(123)))), ((int)(((byte)(175)))));
            this.lblSoloDuo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSoloDuo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoloDuo.ForeColor = System.Drawing.Color.White;
            this.lblSoloDuo.Location = new System.Drawing.Point(599, 27);
            this.lblSoloDuo.Name = "lblSoloDuo";
            this.lblSoloDuo.Size = new System.Drawing.Size(65, 20);
            this.lblSoloDuo.TabIndex = 7;
            this.lblSoloDuo.Text = "Solo/Duo";
            this.lblSoloDuo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSoloDuo.Click += new System.EventHandler(this.lblSoloDuo_Click);
            // 
            // lbl3v3
            // 
            this.lbl3v3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl3v3.ForeColor = System.Drawing.Color.White;
            this.lbl3v3.Location = new System.Drawing.Point(666, 27);
            this.lbl3v3.Name = "lbl3v3";
            this.lbl3v3.Size = new System.Drawing.Size(65, 20);
            this.lbl3v3.TabIndex = 6;
            this.lbl3v3.Text = "3v3";
            this.lbl3v3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl3v3.Click += new System.EventHandler(this.lbl3v3_Click);
            // 
            // lbl5v5
            // 
            this.lbl5v5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl5v5.ForeColor = System.Drawing.Color.White;
            this.lbl5v5.Location = new System.Drawing.Point(532, 27);
            this.lbl5v5.Name = "lbl5v5";
            this.lbl5v5.Size = new System.Drawing.Size(65, 20);
            this.lbl5v5.TabIndex = 5;
            this.lbl5v5.Text = "5v5";
            this.lbl5v5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl5v5.Click += new System.EventHandler(this.lbl5v5_Click);
            // 
            // pboRanking
            // 
            this.pboRanking.Image = global::RiotAPI.Properties.Resources.unranked;
            this.pboRanking.Location = new System.Drawing.Point(532, 55);
            this.pboRanking.Name = "pboRanking";
            this.pboRanking.Size = new System.Drawing.Size(200, 200);
            this.pboRanking.TabIndex = 3;
            this.pboRanking.TabStop = false;
            // 
            // lblSumID
            // 
            this.lblSumID.AutoSize = true;
            this.lblSumID.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblSumID.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSumID.ForeColor = System.Drawing.Color.White;
            this.lblSumID.Location = new System.Drawing.Point(83, 44);
            this.lblSumID.Name = "lblSumID";
            this.lblSumID.Size = new System.Drawing.Size(86, 20);
            this.lblSumID.TabIndex = 2;
            this.lblSumID.Text = "ID: 00000000";
            this.lblSumID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lnklblSumName
            // 
            this.lnklblSumName.AutoSize = true;
            this.lnklblSumName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnklblSumName.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnklblSumName.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnklblSumName.LinkColor = System.Drawing.Color.White;
            this.lnklblSumName.Location = new System.Drawing.Point(81, 8);
            this.lnklblSumName.Name = "lnklblSumName";
            this.lnklblSumName.Size = new System.Drawing.Size(157, 36);
            this.lnklblSumName.TabIndex = 1;
            this.lnklblSumName.TabStop = true;
            this.lnklblSumName.Text = "Name by ID";
            this.lnklblSumName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lnklblSumName.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblSumName_LinkClicked);
            // 
            // pboSumIcon
            // 
            this.pboSumIcon.Location = new System.Drawing.Point(8, 8);
            this.pboSumIcon.Name = "pboSumIcon";
            this.pboSumIcon.Size = new System.Drawing.Size(64, 64);
            this.pboSumIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboSumIcon.TabIndex = 0;
            this.pboSumIcon.TabStop = false;
            // 
            // tabLeague
            // 
            this.tabLeague.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabLeague.Controls.Add(this.cboLeaguesQueueType);
            this.tabLeague.Controls.Add(this.lblLeaguesTierTitle);
            this.tabLeague.Controls.Add(this.lblLeaguesLeagueName);
            this.tabLeague.Controls.Add(this.btnDownArrow);
            this.tabLeague.Controls.Add(this.btnUpArrow);
            this.tabLeague.Controls.Add(this.lblLeaguesRank);
            this.tabLeague.Controls.Add(this.pboLeaguesTier);
            this.tabLeague.Controls.Add(this.lvLeagues);
            this.tabLeague.Location = new System.Drawing.Point(4, 22);
            this.tabLeague.Name = "tabLeague";
            this.tabLeague.Padding = new System.Windows.Forms.Padding(3);
            this.tabLeague.Size = new System.Drawing.Size(736, 399);
            this.tabLeague.TabIndex = 3;
            this.tabLeague.Text = "Leagues";
            this.tabLeague.Click += new System.EventHandler(this.tabLeague_Click);
            // 
            // cboLeaguesQueueType
            // 
            this.cboLeaguesQueueType.FormattingEnabled = true;
            this.cboLeaguesQueueType.Location = new System.Drawing.Point(595, 21);
            this.cboLeaguesQueueType.Name = "cboLeaguesQueueType";
            this.cboLeaguesQueueType.Size = new System.Drawing.Size(121, 21);
            this.cboLeaguesQueueType.TabIndex = 23;
            this.cboLeaguesQueueType.TabStop = false;
            this.cboLeaguesQueueType.Text = "Solo/Duo Queue";
            // 
            // lblLeaguesTierTitle
            // 
            this.lblLeaguesTierTitle.AutoSize = true;
            this.lblLeaguesTierTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeaguesTierTitle.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblLeaguesTierTitle.Location = new System.Drawing.Point(166, 36);
            this.lblLeaguesTierTitle.Name = "lblLeaguesTierTitle";
            this.lblLeaguesTierTitle.Size = new System.Drawing.Size(107, 18);
            this.lblLeaguesTierTitle.TabIndex = 22;
            this.lblLeaguesTierTitle.Text = "Gold, Division I";
            this.lblLeaguesTierTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLeaguesLeagueName
            // 
            this.lblLeaguesLeagueName.AutoSize = true;
            this.lblLeaguesLeagueName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeaguesLeagueName.ForeColor = System.Drawing.Color.White;
            this.lblLeaguesLeagueName.Location = new System.Drawing.Point(165, 8);
            this.lblLeaguesLeagueName.Name = "lblLeaguesLeagueName";
            this.lblLeaguesLeagueName.Size = new System.Drawing.Size(175, 24);
            this.lblLeaguesLeagueName.TabIndex = 21;
            this.lblLeaguesLeagueName.Text = "Elise\'s Corruptors";
            this.lblLeaguesLeagueName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDownArrow
            // 
            this.btnDownArrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDownArrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownArrow.Image = global::RiotAPI.Properties.Resources.rsz_downarrow;
            this.btnDownArrow.Location = new System.Drawing.Point(123, 34);
            this.btnDownArrow.Name = "btnDownArrow";
            this.btnDownArrow.Size = new System.Drawing.Size(25, 24);
            this.btnDownArrow.TabIndex = 20;
            this.btnDownArrow.UseVisualStyleBackColor = true;
            this.btnDownArrow.Click += new System.EventHandler(this.btnDownArrow_Click);
            // 
            // btnUpArrow
            // 
            this.btnUpArrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpArrow.Image = global::RiotAPI.Properties.Resources.rsz_uparrow;
            this.btnUpArrow.Location = new System.Drawing.Point(123, 8);
            this.btnUpArrow.Name = "btnUpArrow";
            this.btnUpArrow.Size = new System.Drawing.Size(25, 24);
            this.btnUpArrow.TabIndex = 18;
            this.btnUpArrow.UseVisualStyleBackColor = true;
            this.btnUpArrow.Click += new System.EventHandler(this.btnUpArrow_Click);
            // 
            // lblLeaguesRank
            // 
            this.lblLeaguesRank.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeaguesRank.ForeColor = System.Drawing.Color.White;
            this.lblLeaguesRank.Location = new System.Drawing.Point(72, 10);
            this.lblLeaguesRank.Name = "lblLeaguesRank";
            this.lblLeaguesRank.Size = new System.Drawing.Size(50, 46);
            this.lblLeaguesRank.TabIndex = 17;
            this.lblLeaguesRank.Text = "IV";
            this.lblLeaguesRank.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pboLeaguesTier
            // 
            this.pboLeaguesTier.Location = new System.Drawing.Point(8, 6);
            this.pboLeaguesTier.Name = "pboLeaguesTier";
            this.pboLeaguesTier.Size = new System.Drawing.Size(63, 57);
            this.pboLeaguesTier.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboLeaguesTier.TabIndex = 1;
            this.pboLeaguesTier.TabStop = false;
            this.pboLeaguesTier.Click += new System.EventHandler(this.pboLeague_Click);
            // 
            // lvLeagues
            // 
            this.lvLeagues.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lvLeagues.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lvLeagues.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvLeagues.ForeColor = System.Drawing.Color.White;
            this.lvLeagues.FullRowSelect = true;
            this.lvLeagues.Location = new System.Drawing.Point(3, 66);
            this.lvLeagues.Name = "lvLeagues";
            this.lvLeagues.Size = new System.Drawing.Size(730, 330);
            this.lvLeagues.TabIndex = 0;
            this.lvLeagues.UseCompatibleStateImageBehavior = false;
            this.lvLeagues.View = System.Windows.Forms.View.Details;
            this.lvLeagues.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvLeagues_ItemSelectionChanged);
            this.lvLeagues.SelectedIndexChanged += new System.EventHandler(this.lvLeagues_SelectedIndexChanged);
            this.lvLeagues.DoubleClick += new System.EventHandler(this.lvLeagues_DoubleClick);
            // 
            // tabMatches
            // 
            this.tabMatches.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabMatches.Location = new System.Drawing.Point(4, 22);
            this.tabMatches.Name = "tabMatches";
            this.tabMatches.Padding = new System.Windows.Forms.Padding(3);
            this.tabMatches.Size = new System.Drawing.Size(736, 399);
            this.tabMatches.TabIndex = 1;
            this.tabMatches.Text = "Matches";
            // 
            // tabAPIKey
            // 
            this.tabAPIKey.Controls.Add(this.lnklblReset);
            this.tabAPIKey.Controls.Add(this.lblIsSaved);
            this.tabAPIKey.Controls.Add(this.lblAPIKeyTitle);
            this.tabAPIKey.Controls.Add(this.btnSaveAPI);
            this.tabAPIKey.Controls.Add(this.txtEnterAPI);
            this.tabAPIKey.Controls.Add(this.lblGettingStartedInstructions);
            this.tabAPIKey.Controls.Add(this.lblGettingStartedTitle);
            this.tabAPIKey.Controls.Add(this.lblInstructionTitle);
            this.tabAPIKey.Controls.Add(this.lnklblTnC);
            this.tabAPIKey.Controls.Add(this.lklblSignUp);
            this.tabAPIKey.Controls.Add(this.lblAPIInstructions);
            this.tabAPIKey.Location = new System.Drawing.Point(4, 22);
            this.tabAPIKey.Name = "tabAPIKey";
            this.tabAPIKey.Padding = new System.Windows.Forms.Padding(3);
            this.tabAPIKey.Size = new System.Drawing.Size(736, 399);
            this.tabAPIKey.TabIndex = 2;
            this.tabAPIKey.Text = "API Key";
            this.tabAPIKey.UseVisualStyleBackColor = true;
            this.tabAPIKey.Leave += new System.EventHandler(this.tabAPIKey_Leave);
            // 
            // lnklblReset
            // 
            this.lnklblReset.AutoSize = true;
            this.lnklblReset.Location = new System.Drawing.Point(418, 222);
            this.lnklblReset.Name = "lnklblReset";
            this.lnklblReset.Size = new System.Drawing.Size(35, 13);
            this.lnklblReset.TabIndex = 12;
            this.lnklblReset.TabStop = true;
            this.lnklblReset.Text = "Reset";
            this.lnklblReset.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblReset_LinkClicked);
            // 
            // lblIsSaved
            // 
            this.lblIsSaved.AutoSize = true;
            this.lblIsSaved.ForeColor = System.Drawing.Color.Blue;
            this.lblIsSaved.Location = new System.Drawing.Point(618, 233);
            this.lblIsSaved.Name = "lblIsSaved";
            this.lblIsSaved.Size = new System.Drawing.Size(41, 13);
            this.lblIsSaved.TabIndex = 11;
            this.lblIsSaved.Text = "Saved!";
            this.lblIsSaved.Visible = false;
            this.lblIsSaved.Leave += new System.EventHandler(this.lblIsSaved_Leave);
            // 
            // lblAPIKeyTitle
            // 
            this.lblAPIKeyTitle.AutoSize = true;
            this.lblAPIKeyTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAPIKeyTitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAPIKeyTitle.Location = new System.Drawing.Point(480, 177);
            this.lblAPIKeyTitle.Name = "lblAPIKeyTitle";
            this.lblAPIKeyTitle.Size = new System.Drawing.Size(150, 18);
            this.lblAPIKeyTitle.TabIndex = 10;
            this.lblAPIKeyTitle.Text = "API Development Key";
            this.lblAPIKeyTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSaveAPI
            // 
            this.btnSaveAPI.Location = new System.Drawing.Point(500, 226);
            this.btnSaveAPI.Name = "btnSaveAPI";
            this.btnSaveAPI.Size = new System.Drawing.Size(112, 26);
            this.btnSaveAPI.TabIndex = 9;
            this.btnSaveAPI.Text = "Save";
            this.btnSaveAPI.UseVisualStyleBackColor = true;
            this.btnSaveAPI.Click += new System.EventHandler(this.btnSaveAPI_Click);
            // 
            // txtEnterAPI
            // 
            this.txtEnterAPI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnterAPI.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtEnterAPI.Location = new System.Drawing.Point(421, 198);
            this.txtEnterAPI.Name = "txtEnterAPI";
            this.txtEnterAPI.PasswordChar = '●';
            this.txtEnterAPI.Size = new System.Drawing.Size(291, 21);
            this.txtEnterAPI.TabIndex = 8;
            this.txtEnterAPI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEnterAPI.Click += new System.EventHandler(this.txtEnterAPI_Click);
            // 
            // lblGettingStartedInstructions
            // 
            this.lblGettingStartedInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGettingStartedInstructions.Location = new System.Drawing.Point(418, 80);
            this.lblGettingStartedInstructions.Name = "lblGettingStartedInstructions";
            this.lblGettingStartedInstructions.Size = new System.Drawing.Size(294, 83);
            this.lblGettingStartedInstructions.TabIndex = 7;
            this.lblGettingStartedInstructions.Text = "-Go to the Sign Up Page.\r\n-Click the \'SIGN UP NOW\' Button.\r\n-Sign in using your N" +
    "ormal League Login.\r\n-Copy the KEY under the \'My Development API Key.\r\n-Paste in" +
    "to the Box below and press Save.\r\n";
            // 
            // lblGettingStartedTitle
            // 
            this.lblGettingStartedTitle.AutoSize = true;
            this.lblGettingStartedTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGettingStartedTitle.Location = new System.Drawing.Point(497, 37);
            this.lblGettingStartedTitle.Name = "lblGettingStartedTitle";
            this.lblGettingStartedTitle.Size = new System.Drawing.Size(115, 16);
            this.lblGettingStartedTitle.TabIndex = 6;
            this.lblGettingStartedTitle.Text = "Getting Started!";
            // 
            // lblInstructionTitle
            // 
            this.lblInstructionTitle.AutoSize = true;
            this.lblInstructionTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructionTitle.Location = new System.Drawing.Point(55, 37);
            this.lblInstructionTitle.Name = "lblInstructionTitle";
            this.lblInstructionTitle.Size = new System.Drawing.Size(244, 16);
            this.lblInstructionTitle.TabIndex = 5;
            this.lblInstructionTitle.Text = "Why get your own Developer Key?";
            // 
            // lnklblTnC
            // 
            this.lnklblTnC.AutoSize = true;
            this.lnklblTnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnklblTnC.Location = new System.Drawing.Point(112, 322);
            this.lnklblTnC.Name = "lnklblTnC";
            this.lnklblTnC.Size = new System.Drawing.Size(139, 16);
            this.lnklblTnC.TabIndex = 4;
            this.lnklblTnC.TabStop = true;
            this.lnklblTnC.Text = "Terms and Conditions";
            this.lnklblTnC.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lklblSignUp
            // 
            this.lklblSignUp.AutoSize = true;
            this.lklblSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lklblSignUp.Location = new System.Drawing.Point(126, 280);
            this.lklblSignUp.Name = "lklblSignUp";
            this.lklblSignUp.Size = new System.Drawing.Size(107, 20);
            this.lklblSignUp.TabIndex = 3;
            this.lklblSignUp.TabStop = true;
            this.lklblSignUp.Text = "Sign Up Page";
            this.lklblSignUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklblSignUp_LinkClicked);
            // 
            // lblAPIInstructions
            // 
            this.lblAPIInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAPIInstructions.Location = new System.Drawing.Point(34, 80);
            this.lblAPIInstructions.Name = "lblAPIInstructions";
            this.lblAPIInstructions.Size = new System.Drawing.Size(301, 172);
            this.lblAPIInstructions.TabIndex = 2;
            this.lblAPIInstructions.Text = resources.GetString("lblAPIInstructions.Text");
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(744, 425);
            this.Controls.Add(this.tbcSums);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.tbcSums.ResumeLayout(false);
            this.tabUser.ResumeLayout(false);
            this.tabUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboVeteran)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboFreshBlood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboHotStreak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboRanking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboSumIcon)).EndInit();
            this.tabLeague.ResumeLayout(false);
            this.tabLeague.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboLeaguesTier)).EndInit();
            this.tabAPIKey.ResumeLayout(false);
            this.tabAPIKey.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcSums;
        private System.Windows.Forms.TabPage tabUser;
        private System.Windows.Forms.TabPage tabMatches;
        private System.Windows.Forms.TabPage tabAPIKey;
        private System.Windows.Forms.LinkLabel lklblSignUp;
        private System.Windows.Forms.Label lblAPIInstructions;
        private System.Windows.Forms.LinkLabel lnklblTnC;
        private System.Windows.Forms.Label lblInstructionTitle;
        private System.Windows.Forms.Label lblGettingStartedInstructions;
        private System.Windows.Forms.Label lblGettingStartedTitle;
        private System.Windows.Forms.TextBox txtEnterAPI;
        private System.Windows.Forms.Button btnSaveAPI;
        private System.Windows.Forms.Label lblAPIKeyTitle;
        private System.Windows.Forms.Label lblIsSaved;
        private System.Windows.Forms.LinkLabel lnklblReset;
        private System.Windows.Forms.PictureBox pboSumIcon;
        private System.Windows.Forms.LinkLabel lnklblSumName;
        private System.Windows.Forms.Label lblSumID;
        private System.Windows.Forms.Label lblRanking;
        private System.Windows.Forms.PictureBox pboRanking;
        private System.Windows.Forms.Label lbl5v5;
        private System.Windows.Forms.Label lblSoloDuo;
        private System.Windows.Forms.Label lbl3v3;
        private System.Windows.Forms.Label lblLP;
        private System.Windows.Forms.Label lblWinsNum;
        private System.Windows.Forms.Label lblLossesNum;
        private System.Windows.Forms.Label lblLossestitle;
        private System.Windows.Forms.Label lblwinstitle;
        private System.Windows.Forms.Label lblRevisionDateStr;
        private System.Windows.Forms.Label lblLvl;
        private System.Windows.Forms.Label lblNormal;
        private System.Windows.Forms.PictureBox pboVeteran;
        private System.Windows.Forms.PictureBox pboFreshBlood;
        private System.Windows.Forms.PictureBox pboHotStreak;
        private System.Windows.Forms.Label lblLeagueName;
        private System.Windows.Forms.TabPage tabLeague;
        private System.Windows.Forms.PictureBox pboLeaguesTier;
        private System.Windows.Forms.ListView lvLeagues;
        private System.Windows.Forms.Label lblLeaguesRank;
        private System.Windows.Forms.Button btnUpArrow;
        private System.Windows.Forms.Button btnDownArrow;
        private System.Windows.Forms.ComboBox cboLeaguesQueueType;
        private System.Windows.Forms.Label lblLeaguesTierTitle;
        private System.Windows.Forms.Label lblLeaguesLeagueName;
    }
}