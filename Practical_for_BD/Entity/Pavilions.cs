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
    
    public partial class Pavilions
    {
        public Pavilions()
        {
            this.Transport_stop = new HashSet<Transport_stop>();
        }
    
        public long ID { get; set; }
        public string Name_pavilion { get; set; }
    
        public virtual ICollection<Transport_stop> Transport_stop { get; set; }
    }
}
