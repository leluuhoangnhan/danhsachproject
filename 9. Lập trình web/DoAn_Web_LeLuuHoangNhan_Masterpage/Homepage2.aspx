<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="~/Homepage2.aspx.cs" Inherits="DoAn_Web_LeLuuHoangNhan_Masterpage.Homepage2" %>
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

    .index-post 
    {
    padding: 0;
    margin: 0 0 30px;
    }
    a,h1,h2,h3,h4
    {
    padding: 0;
    border: 0;
    outline: 0;
    vertical-align: baseline;
    background: 0 0;
    }

     h2 {
    display: block;
    font-size: 1.5em;
    /*margin-block-start: 0.83em;
   
    margin-block-end: 0.83em;
    margin-inline-start: 0px;
    margin-inline-end: 0px;*/
    font-weight: bold;
}

      .post-image-wrap
     {
    position: relative;
    display: block;
    }

     .index-post .post-image-wrap
     {
    float: left;
    width: 260px;
    height: 195px;
    margin: 0 20px 0 0;
    }
     .index-post .post-image-wrap .post-image-link {
    width: 100%;
    height: 100%;
    position: relative;
    display: block;
    z-index: 1;
    overflow: hidden;
}

     a {
    color: #0088ff;
}
a, a:visited {
    text-decoration: none;
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
    opacity: 0;
    transition: opacity .35s ease,transform .35s ease;
}
a img {
    border: 0;
}
img {
    border: none;
    position: relative;
}
   .widget iframe, .widget img {
    max-width: 100%;
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
 .index-post .post-info > h2 > a {
    display: block;
    color: #161619;
    transition: color .17s;
}
 .post-title a {
    display: block;
}
a {
    color: #0088ff;
}

a, a:visited {
    text-decoration: none;
}
.post-meta {
    display: block;
    overflow: hidden;
    color: #aaa;
    font-size: 12px;
    font-weight: 400;
    padding: 0 1px;
}
.post-meta .post-author, .post-meta .post-date {
    float: left;
    margin: 0 10px 0 0;
}

.post-meta a {
    color: #aaa;
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
    font-size: 12px;
    line-height: 1.6em;
    font-weight: 400;
    margin: 10px 0 0;
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
a.read-more::after {
    content: '\f178';
    font-family: FontAwesome;
    font-weight: 400;
    margin: 0 0 0 5px;
}
/*paper*/
#blog-pager {
    overflow: hidden;
    clear: both;
    margin: 0 0 30px;
}
.blog-pager .page-active, .blog-pager a:hover {
    background-color: #0088ff;
    color: #fff;
}

.blog-pager a, .blog-pager span {
    float: left;
    display: block;
    min-width: 50px;
    height: 30px;
    background-color: #161619;
    color: #fff;
    font-size: 13px;
    font-weight: 700;
    line-height: 30px;
    text-align: center;
    box-sizing: border-box;
    margin: 0 5px 0 0;
    border-radius: 3px;
    text-shadow: 1px 2px 0 #656565;
    transition: all .17s ease;
}
a, a:visited {
    text-decoration: none;
}
.blog-pager span.page-dots {
    min-width: 50px;
    background-color: #fff;
    font-size: 16px;
    color: #161619;
    line-height: 30px;
    font-weight: 400;
    letter-spacing: -1px;
    border: 0;
}
   </style>
            <div id="main-wrapper" style="position: relative; overflow: visible; box-sizing: border-box; min-height: 1px;">
             <div class="theiaStickySidebar" style="padding-top: 0px; padding-bottom: 1px; position: static; transform: none;">
                 <div class="widget Blog" id="Blog1">
                    <div class="blog-posts hfeed container index-post-wrap">
                            <div class="blog-post hentry index-post">
            <div class="post-image-wrap">
                <a class="post-image-link" href="#"><img alt="Cho Thuê Căn Hộ Homyland 2 PN - 2 WC Q.2 Gía 11 Triệu/ Tháng"class="post-thumb lazy-yard"src="https://1.bp.blogspot.com/-7olPAkputn8/X379cAQz3cI/AAAAAAAAAjA/h5bwGsw7gXAd30Rq_uZunTLycT35lVeNACLcBGAsYHQ/w640/1.jpg"/></a>
            </div>
            <div class="post-info">
                <h2 class="post-title"><a href="#">Cho Thuê Căn Hộ Homyland 2 PN - 2 WC Q.2 Gía 11 Triệu/ Tháng</a></h2>
                <div class="post-meta">
                    <span class="post-author"><a href="https://www.blogger.com/profile/02836254889699853818"target="_blank"title="Lê Lưu Kì Lân">Lê Hoàng</a></span>
                    <span class="post-date published"> 01/08/2021 01:41:00 CH</span>
                </div>
                <p class="post-snippet">- Diện Tích: 81 m2.   - Full Nội Thất (Chỉ Cần Dọn Quần Áo Vào Ở) .   - Cho Thuê Giá: 11,5 Triệu / Tháng  (Bao Phí Quản Lí).   ⭐⭐⭐⭐⭐⭐⭐   Thông Tin Li…</p>
                <a class="read-more"href="#">Xem thêm »</a>
            </div>
        </div>
        <div class="blog-post hentry index-post">
            <div class="post-image-wrap">
                <a class="post-image-link"href="#"><img alt="Bán Nhanh Căn Hộ Kris Vue 1 PN Quận 2 Giá Chỉ 2.4 Tỷ"class="post-thumb lazy-yard"src="https://1.bp.blogspot.com/-N-bamij2ne4/X374ltyShcI/AAAAAAAAAiU/zttW5gLlYRQ49bNlluqgu3DrkVNEaWApQCLcBGAsYHQ/w640/1.jpg"/></a>
            </div>
            <div class="post-info">
                <h2 class="post-title"><a href="#">Bán Nhanh Căn Hộ Kris Vue 1 PN Quận 2 Giá Chỉ 2.4 Tỷ</a></h2>
               <div class="post-meta">
                    <span class="post-author"><a href="https://www.blogger.com/profile/02836254889699853818"target="_blank"title="Lê Lưu Kì Lân">Lê Hoàng</a></span>
                    <span class="post-date published"> 01/08/2021 01:41:00 CH</span>
                </div>
                <p class="post-snippet">- Diện Tích: 55,81 m2 , Đã Có Sổ Hồng.   -  Full Nội Thất (Xách Vali Vào Ở) .   - Bán Giá: 2,4  Tỷ (Bao Gồm Thuế + Phí  + 5% Sổ ).   ⭐⭐⭐⭐⭐⭐⭐   Thông …</p>
                <a class="read-more"href="#">Xem thêm »</a>
            </div>
        </div>
        <div class="blog-post hentry index-post">
            <div class="post-image-wrap">
                <a class="post-image-link"href="#"><img alt="Cho Thuê Căn Hộ 2 PN - 2 WC Safira KĐ Q.9 Giá Chỉ 6.5 Triệu"class="post-thumb lazy-yard"src="https://1.bp.blogspot.com/-cQZK-rULl6Q/X37jOQffskI/AAAAAAAAAeQ/XaEPJyx50z8gowqOCUmxygNvXq2q47LjACLcBGAsYHQ/w640/1.jpg"/></a>
            </div>
            <div class="post-info">
                <h2 class="post-title"><a href="#">✅Cho Thuê Căn Hộ 2 PN - 2 WC Safira KĐ Q.9 Giá Chỉ 6.5 Triệu</a></h2>
                <div class="post-meta">
                    <span class="post-author"><a href="https://www.blogger.com/profile/02836254889699853818"target="_blank"title="Lê Lưu Kì Lân">Lê Hoàng</a></span>
                    <span class="post-date published"> 01/08/2021 01:41:00 CH</span>
                </div>
                <p class="post-snippet">- Diện Tích: 67 m2.   - Nội Thất Cơ Bản (Gồm 2 Máy Lạnh + Bộ Bàn Ăn) .   - Cho Thuê Giá: 6,5 Triệu / Tháng .   ⭐⭐⭐⭐⭐⭐⭐   Thông Tin Liên Hệ:   📞 Hotl…</p>
                <a class="read-more"href="#">Xem thêm »</a>
            </div>
        </div>
        <div class="blog-post hentry index-post">
            <div class="post-image-wrap">
                <a class="post-image-link"href="#"><img alt="Bán Gấp Căn Hộ The CBD 2 Phòng Ngủ Q.2 Giá 2.2 Tỷ"class="post-thumb lazy-yard"src="https://1.bp.blogspot.com/-xK_w0DFg1tA/X37wh-nqkpI/AAAAAAAAAgo/jbVSsKD_GJYl-QA5WrthgE5lsus6Suo4ACLcBGAsYHQ/w640/1.jpg"/></a>
            </div>
            <div class="post-info">
                <h2 class="post-title"><a href="#">✅Bán Gấp Căn Hộ The CBD 2 Phòng Ngủ Q.2 Giá 2.2 Tỷ</a></h2>
                <div class="post-meta">
                    <span class="post-author"><a href="https://www.blogger.com/profile/02836254889699853818"target="_blank"title="Lê Lưu Kì Lân">Lê Hoàng</a></span>
                    <span class="post-date published"> 01/08/2021 01:41:00 CH</span>
                </div>
                <p class="post-snippet">- Diện Tích: 63 m2 .   -  Full Nội Thất (Xách Vali Vào Ở) .   - Bán Giá: 2,2  Tỷ (Bao Gồm Thuế + Phí  + 5% Sổ ).   ⭐⭐⭐⭐⭐⭐⭐   Thông Tin Liên Hệ:   📞 …</p>
                <a class="read-more"href="#">Xem thêm »</a>
            </div>
        </div> 
                        </div>
                     <div class="blog-pager container"id="blog-pager">
                   <a class="page-num" href="Home.aspx" onclick="getPage(2);return false">1</a>
                         <span class="page-num page-active" >2</span>
                    
                    <span class="page-num page-dots">...</span>
                    <a class="page-num" href="#" onclick="getPage(2);return false">next</a>
                </div>
                     </div>
                 </div>
                </div>
      
        
      
    
</asp:Content>
