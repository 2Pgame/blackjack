namespace blackjack
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ゲームToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewGame = new System.Windows.Forms.ToolStripMenuItem();
            this.ShuffleCard = new System.Windows.Forms.ToolStripMenuItem();
            this.ゲーム終了ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ヘルプToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.version = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ゲームToolStripMenuItem,
            this.ヘルプToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ゲームToolStripMenuItem
            // 
            this.ゲームToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewGame,
            this.ShuffleCard,
            this.ゲーム終了ToolStripMenuItem});
            this.ゲームToolStripMenuItem.Name = "ゲームToolStripMenuItem";
            this.ゲームToolStripMenuItem.Size = new System.Drawing.Size(68, 29);
            this.ゲームToolStripMenuItem.Text = "ゲーム";
            // 
            // NewGame
            // 
            this.NewGame.Name = "NewGame";
            this.NewGame.Size = new System.Drawing.Size(270, 34);
            this.NewGame.Text = "新規作成";
            this.NewGame.Click += new System.EventHandler(this.NewGameClicked);
            // 
            // ShuffleCard
            // 
            this.ShuffleCard.Name = "ShuffleCard";
            this.ShuffleCard.Size = new System.Drawing.Size(270, 34);
            this.ShuffleCard.Text = "カードをシャッフル";
            this.ShuffleCard.Click += new System.EventHandler(this.ShuffleClicked);
            // 
            // ゲーム終了ToolStripMenuItem
            // 
            this.ゲーム終了ToolStripMenuItem.Name = "ゲーム終了ToolStripMenuItem";
            this.ゲーム終了ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.ゲーム終了ToolStripMenuItem.Text = "ゲーム終了";
            this.ゲーム終了ToolStripMenuItem.Click += new System.EventHandler(this.GameEndClicked);
            // 
            // ヘルプToolStripMenuItem
            // 
            this.ヘルプToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.version});
            this.ヘルプToolStripMenuItem.Name = "ヘルプToolStripMenuItem";
            this.ヘルプToolStripMenuItem.Size = new System.Drawing.Size(72, 29);
            this.ヘルプToolStripMenuItem.Text = "ヘルプ";
            // 
            // version
            // 
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(180, 34);
            this.version.Text = "バージョン";
            this.version.Click += new System.EventHandler(this.VersionClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ゲームToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewGame;
        private System.Windows.Forms.ToolStripMenuItem ShuffleCard;
        private System.Windows.Forms.ToolStripMenuItem ゲーム終了ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ヘルプToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem version;
    }
}

