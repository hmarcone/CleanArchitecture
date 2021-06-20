﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CleanArch.Application.ViewModels
{
    public class ProductViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo nome é obrigatório!")]
        [MinLength(3)]
        [MaxLength(100)]
        [DisplayName("Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "O campo descrição é obrigatório!")]
        [MinLength(5)]
        [MaxLength(200)]
        [DisplayName("Description")]
        public string Description { get; set; }

        [Required(ErrorMessage = "O campo preço é obrigatório!")]
        [Range(1, 99999.99)]
        [DisplayName("Price")]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        public decimal Price { get; set; }


    }
}
