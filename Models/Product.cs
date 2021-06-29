using System.ComponentModel.DataAnnotations;

namespace Shop.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Esta campo é obrigatório")]
        [MaxLength(60, ErrorMessage = "ValorEste campo deve conter entre 3 e 60 caracteres")]
        [MinLength(3, ErrorMessage = "ValorEste campo deve conter entre 3 e 60 caracteres")]
        public string Title { get; set; }

        [MaxLength(1024, ErrorMessage = "Este campo deve conter no máximo 1024 caracteres")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Range(1, 999999, ErrorMessage = "o preço deve ser maior que zero")]
        public decimal Price { get; set; }
        
        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Range(1, int.MaxValue, ErrorMessage = "categoria inválida")]
        public int CategoryId { get; set; }
        
        //propriedade de referencia
        public Category Category { get; set; }

    }
}
