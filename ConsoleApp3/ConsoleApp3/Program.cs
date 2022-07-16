public class Tree
{
    public Tree(string name, IEnumerable<Tree> children)
    {
        Name = name;
        Children = children;
    }

    public string Name { get; set; }

    public IEnumerable<Tree> Children { get; set; }

    public IEnumerable<string>  GetChildNames()
    {
        return Children.Select(x => x.Name);
    }

}