namespace Gestion_academique.Views
{
    partial class Menu
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.principale = new System.Windows.Forms.Panel();
            this.btnInscription = new System.Windows.Forms.Button();
            this.btnFrais = new System.Windows.Forms.Button();
            this.btnCotation = new System.Windows.Forms.Button();
            this.btnElection = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.principale);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1752, 571);
            this.splitContainer1.SplitterDistance = 304;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.btnElection);
            this.panel1.Controls.Add(this.btnCotation);
            this.panel1.Controls.Add(this.btnFrais);
            this.panel1.Controls.Add(this.btnInscription);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(298, 565);
            this.panel1.TabIndex = 0;
            // 
            // principale
            // 
            this.principale.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.principale.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.principale.Location = new System.Drawing.Point(25, 3);
            this.principale.Name = "principale";
            this.principale.Size = new System.Drawing.Size(1416, 565);
            this.principale.TabIndex = 1;
            // 
            // btnInscription
            // 
            this.btnInscription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInscription.Location = new System.Drawing.Point(4, 15);
            this.btnInscription.Name = "btnInscription";
            this.btnInscription.Size = new System.Drawing.Size(287, 61);
            this.btnInscription.TabIndex = 0;
            this.btnInscription.Text = "Inscription";
            this.btnInscription.UseVisualStyleBackColor = true;
            this.btnInscription.Click += new System.EventHandler(this.Operations);
            // 
            // btnFrais
            // 
            this.btnFrais.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFrais.Location = new System.Drawing.Point(3, 105);
            this.btnFrais.Name = "btnFrais";
            this.btnFrais.Size = new System.Drawing.Size(287, 64);
            this.btnFrais.TabIndex = 1;
            this.btnFrais.Text = "Frais Academiques";
            this.btnFrais.UseVisualStyleBackColor = true;
            this.btnFrais.Click += new System.EventHandler(this.Operations);
            // 
            // btnCotation
            // 
            this.btnCotation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCotation.Location = new System.Drawing.Point(3, 207);
            this.btnCotation.Name = "btnCotation";
            this.btnCotation.Size = new System.Drawing.Size(288, 60);
            this.btnCotation.TabIndex = 2;
            this.btnCotation.Text = "Cotation";
            this.btnCotation.UseVisualStyleBackColor = true;
            this.btnCotation.Click += new System.EventHandler(this.Operations);
            // 
            // btnElection
            // 
            this.btnElection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnElection.Location = new System.Drawing.Point(2, 304);
            this.btnElection.Name = "btnElection";
            this.btnElection.Size = new System.Drawing.Size(288, 63);
            this.btnElection.TabIndex = 3;
            this.btnElection.Text = "Election ";
            this.btnElection.UseVisualStyleBackColor = true;
            this.btnElection.Click += new System.EventHandler(this.Operations);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.Location = new System.Drawing.Point(15, 482);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(271, 54);
            this.button5.TabIndex = 4;
            this.button5.Text = "Quitter";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Menu";
            this.Size = new System.Drawing.Size(1752, 571);
            this.Load += new System.EventHandler(this.Menu_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnElection;
        private System.Windows.Forms.Button btnCotation;
        private System.Windows.Forms.Button btnFrais;
        private System.Windows.Forms.Button btnInscription;
        private System.Windows.Forms.Panel principale;
    }
}
