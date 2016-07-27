// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ItemId.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Inventory/Item/ItemId.proto
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
	/// <summary>Holder for reflection information generated from POGOProtos/Inventory/Item/ItemId.proto</summary>
	public static partial class ItemIdReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Inventory/Item/ItemId.proto</summary>
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
		/// Initializes static members of the <see cref="ItemIdReflection"/> class.
		/// </summary>
		static ItemIdReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CiZQT0dPUHJvdG9zL0ludmVudG9yeS9JdGVtL0l0ZW1JZC5wcm90bxIZUE9H",
						"T1Byb3Rvcy5JbnZlbnRvcnkuSXRlbSrHBQoGSXRlbUlkEhAKDElURU1fVU5L",
						"Tk9XThAAEhIKDklURU1fUE9LRV9CQUxMEAESEwoPSVRFTV9HUkVBVF9CQUxM",
						"EAISEwoPSVRFTV9VTFRSQV9CQUxMEAMSFAoQSVRFTV9NQVNURVJfQkFMTBAE",
						"Eg8KC0lURU1fUE9USU9OEGUSFQoRSVRFTV9TVVBFUl9QT1RJT04QZhIVChFJ",
						"VEVNX0hZUEVSX1BPVElPThBnEhMKD0lURU1fTUFYX1BPVElPThBoEhAKC0lU",
						"RU1fUkVWSVZFEMkBEhQKD0lURU1fTUFYX1JFVklWRRDKARITCg5JVEVNX0xV",
						"Q0tZX0VHRxCtAhIaChVJVEVNX0lOQ0VOU0VfT1JESU5BUlkQkQMSFwoSSVRF",
						"TV9JTkNFTlNFX1NQSUNZEJIDEhYKEUlURU1fSU5DRU5TRV9DT09MEJMDEhgK",
						"E0lURU1fSU5DRU5TRV9GTE9SQUwQlAMSEwoOSVRFTV9UUk9ZX0RJU0sQ9QMS",
						"EgoNSVRFTV9YX0FUVEFDSxDaBBITCg5JVEVNX1hfREVGRU5TRRDbBBITCg5J",
						"VEVNX1hfTUlSQUNMRRDcBBIUCg9JVEVNX1JBWlpfQkVSUlkQvQUSFAoPSVRF",
						"TV9CTFVLX0JFUlJZEL4FEhUKEElURU1fTkFOQUJfQkVSUlkQvwUSFQoQSVRF",
						"TV9XRVBBUl9CRVJSWRDABRIVChBJVEVNX1BJTkFQX0JFUlJZEMEFEhgKE0lU",
						"RU1fU1BFQ0lBTF9DQU1FUkEQoQYSIwoeSVRFTV9JTkNVQkFUT1JfQkFTSUNf",
						"VU5MSU1JVEVEEIUHEhkKFElURU1fSU5DVUJBVE9SX0JBU0lDEIYHEiEKHElU",
						"RU1fUE9LRU1PTl9TVE9SQUdFX1VQR1JBREUQ6QcSHgoZSVRFTV9JVEVNX1NU",
						"T1JBR0VfVVBHUkFERRDqB2IGcHJvdG8z"));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new pbr.FileDescriptor[] { },
				new pbr::GeneratedClrTypeInfo(new[] { typeof(global::POGOProtos.Inventory.Item.ItemId), }, null));
		}

		#endregion
	}

	#region Enums

	/// <summary>
	/// The item id.
	/// </summary>
	public enum ItemId
	{
		/// <summary>
		/// The item unknown.
		/// </summary>
		[pbr::OriginalName("ITEM_UNKNOWN")] ItemUnknown = 0,

		/// <summary>
		/// The item poke ball.
		/// </summary>
		[pbr::OriginalName("ITEM_POKE_BALL")] ItemPokeBall = 1,

		/// <summary>
		/// The item great ball.
		/// </summary>
		[pbr::OriginalName("ITEM_GREAT_BALL")] ItemGreatBall = 2,

		/// <summary>
		/// The item ultra ball.
		/// </summary>
		[pbr::OriginalName("ITEM_ULTRA_BALL")] ItemUltraBall = 3,

		/// <summary>
		/// The item master ball.
		/// </summary>
		[pbr::OriginalName("ITEM_MASTER_BALL")] ItemMasterBall = 4,

		/// <summary>
		/// The item potion.
		/// </summary>
		[pbr::OriginalName("ITEM_POTION")] ItemPotion = 101,

		/// <summary>
		/// The item super potion.
		/// </summary>
		[pbr::OriginalName("ITEM_SUPER_POTION")] ItemSuperPotion = 102,

		/// <summary>
		/// The item hyper potion.
		/// </summary>
		[pbr::OriginalName("ITEM_HYPER_POTION")] ItemHyperPotion = 103,

		/// <summary>
		/// The item max potion.
		/// </summary>
		[pbr::OriginalName("ITEM_MAX_POTION")] ItemMaxPotion = 104,

		/// <summary>
		/// The item revive.
		/// </summary>
		[pbr::OriginalName("ITEM_REVIVE")] ItemRevive = 201,

		/// <summary>
		/// The item max revive.
		/// </summary>
		[pbr::OriginalName("ITEM_MAX_REVIVE")] ItemMaxRevive = 202,

		/// <summary>
		/// The item lucky egg.
		/// </summary>
		[pbr::OriginalName("ITEM_LUCKY_EGG")] ItemLuckyEgg = 301,

		/// <summary>
		/// The item incense ordinary.
		/// </summary>
		[pbr::OriginalName("ITEM_INCENSE_ORDINARY")] ItemIncenseOrdinary = 401,

		/// <summary>
		/// The item incense spicy.
		/// </summary>
		[pbr::OriginalName("ITEM_INCENSE_SPICY")] ItemIncenseSpicy = 402,

		/// <summary>
		/// The item incense cool.
		/// </summary>
		[pbr::OriginalName("ITEM_INCENSE_COOL")] ItemIncenseCool = 403,

		/// <summary>
		/// The item incense floral.
		/// </summary>
		[pbr::OriginalName("ITEM_INCENSE_FLORAL")] ItemIncenseFloral = 404,

		/// <summary>
		/// The item troy disk.
		/// </summary>
		[pbr::OriginalName("ITEM_TROY_DISK")] ItemTroyDisk = 501,

		/// <summary>
		/// The item x attack.
		/// </summary>
		[pbr::OriginalName("ITEM_X_ATTACK")] ItemXAttack = 602,

		/// <summary>
		/// The item x defense.
		/// </summary>
		[pbr::OriginalName("ITEM_X_DEFENSE")] ItemXDefense = 603,

		/// <summary>
		/// The item x miracle.
		/// </summary>
		[pbr::OriginalName("ITEM_X_MIRACLE")] ItemXMiracle = 604,

		/// <summary>
		/// The item razz berry.
		/// </summary>
		[pbr::OriginalName("ITEM_RAZZ_BERRY")] ItemRazzBerry = 701,

		/// <summary>
		/// The item bluk berry.
		/// </summary>
		[pbr::OriginalName("ITEM_BLUK_BERRY")] ItemBlukBerry = 702,

		/// <summary>
		/// The item nanab berry.
		/// </summary>
		[pbr::OriginalName("ITEM_NANAB_BERRY")] ItemNanabBerry = 703,

		/// <summary>
		/// The item wepar berry.
		/// </summary>
		[pbr::OriginalName("ITEM_WEPAR_BERRY")] ItemWeparBerry = 704,

		/// <summary>
		/// The item pinap berry.
		/// </summary>
		[pbr::OriginalName("ITEM_PINAP_BERRY")] ItemPinapBerry = 705,

		/// <summary>
		/// The item special camera.
		/// </summary>
		[pbr::OriginalName("ITEM_SPECIAL_CAMERA")] ItemSpecialCamera = 801,

		/// <summary>
		/// The item incubator basic unlimited.
		/// </summary>
		[pbr::OriginalName("ITEM_INCUBATOR_BASIC_UNLIMITED")] ItemIncubatorBasicUnlimited = 901,

		/// <summary>
		/// The item incubator basic.
		/// </summary>
		[pbr::OriginalName("ITEM_INCUBATOR_BASIC")] ItemIncubatorBasic = 902,

		/// <summary>
		/// The item pokemon storage upgrade.
		/// </summary>
		[pbr::OriginalName("ITEM_POKEMON_STORAGE_UPGRADE")] ItemPokemonStorageUpgrade = 1001,

		/// <summary>
		/// The item item storage upgrade.
		/// </summary>
		[pbr::OriginalName("ITEM_ITEM_STORAGE_UPGRADE")] ItemItemStorageUpgrade = 1002,
	}

	#endregion
}

#endregion Designer generated code