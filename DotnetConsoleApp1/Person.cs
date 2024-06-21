namespace DotnetConsoleApp1
{
    public struct Person
    {
        public int Id { get; set; } = 0;
        public string Name { get; set; } = String.Empty;

        public Person(int id, string name) => (Id, Name) = (id, name);
    }
}