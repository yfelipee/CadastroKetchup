using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroKetchup.Entities
{
    public class Calcular
    {
        MarcaKetchup marcaKetchup = new MarcaKetchup();
        public double ContaCalcular() {
            marcaKetchup.preço += 10;
            return marcaKetchup.preço;
        }
    }
}
