namespace CompositePatternC_
{
    //Composite
    public class Branch : GitComponent
    {
        private readonly string _name;

        public Branch(string name)
        {
            _name = name;
        }

        public override void ShowDetail()
        {
            Console.WriteLine($"Branch {_name} with commits: ");
            foreach(GitComponent component in _components)
            {
                component.ShowDetail();
            }
        }
    }
}
