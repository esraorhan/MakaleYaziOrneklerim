using System;
using System.Collections.Generic;

#nullable disable

namespace MakaleYaziOrneklerim.Models
{
    public partial class Besinler
    {
        public Besinler()
        {
            Ogunlers = new HashSet<Ogunler>();
        }

        public int BesinId { get; set; }
        public string Yemek { get; set; }
        public string Miktar { get; set; }
        public string OlcuBirimi { get; set; }
        public string Kalori { get; set; }
        public string Protein { get; set; }
        public string Karbonhidrat { get; set; }
        public string Yağ { get; set; }
        public int CategoriesId { get; set; }

        public virtual Category Categories { get; set; }
        public virtual ICollection<Ogunler> Ogunlers { get; set; }
    }
}
