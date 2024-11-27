using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using YamlDotNet.Serialization.NamingConventions;
using YamlDotNet.Serialization;
using RagnarokItensPriceTool;

namespace Arkaik_Monster_Json_Enchancer
{
    internal class ConverterService
    {
        public List<T> ExtractObjects<T>(string path)
        {
            if (string.IsNullOrEmpty(path))
                return null;

            string json = File.ReadAllText(path);
            try
            {
                return JsonSerializer.Deserialize<List<T>>(json);
            }
            catch
            {
                MessageBox.Show("Falha ao tentar ler os dados", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }

        public ItemData ExtractObjectYaml(string path)
        {
            if (string.IsNullOrEmpty(path))
                return null;

            try
            {
                var deserializer = new DeserializerBuilder()
                //.WithNamingConvention(PascalCaseNamingConvention.Instance) // Converte nomes de propriedades
                .Build();

                string ymlString = File.ReadAllText(path);
                return deserializer.Deserialize<ItemData>(ymlString);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao tentar ler os dados", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }

        public void SaveToYamlFile<T>(string filePath, T data)
        {
            // Configurando o serializador para ignorar valores nulos
            var serializer = new SerializerBuilder()
                //.WithNamingConvention(CamelCaseNamingConvention.Instance) // Define o estilo camelCase
                .ConfigureDefaultValuesHandling(DefaultValuesHandling.OmitDefaults) // Ignora valores nulos
                .Build();

            // Serializando os objetos para uma string YAML
            string yamlContent = serializer.Serialize(data);

            // Escrevendo o YAML em um arquivo
            File.WriteAllText(filePath, yamlContent);
        }
    }
}
