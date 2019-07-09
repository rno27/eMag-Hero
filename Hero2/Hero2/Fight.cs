using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hero2
{
    public class Fight : FightRole
    {
        private FighterRole attacker;
        private FighterRole defender;
        private int maxNrRounds { get; set; }


        public Fight(FighterRole fighter1, FighterRole fighter2, int maxNrRounds)
        {
            this.maxNrRounds = maxNrRounds;
            if (fighter1.isAttackingFirst(fighter2))
            {
                attacker = fighter1;
                defender = fighter2;
            }
            else{
                attacker = fighter2;
                defender = fighter1;
            }

        }

        public void proceed()
        {
            for (int round = 1; round <= maxNrRounds; round++)
            {
                attacker.strike(defender);
                if (defender.isDead())
                {
                    return;
                }

                switchRoles();
            }
        }

        private void switchRoles()
        {
            FighterRole auxFighter;
            auxFighter = defender;
            defender = attacker;
            attacker = auxFighter;
        }


    }

}
