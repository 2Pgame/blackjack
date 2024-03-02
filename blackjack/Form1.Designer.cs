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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ゲームToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewGame = new System.Windows.Forms.ToolStripMenuItem();
            this.ShuffleCard = new System.Windows.Forms.ToolStripMenuItem();
            this.CardRelease = new System.Windows.Forms.ToolStripMenuItem();
            this.ゲーム終了ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ヘルプToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.version = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox0 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DealerCard1 = new System.Windows.Forms.PictureBox();
            this.DealerCard2 = new System.Windows.Forms.PictureBox();
            this.DealerCard3 = new System.Windows.Forms.PictureBox();
            this.DealerCard4 = new System.Windows.Forms.PictureBox();
            this.DealerCard5 = new System.Windows.Forms.PictureBox();
            this.PlayerCard5 = new System.Windows.Forms.PictureBox();
            this.PlayerCard4 = new System.Windows.Forms.PictureBox();
            this.PlayerCard3 = new System.Windows.Forms.PictureBox();
            this.PlayerCard2 = new System.Windows.Forms.PictureBox();
            this.PlayerCard1 = new System.Windows.Forms.PictureBox();
            this.CardDraw = new System.Windows.Forms.Button();
            this.CardJudge = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PlayerPoint = new System.Windows.Forms.Label();
            this.DealerPoint = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DealerCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DealerCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DealerCard3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DealerCard4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DealerCard5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerCard5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerCard4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerCard3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerCard1)).BeginInit();
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1924, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ゲームToolStripMenuItem
            // 
            this.ゲームToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewGame,
            this.ShuffleCard,
            this.CardRelease,
            this.ゲーム終了ToolStripMenuItem});
            this.ゲームToolStripMenuItem.Name = "ゲームToolStripMenuItem";
            this.ゲームToolStripMenuItem.Size = new System.Drawing.Size(68, 29);
            this.ゲームToolStripMenuItem.Text = "ゲーム";
            // 
            // NewGame
            // 
            this.NewGame.Name = "NewGame";
            this.NewGame.Size = new System.Drawing.Size(230, 34);
            this.NewGame.Text = "新規作成";
            this.NewGame.Click += new System.EventHandler(this.NewGameClicked);
            // 
            // ShuffleCard
            // 
            this.ShuffleCard.Enabled = false;
            this.ShuffleCard.Name = "ShuffleCard";
            this.ShuffleCard.Size = new System.Drawing.Size(230, 34);
            this.ShuffleCard.Text = "カードをシャッフル";
            this.ShuffleCard.Click += new System.EventHandler(this.ShuffleClicked);
            // 
            // CardRelease
            // 
            this.CardRelease.Name = "CardRelease";
            this.CardRelease.Size = new System.Drawing.Size(230, 34);
            this.CardRelease.Text = "カードを配る";
            this.CardRelease.Click += new System.EventHandler(this.ReleaseClicked);
            // 
            // ゲーム終了ToolStripMenuItem
            // 
            this.ゲーム終了ToolStripMenuItem.Name = "ゲーム終了ToolStripMenuItem";
            this.ゲーム終了ToolStripMenuItem.Size = new System.Drawing.Size(230, 34);
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
            // pictureBox0
            // 
            this.pictureBox0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox0.Location = new System.Drawing.Point(0, 0);
            this.pictureBox0.Name = "pictureBox0";
            this.pictureBox0.Size = new System.Drawing.Size(1924, 1050);
            this.pictureBox0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox0.TabIndex = 3;
            this.pictureBox0.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox11.Location = new System.Drawing.Point(1008, 758);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(108, 108);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 4;
            this.pictureBox11.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("HGP創英角ﾎﾟｯﾌﾟ体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Olive;
            this.label1.Location = new System.Drawing.Point(285, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 48);
            this.label1.TabIndex = 6;
            this.label1.Text = "Dealer";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Gold;
            this.label2.Font = new System.Drawing.Font("HGP創英角ﾎﾟｯﾌﾟ体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(285, 346);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 48);
            this.label2.TabIndex = 7;
            this.label2.Text = "福田";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1043, 837);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "BET";
            // 
            // DealerCard1
            // 
            this.DealerCard1.BackColor = System.Drawing.Color.Transparent;
            this.DealerCard1.Location = new System.Drawing.Point(493, 82);
            this.DealerCard1.Name = "DealerCard1";
            this.DealerCard1.Size = new System.Drawing.Size(187, 231);
            this.DealerCard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DealerCard1.TabIndex = 9;
            this.DealerCard1.TabStop = false;
            // 
            // DealerCard2
            // 
            this.DealerCard2.BackColor = System.Drawing.Color.Transparent;
            this.DealerCard2.Location = new System.Drawing.Point(702, 82);
            this.DealerCard2.Name = "DealerCard2";
            this.DealerCard2.Size = new System.Drawing.Size(187, 231);
            this.DealerCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DealerCard2.TabIndex = 10;
            this.DealerCard2.TabStop = false;
            // 
            // DealerCard3
            // 
            this.DealerCard3.BackColor = System.Drawing.Color.Transparent;
            this.DealerCard3.Location = new System.Drawing.Point(910, 82);
            this.DealerCard3.Name = "DealerCard3";
            this.DealerCard3.Size = new System.Drawing.Size(187, 231);
            this.DealerCard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DealerCard3.TabIndex = 11;
            this.DealerCard3.TabStop = false;
            // 
            // DealerCard4
            // 
            this.DealerCard4.BackColor = System.Drawing.Color.Transparent;
            this.DealerCard4.Location = new System.Drawing.Point(1118, 82);
            this.DealerCard4.Name = "DealerCard4";
            this.DealerCard4.Size = new System.Drawing.Size(187, 231);
            this.DealerCard4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DealerCard4.TabIndex = 12;
            this.DealerCard4.TabStop = false;
            // 
            // DealerCard5
            // 
            this.DealerCard5.BackColor = System.Drawing.Color.Transparent;
            this.DealerCard5.Location = new System.Drawing.Point(1327, 82);
            this.DealerCard5.Name = "DealerCard5";
            this.DealerCard5.Size = new System.Drawing.Size(187, 231);
            this.DealerCard5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DealerCard5.TabIndex = 13;
            this.DealerCard5.TabStop = false;
            // 
            // PlayerCard5
            // 
            this.PlayerCard5.BackColor = System.Drawing.Color.Transparent;
            this.PlayerCard5.Location = new System.Drawing.Point(1327, 346);
            this.PlayerCard5.Name = "PlayerCard5";
            this.PlayerCard5.Size = new System.Drawing.Size(187, 231);
            this.PlayerCard5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlayerCard5.TabIndex = 18;
            this.PlayerCard5.TabStop = false;
            // 
            // PlayerCard4
            // 
            this.PlayerCard4.BackColor = System.Drawing.Color.Transparent;
            this.PlayerCard4.Location = new System.Drawing.Point(1118, 346);
            this.PlayerCard4.Name = "PlayerCard4";
            this.PlayerCard4.Size = new System.Drawing.Size(187, 231);
            this.PlayerCard4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlayerCard4.TabIndex = 17;
            this.PlayerCard4.TabStop = false;
            // 
            // PlayerCard3
            // 
            this.PlayerCard3.BackColor = System.Drawing.Color.Transparent;
            this.PlayerCard3.Location = new System.Drawing.Point(910, 346);
            this.PlayerCard3.Name = "PlayerCard3";
            this.PlayerCard3.Size = new System.Drawing.Size(187, 231);
            this.PlayerCard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlayerCard3.TabIndex = 16;
            this.PlayerCard3.TabStop = false;
            // 
            // PlayerCard2
            // 
            this.PlayerCard2.BackColor = System.Drawing.Color.Transparent;
            this.PlayerCard2.Location = new System.Drawing.Point(702, 346);
            this.PlayerCard2.Name = "PlayerCard2";
            this.PlayerCard2.Size = new System.Drawing.Size(187, 231);
            this.PlayerCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlayerCard2.TabIndex = 15;
            this.PlayerCard2.TabStop = false;
            // 
            // PlayerCard1
            // 
            this.PlayerCard1.BackColor = System.Drawing.Color.Transparent;
            this.PlayerCard1.Location = new System.Drawing.Point(493, 346);
            this.PlayerCard1.Name = "PlayerCard1";
            this.PlayerCard1.Size = new System.Drawing.Size(187, 231);
            this.PlayerCard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlayerCard1.TabIndex = 14;
            this.PlayerCard1.TabStop = false;
            // 
            // CardDraw
            // 
            this.CardDraw.AutoSize = true;
            this.CardDraw.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CardDraw.Location = new System.Drawing.Point(586, 648);
            this.CardDraw.Name = "CardDraw";
            this.CardDraw.Size = new System.Drawing.Size(102, 30);
            this.CardDraw.TabIndex = 19;
            this.CardDraw.Text = "カードを引く";
            this.CardDraw.UseVisualStyleBackColor = true;
            this.CardDraw.Click += new System.EventHandler(this.CardDraw_Click);
            // 
            // CardJudge
            // 
            this.CardJudge.AutoSize = true;
            this.CardJudge.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CardJudge.Location = new System.Drawing.Point(719, 648);
            this.CardJudge.Name = "CardJudge";
            this.CardJudge.Size = new System.Drawing.Size(75, 28);
            this.CardJudge.TabIndex = 20;
            this.CardJudge.Text = "勝負";
            this.CardJudge.UseVisualStyleBackColor = true;
            this.CardJudge.Click += new System.EventHandler(this.JudgeClicked);
            // 
            // PlayerPoint
            // 
            this.PlayerPoint.BackColor = System.Drawing.Color.Transparent;
            this.PlayerPoint.Font = new System.Drawing.Font("Palatino Linotype", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerPoint.ForeColor = System.Drawing.Color.Red;
            this.PlayerPoint.Location = new System.Drawing.Point(222, 394);
            this.PlayerPoint.Name = "PlayerPoint";
            this.PlayerPoint.Size = new System.Drawing.Size(265, 192);
            this.PlayerPoint.TabIndex = 21;
            this.PlayerPoint.Text = "0";
            this.PlayerPoint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DealerPoint
            // 
            this.DealerPoint.BackColor = System.Drawing.Color.Transparent;
            this.DealerPoint.Font = new System.Drawing.Font("Palatino Linotype", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DealerPoint.ForeColor = System.Drawing.Color.Red;
            this.DealerPoint.Location = new System.Drawing.Point(232, 121);
            this.DealerPoint.Name = "DealerPoint";
            this.DealerPoint.Size = new System.Drawing.Size(265, 192);
            this.DealerPoint.TabIndex = 22;
            this.DealerPoint.Text = "0";
            this.DealerPoint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.DealerPoint);
            this.Controls.Add(this.PlayerCard1);
            this.Controls.Add(this.PlayerPoint);
            this.Controls.Add(this.CardJudge);
            this.Controls.Add(this.CardDraw);
            this.Controls.Add(this.PlayerCard5);
            this.Controls.Add(this.PlayerCard4);
            this.Controls.Add(this.PlayerCard3);
            this.Controls.Add(this.PlayerCard2);
            this.Controls.Add(this.DealerCard5);
            this.Controls.Add(this.DealerCard4);
            this.Controls.Add(this.DealerCard3);
            this.Controls.Add(this.DealerCard2);
            this.Controls.Add(this.DealerCard1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox0);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "BlackJack";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DealerCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DealerCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DealerCard3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DealerCard4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DealerCard5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerCard5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerCard4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerCard3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerCard1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox0;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox DealerCard1;
        private System.Windows.Forms.PictureBox DealerCard2;
        private System.Windows.Forms.PictureBox DealerCard3;
        private System.Windows.Forms.PictureBox DealerCard4;
        private System.Windows.Forms.PictureBox DealerCard5;
        private System.Windows.Forms.PictureBox PlayerCard5;
        private System.Windows.Forms.PictureBox PlayerCard4;
        private System.Windows.Forms.PictureBox PlayerCard3;
        private System.Windows.Forms.PictureBox PlayerCard2;
        private System.Windows.Forms.ToolStripMenuItem CardRelease;
        private System.Windows.Forms.PictureBox PlayerCard1;
        private System.Windows.Forms.Button CardJudge;
        public System.Windows.Forms.Button CardDraw;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Label PlayerPoint;
        public System.Windows.Forms.Label DealerPoint;
    }
}

