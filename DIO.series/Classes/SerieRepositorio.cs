using System.Collections.Generic;
using System;
using DIO.Series.Interfaces;

namespace DIO.series.Classes
{
    public class SerieRepositorio : iRepositorio<Serie>
    {

        private List<Serie> listaSerie = new List<Serie>();

        public void Atualiza(int id, Serie objeto)
        {
            listaSerie[id] = objeto;
        }

        public void Exclui(int id)
        {
            listaSerie[id].Excluir();
        }

        public void Insere(Serie objeto)
        {
            listaSerie.Add(objeto);
        }

        public List<Serie> Lista()
        {
            return listaSerie;
        }

        public int ProximoId()
        {
            return listaSerie.Count
        }

        public Serie RetornaPorId(int id)
        {
            return listaSerie[id];
        }
    }
}