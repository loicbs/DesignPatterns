using DesignPatterns.Visitor.Properties;
using System;
using System.Globalization;

namespace DesignPatterns.Visitor
{
    /// <summary>
    /// Visitor that counts the number of items sold.
    /// </summary>
    public class SalesVisitor : IVisitor
    {
        private int bookCount;
        private int vinylCount;

        /// <summary>
        /// Visits a <see cref="Book"/>.
        /// </summary>
        /// <param name="book">The <see cref="Book"/> to visit.</param>
        /// <exception cref="ArgumentNullException"><paramref name="book"/> is a null reference.</exception> 
        /// <summary>
        public void VisitBook(Book book)
        {
            if (book == null) throw new ArgumentNullException(nameof(book));

            bookCount++;
        }

        /// Visits a <see cref="Book"/>.
        /// </summary>
        /// <param name="book">The <see cref="Book"/> to visit.</param>
        /// <exception cref="ArgumentNullException"><paramref name="vinyl"/> is a null reference.</exception> 
        public void VisitVinyl(Vinyl vinyl)
        {
            if (vinyl == null) throw new ArgumentNullException(nameof(vinyl));

            vinylCount++;
        }

        /// <summary>
        /// Prints a message.
        /// </summary>
        public void Print()
        {
            Console.WriteLine(String.Format(CultureInfo.CurrentCulture, Resources.TotalItemSales, "Books", bookCount));
            Console.WriteLine(String.Format(CultureInfo.CurrentCulture, Resources.TotalItemSales, "Vinyls", vinylCount));
        }
    }
}