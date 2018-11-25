<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="QLCuocDT.WebForm1" %>

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
                            <asp:DropDownList ID="DropDownList1" CssClass="dropdown dropdown-toggle form-control" runat="server">
                                <asp:ListItem  Text="Một tuần" Value="MotTuan"></asp:ListItem>
                                <asp:ListItem Text="Một tháng" Value="MotThang" ></asp:ListItem>
                                <asp:ListItem Text="Ba tháng" Value="BaThang"></asp:ListItem>
                                <asp:ListItem Text="Một năm" Value="MotNam"></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                        <div class="col-xs-5">
                            <asp:TextBox runat="server" CssClass="form-control" placeholder="SỐ ĐIỆN THOẠI" ID="txtSim"></asp:TextBox>
                        </div>
                        <div class=" col-xs-2">
                            <asp:Button CssClass="btn btn-info" OnClick="btnTim_Click" runat="server" ID="btnTim" Text="Tìm" />
                        </div>
                    </div>
                    <div class="list-group-item row">
                        <asp:GridView CssClass="table table-bordered" runat="server" ID="gvChiTietCuocGoi" AutoGenerateColumns="false">
                            <Columns>
                                <asp:BoundField DataField="TGBD" HeaderText="Thời gian bắt đầu" />
                                <asp:BoundField DataField="TGKT" HeaderText="Thời gian kết thúc" />
                                <asp:BoundField DataField="SOPHUTSD" HeaderText="Số phút sử dụng" />
                                <asp:BoundField DataField="PHICUOCGOI" HeaderText="Cước phí" />
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
