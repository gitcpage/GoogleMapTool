using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeliMark
{
  class MapSetting
  {
    public string 地区;
    public string 画像;
    public string 横サイズ;
    public string 縦サイズ;
    public string 左基準;
    public string 左経度;
    public string 上基準;
    public string 上緯度;
    public string 右基準;
    public string 右経度;
    public string 下基準;
    public string 下緯度;
    public MapSetting(string[] s)
    {
      地区 = s[0];
      画像 = s[1];
      横サイズ = s[2];
      縦サイズ = s[3];
      左基準 = s[4];
      左経度 = s[5];
      上基準 = s[6];
      上緯度 = s[7];
      右基準 = s[8];
      右経度 = s[9];
      下基準 = s[10];
      下緯度 = s[11];
    }
  }
}
