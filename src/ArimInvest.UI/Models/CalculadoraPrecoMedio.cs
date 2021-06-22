using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArimInvest.UI.Models
{
    public class CalculadoraPrecoMedio
    {
        public CalculadoraPrecoMedio(List<Compra> compras)
        {
            Quantidade = compras.Sum(x => x.Quantidade);
            TotalCompra = compras.Sum(x => x.Quantidade * Convert.ToDecimal(x.PrecoCompra));
            PrecoMedio = TotalCompra / Quantidade;
        }

        public decimal PrecoMedio { get; private set; }
        public decimal TotalCompra { get; private set; }
        public int Quantidade { get; private set; }
    }
}
