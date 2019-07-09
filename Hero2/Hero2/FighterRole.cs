using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hero2
{
    public interface FighterRole 
    {
        void strike(FighterRole defender);

        bool isDead();

        bool isAttackingFirst(FighterRole fighter2);

        bool hasSameSpeed(int speed);

        bool isLessLucky(int luck);

        bool isSlower(int speed);

        void defend(int strength);
    }
}
