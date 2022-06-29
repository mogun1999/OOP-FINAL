using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Entities;
using Services;
namespace OOP_FINAL.Pages
{
    public class ThemMatHangModel : PageModel
    {
        public string Chuoi { get; set; }
        public int mahang { get; set; }
        public string tenhang { get; set; }
        public bool hansd { get; set; }
        public string ctysx { get; set; }
        public int namsx { get; set; }
        public int loai { get; set; }

        private IXuLyMatHang xuLyMatHang;
        public ThemMatHangModel()
        {
            xuLyMatHang = new XuLyMatHang();
        }
        public void onGet()
        {
            Chuoi = string.Empty;
        }
        public void onPost()
        {
            try
            {
                MatHang mh = new MatHang(mahang, tenhang, hansd, ctysx, namsx, loai);
                var kq = xuLyMatHang.ThemMatHang(mh);
                if(kq.IsSuccess)
                {
                    Chuoi = "Luu tru thanh cong"; 
                }
                else
                {
                    Chuoi = "Luu tru ko thanh cong";
                }    
            }
            catch (Exception ex)
            {
                Chuoi = ex.Message;
            }
        }
    }
}

