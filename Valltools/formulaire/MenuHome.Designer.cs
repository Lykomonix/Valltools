namespace Valltools
{
    partial class MenuHome
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
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tlpMenu = new System.Windows.Forms.TableLayoutPanel();
            this.btnMap = new System.Windows.Forms.Button();
            this.btnAgent = new System.Windows.Forms.Button();
            this.pnlTitle.SuspendLayout();
            this.tlpMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitle
            // 
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(942, 75);
            this.pnlTitle.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblTitle.Location = new System.Drawing.Point(413, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(117, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Valltools";
            // 
            // tlpMenu
            // 
            this.tlpMenu.ColumnCount = 2;
            this.tlpMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMenu.Controls.Add(this.btnMap, 0, 0);
            this.tlpMenu.Controls.Add(this.btnAgent, 1, 0);
            this.tlpMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMenu.Location = new System.Drawing.Point(0, 75);
            this.tlpMenu.Name = "tlpMenu";
            this.tlpMenu.RowCount = 1;
            this.tlpMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMenu.Size = new System.Drawing.Size(942, 418);
            this.tlpMenu.TabIndex = 2;
            // 
            // btnMap
            // 
            this.btnMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMap.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnMap.Location = new System.Drawing.Point(3, 3);
            this.btnMap.Name = "btnMap";
            this.btnMap.Size = new System.Drawing.Size(465, 412);
            this.btnMap.TabIndex = 0;
            this.btnMap.Text = "Map";
            this.btnMap.UseVisualStyleBackColor = true;
            // 
            // btnAgent
            // 
            this.btnAgent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAgent.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnAgent.Location = new System.Drawing.Point(474, 3);
            this.btnAgent.Name = "btnAgent";
            this.btnAgent.Size = new System.Drawing.Size(465, 412);
            this.btnAgent.TabIndex = 1;
            this.btnAgent.Text = "Agent";
            this.btnAgent.UseVisualStyleBackColor = true;
            // 
            // MenuHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 493);
            this.Controls.Add(this.tlpMenu);
            this.Controls.Add(this.pnlTitle);
            this.Name = "MenuHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Valltools";
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.tlpMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TableLayoutPanel tlpMenu;
        private System.Windows.Forms.Button btnMap;
        private System.Windows.Forms.Button btnAgent;
    }
}

