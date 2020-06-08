namespace GESTION_DE_LOCATION_DES_VOITURES
{
    partial class FMenuGenerale
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
            this.btn1 = new MetroFramework.Controls.MetroButton();
            this.btn2 = new MetroFramework.Controls.MetroButton();
            this.btn3 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.btnClose = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(14, 19);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(81, 42);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "Voitures";
            this.btn1.UseSelectable = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(101, 19);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(65, 42);
            this.btn2.TabIndex = 0;
            this.btn2.Text = "Location";
            this.btn2.UseSelectable = true;
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(295, 19);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(119, 42);
            this.btn3.TabIndex = 0;
            this.btn3.Text = "Retour Location";
            this.btn3.UseSelectable = true;
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(172, 19);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(53, 42);
            this.metroButton2.TabIndex = 0;
            this.metroButton2.Text = "Clients";
            this.metroButton2.UseSelectable = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(420, 19);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(62, 41);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseSelectable = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FMenuGenerale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GESTION_DE_LOCATION_DES_VOITURES.Properties.Resources.RC1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(504, 621);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FMenuGenerale";
            this.Padding = new System.Windows.Forms.Padding(40, 129, 40, 43);
            this.Text = "Sociéte Salem de Location de Voiture";
            this.Load += new System.EventHandler(this.FMenuGenerale_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btn1;
        private MetroFramework.Controls.MetroButton btn2;
        private MetroFramework.Controls.MetroButton btn3;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton btnClose;
    }
}