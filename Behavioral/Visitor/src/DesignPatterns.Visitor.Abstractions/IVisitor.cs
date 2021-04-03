using System;

namespace DesignPatterns.Visitor
{
    /// <summary>
    /// Defines a visitor
    /// </summary>
    public interface IVisitor
    {
        /// <summary>
        /// Visits a <see cref="Book"/>.
        /// </summary>
        /// <param name="book">The <see cref="Book"/> to visit.</param>
        /// <exception cref="ArgumentNullException"><paramref name="book"/> is a null reference.</exception> 
        void VisitBook(Book book);

        /// <summary>
        /// Visits a <see cref="Book"/>.
        /// </summary>
        /// <param name="book">The <see cref="Book"/> to visit.</param>
        /// <exception cref="ArgumentNullException"><paramref name="vinyl"/> is a null reference.</exception> 
        void VisitVinyl(Vinyl vinyl);

        /// <summary>
        /// Prints a message.
        /// </summary>
        void Print();
    }
}