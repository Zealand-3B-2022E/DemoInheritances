using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoInheritances
{
    public abstract class baseclass
    {
        public abstract string MyAbstractMethod();

        public baseclass(string myBaseProperty)
        {
            MyBaseProperty = myBaseProperty;
        }

        public string MyBaseProperty { get; set; }

        public virtual string MyBaseMethod()
        {
            return "in MyBaseMethod()";
        }



    }
}
