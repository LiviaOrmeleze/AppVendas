﻿using System.ComponentModel.DataAnnotations;

namespace AppVendas.Models
{
    public class Produto
    {
        public Guid ProdutoId { get; set; }

        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "O campo não pode ser vazio!")]
        [MaxLength(100, ErrorMessage = "A Descrição deve ter, no máximo, 100 caracteres!")]
        [MinLength(3, ErrorMessage = "O campo deve ter, no mínimo, 3 caracteres!")]
        public string ProdutoNome { get; set; }

        [Required(ErrorMessage = "O campo não pode ser vazio!")]
        [Range(0, double.MaxValue, ErrorMessage = "A qualidade em estoque deve ser positivo!")]
        public double Valor { get; set; }

        [Required(ErrorMessage = "O campo não pode ser vazio!")]
        [Range(0, double.MaxValue, ErrorMessage = "A quantidade em estoque deve ser positivo!")]
        [Display(Name = "Estoque atual")]
        public double QtadeEstoque { get; set; }

        [Display(Name = "Ativo?")]
        public bool? CadastroAtivo { get; set; } = true;

        [Display(Name = "Categoria")]
        /*chave estrangeira8*/
        [Required(ErrorMessage = "Por favor, selecione uma categoria")]
        public Guid CategoriaId { get; set; }

        public Categoria? Categoria { get; set; }

    }
}
