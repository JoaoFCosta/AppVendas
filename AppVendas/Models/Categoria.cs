using System.ComponentModel.DataAnnotations;

namespace AppVendas.Models
{
    public class Categoria
    {
        public Guid CategoriaId { get; set; }

        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "O Campo é obrigatório!")]
        [MaxLength(100, ErrorMessage = "A Descrição deve ter, no máximo, 100 caractéres!")]
        public string CategoriaNome { get; set; }

    }
}
