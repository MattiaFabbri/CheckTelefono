# Check Telefono
Ricevuto come parametro un vettore di string, ritornare al chiamante la prima stringa che assomiglia molto ad un numero di telefono cellulare italiano.

## Quando un numero è valido?
un numero per essere valido deve avere certe caratteristiche, le quali sono state elencate sotto:

Inizia con +39 e deve essere esattamente lungo 13 cifre.  
Inizia con 0039 e deve essere esattamente lungo 14 cifre.  
Inizia con un 3 e deve essere esattamente lungo 10 cifre.  

### Tutte le altre situazioni sono da scartare  

## Possibile soluzione
```c#
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
```  

