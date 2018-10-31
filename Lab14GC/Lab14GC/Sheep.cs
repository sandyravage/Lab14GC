using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14GC
{
    public class Sheep : ICloneable, ICountable
    {
        protected int Count;
        protected string Name;

        public Sheep(string name)
        {
            Name = name;
        }

        public string GetName()
        {
            return Name;
        }
        
        public object Clone()
        {
            Sheep x = (Sheep) this.MemberwiseClone();
            x.Name = "Dolly";
            return x;
        }

        public void IncrementCount()
        {
            Count++;
        }

        public void ResetCount()
        {
            Count = 0;
        }

        public int GetCount()
        {
            return Count;
        }

        public string GetCountString()
        {
            return Count.ToString();
        }
    }
}
