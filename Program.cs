//L’utente deve poter eseguire delle ricerche per codice o per titolo e, eventualmente, effettuare dei prestiti registrando il periodo (Dal/Al) del prestito e il documento.
//Deve essere possibile effettuare la ricerca dei prestiti dato nome e cognome di un utente.

//creazione utente
User myUser = new User("Mario", "Rossi", "mariorossi@gmail.com", "prova123", 333777888);

//creazione prodotti
Book myBook = new Book(12345678, 1200, "il signore degli anelli", 1954, "J. R. R. Tolkien", "fantasy", true);
Film myFilm = new Film(87654321, 200, "il signore degli anelli: la compagnia dell'anello", 2001, "J. R. R. Tolkien", "fantasy", true);

//accesso
Console.WriteLine("Esegui l'accesso");
string verifyUserEmail = Console.ReadLine();
string verifyUserPassword = Console.ReadLine();
if (verifyUserEmail == myUser.GetEmail() && verifyUserPassword == myUser.GetPassword())
{
    //ricerca
    Console.WriteLine("Cerca un libro");
    bool searchBooksTitle = myBook.title.Contains(Console.ReadLine());
    bool searchBooksIsbn = myBook.title.Contains(Console.ReadLine());
    if (searchBooksTitle == true || searchBooksIsbn == true)
    {
        Console.WriteLine($"Il libro esiste in libreria? {myBook.title} \n");
    }
    else
    {
        Console.WriteLine("Ci dispiace non abbiamo questo titolo \n");
    }

    Console.WriteLine("Cerca un film");
    bool searchFilmsTitle = myFilm.title.Contains(Console.ReadLine());
    bool searchFilmsCode = myFilm.title.Contains(Console.ReadLine());
    if (searchFilmsTitle == true || searchFilmsCode == true)
    {
        Console.WriteLine($"Il film esiste in libreria? {myFilm.title} \n");
    }
    else
    {
        Console.WriteLine("Ci dispiace non abbiamo questo titolo \n");
    }

    //prenotazione
    if (myBook.status == true)
    {
        Console.WriteLine("Vuoi prenotare il libro?\n si/no");
        if (Console.ReadLine() == "si")
        {
            Console.WriteLine($"{myBook.title} prenotato con successo");
            myBook.status = false;
        }
        else
        {
            Console.WriteLine($"{myBook.title} non prenotato");
            myBook.status = true;
        }
    } 
    else
    {
        Console.WriteLine("Libro non disponibile");
    }

    if (myFilm.status == true)
    {
        Console.WriteLine("Vuoi prenotare il film?\n si/no");
        if (Console.ReadLine() == "si")
        {
            Console.WriteLine($"{myFilm.title} prenotato con successo");
            myFilm.status = false;
        }
        else
        {
            Console.WriteLine($"{myFilm.title} non prenotato");
            myFilm.status = true;
        }
    }
    else
    {
        Console.WriteLine("Film non disponibile");
    }
}
else
{
    Console.WriteLine("\nRegistrati\n");
}

//Console.WriteLine($"\nL'ISBN del libro è: {myBook.GetIsbn()}");
//Console.WriteLine($"Il numero di pagine del libro è: {myBook.GetPageNumber()}");
//Console.WriteLine($"Il titolo del libro è: {myBook.title}");
//Console.WriteLine($"L'anno di uscita del libro è: {myBook.year}");
//Console.WriteLine($"L'autore del libro è: {myBook.author}");
//Console.WriteLine($"La categoria del libro è: {myBook.category}");
//Console.WriteLine($"La disponibilità del libro è: {myBook.status} \n");

//Console.WriteLine($"\nIl codice del film è: {myFilm.GetCode()}");
//Console.WriteLine($"La durata del film è: {myFilm.GetDuration()} minuti");
//Console.WriteLine($"Il titolo del film è: {myFilm.title}");
//Console.WriteLine($"L'anno di uscita del film è: {myFilm.year}");
//Console.WriteLine($"L'autore del film è: {myFilm.author}");
//Console.WriteLine($"La categoria del film è: {myFilm.category}");
//Console.WriteLine($"La disponibilità del film è: {myFilm.status} \n");

//funzioni
public class User
{
    private string name;
    private string surname;
    private string email;
    private string password;
    private int phone;

    public User(string name, string surname, string email, string password, int phone)
    {
        this.name = name;
        this.surname = surname;
        this.email = email;
        this.password = password;
        this.phone = phone;
    }

    public string GetName()
    {
        return this.name;
    }
    public string GetSurname()
    {
        return this.surname;
    }
    public string GetEmail()
    {
        return this.email;
    }
    public string GetPassword()
    {
        return this.password;
    }
    public int GetPhone()
    {
        return this.phone;
    }
}
//--------------------------------------------------------------------------//
public class Product
{
    protected internal int year;
    protected internal string title;
    protected internal string author;
    protected internal string category;
    protected internal bool status;

    public Product(int year, string title, string author, string category, bool status)
    {
        this.year = year;
        this.title = title;
        this.author = author;
        this.category = category;
        this.status = status;
    }
}
//--------------------------------------------------------------------------//
public class Book : Product
{
    private int ISBN;
    private int pageNumber;

    public Book(int ISBN, int pageNumber, string title, int year, string author, string category, bool status) : base(year, title, author, category, status)
    {
        this.ISBN = ISBN;
        this.pageNumber = pageNumber;
    }

    public int GetIsbn()
    {
        return this.ISBN;
    }
    public int GetPageNumber()
    {
        return this.pageNumber;
    }
}
//--------------------------------------------------------------------------//
public class Film : Product
{
    private int code;
    private int duration;

    public Film(int code, int duration, string title, int year, string author, string category, bool status) : base(year, title, author, category, status)
    {
        this.code = code;
        this.duration = duration;
    }
    public int GetCode()
    {
        return this.code;
    }
    public int GetDuration()
    {
        return this.duration;
    }
}