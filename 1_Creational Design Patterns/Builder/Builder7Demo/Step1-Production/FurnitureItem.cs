namespace Builder7Demo.Step1_Production;
    public class FurnitureItem(
        string productName, 
        double price, 
        double height, 
        double width, 
        double weight)
    {
        public string Name = productName;
        public double Price = price;
        public double Height = height;
        public double Width = width;
        public double Weight = weight;
    }
