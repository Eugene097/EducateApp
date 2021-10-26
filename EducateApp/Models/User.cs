using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

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
    }
}
