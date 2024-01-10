namespace CompositePatternC_
{
    public abstract class GitComponent
    {
        //Component
        protected readonly List<GitComponent> _components = new List<GitComponent>();
        public abstract void ShowDetail();

        public void Add(GitComponent component) 
        {
            _components.Add(component);
        }
        public void Remove(GitComponent component)
        {
            _components.Remove(component);
        }
    }
}
