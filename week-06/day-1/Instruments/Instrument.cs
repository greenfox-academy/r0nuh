﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instruments
{
    public abstract class Instrument
    {
        protected string name;

        public abstract void Play();

    }
}