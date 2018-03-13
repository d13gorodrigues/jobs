using System;
using System.ComponentModel.DataAnnotations;

namespace RegVehic.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Campo Brand obrigatório")]
        [MaxLength(40, ErrorMessage ="É permitido no máximo 40 caracteres")]
        public string Brand { get; set; }

        [Required(ErrorMessage = "Campo Model obrigatório")]
        [MaxLength(50, ErrorMessage ="É permitido no máximo 50 caracteres")]
        public string Model { get; set; }

        [Required(ErrorMessage = "Campo Color obrigatório")]
        [MaxLength(30, ErrorMessage = "É permitido no máximo 30 caracteres")]
        public string Color { get; set; }
        
        [Required(ErrorMessage = "Campo Year obrigatório")]
        public int Year { get; set; }

        [Required(ErrorMessage = "Campo Price obrigatório")]
        public double Price { get; set; }  
        
        [Required(ErrorMessage = "Campo Description obrigatório")]
        public string Description { get; set; }

        public bool IsNew { get; set; }
        public DateTime DateReg { get; set; }
        public DateTime? DateUpdate { get; set; }


    }
}
