using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication4.Models;

namespace WebApplication4.Services
{
    public interface IMenuData
    {
        IEnumerable<Comidas> GetAll();
        Comidas Get(int id);
        Comidas Add(Comidas comidas);
        void DeleteO(int id);
        IEnumerable<Comidas> GetArroz();
        IEnumerable<Comidas> GetLegumbre();
        IEnumerable<Comidas> GetEnsalada();
        IEnumerable<Comidas> GetCarne();
        IEnumerable<Comidas> GetPostre();
        IEnumerable<Comidas> GetFreida();
        IEnumerable<Comidas> GetSopa();

        Personas GetU(Personas model);
        Personas AddP(Personas personas);
        
        bool Logged();
        bool LogOut();
        
        Personas GetT(Personas personas);

        Clientes AddC(Clientes clientes);
        IEnumerable<Clientes> GetC();

    }
}
