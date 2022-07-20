public class Tree
{

    public string Name { get; set; }

    public IEnumerable<Tree> Children { get; set; }

    public List<string> GetNames() {
        var names = new List<string>();

        foreach (var c in Children) {
            names.Add(c.Name);
        }

        return names;
    }

}