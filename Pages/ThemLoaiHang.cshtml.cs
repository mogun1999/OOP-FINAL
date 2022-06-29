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
    public class ThemLoaiHangModel : PageModel
    {
        public string Chuoi { get; set; }
        public int maloai { get; set; }
        public string loaihang { get; set; }
        private IXuLyLoaiHang xuLyLoaiHang;
        public ThemLoaiHangModel()
        {
            xuLyLoaiHang = new XuLyLoaiHang();
        }
        public void OnGet()
        {
            Chuoi = string.Empty;
        }
        public void onPost()
        {
            try
            {
                LoaiHang mh = new LoaiHang(maloai, loaihang);
                var kq = xuLyLoaiHang.ThemLoaiHang(mh);
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
