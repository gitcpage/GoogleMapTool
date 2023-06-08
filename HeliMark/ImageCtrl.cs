using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms; // for MessageBox.Show

namespace HeliMark
{
  class ImageCtrl
  {
    Bitmap m_img;
    int m_width, m_height;

    SolidBrush m_redBrush, m_blueBrush, m_yellowBrush, m_greenBrush, m_whiteBrush;
    Pen m_redPen, m_bluePen, m_yellowPen, m_greenPen, m_blackPen, m_haPen;
    SolidBrush m_strBrush;
    Font m_font;
    StringFormat m_strFmtCenter;
    StringFormat m_strFmtLeft;

    Graphics m_g;

    MapSetting m_mapSetting;

    public ImageCtrl()
    {
      m_g = null;
      // 不透明度は51(=255*2/10)
      m_redBrush = new SolidBrush(Color.FromArgb(51, 255, 50, 50));
      m_blueBrush = new SolidBrush(Color.FromArgb(101, 50, 150, 255));
      m_yellowBrush = new SolidBrush(Color.FromArgb(51, 255, 255, 50));
      m_greenBrush = new SolidBrush(Color.FromArgb(51, 0, 255, 0));
      m_whiteBrush = new SolidBrush(Color.FromArgb(51, 255, 255, 255));
      // 不透明度は153(=255*6/10)
      m_redPen = new Pen(Color.FromArgb(153, 255, 50, 50));
      m_bluePen = new Pen(Color.FromArgb(153, 50, 150, 255));
      m_yellowPen = new Pen(Color.FromArgb(153, 255, 255, 50));
      m_greenPen = new Pen(Color.FromArgb(153, 0, 255, 0));
      m_blackPen = new Pen(Color.FromArgb(153, 0, 0, 0));

      m_haPen = new Pen(Color.FromArgb(153, 255, 255, 255), 3.0f);

      m_strBrush = new SolidBrush(Color.Black);
      m_font = new Font("メイリオ", 10.0f);
      m_strFmtCenter = new StringFormat();
      m_strFmtCenter.Alignment = StringAlignment.Center; // X軸中央
      m_strFmtCenter.LineAlignment = StringAlignment.Center; // Y軸中央
      m_strFmtLeft = new StringFormat();
      m_strFmtLeft.Alignment = StringAlignment.Near; // X軸左
      m_strFmtLeft.LineAlignment = StringAlignment.Near; // Y軸上
    }
    ~ImageCtrl()
    {
      m_g.Dispose();

      m_redBrush.Dispose();
      m_blueBrush.Dispose();
      m_yellowBrush.Dispose();
      m_greenBrush.Dispose();
      m_whiteBrush.Dispose();
      m_redPen.Dispose();
      m_bluePen.Dispose();
      m_yellowPen.Dispose();
      m_greenBrush.Dispose();
      m_whiteBrush.Dispose();

      m_strBrush.Dispose();
      m_font.Dispose();
      m_strFmtCenter.Dispose();
      m_strFmtLeft.Dispose();
    }
    public bool Init(string kImgPath)
    {
      try
      {
        m_img = new Bitmap(kImgPath);
      }
      catch(Exception)
      {
        return false;
      }
      m_width = m_img.Width;
      m_height = m_img.Height;

      if (m_g != null)
      {
        m_g.Dispose();
      }
      m_g = Graphics.FromImage(m_img);
      return true;
    }
    private bool IsMachinaka(double lngLen, double latLen)
    {
      return lngLen < 0.01 && latLen < 0.007; //町中は狭いことを利用して判定する。
    }
    private bool IsHirono()
    {
      return this.m_width == 1888 && this.m_height == 1345; //広野の場合
    }
    public void PaintMark(MapSetting kMapSetting, Data[] kDataArray, string district)
    {
      if (Flags.is地図に地区時刻表示)
      {
        m_g.DrawString(district, m_font, m_strBrush, 0, 0, m_strFmtLeft);
        m_g.DrawString(DateTime.Now.ToString(), m_font, m_strBrush, 0, 15, m_strFmtLeft);
      }
      double oX = double.Parse(kMapSetting.左基準);
      double lenX = oX - double.Parse(kMapSetting.右基準);
      double oY = double.Parse(kMapSetting.上基準);
      double lenY = oY - double.Parse(kMapSetting.下基準);

      double oLng = double.Parse(kMapSetting.左経度);
      double lenLng = oLng - double.Parse(kMapSetting.右経度);
      double oLat = double.Parse(kMapSetting.上緯度);
      double lenLat = oLat - double.Parse(kMapSetting.下緯度);

      bool isEven = false;
      int prevOx = 0, prevOy = 0, prevDispLen = 0;
      int errCkindCount = 0;

      // 町中は倍率が2倍になっている。
      double r = 9.0;
      if (IsMachinaka(lenLng, lenLat))
      {
        r = 18.0;
      }
      else if (IsHirono()) //広野の場合
      {
        r = 6.0;
      }

      Data.Init8HaLine();
      foreach (Data d in kDataArray)
      {
        int oy = (int)(oY + (d.lat - oLat) * lenY / lenLat);
        int ox = (int)(oX + (d.lng - oLng) * lenX / lenLng);
        double w = d.width;
        double h = d.height;

        double ang = -Math.PI * d.arcdegree / 180;
        int ax = (int)(ox + r * (Math.Cos(ang) * w - Math.Sin(ang) * h));
        int ay = (int)(oy + r * (Math.Sin(ang) * w + Math.Cos(ang) * h));
        int bx = (int)(ox + r * (Math.Cos(ang) * -w - Math.Sin(ang) * h));
        int by = (int)(oy + r * (Math.Sin(ang) * -w + Math.Cos(ang) * h));
        int cx = (int)(ox + r * (Math.Cos(ang) * -w - Math.Sin(ang) * -h));
        int cy = (int)(oy + r * (Math.Sin(ang) * -w + Math.Cos(ang) * -h));
        int dx = (int)(ox + r * (Math.Cos(ang) * w - Math.Sin(ang) * -h));
        int dy = (int)(oy + r * (Math.Sin(ang) * w + Math.Cos(ang) * -h));

        Point point1 = new Point(ax, ay);
        Point point2 = new Point(bx, by);
        Point point3 = new Point(cx, cy);
        Point point4 = new Point(dx, dy);
        Point[] curvePoints =
               {
                 point1,
                 point2,
                 point3,
                 point4 };
        SolidBrush brush;
        Pen pen;
        if (d.gislandad == "")
        {
          brush = m_whiteBrush;
          pen = m_blackPen;
        }
        else if (d.enable == 0)
        {
          brush = m_greenBrush;
          pen = m_greenPen;
        }
        else
        {
          switch (d.ckind)
          {
            case 0:
              brush = m_redBrush;
              pen = m_redPen;
              break;
            case 1:
              brush = m_blueBrush;
              pen = m_bluePen;
              break;
            case 2:
              brush = m_yellowBrush;
              pen = m_yellowPen;
              break;
            default: // 色指定がエラー出る場合
              errCkindCount++;
              continue;
          }
        }
        
        m_g.FillPolygon(brush, curvePoints);
        if (Flags.is1ha毎に線を引く)
        {
          Point[] haLines = d.Point2HaLines(curvePoints);
          for (int i = 0; i < haLines.Length; i += 2)
          {
            m_g.DrawLine(m_haPen, haLines[i], haLines[i + 1]);
          }
        }
        m_g.DrawPolygon(pen, curvePoints);

        // 地番表示の位置補正
        int y = oy;
        int offset = d.disp.Length > 4 ? 15 : 10;
        //int xThreshold = d.disp.Length > 4 ? 25 : 15;
        if (y + 15 > prevOy && 
          y - 15 < prevOy &&
          /*ox+30 > prevOx &&
          ox-30 < prevOx &&*/
          d.disp.Length > 1 &&
          prevDispLen > 1)
        {
          if (isEven/*(isEven && prevOy < oy)|| (!isEven && prevOy > oy)*/)
          {
            y = oy - offset - (prevOy - oy) / 6;
          }
          else
          {
            y = oy + offset + (prevOy - oy) / 6;
          }
        }

        string dispText = "";
        if (Flags.isTextoutLast4Digits)
        {
          string s = d.id.ToString();
          int len = s.Length;
          if (len >= 4)
            dispText += s.Substring(len - 4, 4);
        }
        string[] gisad = d.gislandad.Split(' ');
        if (Flags.isTextoutOaza && gisad.Length > 0) dispText += gisad[0];
        if (Flags.isTextoutAza && gisad.Length > 1) dispText += gisad[1];
        if (Flags.isTextoutChiban && gisad.Length > 2) dispText += gisad[2];

        if (Flags.isTextoutDispChiban) dispText += d.disp; // 表示用地番
        m_g.DrawString(dispText, m_font, m_strBrush, ox, y, m_strFmtCenter);
        prevDispLen = d.disp.Length;
        prevOx = ox; prevOy = oy;
        isEven = !isEven;
      } // foreach

      if (errCkindCount > 0)
      {
        MessageBox.Show("ckindエラーが" + errCkindCount + "件ありました。");
      }

      m_mapSetting = kMapSetting; // XyToLatLng()のため。
    }

    public void XyToLatLng(int x, int y, out double lat, out double lng)
    {
      // PrintMarkからのコピペ
      double oX = double.Parse(m_mapSetting.左基準);
      double lenX = oX - double.Parse(m_mapSetting.右基準);
      double oY = double.Parse(m_mapSetting.上基準);
      double lenY = oY - double.Parse(m_mapSetting.下基準);

      double oLng = double.Parse(m_mapSetting.左経度);
      double lenLng = oLng - double.Parse(m_mapSetting.右経度);
      double oLat = double.Parse(m_mapSetting.上緯度);
      double lenLat = oLat - double.Parse(m_mapSetting.下緯度);
      //int oy = (int)(oY + (d.lat - latO) * lenY / latLen);
      //int ox = (int)(oX + (d.lng - lngO) * lenX / lngLen);
      lat = oLat + (y - oY) * lenLat / lenY;
      lng = oLng + (x - oX) * lenLng / lenX;
    }
    public Bitmap Image
    {
      get
      {
        return m_img;
      }
    }
  }
}
