using UnityEngine;

namespace Vlandemart.Inventory
{
	/// <summary>
	/// Equip slots.
	/// 0 - Head, 1 - Body, 2 - Legs, 3 - Weapon1, 4 - Weapon2
	/// </summary>
	public enum ItemEquipSlot { Head, Body, Legs, Weapon1, Weapon2};

	public class ItemEquipable : Item
	{
		public ItemEquipSlot EquipSlot;
		public int Durability;
	}
}