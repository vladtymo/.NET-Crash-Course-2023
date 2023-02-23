using System;
using ProductClass;
using EmployeeClass;
using FactoryClass;

public class Task
{



    public static void Main(string[] args)
    {
        string name_p_1 = "product_1";
        DateTime ManufactureDate_p_1 = new DateTime(2022, 12, 3);
        CategoryType category_p_1 = CategoryType.type_1;
        decimal price_p_1 = 2323;
        Product product_1 = new Product(name_p_1, ManufactureDate_p_1, category_p_1, price_p_1);

        string name_p_2 = "product_2";
        DateTime ManufactureDate_p_2 = new DateTime(2021, 3, 12);
        CategoryType category_p_2 = CategoryType.type_2;
        decimal price_p_2 = 54456;
        Product product_2 = new Product(name_p_2, ManufactureDate_p_2, category_p_2, price_p_2);

        string name_p_3 = "product_3";
        DateTime ManufactureDate_p_3 = new DateTime(2023, 2, 14);
        CategoryType category_p_3 = CategoryType.type_3;
        decimal price_p_3 = 432;
        Product product_3 = new Product(name_p_3, ManufactureDate_p_3, category_p_3, price_p_3);


        Product[] products = { product_1, product_2, product_3 };

        string name_e_1 = "employee_1";
        string sname_e_1 = "surname1";
        DateTime BirthDate1 = new DateTime(1994, 10, 23);
        decimal salary1 = 232323;

        Employee employee1 = new Employee(name_e_1, sname_e_1, BirthDate1, salary1);


        string name_e_2 = "employee_2";
        string sname_e_2 = "surname2";
        DateTime BirthDate2 = new DateTime(1985, 6, 8);
        decimal salary2 = 65434;

        Employee employee2 = new Employee(name_e_2, sname_e_2, BirthDate2, salary2);

        string name_e_3 = "employee_3";
        string sname_e_3 = "surname3";
        DateTime BirthDate3 = new DateTime(2000, 2, 28);
        decimal salary3 = 254435;

        Employee employee3 = new Employee(name_e_3, sname_e_3, BirthDate3, salary3);


        Employee[] employees = { employee1, employee2, employee3 };

        Factory factory = new Factory("factory",ref products, ref employees);



    }
}



