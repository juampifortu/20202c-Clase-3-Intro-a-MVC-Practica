using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class AlimentoServicio
    {
        public static List<Alimento> alimentos = new List<Alimento>();

        public void Alta(Alimento alimento)
        {
            int maxId = 0;
            if (alimentos.Count > 0)
            {
                maxId = alimentos.Max(o => o.id);
            }
            alimento.id = maxId + 1;
            alimentos.Add(alimento);
        }
        public List<Alimento> Todos()
        {
            return alimentos;
        }
        public void Editar(Alimento alimento)
        {
            Alimento ali = buscarPorId(alimento.id);
            ali.nombre = alimento.nombre;
            ali.peso = alimento.peso;
        }
        public Alimento buscarPorId(int id)
        {
            return alimentos.Find(o => o.id == id);
        }
        public void Borrar(int id)
        {
            alimentos.RemoveAll(o => o.id == id);
        }
    }

}