namespace LabelShop
{
    partial class LabelShop
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxtColorChoice = new System.Windows.Forms.Label();
            this.ComboBoxColor = new System.Windows.Forms.ComboBox();
            this.BtnNewGrid = new System.Windows.Forms.Button();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.btnRotation = new System.Windows.Forms.Button();
            this.btnHorizontale = new System.Windows.Forms.Button();
            this.btnVerticale = new System.Windows.Forms.Button();
            this.btnOuvrir = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtColorChoice
            // 
            this.TxtColorChoice.AutoSize = true;
            this.TxtColorChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtColorChoice.Location = new System.Drawing.Point(12, 12);
            this.TxtColorChoice.Name = "TxtColorChoice";
            this.TxtColorChoice.Size = new System.Drawing.Size(127, 16);
            this.TxtColorChoice.TabIndex = 0;
            this.TxtColorChoice.Text = "Choix des couleurs :";
            this.TxtColorChoice.Click += new System.EventHandler(this.TxtColorChoice_Click);
            // 
            // ComboBoxColor
            // 
            this.ComboBoxColor.FormattingEnabled = true;
            this.ComboBoxColor.Location = new System.Drawing.Point(15, 31);
            this.ComboBoxColor.Name = "ComboBoxColor";
            this.ComboBoxColor.Size = new System.Drawing.Size(124, 21);
            this.ComboBoxColor.TabIndex = 1;
            this.ComboBoxColor.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // BtnNewGrid
            // 
            this.BtnNewGrid.Location = new System.Drawing.Point(15, 296);
            this.BtnNewGrid.Name = "BtnNewGrid";
            this.BtnNewGrid.Size = new System.Drawing.Size(124, 36);
            this.BtnNewGrid.TabIndex = 2;
            this.BtnNewGrid.Text = "Nouvelle Grille";
            this.BtnNewGrid.UseVisualStyleBackColor = true;
            this.BtnNewGrid.Click += new System.EventHandler(this.BtnNewGrid_Click);
            // 
            // pnlContainer
            // 
            this.pnlContainer.BackColor = System.Drawing.Color.White;
            this.pnlContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlContainer.Location = new System.Drawing.Point(186, 12);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(320, 320);
            this.pnlContainer.TabIndex = 3;
            this.pnlContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlContainer_Paint);
            // 
            // btnRotation
            // 
            this.btnRotation.Location = new System.Drawing.Point(15, 69);
            this.btnRotation.Name = "btnRotation";
            this.btnRotation.Size = new System.Drawing.Size(124, 38);
            this.btnRotation.TabIndex = 4;
            this.btnRotation.Text = "Rotation de +90";
            this.btnRotation.UseVisualStyleBackColor = true;
            this.btnRotation.Click += new System.EventHandler(this.btnRotation_Click);
            // 
            // btnHorizontale
            // 
            this.btnHorizontale.Location = new System.Drawing.Point(15, 114);
            this.btnHorizontale.Name = "btnHorizontale";
            this.btnHorizontale.Size = new System.Drawing.Size(124, 39);
            this.btnHorizontale.TabIndex = 5;
            this.btnHorizontale.Text = "Symétrie horizontale";
            this.btnHorizontale.UseVisualStyleBackColor = true;
            this.btnHorizontale.Click += new System.EventHandler(this.btnHorizontale_Click);
            // 
            // btnVerticale
            // 
            this.btnVerticale.Location = new System.Drawing.Point(15, 160);
            this.btnVerticale.Name = "btnVerticale";
            this.btnVerticale.Size = new System.Drawing.Size(124, 41);
            this.btnVerticale.TabIndex = 6;
            this.btnVerticale.Text = "Symétrie verticale";
            this.btnVerticale.UseVisualStyleBackColor = true;
            this.btnVerticale.Click += new System.EventHandler(this.btnVerticale_Click);
            // 
            // btnOuvrir
            // 
            this.btnOuvrir.Location = new System.Drawing.Point(15, 208);
            this.btnOuvrir.Name = "btnOuvrir";
            this.btnOuvrir.Size = new System.Drawing.Size(124, 41);
            this.btnOuvrir.TabIndex = 7;
            this.btnOuvrir.Text = "Ouvrir...";
            this.btnOuvrir.UseVisualStyleBackColor = true;
            this.btnOuvrir.Click += new System.EventHandler(this.btnOuvrir_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(15, 256);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(124, 34);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Enregistrer sous...";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // LabelShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 344);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnOuvrir);
            this.Controls.Add(this.btnVerticale);
            this.Controls.Add(this.btnHorizontale);
            this.Controls.Add(this.btnRotation);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.BtnNewGrid);
            this.Controls.Add(this.ComboBoxColor);
            this.Controls.Add(this.TxtColorChoice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LabelShop";
            this.Text = "LabelShop Basique N";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TxtColorChoice;
        private System.Windows.Forms.ComboBox ComboBoxColor;
        private System.Windows.Forms.Button BtnNewGrid;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Button btnRotation;
        private System.Windows.Forms.Button btnHorizontale;
        private System.Windows.Forms.Button btnVerticale;
        private System.Windows.Forms.Button btnOuvrir;
        private System.Windows.Forms.Button btnSave;
    }
}

