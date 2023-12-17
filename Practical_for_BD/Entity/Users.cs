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
    using System.Linq;
    using System.Security.Cryptography.X509Certificates;

    public partial class Users
    {
        public long ID { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public long ID_Role_and_permission { get; set; }
        public long ID_Gender { get; set; }
        public long ID_Route { get; set; }
        public string Password { get; set; }
    
        public virtual Genders Genders { get; set; }
        public string Gender { get
            {
                using ( var db = new Public_transportEntities1())
                {
                    return db.Genders.Where(x => x.ID == ID_Gender).FirstOrDefault().Gender;
                }
            } 
        }
        public string Full_Name => Surname + " " + Name + " " + Patronymic;
        public virtual Roles_and_permissions Roles_and_permissions { get; set; }
        public virtual Routes Routes { get; set; }
        public string Route { get
            {
                using (var db = new Public_transportEntities1())
                {
                    return db.Routes.Where(x => x.ID == ID_Route).FirstOrDefault().Number_route;
                }
            } 
        }
    }
}
