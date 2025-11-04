// Giovanne CB 3026591 / Ricardo CB3025543
// Projeto: Gerenciador de produtos
// CBTSWE2 - Trabalho Prático 03

using System.ComponentModel.DataAnnotations;

namespace GerProTP3.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome do produto é obrigatório")]
        [StringLength(100, ErrorMessage = "O nome não pode ter mais de 100 caracteres")]
        [Display(Name = "Nome do Produto")]
        public string Name { get; set; }

        [Required(ErrorMessage = "A descrição é obrigatória")]
        [StringLength(500, ErrorMessage = "A descrição não pode ter mais de 500 caracteres")]
        [Display(Name = "Descrição")]
        public string Description { get; set; }

        [Required(ErrorMessage = "O preço é obrigatório")]
        [Range(0.01, 10000, ErrorMessage = "O preço deve estar entre 0,01 e 10.000")]
        [Display(Name = "Preço")]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "A quantidade em estoque é obrigatória")]
        [Range(0, 10000, ErrorMessage = "A quantidade deve estar entre 0 e 10.000")]
        [Display(Name = "Quantidade em Estoque")]
        public int StockQuantity { get; set; }

        [Display(Name = "Data de Cadastro")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}