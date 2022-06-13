using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeliMark
{
  class Flags
  {
    // グリッド更新でもtrueになるので、Form1_Load()の最後でfalseにすること。
    public static bool isSaveYet = false;

    public static bool isDrawThreeTime = true;
    public static bool isDrawTsuya = true;
    public static bool isDrawTwoTime = true;
    public static bool isDrawNoneApplication = false;
    public static bool isDrawAdBlank = false;

    public static bool isTextoutLast4Digits = false;
    public static bool isTextoutOaza = false;
    public static bool isTextoutAza = false;
    public static bool isTextoutChiban = false;
    public static bool isTextoutDispChiban = true;

    public static bool is地図に地区時刻表示 = true;
  }
}
