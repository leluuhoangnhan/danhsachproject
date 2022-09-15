<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QuanTam.aspx.cs" Inherits="DoAn_Web_LeLuuHoangNhan_Masterpage.QuanTam" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="icon" href="favicon.jpg" />
    <title>LÊ LƯU HOÀNG NHÂN - SẢN PHẨM KHÁCH HÀNG ĐANG QUAN TÂM</title>

    <style>
        .tao_Khung{
            border: 1px solid #e2dddd;
            border-radius:10px;
            padding:15px;
            margin-bottom:10px;
        }
        .toMauNen{
            background-color:#41de1b
        }

        .head{
            color:#cc1e1e;
            border-bottom:1px solid #cc1e1e; 
            margin-bottom:30px;
            padding-top:10px;
            padding-bottom:10px;
        }

        .foot{
            margin-top:30px;
            padding-bottom:10px;
            padding-top:10px;
            border-top:1px solid #2754d0;
            background-color:#2754d0;
            color:white;
        }

        .quayLai_Home{
            color:#ffee35;
            font-size:16px;
        }
        .quayLai_Home:hover {
            color:#ffffff;
            font-size:19px;
        }

        .canGiua{
            margin-left:auto;
            margin-right:auto;
        }

    </style>

    <!-- Bootstrap -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous"></link>

</head>
<body>
    <form id="form1" runat="server" class="toMauNen">
        <div>
            <h2 class="text-center text-uppercase head">Danh Sách Sản Phẩm Khách Hàng Quan Tâm (TOP)</h2>

            <div id="thongTin_KH" class="text-center" style="margin-bottom:35px">
                <asp:Label ID="lbl_userName" runat="server" Text="" ForeColor="BlueViolet" Font-Bold="true" Font-Size="30px"></asp:Label><br />
                <asp:Label ID="lbl_loai" runat="server" Text="" ForeColor="White" Font-Bold="true" Font-Size="20px"></asp:Label>
            </div>


            <div class="text-center" style="margin-bottom:15px">
                <asp:MultiView id="mtv_quantam" runat="server">
                    <asp:View id="view_01" runat="server">
                        <asp:Button id="btn_timKiem_01" runat="server" Text="Tìm kiếm" CssClass="btn btn-danger" OnClick="btn_timKiem_01_Click" />&nbsp;&nbsp;
                        <asp:Button id="btn_insert_01" runat="server" Text="Insert" CssClass="btn btn-danger" OnClick="btn_insert_01_Click" /> &nbsp;&nbsp;
                        <asp:Button id="btn_edit_01" runat="server" Text="Edit" CssClass="btn btn-danger" OnClick="btn_edit_01_Click" /> &nbsp;&nbsp;
                        <asp:Button id="btn_delete_01" runat="server" Text="Delete" CssClass="btn btn-danger" OnClick="btn_delete_01_Click" />&nbsp;&nbsp;
                        <asp:Button id="btn_reset" runat="server" Text="Làm mới" CssClass="btn btn-danger" OnClick="btn_lamMoi_Click" /><br /><br />
                        <a class="quayLai_Home" href="Home.aspx">Quay lại trang Home</a>
                        <br /><br />
                        <asp:Label ID="lbl_kq_quanTam" runat="server" Font-Bold="true" ForeColor="Yellow" Text=""></asp:Label>
                        
                    </asp:View>


                    <asp:View id="view_02" runat="server">
                        URL IMG: <asp:TextBox id="txt_url" runat="server" MaxLength="199"></asp:TextBox> &nbsp;
                        Tên SP: <asp:TextBox id="txt_tenSP" runat="server" MaxLength="99"></asp:TextBox> &nbsp;
                        Chi tiết SP: <asp:TextBox id="txt_chiTietSP" runat="server" MaxLength="999"></asp:TextBox> &nbsp;
                        Loại SP: <asp:TextBox id="txt_loai" runat="server" MaxLength="19"></asp:TextBox> &nbsp; &nbsp;

                        <asp:Button id="btn_insert_02" runat="server" Text="Insert" CssClass="btn btn-danger" OnClick="btn_insert_02_Click"/>
                    </asp:View>


                    <%--Delete--%>
                    <asp:View id="view_03" runat="server">
                        Mã bài viết: <asp:TextBox id="txt_id_delete" runat="server" MaxLength="199"></asp:TextBox> &nbsp;&nbsp;

                        <asp:Button id="btn_delete_02" runat="server" Text="Delete" CssClass="btn btn-danger" OnClick="btn_delete_02_Click"/>
                    </asp:View>


                    <%--Edit--%>
                    <asp:View id="view_04" runat="server">
                        Nhập mã bài viết: <asp:TextBox id="txt_id_edit" runat="server" MaxLength="199"></asp:TextBox> <br /><br />

                        <asp:Label ID="lbl_thongTinEdit" runat="server" Text="Nhập Thông Tin Cần Chỉnh Sửa" Font-Size="20px" Font-Bold="true" ForeColor="White" CssClass="align-content-center"></asp:Label><br /><br />                
                        URL IMG: <asp:TextBox id="txt_url_edit" runat="server" MaxLength="199"></asp:TextBox> &nbsp;
                        Tên SP: <asp:TextBox id="txt_tenSP_edit" runat="server" MaxLength="99"></asp:TextBox> &nbsp;
                        Chi tiết SP: <asp:TextBox id="txt_chiTietSP_edit" runat="server" MaxLength="999"></asp:TextBox> &nbsp;
                        Loại SP: <asp:TextBox id="txt_loai_edit" runat="server" MaxLength="19"></asp:TextBox> &nbsp; &nbsp;

                        <asp:Button id="btn_edit_03" runat="server" Text="Update" CssClass="btn btn-danger" OnClick="btn_edit_02_Click"/>
                    </asp:View>


                    <%--Tìm kiếm--%>
                    <asp:View id="view_05" runat="server">
                        Nhập mã bài viết cần tìm: <asp:TextBox id="txt_id_timKiem" runat="server" MaxLength="199"></asp:TextBox> <br /><br />

                        <asp:Button id="btn_timKiem_02" runat="server" Text="Tìm" CssClass="btn btn-danger" OnClick="btn_timKiem_02_Click"/>
                    </asp:View>


                </asp:MultiView>

            </div>



            <asp:DataList ID="dtl_QuanTam" runat="server" RepeatColumns="1" CssClass="row">
                <ItemTemplate>
                    <div class="row tao_Khung" style="width:1200px;height:auto;margin-left:80px">
                        <div class="col-1" style="margin-top:auto;margin-bottom:auto">
                            <h4 id="lbl_maSP" style="color:white;background-color:black;text-align:center;padding:1px"><%#Eval("ID") %></h4>
                        </div>

                        <div class="col-2">
                             <img id="lbl_img" src='<%#Eval("IMG") %>' width="150" height="150" />
                        </div>
                        
                        <div class="col-3 text-right">
                           <h4 id="lbl_tenSP"><%#Eval("TENSP") %></h4>
                        </div>

                        <div class="col-4 text-right">
                            <h6 id="lbl_chiTietSP"><%#Eval("CHITIET_SP") %></h6>
                        </div>

                        <div class="col-2 text-center">
                            <h4 id="lbl_loai" style="color:#2754d0"><%#Eval("LOAI") %></h4>
                        </div>

                    </div>
                </ItemTemplate>
            </asp:DataList>

            
            <div class="text-center foot">
                <h4> BẢN QUYỀN THUỘC "ĐỒ ÁN CẢ NHÓM NHÂN + ĐỨC + HIỀN"</h4>
            </div>

        </div>


    </form>
</body>
</html>
