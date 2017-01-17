using System.Collections.Generic;

namespace AlexWebApp.Models.CustomerViewModels
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public virtual Product Product { get; set; }
    }
}