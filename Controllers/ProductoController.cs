using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Http;
using APIRest.Models;

namespace APIRest.Controllers
{
    public class ProductoController : ApiController
    {
        //Diccionario: para tener un par de valores
        //static:´para que los productos no se pierdan y se guarden en memoria
        static Dictionary<int, Producto> productos = new Dictionary<int, Producto>();

        //GET api/Producto
        public IEnumerable<Producto> Get()
        {
            return new List<Producto>(productos.Values);
        }

        //GET api/Producto/5
        public Producto Get(int id)
        {
            Producto encontrado;
            productos.TryGetValue(id, out encontrado);
            return encontrado;
        }

    }
}
