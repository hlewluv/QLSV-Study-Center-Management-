//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLSV
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblDiem
    {
        public string nguoitao { get; set; }
        public int mamonhoc { get; set; }
        public int magiaovien { get; set; }
        public string masinhvien { get; set; }
        public Nullable<double> diemTX { get; set; }
        public Nullable<double> diemGK { get; set; }
        public Nullable<double> diemCK { get; set; }
    
        public virtual tblGiaoVien tblGiaoVien { get; set; }
        public virtual tblMonHoc tblMonHoc { get; set; }
        public virtual tblSinhVien tblSinhVien { get; set; }
    }
}
