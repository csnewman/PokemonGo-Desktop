// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ItemCategory.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Enums/ItemCategory.proto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

#pragma warning disable 1591, 0612, 3021

#region Designer generated code

using pb = Google.Protobuf;
using pbc = Google.Protobuf.Collections;
using pbr = Google.Protobuf.Reflection;
using scg = System.Collections.Generic;

namespace POGOProtos.Enums
{
	/// <summary>Holder for reflection information generated from POGOProtos/Enums/ItemCategory.proto</summary>
	public static partial class ItemCategoryReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Enums/ItemCategory.proto</summary>
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
		/// Initializes static members of the <see cref="ItemCategoryReflection"/> class.
		/// </summary>
		static ItemCategoryReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CiNQT0dPUHJvdG9zL0VudW1zL0l0ZW1DYXRlZ29yeS5wcm90bxIQUE9HT1By",
						"b3Rvcy5FbnVtcyrWAgoMSXRlbUNhdGVnb3J5EhYKEklURU1fQ0FURUdPUllf",
						"Tk9ORRAAEhoKFklURU1fQ0FURUdPUllfUE9LRUJBTEwQARIWChJJVEVNX0NB",
						"VEVHT1JZX0ZPT0QQAhIaChZJVEVNX0NBVEVHT1JZX01FRElDSU5FEAMSFwoT",
						"SVRFTV9DQVRFR09SWV9CT09TVBAEEhoKFklURU1fQ0FURUdPUllfVVRJTElU",
						"RVMQBRIYChRJVEVNX0NBVEVHT1JZX0NBTUVSQRAGEhYKEklURU1fQ0FURUdP",
						"UllfRElTSxAHEhsKF0lURU1fQ0FURUdPUllfSU5DVUJBVE9SEAgSGQoVSVRF",
						"TV9DQVRFR09SWV9JTkNFTlNFEAkSGgoWSVRFTV9DQVRFR09SWV9YUF9CT09T",
						"VBAKEiMKH0lURU1fQ0FURUdPUllfSU5WRU5UT1JZX1VQR1JBREUQC2IGcHJv",
						"dG8z"));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new pbr.FileDescriptor[] { },
				new pbr::GeneratedClrTypeInfo(new[] { typeof(global::POGOProtos.Enums.ItemCategory), }, null));
		}

		#endregion
	}

	#region Enums

	/// <summary>
	/// The item category.
	/// </summary>
	public enum ItemCategory
	{
		/// <summary>
		/// The none.
		/// </summary>
		[pbr::OriginalName("ITEM_CATEGORY_NONE")] None = 0,

		/// <summary>
		/// The pokeball.
		/// </summary>
		[pbr::OriginalName("ITEM_CATEGORY_POKEBALL")] Pokeball = 1,

		/// <summary>
		/// The food.
		/// </summary>
		[pbr::OriginalName("ITEM_CATEGORY_FOOD")] Food = 2,

		/// <summary>
		/// The medicine.
		/// </summary>
		[pbr::OriginalName("ITEM_CATEGORY_MEDICINE")] Medicine = 3,

		/// <summary>
		/// The boost.
		/// </summary>
		[pbr::OriginalName("ITEM_CATEGORY_BOOST")] Boost = 4,

		/// <summary>
		/// The utilites.
		/// </summary>
		[pbr::OriginalName("ITEM_CATEGORY_UTILITES")] Utilites = 5,

		/// <summary>
		/// The camera.
		/// </summary>
		[pbr::OriginalName("ITEM_CATEGORY_CAMERA")] Camera = 6,

		/// <summary>
		/// The disk.
		/// </summary>
		[pbr::OriginalName("ITEM_CATEGORY_DISK")] Disk = 7,

		/// <summary>
		/// The incubator.
		/// </summary>
		[pbr::OriginalName("ITEM_CATEGORY_INCUBATOR")] Incubator = 8,

		/// <summary>
		/// The incense.
		/// </summary>
		[pbr::OriginalName("ITEM_CATEGORY_INCENSE")] Incense = 9,

		/// <summary>
		/// The xp boost.
		/// </summary>
		[pbr::OriginalName("ITEM_CATEGORY_XP_BOOST")] XpBoost = 10,

		/// <summary>
		/// The inventory upgrade.
		/// </summary>
		[pbr::OriginalName("ITEM_CATEGORY_INVENTORY_UPGRADE")] InventoryUpgrade = 11,
	}

	#endregion
}

#endregion Designer generated code