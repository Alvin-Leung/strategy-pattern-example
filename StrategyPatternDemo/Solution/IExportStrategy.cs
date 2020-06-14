namespace StrategyPatternDemo.Solution
{
    /// <summary>
    /// Defines the interface that all export strategies utilized by <see cref="ProfileExporter"/>
    /// should have
    /// </summary>
    /// <remarks>
    /// This is the strategy interface for any type of export that <see cref="ProfileExporter"/>
    /// supports. To extend the export behavior of <see cref="ProfileExporter"/>, create a child
    /// implementation of <see cref="IExportStrategy"/>, and inject instances of the implementation
    /// into the <see cref="ProfileExporter"/> as needed
    /// </remarks>
    public interface IExportStrategy
    {
        /// <summary>
        /// Exports the specified user profile
        /// </summary>
        /// <param name="userProfile">The user profile to export</param>
        void Export(Profile userProfile);
    }
}
