using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace HastanYonetim_RandevuSistem.Models
{
    internal static class HastaDto
    {
        public static int HastaId {  get; set; }    
        public static string HastaAd { get; set; }
        public static string HastaSoyad {  get; set; }  
        public static string HastaTcKimlik { get; set; }
        public static string HastaTelefon { get; set; }
        public static string HastaGendre { get; set; }

    }
}
