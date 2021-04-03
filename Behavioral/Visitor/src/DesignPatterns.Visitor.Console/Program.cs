using System;
using System.Collections.Generic;

namespace DesignPatterns.Visitor.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var items = new List<IVisitableElement>
            {
                new Book(12345, 11.99),
                new Book(78910, 22.79),
                new Vinyl(11198, 17.99),
                new Book(63254, 9.79)
            };

            var discountVisitor = new DiscountVisitor();
            var salesVisitor = new SalesVisitor();

            System.Console.WriteLine("== Discount Visitor ==");
            items.ForEach(x => x.Accept(discountVisitor));
            discountVisitor.Print();

            System.Console.WriteLine("\n== Sales Visitor ==");
            items.ForEach(x => x.Accept(salesVisitor));
            salesVisitor.Print();
        }
    }
}
