using System.Collections.Generic;

namespace DIO.Series.Interfaces
{
 
    public interface IRepositorio<t>
    {
        List<t> Lista();       
         t RetornaPorId(int id);        
        void Insere(t entidade);        
        void Exclui(int id);        
        void Atualiza(int id, t entidade);
        int ProximoId();
    }
}