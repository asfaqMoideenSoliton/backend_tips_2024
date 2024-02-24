namespace Reflections
{
    /// <summary>
    /// Gets user input from teh user
    /// </summary>
    public interface IUserInputConstroller
    {
        /// <summary>
        /// Gets User input
        /// </summary>
        /// <returns>string name as string</returns>
        public string GetUserName();

        /// <summary>
        /// Gets user id as int
        /// </summary>
        /// <returns>user id as int </returns>
        public int GetUserId();
    }
}
