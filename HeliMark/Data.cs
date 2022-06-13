using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace HeliMark
{
  // id, 緯度, 経度, 幅, 高さ, 角度, 地名地番, 色品種, 有効, 表示地番
  class Data
  {
    enum CKind // todo:コード位置検証
    {
      Three = 0,
      Tsuya = 1,
      Two = 2
    }
    public int id;
    public double lat;
    public double lng;
    public double width;
    public double height;
    public double arcdegree;
    public string gislandad;
    public int ckind;//0:red, 1:blue, 2:yellow
    public int enable;
    public string disp;
    public Data()
    {
      id = 0;
      lat = 0;
      lng = 0;
      width = 0;
    }
    public static void PrintDataGridView(Data[] src, DataGridView dgv)
    {
      dgv.Rows.Clear();
      foreach(Data d in src)
      {
        dgv.Rows.Add(d.id, d.lat, d.lng, d.width, d.height, d.arcdegree, d.gislandad,
          d.ckind, d.enable, d.disp);
      }
    }
    public static Data[] Make(DataGridView dgv, out string labelDataFilter, ListBox lstFilter)
    {
      int count = dgv.Rows.Count;
      Data[] dArray = new Data[count];
      int i, daIdx = 0, invalidCount = 0;
      string err = null;
      string idStringFilter = (lstFilter.SelectedIndex+1).ToString();
      for (i = 0; i < count; i++)
      {
        try
        {
          if (dgv[0, i].Value == null) continue;
          string idString = dgv[0, i].Value.ToString();
          if (idString == "") continue;
          if (int.Parse(idString) >= 100000) continue; //合筆またはマークなし
          if (!idString.StartsWith(idStringFilter)) continue;

          int ckind = int.Parse(dgv[7, i].Value.ToString());
          int enable = int.Parse(dgv[8, i].Value.ToString());
          string gislandad = dgv[6, i].Value.ToString();
          if (gislandad == "")
          {
            // 地名地番が空白で、表示マーク[地番データなし]✓なし
            if (!Flags.isDrawAdBlank) continue;
          }
          else
          {
            if (enable == 0)
            {
              invalidCount++;
              if (!Flags.isDrawNoneApplication)
              {
                continue;
              }
            }
            else
            {
              if ((ckind == 0) && !Flags.isDrawThreeTime) continue;
              if ((ckind == 1) && !Flags.isDrawTsuya) continue;
              if ((ckind == 2) && !Flags.isDrawTwoTime) continue;
            }
          }
          dArray[daIdx] = new Data();
          dArray[daIdx].id = int.Parse(dgv[0, i].Value.ToString());
          dArray[daIdx].lat = double.Parse(dgv[1, i].Value.ToString());
          dArray[daIdx].lng = double.Parse(dgv[2, i].Value.ToString());
          dArray[daIdx].width = double.Parse(dgv[3, i].Value.ToString());
          dArray[daIdx].height = double.Parse(dgv[4, i].Value.ToString());
          dArray[daIdx].arcdegree = double.Parse(dgv[5, i].Value.ToString());
          dArray[daIdx].gislandad = gislandad;// dgv[6, i].Value.ToString();
          dArray[daIdx].ckind = ckind;// int.Parse(dgv[7, i].Value.ToString());
          dArray[daIdx].enable = enable;// int.Parse(dgv[8, i].Value.ToString());
          dArray[daIdx].disp = dgv[9, i].Value.ToString();
          daIdx++;
        }
        catch(Exception e)
        {
          err = e.Message;
          break;
        }
      }
      Array.Resize(ref dArray, daIdx);


      string filterText = lstFilter.SelectedItem.ToString() + "(" + idStringFilter + ")";
      string t = " 取得時:" + DateTime.Now.ToString("HH時mm分ss秒");
      if (err == null)
      {
        labelDataFilter = "データフィルタ[" + filterText + "]: " + 
          count + "件中" + daIdx + "件マークしました。（申込なし(緑) " + invalidCount + "件）" + t;
      }
      else
      {
        labelDataFilter = "データフィルタ[" + filterText + "]: " + 
          err + " エラーが発生しました。" + i + "件目" + t;
      }
      
      return dArray;
    }
  }
  //static Filter
}
