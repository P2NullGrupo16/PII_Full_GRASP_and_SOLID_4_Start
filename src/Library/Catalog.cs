using System;
using System.Collections.Generic;
using System.Linq;
/// Trabajamos sobre la misma branch mediante Live Share todos los integrantes del grupo.
namespace Full_GRASP_And_SOLID
{
    public class Catalog 
    {

        public  List<Product> productCatalog = new List<Product>();

        public List<Equipment> equipmentCatalog = new List<Equipment>();
            
    

        public  Product AddProductToCatalog(string description, double unitCost)
        {
            Product product = new Product(description, unitCost);
            productCatalog.Add(product);
            return product;
        }

        public Equipment AddEquipmentToCatalog(string description, double hourlyCost)
        {
            Equipment equipment = new Equipment(description, hourlyCost);
            equipmentCatalog.Add(equipment);
            return equipment;
        }

        public Product ProductAt(int index)
        {
            return productCatalog[index] as Product;
        }

        public Equipment EquipmentAt(int index)
        {
            return equipmentCatalog[index] as Equipment;
        }

        public Product GetProduct(string description)
        {
            var query = from Product product in productCatalog where product.Description == description select product;
            return query.FirstOrDefault();
        }

        public  Equipment GetEquipment(string description)
        {
            var query = from Equipment equipment in equipmentCatalog where equipment.Description == description select equipment;
            return query.FirstOrDefault();
        }

        public void PopulateCatalogs()
        {
            AddProductToCatalog("Café", 100);
            AddProductToCatalog("Leche", 200);
            AddProductToCatalog("Café con leche", 300);

            AddEquipmentToCatalog("Cafetera", 1000);
            AddEquipmentToCatalog("Hervidor", 2000);
        }
    }    
} 