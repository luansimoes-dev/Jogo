using System.Collections.ObjectModel;

namespace RPG.Data;

public sealed class Inventory
{
    private readonly List<Item> items = new();

    public IReadOnlyList<Item> Items => new ReadOnlyCollection<Item>(items);

    public void Add(Item item) => items.Add(item);

    public void Remove(Item item) => items.Remove(item);

    public void Clear() => items.Clear();
}
