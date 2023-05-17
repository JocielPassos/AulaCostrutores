using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoAObjetos.Dia3
{
    public class Cliente
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Cpf { get; set;}

        public Cliente()
        { 
        
        }
        public Cliente(int id, string cpf, string nome) 
        {
            Id = id;
            Nome = cpf; 
            Cpf = nome;
        }


        public Cliente(int id)
        {
            Id = id;
        }

        public Cliente(string cpf, string nome)
        {
            Cpf = cpf;
            Nome = nome;
        }

       
        //Exercicio 
        //Cire construtores
        //Sobrecaregue

    }
}
