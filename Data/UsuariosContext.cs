using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using UsuariosBackEnd02.Models;

namespace UsuariosBackEnd02.Data
{
    public class UsuariosContext: DbContext
    {
        public DbSet<Usuario> Usuarios {  get; set; }

        public UsuariosContext(DbContextOptions<UsuariosContext> options)
            : base (options)
        {

        }

    } // class

    // ...

} //namespace
