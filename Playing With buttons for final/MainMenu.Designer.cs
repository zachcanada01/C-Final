namespace Playing_With_buttons_for_final
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.BattleLbl = new System.Windows.Forms.Label();
            this.PlayBtn = new System.Windows.Forms.Button();
            this.InstructionsBtn = new System.Windows.Forms.Button();
            this.lblUs = new System.Windows.Forms.Label();
            this.ExplosionPic = new System.Windows.Forms.PictureBox();
            this.ExplosionPoc = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ExplosionPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExplosionPoc)).BeginInit();
            this.SuspendLayout();
            // 
            // BattleLbl
            // 
            this.BattleLbl.AutoSize = true;
            this.BattleLbl.Font = new System.Drawing.Font("Niagara Solid", 54.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BattleLbl.Location = new System.Drawing.Point(285, 26);
            this.BattleLbl.Name = "BattleLbl";
            this.BattleLbl.Size = new System.Drawing.Size(242, 78);
            this.BattleLbl.TabIndex = 0;
            this.BattleLbl.Text = "BATTLESHIP";
            // 
            // PlayBtn
            // 
            this.PlayBtn.Font = new System.Drawing.Font("Niagara Solid", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayBtn.Location = new System.Drawing.Point(275, 129);
            this.PlayBtn.Name = "PlayBtn";
            this.PlayBtn.Size = new System.Drawing.Size(261, 99);
            this.PlayBtn.TabIndex = 2;
            this.PlayBtn.Text = "Play \r\nPlayer VS Computer\r\n";
            this.PlayBtn.UseVisualStyleBackColor = true;
            this.PlayBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // InstructionsBtn
            // 
            this.InstructionsBtn.Font = new System.Drawing.Font("Niagara Solid", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstructionsBtn.Location = new System.Drawing.Point(321, 243);
            this.InstructionsBtn.Name = "InstructionsBtn";
            this.InstructionsBtn.Size = new System.Drawing.Size(180, 49);
            this.InstructionsBtn.TabIndex = 4;
            this.InstructionsBtn.Text = "Instructions";
            this.InstructionsBtn.UseVisualStyleBackColor = true;
            // 
            // lblUs
            // 
            this.lblUs.AutoSize = true;
            this.lblUs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblUs.Location = new System.Drawing.Point(252, 424);
            this.lblUs.Name = "lblUs";
            this.lblUs.Size = new System.Drawing.Size(300, 17);
            this.lblUs.TabIndex = 5;
            this.lblUs.Text = "Created By: Zach Canada and Hayley Carriker";
            // 
            // ExplosionPic
            // 
            this.ExplosionPic.Image = ((System.Drawing.Image)(resources.GetObject("ExplosionPic.Image")));
            this.ExplosionPic.Location = new System.Drawing.Point(533, 31);
            this.ExplosionPic.Name = "ExplosionPic";
            this.ExplosionPic.Size = new System.Drawing.Size(78, 69);
            this.ExplosionPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ExplosionPic.TabIndex = 3;
            this.ExplosionPic.TabStop = false;
            // 
            // ExplosionPoc
            // 
            this.ExplosionPoc.Image = ((System.Drawing.Image)(resources.GetObject("ExplosionPoc.Image")));
            this.ExplosionPoc.Location = new System.Drawing.Point(201, 30);
            this.ExplosionPoc.Name = "ExplosionPoc";
            this.ExplosionPoc.Size = new System.Drawing.Size(78, 69);
            this.ExplosionPoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ExplosionPoc.TabIndex = 0;
            this.ExplosionPoc.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblUs);
            this.Controls.Add(this.InstructionsBtn);
            this.Controls.Add(this.ExplosionPic);
            this.Controls.Add(this.PlayBtn);
            this.Controls.Add(this.BattleLbl);
            this.Controls.Add(this.ExplosionPoc);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ExplosionPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExplosionPoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ExplosionPoc;
        private System.Windows.Forms.Label BattleLbl;
        private System.Windows.Forms.Button PlayBtn;
        private System.Windows.Forms.PictureBox ExplosionPic;
        private System.Windows.Forms.Button InstructionsBtn;
        private System.Windows.Forms.Label lblUs;
    }
}