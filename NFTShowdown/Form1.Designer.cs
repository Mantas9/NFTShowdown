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
            this.btnEditTeam = new System.Windows.Forms.Button();
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
            // 
            // btnNewTeam
            // 
            this.btnNewTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewTeam.Location = new System.Drawing.Point(12, 541);
            this.btnNewTeam.Name = "btnNewTeam";
            this.btnNewTeam.Size = new System.Drawing.Size(514, 93);
            this.btnNewTeam.TabIndex = 5;
            this.btnNewTeam.Text = "Teambuilder";
            this.btnNewTeam.UseVisualStyleBackColor = true;
            this.btnNewTeam.Click += new System.EventHandler(this.btnNewTeam_Click);
            // 
            // btnEditTeam
            // 
            this.btnEditTeam.Enabled = false;
            this.btnEditTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditTeam.Location = new System.Drawing.Point(12, 442);
            this.btnEditTeam.Name = "btnEditTeam";
            this.btnEditTeam.Size = new System.Drawing.Size(253, 93);
            this.btnEditTeam.TabIndex = 6;
            this.btnEditTeam.Text = "Edit Team";
            this.btnEditTeam.UseVisualStyleBackColor = true;
            this.btnEditTeam.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 646);
            this.Controls.Add(this.btnEditTeam);
            this.Controls.Add(this.btnNewTeam);
            this.Controls.Add(this.btnBattle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboTeams);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboFormat);
            this.Name = "Form1";
            this.Text = "NFT Showdown - home page";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.Button btnEditTeam;
    }
}

