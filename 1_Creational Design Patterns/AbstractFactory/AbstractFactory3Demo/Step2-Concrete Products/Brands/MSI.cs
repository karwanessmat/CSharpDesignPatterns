﻿using AbstractFactory3Demo.Step1_Abstract_Products;

//Concrete_Products are specific implementations of the abstract products, representing different products to be created.
namespace AbstractFactory3Demo.Step2_Concrete_Products.Brands;

public class Msi:IBrand
{
    public string GetBrand()
    {
        return Enums.Brands.MSI.ToString();
    }
}