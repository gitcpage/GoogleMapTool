using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeliMark
{
  internal class Replace
  {
    public static string Preprocess(string src)
    {
      src = src.Replace("（一筆）", "");
      src = src.Replace("‘", "");
      src = src.Replace("12枚", "");
      src = src.Replace("3枚", "");
      src = src.Replace("2枚", "");
      src = src.Replace(" ", "");

      src = src.Replace('（', '(');
      src = src.Replace('）', ')');
      src = src.Replace(',', '・');
      src = src.Replace('１', '1');
      src = src.Replace('２', '2');
      src = src.Replace('３', '3');
      src = src.Replace('４', '4');
      src = src.Replace('５', '5');
      src = src.Replace('６', '6');
      src = src.Replace('７', '7');
      src = src.Replace('８', '8');
      src = src.Replace('９', '9');
      src = src.Replace('０', '0');

      src = src.Replace(".-", "-");
      src = src.Replace("，", "・");
      src = src.Replace(".", "・");

      return src;
    }

    static List<string> m_candidates;
    public static void Print(List<int> level, int min, int max)
    {
      string before = "";
      foreach (int levelItem in level)
      {
        before += levelItem + " ";
      }
      for (int i = min; i <= max; i++)
      {
        m_candidates.Add(before + i.ToString());
      }
    }
    public static int IntParse(string str)
    {
      for (int i = Math.Min(4, str.Length); i > 0; i--)
      {
        string s = str.Substring(0, i);
        int v;
        if (int.TryParse(s, out v))
        {
          return v;
        }
      }
      return -1;
    }

    public static List<string> Parse(string s)
    {
      m_candidates = new List<string>();
      List<int> levels = new List<int>();
      bool inBracket = false;
      int before = -1;
      while (true)
      {
        if (s == "")
        {
          if (before != -1)
          {
            Print(levels, before, before);
          }
          return m_candidates;
        }
        int i;

        if (s[0] == '0')
        {
          ;
        }
        else if (s[0] == '-' || s[0] == '-')
        { // 「-」を区切り文字ではなく、マイナスと解釈されることがあるため IntParse() より先に処理する。
          levels.Add(before);
          before = -1;
        }
        else if (s[0] == '～')
        {
          ;
        }
        else if (s[0] == '(')
        {
          inBracket = true;
        }
        else if (s[0] == ')')
        {
          if (before != -1) Print(levels, before, before);
          before = -1;
          inBracket = false;
        }
        else if (s[0] == '・')
        {
          if (inBracket)
          {
            Print(levels, before, before);
          }
          else
          {
            if (before != -1)
            {
              Print(levels, before, before);
              before = -1;
            }
            levels.Clear();
          }
        }
        else if ((i = IntParse(s)) != -1)
        { // 数値
          int digit = i.ToString().Length;
          s = s.Remove(0, digit);
          if (before != -1)
          {
            Print(levels, before, i);
            before = -1;
          }
          else
          {
            before = i;
          }
          continue;
        }
        else
        {
          //Error
          return m_candidates;
        }
        s = s.Remove(0, 1);
      }
    }
  }
}
