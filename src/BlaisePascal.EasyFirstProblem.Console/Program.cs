public class Program {

    public static void Main()
    {
        Console.WriteLine("Inserire il nome utente");
        string nomeUtente = Console.ReadLine();

        Console.WriteLine("Inserire il numero di libri acquistati");
        int libriAcquistati = Console.Read();

        Console.WriteLine("Inserire il costo di un libro");
        double costoDiUnLibro= Console.Read();

        Console.WriteLine("Che tipo di consegna si desidera? (spedizione o ritiro)");
        string tipoDiConsegna = Console.ReadLine(); //Aggiungere controlli

        Console.WriteLine("Sei uno studente? (y per sì)");
        bool èUnoStudente = Console.ReadLine() == "y"; //Da rendere più pulito e aggiungere i controlli

        double spedizione = 5.0;

        int annullaConsegna = 0; //Serve a annullare il costo di spedizione nel caso si scelga il ritiro

        if (tipoDiConsegna == "spedizione") annullaConsegna = 1;

        double costoTotale = costoDiUnLibro * libriAcquistati + spedizione * annullaConsegna;

        if (costoTotale <= 0)
        {
            Console.WriteLine("Ordine non valido!");
        }
        else
        {
            Console.WriteLine($"Hai acquistato {libriAcquistati} libro/i");
            Console.WriteLine($"Il costo cadauno è: {costoDiUnLibro}");
            Console.WriteLine($"La spedizione è: {spedizione}");
            Console.WriteLine($"L'utente che ha effettuato l'ordine è: {nomeUtente}");
            Console.WriteLine($"Il costo totale è: {libriAcquistati * costoDiUnLibro + spedizione * annullaConsegna}");
            if (costoTotale < 25.0) Console.WriteLine("Ordine di Piccolo importo"); 
            else Console.WriteLine("Grazie per il tuo ordine!");
        }
    }
}
