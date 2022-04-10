using System.Collections.Generic;

namespace projetofinal.Interfaces
{
    public interface IRepositorio <T>
    {
        List <T> Lista(); //um metodo chamado lista.
        T RetornaPorId(int id);
        void Insere(T entidade);
        void Exclui(int id);
        void Atualiza(int id, T entidade);
        int ProximoId();
    }
}