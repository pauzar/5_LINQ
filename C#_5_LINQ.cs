using system; 
using linq;
public class App
{
    public static void Main()
    {
//FASE 1 (2 punts)
//● Creeu un array amb els números donats al principi de la práctica. (0,5 punts)
//● Fent servir consultes linq guardeu en un array tots els números parells. (1 punt)
//● Mostreu l’array de números parells per consola. (0,5 punt)
        
        int[] numeros = { 2,6,8,4,5,5,9,2,1,8,7,5,9,6,4};
        IEnumerable pares =
            from d in numeros
            where d % 2 == 0
            orderby d
            select d;
        List <int> Lista_pares = new List <int>();
        foreach (int p in pares)
        {
            Lista_pares.Add(p);
        }
        Console.WriteLine(Lista_pares);

//FASE 2 (2 punts)
//● Calculeu a partir de l’array anterior la nota mitjana, la máxima i la mínima. (1 punts)
//● Mostreu per consola els resultats. (1 punt)
  		var max = numeros.Max();
  		var min = numeros.Min();
  		var avg = numeros.Average();
        
        Console.WriteLine(max);
        Console.WriteLine(min);
        Console.WriteLine(avg);
        
//FASE 3 (2,5 punts)
//● Fent una consulta linq guardeu en un array quins numero son mes grans que 5 i en un altre array quins
//son mes petits. (1,5 punts)
//● Mostreu per console els dos arrays. (1 punt)
        IEnumerable mayorq =
            from r in numeros
            where r > 5
            select r;
        List <int> Lista_mayorq = new List <int>();
        foreach (int r in mayorq)
        {
            Lista_mayorq.Add(r);
        }
        Console.WriteLine(Lista_mayorq);
        
        
        IEnumerable menorq =
            from e in numeros
            where e < 5
            select e;
        List <int> Lista_menorq = new List <int>();
        foreach (int e in menorq)
        {
            Lista_menorq.Add(e);
        }
        Console.WriteLine(Lista_menorq);

        string[] names = { "David", "Sergio", "Maria", "Laura", "Oscar", "Julia", "Oriol" };
       
//FASE 4 (3,5 punts)
//En aquesta fase farem servir un array amb noms: (David, Sergio, Maria, Laura, Oscar, Julia, Oriol)
//● Creeu un array amb els noms de l’enunciat. (0,5 punts)
//● Fent servir consultes linq mostreu per consola els noms que comencin amb la lletra “O”. (1 punt)
//● Fent servir consultes linq mostreu per consola quins noms tenen més de 6 lletres. (1 punt)
//● Fent servir consultes linq mostreu per consola els noms de l’array ordenats de manera descendent.
//(1 punt)
        IEnumerable query =
            from n in names
            where n.StartsWith("O")
            orderby n
            select n;
        foreach (string q in query)
        {
            Console.WriteLine(q);
        }
        
        IEnumerable masde6 =
            from k in names
            where k.Length>6
    		select k;
        foreach (string s in masde6)
        {
            Console.WriteLine(s);
        }
        
		IEnumerable desc =
            from k in names
            orderby k.Substring(0, 1) descending
    		select k;

        foreach (string s in desc)
        {
            Console.WriteLine(s);
        }          
    }
}