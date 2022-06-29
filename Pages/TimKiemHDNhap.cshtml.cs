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
    public class TimKiemHDNhapModel : PageModel
    {
        public string Chuoi { get; set; }
        public HoaDon a { get; set; }
        public int madon { get; set; }

        private IXuLyHoaDonNhap xuLyHoaDonNhap;
        public TimKiemHDNhapModel()
        {
            xuLyHoaDonNhap = new XuLyHoaDonNhap();
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
                var kq = xuLyHoaDonNhap.TimKiemHoaDonNhap(madon);
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
