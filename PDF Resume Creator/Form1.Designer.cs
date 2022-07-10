namespace PDF_Resume_Creator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Generatebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Generatebtn
            // 
            this.Generatebtn.BackColor = System.Drawing.Color.Honeydew;
            this.Generatebtn.Font = new System.Drawing.Font("Segoe UI Symbol", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Generatebtn.Location = new System.Drawing.Point(253, 195);
            this.Generatebtn.Name = "Generatebtn";
            this.Generatebtn.Size = new System.Drawing.Size(258, 54);
            this.Generatebtn.TabIndex = 0;
            this.Generatebtn.Text = "Generate PDF Resume";
            this.Generatebtn.UseVisualStyleBackColor = false;
            this.Generatebtn.Click += new System.EventHandler(this.Generatebtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Generatebtn);
            this.Name = "Form1";
            this.Text = "PDF Resume Generator ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button Generatebtn;
    }
}