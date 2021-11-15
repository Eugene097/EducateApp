using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EducateApp.ViewModels.Disciplines
{
    public class EditDisciplineViewModel
    {
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

        public string IdUser { get; set; }

    }
}
