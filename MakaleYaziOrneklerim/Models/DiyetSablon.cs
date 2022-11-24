using System;
using System.Collections.Generic;

#nullable disable

namespace MakaleYaziOrneklerim.Models
{
    public partial class DiyetSablon
    {
        public DiyetSablon()
        {
            OgunIcerikleris = new HashSet<OgunIcerikleri>();
            Ogunlers = new HashSet<Ogunler>();
        }

        public int DiyetSablonId { get; set; }
        public string Baslik { get; set; }
        public string Aciklama { get; set; }
        public DateTime OlusturmaTarihi { get; set; }
        public decimal ToplamKalori { get; set; }

        public virtual ICollection<OgunIcerikleri> OgunIcerikleris { get; set; }
        public virtual ICollection<Ogunler> Ogunlers { get; set; }
    }
}
