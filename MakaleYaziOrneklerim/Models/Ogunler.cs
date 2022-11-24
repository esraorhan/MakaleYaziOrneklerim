using System;
using System.Collections.Generic;

#nullable disable

namespace MakaleYaziOrneklerim.Models
{
    public partial class Ogunler
    {
        public Ogunler()
        {
            OgunIcerikleris = new HashSet<OgunIcerikleri>();
        }

        public int OgunId { get; set; }
        public string OgunAdi { get; set; }
        public int? DiyetSablonId { get; set; }
        public int? BesinlerBesinId { get; set; }

        public virtual Besinler BesinlerBesin { get; set; }
        public virtual DiyetSablon DiyetSablon { get; set; }
        public virtual ICollection<OgunIcerikleri> OgunIcerikleris { get; set; }
    }
}
