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
    
    public partial class Transporter
    {
        public Transporter()
        {
            this.Routes = new HashSet<Routes>();
        }
    
        public long ID { get; set; }
        public string Name_transporter { get; set; }
    
        public virtual ICollection<Routes> Routes { get; set; }
    }
}
