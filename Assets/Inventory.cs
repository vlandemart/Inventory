using System;
using System.Collections.Generic;
using UnityEngine;

namespace Vlandemart.Inventory
{
	public class Inventory : MonoBehaviour
	{
		public List<Item> Items = new List<Item>();
		public event Action<Item> OnItemAdded;
		public event Action<Item> OnItemRemoved;
		public int MaxItems = 4;

		protected virtual bool CanAddItem(Item itemToAdd)
		{
			if (Items.Count <= MaxItems)
				return true;
			return false;
		}

		public void AddItem(Item itemToAdd)
		{
			if (CanAddItem(itemToAdd) == false)
			{
				ItemAddFail(itemToAdd);
				return;
			}
			Items.Add(itemToAdd);
			OnItemAdded?.Invoke(itemToAdd);
		}

		protected void ItemAddFail(Item itemToAdd)
		{
			Debug.Log("Can't add " + itemToAdd.Name);
		}

		public void RemoveItem(Item itemToRemove)
		{
			if (Items.Contains(itemToRemove) == false)
			{
				Debug.Log(itemToRemove.Name + " can't be found");
				return;
			}
			Items.Remove(itemToRemove);
			OnItemRemoved?.Invoke(itemToRemove);
		}

		public bool ContainsItem(Item item)
		{
			if (Items.Contains(item))
				return true;
			return false;
		}

		public bool ContainsItem(ItemTypes itemType)
		{
			foreach (var item in Items)
			{
				if (item.ItemType == itemType)
					return true;
			}
			return false;
		}
	}
}
