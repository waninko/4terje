using System;
using System.Collections.Generic;
using System.Text;

namespace animals_classes_interface
{
    abstract class Vertibrate
    {
        bool hasSpine = true;

        public virtual string Breathe()
        {
            return "Breathes oxygen using lungs.";
        }

        public virtual string Born()
        {
            return "Given birth to by mother.";
        }

      

        public string Die()
        {
            return "Can die.";
        }
    }
}
