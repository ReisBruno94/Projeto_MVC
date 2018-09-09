using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Entity
{
    [Table("Contas")]
    public class Conta
    {
        [Display(Name = "Código Conta")]
        public int ContaID { get; set; }

        public int BancoID { get; set; }

        public int ClienteID { get; set; }

        public decimal Saldo { get; set; }

        public virtual Cliente Cliente {get;set;}

        public virtual Banco Banco { get; set; }

    }
}
