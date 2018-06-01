using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeGaverbeekProject.Domain.DAO
{
    public class EntityDAO
    {
        public Entity getByID(int ID)
        {
            using (var db = new WebShopDBContext())
            {
                return null;
            }
        }
    }
}
