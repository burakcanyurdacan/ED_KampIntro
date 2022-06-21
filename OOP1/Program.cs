using OOP1;

Product product1 = new Product();
product1.ID = 1;
product1.CategoryId = 2; //Mobilya olarak düşünelim
product1.ProductName = "Masa";
product1.UnitInStock = 6;
product1.UnitPrice = 350;

Product product2 = new Product
{
    ID = 2,
    CategoryId = 3, //Kırtasiye olarak düşünelim
    UnitPrice = 35,
    ProductName = "Kalem",
    UnitInStock = 6
};

ProductManager productManager = new ProductManager();
productManager.Add(product2);

Console.WriteLine(product2.ProductName);