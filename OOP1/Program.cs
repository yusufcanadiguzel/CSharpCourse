using OOP1;

ProductManager productManager = new ProductManager();

Product product = new Product()
{
    Id = 1,
    CategoryId = 1,
    Name = "Laptop",
    UnitPrice = 10000,
    UnitsInStock = 100
};

productManager.Add(product);
productManager.Update(product);