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
    public class ThongKeSoHangConLaiModel : PageModel
    {
        public string Chuoi { get; set; }
        public int maloai { get; set; }

        private IThongKe thongKe;
        public ThongKeSoHangConLaiModel()
        {
            thongKe = new ThongKe();
        }
        public void onGet()
        {
            Chuoi = string.Empty;
        }
        public void onPost()
        {
            try
            {
                var kq = thongKe.ThongKeSoHangConLai(maloai);
                if (kq.Data>=0)
                {
                    Chuoi = $"So hang con lai la {kq.Data}";
                }
                else
                {
                    Chuoi = "Loai hang chua co so hang trong du lieu";
                }
            }
            catch (Exception ex)
            {
                Chuoi = ex.Message;
            }
        }
    }
}
