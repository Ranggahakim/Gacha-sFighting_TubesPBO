using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Gacha_sFighting
{
    abstract public class Character
    {
        public string Name { get; set; }
        public int HP { get; set; }
        public int MaxHP { get; set; }
        public int AtkDamage { get; set; }
        public int HealAmount { get; set; }

        abstract public string DoAction();

        public Character(string name, int hp, int atkDamage, int healAmount)
        {
            Name = name;
            HP = hp;
            MaxHP = hp; // Max HP sama dengan HP awal
            AtkDamage = atkDamage;
            HealAmount = healAmount;
        }

        public void Attack(Character target)
        {
            target.HP -= AtkDamage;
        }

        // Metode Heal
        public virtual void Heal()
        {
            HP += HealAmount;
            if (HP > MaxHP)
                HP = MaxHP; // Tidak melebihi Max HP
        }
    }

    public class Assassin : Character
    {
        public Assassin() : base("Assassin", 100, 50, 30) { }

        public override string DoAction()
        {
            if(HP > 75)
            {
                return "Attack";
            }else
            {
                return "Heal";
            }
        }
    }

    public class NormalGuy : Character
    {
        public NormalGuy() : base("Normal Guy", 150, 30, 20) { }

        public override string DoAction()
        {
            if (HP > 75)
            {
                return "Attack";
            }
            else
            {
                return "Heal";
            }
        }
    }

    public class Tank : Character
    {
        public Tank() : base("Tank", 200, 20, 15) { }

        public override string DoAction()
        {
            if (HP > 150)
            {
                return "Attack";
            }
            else
            {
                return "Heal";
            }
        }
    }
}
