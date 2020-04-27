using System;
using System.Collections.Generic;
using System.Text;

namespace animals_classes_interface
{
    class Amphibian : Vertibrate, IBirthType
    {
        public string BirthType()
        {
            return"Born as eggs.";
        }
    }
}
