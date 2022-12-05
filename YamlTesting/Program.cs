using System;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;


namespace YamlTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var config = new Settings();
            var serializer = new SerializerBuilder().WithNamingConvention(CamelCaseNamingConvention.Instance).Build();
            var result = serializer.Serialize(config);
            Console.WriteLine(result);
            Console.Read();
        }
    }

    public class Info
    {
        public string Street { get; set; }

    }

    public class Person
    {
        public string Name { get; set; }

    }



}
