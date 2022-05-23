namespace DesafioTecnicoFramework.Api.Helper;

public static class IntHelper
{
    public static bool IsPrimeNumber(this int number)
    {
        for (var i = 2; i <= number / 2; i++)
        {
            if (number % i == 0)
                return false;
        }
        return true;
    }
}