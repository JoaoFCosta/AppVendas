using System.ComponentModel.DataAnnotations;

namespace AppVendas.Models
{
    public class Produto
    {
        public Guid ProdutoId { get; set; }

        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "O Campo é Obrigatório!")]
        [MaxLength(100, ErrorMessage = "O Campo deve ter, no máximo, 100 caractéres!")]
        [MinLength(3, ErrorMessage = "O Campo deve ter, no mínimo, 3 caractéres!")]
        public string ProdutoNome { get; set; }

        [Required(ErrorMessage = "O Campo é Obrigatório!")]
        [Range(0, double.MaxValue, ErrorMessage = "O Valor do Produto deve ser um número positivo!")]
        public double Valor { get; set; }

        [Display(Name = "Quantidade")]
        [Required(ErrorMessage = "O Campo é Obrigatório!")]
        [Range(0, double.MaxValue, ErrorMessage = "A Quantidade em Estoque deve ser positivo!")]
        public double QtadeEstoque { get; set; }

        [Display(Name = "Ativo?")]
        public bool? CadastroAtivo { get; set; } = true;

        //Chave Estrangeira
        [Required(ErrorMessage = "Por favor, selecione uma Categoria!")]
        [Display(Name = "Categoria")]
        public Guid CategoriaId { get; set; }
        public Categoria? Categoria { get; set; }
    }
}
