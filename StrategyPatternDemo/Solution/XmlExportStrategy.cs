using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace StrategyPatternDemo.Solution
{
    /// <summary>
    /// Defines the strategy for exporting user profiles as XML
    /// </summary>
    public class XmlExportStrategy : IExportStrategy
    {
        private readonly string outputDirectory;
        private readonly string outputFileName;

        /// <summary>
        /// Initializes a new instance of the <see cref="XmlExportStrategy"/> class
        /// </summary>
        /// <param name="outputDirectory">The output directory to export to</param>
        /// <param name="outputFileName">The name of the exported file</param>
        public XmlExportStrategy(string outputDirectory, string outputFileName)
        {
            this.outputDirectory = outputDirectory;
            this.outputFileName = outputFileName;
        }

        /// <summary>
        /// Exports the specified user profile as XML
        /// </summary>
        /// <param name="userProfile">The user profile to export</param>
        public void Export(Profile userProfile)
        {
            var outputFilePath = Path.Combine(this.outputDirectory, $"{this.outputFileName}.xml");

            using (var writer = XmlWriter.Create(outputFilePath))
            {
                var serializer = new XmlSerializer(typeof(Profile));
                serializer.Serialize(writer, userProfile);
            }
        }
    }
}
