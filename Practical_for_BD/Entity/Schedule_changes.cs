//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Practical_for_BD.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Schedule_changes
    {
        public long ID { get; set; }
        public long ID_route { get; set; }
        public Nullable<System.DateTime> Date_time { get; set; }
        public string Reason { get; set; }
    }
}
