using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace StrategyPatternDemo.AntiPattern
{
    /// <summary>
    /// Exports a user's <see cref="Profile"/> in the desired format
    /// </summary>
    public class ProfileExporter
    {
        private readonly string outputDirectory;
        private readonly string outputFileName;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProfileExporter"/> class.
        /// </summary>
        /// <param name="outputDirectory">The directory which the exported file will be saved in</param>
        /// <param name="outputFileName">The filename of the exported file, without extension</param>
        public ProfileExporter(string outputDirectory, string outputFileName)
        {
            this.outputDirectory = outputDirectory;
            this.outputFileName = outputFileName;
        }

        /// <summary>
        /// Export the <paramref name="userProfile"/> in XML format
        /// </summary>
        /// <param name="userProfile">The user's profile</param>
        public void ExportAsXml(Profile userProfile)
        {
            var outputFilePath = Path.Combine(this.outputDirectory, $"{this.outputFileName}.xml");

            using (var writer = XmlWriter.Create(outputFilePath))
            {
                var serializer = new XmlSerializer(typeof(Profile));
                serializer.Serialize(writer, userProfile);
            }
        }

        /// <summary>
        /// Exports the <paramref name="userProfile"/> in JSON format
        /// </summary>
        /// <param name="userProfile">The user's profile</param>
        public void ExportAsJson(Profile userProfile)
        {
            // Does the same thing as ExportAsXml, except with JSON output
        }

        /// <summary>
        /// Exports the <paramref name="userProfile"/> into a file containing raw bytes
        /// </summary>
        /// <param name="userProfile">The user's profile</param>
        public void ExportAsBinary(Profile userProfile)
        {
            // Does the same thing as ExportAsXml, except with binary output
        }
    }
}
