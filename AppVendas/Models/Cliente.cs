using System.ComponentModel.DataAnnotations;

namespace AppVendas.Models
{
    public class Cliente
    {
        public Guid ClienteId { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "O Campo é Obrigatório!")]
        [MaxLength(100, ErrorMessage = "O Campo deve ter, no máximo, 100 caractéres!")]
        [MinLength(3, ErrorMessage = "O Campo deve ter, no mínimo, 3 caractéres!")]
        public string ClienteNome { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "O Campo é Obrigatório!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O Campo é Obrigatório!")]
        [MaxLength(11, ErrorMessage = "O Limite do campo é de 11 Dígitos Numéricos!")]
        [MinLength(11, ErrorMessage = "O Campo Celular deve ter 11 Dígitos Numéricos")]
        public string Celular { get; set; }

        [Display(Name = "Ativo?")]
        public bool? CadastroAtivo { get; set; }

        [Display(Name = "Data de Cadastro")]
        [Required(ErrorMessage = "O Campo é Obrigatório!")]
        public DateTime DataCadastro { get; set; }

    }
}
