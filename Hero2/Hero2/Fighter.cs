using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hero2
{
    public class Fighter : FighterRole
    {

    private HealthRole health;
    private int speed;
    private int luck;
    private int strength;
    private int defense;

    public void strike(FighterRole defender)
    {
        defender.defend(strength);
    }

    public bool isDead()
    {
        return health.isDead();
    }

    public bool isAttackingFirst(FighterRole anotherFighter)
    {
        if (anotherFighter.hasSameSpeed(speed))
        {
            return anotherFighter.isLessLucky(luck);
        }
        return anotherFighter.isSlower(speed);
    }


    public bool hasSameSpeed(int otherSpeed)
    {
        return speed == otherSpeed;
    }


    public bool isLessLucky(int otherLuck)
    {
        return luck < otherLuck;
    }

    public bool isSlower(int otherSpeed)
    {
        return speed < otherSpeed;
    }

    public void defend(int strength)
    {
        if (iAmLucky())
        {
            return;
        }
        int damage = computeDamage(strength);
        applyDamage(damage);
    }

    private bool iAmLucky()
    {
        Random randomNumber = new Random();

        if (luck > randomNumber.Next(101))
        {
            return true;
        }
        return false;
    }

    private void applyDamage(int damage)
    {
        health.applyDamage(damage);
    }

    private int computeDamage(int attackerStrength)
    {
        return attackerStrength - defense;
    }

}
}
