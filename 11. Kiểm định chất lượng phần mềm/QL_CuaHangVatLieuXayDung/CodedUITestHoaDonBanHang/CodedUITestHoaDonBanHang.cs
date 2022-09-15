using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;


namespace CodedUITestHoaDonBanHang
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class CodedUITestHoaDonBanHang
    {
        public CodedUITestHoaDonBanHang()
        {
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\TestData_ThemHD.xml", "Addition",DataAccessMethod.Sequential)]
        public void CodedUITestMethod_Them()
        {
            String maHD = this.TestContext.DataRow["MaHD"].ToString();
            String tenKH = this.TestContext.DataRow["TenKH"].ToString();
            String tenNV = this.TestContext.DataRow["TenNV"].ToString();
            String ngayLap = this.TestContext.DataRow["NgayLap"].ToString();
            String tenSP = this.TestContext.DataRow["TenSP"].ToString();
            float donGia = float.Parse(this.TestContext.DataRow["DonGia"].ToString());
            String donViTinh = this.TestContext.DataRow["DonViTinh"].ToString();
            int soLuong = int.Parse(this.TestContext.DataRow["SoLuong"].ToString());
            float thanhTien = donGia * soLuong;
            String kq_MongDoi = this.TestContext.DataRow["KetQuaMongDoi"].ToString();

            this.UIMap.RecordedMethod_ThemHDParams.UITxtMaHDEditText = maHD;
            this.UIMap.RecordedMethod_ThemHDParams.UIĐơnvịtínhComboBoxSelectedItem = tenKH; //Combobox khách hàng chính xác (Đã check không sai)
            this.UIMap.RecordedMethod_ThemHDParams.UICboTenNVComboBoxSelectedItem = tenNV;
            this.UIMap.RecordedMethod_ThemHDParams.UIDtpNgayLapDateTimePickerDateTimeAsString = ngayLap;
            this.UIMap.RecordedMethod_ThemHDParams.UICboTenSanPhamComboBoxSelectedItem = tenSP;
            this.UIMap.RecordedMethod_ThemHDParams.UITxtDonGiaEditText = donGia.ToString();
            this.UIMap.RecordedMethod_ThemHDParams.UICboDVTComboBoxSelectedItem = donViTinh;
            this.UIMap.RecordedMethod_ThemHDParams.UITxtSoLuongEditText = soLuong.ToString();
            this.UIMap.AssertMethod_ThemHDExpectedValues.UILblThongBaoEditControlName = kq_MongDoi;

            this.UIMap.RecordedMethod_ThemHD();
            this.UIMap.AssertMethod_ThemHD();
        }

        #region Additional test attributes

        // You can use the following additional attributes as you write your tests:

        ////Use TestInitialize to run code before running each test 
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        ////Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        #endregion

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        private TestContext testContextInstance;

        public UIMap UIMap
        {
            get
            {
                if ((this.map == null))
                {
                    this.map = new UIMap();
                }

                return this.map;
            }
        }

        private UIMap map;
    }
}
