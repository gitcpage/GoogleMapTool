using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeliMark
{
  internal class FormLib
  {
    static internal string[] SplitByNewLine(string str, bool doWarning = false)
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
    static internal string[] LoadTextByPath(string path)
    {
      //Encoding sjisEnc = Encoding.GetEncoding("Shift_JIS");
      System.IO.StreamReader reader = null;
      try
      {
        reader = new System.IO.StreamReader(path, Encoding.UTF8);
      }
      catch (System.IO.FileNotFoundException)
      {
        MessageBox.Show(path + " ファイルを開けません。プログラムを終了します。", "Error",
          MessageBoxButtons.OK, MessageBoxIcon.Error);
        Environment.Exit(-1);
      }
      string s = reader.ReadToEnd();
      reader.Close();

      return SplitByNewLine(s, true);
    }
  }
}
