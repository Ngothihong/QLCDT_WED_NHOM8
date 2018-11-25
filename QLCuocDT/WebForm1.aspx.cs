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
        QLCuocDTEntities qLTinhCuocDT = new QLCuocDTEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            //gvChiTietCuocGoi.DataSource = qLTinhCuocDT.THOIGIANSUDUNGs.ToList();
            //gvChiTietCuocGoi.DataBind();
        }

        protected void btnTim_Click(object sender, EventArgs e)
        {
            string Sim = txtSim.Text;
            string mahoadon = txtmahoadon.Text;
            THONGTINSIM tHONGTINSIM = new THONGTINSIM();
            if (Sim != "") // sim ko rong
            {
               // var thongtinsim = qLTinhCuocDT.THONGTINSIMs.Where(x => x.Sdt == Sim).ToList();
                var thongtinsim1 = from x in qLTinhCuocDT.THONGTINSIMs
                                   where x.Sdt == Sim
                                   orderby x.IDSim descending
                                   select x;
                
                if ( thongtinsim1.Count() == 0) // sim ko ton tai
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Số điện thoại không tồn tại');</script>");
                }
                else // sim ton tai
                {
                    foreach (var item in thongtinsim1)
                    {
                        tHONGTINSIM = item;
                        break;
                    }

                    if (mahoadon == "") // mahoadon rong
                    {
                       
                        List<THOIGIANSUDUNG> list = qLTinhCuocDT.THOIGIANSUDUNGs.Where(x => x.IDSim == tHONGTINSIM.IDSim).ToList();
                        gvChiTietCuocGoi.DataSource = list;
                        gvChiTietCuocGoi.DataBind();
                    }
                    else // mahoadon ko rong
                    {
                        HOADON hoadon = qLTinhCuocDT.HOADONs.Where(x => x.IDHD == mahoadon).SingleOrDefault();

                        if ( hoadon != null) // ton tai hoa don
                        {
                            var  list = (from x in qLTinhCuocDT.THOIGIANSUDUNGs
                                               where x.IDSim == hoadon.IDsim && x.TGBD >= hoadon.TGBD && x.TGBD <= hoadon.TGKT
                                               select x).ToList();
                           // List<THOIGIANSUDUNG> list = qLTinhCuocDT.THOIGIANSUDUNGs.Where(x => x.IDSim == tHONGTINSIM.IDSim).ToList();
                            gvChiTietCuocGoi.DataSource = list;
                            gvChiTietCuocGoi.DataBind();
                        }
                        else // khong ton tai hoa don
                        {
                            Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Mã hóa đơn không tồn tại');</script>");
                        }
                       
                    }
                    
                }
               
               
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Bạn chưa nhập số điện thoại');</script>");

            }
        }

        //DateTime Thongketheothang()
        //{
        //    string vl = DropDownList1.SelectedValue;
        //    int day = DateTime.Now.Day;
        //    int month = DateTime.Now.Month;
        //    int year = DateTime.Now.Year;
        //    DateTime ngaydautuands=new DateTime();
        //    if (vl == "MotTuan")
        //    {
        //        if (day > 7)
        //        {
        //            ngaydautuands = new DateTime(year, month, day - 7);
        //        }
        //        else if (day < 7)
        //        {
        //            if (month > 1)
        //            {
        //                ngaydautuands = new DateTime(year, month - 1, day - 7);
        //            }
        //            else if (month == 1)
        //            {
        //                ngaydautuands = new DateTime(year - 1, month - 1 + 12, day - 7);
        //            }
        //        }
        //    }
        //    if (vl == "MotThang")
        //    {
        //        ngaydautuands = new DateTime(year, month, 1);
        //    }
        //    if (vl == "BaThang")
        //    {
        //        if (month > 3)
        //        {
        //            ngaydautuands = new DateTime(year, month - 3, 1);
        //        }
        //        else if (month < 3)
        //        {
        //            ngaydautuands = new DateTime(year - 1, month - 3 + 12, 1);
        //        }
        //    }
        //    if (vl == "MotNam")
        //    {
        //        ngaydautuands = new DateTime(year, 1, 1);
        //    }
        //    return ngaydautuands;

        //}
    }
    }