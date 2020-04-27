﻿using System;
using System.Collections.Generic;
using System.Text;

namespace animals_classes_interface
{
    class Mammals : Vertibrate, IBirthType
    {
        public string name;
        public string sound;
        public string birth;
     
        public Mammals(string mammalName, string mammalSound, string mammalSpecialBirth = "Live Birth")
        {
            name = mammalName;
            sound = mammalSound;
            birth = mammalSpecialBirth;

        }

        public string makeSound()
        {
            return $"{sound}! ";
        }
        public virtual string BirthType()
        {
            return birth;
           
        }
    }
}