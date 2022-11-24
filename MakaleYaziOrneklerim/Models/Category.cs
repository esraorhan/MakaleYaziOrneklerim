using System;
using System.Collections.Generic;

#nullable disable

namespace MakaleYaziOrneklerim.Models
{
    public partial class Category
    {
        public Category()
        {
            Besinlers = new HashSet<Besinler>();
        }

        public int CategoriesId { get; set; }
        public string CategoriesName { get; set; }

        public virtual ICollection<Besinler> Besinlers { get; set; }
    }
}
