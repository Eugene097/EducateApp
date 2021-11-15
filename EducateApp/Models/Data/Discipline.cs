using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EducateApp.Models.Data
{
    public class Discipline
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ИД")]
        public short Id { get; set; }

        [Required(ErrorMessage = "Введите индекс профиссионального модуля")]
        [Display(Name = "Индекс профиссионального модуля")]
        public string IndexProfModule { get; set; }

        [Required(ErrorMessage = "Введите название профиссионального модуля")]
        [Display(Name = "Название профиссионального модуля")]
        public string ProfModule { get; set; }

        [Required(ErrorMessage = "Введите индекс")]
        [Display(Name = "Индекс")]
        public string Index { get; set; }

        [Required(ErrorMessage = "Введите название")]
        [Display(Name = "Название")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Введите короткое название")]
        [Display(Name = "Короткое название")]
        public string ShortName { get; set; }

        [Required]
        [Display(Name = "Идентификатор пользвоателя")]
        public string IdUser { get; set; }

        [Display(Name = "Идентификатор пользвоателя")]
        [ForeignKey("IdUser")]
        public User User { get; set; }
    }
}
