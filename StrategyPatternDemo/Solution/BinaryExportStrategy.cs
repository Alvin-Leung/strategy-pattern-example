namespace StrategyPatternDemo.Solution
{
    /// <summary>
    /// Defines the strategy for exporting user profiles as Binary
    /// </summary>
    /// <remarks>
    /// The implementation of this class has been omitted and is only for demonstrating how additional 
    /// strategy child classes could be created from <see cref="IExportStrategy"/>
    /// </remarks>
    public class BinaryExportStrategy : IExportStrategy
    {
        /// <summary>
        /// Exports the <paramref name="userProfile"/> in binary format
        /// </summary>
        /// <param name="userProfile">The user profile to export</param>
        public void Export(Profile userProfile)
        {
            // Implementation omitted
        }
    }
}
