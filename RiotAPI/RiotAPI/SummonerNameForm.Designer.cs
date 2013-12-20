namespace RiotAPI
{
    partial class SummonerNameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SummonerNameForm));
            this.txtBoxSumName = new System.Windows.Forms.TextBox();
            this.lblSumName = new System.Windows.Forms.Label();
            this.ptrBox = new System.Windows.Forms.PictureBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.chkSave = new System.Windows.Forms.CheckBox();
            this.cbo_region = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptrBox)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxSumName
            // 
            this.txtBoxSumName.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSumName.Location = new System.Drawing.Point(125, 105);
            this.txtBoxSumName.Name = "txtBoxSumName";
            this.txtBoxSumName.Size = new System.Drawing.Size(250, 32);
            this.txtBoxSumName.TabIndex = 0;
            this.txtBoxSumName.Text = "Summoner Name";
            this.txtBoxSumName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxSumName.TextChanged += new System.EventHandler(this.txtBoxSumName_TextChanged);
            // 
            // lblSumName
            // 
            this.lblSumName.BackColor = System.Drawing.Color.Teal;
            this.lblSumName.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSumName.ForeColor = System.Drawing.Color.Black;
            this.lblSumName.Location = new System.Drawing.Point(100, 56);
            this.lblSumName.Name = "lblSumName";
            this.lblSumName.Size = new System.Drawing.Size(300, 30);
            this.lblSumName.TabIndex = 1;
            this.lblSumName.Text = "Enter your Summoner Name";
            this.lblSumName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ptrBox
            // 
            this.ptrBox.BackColor = System.Drawing.Color.Teal;
            this.ptrBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptrBox.Location = new System.Drawing.Point(87, 42);
            this.ptrBox.Name = "ptrBox";
            this.ptrBox.Size = new System.Drawing.Size(326, 175);
            this.ptrBox.TabIndex = 3;
            this.ptrBox.TabStop = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSubmit.Location = new System.Drawing.Point(200, 179);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 25);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // chkSave
            // 
            this.chkSave.AutoSize = true;
            this.chkSave.BackColor = System.Drawing.Color.Teal;
            this.chkSave.Checked = true;
            this.chkSave.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSave.Location = new System.Drawing.Point(306, 181);
            this.chkSave.Name = "chkSave";
            this.chkSave.Size = new System.Drawing.Size(63, 20);
            this.chkSave.TabIndex = 3;
            this.chkSave.TabStop = false;
            this.chkSave.Text = "Save";
            this.chkSave.UseVisualStyleBackColor = false;
            this.chkSave.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cbo_region
            // 
            this.cbo_region.FormattingEnabled = true;
            this.cbo_region.Location = new System.Drawing.Point(125, 153);
            this.cbo_region.Name = "cbo_region";
            this.cbo_region.Size = new System.Drawing.Size(55, 21);
            this.cbo_region.TabIndex = 1;
            this.cbo_region.Text = "NA";
            this.cbo_region.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // SummonerNameForm
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RiotAPI.Properties.Resources.userSumNameBackgroundImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(484, 316);
            this.Controls.Add(this.cbo_region);
            this.Controls.Add(this.chkSave);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtBoxSumName);
            this.Controls.Add(this.lblSumName);
            this.Controls.Add(this.ptrBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SummonerNameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Summoner Name";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SummonerNameForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.ptrBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxSumName;
        private System.Windows.Forms.Label lblSumName;
        private System.Windows.Forms.PictureBox ptrBox;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.CheckBox chkSave;
        private System.Windows.Forms.ComboBox cbo_region;
    }
}

