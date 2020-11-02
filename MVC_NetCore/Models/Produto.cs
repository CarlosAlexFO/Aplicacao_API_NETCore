using System;
using System.ComponentModel.DataAnnotations;

namespace MVC_NetCore.Models
{
    public class Produto
    {

        public int Id { get; set; }

        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "O Campo Descrição é obrigatório!")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "O Campo Quantidade é obrigatório!")]
        [Range(1, 10, ErrorMessage = "Valor fora da faixa!")]
        public int Quantidade { get; set; }

        [Required(ErrorMessage = "O Campo CategoriaId é obrigatório!")]
        public int CategoriaId { get; set; }

        public Categoria Categoria { get; set; }
    }
}
