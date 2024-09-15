namespace SRP
{
	public class PersistenceManager
	{
		public void SaveEntry(Journal journal, string fileName, bool overWrite = false)
		{

			if (overWrite || !File.Exists(fileName))
				File.WriteAllText(fileName, journal.GetLatestEntry());
		}
	}
}
