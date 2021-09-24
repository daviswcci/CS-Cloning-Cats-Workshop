using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cloning_Cats_924
{
    class Owner
    {
        public string Name;
        public int Age;

        public Owner(string name, int age)
        {
            Name = name;
            Age = age;
        }
        /// <summary>
        /// Returns a copy of this object, with copies of value types and references to reference types.
        /// </summary>
        /// <returns></returns>
        public Owner ShallowClone()
        {
            return (Owner) this.MemberwiseClone();
        }

        public Owner DeepClone()
        {
            return new Owner(Name, Age);
        }
    }
}
