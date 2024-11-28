using YamlDotNet.Core;
using YamlDotNet.Serialization.TypeInspectors;
using YamlDotNet.Serialization;

namespace RagnarokItensPriceTool
{
    public class CustomTypeInspector : TypeInspectorSkeleton
    {
        private readonly ITypeInspector _innerTypeInspector;

        public CustomTypeInspector(ITypeInspector innerTypeInspector)
        {
            _innerTypeInspector = innerTypeInspector;
        }

        public override IEnumerable<IPropertyDescriptor> GetProperties(Type type, object container)
        {
            return _innerTypeInspector.GetProperties(type, container)
                .Select(p => new CustomPropertyDescriptor(p));
        }

        public override string GetEnumValue(object value)
        {
            return _innerTypeInspector.GetEnumValue(value);
        }

        public override string GetEnumName(Type type, string value)
        {
            return _innerTypeInspector.GetEnumName(type, value);
        }
    }

    public class CustomPropertyDescriptor : IPropertyDescriptor
    {
        private readonly IPropertyDescriptor _baseDescriptor;

        public CustomPropertyDescriptor(IPropertyDescriptor baseDescriptor)
        {
            _baseDescriptor = baseDescriptor;
            ScalarStyle = ScalarStyle.Any; // Estilo padrão
        }

        public string Name => _baseDescriptor.Name;
        public Type Type => _baseDescriptor.Type;
        public Type TypeOverride { get => _baseDescriptor.TypeOverride; set => _baseDescriptor.TypeOverride = value; }
        public int Order { get => _baseDescriptor.Order; set => _baseDescriptor.Order = value; }
        public ScalarStyle ScalarStyle { get; set; }
        public bool CanWrite => _baseDescriptor.CanWrite;
        public bool AllowNulls => _baseDescriptor.AllowNulls;
        public bool Required => _baseDescriptor.Required;
        public Type ConverterType => _baseDescriptor.ConverterType;

        public void Write(object target, object value) => _baseDescriptor.Write(target, value);

        public T GetCustomAttribute<T>() where T : Attribute => _baseDescriptor.GetCustomAttribute<T>();

        public IObjectDescriptor Read(object target)
        {
            var descriptor = _baseDescriptor.Read(target);

            // Determina o estilo do valor com base no conteúdo
            if (descriptor.Value is string stringValue)
            {
                if (stringValue.Contains('\n')) // Multiline -> usa '|'
                    return new ObjectDescriptor(stringValue, typeof(string), typeof(string), ScalarStyle.Literal);
                if (stringValue.Contains(":") || stringValue.Contains("\"")) // Aspas desnecessárias
                    return new ObjectDescriptor(stringValue, typeof(string), typeof(string), ScalarStyle.Plain);
            }

            return descriptor;
        }
    }
}
