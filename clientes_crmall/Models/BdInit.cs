using clientes_crmall.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace clientes_crmall.Models
{
    public class BdInit
    {
        public static void Initialize(ClienteContext context)
        {
            context.Database.EnsureCreated();
            //if (context.Clientes.Any())
            //{
            //    return;
            //}
        }
        }
}
