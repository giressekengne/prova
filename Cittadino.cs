using System;

namespace prova
{
    public class Cittadino
    {

        // Attributi ed Incapsulamento
        public string nome { get; set; }
        public string cognome { get; set; }
        public string sesso { get; set; }
        public string dataDiNascita { get; set; }
        public int _id { get; set; }
        public Città città;


        //Costruttore per Creare instanza un istanza del cittadino
        public Cittadino(string nome, string cognome, string sesso, int id)
        {
            this.nome = nome;
            this.cognome = cognome;
            this.sesso = sesso;
            this._id = id;

        }

        // Metodo per Prendere la data di nascita da Tastiere (Comparabile alla scanf in c)
        public void dataDiNas()
        {
            Console.WriteLine("Inserire la data di nascita");
            dataDiNascita = Console.ReadLine();
        }

        
    }
}
