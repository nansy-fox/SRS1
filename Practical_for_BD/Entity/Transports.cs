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
    
    public partial class Transports
    {
        public Transports()
        {
            this.Chart = new HashSet<Chart>();
            this.Day_routs = new HashSet<Day_routs>();
        }
    
        public long ID { get; set; }
        public long ID_type_transport { get; set; }
        public long ID_rout { get; set; }
        public long ID_weekday { get; set; }
    
        public virtual ICollection<Chart> Chart { get; set; }
        public virtual ICollection<Day_routs> Day_routs { get; set; }
        public virtual Routes Routes { get; set; }
        public virtual Types_transport Types_transport { get; set; }
        public virtual Weekdays Weekdays { get; set; }
    }
}
