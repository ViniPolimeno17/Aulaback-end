namespace Calculator.Classes
{
    public class Calculadora
    {
        public float numero1;
        public float numero2;

        public void Somar()
        {
            float Resultado = numero1 + numero2;
            Console.WriteLine($"Oh resultado é: {Resultado}");
        }
        public void Subtrair()
        {
            float Resultado = numero1 - numero2;
            Console.WriteLine($"Oh resultado é: {Resultado}");
        }
        public void Multiplicacao()
        {
            float Resultado = numero1 * numero2;
            Console.WriteLine($"Oh resultado é: {Resultado}");
        }
        public void Divisao()
        {
            float Resultado = numero1 / numero2;
            Console.WriteLine($"Oh resultado é: {Resultado}");
        }

    }
}