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
    public class XoaHoaDonBanModel : PageModel
    {
        public string Chuoi { get; set; }
        public int madon { get; set; }

        private IXuLyHoaDonBan xuLyHoaDonBan;
        public XoaHoaDonBanModel()
        {
            xuLyHoaDonBan = new XuLyHoaDonBan();
        }
        public void onGet()
        {
            Chuoi = string.Empty;
        }
        public void onPost()
        {
            try
            {
                var kq = xuLyHoaDonBan.XoaHoaDonBan(madon);
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
