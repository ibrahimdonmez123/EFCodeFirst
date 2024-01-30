using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirst.Entity
{

    [Table("Ogrenciler")] 
    public  class Ogrenci
    {
        [Key] 
        public int Id { get; set; }
        [Required] 
        [StringLength(50)]  
        public string Isim { get; set; }
        

        public int Yas { get; set; }


        public string Cinsiyet { get; set; }

    }
}
