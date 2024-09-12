namespace Gestion_academique.Formulaire
{
    partial class Home
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
            this.Apex = new System.Windows.Forms.SplitContainer();
            this.lblconnection = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtpwd = new System.Windows.Forms.TextBox();
            this.btnconnection = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.PanelParent = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Apex)).BeginInit();
            this.Apex.Panel1.SuspendLayout();
            this.Apex.Panel2.SuspendLayout();
            this.Apex.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Apex
            // 
            this.Apex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Apex.Location = new System.Drawing.Point(0, 0);
            this.Apex.Name = "Apex";
            this.Apex.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // Apex.Panel1
            // 
            this.Apex.Panel1.Controls.Add(this.lblconnection);
            this.Apex.Panel1.Controls.Add(this.groupBox1);
            // 
            // Apex.Panel2
            // 
            this.Apex.Panel2.Controls.Add(this.PanelParent);
            this.Apex.Size = new System.Drawing.Size(1776, 752);
            this.Apex.SplitterDistance = 151;
            this.Apex.TabIndex = 0;
            // 
            // lblconnection
            // 
            this.lblconnection.AutoSize = true;
            this.lblconnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblconnection.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblconnection.Location = new System.Drawing.Point(3, 57);
            this.lblconnection.Margin = new System.Windows.Forms.Padding(3);
            this.lblconnection.Name = "lblconnection";
            this.lblconnection.Size = new System.Drawing.Size(287, 32);
            this.lblconnection.TabIndex = 1;
            this.lblconnection.Text = "Utilisateur Connecté :";
            this.lblconnection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtpwd);
            this.groupBox1.Controls.Add(this.btnconnection);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtuser);
            this.groupBox1.Location = new System.Drawing.Point(559, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1191, 136);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Authentification";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(329, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // txtpwd
            // 
            this.txtpwd.Location = new System.Drawing.Point(445, 67);
            this.txtpwd.Multiline = true;
            this.txtpwd.Name = "txtpwd";
            this.txtpwd.Size = new System.Drawing.Size(209, 47);
            this.txtpwd.TabIndex = 3;
            // 
            // btnconnection
            // 
            this.btnconnection.Location = new System.Drawing.Point(733, 67);
            this.btnconnection.Name = "btnconnection";
            this.btnconnection.Size = new System.Drawing.Size(239, 47);
            this.btnconnection.TabIndex = 2;
            this.btnconnection.Text = "Connecter";
            this.btnconnection.UseVisualStyleBackColor = true;
            this.btnconnection.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(114, 66);
            this.txtuser.Multiline = true;
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(186, 48);
            this.txtuser.TabIndex = 0;
            // 
            // PanelParent
            // 
            this.PanelParent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelParent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelParent.Location = new System.Drawing.Point(12, 14);
            this.PanelParent.Name = "PanelParent";
            this.PanelParent.Size = new System.Drawing.Size(1752, 571);
            this.PanelParent.TabIndex = 0;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1776, 752);
            this.Controls.Add(this.Apex);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Home_Load);
            this.Apex.Panel1.ResumeLayout(false);
            this.Apex.Panel1.PerformLayout();
            this.Apex.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Apex)).EndInit();
            this.Apex.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer Apex;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtpwd;
        private System.Windows.Forms.Button btnconnection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.Panel PanelParent;
        private System.Windows.Forms.Label lblconnection;
    }
}