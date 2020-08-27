using System;

namespace Shindows.Models
{
    public class CategoryModel
    {
        public CategoryModel(int id, string value)
        {
            Id = id;
            Value = value;
        }
        public Int32 Id { get; set; }
        public String Value { get; set; }
    }
}