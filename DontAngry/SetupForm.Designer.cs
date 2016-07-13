namespace DontAngry
{
    partial class SetupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetupForm));
            this.dom_NumOfPlayers = new System.Windows.Forms.DomainUpDown();
            this.lbl_NumOfPlayers = new System.Windows.Forms.Label();
            this.pcb_PlayGame = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_PlayGame)).BeginInit();
            this.SuspendLayout();
            // 
            // dom_NumOfPlayers
            // 
            this.dom_NumOfPlayers.Cursor = System.Windows.Forms.Cursors.Default;
            this.dom_NumOfPlayers.Items.Add("1");
            this.dom_NumOfPlayers.Items.Add("2");
            this.dom_NumOfPlayers.Items.Add("3");
            this.dom_NumOfPlayers.Items.Add("4");
            this.dom_NumOfPlayers.Location = new System.Drawing.Point(154, 185);
            this.dom_NumOfPlayers.Name = "dom_NumOfPlayers";
            this.dom_NumOfPlayers.ReadOnly = true;
            this.dom_NumOfPlayers.Size = new System.Drawing.Size(109, 20);
            this.dom_NumOfPlayers.Sorted = true;
            this.dom_NumOfPlayers.TabIndex = 0;
            this.dom_NumOfPlayers.Text = "1";
            // 
            // lbl_NumOfPlayers
            // 
            this.lbl_NumOfPlayers.Location = new System.Drawing.Point(47, 185);
            this.lbl_NumOfPlayers.Name = "lbl_NumOfPlayers";
            this.lbl_NumOfPlayers.Size = new System.Drawing.Size(101, 20);
            this.lbl_NumOfPlayers.TabIndex = 1;
            this.lbl_NumOfPlayers.Text = "Number of players";
            this.lbl_NumOfPlayers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pcb_PlayGame
            // 
            this.pcb_PlayGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcb_PlayGame.Image = global::DontAngry.Properties.Resources.playbutton;
            this.pcb_PlayGame.Location = new System.Drawing.Point(50, 264);
            this.pcb_PlayGame.Name = "pcb_PlayGame";
            this.pcb_PlayGame.Size = new System.Drawing.Size(213, 75);
            this.pcb_PlayGame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_PlayGame.TabIndex = 2;
            this.pcb_PlayGame.TabStop = false;
            this.pcb_PlayGame.Click += new System.EventHandler(this.pcb_PlayGame_Click);
            // 
            // SetupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::DontAngry.Properties.Resources.dontangry;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(315, 371);
            this.Controls.Add(this.pcb_PlayGame);
            this.Controls.Add(this.lbl_NumOfPlayers);
            this.Controls.Add(this.dom_NumOfPlayers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "SetupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Set Up";
            ((System.ComponentModel.ISupportInitialize)(this.pcb_PlayGame)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DomainUpDown dom_NumOfPlayers;
        private System.Windows.Forms.Label lbl_NumOfPlayers;
        private System.Windows.Forms.PictureBox pcb_PlayGame;
    }
}

