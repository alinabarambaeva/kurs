//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace kurs
{
    using System;
    using System.Collections.Generic;
    
    public partial class Request
    {
        public int id_request { get; set; }
        public Nullable<int> id_client { get; set; }
        public Nullable<int> id_worker { get; set; }
        public Nullable<int> id_device { get; set; }
        public Nullable<int> id_time1 { get; set; }
        public Nullable<int> id_time2 { get; set; }
        public Nullable<int> id_type_of_repair { get; set; }
        public Nullable<int> id_price { get; set; }
        public Nullable<int> id_warranty { get; set; }
    
        public virtual Clients Clients { get; set; }
        public virtual Devices Devices { get; set; }
        public virtual Price Price { get; set; }
        public virtual Times1 Times1 { get; set; }
        public virtual Times2 Times2 { get; set; }
        public virtual Type_of_repair Type_of_repair { get; set; }
        public virtual Warranty Warranty { get; set; }
        public virtual Workers Workers { get; set; }
    }
}
