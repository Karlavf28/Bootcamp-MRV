using System.Collections.Generic;
using DIO.series;
using DIO.series.Classes;

namespace DIO.series.Interfaces
{
    
        public interface iRepositorio<T>
    {
        List<T> Lista();
        T RetornaPorId(int id);
        void Insere(T entidade);
        void Exclui(int id);
        void Atualiza(int id, T entidade);
        int ProximoId();
    }
}


