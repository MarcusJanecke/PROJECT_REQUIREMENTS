namespace TicketApplicationSystem
{
    /// <summary>
    /// TicketCalculator class handles all ticket price calculations
    /// and applies business rules for discounts.
    /// </summary>
    public class TicketCalculator
    {
        // Category pricing per kilometer
        private const double CATEGORY_ONE_RATE = 20;    // R20 per km
        private const double CATEGORY_TWO_RATE = 35;    // R35 per km
        private const double CATEGORY_THREE_RATE = 50;  // R50 per km

        // Discount percentages
        private const double FEMALE_DISCOUNT = 0.5;     // 50% discount

        /// <summary>
        /// Calculate the final ticket price based on age, gender, category, and distance.
        /// </summary>
        /// <param name="age">Passenger age</param>
        /// <param name="gender">Passenger gender (Male/Female)</param>
        /// <param name="category">Travel category (Category One/Two/Three)</param>
        /// <param name="distance">Travel distance in kilometers</param>
        /// <returns>Final ticket price after applying all rules</returns>
        public double CalculateTicketPrice(int age, string gender, string category, double distance)
        {
            // Rule 1: If age is less than 12, ticket is FREE
            if (age < 12)
            {
                return 0;
            }

            // Calculate base price based on category
            double basePrice = GetCategoryRate(category) * distance;

            // Rule 2: If passenger is Female, apply 50% discount
            if (gender.Equals("Female", System.StringComparison.OrdinalIgnoreCase))
            {
                basePrice = basePrice * (1 - FEMALE_DISCOUNT);
            }

            return basePrice;
        }

        /// <summary>
        /// Get the price rate per kilometer for a given category.
        /// </summary>
        /// <param name="category">Travel category</param>
        /// <returns>Price per kilometer</returns>
        private double GetCategoryRate(string category)
        {
            switch (category)
            {
                case "Category One":
                    return CATEGORY_ONE_RATE;
                case "Category Two":
                    return CATEGORY_TWO_RATE;
                case "Category Three":
                    return CATEGORY_THREE_RATE;
                default:
                    throw new System.ArgumentException("Invalid category selected.");
            }
        }
    }
}
