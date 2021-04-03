using System;

namespace DesignPatterns.Visitor
{
    /// <summary>
    /// Defines a visitor
    /// </summary>
    public interface IVisitableElement
    {
        /// <summary>
        /// Accepts a <see cref="IVisitor"/>.
        /// </summary>
        /// <param name="book">The <see cref="IVisitor"/> to accept.</param>
        /// <exception cref="ArgumentNullException"><paramref name="visitor"/> is a null reference.</exception> 
        void Accept(IVisitor visitor);
    }
}