using System;
using System.ComponentModel.DataAnnotations;

namespace Employees.Api.ViewModels
{
    public class InsertEmployeeViewModel : BaseViewModel
    {
        [Required(ErrorMessage = "Поле Имя является обязательным для заполнения!")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Поле Фамилия является обязательным для заполнения!")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Поле Оклад является обязательным для заполнения!")]
        public double Cash { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime StartedWork { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime EndedWork { get; set; }

        [Required]
        public int PositionId { get; set; }
    }
}