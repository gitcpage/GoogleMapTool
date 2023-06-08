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
  public partial class Form1 : Form
  {
    ImageCtrl m_ImgCtrl;
    Data[] m_DataForDraw;
    MapSetting[] m_mapSetting;
    int m_mapSettingIndex = -1;
    string kDefaultTitleBarText;

    Point m_imgScrollPos;
    static string s_dialogInitialDirectory = @"C:\";

    public Form1()
    {
      InitializeComponent();
      m_imgScrollPos = new Point();
      Print.Init(this.pageSetupDialog1);
      chk取得処理で全て処理する_CheckedChanged(this, null);
      chk塗りつぶしマーク(null, null);
    }

    private string[] SplitByNewLine(string str, bool doWarning = false)
    {
      string[] dem = new string[1];
      dem[0] = Environment.NewLine;

      // 2023/06/07 空行があった場合に警告する。
      if (!doWarning)
        return str.Split(dem, StringSplitOptions.None);//RemoveEmptyEntries);
      string[] strings = str.Split(dem, StringSplitOptions.None);
      foreach (var item in strings)
      {
        if (item == "")
        {
          MessageBox.Show("data.txtに空行がありました。エラーの原因になるので取り除いてください。");
          return str.Split(dem, StringSplitOptions.RemoveEmptyEntries);
        }
      }
      return strings;
    }
    private string[] LoadTextByPath(string path)
    {
      //Encoding sjisEnc = Encoding.GetEncoding("Shift_JIS");
      System.IO.StreamReader reader = null;
      try
      {
        reader = new System.IO.StreamReader(path, Encoding.UTF8);
      }
      catch(System.IO.FileNotFoundException)
      {
        MessageBox.Show(path + " ファイルを開けません。プログラムを終了します。", "Error", 
          MessageBoxButtons.OK ,MessageBoxIcon.Error);
        Environment.Exit(-1);
      }
      string s = reader.ReadToEnd();
      reader.Close();

      return SplitByNewLine(s, true);
    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void btn地図画像を作る_Click(object sender, EventArgs e)
    {
      // 以前、step1 で「データを読み込む」処理をしていたが、それをForm1_Load()へ移動した。

      // step0 画像を取得する（画像がない場合に例外で対処するため先に処理する）
      int mapSettingIndex = this.listBox地区一覧.SelectedIndex;
      ImageCtrl imgCtrl = new ImageCtrl();
      //m_ImgCtrl.Init("fujii.png");
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
        this.listBox地区一覧);
      this.lblデータフィルタ.Text = lblデータフィルタstring;

      Data.PrintDataGridView(m_DataForDraw, this.dataGridView表示データ);

      // step2 地図を表示する
      m_ImgCtrl = imgCtrl; // step0から
      this.picImg.Image = m_ImgCtrl.Image;

      // step3 地図にマークする
      if (mapSettingIndex < 0 && mapSettingIndex > 7)
      {
        MessageBox.Show("mapSettingIndexが0～7ではありません。" + mapSettingIndex + "です。", "btnテスト_Click");
        return;
      }
      m_ImgCtrl.PaintMark(m_mapSetting[mapSettingIndex], m_DataForDraw,
        this.listBox地区一覧.SelectedItem.ToString());
      m_mapSettingIndex = mapSettingIndex;

      this.Text = kDefaultTitleBarText + "(" + listBox地区一覧.SelectedItem.ToString() + ")";

      // 印刷プレビュー //https://dobon.net/vb/dotnet/graphics/printpreviewdialog.html
      UpdatePrintPreview();
    }
    private void UpdatePrintPreview()
    {
      if (this.picImg.Image == null) return;
      printPreviewControl1.Document = Print.PrintDoc;
      printPreviewControl1.InvalidatePreview();
    }
    private void pd_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
    {
      //画像を読み込む
      Image img = (Image)this.picImg.Image.Clone();
      //画像を描画する
      int left, top, width,  height;
      if (Print.PageSettings.Landscape)
      {
        Print.SetHorizonValues(img, out left, out top, out width, out height);
      }
      else
      {
        Print.SetVerticalValues(img, out left, out top, out width, out height);
      }
      e.Graphics.DrawImage(img, left, top, width, height);
      //次のページがないことを通知する
      e.HasMorePages = false;
      //後始末をする
      img.Dispose();
    }
    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void Form1_Load(object sender, EventArgs e)
    {
      string[] dem = new string[1];
      dem[0] = ";";

      if (this.dataGridViewMapSetting.Rows.Count == 0)
      {
        kDefaultTitleBarText = this.Text;
        string[] mapsettingLines = LoadTextByPath("mapsetting.txt");
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
      //this.dataGridViewMap.Rows.Add(
      //  "hujii", "1565", "2117", "79", "139.93841904476", "84", "39.05131728821", "1371", "139.95227141995", "1960", "39.0356716804129");

      if (this.listBox地区一覧.SelectedIndex == -1) // 20230608追加
        this.listBox地区一覧.SelectedIndex = 0;

      // データを読み込む
      string[] dataLines = LoadTextByPath("data.txt");
      this.dataGridView全データ.Rows.Clear();
      foreach (string s in dataLines)
      {
        string[] ss = s.Split(dem, StringSplitOptions.None);
        this.dataGridView全データ.Rows.Add(ss);
      }

      WritePrintSetting();
      Print.PrintDoc.PrintPage +=
          new System.Drawing.Printing.PrintPageEventHandler(pd_PrintPage);

      Flags.isSaveYet = false;
    }

    private void picImg_MouseClick(object sender, MouseEventArgs e)
    {
      switch (e.Button)
      {
        // 左クリック時、ズーム切り替えをする。
        case MouseButtons.Left:
          if (this.panelPic.AutoScroll == true)
          {
            m_imgScrollPos = this.panelPic.AutoScrollPosition;
            //取得時は負の値に反転しているので、正の値にする。
            //https://dobon.net/vb/dotnet/form/autoscrollposition.html
            m_imgScrollPos.X = -m_imgScrollPos.X;
            m_imgScrollPos.Y = -m_imgScrollPos.Y;
            this.panelPic.AutoScroll = false;
            this.picImg.SizeMode = PictureBoxSizeMode.Zoom;
          }
          else
          {
            this.panelPic.AutoScroll = true;
            this.picImg.SizeMode = PictureBoxSizeMode.AutoSize;
            this.panelPic.AutoScrollPosition = m_imgScrollPos;
          }
          break;
        // 中央クリック時、オートスクロールなら座標をクリップボードにコピーする。
        case MouseButtons.Middle:
          if (this.panelPic.AutoScroll == true)
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
            this.picImg.Image.Save(sfd.FileName, System.Drawing.Imaging.ImageFormat.Png);
            s_dialogInitialDirectory = System.IO.Path.GetDirectoryName(sfd.FileName);
          }
          break;
      }
    }

    enum ResultStatus : short
    {
      Duplicate = -1,
      None = 0,
      Success = 1
    }

    // string src = exl地名地番;
    ResultStatus 置換処理(string src, int rowCount, string ckind)
    {
      ResultStatus resultStatus = ResultStatus.None;
      // ▲▲▲ プリプロセス ▲▲▲
      if (src == "白井新田 東部 245")
      {
        src = "白井新田 東部 245-(1・2・3)";
      }
      if (src == "白井新田 藤井南 23-24")
      {
        src = "白井新田 藤井南 23・24-(1・2・3)";
      }
      string ToGis字(string src_)
      {
        src_ = src_.Replace("漆曽根", "うるしそね");
        src_ = src_.Replace("仲の坪", "仲ノ坪");
        src_ = src_.Replace("上曾根田", "上曽根田");
        src_ = src_.Replace("  ", " ");
        src_ = src_.Replace("  ", " ");
        //src_ = src_.Replace("）～（", "～"); // 野沢 上野沢 114-（1）～（4）

        return src_;
      }
      char[] chars = new char[1];
      chars[0] = ' ';
      string[] ss_tokens = ToGis字(src).Split(chars, StringSplitOptions.None); // 変換
      if (ss_tokens.Length == 3/* || sgis_tokens.Length < 3*/)
      {
        ss_tokens[2] = Replace.Preprocess(ss_tokens[2]);
        List<string> candidates = Replace.Parse(ss_tokens[2]);
        // ▼▼▼ プリプロセス ▼▼▼

        for (int jj = 0; jj < rowCount; jj++)
        {
          string gis = this.dataGridView全データ[6, jj].Value.ToString();// Replace.Preprocess(this.dataGridView全データ[6, jj].Value.ToString());
          if (gis != src)
          {
            bool isMatch = false;
            foreach (string cand in candidates)
            {
              string hole = ss_tokens[0] + " " + ss_tokens[1] + " " + cand;
              // ▲▲ Gisプリプロセス ▲▲
              string[] sgis_tokens = gis.Split(chars, StringSplitOptions.None); // 変換
              if (sgis_tokens.Length != 3) continue;
              if (sgis_tokens[1] != ss_tokens[1]) continue; // 子字判定で高速化。4.65秒から1.94秒になった
              sgis_tokens[2] = Replace.Preprocess(sgis_tokens[2]);
              List<string> gisCandidates = Replace.Parse(sgis_tokens[2]);
              // ▼▼ Gisプリプロセス ▼▼
              foreach (string gisCand in gisCandidates)
              {
                string holeGis = sgis_tokens[0] + " " + sgis_tokens[1] + " " + gisCand;
                if (hole == holeGis)
                {
                  // 「なし」の処理
                  if (int.Parse(this.dataGridView全データ[0, jj].Value.ToString()) >= 200000)
                  {
                  }
                  // 合筆の処理
                  else if (int.Parse(this.dataGridView全データ[0, jj].Value.ToString()) >= 100000)
                  {
                  }
                  else
                  {
                    this.dataGridView全データ[8, jj].Value = "1"; // 有効
                    this.dataGridView全データ[7, jj].Value = ckind; // 色品種
                  }
                  resultStatus = ResultStatus.Success;
                  isMatch = true;
                  break;
                }
              } // foreach (string gisCand in gisCandidates)
            } // foreach (string cand in candidates)
            if (!isMatch) continue; // 地名地番
          }  // for (j = 0; j < rowCount; j++)
        }
      }// if (ss_tokens.Length == 3/* || sgis_tokens.Length < 3*/)
      return resultStatus;
    }
    private void btn取得処理を行う_Click(object sender, EventArgs e)
    {
      // プロファイラコード
      //System.Diagnostics.Stopwatch stopWatch = new System.Diagnostics.Stopwatch();
      //stopWatch.Start();

      if (this.chk取得処理で全て処理する.Checked)
      {
        btn申込全てクリア_Click(null, null);
      }
      string[] excel地名地番 = SplitByNewLine(this.txtExcel地名地番.Text);
      string[] excelつや姫エサ米2回 = null;
      int count = excel地名地番.Length;
      if (!this.chkつや姫エサ米を無効.Checked)
      {
        excelつや姫エサ米2回 = SplitByNewLine(this.txtExcelつや姫エサ米2回.Text);
        count = Math.Min(count, excelつや姫エサ米2回.Length);
      }
      string result = "（入力件数一致）";
      // 「-1」は一番下の新しい行の分。減らさないと参照エラーになる。
      int rowCount = this.dataGridView全データ.Rows.Count - 1;
      int errRowCount = 0; // 取得した行のデータがエラーだった数。
      int adDuplicateCount = 0; // 取得した行が重複した数。
      int adUnknownCount = 0; // 取得した行の地名地番が見つからなかった数。
      int combinedCount = 0; // 合筆数。
      int markNoneCount = 0; // マークなし数。
      string adUnknownString = "", adDuplicateString = "", combinedString = "", markNoneString = "";
      string combinedStringForCheckSplitSemicolon = "";
      int successCount = 0;
      ResultStatus resultStatus;
      string[] ckindStrings = { "3回", "つや姫", "エサ米2回" };
      for (int i = 0; i < count; i++)
      {
        string exl地名地番 = excel地名地番[i];
        if (exl地名地番 == "地名地番" || exl地名地番 == "地名地番\t\t") continue;
        if (exl地名地番 == "" || exl地名地番 == "\t\t")
        {
          errRowCount++;
          continue;
        }
        exl地名地番 = exl地名地番.Replace("\t", " ");

        string ckind = "0";
        if (!this.chkつや姫エサ米を無効.Checked)
        {

          string exlつやエサ = excelつや姫エサ米2回[i];
          // 「tab」、「〇tab」、「tab〇」のいずれかとする
          if (exlつやエサ == "")
          {
            errRowCount++;
            continue;
          }

          if (exlつやエサ.Length == 1)
          {
            ;// ckind = "0";
          }
          else if (
            exlつやエサ.StartsWith("○") ||//記号
            exlつやエサ.StartsWith("◯") ||
            exlつやエサ.StartsWith("❍") ||
            exlつやエサ.StartsWith("⭘") ||
            exlつやエサ.StartsWith("〇")//漢数字○
            )
          {
            ckind = "1";
          }
          else
          {
            ckind = "2";
          }
        }

        int j;
        resultStatus = ResultStatus.None;
        //foreach (DataGridViewRow r in this.dataGridView全データ.Rows)
        for (j = 0; j < rowCount; j++)
        {
          // ここで例外が発生した場合は、data.txtの最後の行などに空行があるか確認すること。
          bool hit = this.chk置換処理を行う.Checked && 
            this.dataGridView全データ[6, j].Value.ToString() == "白井新田 藤井北 68" &&
            "白井新田 藤井北 67-4・68-4" == exl地名地番;
          if (!hit && (this.dataGridView全データ[6, j].Value.ToString() != exl地名地番)) continue; // 地名地番
          if (this.dataGridView全データ[8, j].Value.Equals("1"))
          {
            adDuplicateCount++;
            adDuplicateString += exl地名地番 + "\t(" + ckindStrings[int.Parse(ckind)] + ")" + Environment.NewLine;
            resultStatus = ResultStatus.Duplicate;
            break;
          }

          // 「なし」の処理
          if (int.Parse(this.dataGridView全データ[0, j].Value.ToString()) >= 200000)
          {
            markNoneCount++;
            markNoneString += exl地名地番 + Environment.NewLine;
          }
          // 合筆の処理
          else if (int.Parse(this.dataGridView全データ[0, j].Value.ToString()) >= 100000)
          {
            combinedCount++;
            string srcGis = this.dataGridView全データ[1, j].Value.ToString();
            combinedString += exl地名地番 + "\t(" + srcGis + 
              ", " + this.dataGridView全データ[2, j].Value.ToString() + ")" + Environment.NewLine;
            combinedStringForCheckSplitSemicolon += srcGis + ";";
          }
          else
          {
            this.dataGridView全データ[8, j].Value = "1"; // 有効
            this.dataGridView全データ[7, j].Value = ckind; // 色品種
          }

          resultStatus = ResultStatus.Success;
          //対象が複数件ある場合のため、breakせずに再度回す。
        } // for (j = 0; j < rowCount; j++)
        if (resultStatus == ResultStatus.Success)
        {
          successCount++;
        }
        else if (resultStatus == ResultStatus.None)
        {
          if (this.chk置換処理を行う.Checked)
            resultStatus = 置換処理(exl地名地番, rowCount, ckind);
          if (resultStatus == ResultStatus.None)
          {
            adUnknownCount++;
            adUnknownString += exl地名地番 + "\t(" + ckindStrings[int.Parse(ckind)] + ")" + Environment.NewLine;
          }
        }  // else if (resultStatus == ResultStatus.None)
        Flags.isSaveYet = true;
      } // for (int i = 0; i < count; i++)

      if (excelつや姫エサ米2回 != null && excelつや姫エサ米2回.Length > count)
      {
        result = "（つや姫、エサ米2回データが" + (excelつや姫エサ米2回.Length - count).ToString() + "件多い。）";
      }
      if (/*excel地名地番!=null &&*/ excel地名地番.Length > count)
      {
        result = "（地名地番データが" + (excel地名地番.Length - count).ToString() + "件多い。）";
      }
      this.lbl取得処理結果.Text = "取得結果：" + count +"件処理し、" + successCount + "件成功" + 
        result + "無効行:" + errRowCount + "件";
      this.lbl地名地番不明.Text = "地名地番不明：" + adUnknownCount + "件";
      this.txt地名地番不明.Text = adUnknownString;
      this.lbl地名地番重複.Text = "地名地番重複：" + adDuplicateCount + "件";
      this.txt地名地番重複.Text = adDuplicateString;
      this.lblマークなし.Text = "マークなし：" + markNoneCount + "件";
      this.txtマークなし.Text = markNoneString;
      this.lbl合筆.Text = "合筆：" + combinedCount + "件";
      this.txt合筆.Text = combinedString;

      // 合筆の片割れを元地番と突き合わせする。
      string[] combinedSplit = combinedStringForCheckSplitSemicolon.Split(';');
      this.txt合筆元データなし.Text = ""; //202230608追加
      foreach (string cmb in combinedSplit)
      {
        int i;
        for (i = 0; i < rowCount; i++)
        {
          if (int.Parse(this.dataGridView全データ[0, i].Value.ToString()) >= 100000) continue;
          if (this.dataGridView全データ[6, i].Value.ToString() == cmb) break;
        }
        if (i == rowCount)
        {
          this.txt合筆元データなし.Text += cmb + Environment.NewLine;
        }
      }

      // プロファイラコード
      //stopWatch.Stop();
      //TimeSpan ts = stopWatch.Elapsed;
      //string elapsedTime = String.Format("{0:00}.{1:00}", ts.Seconds, ts.Milliseconds / 10);
      //MessageBox.Show("RunTime " + elapsedTime);

      if (this.chk取得処理で全て処理する.Checked)
      {
        btn申込を保存する_Click(null, null);
      }
    }//private void btn取得処理を行う_Click(object sender, EventArgs e)

    private void chk取得処理で全て処理する_CheckedChanged(object sender, EventArgs e)
    {
      if (this.chk取得処理で全て処理する.Checked)
      {
        this.btn申込全てクリア.Enabled = false;
        this.btn申込を保存する.Enabled = false;
      }
      else
      {
        this.btn申込全てクリア.Enabled = true;
        this.btn申込を保存する.Enabled = true;
      }
    }

    private void btn申込全てクリア_Click(object sender, EventArgs e)
    {
      for (int i = 0; i < this.dataGridView全データ.RowCount; i++)
      {
        this.dataGridView全データ[8, i].Value = "0";
      }
      Flags.isSaveYet = true;
    }

    private void btn申込を保存する_Click(object sender, EventArgs e)
    {
      StringBuilder sb = new StringBuilder();
      bool isFirst1 = true;
      foreach (DataGridViewRow r in this.dataGridView全データ.Rows)
      {
        if (r.IsNewRow) continue;
        if (isFirst1)
        {
          isFirst1 = false;
        }
        else
        {
          sb.Append(Environment.NewLine);
        }
        bool isFirst2 = true;
        foreach (DataGridViewCell c in r.Cells)
        {
          if (isFirst2)
          {
            isFirst2 = false;
          }
          else
          {
            sb.Append(";");
          }
          sb.Append(c.Value);
        } // foreach
      } // foreach

      System.IO.StreamWriter writer = new System.IO.StreamWriter("data.txt", false, Encoding.UTF8);
      writer.Write(sb);
      writer.Close();
      MessageBox.Show("data.txt を保存しました。");
      Flags.isSaveYet = false;
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
      if (Flags.isSaveYet)
      {
        if (MessageBox.Show("まだ申込データを保存していません。\r\n終了しますか？","ヘリ地図作成", MessageBoxButtons.YesNo) == DialogResult.No)
        {
          e.Cancel = true;
        }
      }
    }

    private void chk塗りつぶしマーク(object sender, EventArgs e)
    {
      Flags.isDrawThreeTime = this.chk3回.Checked;
      Flags.isDrawTsuya = this.chkつや姫.Checked;
      Flags.isDrawTwoTime = this.chk2回.Checked;
      Flags.isDrawNoneApplication = this.chk申込なし.Checked;
      Flags.isDrawAdBlank = this.chk地番データなし.Checked;
    }

    private void chk表示テキスト(object sender, EventArgs e)
    {
      if (sender == this.chkid下4桁)
      {
        Flags.isTextoutLast4Digits = this.chkid下4桁.Checked;
      }
      else if (sender == this.chk大字)
      {
        Flags.isTextoutOaza = this.chk大字.Checked;
      }
      else if (sender == this.chk字)
      {
        Flags.isTextoutAza = this.chk字.Checked;
      }
      else if (sender == this.chk地番)
      {
        Flags.isTextoutChiban = this.chk地番.Checked;
      }
      else if (sender == this.chk表示地番)
      {
        Flags.isTextoutDispChiban = this.chk表示地番.Checked;
      }
      else
      {
        MessageBox.Show("Error: [chk表示テキスト]チェック不明");
      }
    }

    private void dataGridView全データ_CellValueChanged(object sender, DataGridViewCellEventArgs e)
    {
      Flags.isSaveYet = true;
    }

    private void chk地図に地区時刻表示_CheckedChanged(object sender, EventArgs e)
    {
      Flags.is地図に地区時刻表示 = this.chk地図に地区時刻表示.Checked;
    }

    private void btn印刷する_Click(object sender, EventArgs e)
    {
      if (this.picImg.Image == null)
      {
        MessageBox.Show("まだ画像が準備でいていません。\n[メイン]タブで[地図画像を作る]をクリックしてください。");
        return;
      }
      Print.DoPrint();
    }

    private void btn印刷設定_Click(object sender, EventArgs e)
    {
      if (Print.ShowPageDialog())
      {
        WritePrintSetting();
        UpdatePrintPreview();
      }
    }

    private void WritePrintSetting()
    {
      this.lblサイズ.Text =
        "サイズ：" + Print.PageSettings.PaperSize.PaperName;
      this.lbl給紙方法.Text =
        "給紙方法：" + Print.PageSettings.PaperSource.SourceName;
      this.lbl印刷方向.Text =
        "印刷方向：" + (Print.PageSettings.Landscape ? "横" : "縦");
      this.lbl余白.Text =
        "余白：左" + Print.MarginToMillimetre(Print.PageSettings.Margins.Left) +
        ", 上" + Print.MarginToMillimetre(Print.PageSettings.Margins.Top) +
        ", 右" + Print.MarginToMillimetre(Print.PageSettings.Margins.Right) +
        ", 下" + Print.MarginToMillimetre(Print.PageSettings.Margins.Bottom);
    }

    private void btn入力クリア_Click(object sender, EventArgs e)
    {
      this.txtExcelつや姫エサ米2回.Text = "";
      this.txtExcel地名地番.Text = "";
    }

    private void txtDatatxt再度読込_Click(object sender, EventArgs e)
    {
      Form1_Load(null, null);
    }

    private void btnGitHubを開く_Click(object sender, EventArgs e)
    {
      System.Diagnostics.Process.Start("https://github.com/gitcpage/GoogleMapTool/tree/main/HeliMark");
    }

    private void chk1ha毎に線を引く_CheckedChanged(object sender, EventArgs e)
    {
      Flags.is1ha毎に線を引く = this.chk1ha毎に線を引く.Checked;
    }
  }
}
