using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eksamensoppgaver
{
    class Instrument
    {
        public Instrument(string name, Image image, string audioUrl)
        {
            this.Image = image;
            this.Name = name;
            this.URL = audioUrl;
        }
        public Image Image{ get; set; }
        public string Name { get; set; }
        public string URL { get; set; }
    }
}
