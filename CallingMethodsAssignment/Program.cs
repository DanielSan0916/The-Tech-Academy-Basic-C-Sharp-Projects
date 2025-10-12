//MathMethod.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsAssignment
{
    public class MathMethods
    {
        //Create three methods that take one integer parameter and return an integer
        //First method is Heal (int magic)
        public static int Heal(int magic)
        {
            int hitpoints = magic * 10;
            return hitpoints;
        }

        //Second method is Defense (int defense)
        public static int Defense(int defense)
        {
            int enemy_str = 7;
            int weapon_mt = 11;
            int triangle_bonus = -1;
            int crit_coeff = 2;
            int damage = (enemy_str + (weapon_mt + triangle_bonus) - defense) * crit_coeff;
            return damage;
        }

        //Third method is Attack (int strength)
        public static int Attack(int strength)
        {
            int enemy_def = 5;
            int weapon_mt = 8;
            int triangle_bonus = 1;
            int crit_coeff = 2;
            int damage = (strength + weapon_mt + triangle_bonus - enemy_def) * crit_coeff;
            return damage;
        }
    }
}

namespace CallingMethodsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("You've encountered Predator the Brigand and he launches a surprise attack.");
            Console.WriteLine("Input your defense stat:");
            int defense = Convert.ToInt32(Console.ReadLine());
            int enemy_damage = MathMethods.Defense(defense);
            Console.WriteLine("You have taken " + enemy_damage + " HP of damage.");
            Console.WriteLine("Your healer, Serra is near by. SHe heals you with her staff.");
            Console.WriteLine("Input your healer's magic stat:");
            int magic = Convert.ToInt32(Console.ReadLine());
            int hitpoints = MathMethods.Heal(magic);
            Console.WriteLine("You have been healed for " + hitpoints + " HP.");
            Console.WriteLine("You are ready to counter attack.");
            Console.WriteLine("Input your strength stat:");
            int strength = Convert.ToInt32(Console.ReadLine());
            int damage = MathMethods.Attack(strength);
            Console.WriteLine("You have landed a critical attack and dealt " + damage + " HP worth of damage.");
            Console.ReadLine();
        }
    }
}