using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder.Infrastructure;

namespace Builder.Core
{
    public class Baker
    {
        public Bread Bake(BreadBuilder bread)
        {
            bread.CreateBread();
            bread.SetFlour();
            bread.SetSalt();
            bread.SetAdditives();
            return bread.Bread;
        }
    }
}
