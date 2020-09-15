using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Collections.Generic;
using System.Linq;

namespace Employees.Api.Helpers
{
    public class ErrorHelper
    {
        public ICollection<string> GetModelStateErrors(ModelStateDictionary modelState)
        {
            var errors = modelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage).ToList();
            return errors;
        }
    }
}