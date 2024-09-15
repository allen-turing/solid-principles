namespace SRP
{
	public class Journal
	{
		private readonly List<string> _entries = new();

		private static int count = 0;

		public void AddEntry(string text)
		{
			_entries.Add($"{++count}: {text}");
		}

		public void RemoveEntry(int index)
		{
			_entries.RemoveAt(index);
		}

		public void SaveEntry(string fileName, bool overWrite = false)
		{
			File.WriteAllText(fileName, _entries[_entries.Count - 1]);
		}
	}
}
