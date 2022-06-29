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
    public class TimKiemHDBanModel : PageModel
    {
        public string Chuoi { get; set; }
        public HoaDon a { get; set; }
        public int madon { get; set; }

        private IXuLyHoaDonBan xuLyHoaDonBan;
        public TimKiemHDBanModel()
        {
            xuLyHoaDonBan = new XuLyHoaDonBan();
        }
        public void onGet()
        {
            Chuoi = string.Empty;
            a = null;
        }
        public void onPost()
        {
            try
            {
                var kq = xuLyHoaDonBan.TimKiemHoaDonBan(madon);
                if (kq.Data != null)
                {
                    a = kq.Data;
                }
                else
                {
                    Chuoi = "Ko co ket qua";
                }
            }
            catch (Exception ex)
            {
                Chuoi = ex.Message;
            }
        }
    }
}
