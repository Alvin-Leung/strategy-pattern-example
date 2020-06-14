using StrategyPatternDemo.Solution;
using System.IO;

namespace StrategyPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var myProfile = new Profile
            {
                Age = 35,
                Sex = "M",
                Location = "London"
            };

            var strategy = new XmlExportStrategy(Directory.GetCurrentDirectory(), "myProfile");
            var exporter = new ProfileExporter(strategy);
            exporter.Export(myProfile);
        }
    }
}
