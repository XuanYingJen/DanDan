using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class GlobalVar
    {
        public static string image_dir = @"C:\Users\winni\OneDrive\Desktop\資策會\期中個人專題\images"; //圖檔路徑
        public static string strDBConnectionString = "";
        public static List<ArrayList> list訂購品項資料集合 = new List<ArrayList>();
        public static bool is登入成功 = false;
        public static int 使用者ID = 0;
        public static string 使用者名稱 = "";
        public static string 使用者電話 = "";
        public static int 使用者權限 = 0;
    }
}
