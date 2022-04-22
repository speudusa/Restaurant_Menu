using System;
namespace Restaurant_Menu
{
    public class MenuItem
    {

        public double Price { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public bool IsNew { get; set; }

        public MenuItem(double price, string description, string category, bool isNew)
        {
            Price = price;
            Description = description;
            Category = category;
            IsNew = isNew;
        }

        public string IsItNew()
        {
            if (IsNew)
            {
                return ("New item!");
            }
            else
            {
                return ("This is not new.");
            }
        }

        public override bool Equals(object comparison)
        {
            if (comparison == this)
            {
                return true;
            }

            if (comparison == null)
            {
                return false;
            }

            if (comparison.GetType() != GetType())
            {
                return false;
            }

            MenuItem theItem = comparison as MenuItem;
            return theItem.Description == Description;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Description);
        }
    }
}
