using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dia6
{
    partial class CuentaCorriente
    {
        private String moneda;
        private String propietario;
        private double saldo;

        public CuentaCorriente(string moneda, string propietario, double saldo)
        {
            this.moneda = moneda;
            this.propietario = propietario;
            this.saldo = saldo;
        }

    }
}
