<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Tin_Moi.aspx.cs" Inherits="DoAn_Web_LeLuuHoangNhan_Masterpage.Tin_Moi" %>
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
        /*title*/
        .title-wrap {
    position: relative;
    float: left;
    width: 100%;
    height: 32px;
    display: block;
    margin: 0 0 20px;
    background: #161619;
}
        .title-wrap > h3 {
    position: relative;
    float: left;
    height: 32px;
    font-size: 15px;
    color: #fff;
    background: #0088ff;
    text-transform: uppercase;
    line-height: 32px;
    padding: 0 12px;
    margin: 0;
}
        a.view-all {
    position: relative;
    float: right;
    height: 22px;
    font-size: 11px;
    line-height: 22px;
    margin-top: 5px;
    margin-right: 5px;
    padding: 0 10px;
    font-weight: bold;
    text-transform: uppercase;
    transition: all .17s ease;
    color: #fff;
    background: #0088ff;
    border-radius: 2px;
}
a {
    color: #0088ff;
}
a, a:visited {
    text-decoration: none;
}
        /*clear*/
        .clearfix {
    clear: both;
}
        /*wrap*/
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
     .post-meta .post-author:before {
    content: '\f2c0';
}

.post-meta span:before {
    font-family: FontAwesome;
    font-weight: 400;
    margin: 0 3px 0 0;
}
.post-meta a {
    color: #aaa;
    transition: color .17s;
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
    </style>



    <div id="main-wrapper" style="position: relative; overflow: visible; box-sizing: border-box; min-height: 1px;">
      <div class="theiaStickySidebar" style="padding-top: 0px; padding-bottom: 1px; position: static; transform: none;">
             <div class="widget Blog" id="Blog1">
                 <div class="home-posts-headline title-wrap Label">
                     <h3 class="title">Các bài đăng gần đây</h3>
                     <a class="view-all"href="#">Xem tất cả</a>
                 </div>
                 <div class="clearfix"></div>
                 <div class="blog-posts hfeed container index-post-wrap">
                        <div class="blog-post hentry index-post">
            <div class="post-image-wrap">
                <a class="post-image-link"href="#"><img alt="🔥🔥Duy Nhất Chỉ 1 Không 2 Căn Jamila Giá Thấp Nhất Thị Trường"class="post-thumb lazy-yard"src="https://1.bp.blogspot.com/-FvK2llCDJmc/X1JTzAcMmvI/AAAAAAAAAEM/wCqeap2ct0wOTvIa6RnRrmdCnZAkp8cVgCLcBGAsYHQ/w640/14.jpg" /></a>
            </div>
            <div class="post-info">
                <h2 class="post-title"><a href="#">🔥🔥Duy Nhất Chỉ 1 Không 2 Căn Jamila Giá Thấp Nhất Thị Trường</a></h2>
                <div class="post-meta">
                    <span class="post-author">
                        <a href="https://www.blogger.com/profile/02836254889699853818"target="_blank"title="Lê Lưu Kì Lân"> Lê Hoàng</a>
                    </span>
                    <span class="post-date published">7/01/2021 01:48:00 CH</span>
                </div>
                <p class="post-snippet">- Cần gấp tiền nên bán gấp. Chỉ bán trong tháng 9. Bàn giao nội thất cơ bản, nội thất dính tường, có bếp, máy lạnh,…2 phòng ngủ, diện tích 73m2.    …</p>
                <a class="read-more" href="#">Xem thêm »</a>
            </div>
        </div>
                        <div class="blog-post hentry index-post">
                            <div class="post-image-wrap">
                                <a class="post-image-link" href="#">
                                    <img alt="✅BÁN - CHO THUÊ CĂN HỘ CHUNG CƯ THE KRISTA QUẬN 2 GIÁ TỐT" class="post-thumb lazy-yard" src="https://1.bp.blogspot.com/-jSQSQlVh7EQ/X_wJjhECk9I/AAAAAAAABt8/sNsvLSaRFLYxoaWHq8Ek8ibFPEpOn-sfwCLcBGAsYHQ/w640/1.jpg" height="195px";width="260px" />
                                </a>
                            </div>
                            <div class="post-info">
                                <h2 class="post-title">
                                    <a href="#">
                                        ✅BÁN - CHO THUÊ CĂN HỘ CHUNG CƯ THE KRISTA QUẬN 2 GIÁ TỐT
                                    </a>
                                </h2>
                                <div class="post-meta">
                                    <span class="post-author">
                       
                                        <a href="https://draft.blogger.com/profile/02836254889699853818"target="_blank"title="Lê Lưu kì Lân">Lê Hoàng</a>
                                    </span>
                                    <span class="post-date published" >
                        
                                        01/08/2021 01:47:00 CH
                                    </span>
                                </div>
                                <p class="post-snippet">
                                    Đánh giá: ⭐⭐⭐⭐⭐ - Địa chỉ:  537 Nguyễn Duy Trinh, P. Bình Trưng Tây, Quận 2. 💥 BẢNG GIÁ BÁN CĂN HỘ THE KRISTA: * Loại căn 2 phòng ngủ - diện tích 80…
                                </p>
                                <a class="read-more"href="#">
                                    Xem thêm »
             
                                </a>
                            </div>
                        </div>
                        <div class="blog-post hentry index-post">
                            <div class="post-image-wrap">
                                <a class="post-image-link" href="#">
                                    <img alt="⚡⚡Cần Tiền Bán Nhanh Căn Jamila 3 PN Gía Rẻ" class="post-thumb lazy-yard"src="https://1.bp.blogspot.com/-3UQSZK42oLk/X1JVeTbGTsI/AAAAAAAAAFc/URfBClw_mQcNQivmcybYTD02m_FzacvyQCLcBGAsYHQ/w640/23.jpg"/>
                                </a>
                            </div>
                            <div class="post-info">
                                <h2 class="post-title"><a href="#">⚡⚡Cần Tiền Bán Nhanh Căn Jamila 3 PN Gía Rẻ</a></h2>
                                <div class="post-meta">
                                    <span class="post-author">
                        
                                        <a href="https://draft.blogger.com/profile/02836254889699853818"target="_blank"title="Lê Lưu Kì Lân"> Lê Hoàng</a>
                                    </span>
                                    <span class="post-date published">01/08/2021 01:47:00 CH</span>
                                </div>
                                <p class="post-snippet">- Diện tích 93m2, Full nội thất (Gồm tủ bếp, máy hút mùi, tủ trang trí, tủ giày gỗ sồi nguyên tấm, máy nước nóng, máy giặt, 4 máy lạnh, rèm cửa). …</p>
                                <a class="read-more"href="#">Xem thêm »</a>
                            </div>
                        </div>
                        <div class="blog-post hentry index-post">
                            <div class="post-image-wrap">
                                <a class="post-image-link" href="#">
                                    <img  alt="🔔🔔Bán Nhanh Căn Hộ Feliz En Vista 4 PN Quận 2 Gía 10.9 Tỷ"class="post-thumb lazy-yard"src="https://1.bp.blogspot.com/-hS0Olszc-Mw/X36bkaYP6JI/AAAAAAAAAX0/pyq0tUikf9EwzY6jojuTxLIztLpBjYqvQCLcBGAsYHQ/w640/2.jpg"/>
                                </a>
                            </div>
                            <div class="post-info">
                                <h2 class="post-title"><a href="#">🔔🔔Bán Nhanh Căn Hộ Feliz En Vista 4 PN Quận 2 Gía 10.9 Tỷ</a></h2>
                                <div class="post-meta">
                                    <span class="post-author"><a href="https://www.blogger.com/profile/02836254889699853818"target="_blank"title="Lê Lưu Kì Lân">Lê Hoàng</a></span>
                                    <span class="post-date published">01/08/2021 01:53:00 CH</span>
                                </div>
                                <p class="post-snippet">- Diện Tích: 181,09 m2 .   - Hoàn Thiện Chủ Đầu Tư .   - Bán Giá: 10,9  Tỷ (Bao Gồm Thuế + Phí).   ⭐⭐⭐⭐⭐⭐⭐   Thông Tin Liên Hệ:   📞 Hotline (Zalo): …</p>
                                <a class="read-more" href="#">Xem thêm »</a>
                            </div>
                        </div>
                 </div>
             </div>
       
      </div>
       
    </div>
    

    <section></section>
</asp:Content>
