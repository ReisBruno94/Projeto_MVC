using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto.Entity
{
    [Table("Cliente")]
    public class Cliente
    {
        [Display(Name = "Código")]
        public int ClienteID { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Esse campo é Obrigatório")]
        public string Nome { get; set; }

        [Display(Name = "CPF")]
        [Required(ErrorMessage = "Esse campo é Obrigatório")]
        public string CPF { get; set; }

        public string Telefone { get; set; }
        public string Email { get; set; }
        public int Estado { get; set; }

        
    }

}
