namespace Champions
{
    partial class mainForm
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.upperFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.middleFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.lowwerFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.sqlConnectionLbl = new System.Windows.Forms.Label();
            this.sqliteConnectionLbl = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lowwerFlowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // upperFlowLayoutPanel
            // 
            this.upperFlowLayoutPanel.AutoScroll = true;
            this.upperFlowLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.upperFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.upperFlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.upperFlowLayoutPanel.Name = "upperFlowLayoutPanel";
            this.upperFlowLayoutPanel.Size = new System.Drawing.Size(800, 100);
            this.upperFlowLayoutPanel.TabIndex = 0;
            // 
            // middleFlowLayoutPanel
            // 
            this.middleFlowLayoutPanel.AutoScroll = true;
            this.middleFlowLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.middleFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.middleFlowLayoutPanel.Location = new System.Drawing.Point(0, 100);
            this.middleFlowLayoutPanel.Name = "middleFlowLayoutPanel";
            this.middleFlowLayoutPanel.Size = new System.Drawing.Size(800, 350);
            this.middleFlowLayoutPanel.TabIndex = 1;
            // 
            // lowwerFlowLayoutPanel
            // 
            this.lowwerFlowLayoutPanel.Controls.Add(this.sqlConnectionLbl);
            this.lowwerFlowLayoutPanel.Controls.Add(this.sqliteConnectionLbl);
            this.lowwerFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lowwerFlowLayoutPanel.Location = new System.Drawing.Point(0, 380);
            this.lowwerFlowLayoutPanel.Name = "lowwerFlowLayoutPanel";
            this.lowwerFlowLayoutPanel.Size = new System.Drawing.Size(800, 70);
            this.lowwerFlowLayoutPanel.TabIndex = 0;
            // 
            // sqlConnectionLbl
            // 
            this.sqlConnectionLbl.AutoSize = true;
            this.sqlConnectionLbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.sqlConnectionLbl.Location = new System.Drawing.Point(3, 0);
            this.sqlConnectionLbl.Name = "sqlConnectionLbl";
            this.sqlConnectionLbl.Size = new System.Drawing.Size(81, 13);
            this.sqlConnectionLbl.TabIndex = 0;
            this.sqlConnectionLbl.Text = "SQL database: ";
            // 
            // sqliteConnectionLbl
            // 
            this.sqliteConnectionLbl.AutoSize = true;
            this.sqliteConnectionLbl.Dock = System.Windows.Forms.DockStyle.Left;
            this.sqliteConnectionLbl.Location = new System.Drawing.Point(90, 0);
            this.sqliteConnectionLbl.Name = "sqliteConnectionLbl";
            this.sqliteConnectionLbl.Size = new System.Drawing.Size(92, 13);
            this.sqliteConnectionLbl.TabIndex = 1;
            this.sqliteConnectionLbl.Text = "SQLite database: ";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 500;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lowwerFlowLayoutPanel);
            this.Controls.Add(this.middleFlowLayoutPanel);
            this.Controls.Add(this.upperFlowLayoutPanel);
            this.Name = "mainForm";
            this.Text = "Game";
            this.lowwerFlowLayoutPanel.ResumeLayout(false);
            this.lowwerFlowLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel upperFlowLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel middleFlowLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel lowwerFlowLayoutPanel;
        private System.Windows.Forms.Label sqlConnectionLbl;
        private System.Windows.Forms.Label sqliteConnectionLbl;
        private System.Windows.Forms.Timer timer;
    }
}

