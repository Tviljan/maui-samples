using CollectionViewDemos.Models;

namespace CollectionViewDemos;

public class AnimalDataTemplateSelector : DataTemplateSelector
{
    public DataTemplate BearTemplate { get; set; }
    public DataTemplate DogTemplate { get; set; }
    public DataTemplate CatTemplate { get; set; }

    protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
    {
        return item switch
        {
            Bear _ => BearTemplate,
            Dog _ => DogTemplate,
            Cat _ => CatTemplate,
            _ => throw new InvalidOperationException( $"Unknown card type  {item}"),
        };
    }
}