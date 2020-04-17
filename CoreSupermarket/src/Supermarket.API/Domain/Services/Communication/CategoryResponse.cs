using Supermarket.API.Domain.Models;

namespace Supermarket.API.Domain.Services.Communication
{
    public class CategoryResponse : BaseResponse
    {
        // if request succeeds this will be the saved category
        public Category Category { get; private set; }

// Private constructor that will actually be called be overloaded constructors below
        private CategoryResponse(bool success, string message, Category category) : base(success, message)
        {
            Category = category;
        }

        /// <summary>
        /// Creates a success response.
        /// </summary>
        /// <param name="category">Saved category.</param>
        /// <returns>Response.</returns>
        public CategoryResponse(Category category) : this(true, string.Empty, category)
        { }

        /// <summary>
        /// Creates am error response.
        /// </summary>
        /// <param name="message">Error message.</param>
        /// <returns>Response.</returns>
        public CategoryResponse(string message) : this(false, message, null)
        { }
    }
}