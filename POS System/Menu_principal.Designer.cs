namespace POS_System
{
    partial class MenuMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuMain));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsLogin = new System.Windows.Forms.ToolStripButton();
            this.tsHistoriqueTransaction = new System.Windows.Forms.ToolStripButton();
            this.tsGestionCompte = new System.Windows.Forms.ToolStripButton();
            this.tsJournalClient = new System.Windows.Forms.ToolStripButton();
            this.tsRelevé = new System.Windows.Forms.ToolStripButton();
            this.tsProduit = new System.Windows.Forms.ToolStripButton();
            this.tsCommande = new System.Windows.Forms.ToolStripButton();
            this.tsRapport = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tsVente = new System.Windows.Forms.ToolStripButton();
            this.tsParametres = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsLogin,
            this.tsHistoriqueTransaction,
            this.tsGestionCompte,
            this.tsJournalClient,
            this.tsRelevé,
            this.tsProduit,
            this.tsCommande,
            this.tsRapport,
            this.toolStripButton1,
            this.tsVente,
            this.tsParametres});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(112, 556);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90;
            // 
            // tsLogin
            // 
            this.tsLogin.AutoSize = false;
            this.tsLogin.BackColor = System.Drawing.SystemColors.Control;
            this.tsLogin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsLogin.Image = global::POS_System.Properties.Resources.login;
            this.tsLogin.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsLogin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsLogin.Name = "tsLogin";
            this.tsLogin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tsLogin.Size = new System.Drawing.Size(105, 40);
            this.tsLogin.Text = "Login";
            this.tsLogin.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.tsLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsLogin.Click += new System.EventHandler(this.tsLogin_Click);
            // 
            // tsHistoriqueTransaction
            // 
            this.tsHistoriqueTransaction.AutoSize = false;
            this.tsHistoriqueTransaction.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsHistoriqueTransaction.Image = global::POS_System.Properties.Resources.Sales_report_25411;
            this.tsHistoriqueTransaction.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsHistoriqueTransaction.Name = "tsHistoriqueTransaction";
            this.tsHistoriqueTransaction.Size = new System.Drawing.Size(105, 45);
            this.tsHistoriqueTransaction.Text = "Historique trans";
            this.tsHistoriqueTransaction.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.tsHistoriqueTransaction.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsGestionCompte
            // 
            this.tsGestionCompte.AutoSize = false;
            this.tsGestionCompte.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsGestionCompte.Image = global::POS_System.Properties.Resources.communities;
            this.tsGestionCompte.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsGestionCompte.Name = "tsGestionCompte";
            this.tsGestionCompte.Size = new System.Drawing.Size(105, 45);
            this.tsGestionCompte.Text = "Créer compte";
            this.tsGestionCompte.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.tsGestionCompte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsGestionCompte.Click += new System.EventHandler(this.tsGestionCompte_Click);
            // 
            // tsJournalClient
            // 
            this.tsJournalClient.AutoSize = false;
            this.tsJournalClient.Image = global::POS_System.Properties.Resources.icons8_check_out_100;
            this.tsJournalClient.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsJournalClient.Name = "tsJournalClient";
            this.tsJournalClient.Size = new System.Drawing.Size(105, 45);
            this.tsJournalClient.Text = "Journal Client";
            this.tsJournalClient.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.tsJournalClient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsRelevé
            // 
            this.tsRelevé.AutoSize = false;
            this.tsRelevé.Image = global::POS_System.Properties.Resources.icons8_remplacer_100;
            this.tsRelevé.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsRelevé.Name = "tsRelevé";
            this.tsRelevé.Size = new System.Drawing.Size(105, 45);
            this.tsRelevé.Text = "Relevé";
            this.tsRelevé.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.tsRelevé.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsRelevé.ToolTipText = "Relevé";
            // 
            // tsProduit
            // 
            this.tsProduit.AutoSize = false;
            this.tsProduit.Image = global::POS_System.Properties.Resources.icons8_nouveau_produit_100;
            this.tsProduit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsProduit.Name = "tsProduit";
            this.tsProduit.Size = new System.Drawing.Size(105, 45);
            this.tsProduit.Text = "Produit";
            this.tsProduit.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.tsProduit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsProduit.Click += new System.EventHandler(this.tsProduit_Click);
            // 
            // tsCommande
            // 
            this.tsCommande.AutoSize = false;
            this.tsCommande.Image = global::POS_System.Properties.Resources.command_folder_20503;
            this.tsCommande.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsCommande.Name = "tsCommande";
            this.tsCommande.Size = new System.Drawing.Size(105, 45);
            this.tsCommande.Text = "Commande";
            this.tsCommande.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.tsCommande.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsCommande.Click += new System.EventHandler(this.tsCommande_Click);
            // 
            // tsRapport
            // 
            this.tsRapport.AutoSize = false;
            this.tsRapport.Image = global::POS_System.Properties.Resources.trade_report_reports_documents_2351;
            this.tsRapport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsRapport.Name = "tsRapport";
            this.tsRapport.Size = new System.Drawing.Size(105, 45);
            this.tsRapport.Text = "Rapport";
            this.tsRapport.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.tsRapport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.AutoSize = false;
            this.toolStripButton1.Image = global::POS_System.Properties.Resources._1486504352_checklist_clipboard_inventory_list_report_tasks_todo_81326;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(105, 45);
            this.toolStripButton1.Text = "Inventaire";
            this.toolStripButton1.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsVente
            // 
            this.tsVente.AutoSize = false;
            this.tsVente.Image = global::POS_System.Properties.Resources.sales_sale_supermarket_stock_market_icon_153077;
            this.tsVente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsVente.Name = "tsVente";
            this.tsVente.Size = new System.Drawing.Size(105, 45);
            this.tsVente.Text = "Vente";
            this.tsVente.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.tsVente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsParametres
            // 
            this.tsParametres.AutoSize = false;
            this.tsParametres.Image = global::POS_System.Properties.Resources.settings;
            this.tsParametres.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsParametres.Name = "tsParametres";
            this.tsParametres.Size = new System.Drawing.Size(107, 45);
            this.tsParametres.Text = "Parametres";
            this.tsParametres.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.tsParametres.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // MenuMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(988, 556);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MenuMain";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsLogin;
        private System.Windows.Forms.ToolStripButton tsHistoriqueTransaction;
        private System.Windows.Forms.ToolStripButton tsGestionCompte;
        private System.Windows.Forms.ToolStripButton tsJournalClient;
        private System.Windows.Forms.ToolStripButton tsRelevé;
        private System.Windows.Forms.ToolStripButton tsProduit;
        private System.Windows.Forms.ToolStripButton tsCommande;
        private System.Windows.Forms.ToolStripButton tsRapport;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton tsVente;
        private System.Windows.Forms.ToolStripButton tsParametres;
    }
}

