using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace WindowsFormsApp1
{
    public class Food
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Picture { get; set; }
        public double Price { get; set; }

        public Food()
        {
            Name = "";
            Description = "";
            Picture = "";
            Price = 0.0;
        }

        public Food(string name, string description, string picture, double price)
        {
            this.Name = name;
            this.Description = description;
            this.Picture = picture;
            this.Price = price;
        }
    }

    internal class Food_Options
    {
        public static List<Food> Breakfast = new List<Food>();
        public static List<Food> Lunch = new List<Food>();
        public static List<Food> Supper = new List<Food>();

        static Food_Options()
        {
            // Breakfast Items
            Food b1 = new Food();
            b1.Name = "Coffee";
            b1.Description = "A hot beverage made from roasted coffee beans.";
            b1.Picture = "images\\symbols\\food\\coffee.jpg";
            b1.Price = 2.40;
            Breakfast.Add(b1);

            Food b2 = new Food();
            b2.Name = "Juice";
            b2.Description = "A refreshing drink made from fresh oranges.";
            b2.Picture = "images\\symbols\\food\\juice.jpg";
            b2.Price = 2.50;
            Breakfast.Add(b2);

            Food b3 = new Food();
            b3.Name = "Milk";
            b3.Description = "A nutritious drink rich in calcium. Produced by local catle";
            b3.Picture = "images\\symbols\\food\\milk.jpg";
            b3.Price = 1.50;
            Breakfast.Add(b3);

            Food b4 = new Food();
            b4.Name = "Cheese Pie";
            b4.Description = "A savory pie filled with cheese.";
            b4.Picture = "images\\symbols\\food\\cheesepie.jpg";
            b4.Price = 2.00;
            Breakfast.Add(b4);

            Food b5 = new Food();
            b5.Name = "Croissant";
            b5.Description = "A flaky, buttery pastry.";
            b5.Picture = "images\\symbols\\food\\croissant.jpg";
            b5.Price = 2.20;
            Breakfast.Add(b5);

            Food b6 = new Food();
            b6.Name = "Full Breakfast Plate";
            b6.Description = "A hearty breakfast with eggs, bacon and french toast.";
            b6.Picture = "images\\symbols\\food\\fullbreakfast.jpg";
            b6.Price = 10.00;
            Breakfast.Add(b6);

            Food b7 = new Food();
            b7.Name = "Yogurt";
            b7.Description = "A creamy dairy product, mixed with honey and fresh local berries.";
            b7.Picture = "images\\symbols\\food\\yogurt.jpg";
            b7.Price = 8.00;
            Breakfast.Add(b7);


            // Lunch Items
            Food l1 = new Food();
            l1.Name = "Grilled Chicken Sandwich";
            l1.Description = "A delicious sandwich with grilled chicken, lettuce, and tomato.";
            l1.Picture = "images\\symbols\\food\\grilledchicken.jpg";
            l1.Price = 7.50;
            Lunch.Add(l1);
            
            Food l2 = new Food();
            l2.Name = "Caesar Salad";
            l2.Description = "A fresh salad with romaine lettuce, cherry tomatoes, croutons, chicken, parmesan cheese, and Caesar dressing.";
            l2.Picture = "images\\symbols\\food\\caesarsalad.jpg";
            l2.Price = 6.00;
            Lunch.Add(l2);            

            Food l4 = new Food();
            l4.Name = "Pasta Primavera";
            l4.Description = "An Italian-American dish that consists of pasta in a cream sauce and fresh vegetables.";
            l4.Picture = "images\\symbols\\food\\pastaprimavera.jpg";
            l4.Price = 8.00;
            Lunch.Add(l4);

            Food l5 = new Food();
            l5.Name = "Pasta Carbonara";
            l5.Description = "Pasta made with egg, hard cheese, pancetta, and pepper.";
            l5.Picture = "images\\symbols\\food\\pastacarbonara.jpg";
            l5.Price = 9.00;
            Lunch.Add(l5);

            Food l6 = new Food();
            l6.Name = "Grilled Fish";
            l6.Description = "Trout from the local river, caught the same day, grilled to perfection and served with lemon and herbs.";
            l6.Picture = "images\\symbols\\food\\grilledfish.jpg";
            l6.Price = 12.00;
            Lunch.Add(l6);

            Food l7 = new Food();
            l7.Name = "Beef Sausage";
            l7.Description = "Locally made sausage made of beef, smoked and served with mustard and sauerkraut.";
            l7.Picture = "images\\symbols\\food\\beefsausage.jpg";
            l7.Price = 10.00;
            Lunch.Add(l7);

            Food l8 = new Food();
            l8.Name = "Lamb Ribs";
            l8.Description = "Tender lamb ribs marinated in herbs and grilled over an open flame.";
            l8.Picture = "images\\symbols\\food\\lambribs.jpg";
            l8.Price = 14.00;
            Lunch.Add(l8);

            Food l9 = new Food();
            l9.Name = "Beef Steak";
            l9.Description = "Juicy beef steak cooked to your liking, served with a side of fries.";
            l9.Picture = "images\\symbols\\food\\beefstake.jpg";
            l9.Price = 15.00;
            Lunch.Add(l9);
            
            Food l10 = new Food();
            l10.Name = "Vegetable Stir Fry";
            l10.Description = "A colorful mix of fresh vegetables stir-fried in a savory sauce, served with steamed rice.";
            l10.Picture = "images\\symbols\\food\\vegetablestirfry.jpg";
            l10.Price = 9.00;
            Lunch.Add(l10);


            // Supper Items
            Food s1 = new Food();
            s1.Name = "Tomato Soup";
            s1.Description = "A warm and comforting tomato soup served with bread.";
            s1.Picture = "images\\symbols\\food\\tomatosoup.jpg";
            s1.Price = 4.00;
            Supper.Add(s1);

            Food s2 = new Food();
            s2.Name = "Veggie Wrap";
            s2.Description = "A healthy wrap filled with fresh vegetables and hummus.";
            s2.Picture = "images\\symbols\\food\\veggiewrap.jpg";
            s2.Price = 5.50;
            Lunch.Add(s2);

            Food s3 = new Food();
            s3.Name = "Fruit Salad";
            s3.Description = "A refreshing mix of seasonal fruits.";
            s3.Picture = "images\\symbols\\food\\fruitsalad.jpg";
            s3.Price = 4.50;
            Supper.Add(s3);

            Food s4 = new Food();
            s4.Name = "Cheese and Crackers";
            s4.Description = "A selection of cheeses served with assorted crackers.";
            s4.Picture = "images\\symbols\\food\\cheesecrackers.jpg";
            s4.Price = 7.00;
            Supper.Add(s4);

            Food s5 = new Food();
            s5.Name = "Red Wine";
            s5.Description = "A glass of fine red wine to complement your meal.";
            s5.Picture = "images\\symbols\\food\\redwine.jpg";
            s5.Price = 7.00;
            Supper.Add(s5);

            Food s6 = new Food();
            s6.Name = "White Wine";
            s6.Description = "A glass of crisp white wine to accompany your food.";
            s6.Picture = "images\\symbols\\food\\whitewine.jpg";
            s6.Price = 7.00;
            Supper.Add(s6);
            
            Food s7 = new Food();
            s7.Name = "Herbal Tea";
            s7.Description = "A soothing cup of herbal tea made from a blend of natural herbs.";
            s7.Picture = "images\\symbols\\food\\herbaltea.jpg";
            s7.Price = 3.00;
            Supper.Add(s7);

        }
    }

    public class Cart
    {
        public Food item { get; set; }
        public int quantity { get; set; }

        public Cart()
        {
            item = new Food();
            quantity = 0;
        }
        public Cart(Food item, int amount)
        {
            this.item = item;
            this.quantity = amount;
        }
    }
}
