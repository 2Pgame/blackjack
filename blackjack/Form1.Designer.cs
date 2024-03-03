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
            this.BetButton = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.Initialization = new System.Windows.Forms.Button();
            this.CrownPictureE = new System.Windows.Forms.PictureBox();
            this.CrownPictureP = new System.Windows.Forms.PictureBox();
            this.WinOrLoseP = new System.Windows.Forms.Label();
            this.WinOrLoseE = new System.Windows.Forms.Label();
            this.rest = new System.Windows.Forms.Label();
            this.coinlabel = new System.Windows.Forms.Label();
            this.BetButton1 = new System.Windows.Forms.Button();
            this.PlayerCard6 = new System.Windows.Forms.PictureBox();
            this.DealerCard6 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BetButton)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.CrownPictureE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CrownPictureP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerCard6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DealerCard6)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(1898, 33);
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
            this.CardRelease.Enabled = false;
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
            this.pictureBox0.Size = new System.Drawing.Size(1898, 1024);
            this.pictureBox0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox0.TabIndex = 3;
            this.pictureBox0.TabStop = false;
            // 
            // BetButton
            // 
            this.BetButton.BackColor = System.Drawing.Color.Transparent;
            this.BetButton.Enabled = false;
            this.BetButton.Location = new System.Drawing.Point(657, 535);
            this.BetButton.Name = "BetButton";
            this.BetButton.Size = new System.Drawing.Size(83, 91);
            this.BetButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BetButton.TabIndex = 4;
            this.BetButton.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("HGP創英角ﾎﾟｯﾌﾟ体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Olive;
            this.label1.Location = new System.Drawing.Point(285, 54);
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
            this.label2.Location = new System.Drawing.Point(285, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 48);
            this.label2.TabIndex = 7;
            this.label2.Text = "福田";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DealerCard1
            // 
            this.DealerCard1.BackColor = System.Drawing.Color.Transparent;
            this.DealerCard1.Location = new System.Drawing.Point(493, 52);
            this.DealerCard1.Name = "DealerCard1";
            this.DealerCard1.Size = new System.Drawing.Size(144, 204);
            this.DealerCard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DealerCard1.TabIndex = 9;
            this.DealerCard1.TabStop = false;
            // 
            // DealerCard2
            // 
            this.DealerCard2.BackColor = System.Drawing.Color.Transparent;
            this.DealerCard2.Location = new System.Drawing.Point(648, 52);
            this.DealerCard2.Name = "DealerCard2";
            this.DealerCard2.Size = new System.Drawing.Size(144, 204);
            this.DealerCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DealerCard2.TabIndex = 10;
            this.DealerCard2.TabStop = false;
            // 
            // DealerCard3
            // 
            this.DealerCard3.BackColor = System.Drawing.Color.Transparent;
            this.DealerCard3.Location = new System.Drawing.Point(803, 52);
            this.DealerCard3.Name = "DealerCard3";
            this.DealerCard3.Size = new System.Drawing.Size(144, 204);
            this.DealerCard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DealerCard3.TabIndex = 11;
            this.DealerCard3.TabStop = false;
            // 
            // DealerCard4
            // 
            this.DealerCard4.BackColor = System.Drawing.Color.Transparent;
            this.DealerCard4.Location = new System.Drawing.Point(958, 52);
            this.DealerCard4.Name = "DealerCard4";
            this.DealerCard4.Size = new System.Drawing.Size(144, 204);
            this.DealerCard4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DealerCard4.TabIndex = 12;
            this.DealerCard4.TabStop = false;
            // 
            // DealerCard5
            // 
            this.DealerCard5.BackColor = System.Drawing.Color.Transparent;
            this.DealerCard5.Location = new System.Drawing.Point(1113, 52);
            this.DealerCard5.Name = "DealerCard5";
            this.DealerCard5.Size = new System.Drawing.Size(144, 204);
            this.DealerCard5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DealerCard5.TabIndex = 13;
            this.DealerCard5.TabStop = false;
            // 
            // PlayerCard5
            // 
            this.PlayerCard5.BackColor = System.Drawing.Color.Transparent;
            this.PlayerCard5.Location = new System.Drawing.Point(1113, 316);
            this.PlayerCard5.Name = "PlayerCard5";
            this.PlayerCard5.Size = new System.Drawing.Size(144, 204);
            this.PlayerCard5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlayerCard5.TabIndex = 18;
            this.PlayerCard5.TabStop = false;
            // 
            // PlayerCard4
            // 
            this.PlayerCard4.BackColor = System.Drawing.Color.Transparent;
            this.PlayerCard4.Location = new System.Drawing.Point(958, 316);
            this.PlayerCard4.Name = "PlayerCard4";
            this.PlayerCard4.Size = new System.Drawing.Size(144, 204);
            this.PlayerCard4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlayerCard4.TabIndex = 17;
            this.PlayerCard4.TabStop = false;
            // 
            // PlayerCard3
            // 
            this.PlayerCard3.BackColor = System.Drawing.Color.Transparent;
            this.PlayerCard3.Location = new System.Drawing.Point(803, 316);
            this.PlayerCard3.Name = "PlayerCard3";
            this.PlayerCard3.Size = new System.Drawing.Size(144, 204);
            this.PlayerCard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlayerCard3.TabIndex = 16;
            this.PlayerCard3.TabStop = false;
            // 
            // PlayerCard2
            // 
            this.PlayerCard2.BackColor = System.Drawing.Color.Transparent;
            this.PlayerCard2.Location = new System.Drawing.Point(648, 316);
            this.PlayerCard2.Name = "PlayerCard2";
            this.PlayerCard2.Size = new System.Drawing.Size(144, 204);
            this.PlayerCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlayerCard2.TabIndex = 15;
            this.PlayerCard2.TabStop = false;
            // 
            // PlayerCard1
            // 
            this.PlayerCard1.BackColor = System.Drawing.Color.Transparent;
            this.PlayerCard1.Location = new System.Drawing.Point(493, 316);
            this.PlayerCard1.Name = "PlayerCard1";
            this.PlayerCard1.Size = new System.Drawing.Size(144, 204);
            this.PlayerCard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlayerCard1.TabIndex = 14;
            this.PlayerCard1.TabStop = false;
            // 
            // CardDraw
            // 
            this.CardDraw.AutoSize = true;
            this.CardDraw.Enabled = false;
            this.CardDraw.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CardDraw.Location = new System.Drawing.Point(784, 568);
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
            this.CardJudge.Enabled = false;
            this.CardJudge.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CardJudge.Location = new System.Drawing.Point(917, 568);
            this.CardJudge.Name = "CardJudge";
            this.CardJudge.Size = new System.Drawing.Size(75, 28);
            this.CardJudge.TabIndex = 20;
            this.CardJudge.Text = "勝負";
            this.CardJudge.UseVisualStyleBackColor = true;
            this.CardJudge.Click += new System.EventHandler(this.JudgeClicked);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Ticked);
            // 
            // PlayerPoint
            // 
            this.PlayerPoint.BackColor = System.Drawing.Color.Transparent;
            this.PlayerPoint.Font = new System.Drawing.Font("Palatino Linotype", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerPoint.ForeColor = System.Drawing.Color.Red;
            this.PlayerPoint.Location = new System.Drawing.Point(240, 364);
            this.PlayerPoint.Name = "PlayerPoint";
            this.PlayerPoint.Size = new System.Drawing.Size(229, 192);
            this.PlayerPoint.TabIndex = 21;
            this.PlayerPoint.Text = "0";
            this.PlayerPoint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DealerPoint
            // 
            this.DealerPoint.BackColor = System.Drawing.Color.Transparent;
            this.DealerPoint.Font = new System.Drawing.Font("Palatino Linotype", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DealerPoint.ForeColor = System.Drawing.Color.Red;
            this.DealerPoint.Location = new System.Drawing.Point(258, 91);
            this.DealerPoint.Name = "DealerPoint";
            this.DealerPoint.Size = new System.Drawing.Size(229, 192);
            this.DealerPoint.TabIndex = 22;
            this.DealerPoint.Text = "0";
            this.DealerPoint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Initialization
            // 
            this.Initialization.AutoSize = true;
            this.Initialization.Enabled = false;
            this.Initialization.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Initialization.Location = new System.Drawing.Point(1018, 568);
            this.Initialization.Name = "Initialization";
            this.Initialization.Size = new System.Drawing.Size(75, 28);
            this.Initialization.TabIndex = 23;
            this.Initialization.Text = "初期化";
            this.Initialization.UseVisualStyleBackColor = true;
            this.Initialization.Click += new System.EventHandler(this.Initialization_Clicked);
            // 
            // CrownPictureE
            // 
            this.CrownPictureE.BackColor = System.Drawing.Color.Transparent;
            this.CrownPictureE.Location = new System.Drawing.Point(14, 123);
            this.CrownPictureE.Name = "CrownPictureE";
            this.CrownPictureE.Size = new System.Drawing.Size(100, 80);
            this.CrownPictureE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CrownPictureE.TabIndex = 24;
            this.CrownPictureE.TabStop = false;
            // 
            // CrownPictureP
            // 
            this.CrownPictureP.BackColor = System.Drawing.Color.Transparent;
            this.CrownPictureP.Location = new System.Drawing.Point(14, 380);
            this.CrownPictureP.Name = "CrownPictureP";
            this.CrownPictureP.Size = new System.Drawing.Size(100, 80);
            this.CrownPictureP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CrownPictureP.TabIndex = 25;
            this.CrownPictureP.TabStop = false;
            // 
            // WinOrLoseP
            // 
            this.WinOrLoseP.BackColor = System.Drawing.Color.Transparent;
            this.WinOrLoseP.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WinOrLoseP.ForeColor = System.Drawing.Color.Red;
            this.WinOrLoseP.Location = new System.Drawing.Point(100, 390);
            this.WinOrLoseP.Name = "WinOrLoseP";
            this.WinOrLoseP.Size = new System.Drawing.Size(173, 61);
            this.WinOrLoseP.TabIndex = 26;
            this.WinOrLoseP.Text = "勝ち";
            this.WinOrLoseP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WinOrLoseE
            // 
            this.WinOrLoseE.BackColor = System.Drawing.Color.Transparent;
            this.WinOrLoseE.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WinOrLoseE.ForeColor = System.Drawing.Color.Red;
            this.WinOrLoseE.Location = new System.Drawing.Point(100, 123);
            this.WinOrLoseE.Name = "WinOrLoseE";
            this.WinOrLoseE.Size = new System.Drawing.Size(173, 61);
            this.WinOrLoseE.TabIndex = 27;
            this.WinOrLoseE.Text = "勝ち";
            this.WinOrLoseE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rest
            // 
            this.rest.AutoSize = true;
            this.rest.BackColor = System.Drawing.Color.Transparent;
            this.rest.Location = new System.Drawing.Point(547, 574);
            this.rest.Name = "rest";
            this.rest.Size = new System.Drawing.Size(37, 18);
            this.rest.TabIndex = 28;
            this.rest.Text = "残り";
            // 
            // coinlabel
            // 
            this.coinlabel.AutoSize = true;
            this.coinlabel.BackColor = System.Drawing.Color.Transparent;
            this.coinlabel.Location = new System.Drawing.Point(590, 574);
            this.coinlabel.Name = "coinlabel";
            this.coinlabel.Size = new System.Drawing.Size(26, 18);
            this.coinlabel.TabIndex = 29;
            this.coinlabel.Text = "10";
            this.coinlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BetButton1
            // 
            this.BetButton1.AutoSize = true;
            this.BetButton1.Location = new System.Drawing.Point(657, 568);
            this.BetButton1.Name = "BetButton1";
            this.BetButton1.Size = new System.Drawing.Size(83, 28);
            this.BetButton1.TabIndex = 30;
            this.BetButton1.Text = "BET";
            this.BetButton1.UseVisualStyleBackColor = true;
            this.BetButton1.Visible = false;
            this.BetButton1.Click += new System.EventHandler(this.BetButton1Clicked);
            // 
            // PlayerCard6
            // 
            this.PlayerCard6.BackColor = System.Drawing.Color.Transparent;
            this.PlayerCard6.Location = new System.Drawing.Point(1268, 316);
            this.PlayerCard6.Name = "PlayerCard6";
            this.PlayerCard6.Size = new System.Drawing.Size(144, 204);
            this.PlayerCard6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlayerCard6.TabIndex = 32;
            this.PlayerCard6.TabStop = false;
            // 
            // DealerCard6
            // 
            this.DealerCard6.BackColor = System.Drawing.Color.Transparent;
            this.DealerCard6.Location = new System.Drawing.Point(1268, 52);
            this.DealerCard6.Name = "DealerCard6";
            this.DealerCard6.Size = new System.Drawing.Size(144, 204);
            this.DealerCard6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DealerCard6.TabIndex = 31;
            this.DealerCard6.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.PlayerCard6);
            this.Controls.Add(this.DealerCard6);
            this.Controls.Add(this.BetButton1);
            this.Controls.Add(this.coinlabel);
            this.Controls.Add(this.rest);
            this.Controls.Add(this.WinOrLoseE);
            this.Controls.Add(this.WinOrLoseP);
            this.Controls.Add(this.CrownPictureP);
            this.Controls.Add(this.CrownPictureE);
            this.Controls.Add(this.Initialization);
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
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BetButton);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox0);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "BlackJack";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BetButton)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.CrownPictureE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CrownPictureP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerCard6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DealerCard6)).EndInit();
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
        private System.Windows.Forms.PictureBox BetButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
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
        private System.Windows.Forms.Button Initialization;
        public System.Windows.Forms.Label WinOrLoseP;
        public System.Windows.Forms.Label WinOrLoseE;
        public System.Windows.Forms.PictureBox CrownPictureE;
        public System.Windows.Forms.PictureBox CrownPictureP;
        private System.Windows.Forms.Label rest;
        public System.Windows.Forms.Label coinlabel;
        private System.Windows.Forms.Button BetButton1;
        private System.Windows.Forms.PictureBox PlayerCard6;
        private System.Windows.Forms.PictureBox DealerCard6;
    }
}

