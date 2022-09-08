using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoInheritances
{
    public class mySpecializedClass : baseclass, IMyInterface


    {
        

        public string MySpecializedProperty { get; set; }

        public mySpecializedClass(string mySpecializedProperty)
            :this("defaultvalue",mySpecializedProperty)
        {
            
        }

        public mySpecializedClass(string myBaseProperty,string mySpecializedProperty)
            : base(myBaseProperty)
        {
            MySpecializedProperty = mySpecializedProperty;
        }

        public override string MyBaseMethod()
        {
            return base.MyBaseMethod() + "InMyspecilaizedMethod";
            //return base.MyBaseMethod();
        }

        public override string MyAbstractMethod()
        {
            throw new NotImplementedException();
        }

        public string MyInterfaceMethod()
        {
            throw new NotImplementedException();
        }
    }
}
