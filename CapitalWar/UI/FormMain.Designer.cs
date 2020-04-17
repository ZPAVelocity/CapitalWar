namespace CapitalWar.UI
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItemStart = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemStartGame = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemLoadGame = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSaveGame = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelPlayer = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelLocation = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelAsset = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStripMain.SuspendLayout();
            this.statusStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelMain.ColumnCount = 2;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 31);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 2;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(782, 493);
            this.tableLayoutPanelMain.TabIndex = 0;
            // 
            // menuStripMain
            // 
            this.menuStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemStart});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(782, 28);
            this.menuStripMain.TabIndex = 1;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // ToolStripMenuItemStart
            // 
            this.ToolStripMenuItemStart.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemStartGame,
            this.ToolStripMenuItemLoadGame,
            this.ToolStripMenuItemSaveGame});
            this.ToolStripMenuItemStart.Name = "ToolStripMenuItemStart";
            this.ToolStripMenuItemStart.Size = new System.Drawing.Size(53, 24);
            this.ToolStripMenuItemStart.Text = "开始";
            // 
            // ToolStripMenuItemStartGame
            // 
            this.ToolStripMenuItemStartGame.Name = "ToolStripMenuItemStartGame";
            this.ToolStripMenuItemStartGame.Size = new System.Drawing.Size(224, 26);
            this.ToolStripMenuItemStartGame.Text = "开始游戏";
            // 
            // ToolStripMenuItemLoadGame
            // 
            this.ToolStripMenuItemLoadGame.Name = "ToolStripMenuItemLoadGame";
            this.ToolStripMenuItemLoadGame.Size = new System.Drawing.Size(224, 26);
            this.ToolStripMenuItemLoadGame.Text = "加载游戏";
            // 
            // ToolStripMenuItemSaveGame
            // 
            this.ToolStripMenuItemSaveGame.Name = "ToolStripMenuItemSaveGame";
            this.ToolStripMenuItemSaveGame.Size = new System.Drawing.Size(224, 26);
            this.ToolStripMenuItemSaveGame.Text = "保存游戏";
            // 
            // statusStripMain
            // 
            this.statusStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelStatus,
            this.toolStripStatusLabelPlayer,
            this.toolStripStatusLabelLocation,
            this.toolStripStatusLabelAsset});
            this.statusStripMain.Location = new System.Drawing.Point(0, 527);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Size = new System.Drawing.Size(782, 26);
            this.statusStripMain.TabIndex = 2;
            this.statusStripMain.Text = "statusStrip1";
            // 
            // toolStripStatusLabelPlayer
            // 
            this.toolStripStatusLabelPlayer.Name = "toolStripStatusLabelPlayer";
            this.toolStripStatusLabelPlayer.Size = new System.Drawing.Size(54, 20);
            this.toolStripStatusLabelPlayer.Text = "玩家：";
            // 
            // toolStripStatusLabelLocation
            // 
            this.toolStripStatusLabelLocation.Name = "toolStripStatusLabelLocation";
            this.toolStripStatusLabelLocation.Size = new System.Drawing.Size(84, 20);
            this.toolStripStatusLabelLocation.Text = "当前位置：";
            // 
            // toolStripStatusLabelAsset
            // 
            this.toolStripStatusLabelAsset.Name = "toolStripStatusLabelAsset";
            this.toolStripStatusLabelAsset.Size = new System.Drawing.Size(84, 20);
            this.toolStripStatusLabelAsset.Text = "当前资金：";
            // 
            // toolStripStatusLabelStatus
            // 
            this.toolStripStatusLabelStatus.Name = "toolStripStatusLabelStatus";
            this.toolStripStatusLabelStatus.Size = new System.Drawing.Size(54, 20);
            this.toolStripStatusLabelStatus.Text = "状态：";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.statusStripMain);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Controls.Add(this.menuStripMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "FormMain";
            this.Text = "Form1";
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.statusStripMain.ResumeLayout(false);
            this.statusStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemStart;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemStartGame;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemLoadGame;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSaveGame;
        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelPlayer;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelLocation;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelAsset;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelStatus;
    }
}