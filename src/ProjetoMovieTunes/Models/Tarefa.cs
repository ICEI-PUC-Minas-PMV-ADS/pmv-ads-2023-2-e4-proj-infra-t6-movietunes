using System;


namespace ProjetoMovieTunes.Models
{

    public class Tarefa
    {
        public Tarefas(string nome,string filmes,string trilha,string avaliacao)
        {
            Id = Guid.NewGuid().ToString();
            None = nome;
            Filmes = filmes;
            Trilha = trilha;
            Avaliacao = avaliacao;
        
        }


      public string Id {get; set}

     public string Nome { get; private set;}

     public string Filmes {get; set;}

     public string Trilha {get; set;}   

    public string Avaliacao { get; set;}


    }
}