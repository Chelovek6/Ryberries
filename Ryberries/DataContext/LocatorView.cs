﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ryberries.DataContext
{
    public static class LocatorView
    {
        public static CurrentView CurrentView { get; set; } = new CurrentView();
    }
}
