using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Detetive
{
    class Lugares
    {
        public string Nome { get; set; }
        public Image Imagem { get; set; }
    }
    class Pessoas
    {
        public string Nome { get; set; }
        public Image Imagem { get; set; }        
    }
    class Armas
    {
        public string Nome { get; set; }
        public Image Imagem { get; set; }        
    }
    class Assassino
    {   
        public Lugares Lugar { get; set; }
        public Pessoas Pessoa { get; set; }
        public Armas Arma { get; set; }
        
    }
}
