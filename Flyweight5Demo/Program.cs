using Flyweight5Demo._4.Client;

var inventory = new InventoryManagement();

// Adding products to inventory
inventory.AddProduct("12345", 19.99m, 100, "A great product.", "Weight: 1kg, Color: Red", new List<string> { "Awesome product", "Very nice" });
inventory.AddProduct("12346", 29.99m, 150, "A great product.", "Weight: 1kg, Color: Red", new List<string> { "Awesome product", "Very nice" });

// This will share the description and reviews between two products

// Display all products in the inventory
inventory.DisplayInventory();