namespace PilaresPOO.Classes.Pilares

{
    public abstract class Conta
    {
    public float Saldo { get; set; }
    public string? Titular { get; set; }
    public abstract float Sacar (float valor);
    public abstract bool Depositar (float valor);

    public void BotaSaldoAi(float grana)
    {
        Saldo = grana;
    }
    public float getSaldo()
    {
        return Saldo;
    }

    }
} 