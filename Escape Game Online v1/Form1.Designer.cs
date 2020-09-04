namespace Escape_Game_Online_v1
{
    partial class OcarinaBox
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMP = new System.Windows.Forms.TextBox();
            this.ValidationButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxName.Font = new System.Drawing.Font("Arial Narrow", 19.8F);
            this.textBoxName.Location = new System.Drawing.Point(88, 79);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(472, 45);
            this.textBoxName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F);
            this.label1.Location = new System.Drawing.Point(85, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nom Utilisateur :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F);
            this.label2.Location = new System.Drawing.Point(85, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mot de passe :";
            // 
            // textBoxMP
            // 
            this.textBoxMP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMP.Font = new System.Drawing.Font("Arial Narrow", 19.8F);
            this.textBoxMP.Location = new System.Drawing.Point(88, 167);
            this.textBoxMP.Name = "textBoxMP";
            this.textBoxMP.Size = new System.Drawing.Size(472, 45);
            this.textBoxMP.TabIndex = 4;
            // 
            // ValidationButton
            // 
            this.ValidationButton.AutoSize = true;
            this.ValidationButton.BackColor = System.Drawing.Color.ForestGreen;
            this.ValidationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ValidationButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ValidationButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F);
            this.ValidationButton.Location = new System.Drawing.Point(0, 249);
            this.ValidationButton.Name = "ValidationButton";
            this.ValidationButton.Size = new System.Drawing.Size(638, 79);
            this.ValidationButton.TabIndex = 5;
            this.ValidationButton.Text = "Valider";
            this.ValidationButton.UseVisualStyleBackColor = false;
            this.ValidationButton.Click += new System.EventHandler(this.ValidationButton_Click);
            // 
            // OcarinaBox
            // 
            this.AcceptButton = this.ValidationButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(638, 328);
            this.Controls.Add(this.ValidationButton);
            this.Controls.Add(this.textBoxMP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxName);
            this.Name = "OcarinaBox";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OcarinaBox";
            this.Load += new System.EventHandler(this.OcarinaBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMP;
        private System.Windows.Forms.Button ValidationButton;
    }
}

