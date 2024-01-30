namespace BE_Day_2_esercizio
{
    internal class Persona
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public int Eta { get; set; }
        public Persona(string nome, string cognome, int eta)
        {
            Nome = nome;
            Cognome = cognome;
            Eta = eta;
        }
        public string getDettagli()
        {
            return "Nome: " + Nome + " Cognome: " + Cognome + " Eta: " + Eta;
        }

    }

}
