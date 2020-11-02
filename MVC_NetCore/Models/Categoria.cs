using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MVC_NetCore.Models
{
    public class Categoria
    {
        public int Id { get; set; }

        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "O Campo Descrição é obrigatório!")]
        public string Descricao { get; set; }

        //[Required(ErrorMessage = "O Campo CategoriaId é obrigatório!")]
        //Quando criado a API, a lista abaixo não é necessario
        //public List<Produto> Produtos { get; set; }

    }
}
