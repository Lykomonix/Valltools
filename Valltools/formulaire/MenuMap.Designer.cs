namespace Valltools.formulaire
{
    partial class MenuMap
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
            this.tlpMenuMap = new System.Windows.Forms.TableLayoutPanel();
            this.btnRanked = new System.Windows.Forms.Button();
            this.btnAllMap = new System.Windows.Forms.Button();
            this.btnFilteredMap = new System.Windows.Forms.Button();
            this.tlpMenuMap.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMenuMap
            // 
            this.tlpMenuMap.ColumnCount = 1;
            this.tlpMenuMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMenuMap.Controls.Add(this.btnRanked, 0, 0);
            this.tlpMenuMap.Controls.Add(this.btnAllMap, 0, 1);
            this.tlpMenuMap.Controls.Add(this.btnFilteredMap, 0, 2);
            this.tlpMenuMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMenuMap.Location = new System.Drawing.Point(0, 0);
            this.tlpMenuMap.Name = "tlpMenuMap";
            this.tlpMenuMap.RowCount = 3;
            this.tlpMenuMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpMenuMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpMenuMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpMenuMap.Size = new System.Drawing.Size(942, 493);
            this.tlpMenuMap.TabIndex = 0;
            // 
            // btnRanked
            // 
            this.btnRanked.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRanked.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnRanked.Location = new System.Drawing.Point(3, 3);
            this.btnRanked.Name = "btnRanked";
            this.btnRanked.Size = new System.Drawing.Size(936, 158);
            this.btnRanked.TabIndex = 0;
            this.btnRanked.Text = "Ranked Map Pool";
            this.btnRanked.UseVisualStyleBackColor = true;
            this.btnRanked.Click += new System.EventHandler(this.btnRanked_Click);
            // 
            // btnAllMap
            // 
            this.btnAllMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAllMap.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnAllMap.Location = new System.Drawing.Point(3, 167);
            this.btnAllMap.Name = "btnAllMap";
            this.btnAllMap.Size = new System.Drawing.Size(936, 158);
            this.btnAllMap.TabIndex = 1;
            this.btnAllMap.Text = "All Map Pool";
            this.btnAllMap.UseVisualStyleBackColor = true;
            this.btnAllMap.Click += new System.EventHandler(this.btnAllMap_Click);
            // 
            // btnFilteredMap
            // 
            this.btnFilteredMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFilteredMap.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnFilteredMap.Location = new System.Drawing.Point(3, 331);
            this.btnFilteredMap.Name = "btnFilteredMap";
            this.btnFilteredMap.Size = new System.Drawing.Size(936, 159);
            this.btnFilteredMap.TabIndex = 2;
            this.btnFilteredMap.Text = "Filtered Map Pool";
            this.btnFilteredMap.UseVisualStyleBackColor = true;
            this.btnFilteredMap.Click += new System.EventHandler(this.btnFilteredMap_Click);
            // 
            // MenuMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 493);
            this.Controls.Add(this.tlpMenuMap);
            this.Name = "MenuMap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Valltools/Map";
            this.tlpMenuMap.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMenuMap;
        private System.Windows.Forms.Button btnRanked;
        private System.Windows.Forms.Button btnAllMap;
        private System.Windows.Forms.Button btnFilteredMap;
    }
}