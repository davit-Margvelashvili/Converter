using Converter.Core.Exceptions;

namespace Converter.Core.Models
{
    public class Unit
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public decimal Value { get; set; }

        public Category Category { get; set; }
    }

    public static class Converter
    {
        public static decimal Convert(decimal amount, Unit from, Unit to)
        {
            if (from.CategoryId != to.CategoryId)
                throw new InconsistentCategoryException(from.Category, to.Category);

            var unitValue = from.Value / to.Value;
            return unitValue * amount;
        }
    }
}