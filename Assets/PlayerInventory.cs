using UnityEngine;
using System.Collections.Generic;

namespace Vlandemart.Inventory
{
	public class PlayerInventory : Inventory
	{
		/// <summary>
		/// Currently equiped items.
		/// 0 - Head, 1 - Body, 2 - Legs, 3 - Weapon1, 4 - Weapon2
		/// </summary>
		public List<ItemEquipable> EquipedItems = new List<ItemEquipable>(5);

		/// <summary>
		/// Equips the item.
		/// </summary>
		/// <returns><c>true</c>, if item was equiped, <c>false</c> otherwise.</returns>
		/// <param name="itemToEquip">Item to equip.</param>
		public bool EquipItem(ItemEquipable itemToEquip)
		{
			int slotToEquip = (int)itemToEquip.EquipSlot;
			if (slotToEquip < EquipedItems.Count)
				return false;

			if (EquipedItems[slotToEquip] != null)
			{
				if (!UnequipItem(slotToEquip))
					return false;
			}
			EquipedItems[slotToEquip] = itemToEquip;
			RemoveItem(itemToEquip);
			//Do item related stuff - spawn weapon, wear armor, etc.
			return true;
		}

		public bool UnequipItem(int slotToEmpty)
		{
			if (slotToEmpty < EquipedItems.Count)
				return false;

			if (EquipedItems[slotToEmpty] != null)
			{
				AddItem(EquipedItems[slotToEmpty]);
				EquipedItems[slotToEmpty] = null;
				return true;
			}
			return false;
		}
	}
}
