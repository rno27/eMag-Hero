using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hero2
{
    public interface HealthRole
    {
        bool isDead();

        void applyDamage(int damage);
    }
}
