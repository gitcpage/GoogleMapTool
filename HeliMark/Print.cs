using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing.Printing; // PrintDocument
using System.Windows.Forms; // PageSetupDialog, MessageBox

namespace HeliMark
{
  class Print
  {
    static public PageSetupDialog s_formPageSetupDialog; // PageSettings プロパティを持つ
    static private PrintDocument s_printDocument = null;
    // PageSettings は s_formPageSetupDialog.PageSettings からアクセスする。

    static public PageSettings PageSettings
    {
      get
      {
        return s_formPageSetupDialog.PageSettings;
      }
    }
    static public PrintDocument PrintDoc
    {
      get
      {
        return s_printDocument;
      }
    }

    static public void Init(PageSetupDialog psd)
    {
      if (s_printDocument == null)
      {
        s_printDocument = new PrintDocument();
        PrinterSettings.PaperSizeCollection psc = s_printDocument.PrinterSettings.PaperSizes;
        foreach (PaperSize pagerSize in psc)
        {
          if (pagerSize.Kind == PaperKind.A3)
          {
            s_printDocument.DefaultPageSettings.PaperSize = pagerSize;
          }
        }
        s_formPageSetupDialog = psd;
        s_formPageSetupDialog.PageSettings = s_printDocument.DefaultPageSettings;
        Margins m = s_formPageSetupDialog.PageSettings.Margins;
        m.Left = m.Top = m.Right = m.Bottom = 35;  // 35:8.8mm 40:10.1mm
      }
      else
      {
        MessageBox.Show("Error: プリンタ処理で初期化を２回以上呼び出しました。");
      }
    }

    static public bool ShowPageDialog(bool doShowMessage = false)
    {
      //https://dobon.net/vb/dotnet/graphics/pagesetupdialog.html
      PrintDocument pd = s_printDocument;// new PrintDocument();

      PageSetupDialog psd = s_formPageSetupDialog;// new PageSetupDialog();
      psd.Document = pd;
      Margins m = s_formPageSetupDialog.PageSettings.Margins;

      // ここら辺の「m.Left * 127 / 50」などのコードは
      // ダイアログを表示すると値が変になるため補正している。
      Margins oldm = (Margins)m.Clone();
      m.Left = m.Left * 127 / 50;
      m.Top = m.Top * 127 / 50;
      m.Right = m.Right * 127 / 50;
      m.Bottom = m.Bottom * 127 / 50;

      if (psd.ShowDialog() != DialogResult.OK)
      {
        s_formPageSetupDialog.PageSettings.Margins = oldm;
        return false;
      }

      if (!doShowMessage) return true;

      MessageBox.Show("[OK]がクリックされました。");

      PageSettings ps = psd.PageSettings;
      string s;

      s = ps.PaperSize.ToString() + Environment.NewLine +
        ps.PaperSize.PaperName + Environment.NewLine +
        ps.PaperSize.Width.ToString() + Environment.NewLine +
        ps.PaperSource.SourceName;
      MessageBox.Show(s, "PaperSize 用紙設定");

      s = ps.Margins.ToString() + Environment.NewLine +
        (ps.Margins.Left*127/50).ToString();
      MessageBox.Show(s, "Margins 余白");

      s = ps.Bounds.ToString() + Environment.NewLine +
        ps.Bounds.Left;
      MessageBox.Show(s, "Bounds 境界");

      s = ps.PrintableArea.ToString() + Environment.NewLine +
        ps.PrintableArea.Left.ToString();
      MessageBox.Show(s, "PrintableArea 印刷領域");

      s = ps.Landscape.ToString();
      MessageBox.Show(s, "Landscape 印刷方向（Falseが縦）");

      return true;
    }

    static public string MarginToMillimetre(int marginValue)
    {
      return (((double)marginValue * 127.0f / 500.0f)).ToString();
    }

    // 縦印刷に必要な値を得る。
    static public void SetVerticalValues(System.Drawing.Image img,
      out int left, out int top, out int width, out int height)
    {
      System.Drawing.Printing.Margins m = Print.PageSettings.Margins;
      int pw = Print.PageSettings.PaperSize.Width; // page width
      int ph = Print.PageSettings.PaperSize.Height;
      int piw = pw - m.Left * 2; // page image width
      int pih = ph - m.Top * 2;
      int opiw = piw; // origin page image width
      int opih = pih;
      int increaseMarginW = 0; // w: width
      int increaseMarginH = 0;
      int iw = img.Width;
      int ih = img.Height;
      if (iw * pih > ih * piw)
      {
        // 横が限界まで長い場合の処理。
        pih = ih * piw / iw;
        increaseMarginH = (opih - pih) / 2;
      }
      else
      {
        // 印刷方向として、ここにきてはならない。
        piw = iw * pih / ih;
        increaseMarginW = (opiw - piw) / 2;
      }
      left = m.Left + increaseMarginW;
      top = m.Top + increaseMarginH;
      width = piw;
      height = pih;
    }

    // 横印刷に必要な値を得る。
    static public void SetHorizonValues(System.Drawing.Image img,
      out int left, out int top, out int width, out int height)
    {
      System.Drawing.Printing.Margins m = Print.PageSettings.Margins;
      int pw = Print.PageSettings.PaperSize.Height; // page width
      int ph = Print.PageSettings.PaperSize.Width;
      int piw = pw - m.Left * 2; // page image width
      int pih = ph - m.Top * 2;
      int opiw = piw; // origin page image width
      int opih = pih;
      int increaseMarginW = 0; // w: width
      int increaseMarginH = 0;
      int iw = img.Width;
      int ih = img.Height;
      if (iw * pih > ih * piw)
      {
        // 横が限界まで長い場合の処理。ここにきてはならない。
        pih = ih * piw / iw;
        increaseMarginH = (opih - pih) / 2;
      }
      else
      {
        piw = iw * pih / ih;
        increaseMarginW = (opiw - piw) / 2;
      }
      left = m.Left + increaseMarginW;
      top = m.Top + increaseMarginH;
      width = piw;
      height = pih;
    }
    static public void DoPrint()
    {
      // https://dobon.net/vb/dotnet/graphics/printdialog.html
      PrintDialog pdlg = new PrintDialog();
      pdlg.Document = PrintDoc;
      if (pdlg.ShowDialog() == DialogResult.OK)
      {
        PrintDoc.Print();
      }
    }
  }
}
