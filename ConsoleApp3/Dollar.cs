namespace ConsoleApp3;

public class Dollar
{
    public decimal USD { get; set; }

    public Dollar(decimal usd)
    {
        USD = usd;
    }


    public static implicit operator Dollar(decimal usd)
    {

        return new Dollar(usd);
    }

    public static implicit operator Dollar(Manat manat)
    {
        return new Dollar(manat * 0.59m);
    }
    public override string ToString()
    {
        return $"{USD}$";
    }

}
