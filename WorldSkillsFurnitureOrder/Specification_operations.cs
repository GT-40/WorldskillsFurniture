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
    
    public partial class Specification_operations
    {
        public string Product { get; set; }
        public string Operation { get; set; }
        public int Serial_number { get; set; }
        public string Equipment_type { get; set; }
        public System.TimeSpan Operation_time { get; set; }
    
        public virtual Equipment_type Equipment_type1 { get; set; }
        public virtual Products Products { get; set; }
    }
}
