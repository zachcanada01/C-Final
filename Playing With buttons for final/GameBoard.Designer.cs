namespace Playing_With_buttons_for_final
{
    partial class GameBoard
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
            this.WinsTx = new System.Windows.Forms.Label();
            this.lbltx = new System.Windows.Forms.Label();
            this.lbltxt = new System.Windows.Forms.Label();
            this.WinsTxt = new System.Windows.Forms.Label();
            this.PlayerLBL = new System.Windows.Forms.Label();
            this.CompLBL = new System.Windows.Forms.Label();
            this.CoordBox = new System.Windows.Forms.ComboBox();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WinsTx
            // 
            this.WinsTx.AutoSize = true;
            this.WinsTx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.WinsTx.Location = new System.Drawing.Point(138, 21);
            this.WinsTx.Name = "WinsTx";
            this.WinsTx.Size = new System.Drawing.Size(44, 20);
            this.WinsTx.TabIndex = 0;
            this.WinsTx.Text = "Wins";
            // 
            // lbltx
            // 
            this.lbltx.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbltx.Location = new System.Drawing.Point(188, 21);
            this.lbltx.Name = "lbltx";
            this.lbltx.Size = new System.Drawing.Size(29, 22);
            this.lbltx.TabIndex = 1;
            // 
            // lbltxt
            // 
            this.lbltxt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbltxt.Location = new System.Drawing.Point(634, 23);
            this.lbltxt.Name = "lbltxt";
            this.lbltxt.Size = new System.Drawing.Size(29, 22);
            this.lbltxt.TabIndex = 2;
            // 
            // WinsTxt
            // 
            this.WinsTxt.AutoSize = true;
            this.WinsTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.WinsTxt.Location = new System.Drawing.Point(584, 23);
            this.WinsTxt.Name = "WinsTxt";
            this.WinsTxt.Size = new System.Drawing.Size(44, 20);
            this.WinsTxt.TabIndex = 3;
            this.WinsTxt.Text = "Wins";
            // 
            // PlayerLBL
            // 
            this.PlayerLBL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PlayerLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.PlayerLBL.Location = new System.Drawing.Point(142, 51);
            this.PlayerLBL.Name = "PlayerLBL";
            this.PlayerLBL.Size = new System.Drawing.Size(75, 30);
            this.PlayerLBL.TabIndex = 4;
            this.PlayerLBL.Text = "Player";
            // 
            // CompLBL
            // 
            this.CompLBL.AutoSize = true;
            this.CompLBL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CompLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.CompLBL.Location = new System.Drawing.Point(577, 51);
            this.CompLBL.Name = "CompLBL";
            this.CompLBL.Size = new System.Drawing.Size(100, 27);
            this.CompLBL.TabIndex = 5;
            this.CompLBL.Text = "Computer";
            // 
            // CoordBox
            // 
            this.CoordBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CoordBox.FormattingEnabled = true;
            this.CoordBox.Items.AddRange(new object[] {
            "A1",
            "A2",
            "A3",
            "A4",
            "A5",
            "B1",
            "B2",
            "B3 ",
            "B4",
            "B5",
            "C1",
            "C2",
            "C3",
            "C4",
            "C5",
            "D1",
            "D2",
            "D3",
            "D4",
            "D5",
            "E1",
            "E2",
            "E3",
            "E4",
            "E5"});
            this.CoordBox.Location = new System.Drawing.Point(348, 51);
            this.CoordBox.MaxDropDownItems = 36;
            this.CoordBox.MaxLength = 4;
            this.CoordBox.Name = "CoordBox";
            this.CoordBox.Size = new System.Drawing.Size(119, 21);
            this.CoordBox.TabIndex = 6;
            this.CoordBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(619, 415);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(113, 41);
            this.ExitBtn.TabIndex = 7;
            this.ExitBtn.Text = "MENU";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // GameBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.CoordBox);
            this.Controls.Add(this.CompLBL);
            this.Controls.Add(this.PlayerLBL);
            this.Controls.Add(this.WinsTxt);
            this.Controls.Add(this.lbltxt);
            this.Controls.Add(this.lbltx);
            this.Controls.Add(this.WinsTx);
            this.Name = "GameBoard";
            this.Text = "GameBoard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WinsTx;
        private System.Windows.Forms.Label lbltx;
        private System.Windows.Forms.Label lbltxt;
        private System.Windows.Forms.Label WinsTxt;
        private System.Windows.Forms.Label PlayerLBL;
        private System.Windows.Forms.Label CompLBL;
        private System.Windows.Forms.ComboBox CoordBox;
        private System.Windows.Forms.Button ExitBtn;
    }
}