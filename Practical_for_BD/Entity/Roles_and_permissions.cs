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
    
    public partial class Roles_and_permissions
    {
        public Roles_and_permissions()
        {
            this.Users = new HashSet<Users>();
        }
    
        public long ID { get; set; }
        public long ID_Role { get; set; }
        public long ID_Permission { get; set; }
    
        public virtual Permissions Permissions { get; set; }
        public virtual Roles Roles { get; set; }
        public virtual ICollection<Users> Users { get; set; }
    }
}
