namespace Pipeline.Data
{
    [AttributeUsage(AttributeTargets.All, Inherited = true, AllowMultiple = true)]
    public abstract class SuportsDataAttributeBase : Attribute
    {
        public Type? SupportedType { get; set; }
        public SuportsDataAttributeBase(Type? type)
        {
            SupportedType = type;
        }
    }

    [AttributeUsage(AttributeTargets.All, Inherited = true, AllowMultiple = true)]
    public sealed class SuportsInputDataAttribute : SuportsDataAttributeBase
    {
        public SuportsInputDataAttribute(Type type) : base(type)
        {
        }
    }

    [AttributeUsage(AttributeTargets.All, Inherited = true, AllowMultiple = true)]
    public sealed class SuportsOutputDataAttribute : SuportsDataAttributeBase
    {
        public SuportsOutputDataAttribute(Type type) : base(type)
        {
        }
    }

    [AttributeUsage(AttributeTargets.All, Inherited = true, AllowMultiple = true)]
    public sealed class SuportsAnyInputDataAttribute : SuportsDataAttributeBase
    {
        public SuportsAnyInputDataAttribute() : base(null)
        {
        }
    }

    [AttributeUsage(AttributeTargets.All, Inherited = true, AllowMultiple = true)]
    public sealed class SuportsAnyOutputDataAttribute : SuportsDataAttributeBase
    {
        public SuportsAnyOutputDataAttribute() : base(null)
        {
        }
    }
}