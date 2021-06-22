using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ArimInvest.UI.Models
{
    public class Compra
    {
        public Compra()
        {
            DataCompra = DateTime.Now;
            Quantidade = 1;
        }
        public Compra(DateTime dataCompra, int quantidade, string precoCompra, string nomeAcao)
        {
            DataCompra = dataCompra;
            Quantidade = quantidade;
            PrecoCompra = precoCompra;
            NomeAcao = nomeAcao;
        }

        [Required]
        public DateTime DataCompra { get; set; }

        [Required(ErrorMessage ="Informe a Quantidade")]
        [Range(0, 300, ErrorMessage = "O valor minimo é {0} e o máximo é {1}")]
        public int Quantidade { get; set; }

        [Required(ErrorMessage = "Informe o Preço de Compra")]
        [RegularExpression("^[-,0-9]+$", ErrorMessage = "Somente números")]
        public string PrecoCompra { get; set; }
        public string NomeAcao { get; set; }
        public string TotalCompra()
        {
            return (Quantidade * Convert.ToDecimal(PrecoCompra)).ToString("C2");
        }
    }
}
