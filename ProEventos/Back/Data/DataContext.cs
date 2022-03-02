﻿using Microsoft.EntityFrameworkCore;
using ProEventos.Models;

namespace ProEventos
{
    public class DataContext :DbContext
    {
        //
        public DataContext( DbContextOptions<DataContext> options):base(options)
        {

        }
        public DbSet<Evento> Eventos { get; set; }

    }
}
