using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba3
{

    public partial class flat
    {
        
        public override  int GetHashCode()
        {
            int intRes = size + 1;
        
           
            return intRes;
        }
        public override bool Equals(object obj)
        {
            var Person = obj as flat;
            if (Person == null)
                return false;
            return Person.id == id && Person.number == number;
        }
        public override string ToString()
        {
            return "Flat: " + NUMBER + " " + FLOOR + " " + TIME;
        }


    }
}
