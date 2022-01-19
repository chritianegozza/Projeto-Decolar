using System;

namespace Dio.Series
{
    public class Serie : EntidadeBase
    {
       //Atributos

       private Genero Genero { get; set; }
       private string Titulo { get; set; }

       private string Descricao { get; set; }

       private int Ano { get; set; }
       private bool Excluido { get; set; }

       //Métodos
       public Serie(int id, Genero genero, string titulo, string descricao, int ano)
       {
           this.Id = id;
           this.Genero = genero;
           this.Titulo = titulo;
           this.Descricao = descricao;
           this.Ano = ano;
           this.Excluido = false;
       }

        public override string ToString()
        {  
            //Environment.NewLine https://docs.microsoft.com/en-us/dotnet/api/system.environment.newline?view=netcore-3.1
            string returno = "";
            returno += "Gênero: " + this.Genero + Environment.NewLine;
            returno += "Titulo: " + this.Titulo + Environment.NewLine;
            returno += "Descrição: " + this.Descricao + Environment.NewLine;
            returno += "Ano de Início: " + this.Ano + Environment.NewLine;
            returno += "Excluido: " + this.Excluido;
            return returno;
        }

        public string retornaTitulo()
        {
            return this.Titulo;
        }

        public int  retornaId()
        {
            return this.Id;
        }
        public bool retornaExcluido()
        {
            return this.Excluido;
        }
        public void Ecluir()
        {
            this.Excluido = true;
        }

    }
}