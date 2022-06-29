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
    public class TimKiemMatHangModel : PageModel
    {
        public string Chuoi { get; set; }
        public MatHang a { get; set; }
        public int mahang { get; set; }

        private IXuLyMatHang xuLyMatHang;
        public TimKiemMatHangModel()
        {
            xuLyMatHang = new XuLyMatHang();
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
                var kq = xuLyMatHang.TimKiemMatHang(mahang);
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

