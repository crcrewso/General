using System;
using System.IO;
using Tomlyn;

namespace TOML_Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string toml = File.ReadAllText("../../../Resources/Config.toml");

            var model = Toml.ToModel(toml);
            var tomlOut = Toml.FromModel(model);
            var config = new Config();
            config.Save();

            Console.WriteLine(tomlOut);




        }
    }
}
