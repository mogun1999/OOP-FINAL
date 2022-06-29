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
    public class ThongKeHetHSDModel : PageModel
    {
        public string Chuoi { get; set; }
        private IThongKe thongKe;
        public ThongKeHetHSDModel()
        {
            thongKe = new ThongKe();
        }
        public void onGet()
        {
            try
            {
                var kq = thongKe.ThongKeHetHSD();
                if (kq.Data > 0)
                {
                    Chuoi = $"So hang het HSD la: {kq}";
                }
                else
                {
                    Chuoi = "Kho khong co hang het HSD";
                }
            }
            catch (Exception ex)
            {
                Chuoi = ex.Message;
            }
        }
    }
}
