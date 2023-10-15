using EFCoreLinqSorgulari.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System.Diagnostics.Metrics;
using System.Text.RegularExpressions;

namespace EFCoreLinqSorgulari
{
    internal class Program
    {
        static void Main(string[] args)
        {
           NorthwindContext context = new NorthwindContext();
            //1- SELECT CategoryName, Description FROM Categories ORDER BY Categories ASC
            //var result = context.Categories.Select(c => new
            //{
            //    c.CategoryName,c.Description
            //}).OrderBy(a=>a.CategoryName);

            //3 - SELECT FirstName,LastName,HireDate FROM Employees ORDER BY HireDate DESC
            //var result=context.Employees.Select(e=> new Employee
            //{
            //    FirstName=e.FirstName,
            //    LastName=e.LastName,
            //    HireDate=e.HireDate
            //}).OrderByDescending(e=>e.HireDate);

            //5 - SELECT CompanyName, Fax, Phone, HomePage, Country FROM Suppliers ORDER BY Country DESC, CompanyName ASC
            //var result = context.Suppliers.Select(s => new Supplier
            //{
            //    CompanyName = s.CompanyName,
            //    Fax = s.Fax,
            //    Phone = s.Phone,
            //    HomePage = s.HomePage,
            //    Country = s.Country
            //}).OrderByDescending(s => s.Country).ThenBy(s => s.CompanyName);

            //6 - SELECT CompanyName, ContactName FROM Customers WHERE City = 'Buenos Aires'
            //var result = context.Customers.Where(c => c.City == "Buenos Aires").Select(c => new Customer
            //{
            //    CompanyName = c.CompanyName,
            //    ContactName = c.ContactName
            //}).ToList();

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.CompanyName + " - " + item.ContactName);
            //}

            //8 - SELECT OrderDate, ShippedDate, CustomerID, Freight FROM Orders WHERE OrderDate = 'May 19, 1997'
            //var result = context.Orders.Where(o => o.OrderDate == DateTime.Parse("1997-05-19")).Select(o=> new Order
            //{
            //    OrderDate = o.OrderDate,
            //    Freight = o.Freight,
            //    ShippedDate= o.ShippedDate,
            //    CustomerId=o.CustomerId
            //});

            //11 - SELECT City, CompanyName, ContactName FROM Customers WHERE City LIKE 'A%' OR City LIKE 'B%'
            //var result = context.Customers.Where(c => c.City.StartsWith("A") || c.City.StartsWith("B")).Select(c => new Customer
            //{
            //    City = c.City,
            //    CompanyName = c.CompanyName,
            //    ContactName = c.ContactName
            //});

            //14 - SELECT CompanyName, ContactName, Fax FROM Customers WHERE 'Fax' IS NOT NULL
            //var result = context.Customers.Where(c => c.Fax != null).Select(c=> new Customer
            //{
            //    CompanyName = c.CompanyName,
            //    Fax=c.Fax,
            //    ContactName=c.ContactName
            //});

            //18 - SELECT FirstName, LastName, BirthDate FROM Employees WHERE BirthDate BETWEEN '1950-01-01' AND '1959-12-31'
            //var result = context.Employees.Where(e => e.BirthDate.Value.Year >= 1950 && e.BirthDate.Value.Year < 1960).Select(e => new Employee
            //{
            //    FirstName = e.FirstName,
            //    LastName = e.LastName,
            //    BirthDate = e.BirthDate
            //});
            //VEYAA 2.SEÇENEK OLARAK >>>>>>  18.soru için!!!
            //SELECT FirstName,LastName,BirthDate From Employees WHERE between ('1949') and ('1959')
            //var select = context.Employees.Where(e => e.BirthDate.Value.Year > 1949 && e.BirthDate.Value.Year > 1960).Select(e => new Employee
            //{
            //    FirstName = e.FirstName,
            //    LastName = e.LastName,
            //    BirthDate = e.BirthDate
            //});

            //21 - SELECT ContactName, ContactTitle, CompanyName FROM Customers where ContactTitle NOT LIKE '%Sales%'
            //var result = context.Customers.Where(c => !c.ContactTitle.Contains("Sales"));

