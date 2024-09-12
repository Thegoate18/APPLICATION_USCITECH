namespace Gestion_academique.Views
{
    partial class Inscription
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvListing = new System.Windows.Forms.DataGridView();
            this.div = new System.Windows.Forms.SplitContainer();
            this.dgvCandidat = new System.Windows.Forms.DataGridView();
            this.div2 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.txtPourcentage = new System.Windows.Forms.TextBox();
            this.datNess = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxEcole = new System.Windows.Forms.ComboBox();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.div)).BeginInit();
            this.div.Panel1.SuspendLayout();
            this.div.Panel2.SuspendLayout();
            this.div.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.div2)).BeginInit();
            this.div2.Panel1.SuspendLayout();
            this.div2.Panel2.SuspendLayout();
            this.div2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(16, 15);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1378, 531);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.div);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1370, 493);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Demande Inscription";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1370, 493);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Validation Inscription";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgvListing);
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1370, 493);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Listing";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvListing
            // 
            this.dgvListing.AllowUserToAddRows = false;
            this.dgvListing.AllowUserToDeleteRows = false;
            this.dgvListing.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListing.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListing.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvListing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListing.Location = new System.Drawing.Point(6, 99);
            this.dgvListing.Name = "dgvListing";
            this.dgvListing.ReadOnly = true;
            this.dgvListing.RowTemplate.Height = 24;
            this.dgvListing.Size = new System.Drawing.Size(1358, 388);
            this.dgvListing.TabIndex = 0;
            // 
            // div
            // 
            this.div.Dock = System.Windows.Forms.DockStyle.Fill;
            this.div.Location = new System.Drawing.Point(3, 3);
            this.div.Name = "div";
            this.div.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // div.Panel1
            // 
            this.div.Panel1.Controls.Add(this.div2);
            // 
            // div.Panel2
            // 
            this.div.Panel2.Controls.Add(this.dgvCandidat);
            this.div.Size = new System.Drawing.Size(1364, 487);
            this.div.SplitterDistance = 295;
            this.div.TabIndex = 0;
            // 
            // dgvCandidat
            // 
            this.dgvCandidat.AllowUserToAddRows = false;
            this.dgvCandidat.AllowUserToDeleteRows = false;
            this.dgvCandidat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCandidat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCandidat.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCandidat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCandidat.Location = new System.Drawing.Point(3, 21);
            this.dgvCandidat.Name = "dgvCandidat";
            this.dgvCandidat.ReadOnly = true;
            this.dgvCandidat.RowTemplate.Height = 24;
            this.dgvCandidat.Size = new System.Drawing.Size(1358, 164);
            this.dgvCandidat.TabIndex = 1;
            // 
            // div2
            // 
            this.div2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.div2.Location = new System.Drawing.Point(0, 0);
            this.div2.Name = "div2";
            // 
            // div2.Panel1
            // 
            this.div2.Panel1.Controls.Add(this.cbxEcole);
            this.div2.Panel1.Controls.Add(this.label4);
            this.div2.Panel1.Controls.Add(this.label3);
            this.div2.Panel1.Controls.Add(this.label2);
            this.div2.Panel1.Controls.Add(this.txtTelephone);
            this.div2.Panel1.Controls.Add(this.txtPrenom);
            this.div2.Panel1.Controls.Add(this.txtNom);
            this.div2.Panel1.Controls.Add(this.label1);
            // 
            // div2.Panel2
            // 
            this.div2.Panel2.Controls.Add(this.btnEnregistrer);
            this.div2.Panel2.Controls.Add(this.label5);
            this.div2.Panel2.Controls.Add(this.label6);
            this.div2.Panel2.Controls.Add(this.datNess);
            this.div2.Panel2.Controls.Add(this.txtPourcentage);
            this.div2.Size = new System.Drawing.Size(1364, 295);
            this.div2.SplitterDistance = 678;
            this.div2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom ";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(134, 19);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(335, 30);
            this.txtNom.TabIndex = 1;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(134, 83);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(335, 30);
            this.txtPrenom.TabIndex = 2;
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(134, 151);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(335, 30);
            this.txtTelephone.TabIndex = 3;
            // 
            // txtPourcentage
            // 
            this.txtPourcentage.Location = new System.Drawing.Point(221, 14);
            this.txtPourcentage.Name = "txtPourcentage";
            this.txtPourcentage.Size = new System.Drawing.Size(202, 30);
            this.txtPourcentage.TabIndex = 5;
            this.txtPourcentage.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // datNess
            // 
            this.datNess.Location = new System.Drawing.Point(221, 72);
            this.datNess.Name = "datNess";
            this.datNess.Size = new System.Drawing.Size(200, 30);
            this.datNess.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Prénom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Téléphone ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ecole ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Pourcentage";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "Date de naissance";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // cbxEcole
            // 
            this.cbxEcole.FormattingEnabled = true;
            this.cbxEcole.Location = new System.Drawing.Point(134, 214);
            this.cbxEcole.Name = "cbxEcole";
            this.cbxEcole.Size = new System.Drawing.Size(335, 33);
            this.cbxEcole.TabIndex = 10;
            this.cbxEcole.SelectedIndexChanged += new System.EventHandler(this.getID);
            this.cbxEcole.SelectedValueChanged += new System.EventHandler(this.getID);
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(33, 222);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(217, 54);
            this.btnEnregistrer.TabIndex = 11;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            // 
            // Inscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Inscription";
            this.Size = new System.Drawing.Size(1416, 565);
            this.Load += new System.EventHandler(this.Inscription_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListing)).EndInit();
            this.div.Panel1.ResumeLayout(false);
            this.div.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.div)).EndInit();
            this.div.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidat)).EndInit();
            this.div2.Panel1.ResumeLayout(false);
            this.div2.Panel1.PerformLayout();
            this.div2.Panel2.ResumeLayout(false);
            this.div2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.div2)).EndInit();
            this.div2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgvListing;
        private System.Windows.Forms.SplitContainer div;
        private System.Windows.Forms.SplitContainer div2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPourcentage;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker datNess;
        private System.Windows.Forms.DataGridView dgvCandidat;
        private System.Windows.Forms.ComboBox cbxEcole;
        private System.Windows.Forms.Button btnEnregistrer;
    }
}
