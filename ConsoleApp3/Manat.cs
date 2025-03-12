namespace ConsoleApp3;

public class Manat
{
    public decimal AZN { get; set; }
    public Manat(decimal azn)
    {
        AZN = azn;
    }

    public static implicit operator Manat(decimal AZN)
    {
        return new(AZN);
    }


    public static bool operator ==(Manat a, Manat b)
    {
        return a.AZN == b.AZN;
    }

    public static bool operator >(Manat a, Manat b)
    {
        return a.AZN > b.AZN;
    }

    public static bool operator <(Manat a, Manat b)
    {
        return a.AZN < b.AZN;
    }

    public static bool operator >=(Manat a, Manat b)
    {
        return a.AZN >= b.AZN;
    }

    public static bool operator <=(Manat a, Manat b)
    {
        return a.AZN <= b.AZN;
    }


    public static bool operator !=(Manat a, Manat b)
    {
        return !(a == b);
    }

    public static decimal operator +(Manat a, Manat b)
    {
        return a.AZN + b.AZN;
    }

    public static decimal operator *(Manat a, Manat b)
    {
        return a.AZN * b.AZN;
    }
}
