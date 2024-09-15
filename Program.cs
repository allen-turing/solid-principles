using SRP;

var journal = new Journal();
journal.AddEntry("I did something today!");
var persistenceManager = new PersistenceManager();
persistenceManager.SaveEntry(journal, "File 1.txt");