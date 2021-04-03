using DesignPatterns.Visitor.Properties;
using System;
using System.Globalization;

namespace DesignPatterns.Visitor
{
    /// <summary>
    /// Visitor that defines the discount that should be applied on element.
    /// </summary>
    public class DiscountVisitor : IVisitor
    {
        private double savings;

        /// <summary>
        /// Visits a <see cref="Book"/>.
        /// </summary>
        /// <param name="book">The <see cref="Book"/> to visit.</param>
        /// <exception cref="ArgumentNullException"><paramref name="book"/> is a null reference.</exception> 
        public void VisitBook(Book book)
        {
            if (book == null) throw new ArgumentNullException(nameof(book));

            double discount = 0;

            if (book.Price < 20)
            {
                discount = book.GetDiscount(0.10);
                Console.WriteLine(String.Format(CultureInfo.CurrentCulture, Resources.Discounted, nameof(Book), book.ID, Math.Round(book.Price - discount, 2)));
            }
            else
            {
                Console.WriteLine(String.Format(CultureInfo.CurrentCulture, Resources.FullPrice, nameof(Book), book.ID, book.Price));
            }
            savings += discount;
        }

        /// <summary>
        /// Visits a <see cref="Book"/>.
        /// </summary>
        /// <param name="book">The <see cref="Book"/> to visit.</param>
        /// <exception cref="ArgumentNullException"><paramref name="vinyl"/> is a null reference.</exception> 
        public void VisitVinyl(Vinyl vinyl)
        {
            if (vinyl == null) throw new ArgumentNullException(nameof(vinyl));

            double discount = vinyl.GetDiscount(0.15);
            Console.WriteLine(String.Format(CultureInfo.CurrentCulture, Resources.Discounted, nameof(Vinyl), vinyl.ID, Math.Round(vinyl.Price - discount, 2)));
            savings += discount;
        }

        /// <summary>
        /// Prints a message.
        /// </summary>
        public void Print()
        {
            Console.WriteLine(String.Format(CultureInfo.CurrentCulture, Resources.TotalSaving, Math.Round(savings, 2)));
        }
    }

}