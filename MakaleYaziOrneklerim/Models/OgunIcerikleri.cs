using System;
using System.Collections.Generic;

#nullable disable

namespace MakaleYaziOrneklerim.Models
{
    public partial class OgunIcerikleri
    {
        public int OgunIcerikId { get; set; }
        public string Yemek { get; set; }
        public string Miktar { get; set; }
        public string Olcubirimi { get; set; }
        public string Kalori { get; set; }
        public string Protein { get; set; }
        public string Karbonhidrat { get; set; }
        public string Yağ { get; set; }
        public int OgunId { get; set; }
        public int DiyetSablonId { get; set; }

        public virtual DiyetSablon DiyetSablon { get; set; }
        public virtual Ogunler Ogun { get; set; }
    }
}
