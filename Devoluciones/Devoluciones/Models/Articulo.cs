using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Devoluciones.Models
{
    public class Articulo
    {
        public Guid Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string ImageURL { get; set; }

        public static ObservableCollection<Articulo> GetArticulosFake()
        {
            return new ObservableCollection<Articulo>
            {
                new Articulo{ Id = Guid.Parse("59c18939-d05a-467e-92fb-aad0eb63753f"), Codigo = "01", Nombre = "Camisa", ImageURL = "https://upload.wikimedia.org/wikipedia/commons/2/24/Blue_Tshirt.jpg"},
                new Articulo{ Id = Guid.Parse("7787a76f-119a-4109-999c-d20eb58ed6f9"), Codigo = "02", Nombre = "Pantalon", ImageURL = "https://media.wuerth.com/stmedia/modyf/shop/290px/1370911.jpg"},
                new Articulo{ Id = Guid.Parse("fd6bd6be-c242-4b71-b8c4-6e222ce3032d"), Codigo = "03", Nombre = "Chaqueta", ImageURL = "https://www.outlete.es/tienda/28973-large_default/chaqueta-moto-cuero-bstar-classic-jacket.jpg"}
            };
        }

    }
}
