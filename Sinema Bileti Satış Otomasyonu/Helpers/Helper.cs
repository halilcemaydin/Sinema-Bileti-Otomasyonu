using Sinema_Bileti.Enums;
using Sinema_Bileti.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinema_Bileti.Helpers
{
    public class Helper
    {
        public static List<Movie> CreateMovies()
        {
            string basePath = "D://Dersler//Console//Windows Form App//Sinemaa//Sinema Bileti//Pictures//";
            return new List<Movie>()
            {
               new Movie()
               {
                    movieName = "Yıldızlar arası",
                    category = Category.bilim_kurgu,
                    minute = "2 saat 49 dakika",
                    price = 50,
                    picturePath = basePath + "yıldızlar_arasında.jpg"
               },
               new Movie()
               {
                     movieName = "Canavar",
                     category = Category.gerilim,
                     minute = "1 saat 33 dakika",
                     price = 50,
                     picturePath = basePath + "beast.jpg"
               },
               new Movie()
               {
                    movieName = "üç_aptal",
                    category = Category.komedi,
                    minute = "2 saat 51 dakika",
                    price = 60,
                    picturePath = basePath + "üçaptal.jpg"
               },
               new Movie()
               {
                    movieName = "Black Man",
                    category = Category.macera,
                    minute = "2 saat 5 dakika",
                    price = 50,
                    picturePath = basePath + "Black Man.jpg"
               },
               new Movie()
               {
                    movieName = "Jumanji",
                    category = Category.macera,
                    minute = "1 saat 44 dakika",
                    price = 50,
                    picturePath = basePath + "jumanji.jpg"
               },
               new Movie()
               {
                   movieName = "Warcraft",
                   category = Category.fantastik,
                   minute = "2 saat 3 dakika",
                   price = 40,
                   picturePath = basePath + "warcraft.jpg"
               }
            };
        }
    }
}
