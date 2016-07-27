// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InventoryUpgradeType.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Inventory/InventoryUpgradeType.proto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

#pragma warning disable 1591, 0612, 3021

#region Designer generated code

using pb = Google.Protobuf;
using pbc = Google.Protobuf.Collections;
using pbr = Google.Protobuf.Reflection;
using scg = System.Collections.Generic;

namespace POGOProtos.Inventory
{
	/// <summary>Holder for reflection information generated from POGOProtos/Inventory/InventoryUpgradeType.proto</summary>
	public static partial class InventoryUpgradeTypeReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Inventory/InventoryUpgradeType.proto</summary>
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
		/// Initializes static members of the <see cref="InventoryUpgradeTypeReflection"/> class.
		/// </summary>
		static InventoryUpgradeTypeReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"Ci9QT0dPUHJvdG9zL0ludmVudG9yeS9JbnZlbnRvcnlVcGdyYWRlVHlwZS5w",
						"cm90bxIUUE9HT1Byb3Rvcy5JbnZlbnRvcnkqYgoUSW52ZW50b3J5VXBncmFk",
						"ZVR5cGUSEQoNVVBHUkFERV9VTlNFVBAAEhkKFUlOQ1JFQVNFX0lURU1fU1RP",
						"UkFHRRABEhwKGElOQ1JFQVNFX1BPS0VNT05fU1RPUkFHRRACYgZwcm90bzM="));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new pbr.FileDescriptor[] { },
				new pbr::GeneratedClrTypeInfo(new[] { typeof(global::POGOProtos.Inventory.InventoryUpgradeType), }, null));
		}

		#endregion
	}

	#region Enums

	/// <summary>
	/// The inventory upgrade type.
	/// </summary>
	public enum InventoryUpgradeType
	{
		/// <summary>
		/// The upgrade unset.
		/// </summary>
		[pbr::OriginalName("UPGRADE_UNSET")] UpgradeUnset = 0,

		/// <summary>
		/// The increase item storage.
		/// </summary>
		[pbr::OriginalName("INCREASE_ITEM_STORAGE")] IncreaseItemStorage = 1,

		/// <summary>
		/// The increase pokemon storage.
		/// </summary>
		[pbr::OriginalName("INCREASE_POKEMON_STORAGE")] IncreasePokemonStorage = 2,
	}

	#endregion
}

#endregion Designer generated code