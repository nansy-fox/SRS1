using Practical_for_BD.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_for_BD
{
    internal class Helper
    {
        private static Entity.Public_transportEntities1 transportEntities;
        Public_transportEntities1 db = Helper.GetContext();

        public static Public_transportEntities1 GetContext()
        {
            if (transportEntities == null)
            {
                transportEntities = new Entity.Public_transportEntities1();
            }
            return transportEntities;
        }
        public void Authorisation(string surname, string name)
        {
            var Login = db.Users.Where(e => e.Surname.Contains(surname) && e.Name.Contains(name));
        }
    }
}
