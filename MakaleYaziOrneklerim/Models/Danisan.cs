using System;
using System.Collections.Generic;

#nullable disable

namespace MakaleYaziOrneklerim.Models
{
    public partial class Danisan
    {
        public Danisan()
        {
            DanisanTahlilDosyas = new HashSet<DanisanTahlilDosya>();
            Gorusmelers = new HashSet<Gorusmeler>();
        }

        public int DanisanId { get; set; }
        public string AdiSoyadi { get; set; }
        public string Email { get; set; }
        public string TlfNo { get; set; }
        public string Cinsiyet { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string Image { get; set; }
        public DateTime DiyetBaslamatarihi { get; set; }
        public bool Status { get; set; }
        public string EgitimDurumu { get; set; }
        public float Boy { get; set; }
        public float Kilo { get; set; }
        public int Yas { get; set; }

        public virtual ICollection<DanisanTahlilDosya> DanisanTahlilDosyas { get; set; }
        public virtual ICollection<Gorusmeler> Gorusmelers { get; set; }
    }
}
