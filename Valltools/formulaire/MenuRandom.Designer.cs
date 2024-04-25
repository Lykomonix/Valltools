namespace Valltools.formulaire
{
    partial class MenuRandom
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
            this.tlpMenuRandom = new System.Windows.Forms.TableLayoutPanel();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.tlpMenuRandom.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMenuRandom
            // 
            this.tlpMenuRandom.ColumnCount = 1;
            this.tlpMenuRandom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMenuRandom.Controls.Add(this.btnGenerate, 0, 1);
            this.tlpMenuRandom.Controls.Add(this.lblName, 0, 0);
            this.tlpMenuRandom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMenuRandom.Location = new System.Drawing.Point(0, 0);
            this.tlpMenuRandom.Name = "tlpMenuRandom";
            this.tlpMenuRandom.RowCount = 2;
            this.tlpMenuRandom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tlpMenuRandom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpMenuRandom.Size = new System.Drawing.Size(942, 493);
            this.tlpMenuRandom.TabIndex = 0;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnGenerate.Location = new System.Drawing.Point(3, 422);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(936, 68);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // lblName
            // 
            this.lblName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F);
            this.lblName.Location = new System.Drawing.Point(3, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(936, 419);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "...";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MenuRandom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 493);
            this.Controls.Add(this.tlpMenuRandom);
            this.Name = "MenuRandom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Valltools/.../...";
            this.tlpMenuRandom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMenuRandom;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label lblName;
    }
}