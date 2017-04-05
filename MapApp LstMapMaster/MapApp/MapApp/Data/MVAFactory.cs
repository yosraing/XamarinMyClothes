using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MapApp.Utilitaire;

namespace MapApp.Data
{
    public class MVAFactory
    {
        public class MVA
        {
            public string Title { get; set; }
            public string ImageUrl { get; set; }
            public string Prix { get; set; }
            public string Mail { get; set; }
            public string Phone { get; set; }
        }

        public static IList<MVA> MVAData { get; set; }
        // public  static IList<MVA> MVADataWithGrouping { get; set; }

        public static int RefreshCount { get; set; } = 0;


        static MVAFactory()
        {

            MVAData = new ObservableCollection<MVA>
            {
                new MVA
                {
                    Title = "Chemis Femme1",
                    Prix = "58,900 dt",
                    Mail = "chemisfemme@gmail.com",
                    ImageUrl = "cf1.jpg",
                    Phone = "12345678"

                },
                new MVA
                {
                    Title = "Chemis Femme2",
                    Prix = "64,900 dt",
                    Mail = "chemisfemme@gmail.com",
                    ImageUrl = "cf2.jpg",
                    Phone = "12345678"

                },
                new MVA
                {
                    Title = "Chemis Femme3",
                    Prix = "45,900 dt",
                    Mail = "chemisfemme@gmail.com",
                    ImageUrl = "cf3.jpg",
                    Phone = "12345678"

                },
                 new MVA
                {
                    Title = "Les Chaussure Femme1",
                    Prix = "70 dt",
                    Mail = "chemisfemme@gmail.com",
                    ImageUrl = "chf1.jpg",
                    Phone = "12345678"

                },
                new MVA
                {
                    Title = "Les Chaussure Femme2",
                    Prix = "40 dt",
                    Mail = "chemisfemme@gmail.com",
                    ImageUrl = "chf2.jpg",
                    Phone = "12345678"

                },
                new MVA
                {
                    Title = "Les Chaussure Femme3",
                    Prix = "38,900 dt",
                    Mail = "chemisfemme@gmail.com",
                    ImageUrl = "chf3.jpg",
                    Phone = "12345678"

                },
                 new MVA
                {
                    Title = "Jupe Femme1",
                    Prix = "70 dt",
                    Mail = "chemisfemme@gmail.com",
                    ImageUrl = "j1.jpg",
                    Phone = "12345678"

                },
                new MVA
                {
                    Title = "Jupe Femme2",
                    Prix = "60 dt",
                    Mail = "chemisfemme@gmail.com",
                    ImageUrl = "j2.jpg",
                    Phone = "12345678"

                },
                new MVA
                {
                    Title = "Jupe Femme3",
                    Prix = "50,900 dt",
                    Mail = "chemisfemme@gmail.com",
                    ImageUrl = "j3.jpg",
                    Phone = "12345678"

                },
                 new MVA
                {
                    Title = "Pantalon Femme1",
                    Prix = "34,900 dt",
                    Mail = "chemisfemme@gmail.com",
                    ImageUrl = "pf1.jpg",
                    Phone = "12345678"

                },
                new MVA
                {
                    Title = "Pantalon Femme2",
                    Prix = "48 dt",
                    Mail = "chemisfemme@gmail.com",
                    ImageUrl = "pf2.jpg"

                },
                new MVA
                {
                    Title = "Pantalon Femme3",
                    Prix = "60 dt",
                    Mail = "chemisfemme@gmail.com",
                    ImageUrl = "pf3.jpg",
                    Phone = "12345678"

                },
                new MVA
                {
                    Title = "Robe Femme1",
                    Prix = "170 dt",
                    Mail = "chemisfemme@gmail.com",
                    ImageUrl = "r1.jpg",
                    Phone = "12345678"

                },
                new MVA
                {
                    Title = "Robe Femme2",
                    Prix = "250 dt",
                    Mail = "chemisfemme@gmail.com",
                    ImageUrl = "r2.jpg",
                    Phone = "12345678"

                },
                new MVA
                {
                    Title = "Robe Femme3",
                    Prix = "120 dt",
                    Mail = "chemisfemme@gmail.com",
                    ImageUrl = "r3.jpg",
                    Phone = "12345678"

                }



            };

        }

        public static ObservableCollection<Grouping<string, MVA>>
            BindingWithGrouping(string searchText = "")
        {
            var result = MVAData;

            if (!string.IsNullOrEmpty(searchText) && searchText.Length > 3)
            {
                result = result.Where(x => x.Title.ToLower().StartsWith(
                    searchText.ToLower())).ToList();
            }

            var list = new ObservableCollection<Grouping<string, MVA>>
                (result.
                OrderBy(c => RefreshCount % 2 == 0 ? c.Prix : c.Title).
                GroupBy(c => c.Title[0].ToString()
                ).Select(K => new Grouping<string, MVA>(K.Key, K)));
            return list;
        }
    }
}
