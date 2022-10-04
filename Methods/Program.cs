using Methods;

Product[] products =
{
    new Product{Id=1, Name="Laptop", Description="Dizüstü Bilgisayar", UnitPrice=10000, UnitsInStock=100},
    new Product{Id=2, Name="Mouse", Description = "Fare", UnitPrice =100, UnitsInStock =1000},
    new Product{Id=3, Name="Keyboard", Description="Klavye", UnitPrice =200, UnitsInStock=500}
};

foreach (var product in products)
{
    Console.WriteLine("Ürün adı : " + product.Name);
    Console.WriteLine("Ürün açıklaması : " + product.Description);
    Console.WriteLine("Ürün fiyatı : " + product.UnitPrice);
    Console.WriteLine("Stok adedi : " + product.UnitsInStock);
    Console.WriteLine("\n");
}

CartManager cartManager = new CartManager();


foreach (var product in products)
{
    cartManager.Add(product);
}
