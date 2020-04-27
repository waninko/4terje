using System;
using System.Collections.Generic;
using System.Text;

namespace animals_classes_interface
{
    class Reptile : Vertibrate, IBirthType
    {
        public string BirthType()
        {
            return "Born as eggs.";
        }
    }
}
