//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Worldskills
{
    using System;
    using System.Collections.Generic;
    
    public partial class Specification_assembly_unit
    {
        public string Product { get; set; }
        public string Assembly_unit { get; set; }
        public int Quantity { get; set; }
    
        public virtual Products Products { get; set; }
        public virtual Products Products1 { get; set; }
    }
}
