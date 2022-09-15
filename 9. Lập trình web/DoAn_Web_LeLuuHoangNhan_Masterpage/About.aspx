<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="DoAn_Web_LeLuuHoangNhan_Masterpage.About" %>
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
     .item-post .post-meta {
    padding: 0 1px 10px;
    border-bottom: 1px solid #eaeaea;
}

.post-meta {
    display: block;
    overflow: hidden;
    color: #aaa;
    font-size: 12px;
    font-weight: 400;
    padding: 0 1px;
}
span
 {
    padding: 0;
    border: 0;
    outline: 0;
    vertical-align: baseline;
    background: 0 0;
    text-decoration: none;
}
.post-meta .post-author, .post-meta .post-date {
    float: left;
    margin: 0 10px 0 0;
}
.post-meta a {
    color: #aaa;
    transition: color .17s;
}

a {
    color: #0088ff;
}
a, a:visited {
    text-decoration: none;
}
.post-meta .post-date {
    text-transform: capitalize;
}

.post-meta .post-author, .post-meta .post-date {
    float: left;
    margin: 0 10px 0 0;
}
        /*--a---img*/
        .item-post .post-body {
            width: 100%;
            line-height: 1.5em;
            overflow: hidden;
            padding: 20px 0 0;
        }

        .post-body a {
            transition: color .17s ease;
        }

        .separator a {
            clear: none;
            float: none;
            margin-left: 0;
            margin-right: 0;
        }

        a {
            color: #0088ff;
        }

            a, a:visited {
                text-decoration: none;
            }

        /*  img */
        .item-post .post-body img.lazy-yard {
            opacity: 1;
        }

        .item-post .post-body img {
            max-width: 100%;
            transition: opacity .35s ease,transform .35s ease;
        }

        a img {
            border: 0;
        }

        img {
            position: relative;
            width:90%;
        }

        /* footer*/

        .post-footer {
            position: relative;
            float: left;
            width: 100%;
            margin: 20px 0 0;
        }

        .post-share {
            position: relative;
            overflow: hidden;
            line-height: 0;
            margin: 0 0 30px;
        }

        ul.share-links social social-color {
            position: relative;
        }

        .section, .widget, .widget ul {
            margin: 0;
            padding: 0;
        }

        dl, ul {
            list-style-position: inside;
            font-weight: 400;
            list-style: none;
        }

        .share-links li.facebook, .share-links li.twitter, .share-links li.gplus {
            width: 40%;
        }

        .share-links li {
            width:250px;
            float: left;
            box-sizing: border-box;
            margin: 0 5px 0 0;
        }

        ul li {
            list-style: none;
        }

        .social-color .facebook a {
            background-color: #3b5999;
        }

        .share-links li a {
            float: left;
            display: inline-block;
            cursor: pointer;
            width: 100%;
            height: 32px;
            line-height: 32px;
            color: #fff;
            font-weight: 400;
            font-size: 13px;
            text-align: center;
            box-sizing: border-box;
            opacity: 1;
            margin: 0;
            padding: 0;
            transition: all .17s ease;
        }

        a {
            color: #0088ff;
        }

            a, a:visited {
                text-decoration: none;
            }

        .social-color .email a {
            background-color: #888;
        }

        .about-author {
            position: relative;
            display: block;
            overflow: hidden;
            padding: 20px;
            margin: 0 0 30px;
            border: 1px solid #eaeaea;
        }

            .about-author .avatar-container {
                position: relative;
                float: left;
                width: 80px;
                height: 80px;
                overflow: hidden;
                margin: 0 15px 0 0;
                border-radius: 100%;
            }

            .post-image-link, .about-author .avatar-container, .comments .avatar-image-container {
                background-color: rgba(155,155,155,0.05);
                color: transparent !important;
            }

            /*image */
            .about-author .author-avatar.lazy-yard {
                opacity: 1;
            }

            .about-author .author-avatar
             {
                float: left;
                width: 100%;
                height: 100%;
                border-radius: 100%; opacity: 0;
                transition: opacity .35s ease;
            }

        .widget iframe, .widget img {
            max-width: 100%;
        }

        img {
            border: none;
            position: relative;
        }

        .author-name {
    overflow: hidden;
    display: inline-block;
    font-size: 16px;
    font-weight: 700;
    margin: 7px 0 3px;
}

        h3 {
            margin-top:11px;
            margin-bottom:11px;
            margin-left: 11px;
            margin-right: 11px;
           
        }

        .author-name span {
    color: #161619;
}

        .author-name a {
    color: #161619;
    transition: color .17s;
}

        .author-description {
    display: block;
    overflow: hidden;
    font-size: 13px;
    font-weight: 400;
    line-height: 1.5em;
}
    </style>


     <div id="content-wrapper " style="transform: none;">
        <%--<div class="content" style="transform: none;">--%>
            <div id="main-wrapper" style="position: relative; overflow: visible; box-sizing: border-box; min-height: 1px;">
                <h1 class="post-title">Giới thiệu                </h1>
                 <div class="post-meta">
                    <span class="post-author"><a href="https://www.blogger.com/profile/02836254889699853818"target="_blank"title="Lê Lưu Kì Lân">Lê Hoàng</a></span>
                    <span class="post-date published"> 01/08/2021 01:41:00 CH</span>
                </div><br />
                <div class="post-body post-content">
                    <div>
                        <span style="font-family: arial; font-size: medium;">
                            ✅<b style="color: red;">Chuyên Nhận Ký Gửi Mua Bán - Cho Thuê Căn Hộ Sài Gòn</b>
                        </span>
                    </div>
                  <%--  <div><span style="font-family: arial; font-size: medium;"><br /></span></div>--%>
                    <p>
                        <b><span style="font-family: arial; font-size: large;">GIỜ LÀM VIỆC:</span></b>
                        <span style="font-family: arial; font-size: large;">&nbsp;</span>
                        <span style="font-family: arial;">
                            <span style="font-family: arial; font-size: large;"">
                                <b>Thứ 2 - Thứ 7 (Từ 8:00 - 20:30)</b>
                            </span>
                        </span>
                    </p>
                    <p>
                        <span style="font-family: arial; font-size: medium;">
                            &nbsp;-
                            <b>Hotline/ Zalo</b>
                            &nbsp; : 0938.237.485
                        </span>
                    </p>
                    <p>
                        <span style="font-family: arial; font-size: medium;">
                            &nbsp;-
                            <b>Email :</b>
                              leluuhoangnhan@gmail.com
                        </span>
                    </p>
                    <p>
                        <span style="font-family: arial; font-size: medium;">
                            &nbsp;-
                            <b>Địa chỉ : </b>
                              02 Phan Văn Đáng, Thạnh Mỹ Lợi, Quận 2, Hồ Chí Minh.
                        </span>
                    </p>
                    <p>
                        <span style="font-family: arial; font-size: medium;"></span>
                    </p>
                    <div class="separator" style="clear: both; text-align: center;">
                        <a href="https://1.bp.blogspot.com/-L7_SJayER0E/X1SuLOnBBBI/AAAAAAAAANw/0qNC9GmDI6EBajqd1ehc0EmLxWJbykneACLcBGAsYHQ/s2048/FPPP.jpg" style="margin-left: 1em; margin-right: 1em;">
                            <img border="0" data-original-height="426" data-original-width="626" src="https://1.bp.blogspot.com/-L7_SJayER0E/X1SuLOnBBBI/AAAAAAAAANw/0qNC9GmDI6EBajqd1ehc0EmLxWJbykneACLcBGAsYHQ/s16000/FPPP.jpg" class="lazy-yard"/>
                        </a>
                    </div>
                    <br />
                    <p><br /></p>
                </div>
                <div class="post-footer">
                    <div class="post-share">
                        <ul class="share-links social social-color">
                            <li class="facebook">
                                <a class="facebook" href="https://www.facebook.com/sharer.php?u=https://www.leluuhoangnhan.com/2020/09/gioi-thieu.html">
                                    <span>facebook</span>
                                </a>
                            </li>
                            <li class="email">
                                <a class="Email" href="mailto:?subject=Giới Thiệu&body=https://www.leluuhoangnhan.com/2020/09/gioi-thieu.html">
                                    <span>Email</span>
                                </a>
                            </li>
                        </ul>
                    </div>
                    <div class="about-author">
                        <div class="avatar-container"><img alt="abc"class="author-avatar lazy-yard"src="//3.bp.blogspot.com/-qnNBs9xdk-A/X3_3fCwNwdI/AAAAAAAAAl0/UBmPnx3LekwD_-P5Qp5rCUN5tAJ0ojuSwCK4BGAYYCw/w100/Logo%2BNh%25E1%25BB%258F.jpg"/></div>
                        <h3 class="author-name">
                            <span>tác giả :</span>
                            <a  href="https://www.blogger.com/profile/02836254889699853818">Lê Hoàng</a>
                        </h3>
                        <span class="author-description">Chuyên Viên Kinh Doanh Bất Động Sản</span>
                    </div>
                    <div id="related-wrap"></div> 
                </div>
            </div>
        <%--/div>--%>
    </div>
</asp:Content>
