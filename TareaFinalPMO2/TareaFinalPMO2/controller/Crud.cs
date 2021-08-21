﻿using TareaFinalPMO2.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace TareaFinalPMO2.controller
{
    public class Crud
    {
        Coneccion conn = new Coneccion();
        public Task<List<Personas>> getReadPersonas()
        {
            return conn.GetConnectionAsync().Table<Personas>().ToListAsync();
        }

        public Task<Personas> getPersonasId(int id)
        {
            return conn
                .GetConnectionAsync()
                .Table<Personas>()
                .Where(item => item.id == id)
                .FirstOrDefaultAsync();
        }

        public Task<int> getPersonasUpdateId(Personas personas)
        {
            return conn
                .GetConnectionAsync()
                .UpdateAsync(personas);

        }

        public Task<int> Delete(Personas personas)
        {
            return conn
                .GetConnectionAsync()
                .DeleteAsync(personas);
        }

    }
}

