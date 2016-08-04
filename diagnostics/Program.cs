using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//自己加入的命名空間
using System.Diagnostics;

namespace diagnostics
{
    class Program
    {
        static void Main(string[] args)
        {
            //第一個 利用debug類別來列印偵錯資訊
            Debug.Listeners.Add(new TextWriterTraceListener(Console.Out)); // 1.
            Debug.AutoFlush = true; // 2.當有寫入文字，直接寫入目標(若不想頻繁寫入，可以在最後使用 Debug.Flush(); 輸出資料 )
            Debug.Indent(); // 3.縮排
            Debug.WriteLine(" == DEBUG 起點 == ");// 4.紀錄資訊
            Debug.WriteLine(" == DEBUG 終點 == ");
            Debug.Unindent(); // 5.解除縮排

        }
    }
}
