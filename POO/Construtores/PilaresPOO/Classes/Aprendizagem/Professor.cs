namespace PilaresPOO.Classes.Aprendizagem
{
    public class Professor : Pessoa
    {
        public int nif { get; set; }

        public float salario { get; set; }

        public Professor(int _nif)
        {
           nif = _nif; 
        } 
    }
}