﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eksamensoppgaver
{
    public class Informasjon
    {
        public Informasjon(string h, string c)
        {
            this.Header = h;
            this.Content = c;
        }
       public string Header{get;set;}
       public string Content { get; set; }
    }
}