            //23 - SELECT CompanyName, ContactTitle, City, Country FROM Customers WHERE (Country ='Mexico' OR Country='Spain') AND City<>'Madrid'
            //var result = context.Customers.Where(c => (c.Country == "Mexico" || c.Country == "Spain") && c.City != "Madrid");

            //24 - SELECT FirstName +' ' + LastName + ' can be reached at x ' + Extension + '.' AS ContactInfo FROM Employees
            //var result = context.Employees.Select(e => new 
            //{
            //    ContactInfo=e.FirstName + " " + e.LastName + "can be reached at x " + e.Extension + "."
            //});

            //34 - SELECT p.ProductName, SUM(od.Quantity) as TotalUnits FROM[Order Details] od JOIN Products p ON od.ProductID = p.ProductID GROUP BY p.ProductName HAVING SUM(od.Quantity) < 200
            //var result = context.Products.Select(p => new
            //{
            //    ProductName = p.ProductName,
            //    TotalUnits = p.OrderDetails.Sum(od => od.Quantity)
            //}).Where(a=>a.TotalUnits<200);


            //Categories tablosuna kullanıcıcdan aldıgımız bilgilerle 1 adet kayıt ekleyelim
            //Category category = new Category();
            //Console.WriteLine("Kategori adı giriniz: ");
            //category.CategoryName = Console.ReadLine();
            //Console.WriteLine("Kategori açıklama giriniz: ");
            //category.Description = Console.ReadLine();

            //context.Categories.Add(category);
            //context.SaveChanges();

            //id si 2 olan kategorinin ismini değistir
            //Category category = context.Categories.Where(c=>c.CategoryId==2).First();
            //Category category = context.Categories.Find(2);
            //Category category=context.Categories.FirstOrDefault(c=>c.CategoryId==2);
            //var category=context.Categories.FirstOrDefault(c=>c.CategoryId==2);

            //category.CategoryName = "Yemekler";
            //context.Categories.Update(category);
            //context.SaveChanges();

            //SINIFTA YAPTIĞIMIZ DATABASE SORULARI: 1,3,5,6,8,11,14,18,21,23,24,34



            //ÖDEEEVVV!!!!!!!
            //2 - SELECT ContactName, CompanyName, ContactTitle, Phone FROM Customers ORDER BY Phone
            //var result = context.Customers.Select(c => new
            //{
            //    c.ContactName,c.CompanyName,c.ContactTitle,c.Phone
            //}).OrderBy(a=>a.Phone);

            //4 - SELECT OrderID, OrderDate, ShippedDate, CustomerID, Freight FROM Orders ORDER BY Freight DESC
            //var result = context.Orders.Select(o => new Order
            //{
            //    OrderId= o.OrderId,
            //    OrderDate=o.OrderDate,
            //    ShippedDate=o.ShippedDate,
            //    CustomerId=o.CustomerId,
            //    Freight=o.Freight
            //}).OrderByDescending(o=>o.Freight);

            //7 - SELECT ProductName, UnitPrice, QuantityPerUnit, UnitsInStock FROM Products WHERE UnitsInStock = 0
            //var result = context.Products.Where(p => p.UnitsInStock == 0).Select(p=> new Product
            //{
            //    ProductName = p.ProductName,
            //    UnitPrice = p.UnitPrice,
            //    QuantityPerUnit = p.QuantityPerUnit,
            //    UnitsInStock = p.UnitsInStock
            //});

            //9 - SELECT FirstName, LastName, Country FROM Employees WHERE Country<> 'USA'
            //var result = context.Employees.Where(e => !e.Country.Contains("USA")).Select(e=> new Employee
            //{
            //    FirstName = e.FirstName,
            //    LastName = e.LastName,
            //    Country = e.Country
            //});

            //10 - SELECT EmployeeID, OrderID, CustomerID, RequiredDate, ShippedDate FROM Orders WHERE ShippedDate > RequiredDate
            //var result = context.Orders.Where(o => o.ShippedDate > o.RequiredDate).Select(o => new Order
            //{
            //    EmployeeId = o.EmployeeId,
            //    OrderId = o.OrderId,
            //    CustomerId = o.CustomerId,
            //    RequiredDate = o.RequiredDate,
            //    ShippedDate = o.ShippedDate
            //});

