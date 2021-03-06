﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebgentleBookStore.Models
{
    public class BookModel
    {

        public int Id { get; set; }
        [StringLength (100,MinimumLength =5)]
        [Required (ErrorMessage = "Please enter the title of your book")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Please enter the author of your book")]
        public string Author { get; set; }
         [StringLength(100, MinimumLength = 5)]
        [Required(ErrorMessage = "Please enter the error ")] 
        public string Description { get; set; }

        public string Category { get; set; }
        [Required(ErrorMessage = "Please choose the language of your book")]
        public int LanguageId { get; set; }
        [Required(ErrorMessage = "Please enter the total pages")]
        [Display(Name ="Total Number of Pages")]
        public int? TotalPages { get; set; }
       
    }
}
