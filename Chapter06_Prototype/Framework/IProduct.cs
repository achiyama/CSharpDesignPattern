﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter06_Prototype.Framework;
public interface IProduct
{
    void Use(string s);

    IProduct CreateClone();
}
