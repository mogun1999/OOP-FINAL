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
    public class TimKiemLoaiHangModel : PageModel
    {
        public string Chuoi { get; set; }
        public LoaiHang a { get; set; }
        public int maloai { get; set; }

        private IXuLyLoaiHang xuLyLoaiHang;
        public TimKiemLoaiHangModel()
        {
            xuLyLoaiHang = new XuLyLoaiHang();
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
                var kq = xuLyLoaiHang.TimKiemLoaiHang(maloai);
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
