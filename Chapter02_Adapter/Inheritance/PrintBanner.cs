﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter02_Adapter.Inheritance;

public class PrintBanner : Banner, IPrint
{
    public PrintBanner(string str) : base(str)
    {
    }

    public void PrintStrong()
    {
        ShowWithAster();
    }

    public void PrintWeak()
    {
        ShowWithParen();
    }
}
