namespace NFTShowdown
{
    partial class BattleWindow
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCPUHP = new System.Windows.Forms.Label();
            this.progCPUHP = new System.Windows.Forms.ProgressBar();
            this.lblPlayerHP = new System.Windows.Forms.Label();
            this.progPlayerHP = new System.Windows.Forms.ProgressBar();
            this.btnMove1 = new System.Windows.Forms.Button();
            this.btnMove2 = new System.Windows.Forms.Button();
            this.btnMove3 = new System.Windows.Forms.Button();
            this.btnMove4 = new System.Windows.Forms.Button();
            this.txtLogs = new System.Windows.Forms.RichTextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureDeadAI = new System.Windows.Forms.PictureBox();
            this.pictureDead = new System.Windows.Forms.PictureBox();
            this.pictureCPU = new System.Windows.Forms.PictureBox();
            this.picturePlayer = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDeadAI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.CausesValidation = false;
            this.groupBox1.Controls.Add(this.pictureDeadAI);
            this.groupBox1.Controls.Add(this.pictureDead);
            this.groupBox1.Controls.Add(this.lblCPUHP);
            this.groupBox1.Controls.Add(this.progCPUHP);
            this.groupBox1.Controls.Add(this.lblPlayerHP);
            this.groupBox1.Controls.Add(this.progPlayerHP);
            this.groupBox1.Controls.Add(this.pictureCPU);
            this.groupBox1.Controls.Add(this.picturePlayer);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(818, 427);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lblCPUHP
            // 
            this.lblCPUHP.AutoSize = true;
            this.lblCPUHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPUHP.Location = new System.Drawing.Point(518, 328);
            this.lblCPUHP.Name = "lblCPUHP";
            this.lblCPUHP.Size = new System.Drawing.Size(20, 22);
            this.lblCPUHP.TabIndex = 5;
            this.lblCPUHP.Text = "0";
            // 
            // progCPUHP
            // 
            this.progCPUHP.Location = new System.Drawing.Point(580, 327);
            this.progCPUHP.Name = "progCPUHP";
            this.progCPUHP.Size = new System.Drawing.Size(232, 23);
            this.progCPUHP.TabIndex = 4;
            this.progCPUHP.Value = 100;
            // 
            // lblPlayerHP
            // 
            this.lblPlayerHP.AutoSize = true;
            this.lblPlayerHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerHP.Location = new System.Drawing.Point(245, 92);
            this.lblPlayerHP.Name = "lblPlayerHP";
            this.lblPlayerHP.Size = new System.Drawing.Size(20, 22);
            this.lblPlayerHP.TabIndex = 3;
            this.lblPlayerHP.Text = "0";
            // 
            // progPlayerHP
            // 
            this.progPlayerHP.Location = new System.Drawing.Point(7, 92);
            this.progPlayerHP.Name = "progPlayerHP";
            this.progPlayerHP.Size = new System.Drawing.Size(232, 23);
            this.progPlayerHP.TabIndex = 2;
            this.progPlayerHP.Value = 100;
            // 
            // btnMove1
            // 
            this.btnMove1.Location = new System.Drawing.Point(13, 447);
            this.btnMove1.Name = "btnMove1";
            this.btnMove1.Size = new System.Drawing.Size(200, 60);
            this.btnMove1.TabIndex = 1;
            this.btnMove1.Text = "button1";
            this.btnMove1.UseVisualStyleBackColor = true;
            this.btnMove1.Click += new System.EventHandler(this.btnMove1_Click);
            // 
            // btnMove2
            // 
            this.btnMove2.Location = new System.Drawing.Point(219, 447);
            this.btnMove2.Name = "btnMove2";
            this.btnMove2.Size = new System.Drawing.Size(200, 60);
            this.btnMove2.TabIndex = 2;
            this.btnMove2.Text = "button2";
            this.btnMove2.UseVisualStyleBackColor = true;
            this.btnMove2.Click += new System.EventHandler(this.btnMove2_Click);
            // 
            // btnMove3
            // 
            this.btnMove3.Location = new System.Drawing.Point(425, 447);
            this.btnMove3.Name = "btnMove3";
            this.btnMove3.Size = new System.Drawing.Size(200, 60);
            this.btnMove3.TabIndex = 3;
            this.btnMove3.Text = "button3";
            this.btnMove3.UseVisualStyleBackColor = true;
            this.btnMove3.Click += new System.EventHandler(this.btnMove3_Click);
            // 
            // btnMove4
            // 
            this.btnMove4.Location = new System.Drawing.Point(631, 447);
            this.btnMove4.Name = "btnMove4";
            this.btnMove4.Size = new System.Drawing.Size(200, 60);
            this.btnMove4.TabIndex = 4;
            this.btnMove4.Text = "button4";
            this.btnMove4.UseVisualStyleBackColor = true;
            this.btnMove4.Click += new System.EventHandler(this.btnMove4_Click);
            // 
            // txtLogs
            // 
            this.txtLogs.Location = new System.Drawing.Point(837, 34);
            this.txtLogs.Name = "txtLogs";
            this.txtLogs.ReadOnly = true;
            this.txtLogs.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtLogs.Size = new System.Drawing.Size(378, 473);
            this.txtLogs.TabIndex = 5;
            this.txtLogs.Text = "";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(1019, 514);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(195, 70);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Visible = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureDeadAI
            // 
            this.pictureDeadAI.BackColor = System.Drawing.Color.Transparent;
            this.pictureDeadAI.BackgroundImage = global::NFTShowdown.Properties.Resources.dead;
            this.pictureDeadAI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureDeadAI.InitialImage = global::NFTShowdown.Properties.Resources.dead;
            this.pictureDeadAI.Location = new System.Drawing.Point(512, 21);
            this.pictureDeadAI.Name = "pictureDeadAI";
            this.pictureDeadAI.Size = new System.Drawing.Size(300, 300);
            this.pictureDeadAI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureDeadAI.TabIndex = 7;
            this.pictureDeadAI.TabStop = false;
            this.pictureDeadAI.Visible = false;
            // 
            // pictureDead
            // 
            this.pictureDead.BackColor = System.Drawing.Color.Transparent;
            this.pictureDead.BackgroundImage = global::NFTShowdown.Properties.Resources.dead;
            this.pictureDead.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureDead.InitialImage = global::NFTShowdown.Properties.Resources.dead;
            this.pictureDead.Location = new System.Drawing.Point(6, 122);
            this.pictureDead.Name = "pictureDead";
            this.pictureDead.Size = new System.Drawing.Size(300, 300);
            this.pictureDead.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureDead.TabIndex = 6;
            this.pictureDead.TabStop = false;
            this.pictureDead.Visible = false;
            // 
            // pictureCPU
            // 
            this.pictureCPU.Location = new System.Drawing.Point(512, 21);
            this.pictureCPU.Name = "pictureCPU";
            this.pictureCPU.Size = new System.Drawing.Size(300, 300);
            this.pictureCPU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureCPU.TabIndex = 1;
            this.pictureCPU.TabStop = false;
            // 
            // picturePlayer
            // 
            this.picturePlayer.Location = new System.Drawing.Point(6, 121);
            this.picturePlayer.Name = "picturePlayer";
            this.picturePlayer.Size = new System.Drawing.Size(300, 300);
            this.picturePlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturePlayer.TabIndex = 0;
            this.picturePlayer.TabStop = false;
            // 
            // BattleWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1227, 596);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtLogs);
            this.Controls.Add(this.btnMove4);
            this.Controls.Add(this.btnMove3);
            this.Controls.Add(this.btnMove2);
            this.Controls.Add(this.btnMove1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "BattleWindow";
            this.Text = "BattleWindow";
            this.Load += new System.EventHandler(this.BattleWindow_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDeadAI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureCPU;
        private System.Windows.Forms.PictureBox picturePlayer;
        private System.Windows.Forms.Button btnMove1;
        private System.Windows.Forms.Button btnMove2;
        private System.Windows.Forms.Button btnMove3;
        private System.Windows.Forms.Button btnMove4;
        private System.Windows.Forms.RichTextBox txtLogs;
        private System.Windows.Forms.ProgressBar progPlayerHP;
        private System.Windows.Forms.Label lblCPUHP;
        private System.Windows.Forms.ProgressBar progCPUHP;
        private System.Windows.Forms.Label lblPlayerHP;
        private System.Windows.Forms.PictureBox pictureDead;
        private System.Windows.Forms.PictureBox pictureDeadAI;
        private System.Windows.Forms.Button btnExit;
    }
}