using System.ComponentModel.DataAnnotations;

namespace Employees.Api.ViewModels
{
    public class PositionViewModel : BaseViewModel
    {
        [Required]
        public string Name { get; set; }
    }
}