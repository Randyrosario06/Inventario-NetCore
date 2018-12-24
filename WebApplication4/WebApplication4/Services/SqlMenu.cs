using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication4.Data;
using WebApplication4.Models;
using Microsoft.AspNetCore.Session;

namespace WebApplication4.Services
{
    public class SqlMenu : IMenuData
    {
        private OrderEatDBContext _context;

        public SqlMenu (OrderEatDBContext context)
        {
            _context = context;
        }

        public Comidas Add(Comidas comida)
        {
            _context.comidas.Add(comida);
            _context.SaveChanges();
            return comida;
        }

        public Comidas Get(int id)
        {
            return _context.comidas.FirstOrDefault(c => c.ComidaId == id);
        }

        public IEnumerable<Comidas> GetAll()
        {
            return _context.comidas.OrderBy(c => c.Nombre);
        }

        public void DeleteO(int id)
        {
            var comidaD = _context.comidas.FirstOrDefault(c => c.ComidaId == id);
            if (comidaD != null)
            {
                _context.comidas.Remove(comidaD);
                _context.SaveChanges();
            }

        }

        public IEnumerable<Comidas> GetArroz()
        {

            var a = _context.comidas.Where(arr => arr.Platos == TiposPlatos.Arroz)
                .OrderBy(arr => arr.Nombre);
            return a;
        }

        public IEnumerable<Comidas> GetLegumbre()
        {
            var a = _context.comidas.Where(arr => arr.Platos == TiposPlatos.Legumbre)
                .OrderBy(arr => arr.Nombre);
            return a;
        }

        public IEnumerable<Comidas> GetCarne()
        {
            var a = _context.comidas.Where(arr => arr.Platos == TiposPlatos.Carne)
              .OrderBy(arr => arr.Nombre);
            return a;
        }


        public IEnumerable<Comidas> GetEnsalada()
        {
            var a = _context.comidas.Where(arr => arr.Platos == TiposPlatos.Ensalada)
               .OrderBy(arr => arr.Nombre);
            return a;
        }



        public IEnumerable<Comidas> GetPostre()
        {
            var a = _context.comidas.Where(arr => arr.Platos == TiposPlatos.Postre)
               .OrderBy(arr => arr.Nombre);
            return a;
        }

        public IEnumerable<Comidas> GetFreida()
        {
            var a = _context.comidas.Where(arr => arr.Platos == TiposPlatos.Frita)
               .OrderBy(arr => arr.Nombre);
            return a;
        }

        public IEnumerable<Comidas> GetSopa()
        {
            var a = _context.comidas.Where(arr => arr.Platos == TiposPlatos.Sopa)
              .OrderBy(arr => arr.Nombre);
            return a;
        }

       

       

        public Personas AddP(Personas personas)
        {
            _context.personas.Add(personas);
            _context.SaveChanges();
            return personas;
        }

        public Personas GetU(Personas model)
        {

            var u = _context.personas.Where(p => p.Usuario.Equals(model.Usuario) && p.Pass.Equals(model.Pass)).FirstOrDefault();

            if (u == null)
            {
                return null;
            }

            else
            {

                return u;
            }
        }

        public Personas GetT(Personas personas)
        {
           // var a1 = _context.personas.Where(p => p.Tipo.Equals(TipoPersona.Cliente));
            var a2 = _context.personas.Where(p => p.Usuario.Equals(personas.Usuario))
                .FirstOrDefault();

            return a2;
            
        }

        public bool Logged()
        {
            return true;
        }

        public bool LogOut()
        {
            return false;
        }

        public Clientes AddC(Clientes clientes)
        {
            _context.clientes.Add(clientes);
            _context.SaveChanges();
            return clientes;
        }

        public IEnumerable<Clientes> GetC()
        {
            return _context.clientes.OrderBy(c => c.Nombre);
        }
    }
}
