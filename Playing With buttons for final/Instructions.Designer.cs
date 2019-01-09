namespace Playing_With_buttons_for_final
{
    partial class Instructions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Instructions));
            this.lblInstruc = new System.Windows.Forms.Label();
            this.InstructionLbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInstruc
            // 
            this.lblInstruc.AutoSize = true;
            this.lblInstruc.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lblInstruc.Location = new System.Drawing.Point(300, 9);
            this.lblInstruc.Name = "lblInstruc";
            this.lblInstruc.Size = new System.Drawing.Size(191, 39);
            this.lblInstruc.TabIndex = 0;
            this.lblInstruc.Text = "Instructions";
            // 
            // InstructionLbl
            // 
            this.InstructionLbl.AutoSize = true;
            this.InstructionLbl.Location = new System.Drawing.Point(58, 77);
            this.InstructionLbl.Name = "InstructionLbl";
            this.InstructionLbl.Size = new System.Drawing.Size(681, 91);
            this.InstructionLbl.TabIndex = 1;
            this.InstructionLbl.Text = resources.GetString("InstructionLbl.Text");
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(87, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "Play";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(541, 374);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 35);
            this.button2.TabIndex = 3;
            this.button2.Text = "Main Menu";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Instructions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.InstructionLbl);
            this.Controls.Add(this.lblInstruc);
            this.Name = "Instructions";
            this.Text = "Instructions";
            this.Load += new System.EventHandler(this.Instructions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInstruc;
        private System.Windows.Forms.Label InstructionLbl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}