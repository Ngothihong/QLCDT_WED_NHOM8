using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;
using System.Linq.Expressions;

namespace QLCuocDT
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        QLTinhCuocDTEntities qLTinhCuocDT = new QLTinhCuocDTEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            gvChiTietCuocGoi.DataSource = qLTinhCuocDT.ChiTietSuDungs.ToList();
            gvChiTietCuocGoi.DataBind();
        }

        protected void btnTim_Click(object sender, EventArgs e)
        {
            string Sim = txtSim.Text;
            DateTime Thongke = Thongketheothang();

            if (Sim != "")
            {
                List<ChiTietSuDung> list = qLTinhCuocDT.ChiTietSuDungs.Where(x => x.IDSIM == Sim && x.TGBD >= Thongke && x.TGKT <= DateTime.Now).ToList();
                gvChiTietCuocGoi.DataSource = list;
                gvChiTietCuocGoi.DataBind();
            }
            else
            {


            }
        }

        DateTime Thongketheothang()
        {
            string vl = DropDownList1.SelectedValue;
            int day = DateTime.Now.Day;
            int month = DateTime.Now.Month;
            int year = DateTime.Now.Year;
            DateTime ngaydautuands=new DateTime();
            if (vl == "MotTuan")
            {
                if (day > 7)
                {
                    ngaydautuands = new DateTime(year, month, day - 7);
                }
                else if (day < 7)
                {
                    if (month > 1)
                    {
                        ngaydautuands = new DateTime(year, month - 1, day - 7);
                    }
                    else if (month == 1)
                    {
                        ngaydautuands = new DateTime(year - 1, month - 1 + 12, day - 7);
                    }
                }
            }
            if (vl == "MotThang")
            {
                ngaydautuands = new DateTime(year, month, 1);
            }
            if (vl == "BaThang")
            {
                if (month > 3)
                {
                    ngaydautuands = new DateTime(year, month - 3, 1);
                }
                else if (month < 3)
                {
                    ngaydautuands = new DateTime(year - 1, month - 3 + 12, 1);
                }
            }
            if (vl == "MotNam")
            {
                ngaydautuands = new DateTime(year, 1, 1);
            }
            return ngaydautuands;

        }
    }
    }