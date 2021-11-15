using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EducateApp.Models.Data
{
    public class TypeOfTotals
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ИД")]
        public short Id { get; set; }

        [Required(ErrorMessage = "Введите название аттестации")]
        [Display(Name = "Название аттестации")]
        public string CertificateName { get; set; }

        [Required(ErrorMessage = "Введите идентификатор пользвоателя")]
        [Display(Name = "Идентификатор пользвоателя")]
        public User User { get; set; }
    }
}
