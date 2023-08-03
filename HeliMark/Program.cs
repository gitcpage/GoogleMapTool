using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeliMark
{
  static public class Program
  {
    public enum Next { Form1, DataForm, Exit };
    /// <summary>
    /// アプリケーションのメイン エントリ ポイントです。
    /// </summary>
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      for (;;)
      {
        Next next = s_Next;
        s_Next = Next.Exit;
        switch (next)
        {
          case Next.Form1:
            Application.Run(new Form1());
            break;
          case Next.DataForm:
            Application.Run(new DataForm());
            break;
          default:
            return;
        }
      }
    }
    static public Next s_Next = Next.Form1;// DataForm;
  }
}
