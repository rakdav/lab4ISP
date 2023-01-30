using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    internal class Monster<T>:ICloneable,IComparable
    {
        private int life;
        private int ammo;
        public string Name { get; set; }
        public int Life
        {
            get { return life; }
            set { if(value>0&&value<=100)life = value; }
        }
        public T? Id { get; set; }
        public int Ammo
        {
            get { return ammo; }
            set { if(value>0&&value<=500) ammo = value; }
        }
        public Monster(string name, int life, T? id, int ammo)
        {
            Name = name;
            Life = life;
            Id = id;
            Ammo = ammo;
        }

        public object Clone()
        {
            return new Monster<T>(Name=this.Name,
            Life=this.Life,Id=this.Id,Ammo=this.Ammo);
        }

        public int CompareTo(object? obj)
        {   if (obj is Monster<T>)
            {
                var monster = obj as Monster<T>;
                if (this.Life > monster?.Life) return 1;
                else if (this.Life < monster?.Life) return -1;
                return 0;
            }
            else
                throw new Exception("Невозможно сравнить");
        }

        public override string? ToString()
        {
            return $"Имя: {Name} Жизнь:{Life} Id:{Id} " +
                $"Боезапас:{Ammo}";
        }
    }
}
