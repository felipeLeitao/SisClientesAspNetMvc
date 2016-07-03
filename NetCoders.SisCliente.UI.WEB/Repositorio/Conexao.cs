using NetCoders.SisCliente.UI.WEB.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NetCoders.SisCliente.UI.WEB.Repositorio
{
    public class Conexao : DbContext
    {
        public Conexao() : base(@"Data Source = (localdb)\v11.0; Initial Catalog = SisClientes; Integrated Security = true")
        {

        }

        public DbSet<ClienteMOD> Cliente { get; set; }
    }
}