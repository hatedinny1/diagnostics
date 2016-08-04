using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//自己加入的命名空間
using System.Diagnostics; // 偵錯用
using System.IO; //寫檔案用

namespace diagnostics
{
    class Program
    {
        static void Main(string[] args)
        {
            //第一個 利用debug類別來列印偵錯資訊
            Debug.Listeners.Add(new TextWriterTraceListener(Console.Out)); // 1.
            //Debug.AutoFlush = true; // 2.當有寫入文字，直接寫入目標(若不想頻繁寫入，可以在最後使用 Debug.Flush(); 輸出資料 )
            Debug.Indent(); // 3.縮排
            Debug.WriteLine(" == DEBUG 起點 == ");// 4.紀錄資訊
            Debug.WriteLine(" == DEBUG 終點 == ");
            Debug.Unindent(); // 5.解除縮排


            //第二個 利用Trace類別搭配寫log檔案來記錄錯誤
            Trace.Listeners.Add(new TextWriterTraceListener(File.CreateText("TraceOut.txt"))); // 1. 寫入文字檔，目錄會在專案的bin目錄下的Release資料夾內
            Trace.WriteLine("=============================");
            Trace.Indent();// 2.縮排
            var condition = true;            
            Trace.WriteLineIf(condition, " toggle condition 1"); //3.根據條件做顯示
            Trace.WriteLineIf(!condition, " toggle condition 2");
            Trace.Unindent();// 4.解除縮排
            Trace.WriteLine("=============================");
            Trace.Flush();// 5.自己控制寫檔案時間點
            Trace.WriteLine("Not show !!");
        }
    }
}
