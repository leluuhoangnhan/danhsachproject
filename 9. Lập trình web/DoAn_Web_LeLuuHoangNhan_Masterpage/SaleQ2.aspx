<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="SaleQ2.aspx.cs" Inherits="DoAn_Web_LeLuuHoangNhan_Masterpage.SaleQ2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
     <style>     body {
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
}</style>

            <div id="main-wrapper" style="position: relative; overflow: visible; box-sizing: border-box; min-height: 1px;">
             <div class="theiaStickySidebar" style="padding-top: 0px; padding-bottom: 1px; position: static; transform: none;">
                 <div class="widget Blog" id="Blog1">
                    <div class="blog-posts hfeed container index-post-wrap">
                         <div class="blog-post hentry index-post">
            <div class="post-image-wrap">
                <a class="post-image-link"href="#"><img alt="✅Bán - Cho Thuê Căn Hộ Chung Cư La Astoria Quận 2 Giá Tốt"class="post-thumb lazy-yard"src="https://1.bp.blogspot.com/-kcN62QUKcRs/X_wEwA4BiCI/AAAAAAAABtQ/S5oqhyA-i_gikLLvkdPCFhqhIC29BVrqgCLcBGAsYHQ/w640/z2273583632209_e7419ff63b69a4b8178a583cb1fe7df0.jpg"/></a>
            </div>
            <div class="post-info">
                 <h2 class="post-title"><a href="#">✅Bán - Cho Thuê Căn Hộ Chung Cư La Astoria Quận 2 Giá Tốt</a></h2>
                <div class="post-meta">
                    <span class="post-author"><a href="https://www.blogger.com/profile/02836254889699853818"target="_blank"title="Lê Lưu Kì Lân">Lê Hoàng</a></span>
                    <span class="post-date published"> 01/08/2021 01:41:00 CH</span>
                </div>
                <p class="post-snippet">Địa chỉ: 383 Nguyễn Duy Trinh 🌻 BÁN - Loại 1 phòng ngủ offictel giá 1.5 tỷ - Loại 2 phòng ngủ và 1wc giá 2 tỷ - Loại 2 phòng ngủ 2wc giá 2.2 tỷ - Lo…</p>
                <a class="read-more"href="#">Xem thêm »</a>
            </div>
        </div>
        <div class="blog-post hentry index-post">
            <div class="post-image-wrap">
                <a class="post-image-link"href="#"><img alt="💥💥Bán Gấp Căn Hộ La Astoria Quận 2 Giá Chỉ 1 Tỷ 9 Bao Hết Giấy Tờ"class="post-thumb lazy-yard"src="https://1.bp.blogspot.com/-ouKo4_lZQfM/YNMbAgmP3vI/AAAAAAAACIs/3u3vM5Ub91M1FxWWx7hOrx-jBe-Hel12gCLcBGAsYHQ/w640/1.%2Bb%25C3%25A1n%2Bc%25C4%2583n%2Bh%25E1%25BB%2599%2Bla%2Bastoria%2Bgi%25C3%25A1%2Bt%25E1%25BB%2591t.jpg"/></a>
            </div>
            <div class="post-info">
                 <h2 class="post-title"><a href="#">💥💥Bán Gấp Căn Hộ La Astoria Quận 2 Giá Chỉ 1 Tỷ 9 Bao Hết Giấy Tờ</a></h2>
                <div class="post-meta">
                    <span class="post-author"><a href="https://www.blogger.com/profile/02836254889699853818"target="_blank"title="Lê Lưu Kì Lân">Lê Hoàng</a></span>
                    <span class="post-date published"> 01/08/2021 01:41:00 CH</span>
                </div>
                <p class="post-snippet">-  Địa chỉ : 383 Nguyễn Duy Trinh - P. Bình Trưng Tây - Quận 2. 🏡   Thông tin căn hộ: * Giá Bán:  1.9 tỷ (Bao hết thuế + phí + 5% sổ). * Loại căn hộ…</p>
                <a class="read-more"href="#">Xem thêm »</a>
            </div>
        </div>
        <div class="blog-post hentry index-post">
            <div class="post-image-wrap">
                <a class="post-image-link"href="#"><img alt="🔥🔥Parcspring Duy Nhất Chỉ 1 Không 2 Giá Rẻ Nhất Thị Trường🔥🔥"class="post-thumb lazy-yard"src="https://1.bp.blogspot.com/-LbRlNHubk30/X1SXdr3a6bI/AAAAAAAAALQ/jSiL9nzPSlsEbogChNNRLwzYOMtwnM4lQCLcBGAsYHQ/w640/5.jpg"/></a>
            </div>
            <div class="post-info">
                 <h2 class="post-title"><a href="#">🔥🔥Parcspring Duy Nhất Chỉ 1 Không 2 Giá Rẻ Nhất Thị Trường🔥🔥</a></h2>
                <div class="post-meta">
                    <span class="post-author"><a href="https://www.blogger.com/profile/02836254889699853818"target="_blank"title="Lê Lưu Kì Lân">Lê Hoàng</a></span>
                    <span class="post-date published"> 01/08/2021 01:41:00 CH</span>
                </div>
                <p class="post-snippet">- Cần bán gấp căn 3 phòng ngủ Parcspring, 88m2, Full nội thất rẻ nhất thị trường.     - Do đang cần vốn để làm ăn, nên để rẻ lại cho anh em giá chỉ …</p>
                <a class="read-more"href="#">Xem thêm »</a>
            </div>
        </div>
        <div class="blog-post hentry index-post">
            <div class="post-image-wrap">
                <a class="post-image-link"href="#"><img alt="🔥🔥Cần Bán Nhanh Căn Parcspring 2 Phòng Ngủ Giá Siêu Rẻ🔥🔥"class="post-thumb lazy-yard"src="https://1.bp.blogspot.com/-pjsOkyH05e4/X1SVDuHoNKI/AAAAAAAAAJA/Awsc4isvkq4RyD0EcMF9tu_OfaFbEUnbACLcBGAsYHQ/w640/z2058010203048_4b1183ee785dd70814f9ec1f2d840e8b.jpg"/></a>
            </div>
            <div class="post-info">
                 <h2 class="post-title"><a href="#">🔥🔥Cần Bán Nhanh Căn Parcspring 2 Phòng Ngủ Giá Siêu Rẻ🔥🔥</a></h2>
                <div class="post-meta">
                    <span class="post-author"><a href="https://www.blogger.com/profile/02836254889699853818"target="_blank"title="Lê Lưu Kì Lân">Lê Hoàng</a></span>
                    <span class="post-date published"> 01/08/2021 01:41:00 CH</span>
                </div>
                <p class="post-snippet">- Diện tích 69m2, nội thất cơ bản, đầy đủ giấy tờ sổ hồng.     - Cần tiền nên bán lỗ cho anh em giá chỉ 2,35 tỷ. (Giá thị trường 2,69 tỷ)   ✅Liên hệ…</p>
                <a class="read-more"href="#">Xem thêm »</a>
            </div>
        </div>
                        </div>
                     </div>
                 </div>
                </div>

       
</asp:Content>
