using System;
using System.Collections.Generic;
using System.Text;

namespace animals_classes_interface
{
    class Fish : Vertibrate , IBirthType
    {
        public virtual string BirthType()
        {
            return "Born as eggs.";
        }

        public override string Breathe()
        {
            return "Breathes oxygen using gills.";
        }
        
       
      
    }
}
