//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace GameMall_Data.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Goods
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Goods()
        {
            this.Orders = new HashSet<Orders>();
            this.Screenshot = new HashSet<Screenshot>();
            this.ShoppingCars = new HashSet<ShoppingCars>();
            this.StockLog = new HashSet<StockLog>();
            this.Versions = new HashSet<Versions>();
        }
    
        public int GoodsId { get; set; }
        public string GoodsName { get; set; }
        public string Detail { get; set; }
        public string Configuration { get; set; }
        public string InstallWay { get; set; }
        public int Type { get; set; }
        public int TotalSales { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Orders> Orders { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Screenshot> Screenshot { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShoppingCars> ShoppingCars { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StockLog> StockLog { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Versions> Versions { get; set; }
    }
}