            //12 - SELECT* FROM Orders WHERE Freight > 500.00
            //var result = context.Orders.Where(o => o.Freight > 500);

            //13 - SELECT ProductName, UnitsInStock, UnitsOnOrder, ReorderLevel FROM Products WHERE UnitsInStock +UnitsOnOrder <= ReorderLevel
            //var result = context.Products.Where(p => p.UnitsInStock + p.UnitsOnOrder <= p.ReorderLevel).Select(p => new Product
            //{
            //    ProductName = p.ProductName,
            //    UnitsInStock = p.UnitsInStock,
            //    UnitsOnOrder = p.UnitsOnOrder,
            //    ReorderLevel = p.ReorderLevel
            //});

            //15 - SELECT FirstName, LastName FROM Employees WHERE ReportsTo IS NULL
            //var result = context.Employees.Where(e => e.ReportsTo==null).Select(e=> new Employee
            //{
            //    FirstName = e.FirstName,
            //    LastName = e.LastName
            //});

            //16 - SELECT CompanyName, ContactName, Fax FROM Customers WHERE 'Fax' IS NOT NULL ORDER BY CompanyName DESC
            //var result = context.Customers.Where(c => c.Fax != null).Select(c => new Customer
            //{
            //    CompanyName = c.CompanyName,
            //    ContactName = c.ContactName,
            //    Fax = c.Fax
            //}).OrderByDescending(c => c.CompanyName);

            //17 - SELECT City, CompanyName, ContactName FROM Customers WHERE City LIKE 'A%' OR City LIKE 'B%' ORDER BY ContactName DESC
            //var result = context.Customers.Where(c => c.City.StartsWith("A") || c.City.StartsWith("B")).Select(c=>new Customer
            //{
            //    City = c.City,
            //    CompanyName = c.CompanyName,
            //    ContactName = c.ContactName
            //}).OrderByDescending(c => c.ContactName);

            //19 - SELECT * FROM Products WHERE SupplierID IN(SELECT SupplierID FROM Suppliers WHERE CompanyName IN('Tokyo Traders','Exotic Liquids'))
            //var result = context.Products.Where(p => p.Supplier.CompanyName == "Tokyo Traders" || p.Supplier.CompanyName == "Exotic Liquids").Select(p => new Product
            //{
            //    ProductName=p.ProductName,
            //    SupplierId=p.SupplierId
            //});

            //20 - SELECT ShipPostalCode, OrderID, OrderDate FROM Orders WHERE ShipPostalCode LIKE '02389%'
            //var result = context.Orders.Where(o => o.ShipPostalCode.StartsWith("02389")).Select(o=>new Order
            //{
            //    ShipPostalCode = o.ShipPostalCode,
            //    OrderId = o.OrderId,
            //    OrderDate = o.OrderDate
            //});

            //22 - SELECT FirstName, LastName, City, Region FROM Employees WHERE City != 'Seattle'
            //var result = context.Employees.Where(c => c.City != "Seattle").Select(e=>new Employee
            //{
            //    FirstName = e.FirstName,
            //    LastName = e.LastName,
            //    City = e.City,
            //    Region = e.Region
            //});

            //25 - SELECT UnitsInStock, UnitPrice, UnitsInStock *UnitPrice AS TotalPrice, FLOOR(UnitsInStock * UnitPrice) AS TotalPriceRoundedDown, CEILING(UnitsInStock * UnitPrice) AS TotalPriceRoundedUp FROM Products ORDER BY TotalPrice DESC
            //var result = context.Products.Select(p=> new
            //{
            //    TotalPrice=p.UnitPrice*p.UnitsInStock,
            //    TotalPriceRoundedDown=Math.Floor(p.UnitPrice * p.UnitsInStock),
            //    TotalPriceRoundedUp=Math.Ceiling(p.UnitPrice * p.UnitsInStock)
            //});


