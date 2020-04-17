using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Supermarket.API.Extensions
{
    public static class ModelStateExtensions
    {
        // "this" keyword tells c# to treat this as an extension method
        // Extensions must be static
        public static List<string> GetErrorMessages(this ModelStateDictionary dictionary)
        {
            // This functionality is made available via linq queries
            return dictionary.SelectMany(m => m.Value.Errors)
                             .Select(m => m.ErrorMessage)
                             .ToList();
        }
    }
}