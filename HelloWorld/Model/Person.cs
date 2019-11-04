using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld.Model
{
    class Person
    {
        public string nome;
        public string cognome;
        public int età;
        public string sesso;
        public int altezza;
        public double peso;
        public Person(string nome, string cognome)      //Firma completa del metodo
        {
            this.nome = nome;       //Il this serve per riferirsi alla variabile della classe
            this.cognome = cognome;
            this.sesso = "Sconosciuto";
        }
        public Person(string nome)
        {
        }
        public string Anagrafica()
        {
            string anagrafica = this.nome + " " + this.cognome;
            return anagrafica;
        }
    }
}
