using exercise_gitHub_new;

class Program
{
    static void Main(string[] args)
    {
        // Lista di contatti fittizia
        List<Contact> contacts = new List<Contact>
            {
                new Contact { Name = "Mario Rossi", PhoneNumber = "123-456-7890", Email = "mario.rossi@example.com" },
                new Contact { Name = "Luca Bianchi", PhoneNumber = "098-765-4321", Email = "luca.bianchi@example.com" },
                new Contact { Name = "Giulia Verdi", PhoneNumber = "555-123-4567", Email = "giulia.verdi@example.com" }
            };

        // Aggiungi un nuovo contatto
        Console.WriteLine("Inserisci il nome del nuovo contatto:");
        string newName = Console.ReadLine();
        Console.WriteLine("Inserisci il numero di telefono del nuovo contatto:");
        string newPhoneNumber = Console.ReadLine();
        Console.WriteLine("Inserisci l'email del nuovo contatto:");
        string newEmail = Console.ReadLine();

        contacts.Add(new Contact { Name = newName, PhoneNumber = newPhoneNumber, Email = newEmail });

        // Cerca un contatto per nome
        Console.WriteLine("\nInserisci il nome del contatto da cercare:");
        string searchName = Console.ReadLine();
        Contact foundContact = contacts.Find(contact => contact.Name.Equals(searchName, StringComparison.OrdinalIgnoreCase));

        if (foundContact != null)
        {
            Console.WriteLine($"Contatto trovato: Nome: {foundContact.Name}, Telefono: {foundContact.PhoneNumber}, Email: {foundContact.Email}");
        }
        else
        {
            Console.WriteLine("Contatto non trovato.");
        }

        // Elimina un contatto per nome
        Console.WriteLine("\nInserisci il nome del contatto da eliminare:");
        string deleteName = Console.ReadLine();
        Contact contactToDelete = contacts.Find(contact => contact.Name.Equals(deleteName, StringComparison.OrdinalIgnoreCase));

        if (contactToDelete != null)
        {
            contacts.Remove(contactToDelete);
            Console.WriteLine("Contatto eliminato con successo.");
        }
        else
        {
            Console.WriteLine("Contatto non trovato.");
        }

        // Stampa la lista dei contatti
        Console.WriteLine("\nLista dei contatti:");
        foreach (var contact in contacts)
        {
            Console.WriteLine($"Nome: {contact.Name}, Telefono: {contact.PhoneNumber}, Email: {contact.Email}");
        }
    }
}

