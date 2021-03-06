using EducateApp.Models.Data;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EducateApp.Models
{
    public class User : IdentityUser
    {
        //дополнительные поля для каждого пользователя
        //для преподавателя погут понадобится данные о ФИО

        //сообщение об ошибке при валидации на стороне клиента
        [Required(ErrorMessage = "Введите фамилию")]

        //отображение Фамилии вместо LastName
        [Display(Name="Фамилия")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Введите имя")]
        [Display(Name = "Имя")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Введите отчество")]
        [Display(Name = "Отчество")]
        public string Patronymic { get; set; }

        //навигационные свойства
        [Required]
        public ICollection<FormOfStudy> FormsOfStudy { get; set; }

        [Required]
        public ICollection<Discipline> Disciplines { get; set; }
    }
}
