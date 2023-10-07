using System.Collections.Generic;
using ProjetoMovieTunes.API.Models;

namespace ProjetoMovieTunes.Data.Repositories
{
    public interface ITarefasRepository
    {
      void Adicionar(Tarefa tarefa);

      void Atualizar(string id,Tarefa tarefaAtualizada);

      IEnumerable<Tarefa> Buscar();  

      Tarefa Buscar(string Id);
    }
}