            //26 - SELECT YEAR(HireDate) -YEAR(BirthDate) as HireAgeInAccurate, DATEDIFF(WEEKDAY, BirthDate, HireDate) / 365.0 as HireAgeAccurate FROM Employees
            //var result = context.Employees.Select(e => new
            //{
            //    HireAgeInAccurate = e.HireDate.Value.Year - e.BirthDate.Value.Year,
            //    HireAgeAccurate= ((e.HireDate.Value - e.BirthDate.Value).TotalDays)/365.0
            //});


            //27 - SELECT FirstName, LastName, DATENAME(MONTH, BirthDate) FROM Employees WHERE MONTH(Birthdate)= MONTH(GETDATE())
            //var result = context.Employees.Where(e => e.BirthDate.Value.Month == DateTime.Now.Month).Select(e => new
            //{
            //    e.FirstName,
            //    e.LastName,
            //    BirthDate = e.BirthDate.Value.ToString("MMMM")
            //});


            //28 - SELECT LOWER(ContactTitle) AS LowerCaseContactTitle FROM Customers
            //var result = context.Customers.Select(c => c.ContactTitle.ToLower()).ToList();

            //30 - SELECT ProductName FROM Products WHERE CategoryID IN(SELECT CategoryID FROM Categories WHERE CategoryName = 'Seafood')


            //var result = context.Products.Where(p => p.CategoryName == "Seafood").Select(p => new
            //{
            //    p.ProductName,
            //    p.Category.CategoryName
            //});


            //31 - SELECT CompanyName FROM Suppliers WHERE SupplierID IN(SELECT SupplierID FROM Products WHERE CategoryID = 8)
            //var result = context.Suppliers.Where(s => s.Products.Any(p => p.CategoryId == 8 && p.SupplierId == s.SupplierId)).Select(s => s.CompanyName).ToList(); //BU ŞEKİLDE DAHA UZUN OLUYOR!!!

            //var result = context.Products.Where(p => p.CategoryId == 8).Select(p => new
            //{
            //    p.Supplier.CompanyName
            //}).Distinct();

            //32 - SELECT CompanyName FROM Suppliers WHERE SupplierID IN(SELECT SupplierID FROM Products WHERE CategoryID = (SELECT CategoryID FrOM Categories Where CategoryName = 'Seafood'))
            //var result=context.Suppliers.Where(s=>s.Products.Any(p=>p.CategoryId==8 && p.SupplierId == s.SupplierId)).Select(s=>s.CompanyName).ToList(); ???????

            //var result =context.Products.Where(p=>p.)

            //33 - SELECT o.OrderID siparisNo, e.FirstName,e.LastName FROM Orders as o JOIN Employees e ON o.EmployeeID = e.EmployeeID WHERE o.ShippedDate > o.RequiredDate
            //var result = context.Orders.Where(o => o.ShippedDate > o.RequiredDate).Select(o => new
            //{
            //    siparisNo=o.OrderId,
            //    o.Employee.FirstName,
            //    o.Employee.LastName
            //})

            //35 - SELECT c.CompanyName, COUNT(o.CustomerID) FROM Customers c JOIN Orders o ON c.CustomerID = o.CustomerID WHERE OrderDate>= '1996-12-31' GROUP BY c.CompanyName HAVING COUNT(o.CustomerID) > 15

            //var result = context.Customers.GroupJoin(context.Orders.Where(o => o.OrderDate >= DateTime.Parse("1996-12-31")), c => c.CustomerId, o => o.CustomerId, (customer, orders) => new
            //{
            //    OrderCount = orders.Count(),
            //    CompanyName = customer.CompanyName
            //}).Where(x => x.OrderCount > 15);

            //36 - SELECT c.CompanyName, o.OrderID, SUM(od.UnitPrice * od.Quantity) AS TotalPrice FROM Customers c JOIN Orders o ON o.CustomerID = c.CustomerID JOIN[Order Details] od ON o.OrderID = od.OrderID GROUP BY c.CompanyName,o.OrderID HAVING  SUM(od.UnitPrice * od.Quantity) > 10000
            //var result = context.Orders.Select(o => new
            //{
            //    companyName = o.Customer.CompanyName,
            //    totalprice = o.OrderDetails.Sum(od => (od.Quantity * od.UnitPrice)),
            //    o.OrderId
            //}).Where(o => o.totalprice > 10000);

        }
    }
}