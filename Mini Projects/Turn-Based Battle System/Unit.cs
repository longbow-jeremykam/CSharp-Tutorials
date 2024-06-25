using System;

public class Unit
{
	private int currentHp;
	private int maxHp;
	private int attackPower;
	private int healPower;
	private string unitName;
    public static Random rand;

    public Unit(int hp, int ap, int healP, string name)
    {
        this.maxHp = hp;
        this.currentHp = (this.maxHp > 0) ? this.maxHp : 1500;
        this.attackPower = ap;
        this.healPower = healP;
        this.unitName = name;
        rand = new Random();
    }

    public void Attack(Unit targetUnit)
    {
        double rng = rand.NextDouble();
        rng = (rng / 2) + 0.75f;
        int randDamage = (int) (attackPower * rng);
        Console.WriteLine((rng > 1.00) ? this.unitName + " lands a critical hit on " + targetUnit.unitName + ", dealing up to " + randDamage + " damage!!"
            : this.unitName + " attacks " + targetUnit.unitName + " and deals " + randDamage + " damage!!");
        targetUnit.TakeDamage(randDamage);
    }

    public void TakeDamage(int damage)
    {
        currentHp -= damage;
    }

    public void Heal()
    {
        double rng = rand.NextDouble();
        rng = rng / 2;
        int healAmt = (int) (this.healPower * rng);
        this.currentHp = (currentHp + healAmt > currentHp + 1500)? maxHp: currentHp + healAmt;
        Console.WriteLine("{0} heals itself, increasing its HP by {1}!", this.unitName, healAmt);
    }

    public bool IsDead()
    {
        if (this.currentHp <= 0)
        {
            return true;
        }

        return false;
    }

    public int CurrentHp { get
        {
            if (currentHp < 0)
            {
                return 0;
            }
            return currentHp;
        }
        set
        {
            currentHp = 0;
        }
    }

    public int MaxHp
    {
        get
        {
            return maxHp;
        }
        set
        {
            MaxHp = value;
        }
    }

    public String Name
    {
        get
        {
            return unitName;
        }
        set
        {
            unitName = value;
        }
    }


}
