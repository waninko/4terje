using System;
using System.Collections.Generic;
using System.Text;

namespace animals_classes_interface
{
   public class UserSelectAnimalGroup
    {
        public string selectedGroup;
        public UserSelectAnimalGroup(string userSelectedNumber)
        {
            selectedGroup = userSelectedNumber;
        }

        public string SetSelection()
        {
            if (selectedGroup == "1")
            {
                return "Mammal";
            }
            return "something else";
        }
    }
}
