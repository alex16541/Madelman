//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Madelman
{
    using System;
    using System.Collections.Generic;
    
    public partial class Furniture
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Furniture()
        {
            this.FurnitureSpec = new HashSet<FurnitureSpec>();
        }
    
        public int Id { get; set; }
        public string Articul { get; set; }
        public string Title { get; set; }
        public int UnitId { get; set; }
        public int Count { get; set; }
        public Nullable<int> ProviderId { get; set; }
        public byte[] Photo { get; set; }
        public string FurnitureType { get; set; }
        public decimal BuyCoast { get; set; }
        public Nullable<decimal> Weight { get; set; }
    
        public virtual Providers Providers { get; set; }
        public virtual Units Units { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FurnitureSpec> FurnitureSpec { get; set; }
    }
}
