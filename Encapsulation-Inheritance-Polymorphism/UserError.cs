﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_Inheritance_Polymorphism
{
    public abstract class UserError
    {
        public virtual string UEMessage()
        {
            return "Generic User Error Message!";
        }
    }
}
