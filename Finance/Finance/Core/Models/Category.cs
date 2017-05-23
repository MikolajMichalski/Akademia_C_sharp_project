using System;

namespace Finance.Models
{
    public class Category
    {
        public Guid CategoryId { get; protected set; }
        public string CategoryName { get; protected set; }
        public float MaximumExpense { get; protected set; }

        public Category(Guid categoryId, string categoryName)
        {
            CategoryId = Guid.NewGuid();
            CategoryName = categoryName;       
        }
    }
}