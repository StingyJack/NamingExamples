// Namespaces are PascalCased. 
namespace NamingExamples
{
    using System; // using statements belong inside the namespace

    /// <summary>
    ///     Always have at least a summary for non-private types and members. 
    ///     Classes and Structs are pascal cased regardless of the access modifier.
    ///     The only things that dont have a blank line separating them are private fields
    /// </summary>
    public class ClassesAreAlwaysPascalCased
    {
        #region "use regions sparingly"

        /// <summary>
        ///     Always have at least a summary for non-private types and members. 
        /// </summary>
        public const string CONSTANTS_CAN_BE_ALL_UPPER_UNDERSCORED = "SomeConstant";

        /// <summary>
        ///     Always have at least a summary for non-private types and members. 
        /// </summary>
        public const string ConstantsCanBePascalCasedAlso = "OtherConstant";

        private readonly string _fieldsShouldBeUnderscoreCamelCased;
        private readonly string _initializeFieldsInTheCtorWhenPossible;

        /// <summary>
        ///     Always have at least a summary for non-private types and members. 
        ///     Use AutoProperty or expression body format  ( => )
        ///     Consider set a default for reference types that commonly cause null ref ex
        /// </summary>
        public List<int> PropertiesArePascalCased { get; set; } = new();

        #endregion //#region "use regions sparingly"

        /// <summary>
        ///     Always check inputs for null values. 
        /// </summary>
        /// <param name="fieldsShouldBeUnderscoreCamelCased"></param>
        /// <param name="initializeFieldsInTheCtorWhenPossible"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public ClassesAreAlwaysPascalCased(string fieldsShouldBeUnderscoreCamelCased, string initializeFieldsInTheCtorWhenPossible)
        {
            //if you have resharper you can use the live templates to generate both of these statements with 6 keystrokes or less
            _fieldsShouldBeUnderscoreCamelCased = fieldsShouldBeUnderscoreCamelCased
                ?? throw new ArgumentNullException(nameof(fieldsShouldBeUnderscoreCamelCased));

            _initializeFieldsInTheCtorWhenPossible = initializeFieldsInTheCtorWhenPossible.NullIfWhiteSpace()  //useful extension method
                ?? throw new ArgumentNullException(nameof(initializeFieldsInTheCtorWhenPossible));
        }

        /// <summary>
        ///     Name methods directly and clearly, using proper English phrasing construction. 
        /// </summary>
        /// <returns></returns>
        internal string SmashTogetherThisClassesMembers()
        {
            return $"{CONSTANTS_CAN_BE_ALL_UPPER_UNDERSCORED}{_fieldsShouldBeUnderscoreCamelCased}{ConstantsCanBePascalCasedAlso}" +
                $"_{_initializeFieldsInTheCtorWhenPossible}_{PropertiesArePascalCased.Count}";
        }

        /// <summary>
        ///     Boolean functions and properties should always begin with a form of the word "be" - Am, is, are, was, were, has, have had, do, does, did, etc.
        /// </summary>
        /// <returns></returns>
        public bool IsConstructorInputValueTooLong()
        {
            var returnValue = _fieldsShouldBeUnderscoreCamelCased.Length > 20 ? true : false;
            return returnValue;
        }

    }
}