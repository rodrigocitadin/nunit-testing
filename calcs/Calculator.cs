namespace calcs;

public class Calculator
{
    public int Sum(int x, int y) => x + y;
    public int Sub(int x, int y) => x - y;
    public int Mult(int x, int y) => x * y;
    public int Div(int x, int y) => x / y;
    public (int a, int b) Rem(int x, int y) => (x / y, x % y);
}

