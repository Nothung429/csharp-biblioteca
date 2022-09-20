Console.WriteLine("Hello, World!");

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

public class User
{
    private string name;
    private string surname;
    private string email;
    private string password;
    private string phone;

    public User(string name, string surname, string email, string password, string phone)
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
    public string GetPhone()
    {
        return this.phone;
    }
}

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

public class Book : Product
{
    private int ISBN;

    public Book(int ISBN, int year, string title, string author, string category, bool status) : base(year, title, author, category, status)
    {
        this.ISBN = ISBN;
    }

    public int GetIsbn()
    {
        return this.ISBN;
    }
}

public class Film : Product
{
    private int code;

    public Film(int code, int year, string title, string author, string category, bool status) : base(year, title, author, category, status)
    {
        this.code = code;
    }
    public int GetCode()
    {
        return this.code;
    }
}