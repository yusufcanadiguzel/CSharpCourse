using ClassIntro;

Person[] people =
{
    new Person{ FirstName = "Yusufcan", LastName ="Adıgüzel", Age = 24},
    new Person{ FirstName ="Adıgüzel", LastName="Yusufcan", Age = 42},
    new Person{ FirstName ="Test", LastName="Test", Age = 0}
};

foreach (Person person in people)
{
    Console.WriteLine(person.FirstName + " " + person.LastName);
}
