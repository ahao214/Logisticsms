//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Logisticsms.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class AirTransport
    {
        public int Id { get; set; }
        public Nullable<int> MemberId { get; set; }
        public Nullable<int> CustomerId { get; set; }
        public string OrderNumber { get; set; }
        public string SourcePlace { get; set; }
        public string TargetPlace { get; set; }
        public Nullable<System.DateTime> InsertDate { get; set; }
        public string Tag { get; set; }
    }
}
