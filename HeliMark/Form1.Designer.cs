﻿
namespace HeliMark
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tabPageメイン = new System.Windows.Forms.TabPage();
      this.btnGitHubを開く = new System.Windows.Forms.Button();
      this.txtDatatxt再度読込 = new System.Windows.Forms.Button();
      this.chk地図に地区時刻表示 = new System.Windows.Forms.CheckBox();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.chk表示地番 = new System.Windows.Forms.CheckBox();
      this.chk地番 = new System.Windows.Forms.CheckBox();
      this.chk字 = new System.Windows.Forms.CheckBox();
      this.chk大字 = new System.Windows.Forms.CheckBox();
      this.chkid下4桁 = new System.Windows.Forms.CheckBox();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.chk地番データなし = new System.Windows.Forms.CheckBox();
      this.chk申込なし = new System.Windows.Forms.CheckBox();
      this.chk2回 = new System.Windows.Forms.CheckBox();
      this.chkつや姫 = new System.Windows.Forms.CheckBox();
      this.chk3回 = new System.Windows.Forms.CheckBox();
      this.label9 = new System.Windows.Forms.Label();
      this.btn地図画像を作る = new System.Windows.Forms.Button();
      this.dataGridViewMapSetting = new System.Windows.Forms.DataGridView();
      this.地区 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.img = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.横サイズ = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.縦サイズ = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.左基準 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.左経度 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.上基準 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.上緯度 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.右基準 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.右経度 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.下基準 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.下緯度 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.listBox地区一覧 = new System.Windows.Forms.ListBox();
      this.tabPage地図画像 = new System.Windows.Forms.TabPage();
      this.lblタブヒント = new System.Windows.Forms.Label();
      this.panelPic = new System.Windows.Forms.Panel();
      this.picImg = new System.Windows.Forms.PictureBox();
      this.tabPage印刷 = new System.Windows.Forms.TabPage();
      this.groupBox3 = new System.Windows.Forms.GroupBox();
      this.lbl余白 = new System.Windows.Forms.Label();
      this.lbl印刷方向 = new System.Windows.Forms.Label();
      this.lbl給紙方法 = new System.Windows.Forms.Label();
      this.lblサイズ = new System.Windows.Forms.Label();
      this.btn印刷設定 = new System.Windows.Forms.Button();
      this.btn印刷する = new System.Windows.Forms.Button();
      this.printPreviewControl1 = new System.Windows.Forms.PrintPreviewControl();
      this.tabPage表示データ = new System.Windows.Forms.TabPage();
      this.label2 = new System.Windows.Forms.Label();
      this.dataGridView表示データ = new System.Windows.Forms.DataGridView();
      this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.tabPage全データ = new System.Windows.Forms.TabPage();
      this.label8 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.dataGridView全データ = new System.Windows.Forms.DataGridView();
      this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.lat = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.lng = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.width = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.height = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.arcdegree = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.gislandad = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ckind = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.enable = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.disp = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.tabPageExcelから取得 = new System.Windows.Forms.TabPage();
      this.btn入力クリア = new System.Windows.Forms.Button();
      this.chkつや姫エサ米を無効 = new System.Windows.Forms.CheckBox();
      this.chk置換処理を行う = new System.Windows.Forms.CheckBox();
      this.chk取得処理で全て処理する = new System.Windows.Forms.CheckBox();
      this.btn申込を保存する = new System.Windows.Forms.Button();
      this.btn申込全てクリア = new System.Windows.Forms.Button();
      this.btn取得処理を行う = new System.Windows.Forms.Button();
      this.txtExcel地名地番 = new System.Windows.Forms.TextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.lbl取得処理結果 = new System.Windows.Forms.Label();
      this.label11 = new System.Windows.Forms.Label();
      this.lbl合筆 = new System.Windows.Forms.Label();
      this.lblマークなし = new System.Windows.Forms.Label();
      this.lbl地名地番重複 = new System.Windows.Forms.Label();
      this.lbl地名地番不明 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.txt合筆元データなし = new System.Windows.Forms.TextBox();
      this.txt合筆 = new System.Windows.Forms.TextBox();
      this.txtマークなし = new System.Windows.Forms.TextBox();
      this.txt地名地番重複 = new System.Windows.Forms.TextBox();
      this.txt地名地番不明 = new System.Windows.Forms.TextBox();
      this.txtExcelつや姫エサ米2回 = new System.Windows.Forms.TextBox();
      this.tabPageメモ = new System.Windows.Forms.TabPage();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.lblデータフィルタ = new System.Windows.Forms.Label();
      this.label10 = new System.Windows.Forms.Label();
      this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
      this.printDialog1 = new System.Windows.Forms.PrintDialog();
      this.chk1ha毎に線を引く = new System.Windows.Forms.CheckBox();
      this.tabControl1.SuspendLayout();
      this.tabPageメイン.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMapSetting)).BeginInit();
      this.tabPage地図画像.SuspendLayout();
      this.panelPic.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.picImg)).BeginInit();
      this.tabPage印刷.SuspendLayout();
      this.groupBox3.SuspendLayout();
      this.tabPage表示データ.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView表示データ)).BeginInit();
      this.tabPage全データ.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView全データ)).BeginInit();
      this.tabPageExcelから取得.SuspendLayout();
      this.tabPageメモ.SuspendLayout();
      this.SuspendLayout();
      // 
      // tabControl1
      // 
      this.tabControl1.Controls.Add(this.tabPageメイン);
      this.tabControl1.Controls.Add(this.tabPage地図画像);
      this.tabControl1.Controls.Add(this.tabPage印刷);
      this.tabControl1.Controls.Add(this.tabPage表示データ);
      this.tabControl1.Controls.Add(this.tabPage全データ);
      this.tabControl1.Controls.Add(this.tabPageExcelから取得);
      this.tabControl1.Controls.Add(this.tabPageメモ);
      this.tabControl1.Location = new System.Drawing.Point(12, 12);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(776, 469);
      this.tabControl1.TabIndex = 0;
      // 
      // tabPageメイン
      // 
      this.tabPageメイン.Controls.Add(this.chk1ha毎に線を引く);
      this.tabPageメイン.Controls.Add(this.btnGitHubを開く);
      this.tabPageメイン.Controls.Add(this.txtDatatxt再度読込);
      this.tabPageメイン.Controls.Add(this.chk地図に地区時刻表示);
      this.tabPageメイン.Controls.Add(this.groupBox2);
      this.tabPageメイン.Controls.Add(this.groupBox1);
      this.tabPageメイン.Controls.Add(this.label9);
      this.tabPageメイン.Controls.Add(this.btn地図画像を作る);
      this.tabPageメイン.Controls.Add(this.dataGridViewMapSetting);
      this.tabPageメイン.Controls.Add(this.listBox地区一覧);
      this.tabPageメイン.Location = new System.Drawing.Point(4, 22);
      this.tabPageメイン.Name = "tabPageメイン";
      this.tabPageメイン.Padding = new System.Windows.Forms.Padding(3);
      this.tabPageメイン.Size = new System.Drawing.Size(768, 443);
      this.tabPageメイン.TabIndex = 0;
      this.tabPageメイン.Text = "メイン";
      this.tabPageメイン.UseVisualStyleBackColor = true;
      // 
      // btnGitHubを開く
      // 
      this.btnGitHubを開く.Location = new System.Drawing.Point(222, 180);
      this.btnGitHubを開く.Name = "btnGitHubを開く";
      this.btnGitHubを開く.Size = new System.Drawing.Size(100, 33);
      this.btnGitHubを開く.TabIndex = 10;
      this.btnGitHubを開く.Text = "GitHubを開く";
      this.btnGitHubを開く.UseVisualStyleBackColor = true;
      this.btnGitHubを開く.Click += new System.EventHandler(this.btnGitHubを開く_Click);
      // 
      // txtDatatxt再度読込
      // 
      this.txtDatatxt再度読込.Location = new System.Drawing.Point(222, 121);
      this.txtDatatxt再度読込.Name = "txtDatatxt再度読込";
      this.txtDatatxt再度読込.Size = new System.Drawing.Size(100, 32);
      this.txtDatatxt再度読込.TabIndex = 9;
      this.txtDatatxt再度読込.Text = "data.txt再度読込";
      this.txtDatatxt再度読込.UseVisualStyleBackColor = true;
      this.txtDatatxt再度読込.Click += new System.EventHandler(this.txtDatatxt再度読込_Click);
      // 
      // chk地図に地区時刻表示
      // 
      this.chk地図に地区時刻表示.AutoSize = true;
      this.chk地図に地区時刻表示.Checked = true;
      this.chk地図に地区時刻表示.CheckState = System.Windows.Forms.CheckState.Checked;
      this.chk地図に地区時刻表示.Location = new System.Drawing.Point(518, 153);
      this.chk地図に地区時刻表示.Name = "chk地図に地区時刻表示";
      this.chk地図に地区時刻表示.Size = new System.Drawing.Size(135, 16);
      this.chk地図に地区時刻表示.TabIndex = 8;
      this.chk地図に地区時刻表示.Text = "地図に地区・時刻表示";
      this.chk地図に地区時刻表示.UseVisualStyleBackColor = true;
      this.chk地図に地区時刻表示.CheckedChanged += new System.EventHandler(this.chk地図に地区時刻表示_CheckedChanged);
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.chk表示地番);
      this.groupBox2.Controls.Add(this.chk地番);
      this.groupBox2.Controls.Add(this.chk字);
      this.groupBox2.Controls.Add(this.chk大字);
      this.groupBox2.Controls.Add(this.chkid下4桁);
      this.groupBox2.Location = new System.Drawing.Point(520, 37);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(175, 110);
      this.groupBox2.TabIndex = 7;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "表示テキスト";
      // 
      // chk表示地番
      // 
      this.chk表示地番.AutoSize = true;
      this.chk表示地番.Checked = true;
      this.chk表示地番.CheckState = System.Windows.Forms.CheckState.Checked;
      this.chk表示地番.Location = new System.Drawing.Point(6, 62);
      this.chk表示地番.Name = "chk表示地番";
      this.chk表示地番.Size = new System.Drawing.Size(72, 16);
      this.chk表示地番.TabIndex = 0;
      this.chk表示地番.Text = "表示地番";
      this.chk表示地番.UseVisualStyleBackColor = true;
      this.chk表示地番.CheckedChanged += new System.EventHandler(this.chk表示テキスト);
      // 
      // chk地番
      // 
      this.chk地番.AutoSize = true;
      this.chk地番.Location = new System.Drawing.Point(102, 40);
      this.chk地番.Name = "chk地番";
      this.chk地番.Size = new System.Drawing.Size(48, 16);
      this.chk地番.TabIndex = 0;
      this.chk地番.Text = "地番";
      this.chk地番.UseVisualStyleBackColor = true;
      this.chk地番.CheckedChanged += new System.EventHandler(this.chk表示テキスト);
      // 
      // chk字
      // 
      this.chk字.AutoSize = true;
      this.chk字.Location = new System.Drawing.Point(60, 40);
      this.chk字.Name = "chk字";
      this.chk字.Size = new System.Drawing.Size(36, 16);
      this.chk字.TabIndex = 0;
      this.chk字.Text = "字";
      this.chk字.UseVisualStyleBackColor = true;
      this.chk字.CheckedChanged += new System.EventHandler(this.chk表示テキスト);
      // 
      // chk大字
      // 
      this.chk大字.AutoSize = true;
      this.chk大字.Location = new System.Drawing.Point(6, 40);
      this.chk大字.Name = "chk大字";
      this.chk大字.Size = new System.Drawing.Size(48, 16);
      this.chk大字.TabIndex = 0;
      this.chk大字.Text = "大字";
      this.chk大字.UseVisualStyleBackColor = true;
      this.chk大字.CheckedChanged += new System.EventHandler(this.chk表示テキスト);
      // 
      // chkid下4桁
      // 
      this.chkid下4桁.AutoSize = true;
      this.chkid下4桁.Location = new System.Drawing.Point(6, 18);
      this.chkid下4桁.Name = "chkid下4桁";
      this.chkid下4桁.Size = new System.Drawing.Size(63, 16);
      this.chkid下4桁.TabIndex = 0;
      this.chkid下4桁.Text = "id下4桁";
      this.chkid下4桁.UseVisualStyleBackColor = true;
      this.chkid下4桁.CheckedChanged += new System.EventHandler(this.chk表示テキスト);
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.chk地番データなし);
      this.groupBox1.Controls.Add(this.chk申込なし);
      this.groupBox1.Controls.Add(this.chk2回);
      this.groupBox1.Controls.Add(this.chkつや姫);
      this.groupBox1.Controls.Add(this.chk3回);
      this.groupBox1.Location = new System.Drawing.Point(362, 37);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(138, 135);
      this.groupBox1.TabIndex = 6;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "塗りつぶしマーク";
      // 
      // chk地番データなし
      // 
      this.chk地番データなし.AutoSize = true;
      this.chk地番データなし.Location = new System.Drawing.Point(6, 106);
      this.chk地番データなし.Name = "chk地番データなし";
      this.chk地番データなし.Size = new System.Drawing.Size(123, 16);
      this.chk地番データなし.TabIndex = 0;
      this.chk地番データなし.Text = "地番データなし 白色";
      this.chk地番データなし.UseVisualStyleBackColor = true;
      this.chk地番データなし.CheckedChanged += new System.EventHandler(this.chk塗りつぶしマーク);
      // 
      // chk申込なし
      // 
      this.chk申込なし.AutoSize = true;
      this.chk申込なし.Location = new System.Drawing.Point(6, 84);
      this.chk申込なし.Name = "chk申込なし";
      this.chk申込なし.Size = new System.Drawing.Size(95, 16);
      this.chk申込なし.TabIndex = 0;
      this.chk申込なし.Text = "申込なし 緑色";
      this.chk申込なし.UseVisualStyleBackColor = true;
      this.chk申込なし.CheckedChanged += new System.EventHandler(this.chk塗りつぶしマーク);
      // 
      // chk2回
      // 
      this.chk2回.AutoSize = true;
      this.chk2回.Checked = true;
      this.chk2回.CheckState = System.Windows.Forms.CheckState.Checked;
      this.chk2回.Location = new System.Drawing.Point(6, 62);
      this.chk2回.Name = "chk2回";
      this.chk2回.Size = new System.Drawing.Size(101, 16);
      this.chk2回.TabIndex = 0;
      this.chk2回.Text = "エサ米2回 黄色";
      this.chk2回.UseVisualStyleBackColor = true;
      this.chk2回.CheckedChanged += new System.EventHandler(this.chk塗りつぶしマーク);
      // 
      // chkつや姫
      // 
      this.chkつや姫.AutoSize = true;
      this.chkつや姫.Checked = true;
      this.chkつや姫.CheckState = System.Windows.Forms.CheckState.Checked;
      this.chkつや姫.Location = new System.Drawing.Point(6, 40);
      this.chkつや姫.Name = "chkつや姫";
      this.chkつや姫.Size = new System.Drawing.Size(83, 16);
      this.chkつや姫.TabIndex = 0;
      this.chkつや姫.Text = "つや姫 青色";
      this.chkつや姫.UseVisualStyleBackColor = true;
      this.chkつや姫.CheckedChanged += new System.EventHandler(this.chk塗りつぶしマーク);
      // 
      // chk3回
      // 
      this.chk3回.AutoSize = true;
      this.chk3回.Checked = true;
      this.chk3回.CheckState = System.Windows.Forms.CheckState.Checked;
      this.chk3回.Location = new System.Drawing.Point(6, 18);
      this.chk3回.Name = "chk3回";
      this.chk3回.Size = new System.Drawing.Size(70, 16);
      this.chk3回.TabIndex = 0;
      this.chk3回.Text = "3回 赤色";
      this.chk3回.UseVisualStyleBackColor = true;
      this.chk3回.CheckedChanged += new System.EventHandler(this.chk塗りつぶしマーク);
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Location = new System.Drawing.Point(6, 213);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(77, 12);
      this.label9.TabIndex = 5;
      this.label9.Text = "mapsetting.txt";
      // 
      // btn地図画像を作る
      // 
      this.btn地図画像を作る.Location = new System.Drawing.Point(222, 60);
      this.btn地図画像を作る.Name = "btn地図画像を作る";
      this.btn地図画像を作る.Size = new System.Drawing.Size(101, 33);
      this.btn地図画像を作る.TabIndex = 4;
      this.btn地図画像を作る.Text = "地図画像を作る";
      this.btn地図画像を作る.UseVisualStyleBackColor = true;
      this.btn地図画像を作る.Click += new System.EventHandler(this.btn地図画像を作る_Click);
      // 
      // dataGridViewMapSetting
      // 
      this.dataGridViewMapSetting.AllowUserToAddRows = false;
      this.dataGridViewMapSetting.AllowUserToDeleteRows = false;
      this.dataGridViewMapSetting.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridViewMapSetting.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.地区,
            this.img,
            this.横サイズ,
            this.縦サイズ,
            this.左基準,
            this.左経度,
            this.上基準,
            this.上緯度,
            this.右基準,
            this.右経度,
            this.下基準,
            this.下緯度});
      this.dataGridViewMapSetting.Location = new System.Drawing.Point(6, 228);
      this.dataGridViewMapSetting.Name = "dataGridViewMapSetting";
      this.dataGridViewMapSetting.RowTemplate.Height = 21;
      this.dataGridViewMapSetting.Size = new System.Drawing.Size(756, 209);
      this.dataGridViewMapSetting.TabIndex = 3;
      this.dataGridViewMapSetting.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
      // 
      // 地区
      // 
      this.地区.Frozen = true;
      this.地区.HeaderText = "地区";
      this.地区.Name = "地区";
      this.地区.ReadOnly = true;
      this.地区.Width = 60;
      // 
      // img
      // 
      this.img.HeaderText = "画像";
      this.img.Name = "img";
      this.img.Width = 90;
      // 
      // 横サイズ
      // 
      this.横サイズ.HeaderText = "横サイズ";
      this.横サイズ.Name = "横サイズ";
      this.横サイズ.Width = 80;
      // 
      // 縦サイズ
      // 
      this.縦サイズ.HeaderText = "縦サイズ";
      this.縦サイズ.Name = "縦サイズ";
      this.縦サイズ.Width = 80;
      // 
      // 左基準
      // 
      this.左基準.HeaderText = "左基準";
      this.左基準.Name = "左基準";
      this.左基準.Width = 70;
      // 
      // 左経度
      // 
      this.左経度.HeaderText = "左経度";
      this.左経度.Name = "左経度";
      this.左経度.Width = 80;
      // 
      // 上基準
      // 
      this.上基準.HeaderText = "上基準";
      this.上基準.Name = "上基準";
      this.上基準.Width = 70;
      // 
      // 上緯度
      // 
      this.上緯度.HeaderText = "上緯度";
      this.上緯度.Name = "上緯度";
      this.上緯度.Width = 80;
      // 
      // 右基準
      // 
      this.右基準.HeaderText = "右基準";
      this.右基準.Name = "右基準";
      this.右基準.Width = 70;
      // 
      // 右経度
      // 
      this.右経度.HeaderText = "右経度";
      this.右経度.Name = "右経度";
      this.右経度.Width = 80;
      // 
      // 下基準
      // 
      this.下基準.HeaderText = "下基準";
      this.下基準.Name = "下基準";
      this.下基準.Width = 70;
      // 
      // 下緯度
      // 
      this.下緯度.HeaderText = "下緯度";
      this.下緯度.Name = "下緯度";
      this.下緯度.Width = 80;
      // 
      // listBox地区一覧
      // 
      this.listBox地区一覧.FormattingEnabled = true;
      this.listBox地区一覧.ItemHeight = 12;
      this.listBox地区一覧.Items.AddRange(new object[] {
            "東部",
            "藤井",
            "広野",
            "野沢",
            "上吉出",
            "下吉出",
            "西部",
            "町中"});
      this.listBox地区一覧.Location = new System.Drawing.Point(53, 60);
      this.listBox地区一覧.Name = "listBox地区一覧";
      this.listBox地区一覧.Size = new System.Drawing.Size(139, 112);
      this.listBox地区一覧.TabIndex = 0;
      // 
      // tabPage地図画像
      // 
      this.tabPage地図画像.Controls.Add(this.lblタブヒント);
      this.tabPage地図画像.Controls.Add(this.panelPic);
      this.tabPage地図画像.Location = new System.Drawing.Point(4, 22);
      this.tabPage地図画像.Name = "tabPage地図画像";
      this.tabPage地図画像.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage地図画像.Size = new System.Drawing.Size(768, 443);
      this.tabPage地図画像.TabIndex = 1;
      this.tabPage地図画像.Text = "地図画像";
      this.tabPage地図画像.UseVisualStyleBackColor = true;
      // 
      // lblタブヒント
      // 
      this.lblタブヒント.AutoSize = true;
      this.lblタブヒント.Location = new System.Drawing.Point(233, 428);
      this.lblタブヒント.Name = "lblタブヒント";
      this.lblタブヒント.Size = new System.Drawing.Size(535, 12);
      this.lblタブヒント.TabIndex = 2;
      this.lblタブヒント.Text = "左クリック：オートスクロールとズームの切り替え / 中央クリック：オートスクロール時緯度経度コピー / 右クリック：保存";
      // 
      // panelPic
      // 
      this.panelPic.AutoScroll = true;
      this.panelPic.Controls.Add(this.picImg);
      this.panelPic.Location = new System.Drawing.Point(6, 6);
      this.panelPic.Name = "panelPic";
      this.panelPic.Size = new System.Drawing.Size(756, 419);
      this.panelPic.TabIndex = 1;
      // 
      // picImg
      // 
      this.picImg.Location = new System.Drawing.Point(0, 0);
      this.picImg.Name = "picImg";
      this.picImg.Size = new System.Drawing.Size(750, 400);
      this.picImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
      this.picImg.TabIndex = 0;
      this.picImg.TabStop = false;
      this.picImg.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picImg_MouseClick);
      // 
      // tabPage印刷
      // 
      this.tabPage印刷.Controls.Add(this.groupBox3);
      this.tabPage印刷.Controls.Add(this.btn印刷する);
      this.tabPage印刷.Controls.Add(this.printPreviewControl1);
      this.tabPage印刷.Location = new System.Drawing.Point(4, 22);
      this.tabPage印刷.Name = "tabPage印刷";
      this.tabPage印刷.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage印刷.Size = new System.Drawing.Size(768, 443);
      this.tabPage印刷.TabIndex = 6;
      this.tabPage印刷.Text = "印刷";
      this.tabPage印刷.UseVisualStyleBackColor = true;
      // 
      // groupBox3
      // 
      this.groupBox3.Controls.Add(this.lbl余白);
      this.groupBox3.Controls.Add(this.lbl印刷方向);
      this.groupBox3.Controls.Add(this.lbl給紙方法);
      this.groupBox3.Controls.Add(this.lblサイズ);
      this.groupBox3.Controls.Add(this.btn印刷設定);
      this.groupBox3.Location = new System.Drawing.Point(426, 65);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new System.Drawing.Size(272, 118);
      this.groupBox3.TabIndex = 2;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "印刷設定";
      // 
      // lbl余白
      // 
      this.lbl余白.AutoSize = true;
      this.lbl余白.Location = new System.Drawing.Point(17, 95);
      this.lbl余白.Name = "lbl余白";
      this.lbl余白.Size = new System.Drawing.Size(35, 12);
      this.lbl余白.TabIndex = 2;
      this.lbl余白.Text = "余白：";
      // 
      // lbl印刷方向
      // 
      this.lbl印刷方向.AutoSize = true;
      this.lbl印刷方向.Location = new System.Drawing.Point(17, 83);
      this.lbl印刷方向.Name = "lbl印刷方向";
      this.lbl印刷方向.Size = new System.Drawing.Size(59, 12);
      this.lbl印刷方向.TabIndex = 2;
      this.lbl印刷方向.Text = "印刷方向：";
      // 
      // lbl給紙方法
      // 
      this.lbl給紙方法.AutoSize = true;
      this.lbl給紙方法.Location = new System.Drawing.Point(17, 71);
      this.lbl給紙方法.Name = "lbl給紙方法";
      this.lbl給紙方法.Size = new System.Drawing.Size(59, 12);
      this.lbl給紙方法.TabIndex = 2;
      this.lbl給紙方法.Text = "給紙方法：";
      // 
      // lblサイズ
      // 
      this.lblサイズ.AutoSize = true;
      this.lblサイズ.Location = new System.Drawing.Point(17, 59);
      this.lblサイズ.Name = "lblサイズ";
      this.lblサイズ.Size = new System.Drawing.Size(40, 12);
      this.lblサイズ.TabIndex = 2;
      this.lblサイズ.Text = "サイズ：";
      // 
      // btn印刷設定
      // 
      this.btn印刷設定.Location = new System.Drawing.Point(6, 18);
      this.btn印刷設定.Name = "btn印刷設定";
      this.btn印刷設定.Size = new System.Drawing.Size(116, 29);
      this.btn印刷設定.TabIndex = 1;
      this.btn印刷設定.Text = "印刷設定";
      this.btn印刷設定.UseVisualStyleBackColor = true;
      this.btn印刷設定.Click += new System.EventHandler(this.btn印刷設定_Click);
      // 
      // btn印刷する
      // 
      this.btn印刷する.Location = new System.Drawing.Point(491, 208);
      this.btn印刷する.Name = "btn印刷する";
      this.btn印刷する.Size = new System.Drawing.Size(116, 29);
      this.btn印刷する.TabIndex = 1;
      this.btn印刷する.Text = "印刷する";
      this.btn印刷する.UseVisualStyleBackColor = true;
      this.btn印刷する.Click += new System.EventHandler(this.btn印刷する_Click);
      // 
      // printPreviewControl1
      // 
      this.printPreviewControl1.Location = new System.Drawing.Point(3, 6);
      this.printPreviewControl1.Name = "printPreviewControl1";
      this.printPreviewControl1.Size = new System.Drawing.Size(400, 431);
      this.printPreviewControl1.TabIndex = 0;
      // 
      // tabPage表示データ
      // 
      this.tabPage表示データ.Controls.Add(this.label2);
      this.tabPage表示データ.Controls.Add(this.dataGridView表示データ);
      this.tabPage表示データ.Location = new System.Drawing.Point(4, 22);
      this.tabPage表示データ.Name = "tabPage表示データ";
      this.tabPage表示データ.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage表示データ.Size = new System.Drawing.Size(768, 443);
      this.tabPage表示データ.TabIndex = 3;
      this.tabPage表示データ.Text = "表示データ";
      this.tabPage表示データ.UseVisualStyleBackColor = true;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(6, 13);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(137, 12);
      this.label2.TabIndex = 2;
      this.label2.Text = "地図のマークに使用されます";
      // 
      // dataGridView表示データ
      // 
      this.dataGridView表示データ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView表示データ.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
      this.dataGridView表示データ.Location = new System.Drawing.Point(3, 28);
      this.dataGridView表示データ.Name = "dataGridView表示データ";
      this.dataGridView表示データ.RowTemplate.Height = 21;
      this.dataGridView表示データ.Size = new System.Drawing.Size(762, 374);
      this.dataGridView表示データ.TabIndex = 1;
      // 
      // dataGridViewTextBoxColumn1
      // 
      this.dataGridViewTextBoxColumn1.Frozen = true;
      this.dataGridViewTextBoxColumn1.HeaderText = "id";
      this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
      this.dataGridViewTextBoxColumn1.ReadOnly = true;
      this.dataGridViewTextBoxColumn1.Width = 70;
      // 
      // dataGridViewTextBoxColumn2
      // 
      this.dataGridViewTextBoxColumn2.HeaderText = "緯度";
      this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
      this.dataGridViewTextBoxColumn2.ReadOnly = true;
      // 
      // dataGridViewTextBoxColumn3
      // 
      this.dataGridViewTextBoxColumn3.HeaderText = "経度";
      this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
      this.dataGridViewTextBoxColumn3.ReadOnly = true;
      // 
      // dataGridViewTextBoxColumn4
      // 
      this.dataGridViewTextBoxColumn4.HeaderText = "幅";
      this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
      this.dataGridViewTextBoxColumn4.ReadOnly = true;
      this.dataGridViewTextBoxColumn4.Width = 40;
      // 
      // dataGridViewTextBoxColumn5
      // 
      this.dataGridViewTextBoxColumn5.HeaderText = "高さ";
      this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
      this.dataGridViewTextBoxColumn5.ReadOnly = true;
      this.dataGridViewTextBoxColumn5.Width = 40;
      // 
      // dataGridViewTextBoxColumn6
      // 
      this.dataGridViewTextBoxColumn6.HeaderText = "角度";
      this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
      this.dataGridViewTextBoxColumn6.ReadOnly = true;
      this.dataGridViewTextBoxColumn6.Width = 40;
      // 
      // dataGridViewTextBoxColumn7
      // 
      this.dataGridViewTextBoxColumn7.HeaderText = "地名地番";
      this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
      // 
      // dataGridViewTextBoxColumn8
      // 
      this.dataGridViewTextBoxColumn8.HeaderText = "色品種";
      this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
      this.dataGridViewTextBoxColumn8.Width = 70;
      // 
      // dataGridViewTextBoxColumn9
      // 
      this.dataGridViewTextBoxColumn9.HeaderText = "有効";
      this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
      this.dataGridViewTextBoxColumn9.Width = 40;
      // 
      // dataGridViewTextBoxColumn10
      // 
      this.dataGridViewTextBoxColumn10.HeaderText = "表示地番";
      this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
      // 
      // tabPage全データ
      // 
      this.tabPage全データ.Controls.Add(this.label8);
      this.tabPage全データ.Controls.Add(this.label7);
      this.tabPage全データ.Controls.Add(this.label3);
      this.tabPage全データ.Controls.Add(this.label1);
      this.tabPage全データ.Controls.Add(this.dataGridView全データ);
      this.tabPage全データ.Location = new System.Drawing.Point(4, 22);
      this.tabPage全データ.Name = "tabPage全データ";
      this.tabPage全データ.Size = new System.Drawing.Size(768, 443);
      this.tabPage全データ.TabIndex = 2;
      this.tabPage全データ.Text = "全データ";
      this.tabPage全データ.UseVisualStyleBackColor = true;
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(3, 413);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(191, 12);
      this.label8.TabIndex = 2;
      this.label8.Text = "100000～：重複、200000～：マークなし";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(3, 401);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(661, 12);
      this.label7.TabIndex = 2;
      this.label7.Text = "10000～：東部、20000～：藤井、30000～：広野、40000～：野沢、50000～：上吉出、60000～：下吉出、70000～：西部、80000～：町中" +
    "";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(3, 9);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(219, 12);
      this.label3.TabIndex = 1;
      this.label3.Text = "全て地区と、申し込みなしを含む全てのデータ";
      this.label3.Click += new System.EventHandler(this.label1_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(558, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(207, 12);
      this.label1.TabIndex = 1;
      this.label1.Text = "id:lat;lng;width height;deg;gislandad;c;e;m";
      this.label1.Click += new System.EventHandler(this.label1_Click);
      // 
      // dataGridView全データ
      // 
      this.dataGridView全データ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView全データ.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.lat,
            this.lng,
            this.width,
            this.height,
            this.arcdegree,
            this.gislandad,
            this.ckind,
            this.enable,
            this.disp});
      this.dataGridView全データ.Location = new System.Drawing.Point(3, 24);
      this.dataGridView全データ.Name = "dataGridView全データ";
      this.dataGridView全データ.RowTemplate.Height = 21;
      this.dataGridView全データ.Size = new System.Drawing.Size(762, 374);
      this.dataGridView全データ.TabIndex = 0;
      this.dataGridView全データ.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView全データ_CellValueChanged);
      // 
      // id
      // 
      this.id.Frozen = true;
      this.id.HeaderText = "id";
      this.id.Name = "id";
      this.id.ReadOnly = true;
      this.id.Width = 70;
      // 
      // lat
      // 
      this.lat.HeaderText = "緯度(マ地番)";
      this.lat.Name = "lat";
      this.lat.ReadOnly = true;
      // 
      // lng
      // 
      this.lng.HeaderText = "経度(マid)";
      this.lng.Name = "lng";
      this.lng.ReadOnly = true;
      // 
      // width
      // 
      this.width.HeaderText = "幅";
      this.width.Name = "width";
      this.width.ReadOnly = true;
      this.width.Width = 40;
      // 
      // height
      // 
      this.height.HeaderText = "高さ";
      this.height.Name = "height";
      this.height.ReadOnly = true;
      this.height.Width = 40;
      // 
      // arcdegree
      // 
      this.arcdegree.HeaderText = "角度";
      this.arcdegree.Name = "arcdegree";
      this.arcdegree.ReadOnly = true;
      this.arcdegree.Width = 40;
      // 
      // gislandad
      // 
      this.gislandad.HeaderText = "地名地番";
      this.gislandad.Name = "gislandad";
      // 
      // ckind
      // 
      this.ckind.HeaderText = "色品種";
      this.ckind.Name = "ckind";
      this.ckind.Width = 70;
      // 
      // enable
      // 
      this.enable.HeaderText = "有効";
      this.enable.Name = "enable";
      this.enable.Width = 40;
      // 
      // disp
      // 
      this.disp.HeaderText = "表示地番";
      this.disp.Name = "disp";
      // 
      // tabPageExcelから取得
      // 
      this.tabPageExcelから取得.Controls.Add(this.btn入力クリア);
      this.tabPageExcelから取得.Controls.Add(this.chkつや姫エサ米を無効);
      this.tabPageExcelから取得.Controls.Add(this.chk置換処理を行う);
      this.tabPageExcelから取得.Controls.Add(this.chk取得処理で全て処理する);
      this.tabPageExcelから取得.Controls.Add(this.btn申込を保存する);
      this.tabPageExcelから取得.Controls.Add(this.btn申込全てクリア);
      this.tabPageExcelから取得.Controls.Add(this.btn取得処理を行う);
      this.tabPageExcelから取得.Controls.Add(this.txtExcel地名地番);
      this.tabPageExcelから取得.Controls.Add(this.label6);
      this.tabPageExcelから取得.Controls.Add(this.lbl取得処理結果);
      this.tabPageExcelから取得.Controls.Add(this.label11);
      this.tabPageExcelから取得.Controls.Add(this.lbl合筆);
      this.tabPageExcelから取得.Controls.Add(this.lblマークなし);
      this.tabPageExcelから取得.Controls.Add(this.lbl地名地番重複);
      this.tabPageExcelから取得.Controls.Add(this.lbl地名地番不明);
      this.tabPageExcelから取得.Controls.Add(this.label5);
      this.tabPageExcelから取得.Controls.Add(this.label4);
      this.tabPageExcelから取得.Controls.Add(this.txt合筆元データなし);
      this.tabPageExcelから取得.Controls.Add(this.txt合筆);
      this.tabPageExcelから取得.Controls.Add(this.txtマークなし);
      this.tabPageExcelから取得.Controls.Add(this.txt地名地番重複);
      this.tabPageExcelから取得.Controls.Add(this.txt地名地番不明);
      this.tabPageExcelから取得.Controls.Add(this.txtExcelつや姫エサ米2回);
      this.tabPageExcelから取得.Location = new System.Drawing.Point(4, 22);
      this.tabPageExcelから取得.Name = "tabPageExcelから取得";
      this.tabPageExcelから取得.Padding = new System.Windows.Forms.Padding(3);
      this.tabPageExcelから取得.Size = new System.Drawing.Size(768, 443);
      this.tabPageExcelから取得.TabIndex = 4;
      this.tabPageExcelから取得.Text = "Excelから取得";
      this.tabPageExcelから取得.UseVisualStyleBackColor = true;
      // 
      // btn入力クリア
      // 
      this.btn入力クリア.Location = new System.Drawing.Point(441, 22);
      this.btn入力クリア.Name = "btn入力クリア";
      this.btn入力クリア.Size = new System.Drawing.Size(108, 32);
      this.btn入力クリア.TabIndex = 7;
      this.btn入力クリア.Text = "入力クリア";
      this.btn入力クリア.UseVisualStyleBackColor = true;
      this.btn入力クリア.Click += new System.EventHandler(this.btn入力クリア_Click);
      // 
      // chkつや姫エサ米を無効
      // 
      this.chkつや姫エサ米を無効.AutoSize = true;
      this.chkつや姫エサ米を無効.Location = new System.Drawing.Point(574, 212);
      this.chkつや姫エサ米を無効.Name = "chkつや姫エサ米を無効";
      this.chkつや姫エサ米を無効.Size = new System.Drawing.Size(179, 16);
      this.chkつや姫エサ米を無効.TabIndex = 6;
      this.chkつや姫エサ米を無効.Text = "「つや姫、エサ米2回」を無効で赤";
      this.chkつや姫エサ米を無効.UseVisualStyleBackColor = true;
      this.chkつや姫エサ米を無効.CheckedChanged += new System.EventHandler(this.chk取得処理で全て処理する_CheckedChanged);
      // 
      // chk置換処理を行う
      // 
      this.chk置換処理を行う.AutoSize = true;
      this.chk置換処理を行う.Checked = true;
      this.chk置換処理を行う.CheckState = System.Windows.Forms.CheckState.Checked;
      this.chk置換処理を行う.Location = new System.Drawing.Point(574, 190);
      this.chk置換処理を行う.Name = "chk置換処理を行う";
      this.chk置換処理を行う.Size = new System.Drawing.Size(100, 16);
      this.chk置換処理を行う.TabIndex = 6;
      this.chk置換処理を行う.Text = "置換処理を行う";
      this.chk置換処理を行う.UseVisualStyleBackColor = true;
      // 
      // chk取得処理で全て処理する
      // 
      this.chk取得処理で全て処理する.AutoSize = true;
      this.chk取得処理で全て処理する.Checked = true;
      this.chk取得処理で全て処理する.CheckState = System.Windows.Forms.CheckState.Checked;
      this.chk取得処理で全て処理する.Location = new System.Drawing.Point(574, 168);
      this.chk取得処理で全て処理する.Name = "chk取得処理で全て処理する";
      this.chk取得処理で全て処理する.Size = new System.Drawing.Size(146, 16);
      this.chk取得処理で全て処理する.TabIndex = 6;
      this.chk取得処理で全て処理する.Text = "取得処理で全て処理する";
      this.chk取得処理で全て処理する.UseVisualStyleBackColor = true;
      this.chk取得処理で全て処理する.CheckedChanged += new System.EventHandler(this.chk取得処理で全て処理する_CheckedChanged);
      // 
      // btn申込を保存する
      // 
      this.btn申込を保存する.Location = new System.Drawing.Point(574, 131);
      this.btn申込を保存する.Name = "btn申込を保存する";
      this.btn申込を保存する.Size = new System.Drawing.Size(117, 31);
      this.btn申込を保存する.TabIndex = 5;
      this.btn申込を保存する.Text = "申込を保存する";
      this.btn申込を保存する.UseVisualStyleBackColor = true;
      this.btn申込を保存する.Click += new System.EventHandler(this.btn申込を保存する_Click);
      // 
      // btn申込全てクリア
      // 
      this.btn申込全てクリア.Location = new System.Drawing.Point(574, 58);
      this.btn申込全てクリア.Name = "btn申込全てクリア";
      this.btn申込全てクリア.Size = new System.Drawing.Size(117, 30);
      this.btn申込全てクリア.TabIndex = 4;
      this.btn申込全てクリア.Text = "申込全てクリア";
      this.btn申込全てクリア.UseVisualStyleBackColor = true;
      this.btn申込全てクリア.Click += new System.EventHandler(this.btn申込全てクリア_Click);
      // 
      // btn取得処理を行う
      // 
      this.btn取得処理を行う.Location = new System.Drawing.Point(574, 94);
      this.btn取得処理を行う.Name = "btn取得処理を行う";
      this.btn取得処理を行う.Size = new System.Drawing.Size(117, 31);
      this.btn取得処理を行う.TabIndex = 3;
      this.btn取得処理を行う.Text = "取得処理を行う";
      this.btn取得処理を行う.UseVisualStyleBackColor = true;
      this.btn取得処理を行う.Click += new System.EventHandler(this.btn取得処理を行う_Click);
      // 
      // txtExcel地名地番
      // 
      this.txtExcel地名地番.Location = new System.Drawing.Point(21, 58);
      this.txtExcel地名地番.MaxLength = 200000;
      this.txtExcel地名地番.Multiline = true;
      this.txtExcel地名地番.Name = "txtExcel地名地番";
      this.txtExcel地名地番.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.txtExcel地名地番.Size = new System.Drawing.Size(276, 163);
      this.txtExcel地名地番.TabIndex = 2;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(19, 43);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(140, 12);
      this.label6.TabIndex = 1;
      this.label6.Text = "地名地番（遊佐 沖 55など）";
      // 
      // lbl取得処理結果
      // 
      this.lbl取得処理結果.AutoSize = true;
      this.lbl取得処理結果.Location = new System.Drawing.Point(19, 224);
      this.lbl取得処理結果.Name = "lbl取得処理結果";
      this.lbl取得処理結果.Size = new System.Drawing.Size(83, 12);
      this.lbl取得処理結果.TabIndex = 1;
      this.lbl取得処理結果.Text = "取得処理結果：";
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.Location = new System.Drawing.Point(377, 337);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(88, 12);
      this.label11.TabIndex = 1;
      this.label11.Text = "合筆元データなし";
      // 
      // lbl合筆
      // 
      this.lbl合筆.AutoSize = true;
      this.lbl合筆.Location = new System.Drawing.Point(19, 337);
      this.lbl合筆.Name = "lbl合筆";
      this.lbl合筆.Size = new System.Drawing.Size(181, 12);
      this.lbl合筆.TabIndex = 1;
      this.lbl合筆.Text = "合筆（マークデータを持たない片割れ）";
      // 
      // lblマークなし
      // 
      this.lblマークなし.AutoSize = true;
      this.lblマークなし.Location = new System.Drawing.Point(499, 241);
      this.lblマークなし.Name = "lblマークなし";
      this.lblマークなし.Size = new System.Drawing.Size(196, 12);
      this.lblマークなし.TabIndex = 1;
      this.lblマークなし.Text = "マークなし（GISでマークがない地名地番）";
      // 
      // lbl地名地番重複
      // 
      this.lbl地名地番重複.AutoSize = true;
      this.lbl地名地番重複.Location = new System.Drawing.Point(258, 241);
      this.lbl地名地番重複.Name = "lbl地名地番重複";
      this.lbl地名地番重複.Size = new System.Drawing.Size(203, 12);
      this.lbl地名地番重複.TabIndex = 1;
      this.lbl地名地番重複.Text = "地名地番重複（同一地名地番2件以上）";
      // 
      // lbl地名地番不明
      // 
      this.lbl地名地番不明.AutoSize = true;
      this.lbl地名地番不明.Location = new System.Drawing.Point(17, 241);
      this.lbl地名地番不明.Name = "lbl地名地番不明";
      this.lbl地名地番不明.Size = new System.Drawing.Size(241, 12);
      this.lbl地名地番不明.TabIndex = 1;
      this.lbl地名地番不明.Text = "地名地番不明（[全データ]タブの地名地番にない）";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(301, 43);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(93, 12);
      this.label5.TabIndex = 1;
      this.label5.Text = "つや姫、エサ米2回";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(19, 12);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(354, 12);
      this.label4.TabIndex = 1;
      this.label4.Text = "Excelから（「つや姫」、「エサ米2回」）、（「地名地番」）を申込全件貼り付け";
      // 
      // txt合筆元データなし
      // 
      this.txt合筆元データなし.Location = new System.Drawing.Point(379, 352);
      this.txt合筆元データなし.MaxLength = 300000;
      this.txt合筆元データなし.Multiline = true;
      this.txt合筆元データなし.Name = "txt合筆元データなし";
      this.txt合筆元データなし.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.txt合筆元データなし.Size = new System.Drawing.Size(354, 85);
      this.txt合筆元データなし.TabIndex = 0;
      // 
      // txt合筆
      // 
      this.txt合筆.Location = new System.Drawing.Point(19, 352);
      this.txt合筆.MaxLength = 300000;
      this.txt合筆.Multiline = true;
      this.txt合筆.Name = "txt合筆";
      this.txt合筆.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.txt合筆.Size = new System.Drawing.Size(354, 85);
      this.txt合筆.TabIndex = 0;
      // 
      // txtマークなし
      // 
      this.txtマークなし.Location = new System.Drawing.Point(501, 256);
      this.txtマークなし.MaxLength = 300000;
      this.txtマークなし.Multiline = true;
      this.txtマークなし.Name = "txtマークなし";
      this.txtマークなし.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.txtマークなし.Size = new System.Drawing.Size(235, 74);
      this.txtマークなし.TabIndex = 0;
      // 
      // txt地名地番重複
      // 
      this.txt地名地番重複.Location = new System.Drawing.Point(260, 256);
      this.txt地名地番重複.MaxLength = 300000;
      this.txt地名地番重複.Multiline = true;
      this.txt地名地番重複.Name = "txt地名地番重複";
      this.txt地名地番重複.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.txt地名地番重複.Size = new System.Drawing.Size(235, 74);
      this.txt地名地番重複.TabIndex = 0;
      // 
      // txt地名地番不明
      // 
      this.txt地名地番不明.Location = new System.Drawing.Point(19, 256);
      this.txt地名地番不明.MaxLength = 300000;
      this.txt地名地番不明.Multiline = true;
      this.txt地名地番不明.Name = "txt地名地番不明";
      this.txt地名地番不明.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.txt地名地番不明.Size = new System.Drawing.Size(235, 74);
      this.txt地名地番不明.TabIndex = 0;
      // 
      // txtExcelつや姫エサ米2回
      // 
      this.txtExcelつや姫エサ米2回.Location = new System.Drawing.Point(303, 58);
      this.txtExcelつや姫エサ米2回.MaxLength = 200000;
      this.txtExcelつや姫エサ米2回.Multiline = true;
      this.txtExcelつや姫エサ米2回.Name = "txtExcelつや姫エサ米2回";
      this.txtExcelつや姫エサ米2回.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.txtExcelつや姫エサ米2回.Size = new System.Drawing.Size(265, 163);
      this.txtExcelつや姫エサ米2回.TabIndex = 0;
      // 
      // tabPageメモ
      // 
      this.tabPageメモ.Controls.Add(this.textBox1);
      this.tabPageメモ.Location = new System.Drawing.Point(4, 22);
      this.tabPageメモ.Name = "tabPageメモ";
      this.tabPageメモ.Padding = new System.Windows.Forms.Padding(3);
      this.tabPageメモ.Size = new System.Drawing.Size(768, 443);
      this.tabPageメモ.TabIndex = 5;
      this.tabPageメモ.Text = "メモ";
      this.tabPageメモ.UseVisualStyleBackColor = true;
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(6, 3);
      this.textBox1.MaxLength = 200000;
      this.textBox1.Multiline = true;
      this.textBox1.Name = "textBox1";
      this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.textBox1.Size = new System.Drawing.Size(756, 434);
      this.textBox1.TabIndex = 0;
      // 
      // lblデータフィルタ
      // 
      this.lblデータフィルタ.AutoSize = true;
      this.lblデータフィルタ.Location = new System.Drawing.Point(14, 495);
      this.lblデータフィルタ.Name = "lblデータフィルタ";
      this.lblデータフィルタ.Size = new System.Drawing.Size(78, 12);
      this.lblデータフィルタ.TabIndex = 2;
      this.lblデータフィルタ.Text = "データフィルタ：-";
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Location = new System.Drawing.Point(666, 495);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(122, 12);
      this.label10.TabIndex = 3;
      this.label10.Text = "Version 2.8(2022.06.19)";
      // 
      // printDialog1
      // 
      this.printDialog1.UseEXDialog = true;
      // 
      // chk1ha毎に線を引く
      // 
      this.chk1ha毎に線を引く.AutoSize = true;
      this.chk1ha毎に線を引く.Checked = true;
      this.chk1ha毎に線を引く.CheckState = System.Windows.Forms.CheckState.Checked;
      this.chk1ha毎に線を引く.Location = new System.Drawing.Point(518, 175);
      this.chk1ha毎に線を引く.Name = "chk1ha毎に線を引く";
      this.chk1ha毎に線を引く.Size = new System.Drawing.Size(110, 16);
      this.chk1ha毎に線を引く.TabIndex = 11;
      this.chk1ha毎に線を引く.Text = "1 ha 毎に線を引く";
      this.chk1ha毎に線を引く.UseVisualStyleBackColor = true;
      this.chk1ha毎に線を引く.CheckedChanged += new System.EventHandler(this.chk1ha毎に線を引く_CheckedChanged);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 516);
      this.Controls.Add(this.label10);
      this.Controls.Add(this.lblデータフィルタ);
      this.Controls.Add(this.tabControl1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.Name = "Form1";
      this.Text = "ヘリ地図作成";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
      this.Load += new System.EventHandler(this.Form1_Load);
      this.tabControl1.ResumeLayout(false);
      this.tabPageメイン.ResumeLayout(false);
      this.tabPageメイン.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMapSetting)).EndInit();
      this.tabPage地図画像.ResumeLayout(false);
      this.tabPage地図画像.PerformLayout();
      this.panelPic.ResumeLayout(false);
      this.panelPic.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.picImg)).EndInit();
      this.tabPage印刷.ResumeLayout(false);
      this.groupBox3.ResumeLayout(false);
      this.groupBox3.PerformLayout();
      this.tabPage表示データ.ResumeLayout(false);
      this.tabPage表示データ.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView表示データ)).EndInit();
      this.tabPage全データ.ResumeLayout(false);
      this.tabPage全データ.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView全データ)).EndInit();
      this.tabPageExcelから取得.ResumeLayout(false);
      this.tabPageExcelから取得.PerformLayout();
      this.tabPageメモ.ResumeLayout(false);
      this.tabPageメモ.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPageメイン;
    private System.Windows.Forms.TabPage tabPage地図画像;
    private System.Windows.Forms.PictureBox picImg;
    private System.Windows.Forms.TabPage tabPage全データ;
    private System.Windows.Forms.ListBox listBox地区一覧;
    private System.Windows.Forms.DataGridView dataGridViewMapSetting;
    private System.Windows.Forms.Button btn地図画像を作る;
    private System.Windows.Forms.Panel panelPic;
    private System.Windows.Forms.DataGridView dataGridView全データ;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label lblデータフィルタ;
    private System.Windows.Forms.TabPage tabPage表示データ;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.DataGridView dataGridView表示データ;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.DataGridViewTextBoxColumn 地区;
    private System.Windows.Forms.DataGridViewTextBoxColumn img;
    private System.Windows.Forms.DataGridViewTextBoxColumn 横サイズ;
    private System.Windows.Forms.DataGridViewTextBoxColumn 縦サイズ;
    private System.Windows.Forms.DataGridViewTextBoxColumn 左基準;
    private System.Windows.Forms.DataGridViewTextBoxColumn 左経度;
    private System.Windows.Forms.DataGridViewTextBoxColumn 上基準;
    private System.Windows.Forms.DataGridViewTextBoxColumn 上緯度;
    private System.Windows.Forms.DataGridViewTextBoxColumn 右基準;
    private System.Windows.Forms.DataGridViewTextBoxColumn 右経度;
    private System.Windows.Forms.DataGridViewTextBoxColumn 下基準;
    private System.Windows.Forms.DataGridViewTextBoxColumn 下緯度;
    private System.Windows.Forms.Label lblタブヒント;
    private System.Windows.Forms.TabPage tabPageExcelから取得;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox txtExcelつや姫エサ米2回;
    private System.Windows.Forms.Button btn取得処理を行う;
    private System.Windows.Forms.TextBox txtExcel地名地番;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox txt地名地番不明;
    private System.Windows.Forms.Label lbl地名地番不明;
    private System.Windows.Forms.Label lbl取得処理結果;
    private System.Windows.Forms.CheckBox chk取得処理で全て処理する;
    private System.Windows.Forms.Button btn申込を保存する;
    private System.Windows.Forms.Button btn申込全てクリア;
    private System.Windows.Forms.TextBox txt合筆;
    private System.Windows.Forms.TextBox txt地名地番重複;
    private System.Windows.Forms.Label lbl合筆;
    private System.Windows.Forms.Label lbl地名地番重複;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.DataGridViewTextBoxColumn id;
    private System.Windows.Forms.DataGridViewTextBoxColumn lat;
    private System.Windows.Forms.DataGridViewTextBoxColumn lng;
    private System.Windows.Forms.DataGridViewTextBoxColumn width;
    private System.Windows.Forms.DataGridViewTextBoxColumn height;
    private System.Windows.Forms.DataGridViewTextBoxColumn arcdegree;
    private System.Windows.Forms.DataGridViewTextBoxColumn gislandad;
    private System.Windows.Forms.DataGridViewTextBoxColumn ckind;
    private System.Windows.Forms.DataGridViewTextBoxColumn enable;
    private System.Windows.Forms.DataGridViewTextBoxColumn disp;
    private System.Windows.Forms.Label lblマークなし;
    private System.Windows.Forms.TextBox txtマークなし;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.CheckBox chk3回;
    private System.Windows.Forms.CheckBox chk申込なし;
    private System.Windows.Forms.CheckBox chk2回;
    private System.Windows.Forms.CheckBox chkつや姫;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.CheckBox chk表示地番;
    private System.Windows.Forms.CheckBox chk地番;
    private System.Windows.Forms.CheckBox chk字;
    private System.Windows.Forms.CheckBox chk大字;
    private System.Windows.Forms.CheckBox chkid下4桁;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.CheckBox chk地番データなし;
    private System.Windows.Forms.CheckBox chk地図に地区時刻表示;
    private System.Windows.Forms.TabPage tabPageメモ;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.TextBox txt合筆元データなし;
    private System.Windows.Forms.TabPage tabPage印刷;
    private System.Windows.Forms.PrintPreviewControl printPreviewControl1;
    private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
    private System.Windows.Forms.Button btn印刷する;
    private System.Windows.Forms.PrintDialog printDialog1;
    private System.Windows.Forms.Button btn印刷設定;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.Label lbl給紙方法;
    private System.Windows.Forms.Label lblサイズ;
    private System.Windows.Forms.Label lbl余白;
    private System.Windows.Forms.Label lbl印刷方向;
    private System.Windows.Forms.Button btn入力クリア;
    private System.Windows.Forms.Button txtDatatxt再度読込;
    private System.Windows.Forms.CheckBox chkつや姫エサ米を無効;
    private System.Windows.Forms.CheckBox chk置換処理を行う;
    private System.Windows.Forms.Button btnGitHubを開く;
    private System.Windows.Forms.CheckBox chk1ha毎に線を引く;
  }
}

