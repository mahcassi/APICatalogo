﻿using APICatalogo.Models;
using System.Runtime.InteropServices;

namespace APICatalogo.Repositories.Interfaces
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> GetCategorias();
        Categoria GetCategoria(int id);
        Categoria Create(Categoria categoria);
        Categoria Update(Categoria categoria);
        Categoria Delete(int id);
    }
}
