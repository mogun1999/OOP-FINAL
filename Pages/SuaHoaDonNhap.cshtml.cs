using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Services;
using Entities;

namespace OOP_FINAL.Pages
{
    public class SuaHoaDonNhapModel : PageModel
    {
        public string Chuoi { get; set; }
        public int mahd { get; set; }
        public int mahang { get; set; }
        public int sl { get; set; }
        public int dongia { get; set; }
        public string dl { get; set; }
        public string date { get; set; }
        private IXuLyHoaDonNhap xuLyHoaDonNhap;
        public SuaHoaDonNhapModel()
        {
            xuLyHoaDonNhap = new XuLyHoaDonNhap();
        }
        public void onGet()
        {
            Chuoi = string.Empty;
        }
        public void onPost()
        {
            try
            {
                HoaDon hd = new HoaDon(mahd, mahang, sl, dongia, dl, date);
                var kq = xuLyHoaDonNhap.SuaHoaDonNhap(hd);
                if (kq.IsSuccess)
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
