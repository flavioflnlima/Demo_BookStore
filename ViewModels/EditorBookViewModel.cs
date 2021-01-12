using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace BookStore.ViewModels
{
    public class EditorBookViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Nome invalido")]
        [Display(Name = "Nome do Livro")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "ISBN invalido")]
        public string ISBN { get; set; }

        [Required(ErrorMessage = "Data de lançamento invalido")]
        [Display(Name = "Data de Lançamento")]
        [DataType(DataType.Date)]
        public DateTime DataLancamento { get; set; }

        [Required(ErrorMessage = "Categoria invalido")]
        [Display(Name = "Categoria")]
        public int CategoriaId { get; set; }
        public SelectList CategoriaOptions { get; set; }
    }
}