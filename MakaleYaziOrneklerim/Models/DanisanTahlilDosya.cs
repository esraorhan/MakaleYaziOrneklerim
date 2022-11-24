using System;
using System.Collections.Generic;

#nullable disable

namespace MakaleYaziOrneklerim.Models
{
    public partial class DanisanTahlilDosya
    {
        public int DanisanTahlilDosyaId { get; set; }
        public string DanisanDosyaTuru { get; set; }
        public DateTime YuklenmeTarihi { get; set; }
        public string DosyaAdi { get; set; }
        public int DanisanId { get; set; }

        public virtual Danisan Danisan { get; set; }
    }
}
