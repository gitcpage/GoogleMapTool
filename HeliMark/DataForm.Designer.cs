﻿namespace HeliMark
{
  partial class DataForm
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
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tabPageDメイン = new System.Windows.Forms.TabPage();
      this.btnヘリ地図作成へ = new System.Windows.Forms.Button();
      this.btnD選択 = new System.Windows.Forms.Button();
      this.listBoxD地区一覧 = new System.Windows.Forms.ListBox();
      this.tabPageD座標 = new System.Windows.Forms.TabPage();
      this.picDImg = new System.Windows.Forms.PictureBox();
      this.tabPageデータ = new System.Windows.Forms.TabPage();
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
      this.panelDPic = new System.Windows.Forms.Panel();
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
      this.lblデータフィルタ = new System.Windows.Forms.Label();
      this.tabControl1.SuspendLayout();
      this.tabPageDメイン.SuspendLayout();
      this.tabPageD座標.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.picDImg)).BeginInit();
      this.tabPageデータ.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMapSetting)).BeginInit();
      this.panelDPic.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView全データ)).BeginInit();
      this.SuspendLayout();
      // 
      // tabControl1
      // 
      this.tabControl1.Controls.Add(this.tabPageDメイン);
      this.tabControl1.Controls.Add(this.tabPageD座標);
      this.tabControl1.Controls.Add(this.tabPageデータ);
      this.tabControl1.Location = new System.Drawing.Point(7, 8);
      this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(860, 509);
      this.tabControl1.TabIndex = 0;
      // 
      // tabPageDメイン
      // 
      this.tabPageDメイン.Controls.Add(this.dataGridViewMapSetting);
      this.tabPageDメイン.Controls.Add(this.btnヘリ地図作成へ);
      this.tabPageDメイン.Controls.Add(this.btnD選択);
      this.tabPageDメイン.Controls.Add(this.listBoxD地区一覧);
      this.tabPageDメイン.Location = new System.Drawing.Point(4, 22);
      this.tabPageDメイン.Margin = new System.Windows.Forms.Padding(2);
      this.tabPageDメイン.Name = "tabPageDメイン";
      this.tabPageDメイン.Padding = new System.Windows.Forms.Padding(2);
      this.tabPageDメイン.Size = new System.Drawing.Size(852, 483);
      this.tabPageDメイン.TabIndex = 0;
      this.tabPageDメイン.Text = "Dメイン";
      this.tabPageDメイン.UseVisualStyleBackColor = true;
      // 
      // btnヘリ地図作成へ
      // 
      this.btnヘリ地図作成へ.Location = new System.Drawing.Point(735, 441);
      this.btnヘリ地図作成へ.Name = "btnヘリ地図作成へ";
      this.btnヘリ地図作成へ.Size = new System.Drawing.Size(112, 37);
      this.btnヘリ地図作成へ.TabIndex = 3;
      this.btnヘリ地図作成へ.Text = "ヘリ地図作成へ";
      this.btnヘリ地図作成へ.UseVisualStyleBackColor = true;
      this.btnヘリ地図作成へ.Click += new System.EventHandler(this.btnヘリ地図作成へ_Click);
      // 
      // btnD選択
      // 
      this.btnD選択.Location = new System.Drawing.Point(181, 39);
      this.btnD選択.Margin = new System.Windows.Forms.Padding(2);
      this.btnD選択.Name = "btnD選択";
      this.btnD選択.Size = new System.Drawing.Size(97, 31);
      this.btnD選択.TabIndex = 2;
      this.btnD選択.Text = "選択";
      this.btnD選択.UseVisualStyleBackColor = true;
      this.btnD選択.Click += new System.EventHandler(this.btnD選択_Click);
      // 
      // listBoxD地区一覧
      // 
      this.listBoxD地区一覧.FormattingEnabled = true;
      this.listBoxD地区一覧.ItemHeight = 12;
      this.listBoxD地区一覧.Items.AddRange(new object[] {
            "東部",
            "藤井",
            "広野",
            "野沢",
            "上吉出",
            "下吉出",
            "西部",
            "町中"});
      this.listBoxD地区一覧.Location = new System.Drawing.Point(5, 5);
      this.listBoxD地区一覧.Name = "listBoxD地区一覧";
      this.listBoxD地区一覧.Size = new System.Drawing.Size(139, 112);
      this.listBoxD地区一覧.TabIndex = 1;
      // 
      // tabPageD座標
      // 
      this.tabPageD座標.Controls.Add(this.panelDPic);
      this.tabPageD座標.Location = new System.Drawing.Point(4, 22);
      this.tabPageD座標.Margin = new System.Windows.Forms.Padding(2);
      this.tabPageD座標.Name = "tabPageD座標";
      this.tabPageD座標.Padding = new System.Windows.Forms.Padding(2);
      this.tabPageD座標.Size = new System.Drawing.Size(852, 483);
      this.tabPageD座標.TabIndex = 1;
      this.tabPageD座標.Text = "座標";
      this.tabPageD座標.UseVisualStyleBackColor = true;
      // 
      // picDImg
      // 
      this.picDImg.Location = new System.Drawing.Point(18, 26);
      this.picDImg.Name = "picDImg";
      this.picDImg.Size = new System.Drawing.Size(750, 400);
      this.picDImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
      this.picDImg.TabIndex = 1;
      this.picDImg.TabStop = false;
      this.picDImg.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picDImg_MouseClick);
      // 
      // tabPageデータ
      // 
      this.tabPageデータ.Controls.Add(this.dataGridView全データ);
      this.tabPageデータ.Location = new System.Drawing.Point(4, 22);
      this.tabPageデータ.Margin = new System.Windows.Forms.Padding(2);
      this.tabPageデータ.Name = "tabPageデータ";
      this.tabPageデータ.Padding = new System.Windows.Forms.Padding(2);
      this.tabPageデータ.Size = new System.Drawing.Size(852, 483);
      this.tabPageデータ.TabIndex = 2;
      this.tabPageデータ.Text = "データ";
      this.tabPageデータ.UseVisualStyleBackColor = true;
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
      this.dataGridViewMapSetting.Location = new System.Drawing.Point(48, 137);
      this.dataGridViewMapSetting.Name = "dataGridViewMapSetting";
      this.dataGridViewMapSetting.RowHeadersWidth = 62;
      this.dataGridViewMapSetting.RowTemplate.Height = 21;
      this.dataGridViewMapSetting.Size = new System.Drawing.Size(756, 209);
      this.dataGridViewMapSetting.TabIndex = 4;
      // 
      // 地区
      // 
      this.地区.Frozen = true;
      this.地区.HeaderText = "地区";
      this.地区.MinimumWidth = 8;
      this.地区.Name = "地区";
      this.地区.ReadOnly = true;
      this.地区.Width = 60;
      // 
      // img
      // 
      this.img.HeaderText = "画像";
      this.img.MinimumWidth = 8;
      this.img.Name = "img";
      this.img.Width = 90;
      // 
      // 横サイズ
      // 
      this.横サイズ.HeaderText = "横サイズ";
      this.横サイズ.MinimumWidth = 8;
      this.横サイズ.Name = "横サイズ";
      this.横サイズ.Width = 80;
      // 
      // 縦サイズ
      // 
      this.縦サイズ.HeaderText = "縦サイズ";
      this.縦サイズ.MinimumWidth = 8;
      this.縦サイズ.Name = "縦サイズ";
      this.縦サイズ.Width = 80;
      // 
      // 左基準
      // 
      this.左基準.HeaderText = "左基準";
      this.左基準.MinimumWidth = 8;
      this.左基準.Name = "左基準";
      this.左基準.Width = 70;
      // 
      // 左経度
      // 
      this.左経度.HeaderText = "左経度";
      this.左経度.MinimumWidth = 8;
      this.左経度.Name = "左経度";
      this.左経度.Width = 80;
      // 
      // 上基準
      // 
      this.上基準.HeaderText = "上基準";
      this.上基準.MinimumWidth = 8;
      this.上基準.Name = "上基準";
      this.上基準.Width = 70;
      // 
      // 上緯度
      // 
      this.上緯度.HeaderText = "上緯度";
      this.上緯度.MinimumWidth = 8;
      this.上緯度.Name = "上緯度";
      this.上緯度.Width = 80;
      // 
      // 右基準
      // 
      this.右基準.HeaderText = "右基準";
      this.右基準.MinimumWidth = 8;
      this.右基準.Name = "右基準";
      this.右基準.Width = 70;
      // 
      // 右経度
      // 
      this.右経度.HeaderText = "右経度";
      this.右経度.MinimumWidth = 8;
      this.右経度.Name = "右経度";
      this.右経度.Width = 80;
      // 
      // 下基準
      // 
      this.下基準.HeaderText = "下基準";
      this.下基準.MinimumWidth = 8;
      this.下基準.Name = "下基準";
      this.下基準.Width = 70;
      // 
      // 下緯度
      // 
      this.下緯度.HeaderText = "下緯度";
      this.下緯度.MinimumWidth = 8;
      this.下緯度.Name = "下緯度";
      this.下緯度.Width = 80;
      // 
      // panelDPic
      // 
      this.panelDPic.Controls.Add(this.picDImg);
      this.panelDPic.Location = new System.Drawing.Point(5, 5);
      this.panelDPic.Name = "panelDPic";
      this.panelDPic.Size = new System.Drawing.Size(842, 455);
      this.panelDPic.TabIndex = 2;
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
      this.dataGridView全データ.Location = new System.Drawing.Point(45, 54);
      this.dataGridView全データ.Name = "dataGridView全データ";
      this.dataGridView全データ.RowHeadersWidth = 62;
      this.dataGridView全データ.RowTemplate.Height = 21;
      this.dataGridView全データ.Size = new System.Drawing.Size(762, 374);
      this.dataGridView全データ.TabIndex = 1;
      // 
      // id
      // 
      this.id.Frozen = true;
      this.id.HeaderText = "id";
      this.id.MinimumWidth = 8;
      this.id.Name = "id";
      this.id.ReadOnly = true;
      this.id.Width = 70;
      // 
      // lat
      // 
      this.lat.HeaderText = "緯度(マ地番)";
      this.lat.MinimumWidth = 8;
      this.lat.Name = "lat";
      this.lat.ReadOnly = true;
      this.lat.Width = 150;
      // 
      // lng
      // 
      this.lng.HeaderText = "経度(マid)";
      this.lng.MinimumWidth = 8;
      this.lng.Name = "lng";
      this.lng.ReadOnly = true;
      this.lng.Width = 150;
      // 
      // width
      // 
      this.width.HeaderText = "幅";
      this.width.MinimumWidth = 8;
      this.width.Name = "width";
      this.width.ReadOnly = true;
      this.width.Width = 40;
      // 
      // height
      // 
      this.height.HeaderText = "高さ";
      this.height.MinimumWidth = 8;
      this.height.Name = "height";
      this.height.ReadOnly = true;
      this.height.Width = 40;
      // 
      // arcdegree
      // 
      this.arcdegree.HeaderText = "角度";
      this.arcdegree.MinimumWidth = 8;
      this.arcdegree.Name = "arcdegree";
      this.arcdegree.ReadOnly = true;
      this.arcdegree.Width = 40;
      // 
      // gislandad
      // 
      this.gislandad.HeaderText = "地名地番";
      this.gislandad.MinimumWidth = 8;
      this.gislandad.Name = "gislandad";
      this.gislandad.Width = 150;
      // 
      // ckind
      // 
      this.ckind.HeaderText = "色品種";
      this.ckind.MinimumWidth = 8;
      this.ckind.Name = "ckind";
      this.ckind.Width = 70;
      // 
      // enable
      // 
      this.enable.HeaderText = "有効";
      this.enable.MinimumWidth = 8;
      this.enable.Name = "enable";
      this.enable.Width = 40;
      // 
      // disp
      // 
      this.disp.HeaderText = "表示地番";
      this.disp.MinimumWidth = 8;
      this.disp.Name = "disp";
      this.disp.Width = 150;
      // 
      // lblデータフィルタ
      // 
      this.lblデータフィルタ.AutoSize = true;
      this.lblデータフィルタ.Location = new System.Drawing.Point(12, 553);
      this.lblデータフィルタ.Name = "lblデータフィルタ";
      this.lblデータフィルタ.Size = new System.Drawing.Size(78, 12);
      this.lblデータフィルタ.TabIndex = 3;
      this.lblデータフィルタ.Text = "データフィルタ：-";
      // 
      // DataForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(875, 574);
      this.Controls.Add(this.lblデータフィルタ);
      this.Controls.Add(this.tabControl1);
      this.Margin = new System.Windows.Forms.Padding(2);
      this.Name = "DataForm";
      this.Text = "Data";
      this.Load += new System.EventHandler(this.DataForm_Load);
      this.tabControl1.ResumeLayout(false);
      this.tabPageDメイン.ResumeLayout(false);
      this.tabPageD座標.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.picDImg)).EndInit();
      this.tabPageデータ.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMapSetting)).EndInit();
      this.panelDPic.ResumeLayout(false);
      this.panelDPic.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView全データ)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPageDメイン;
    private System.Windows.Forms.TabPage tabPageD座標;
    private System.Windows.Forms.TabPage tabPageデータ;
    private System.Windows.Forms.PictureBox picDImg;
    private System.Windows.Forms.ListBox listBoxD地区一覧;
    private System.Windows.Forms.Button btnD選択;
    private System.Windows.Forms.Button btnヘリ地図作成へ;
    private System.Windows.Forms.DataGridView dataGridViewMapSetting;
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
    private System.Windows.Forms.Panel panelDPic;
    private System.Windows.Forms.DataGridView dataGridView全データ;
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
    private System.Windows.Forms.Label lblデータフィルタ;
  }
}