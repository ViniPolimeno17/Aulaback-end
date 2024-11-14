namespace PilaresPOO.Classes.Aprendizagem
{
    public abstract class Pessoa
    {
        public string? nome;
        public int idade;
        public int cpf;
        public float peso { get; set; }
        public float altura { get; set; }

        public void Envelhecer()
        {
            idade++;
        }
        public void Engordar(float _kg)
        {
            peso = peso + _kg;
        }

        public void Emagrecer(float _kg)
        {
            peso = peso - _kg;
        }
    }
}