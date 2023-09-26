
public static class Telefono
{
    public static string Check(string[] input)
    {
        foreach (string var in input)
        {
            //rimuovo i spazi non necessari che potrebbo causare problemi
            string c = var.Trim().Replace(" ", "");

            //Controllo se inizia con 0039 e che deve essere esattamente lungo 14 cifre.
            if (c.Length == 14)
            {
                if (c[0] == '0' && c[1] == '0' && c[2] == '3' && c[3] == '9')
                    return c;
            }

            //Controllo se inizia con +39 e che deve essere esattamente lungo 13 cifre.
            if (c.Length == 13)
            {
                if (c[0] == '+' && c[1] == '3' && c[2] == '9')
                    return c;
            }

            //Controllo se inizia con un 3 e che deve essere esattamente lungo 10 cifre.
            if (c.Length == 10)
            {
                if (c[0] == '3')
                    return c;
            }
        }
        return "";
    }


}
