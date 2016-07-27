// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ItemType.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Inventory/Item/ItemType.proto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

#pragma warning disable 1591, 0612, 3021

#region Designer generated code

using pb = Google.Protobuf;
using pbc = Google.Protobuf.Collections;
using pbr = Google.Protobuf.Reflection;
using scg = System.Collections.Generic;

namespace POGOProtos.Inventory.Item
{
	/// <summary>Holder for reflection information generated from POGOProtos/Inventory/Item/ItemType.proto</summary>
	public static partial class ItemTypeReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Inventory/Item/ItemType.proto</summary>
		public static pbr.FileDescriptor Descriptor
		{
			get
			{
				return descriptor;
			}
		}

		/// <summary>
		/// The descriptor.
		/// </summary>
		private static pbr.FileDescriptor descriptor;

		/// <summary>
		/// Initializes static members of the <see cref="ItemTypeReflection"/> class.
		/// </summary>
		static ItemTypeReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CihQT0dPUHJvdG9zL0ludmVudG9yeS9JdGVtL0l0ZW1UeXBlLnByb3RvEhlQ",
						"T0dPUHJvdG9zLkludmVudG9yeS5JdGVtKrICCghJdGVtVHlwZRISCg5JVEVN",
						"X1RZUEVfTk9ORRAAEhYKEklURU1fVFlQRV9QT0tFQkFMTBABEhQKEElURU1f",
						"VFlQRV9QT1RJT04QAhIUChBJVEVNX1RZUEVfUkVWSVZFEAMSEQoNSVRFTV9U",
						"WVBFX01BUBAEEhQKEElURU1fVFlQRV9CQVRUTEUQBRISCg5JVEVNX1RZUEVf",
						"Rk9PRBAGEhQKEElURU1fVFlQRV9DQU1FUkEQBxISCg5JVEVNX1RZUEVfRElT",
						"SxAIEhcKE0lURU1fVFlQRV9JTkNVQkFUT1IQCRIVChFJVEVNX1RZUEVfSU5D",
						"RU5TRRAKEhYKEklURU1fVFlQRV9YUF9CT09TVBALEh8KG0lURU1fVFlQRV9J",
						"TlZFTlRPUllfVVBHUkFERRAMYgZwcm90bzM="));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new pbr.FileDescriptor[] { },
				new pbr::GeneratedClrTypeInfo(new[] { typeof(global::POGOProtos.Inventory.Item.ItemType), }, null));
		}

		#endregion
	}

	#region Enums

	/// <summary>
	/// The item type.
	/// </summary>
	public enum ItemType
	{
		/// <summary>
		/// The none.
		/// </summary>
		[pbr::OriginalName("ITEM_TYPE_NONE")] None = 0,

		/// <summary>
		/// The pokeball.
		/// </summary>
		[pbr::OriginalName("ITEM_TYPE_POKEBALL")] Pokeball = 1,

		/// <summary>
		/// The potion.
		/// </summary>
		[pbr::OriginalName("ITEM_TYPE_POTION")] Potion = 2,

		/// <summary>
		/// The revive.
		/// </summary>
		[pbr::OriginalName("ITEM_TYPE_REVIVE")] Revive = 3,

		/// <summary>
		/// The map.
		/// </summary>
		[pbr::OriginalName("ITEM_TYPE_MAP")] Map = 4,

		/// <summary>
		/// The battle.
		/// </summary>
		[pbr::OriginalName("ITEM_TYPE_BATTLE")] Battle = 5,

		/// <summary>
		/// The food.
		/// </summary>
		[pbr::OriginalName("ITEM_TYPE_FOOD")] Food = 6,

		/// <summary>
		/// The camera.
		/// </summary>
		[pbr::OriginalName("ITEM_TYPE_CAMERA")] Camera = 7,

		/// <summary>
		/// The disk.
		/// </summary>
		[pbr::OriginalName("ITEM_TYPE_DISK")] Disk = 8,

		/// <summary>
		/// The incubator.
		/// </summary>
		[pbr::OriginalName("ITEM_TYPE_INCUBATOR")] Incubator = 9,

		/// <summary>
		/// The incense.
		/// </summary>
		[pbr::OriginalName("ITEM_TYPE_INCENSE")] Incense = 10,

		/// <summary>
		/// The xp boost.
		/// </summary>
		[pbr::OriginalName("ITEM_TYPE_XP_BOOST")] XpBoost = 11,

		/// <summary>
		/// The inventory upgrade.
		/// </summary>
		[pbr::OriginalName("ITEM_TYPE_INVENTORY_UPGRADE")] InventoryUpgrade = 12,
	}

	#endregion
}

#endregion Designer generated code