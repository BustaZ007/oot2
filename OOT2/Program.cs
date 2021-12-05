// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using OOT2.Books;
using OOT2.Calculation;
using OOT2.Delivery;
using OOT2.Promo;

var deliveryCalculator = new DeliveryCalculator();
var promoProvider = new PromoProvider();
var cart = new Cart(deliveryCalculator, promoProvider);
var allBooks = new List<IBook>
{
    new EBook("EBook 1", BookType.ElectronicBook, "Author 1", 1000, 2009, EBookFormat.FB2),
    new EBook("EBook 2", BookType.ElectronicBook, "Author 1", 1000, 2009, EBookFormat.FB2),
    new PaperBook("PBook 1", BookType.PaperBook, "Author 1", 10, 2009),
    new PaperBook("PBook 2", BookType.PaperBook, "Author 2", 10, 2010),
    new EBook("EBook 3", BookType.ElectronicBook, "Author 3", 1000, 2009, EBookFormat.FB2),
};//Все книги имеющиеся в базе

var orderInfo = cart.GetOrderInfo(
    new List<IBook>
    {
        new EBook("EBook 2", BookType.ElectronicBook, "Author 2", 1000, 2009, EBookFormat.FB2),
        new PaperBook("PBook 1", BookType.PaperBook, "Author 1", 10, 2009),
        new PaperBook("PBook 2", BookType.PaperBook, "Author 1", 10, 2010),
        new EBook("EBook 3", BookType.ElectronicBook, "Author 3", 1000, 2009, EBookFormat.FB2),
    }, DeliveryType.Delivery, null, allBooks);
Console.WriteLine(orderInfo.TotalPrice);
orderInfo.Items.ForEach(item => Console.WriteLine(item.Book.Name));