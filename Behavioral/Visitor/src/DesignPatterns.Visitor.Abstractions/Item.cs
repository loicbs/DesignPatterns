using System;

namespace DesignPatterns.Visitor
{
    public class Item
    {
        /// <summary>
        /// Gets or sets the item's ID.
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Gets or sets the item's price.
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Item"/> class.
        /// </summary>
        /// <param name="id">The item's ID</param>
        /// <param name="price">The item's price</param>
        public Item(int id, double price)
        {
            this.ID = id;
            this.Price = price;
        }

        /// <summary>
        /// Gets the item's discount.
        /// </summary>
        /// <param name="percentage">The discount to apply</param>
        /// <returns>The computed discount.</returns>
        public double GetDiscount(double percentage)
        {
            return Math.Round(Price * percentage, 2);
        }
    }

    /// <summary>
    /// Book information
    /// </summary>
    public class Book: Item, IVisitableElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Book"/> class.
        /// </summary>
        /// <param name="id">The book's ID</param>
        /// <param name="price">The book's price</param>
        public Book(int id, double price) : base(id, price) { }

        /// <summary>
        /// Accepts a <see cref="IVisitor"/>.
        /// </summary>
        /// <param name="book">The <see cref="IVisitor"/> to accept.</param>
        /// <exception cref="ArgumentNullException"><paramref name="visitor"/> is a null reference.</exception> 
        public void Accept(IVisitor visitor)
        {
            if (visitor == null) throw new ArgumentNullException(nameof(visitor));

            visitor.VisitBook(this);
        }
    }

    /// <summary>
    /// Vinyl information
    /// </summary>
    public class Vinyl: Item, IVisitableElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Vinyl"/> class.
        /// </summary>
        /// <param name="id">The vinyl's ID</param>
        /// <param name="price">The vinyl's price</param>
        public Vinyl(int id, double price) : base(id, price) { }

        /// <summary>
        /// Accepts a <see cref="IVisitor"/>.
        /// </summary>
        /// <param name="book">The <see cref="IVisitor"/> to accept.</param>
        /// <exception cref="ArgumentNullException"><paramref name="visitor"/> is a null reference.</exception> 
        public void Accept(IVisitor visitor)
        {
            if (visitor == null) throw new ArgumentNullException(nameof(visitor));

            visitor.VisitVinyl(this);
        }
    }
}
