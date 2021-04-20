using System;
using System.ComponentModel.DataAnnotations;

namespace CursoAPI.Models
{
    public class Produto
    {
        public int Id { get; set; }

        [Display(Name ="Descrição")]
        public string Descricao { get; set; }
        [Range(1,10,ErrorMessage ="O valor está fora da faixa permitida")]
        public int Quantidade { get; set; }

        public int CategoriaId { get; set; }

        public Categoria Categoria { get; set; }
    }
}
