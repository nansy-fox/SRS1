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
    
    public partial class Weekdays
    {
        public Weekdays()
        {
            this.Day_routs = new HashSet<Day_routs>();
            this.Transports = new HashSet<Transports>();
        }
    
        public long ID { get; set; }
        public string Weekday { get; set; }
    
        public virtual ICollection<Day_routs> Day_routs { get; set; }
        public virtual ICollection<Transports> Transports { get; set; }
    }
}
