namespace StrategyPatternDemo.Solution
{
    /// <summary>
    /// Defines the strategy for exporting user profiles as JSON
    /// </summary>
    /// <remarks>
    /// The implementation of this class has been omitted and is only for demonstrating how additional 
    /// strategy child classes could be created from <see cref="IExportStrategy"/>
    /// </remarks>
    public class JsonExportStrategy : IExportStrategy
    {
        /// <summary>
        /// Exports the <paramref name="userProfile"/> in JSON format
        /// </summary>
        /// <param name="userProfile">The user profile to export</param>
        public void Export(Profile userProfile)
        {
            // Implementation omitted
        }
    }
}
