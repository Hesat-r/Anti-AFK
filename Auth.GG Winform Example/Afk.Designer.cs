namespace Auth.GG_Winform_Example
{
    partial class Afk
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
            this.siticoneGradientButton1 = new Siticone.UI.WinForms.SiticoneGradientButton();
            this.SuspendLayout();
            // 
            // siticoneGradientButton1
            // 
            this.siticoneGradientButton1.CheckedState.Parent = this.siticoneGradientButton1;
            this.siticoneGradientButton1.CustomImages.Parent = this.siticoneGradientButton1;
            this.siticoneGradientButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(212)))), ((int)(((byte)(113)))));
            this.siticoneGradientButton1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(41)))));
            this.siticoneGradientButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneGradientButton1.ForeColor = System.Drawing.Color.White;
            this.siticoneGradientButton1.HoveredState.Parent = this.siticoneGradientButton1;
            this.siticoneGradientButton1.Location = new System.Drawing.Point(215, 338);
            this.siticoneGradientButton1.Name = "siticoneGradientButton1";
            this.siticoneGradientButton1.ShadowDecoration.Parent = this.siticoneGradientButton1;
            this.siticoneGradientButton1.Size = new System.Drawing.Size(180, 45);
            this.siticoneGradientButton1.TabIndex = 0;
            this.siticoneGradientButton1.Text = "Start";
            this.siticoneGradientButton1.Click += new System.EventHandler(this.siticoneGradientButton1_ClickAsync);
            // 
            // Afk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(627, 446);
            this.Controls.Add(this.siticoneGradientButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Afk";
            this.Text = "Afk";
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.UI.WinForms.SiticoneGradientButton siticoneGradientButton1;
    }
}