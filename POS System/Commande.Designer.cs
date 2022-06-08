namespace POS_System
{
    partial class Commande
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Commande));
            this.btnSav = new System.Windows.Forms.Button();
            this.inpCod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numQut = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBck = new System.Windows.Forms.Button();
            this.lblQuit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numQut)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSav
            // 
            this.btnSav.BackColor = System.Drawing.Color.SkyBlue;
            this.btnSav.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSav.FlatAppearance.BorderSize = 0;
            this.btnSav.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSav.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSav.Location = new System.Drawing.Point(306, 180);
            this.btnSav.Margin = new System.Windows.Forms.Padding(4);
            this.btnSav.Name = "btnSav";
            this.btnSav.Size = new System.Drawing.Size(102, 35);
            this.btnSav.TabIndex = 5;
            this.btnSav.Text = "Confirmer";
            this.btnSav.UseVisualStyleBackColor = false;
            // 
            // inpCod
            // 
            this.inpCod.Location = new System.Drawing.Point(300, 67);
            this.inpCod.Margin = new System.Windows.Forms.Padding(4);
            this.inpCod.Multiline = true;
            this.inpCod.Name = "inpCod";
            this.inpCod.Size = new System.Drawing.Size(218, 26);
            this.inpCod.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(296, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Code:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(296, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Quantité:";
            // 
            // numQut
            // 
            this.numQut.Location = new System.Drawing.Point(300, 126);
            this.numQut.Name = "numQut";
            this.numQut.Size = new System.Drawing.Size(120, 24);
            this.numQut.TabIndex = 9;
            this.numQut.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(29, 96);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 29);
            this.label3.TabIndex = 10;
            this.label3.Text = "Commander";
            // 
            // btnBck
            // 
            this.btnBck.BackColor = System.Drawing.Color.SkyBlue;
            this.btnBck.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBck.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBck.FlatAppearance.BorderSize = 0;
            this.btnBck.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBck.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBck.Location = new System.Drawing.Point(416, 180);
            this.btnBck.Margin = new System.Windows.Forms.Padding(4);
            this.btnBck.Name = "btnBck";
            this.btnBck.Size = new System.Drawing.Size(102, 35);
            this.btnBck.TabIndex = 11;
            this.btnBck.Text = "Retour";
            this.btnBck.UseVisualStyleBackColor = false;
            this.btnBck.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblQuit
            // 
            this.lblQuit.AutoSize = true;
            this.lblQuit.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuit.ForeColor = System.Drawing.Color.Crimson;
            this.lblQuit.Location = new System.Drawing.Point(558, -1);
            this.lblQuit.Name = "lblQuit";
            this.lblQuit.Size = new System.Drawing.Size(23, 28);
            this.lblQuit.TabIndex = 12;
            this.lblQuit.Text = "x";
            this.lblQuit.Click += new System.EventHandler(this.lblQuit_Click);
            // 
            // Commande
            // 
            this.AcceptButton = this.btnSav;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnBck;
            this.ClientSize = new System.Drawing.Size(582, 250);
            this.Controls.Add(this.lblQuit);
            this.Controls.Add(this.btnBck);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inpCod);
            this.Controls.Add(this.numQut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSav);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Commande";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Commande";
            ((System.ComponentModel.ISupportInitialize)(this.numQut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSav;
        private System.Windows.Forms.TextBox inpCod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numQut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBck;
        private System.Windows.Forms.Label lblQuit;
    }
}