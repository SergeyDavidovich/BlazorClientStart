namespace BlazorClientStart.Domain.Shared.Option
{
    public abstract class OptionBase<TValue>
    {
        protected OptionBase() { }

        protected internal OptionBase(string name, TValue value)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new EmptyOptionNameException(nameof(Name));

            Id = Guid.NewGuid();
            Name = name;
            Value = value;
        }

        public Guid Id { get; }

        public string Name { get; private set; }

        public TValue Value { get; set; }
    }
}