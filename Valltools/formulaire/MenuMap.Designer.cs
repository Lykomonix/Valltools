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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnRanked = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnRanked, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAll, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnFilter, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(942, 493);
            this.tableLayoutPanel1.TabIndex = 0;
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
            // btnAll
            // 
            this.btnAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnAll.Location = new System.Drawing.Point(3, 167);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(936, 158);
            this.btnAll.TabIndex = 1;
            this.btnAll.Text = "All Map Pool";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnFilter.Location = new System.Drawing.Point(3, 331);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(936, 159);
            this.btnFilter.TabIndex = 2;
            this.btnFilter.Text = "filtered Map Pool";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // MenuMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 493);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MenuMap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Valltools/Map";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnRanked;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Button btnFilter;
    }
}