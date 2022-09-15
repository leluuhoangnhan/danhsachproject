<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="DoAn_Web_LeLuuHoangNhan_Masterpage.Home" %>

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

 #hot-wrapper {
    box-sizing: border-box;
    padding: 0 20px;
}
#hot-wrapper, #featured-wrapper, #carousel-wrapper {
    margin: 0 auto;
}
.section, .widget, .widget ul {
    margin: 0;
    padding: 0;
}
#hot-section .show-hot .widget-content, #hot-section .hot-posts {
    height: auto;
}

#hot-section .show-hot .widget-content {
    position: relative;
    overflow: hidden;
    height: 380px;
    margin: 0 0 10px;
}
#hot-section .show-hot .widget-content, #hot-section .hot-posts {
    height: auto;
}

ul.hot-posts {
    position: relative;
    overflow: hidden;
    height: 380px;
    margin: 0 -5px;
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
.hot-posts .item-0 {
    width: 50%;
    height: 380px;
    padding-right: 0;
    padding-right: 5px;
}

.hot-posts .item-0 {
    width: 60%;
    height: 380px;
    padding-right: 5px;
}
.hot-posts .hot-item {
    position: relative;
    float: left;
    width: 40%;
    height: 185px;
    overflow: hidde
        n;
    box-sizing: border-box;
    padding: 0 5px;
    margin: 0;
}
ul li {
    list-style: none;
}
.hot-item-inner {
    position: relative;
    float: left;
    width: 100%;
    height: 100%;
    overflow: hidden;
    display: block;
}
.hot-posts .post-image-link {
    width: 100%;
    height: 100%;
    position: relative;
    overflow: hidden;
    display: block;
}

.post-image-link, .about-author .avatar-container, .comments .avatar-image-container {
    background-color: rgba(155,155,155,0.05);
    color: transparent!important;
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
.hot-posts .post-info {
    position: absolute;
    bottom: 0;
    left: 0;
    width: 100%;
    background-image: linear-gradient(rgba(0,0,0,0),rgba(0,0,0,0.7));
    overflow: hidden;
    z-index: 5;
    box-sizing: border-box;
    padding: 30px 20px 20px;
}
.hot-posts .item-0 .post-title {
    font-size: 22px;
}
.hot-posts .item-1 {
    margin: 0 0 10px;
}
.hot-posts .post-title {
    font-size: 17px;
    font-weight: 700;
    display: block;
    line-height: 1.5em;
    margin: 8px 0 7px;
}
.hot-posts .post-title a {
    color: #fff;
    display: block;
}
.post-title a {
    display: block;
}
/*a {
    color: #0088ff;
}
a, a:visited {
    text-decoration: none;
}*/
.hot-posts .post-meta {
    font-size: 11px;
    color: #f0f0f0;
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
.post-meta .post-date {
    text-transform: capitalize;
}
.clearfix {
    clear: both;
}
/* ad----*/
#ad-wrapper {
    margin: 0 auto;
}
.section, .widget, .widget ul {
    margin: 0;
    padding: 0;
}
a, abbr, acronym, address, applet, b, big, blockquote, body, caption, center, cite, code, dd, del, dfn, div, dl, dt, em, fieldset, font, form, h1, h2, h3, h4, h5, h6, html, i, iframe, img, ins, kbd, label, legend, li, object, p, pre, q, s, samp, small, span, strike, strong, sub, sup, table, tbody, td, tfoot, th, thead, tr, tt, u, ul, var {
    padding: 0;
    border: 0;
    outline: 0;
    vertical-align: baseline;
    background: 0 0;
    text-decoration: none;
}

#home-ad-top1 .widget-content {
    position: relative;
    max-width: 100%;
    max-height: 90px;
    line-height: 1;
    margin: 0 auto 20px;
}
element.style {
    clear: both;
    text-align: center;
}
.separator a {
    clear: none!important;
    float: none!important;
    margin-left: 0!important;
    margin-right: 0!important;
}/**/

.widget iframe, .widget img {
    max-width: 100%;
}
/*a img {
    border: 0;
}
img {
    border: none;
    */position: relative;
}
/*main wrap*/
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
/*a {
    color: #0088ff;
}
a, a:visited {
    text-decoration: none;
}*/
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
/*a img {
    border: 0;
}
img {
    border: none;
    position: relative;
}*/

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
/*blog paper*/
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
          <div id="hot-wrapper">
              <div class="section"id="hot-section">
                  <div class="widget-content">
                      <ul class="hot-posts">
                          <li class="hot-item item-0">
                              <div class="hot-item-inner" >
                                  <a class="post-image-link" href="thueVerandah.aspx">
                                      <img class="post-thumb lazy-yard"alt="Cho Thuê Căn Hộ One Verandah 2 Phòng Ngủ Quận 2 Giá Chỉ 18,5 Triệu"src="https://1.bp.blogspot.com/-hKGkR9ZBqkE/X37SZPsLSpI/AAAAAAAAAcE/fy-5Gr7_gRsXbA3E6fMPQUQLJoCoHYQqACLcBGAsYHQ/w680/1.jpg"/>
                                  </a>
                                  <div class="post-info">
                                      <h2 class="post-title"><a href="thueVerandah.aspx">Cho Thuê Căn Hộ One Verandah 2 Phòng Ngủ Quận 2 Giá Chỉ 18,5 Triệu</a></h2>
                                      <div class="post-meta">
                                          <span class="post-author">Lê Lưu Hoàng Nhân </span>
                                          <span class="post-date">July 23, 2021</span>
                                      </div>
                                  </div>
                              </div>
                          </li>
                          <li class="hot-item item-1">
                              <div class="hot-item-inner" >
                                  <a class="post-image-link" href="pagetuyendung.aspx">
                                      <img class="post-thumb lazy-yard"alt="Tuyển CTV Kinh Doanh Bất Động Sản Tại TP. Hồ Chí Minh"src="https://1.bp.blogspot.com/-nORk7IrA7dE/X38ivOb2FJI/AAAAAAAAAj8/G4KJs3JSyCQ7T0M4JmCt4cTnL-IBN8NpwCLcBGAsYHQ/w680/giup-do-ban-be-leo-nui.jpg""/>
                                  </a>
                                  <div class="post-info">
                                      <h2 class="post-title"><a href="pagetuyendung.aspx">Tuyển CTV Kinh Doanh Bất Động Sản Tại TP. Hồ Chí Minh</a></h2>
                                      <div class="post-meta">
                                          <span class="post-author">Lê Lưu Hoàng Nhân </span>
                                          <span class="post-date">July 05, 2021</span>
                                      </div>
                                  </div>
                              </div>
                          </li>
                           <li class="hot-item item-2">
                              <div class="hot-item-inner" >
                                  <a class="post-image-link" href="thueJamilaQ9.aspx">
                                      <img class="post-thumb lazy-yard"alt="Cho Thuê Căn Hộ Jamila Khang Điền Quận 9 Giá Cực Tốt"src="https://1.bp.blogspot.com/-F8fEJlsBmzs/X6fYAG9xd7I/AAAAAAAABmI/oIZme1YnddoKY_T6TYFmDxaN6vioe91HwCLcBGAsYHQ/w680/1.jpg"/>
                                  </a>
                                  <div class="post-info">
                                      <h2 class="post-title"><a href="thueJamilaQ9.aspx">Cho Thuê Căn Hộ Jamila Khang Điền Quận 9 Giá Cực Tốt</a></h2>
                                      <div class="post-meta">
                                          <span class="post-author">Lê Lưu Hoàng Nhân </span>
                                          <span class="post-date">July 13, 2021</span>
                                      </div>
                                  </div>
                              </div>
                          </li>
                           <li class="hot-item item-3">
                              <div class="hot-item-inner" >
                                  <a class="post-image-link" href="BanJamiLaQ9.aspx">
                                      <img class="post-thumb lazy-yard"alt="Bán Nhanh Căn Hộ Jamila Khang Điền Quận 9 Giá Siêu Hot"src="https://1.bp.blogspot.com/-aDQ-L1AUAtw/X6fZRVC3QMI/AAAAAAAABnY/wixeMMork4gH9cXKDqByiuFe0PyugHfywCLcBGAsYHQ/w640/1.jpg"/>
                                  </a>
                                  <div class="post-info">
                                      <h2 class="post-title"><a href="BanJamiLaQ9.aspx">Bán Nhanh Căn Hộ Jamila Khang Điền Quận 9 Giá Siêu Hot</a></h2>
                                      <div class="post-meta">
                                          <span class="post-author">Lê Lưu Hoàng Nhân </span>
                                          <span class="post-date">July 13, 2021</span>
                                      </div>
                                  </div>
                              </div>
                          </li>
                      </ul>
                  </div>
              </div>
          </div><br />   
          <div class="clearfix"></div>
          <div id="ad-wrapper">
              <div class="section"id="home-ad-top1">
                  <div class="widget-content">
                      <div class="separator"style="clear: both; text-align: center;">
                          <a href="#" style="margin-left: 1em; margin-right: 1em;">
                              <img data-original-height="90"data-original-width="780" src="https://1.bp.blogspot.com/-t0NUFEA7GVo/YLuCOcJWXqI/AAAAAAAAB3Y/scUmunWfq-sbtrTaODcV7o6MIxY0EN8YwCLcBGAsYHQ/s0/830_90.gif" width="780" height="90"/>
                          </a>
                      </div>
                  </div>
              </div>
          </div>
           <div class="clearfix"></div>
          <div class="widget Blog" id="Blog1">
                <div class="home-posts-headline title-wrap Label">
                     <h3 class="title">Các bài đăng gần đây</h3>
                     <a class="view-all"href="#">Xem tất cả</a>
                 </div>
                 <div class="clearfix"></div>
                 <div class="blog-posts hfeed container index-post-wrap">
                           <div class="blog-post hentry index-post">
                                <div class="post-image-wrap">
                                    <a class="post-image-link"href="thueVerandah.aspx"><img alt="Cho Thuê Căn Hộ One Verandah 2 Phòng Ngủ Quận 2 Giá Chỉ 18,5 Triệu"class="post-thumb lazy-yard"src="https://1.bp.blogspot.com/-hKGkR9ZBqkE/X37SZPsLSpI/AAAAAAAAAcE/fy-5Gr7_gRsXbA3E6fMPQUQLJoCoHYQqACLcBGAsYHQ/w640/1.jpg" /></a>
                                </div>
                                <div class="post-info">
                                    <h2 class="post-title"><a href="thueVerandah.aspx">Cho Thuê Căn Hộ One Verandah 2 Phòng Ngủ Quận 2 Giá Chỉ 18,5 Triệu</a></h2>
                                    <div class="post-meta">
                                        <span class="post-author">
                                            <a href="https://www.blogger.com/profile/02836254889699853818"target="_blank"title="Student"> Lê Hoàng</a>
                                        </span>
                                        <span class="post-date published">7/01/2021 01:48:00 CH</span>
                                    </div>
                                    <p class="post-snippet">- Diện Tích: 82 m2. - Full Nội Thất (Chỉ Cần Dọn Quần Áo Vào Ở) . - Cho Thuê Giá: 18,5  Triệu/ Tháng  (Bao Phí Quản Lí) .   ⭐⭐⭐⭐⭐⭐⭐   Thông Tin Liên …</p>
                                    <a class="read-more" href="thueVerandah.aspx">Xem thêm »</a>
                                </div>
                            </div>

                             <div class="blog-post hentry index-post">
                        <br />
                        <div class="post-image-wrap">
                            <a class="post-image-link" href="tuyendung001.aspx">
                                <img alt="✅TUYỂN CỘNG TÁC VIÊN KINH DOANH BẤT ĐỘNG SẢN TẠI TP. HCM" class="post-thumb lazy-yard" src="https://1.bp.blogspot.com/-nORk7IrA7dE/X38ivOb2FJI/AAAAAAAAAj8/G4KJs3JSyCQ7T0M4JmCt4cTnL-IBN8NpwCLcBGAsYHQ/w640/giup-do-ban-be-leo-nui.jpg" />
                            </a>
                        </div>
                        <div class="post-info">
                            <h2 class="post-title">
                                <a href="tuyendung001.aspx">✅TUYỂN CỘNG TÁC VIÊN KINH DOANH BẤT ĐỘNG SẢN TẠI TP. HCM</a>
                            </h2>
                            <p class="post-snippet">- Số lượng: 5 người. - Thời gian tuyển: Từ 08/10 - 29/10.  (❗️❗️❗️ Tuyển đủ không tuyển nữa) - Công việc: Đăng bài, chăm sóc khách hàng,…(Không cần d…</p>
                            <a class="read-more" href="pagetuyendung.aspx">Xem thêm » 
                               
                            </a>
                        </div>
                    </div>

                      <div class="blog-post hentry index-post">
            <div class="post-image-wrap">
                <a class="post-image-link"href="#"><img alt="✅Cho Thuê Căn Hộ Jamila Khang Điền Quận 9 Giá Cực Tốt"class="post-thumb lazy-yard"src="https://1.bp.blogspot.com/-F8fEJlsBmzs/X6fYAG9xd7I/AAAAAAAABmI/oIZme1YnddoKY_T6TYFmDxaN6vioe91HwCLcBGAsYHQ/w640/1.jpg"/></a>
            </div>
            <div class="post-info">
                 <h2 class="post-title"><a href="#">✅Cho Thuê Căn Hộ Jamila Khang Điền Quận 9 Giá Cực Tốt</a></h2>
                <div class="post-meta">
                    <span class="post-author"><a href="https://www.blogger.com/profile/02836254889699853818"target="_blank"title="Lê Lưu Kì Lân">Lê Hoàng</a></span>
                    <span class="post-date published"> 01/08/2021 01:41:00 CH</span>
                </div>
                <p class="post-snippet">💐 2 Phòng Ngủ: 6,5 Triệu/ Tháng   💐 3 Phòng Ngủ: 11,5 Triệu/ Tháng Thông Tin Liên Hệ:  (24/7)   📞 Hotline (Zalo): 0938.237.485  – 0925.584.992   ?…</p>
                <a class="read-more"href="BanJamiLaQ9.aspx">Xem thêm »</a>
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
                <a class="read-more"href="BanKrisvueq2.aspx">Xem thêm »</a>
            </div>
        </div>
                     </div>
                <div class="blog-pager container"id="blog-pager">
                    <span class="page-num page-active">1</span>
                    <a class="page-num" href="Homepage2.aspx" onclick="getPage(2);return false">2</a>
                    <span class="page-num page-dots">...</span>
                    <a class="page-num" href="Homepage2.aspx" onclick="getPage(2);return false">next</a>
                </div>
                 </div>
          </div>
        </div>
</asp:Content>
