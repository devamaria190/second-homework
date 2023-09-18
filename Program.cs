using System;

class Address
{
    private string index;
    private string country;
    private string city;
    private string street;
    private string house;
    private string apartment;

    public Address(string index, string country, string city, string street, string house, string apartment)
    {
        this.index = index;
        this.country = country;
        this.city = city;
        this.street = street;
        this.house = house;
        this.apartment = apartment;
    }

    public string Index
    {
        get { return index; }
        set { index = value; }
    }

    public string Country
    {
        get { return country; }
        set { country = value; }
    }

    public string City
    {
        get { return city; }
        set { city = value; }
    }

    public string Street
    {
        get { return street; }
        set { street = value; }
    }

    public string House
    {
        get { return house; }
        set { house = value; }
    }

    public string Apartment
    {
        get { return apartment; }
        set { apartment = value; }
    }
}

class Converter
{
    // Поля
    private double usd;
    private double eur;
    private double pln;

    public Converter(double usd, double eur, double pln)
    {
        this.usd = usd;
        this.eur = eur;
        this.pln = pln;
    }

    public double ConvertToUSD(double uah)
    {
        return uah / usd;
    }

    public double ConvertToEUR(double uah)
    {
        return uah / eur;
    }

    public double ConvertToPLN(double uah)
    {
        return uah / pln;
    }

    public double ConvertFromUSD(double usdAmount)
    {
        return usdAmount * usd;
    }

    public double ConvertFromEUR(double eurAmount)
    {
        return eurAmount * eur;
    }

    public double ConvertFromPLN(double plnAmount)
    {
        return plnAmount * pln;
    }
}

class Employee
{
    private string lastName;
    private string firstName;

    public Employee(string lastName, string firstName)
    {
        this.lastName = lastName;
        this.firstName = firstName;
    }

    public double CalculateSalary(string position, int experience)
    {
        double baseSalary = 0;
        switch (position.ToLower())
        {
            case "manager":
                baseSalary = 50000;
                break;
            case "developer":
                baseSalary = 60000;
                break;
            case "designer":
                baseSalary = 55000;
                break;
            default:
                break;
        }

        double salary = baseSalary + (experience * 2000);

        return salary;
    }

    public double CalculateTax(double salary)
    {
        double tax = 0.18 * salary;
        return tax;
    }

    public void DisplayInfo(string position, int experience)
    {
        double salary = CalculateSalary(position, experience);
        double tax = CalculateTax(salary);

        Console.WriteLine("Прізвище: " + lastName);
        Console.WriteLine("Ім'я: " + firstName);
        Console.WriteLine("Посада: " + position);
        Console.WriteLine("Оклад: " + salary);
        Console.WriteLine("Податковий збір: " + tax);
    }
}

class User
{
    private string login;
    private string firstName;
    private string lastName;
    private int age;
    private readonly DateTime registrationDate;

    public User(string login, string firstName, string lastName, int age)
    {
        this.login = login;
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
        registrationDate = DateTime.Now;
    }

    public void DisplayInfo()
    {
        Console.WriteLine("Логін: " + login);
        Console.WriteLine("Ім'я: " + firstName);
        Console.WriteLine("Прізвище: " + lastName);
        Console.WriteLine("Вік: " + age);
        Console.WriteLine("Дата заповнення анкети: " + registrationDate);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Address address = new Address("12345", "Україна", "Київ", "Вулиця", "1", "5");
        Console.WriteLine("Поштова адреса:");
        Console.WriteLine("Індекс: " + address.Index);
        Console.WriteLine("Країна: " + address.Country);
        Console.WriteLine("Місто: " + address.City);
        Console.WriteLine("Вулиця: " + address.Street);
        Console.WriteLine("Будинок: " + address.House);
        Console.WriteLine("Квартира: " + address.Apartment);

        Converter converter = new Converter(27.5, 33.0, 7.0);
        double uahAmount = 1000.0;
        double usdAmount = converter.ConvertToUSD(uahAmount);
        double eurAmount = converter.ConvertToEUR(uahAmount);
        double plnAmount = converter.ConvertToPLN(uahAmount);
        Console.WriteLine("\nКонвертація з UAH:");
        Console.WriteLine("USD: " + usdAmount);
        Console.WriteLine("EUR: " + eurAmount);
        Console.WriteLine("PLN: " + plnAmount);

        Employee employee = new Employee("Іванов", "Петро");
        string position = "developer";
        int experience = 2;
        Console.WriteLine("\nІнформація про співробітника:");
        employee.DisplayInfo(position, experience);

        User user = new User("user123", "Іван", "Петров", 30);
        Console.WriteLine("\nІнформація про користувача:");
        user.DisplayInfo();
    }
}