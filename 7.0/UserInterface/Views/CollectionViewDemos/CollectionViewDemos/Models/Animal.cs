using CommunityToolkit.Mvvm.ComponentModel;

namespace CollectionViewDemos.Models
{
    public abstract class Animal : ObservableObject
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public string Details { get; set; }
        public string ImageUrl { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }

    public class Bear : Animal
    {

    }
    public class Dog : Animal
    {

    }
    public class Cat : Animal
    {

    }
}
