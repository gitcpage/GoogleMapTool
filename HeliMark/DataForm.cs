using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeliMark
{
  public partial class DataForm : Form
  {
    ImageCtrl m_ImgCtrl;
    Data[] m_DataForDraw;
    int m_mapSettingIndex = -1;
    string kDefaultTitleBarText;
    MapSetting[] m_mapSetting; // todo share

    Point m_imgScrollPos;
    static string s_dialogInitialDirectory = @"C:\"; // todo share
    public DataForm()
    {
      InitializeComponent();
    }

    private void btnヘリ地図作成へ_Click(object sender, EventArgs e)
    {
      Program.s_Next = Program.Next.Form1;
      Close();
    }

    private void DataForm_Load(object sender, EventArgs e)
    {
      this.listBoxD地区一覧.SelectedIndex = 0;
      string[] dem = new string[1];
      dem[0] = ";";

      if (this.dataGridViewMapSetting.Rows.Count == 0)
      {
        kDefaultTitleBarText = this.Text;
        string[] mapsettingLines = FormLib.LoadTextByPath("mapsetting.txt");
        m_mapSetting = new MapSetting[mapsettingLines.Length];
        int i = 0;
        foreach (string s in mapsettingLines)
        {
          string[] ss = s.Split(dem, StringSplitOptions.None);
          this.dataGridViewMapSetting.Rows.Add(ss);
          m_mapSetting[i] = new MapSetting(ss);
          i++;
        }
        this.Text = kDefaultTitleBarText + "(dataLines:" + i.ToString() + ")";
      }
    }

    private void btnD選択_Click(object sender, EventArgs e)
    {
      // step0 画像を取得する（画像がない場合に例外で対処するため先に処理する）
      int mapSettingIndex = this.listBoxD地区一覧.SelectedIndex;
      ImageCtrl imgCtrl = new ImageCtrl();
      {
        string imgPath = m_mapSetting[mapSettingIndex].画像;
        if (!imgCtrl.Init(imgPath))
        {
          MessageBox.Show(imgPath + "の読み込みに失敗しました。", "HeliMarkエラー",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
          return; // 失敗
        }
      }

      // step1 地区を選択する
      string lblデータフィルタstring;
      m_DataForDraw = Data.Make(
        this.dataGridView全データ,
        out lblデータフィルタstring, // ウィンドウ下のラベルに書き込み
        this.listBoxD地区一覧);
      this.lblデータフィルタ.Text = lblデータフィルタstring;

      //Data.PrintDataGridView(m_DataForDraw, this.dataGridView表示データ);
      // step2 地図を表示する
      m_ImgCtrl = imgCtrl; // step0から
      this.picDImg.Image = imgCtrl.Image;

      // step3 地図にマークする
      if (mapSettingIndex < 0 && mapSettingIndex > 7)
      {
        MessageBox.Show("mapSettingIndexが0～7ではありません。" + mapSettingIndex + "です。", "btnテスト_Click");
        return;
      }
      m_ImgCtrl.PaintMark(m_mapSetting[mapSettingIndex], m_DataForDraw,
        this.listBoxD地区一覧.SelectedItem.ToString());
      m_mapSettingIndex = mapSettingIndex;

      this.Text = kDefaultTitleBarText + "(" + listBoxD地区一覧.SelectedItem.ToString() + ")";
    }

    private void picDImg_MouseClick(object sender, MouseEventArgs e)
    {
      switch (e.Button)
      {
        // 左クリック時、ズーム切り替えをする。
        case MouseButtons.Left:
          if (this.panelDPic.AutoScroll == true)
          {
            m_imgScrollPos = this.panelDPic.AutoScrollPosition;
            //取得時は負の値に反転しているので、正の値にする。
            //https://dobon.net/vb/dotnet/form/autoscrollposition.html
            m_imgScrollPos.X = -m_imgScrollPos.X;
            m_imgScrollPos.Y = -m_imgScrollPos.Y;
            this.panelDPic.AutoScroll = false;
            this.picDImg.SizeMode = PictureBoxSizeMode.Zoom;
          }
          else
          {
            this.panelDPic.AutoScroll = true;
            this.picDImg.SizeMode = PictureBoxSizeMode.AutoSize;
            this.panelDPic.AutoScrollPosition = m_imgScrollPos;
          }
          break;
        // 中央クリック時、オートスクロールなら座標をクリップボードにコピーする。
        case MouseButtons.Middle:
          if (this.panelDPic.AutoScroll == true)
          {
            double lat, lng;
            m_ImgCtrl.XyToLatLng(e.X, e.Y, out lat, out lng);
            string s = lat.ToString() + "," + lng.ToString();
            Clipboard.SetText(s);
            string title = e.X.ToString() + "," + e.Y.ToString();
            MessageBox.Show("クリップボードに[" + s + "]をコピーしました。", title);
          }
          break;
        // 右クリック時、画像を保存する。
        case MouseButtons.Right:
          if (m_mapSettingIndex < 0) return;

          SaveFileDialog sfd = new SaveFileDialog();
          sfd.FileName = m_mapSetting[m_mapSettingIndex].地区.ToString() + ".png";
          sfd.InitialDirectory = s_dialogInitialDirectory;
          sfd.Filter = "PNGファイル|*.png";
          sfd.FilterIndex = 1;
          sfd.Title = "保存先のファイルを選択してください";
          sfd.RestoreDirectory = true;
          sfd.OverwritePrompt = true;
          sfd.CheckPathExists = true;
          if (sfd.ShowDialog() == DialogResult.OK)
          {
            this.picDImg.Image.Save(sfd.FileName, System.Drawing.Imaging.ImageFormat.Png);
            s_dialogInitialDirectory = System.IO.Path.GetDirectoryName(sfd.FileName);
          }
          break;
      }
    }
  }
}
