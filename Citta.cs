using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace prova
{
    public class Città
    {
        // Attributi e incapsulamento
        public string _nome { get; set; }
        public string _sindaco { get; set; }
        int capacitàMassima { get; set; }
        public int[] _cittadino = new int[10];
        int i = 0;

        // Costruttore per creare un'istanza della citta
        public Città(string nome, string sindaco, int capacità)
        {
            _nome = nome;
            _sindaco = sindaco;
            capacitàMassima = capacità;

        }


        // Metodo per creare un cittadino maggiorene in una Città 
        public void addCittadino(Cittadino cittadino)
        {
            cittadino.dataDiNas();
            DateTime result = new DateTime();
            DateTime.TryParse(cittadino.dataDiNascita, out result);
            if (result.Year <= DateTime.Now.Year - 18)
            {
                if (i <= capacitàMassima)

                {
                    _cittadino[i] = cittadino._id;
                    cittadino.città = this;
                    i += 1;
                }
                else { Console.WriteLine("La città non ammette più cittadini"); }
            }
            else Console.WriteLine("Il cittadino ha meno di 18 anni quindi non può entrare");
        }

        // Metodo per Stampare un cittadino ( mediante l'uso del FOREACH molto comodo per la stampa
        // delle liste e Array)
        public void stampaCittadino()
        {

            foreach (int cittadini in _cittadino)
            {
                if (i <= cittadini)
                    Console.WriteLine(cittadini);

            }
        }




      
    }
}
