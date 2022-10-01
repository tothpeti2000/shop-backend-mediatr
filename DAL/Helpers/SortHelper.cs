using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Dynamic.Core;

namespace DAL.Helpers
{
    public class SortHelper<T>
    {
        public IQueryable<T> ApplySort(IQueryable<T> entities, string? orderByString)
        {
            if (!entities.Any() || string.IsNullOrWhiteSpace(orderByString))
            {
                return entities;
            }

            var orderParams = orderByString.Trim().Split(" ");
            var orderPropertyName = orderParams[0];

            var propertyInfos = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            var objectProperty = propertyInfos.FirstOrDefault(pi => pi.Name.Equals(orderPropertyName, StringComparison.InvariantCultureIgnoreCase));

            if (objectProperty == null)
            {
                return entities;
            }

            if (orderParams.Length == 2 && orderParams[1] == "desc")
            {
                return entities.OrderBy($"{objectProperty.Name} descending");
            }

            return entities.OrderBy(objectProperty.Name);
        }
    }
}
