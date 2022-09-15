<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Tuyen_Dung.aspx.cs" Inherits="DoAn_Web_LeLuuHoangNhan_Masterpage.Tuyen_Dung" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <style>
         body {
    background: #f8f8f8 url() repeat scroll top left;
    background-color: #f8f8f8;
    font-family: 'Open Sans',sans-serif;
    font-size: 14px;
    font-weight: 400;
    color: #656565;
    word-wrap: break-word;
    margin: 0;
    padding: 0;
}
     #main-wrapper {
            float: left;
            overflow: hidden;
            width: 66.66666667%;
            box-sizing: border-box;
            word-wrap: break-word;
            padding: 0 15px;
            margin: 0;
        }
     #main-wrapper, #sidebar-wrapper {
            width: 100%;
            padding: 0;
        }
            .main .Blog {
    border-bottom-width: 0;
}
.main .widget {
    margin: 0;
}
.section, .widget, .widget ul {
    margin: 0;
    padding: 0;
}
element.style {
    position: relative;
    overflow: visible;
    box-sizing: border-box;
    min-height: 1px;
}
        div {
    display: block;
}

    .blog-post 
    {
    display: block;
    overflow: hidden;
    word-wrap: break-word;
    }
    /**/

        .index-post .post-image-wrap {
            float: left;
            width: 260px;
            height: 195px;
            margin: 0 20px 0 0;
        }

        .post-image-wrap {
            position: relative;
            display: block;
        }

        .index-post .post-image-wrap .post-image-link {
            width: 100%;
            height: 100%;
            position: relative;
            display: block;
            z-index: 1;
            overflow: hidden;
        }

        .post-thumb.lazy-yard {
            opacity: 1;
        }

        .widget iframe, .widget img {
            max-width: 100%;
        }

        .post-thumb {
            display: block;
            position: relative;
            width: 100%;
            height: 100%;
            object-fit: cover;
            object-position: top;
            z-index: 1;
        }

        a img {
            border: 0;
        }

        .index-post .post-info {
            overflow: hidden;
        }

            .index-post .post-info > h2 {
                font-size: 24px;
                font-weight: 700;
                line-height: 1.4em;
                text-decoration: none;
                margin: 0 0 10px;
            }

        h2 {
            display: block;
            /*    margin-block-start: 0.83em;
    margin-block-end: 0.83em;
    margin-inline-start: 0px;
    margin-inline-end: 0px;*/
        }

        .index-post .post-info > h2 > a {
            display: block;
            color: #161619;
            transition: color .17s;
        }

        a, a:visited {
            text-decoration: none;
        }

        .index-post .post-snippet {
            font-size: 13px;
            line-height: 24px;
            color: #666666;
            text-align: justify;
        }

        .post-snippet {
            position: relative;
            display: block;
            overflow: hidden;
            font-weight: 400;
            margin: 10px 0 0;
        }

        p {
            /* margin-block-start: 1em;
    margin-block-end: 1em;
    margin-inline-start: 0px;
    margin-inline-end: 0px;*/ */
        }

        a.read-more {
            display: inline-block;
            background-color: #0088ff;
            color: #fff;
            height: 25px;
            font-size: 13px;
            font-weight: 600;
            line-height: 25px;
            padding: 0 10px;
            margin: 12px 0 0;
            transition: background .17s ease;
        }

        a, a:visited {
            text-decoration: none;
        }

            a.read-more::after {
                content: '\f178';
                font-family: FontAwesome;
                font-weight: 400;
                margin: 0 0 0 5px;
            }
    </style>

    <div id="main-wrapper" style="position: relative; overflow: visible; box-sizing: border-box; min-height: 1px;">
        <div class="theiaStickySidebar" style="padding-top: 0px; padding-bottom: 1px; position: static; transform: none;">
            <div class="widget Blog" id="Blog1">
                <div class="blog-posts hfeed container index-post-wrap">
                    <div class="blog-post hentry index-post">
                        <br />
                        <div class="post-image-wrap">
                            <a class="post-image-link" href="pagetuyendung.aspx">
                                <img alt="✅TUYỂN CỘNG TÁC VIÊN KINH DOANH BẤT ĐỘNG SẢN TẠI TP. HCM" class="post-thumb lazy-yard" src="https://1.bp.blogspot.com/-nORk7IrA7dE/X38ivOb2FJI/AAAAAAAAAj8/G4KJs3JSyCQ7T0M4JmCt4cTnL-IBN8NpwCLcBGAsYHQ/w640/giup-do-ban-be-leo-nui.jpg" />
                            </a>
                        </div>
                        <div class="post-info">
                            <h2 class="post-title">
                                <a href="pagetuyendung.aspx">✅TUYỂN CỘNG TÁC VIÊN KINH DOANH BẤT ĐỘNG SẢN TẠI TP. HCM</a>
                            </h2>
                            <p class="post-snippet">- Số lượng: 5 người. - Thời gian tuyển: Từ 08/10 - 29/10.  (❗️❗️❗️ Tuyển đủ không tuyển nữa) - Công việc: Đăng bài, chăm sóc khách hàng,…(Không cần d…</p>
                            <a class="read-more" href="pagetuyendung.aspx">Xem thêm » 
                               
                            </a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
