using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Entity
{
    [Table("Banco")]
    public class Banco
    {
        public int BancoID { get; set; }

        public string NomeBanco { get; set; }
    }
}
