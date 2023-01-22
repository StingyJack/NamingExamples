namespace NamingExamples
{
    /// <summary>
    ///     Always have a summary for enums. 
    ///     They are first class types like classes and can be in the namespace
    ///     The enum name should not be plural because the usage of the enum member is singular
    ///     If not using nullable enums, try to have a member value that represents "none" or null
    /// </summary>
    public enum PascalCasedEnumAndValues
    {
        /// <summary>
        ///     Always have at least a summary for non-private types and members. 
        /// </summary>
        Unknown,
        /// <summary>
        ///     Always have at least a summary for non-private types and members. 
        /// </summary>
        FirstValue,
        /// <summary>
        ///     Always have at least a summary for non-private types and members. 
        /// </summary>
        SecondValue
    }
}