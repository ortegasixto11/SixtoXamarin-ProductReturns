using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Devoluciones.Models
{
    public class Caja
    {
        public Guid Id { get; set; }
        public string Codigo { get; set; }
        public int Temporada { get; set; }
        public bool P { get; set; }
        public string FormattedP { get { return P ? "Si" : "No"; } }


        public static ObservableCollection<Caja> GetCajasFake()
        {
            return new ObservableCollection<Caja> {
                new Caja{ Id = Guid.Parse("7f06fead-bb1f-40b7-aa37-4451a53fa5c8"), Codigo = "40", P = true, Temporada = 5},
                new Caja{ Id = Guid.Parse("fcd2d7c7-fe18-4293-b93b-2074f7d81774"), Codigo = "50", P = false, Temporada = 6},
                new Caja{ Id = Guid.Parse("32127b8f-f7a9-489f-bc8e-bd66b60a910c"), Codigo = "60", P = true, Temporada = 7},
                new Caja{ Id = Guid.Parse("aaa2000b-072c-4383-99a1-0640cdff1ba9"), Codigo = "70", P = false, Temporada = 8},
                new Caja{ Id = Guid.Parse("2b1037cf-d816-472b-92e2-f11a4788b0ed"), Codigo = "80", P = true, Temporada = 9}
            };
        }

    }
}
