using System;
using System.Collections.Generic;

#nullable disable

namespace MakaleYaziOrneklerim.Models
{
    public partial class Gorusmeler
    {
        public int GorusmeId { get; set; }
        public string Alerji { get; set; }
        public string GenetikHastalik { get; set; }
        public string AiledeHastalik { get; set; }
        public string Aktivite { get; set; }
        public string Aciklama { get; set; }
        public string Kullanilanilac { get; set; }
        public DateTime GorusmeTarihi { get; set; }
        public int DanisanId { get; set; }
        public float GuncelKilo { get; set; }
        public int BacakCm { get; set; }
        public int BasenCm { get; set; }
        public int BelCm { get; set; }
        public int GogusCm { get; set; }
        public int KalcaCm { get; set; }
        public int KolCm { get; set; }
        public int YagOranı { get; set; }

        public virtual Danisan Danisan { get; set; }
    }
}
