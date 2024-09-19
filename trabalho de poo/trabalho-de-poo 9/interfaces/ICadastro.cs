using System;

namespace Interfaces
{
    public interface ICadastro<T>
    {
        void Adicionar(T entity);
        T Buscar(string identifier);
    }

    public interface IVacinacao
    {
        void AgendarVacinação(DateTime data);
        void Vacinar();
    }
}