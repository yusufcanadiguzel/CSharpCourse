using OOP2;

Customer corporateCustomer = new CorporateCustomer()
{
    Id = 1,
    CompanyName = "Test Co.",
    CustomerNumber = "12345",
    TaxNumber = "1234567890"
};

Customer individualCustomer = new IndividualCustomer()
{
    Id = 1,
    FirstName = "Yusufcan",
    LastName = "Adıgüzel",
    IdentityNumber = "12345678901",
    CustomerNumber = "54321",
};

CustomerManager customerManager = new CustomerManager();
customerManager.Add(individualCustomer);
customerManager.Add(corporateCustomer);