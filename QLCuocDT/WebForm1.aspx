<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="QLCuocDT.WebForm1" %>

<%@ Register assembly="DevExpress.Web.v18.1, Version=18.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="Scripts/bootstrap.min.js"></script>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Scripts/Stylewebform.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">

            <div class="panel-heading text-center">
                <h2>QUẢN LÝ CƯỚC ĐIỆN THOẠI</h2>
            </div>
         
            

            <div class="panel-body">
                <div class="list-group">
                    <div class="list-group-item row">
                        <div class="col-xs-5">
                            <asp:TextBox ID="txtmahoadon" runat="server" CssClass="form-control" placeholder="Mã hóa đơn" Height="24px" Width="348px"></asp:TextBox>
                        </div>
                        <div class="col-xs-5">
                            <asp:TextBox runat="server" CssClass="form-control" placeholder="SỐ ĐIỆN THOẠI" ID="txtSim" Height="24px" Width="348px"></asp:TextBox>
                        </div>
                        <div class=" col-xs-2">
                            <asp:Button CssClass="btn btn-info" OnClick="btnTim_Click" runat="server" ID="btnTim" Text="Tìm" />
                        </div>
                    </div>
                    <div class="list-group-item row">
                        <asp:GridView CssClass="table table-bordered" runat="server" ID="gvChiTietCuocGoi" AutoGenerateColumns="False">
                            <Columns>
                                <asp:BoundField DataField="TGBD" HeaderText="Thời gian bắt đầu" />
                                <asp:BoundField DataField="TGKT" HeaderText="Thời gian kết thúc" />
                                <asp:BoundField DataField="SophutBN" HeaderText="Số phút ban ngày" />
                                <asp:BoundField DataField="SophutBD" HeaderText="Số phút ban đêm" />
                                <asp:BoundField DataField="Gia" HeaderText="Giá" />
                            </Columns>
                        </asp:GridView>
                    </div>
                </div>

                <div class="panel-footer top-left">
                    <asp:Label runat="server" Text="HotLine:19000000"></asp:Label>
                </div>

            </div>

        </div>
    </form>
</body>
</html>
