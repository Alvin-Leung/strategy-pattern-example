namespace StrategyPatternDemo.Solution
{
    /// <summary>
    /// Exports a user's <see cref="Profile"/> in the desired format
    /// </summary>
    public class ProfileExporter
    {
        private readonly IExportStrategy exportStrategy;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProfileExporter"/> class.
        /// </summary>
        /// <param name="exportStrategy">The strategy to use when exporting profiles</param>
        public ProfileExporter(IExportStrategy exportStrategy)
        {
            this.exportStrategy = exportStrategy;
        }

        /// <summary>
        /// Exports the specified user profile
        /// </summary>
        /// <param name="userProfile">The user profile to export</param>
        public void Export(Profile userProfile)
        {
            this.exportStrategy.Export(userProfile);
        }
    }
}
