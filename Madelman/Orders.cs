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
    
    public partial class Orders
    {
        public int Id { get; set; }
        public string Numver { get; set; }
        public System.DateTime Date { get; set; }
        public string Title { get; set; }
        public int ProductId { get; set; }
        public int CustomerId { get; set; }
        public int ManagerId { get; set; }
        public decimal Coast { get; set; }
        public System.DateTime DateOfComplet { get; set; }
        public string Files { get; set; }
    
        public virtual Products Products { get; set; }
        public virtual Users Users { get; set; }
        public virtual Users Users1 { get; set; }
    }
}
