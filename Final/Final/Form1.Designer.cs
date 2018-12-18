namespace Final
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
            this.coordinateChoice = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // coordinateChoice
            // 
            this.coordinateChoice.FormattingEnabled = true;
            this.coordinateChoice.Items.AddRange(new object[] {
            "A1",
            "A2",
            "A3",
            "A4",
            "A5",
            "A6",
            "B1",
            "B2",
            "B3",
            "B4",
            "B5",
            "B6",
            "C1",
            "C2",
            "C3",
            "C4",
            "C5",
            "C6",
            "D1",
            "D2",
            "D3",
            "D4",
            "D5",
            "D6",
            "E1",
            "E2",
            "E3",
            "E4",
            "E5",
            "E6",
            "F1",
            "F2",
            "F3",
            "F4",
            "F5",
            "F6",
            ""});
            this.coordinateChoice.Location = new System.Drawing.Point(324, 89);
            this.coordinateChoice.Name = "coordinateChoice";
            this.coordinateChoice.Size = new System.Drawing.Size(121, 21);
            this.coordinateChoice.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.coordinateChoice);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox coordinateChoice;
    }
}

