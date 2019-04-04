using UnityEngine;

namespace Vlandemart.Inventory
{
	public enum ItemTypes { Item, Equipable, Wearable, Consumable };

	public class Item : ScriptableObject
	{
		public string Name = "Title";
		public string Description = "Description";
		public ItemTypes ItemType = ItemTypes.Item;
		public Sprite ItemSprite;
	}
}
