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
    
    public partial class FurnitureSpec
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int FurnitureId { get; set; }
        public int Count { get; set; }
    
        public virtual Furniture Furniture { get; set; }
        public virtual Products Products { get; set; }
    }
}