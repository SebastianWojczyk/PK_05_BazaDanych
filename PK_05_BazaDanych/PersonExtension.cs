﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PK_05_BazaDanych
{
    partial class Person
    {
        public override string ToString()
        {
            return $"{Name} ur. {BirthDate.ToLongDateString()} ({Height}cm)";
        }
    }
}
