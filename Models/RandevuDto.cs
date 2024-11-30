using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastanYonetim_RandevuSistem.Models
{
    internal class RandevuDto
    {
        public  int RandevuId { get; set; }  
        public  string RandevuTarih {  get; set; }   
        public string RandevuSaat {  get; set; }    
        public  string BransAdı {  get; set; }   
        public string DoktorAdı {  get; set; }  
        public string Durum {  get; set; }   
        public string HastaAdı{  get; set; }   
        public string HastaSikayet {  get; set; }
    }
}
