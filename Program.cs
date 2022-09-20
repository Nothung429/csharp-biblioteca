//Si vuole progettare un sistema per la gestione di una biblioteca. Gli utenti si possono registrare al sistema, fornendo:
//    cognome,
//    nome,
//    email,
//    password,
//    recapito telefonico,

//Gli utenti registrati possono effettuare dei prestiti sui documenti che sono di vario tipo (libri, DVD). I documenti sono caratterizzati da:
//    un codice identificativo di tipo stringa (ISBN per i libri, numero seriale per i DVD),
//    titolo,
//    anno,
//    settore(storia, matematica, economia, …),
//    stato(In Prestito, Disponibile),
//    uno scaffale in cui è posizionato,
//    un autore (Nome, Cognome).

//Per i libri si ha in aggiunta il numero di pagine, mentre per i dvd la durata.

//L’utente deve poter eseguire delle ricerche per codice o per titolo e, eventualmente, effettuare dei prestiti registrando il periodo (Dal/Al) del prestito e il documento.
//Deve essere possibile effettuare la ricerca dei prestiti dato nome e cognome di un utente.

//creazione utente 
User myUser = new User("Mario", "Rossi", "mariorossi@gmail.com", "prova123", 333777888);

//creazione prodotti
Book myBook = new Book(12345678, 1200, "il signore degli anelli", 1954, "J. R. R. Tolkien", "fantasy", true);
Film myFilm = new Film(87654321, 200, "il signore degli anelli: la compagnia dell'anello", 2001, "J. R. R. Tolkien", "fantasy", true);

Console.WriteLine("Esegui l'accesso");
bool verifyUserEmail = myUser.GetEmail().Contains(Console.ReadLine());
bool verifyUserPassword = myUser.GetPassword().Contains(Console.ReadLine());
if (verifyUserEmail == true && verifyUserPassword == true)
{
    //ricerca
    Console.WriteLine("Cerca un libro");
    bool searchBooks = myBook.title.Contains(Console.ReadLine());
    if (searchBooks == true)
    {
        Console.WriteLine($"Il libro esiste in libreria? {myBook.title} \n");
    }
    else
    {
        Console.WriteLine("Ci dispiace non abbiamo questo titolo \n");
    }

    Console.WriteLine("Cerca un film");
    bool searchFilms = myFilm.title.Contains(Console.ReadLine());
    if (searchFilms == true)
    {
        Console.WriteLine($"Il film esiste in libreria? {myFilm.title} \n");
    }
    else
    {
        Console.WriteLine("Ci dispiace non abbiamo questo titolo \n");
    }
}
else
{
    Console.WriteLine("Registrati merda");
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