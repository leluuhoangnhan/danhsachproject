using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqToExcel;
using LinqToExcel.Attributes;

namespace DemoDocFileExcelDriveGoogle.Model
{
    class RoHang
    {
        [ExcelColumn("STT")]
        public string stt { get; set; }

        [ExcelColumn("Mã Căn")]
        public string maCan { get; set; }

        [ExcelColumn("Số PN")]
        public string soPN{ get; set; }

        [ExcelColumn("Diện Tích")]
        public string dienTich { get; set; }

        [ExcelColumn("Giá")]
        public string gia { get; set; }

        [ExcelColumn("Chi Tiết")]
        public string chiTiet { get; set; }

        [ExcelColumn("Tình Trạng")]
        public string tinhTrang { get; set; }

        [ExcelColumn("Pháp Lý")]
        public string phapLy { get; set; }

        [ExcelColumn("Ghi Chú")]
        public string ghiChu { get; set; }
    }
}
