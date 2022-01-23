namespace NFTShowdown
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
            this.comboFormat = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboTeams = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBattle = new System.Windows.Forms.Button();
            this.btnNewTeam = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblWins = new System.Windows.Forms.Label();
            this.lblLosses = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBackground = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // comboFormat
            // 
            this.comboFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFormat.FormattingEnabled = true;
            this.comboFormat.Items.AddRange(new object[] {
            "Random Battle",
            "Teams Battle",
            "Random 1v1 Battle"});
            this.comboFormat.Location = new System.Drawing.Point(97, 10);
            this.comboFormat.Name = "comboFormat";
            this.comboFormat.Size = new System.Drawing.Size(429, 24);
            this.comboFormat.TabIndex = 0;
            this.comboFormat.SelectedIndexChanged += new System.EventHandler(this.comboFormat_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Format:";
            // 
            // comboTeams
            // 
            this.comboTeams.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTeams.FormattingEnabled = true;
            this.comboTeams.Location = new System.Drawing.Point(97, 54);
            this.comboTeams.Name = "comboTeams";
            this.comboTeams.Size = new System.Drawing.Size(429, 24);
            this.comboTeams.TabIndex = 2;
            this.comboTeams.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Team:";
            this.label2.Visible = false;
            // 
            // btnBattle
            // 
            this.btnBattle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBattle.Location = new System.Drawing.Point(17, 96);
            this.btnBattle.Name = "btnBattle";
            this.btnBattle.Size = new System.Drawing.Size(509, 93);
            this.btnBattle.TabIndex = 4;
            this.btnBattle.Text = "Join Battle";
            this.btnBattle.UseVisualStyleBackColor = true;
            this.btnBattle.Click += new System.EventHandler(this.btnBattle_Click);
            // 
            // btnNewTeam
            // 
            this.btnNewTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewTeam.Location = new System.Drawing.Point(17, 606);
            this.btnNewTeam.Name = "btnNewTeam";
            this.btnNewTeam.Size = new System.Drawing.Size(509, 93);
            this.btnNewTeam.TabIndex = 5;
            this.btnNewTeam.Text = "Teambuilder";
            this.btnNewTeam.UseVisualStyleBackColor = true;
            this.btnNewTeam.Click += new System.EventHandler(this.btnNewTeam_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Wins: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Losses:";
            // 
            // lblWins
            // 
            this.lblWins.AutoSize = true;
            this.lblWins.BackColor = System.Drawing.Color.Transparent;
            this.lblWins.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWins.Location = new System.Drawing.Point(116, 192);
            this.lblWins.Name = "lblWins";
            this.lblWins.Size = new System.Drawing.Size(21, 29);
            this.lblWins.TabIndex = 9;
            this.lblWins.Text = "-";
            // 
            // lblLosses
            // 
            this.lblLosses.AutoSize = true;
            this.lblLosses.BackColor = System.Drawing.Color.Transparent;
            this.lblLosses.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLosses.Location = new System.Drawing.Point(116, 221);
            this.lblLosses.Name = "lblLosses";
            this.lblLosses.Size = new System.Drawing.Size(21, 29);
            this.lblLosses.TabIndex = 10;
            this.lblLosses.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(116, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(346, 29);
            this.label5.TabIndex = 11;
            this.label5.Text = "GUI Background Customization";
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(387, 557);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(138, 43);
            this.btnNext.TabIndex = 13;
            this.btnNext.Text = "=>";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(19, 557);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 43);
            this.button1.TabIndex = 14;
            this.button1.Text = "<=";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBackground
            // 
            this.pictureBackground.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBackground.Image = global::NFTShowdown.Properties.Resources._1;
            this.pictureBackground.Location = new System.Drawing.Point(19, 305);
            this.pictureBackground.Name = "pictureBackground";
            this.pictureBackground.Size = new System.Drawing.Size(507, 245);
            this.pictureBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBackground.TabIndex = 12;
            this.pictureBackground.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 711);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.pictureBackground);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblLosses);
            this.Controls.Add(this.lblWins);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnNewTeam);
            this.Controls.Add(this.btnBattle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboTeams);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboFormat);
            this.Name = "Form1";
            this.Text = "NFT Showdown - home page";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboFormat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboTeams;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBattle;
        private System.Windows.Forms.Button btnNewTeam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblWins;
        private System.Windows.Forms.Label lblLosses;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBackground;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button button1;
    }
}

