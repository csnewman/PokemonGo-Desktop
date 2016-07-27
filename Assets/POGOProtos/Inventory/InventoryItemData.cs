// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InventoryItemData.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Inventory/InventoryItemData.proto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

#pragma warning disable 1591, 0612, 3021

#region Designer generated code

using POGOProtos.Data;
using POGOProtos.Data.Player;
using POGOProtos.Inventory.Item;
using pb = Google.Protobuf;
using pbc = Google.Protobuf.Collections;
using pbr = Google.Protobuf.Reflection;
using scg = System.Collections.Generic;

namespace POGOProtos.Inventory
{
	/// <summary>Holder for reflection information generated from POGOProtos/Inventory/InventoryItemData.proto</summary>
	public static partial class InventoryItemDataReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Inventory/InventoryItemData.proto</summary>
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
		/// Initializes static members of the <see cref="InventoryItemDataReflection"/> class.
		/// </summary>
		static InventoryItemDataReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CixQT0dPUHJvdG9zL0ludmVudG9yeS9JbnZlbnRvcnlJdGVtRGF0YS5wcm90",
						"bxIUUE9HT1Byb3Rvcy5JbnZlbnRvcnkaKFBPR09Qcm90b3MvSW52ZW50b3J5",
						"L0l0ZW0vSXRlbURhdGEucHJvdG8aJ1BPR09Qcm90b3MvSW52ZW50b3J5L0Fw",
						"cGxpZWRJdGVtcy5wcm90bxooUE9HT1Byb3Rvcy9JbnZlbnRvcnkvRWdnSW5j",
						"dWJhdG9ycy5wcm90bxooUE9HT1Byb3Rvcy9JbnZlbnRvcnkvUG9rZW1vbkZh",
						"bWlseS5wcm90bxosUE9HT1Byb3Rvcy9JbnZlbnRvcnkvSW52ZW50b3J5VXBn",
						"cmFkZXMucHJvdG8aIVBPR09Qcm90b3MvRGF0YS9Qb2tlbW9uRGF0YS5wcm90",
						"bxoiUE9HT1Byb3Rvcy9EYXRhL1Bva2VkZXhFbnRyeS5wcm90bxooUE9HT1By",
						"b3Rvcy9EYXRhL1BsYXllci9QbGF5ZXJTdGF0cy5wcm90bxorUE9HT1Byb3Rv",
						"cy9EYXRhL1BsYXllci9QbGF5ZXJDdXJyZW5jeS5wcm90bxopUE9HT1Byb3Rv",
						"cy9EYXRhL1BsYXllci9QbGF5ZXJDYW1lcmEucHJvdG8i4wQKEUludmVudG9y",
						"eUl0ZW1EYXRhEjIKDHBva2Vtb25fZGF0YRgBIAEoCzIcLlBPR09Qcm90b3Mu",
						"RGF0YS5Qb2tlbW9uRGF0YRIxCgRpdGVtGAIgASgLMiMuUE9HT1Byb3Rvcy5J",
						"bnZlbnRvcnkuSXRlbS5JdGVtRGF0YRI0Cg1wb2tlZGV4X2VudHJ5GAMgASgL",
						"Mh0uUE9HT1Byb3Rvcy5EYXRhLlBva2VkZXhFbnRyeRI5CgxwbGF5ZXJfc3Rh",
						"dHMYBCABKAsyIy5QT0dPUHJvdG9zLkRhdGEuUGxheWVyLlBsYXllclN0YXRz",
						"Ej8KD3BsYXllcl9jdXJyZW5jeRgFIAEoCzImLlBPR09Qcm90b3MuRGF0YS5Q",
						"bGF5ZXIuUGxheWVyQ3VycmVuY3kSOwoNcGxheWVyX2NhbWVyYRgGIAEoCzIk",
						"LlBPR09Qcm90b3MuRGF0YS5QbGF5ZXIuUGxheWVyQ2FtZXJhEkMKEmludmVu",
						"dG9yeV91cGdyYWRlcxgHIAEoCzInLlBPR09Qcm90b3MuSW52ZW50b3J5Lklu",
						"dmVudG9yeVVwZ3JhZGVzEjkKDWFwcGxpZWRfaXRlbXMYCCABKAsyIi5QT0dP",
						"UHJvdG9zLkludmVudG9yeS5BcHBsaWVkSXRlbXMSOwoOZWdnX2luY3ViYXRv",
						"cnMYCSABKAsyIy5QT0dPUHJvdG9zLkludmVudG9yeS5FZ2dJbmN1YmF0b3Jz",
						"EjsKDnBva2Vtb25fZmFtaWx5GAogASgLMiMuUE9HT1Byb3Rvcy5JbnZlbnRv",
						"cnkuUG9rZW1vbkZhbWlseWIGcHJvdG8z"));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new[]
				{
					global::POGOProtos.Inventory.Item.ItemDataReflection.Descriptor,
					global::POGOProtos.Inventory.AppliedItemsReflection.Descriptor,
					global::POGOProtos.Inventory.EggIncubatorsReflection.Descriptor,
					global::POGOProtos.Inventory.PokemonFamilyReflection.Descriptor,
					global::POGOProtos.Inventory.InventoryUpgradesReflection.Descriptor,
					global::POGOProtos.Data.PokemonDataReflection.Descriptor, global::POGOProtos.Data.PokedexEntryReflection.Descriptor,
					global::POGOProtos.Data.Player.PlayerStatsReflection.Descriptor,
					global::POGOProtos.Data.Player.PlayerCurrencyReflection.Descriptor,
					global::POGOProtos.Data.Player.PlayerCameraReflection.Descriptor,
				},
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Inventory.InventoryItemData),
							global::POGOProtos.Inventory.InventoryItemData.Parser,
							new[]
							{
								"PokemonData", "Item", "PokedexEntry", "PlayerStats", "PlayerCurrency", "PlayerCamera", "InventoryUpgrades",
								"AppliedItems", "EggIncubators", "PokemonFamily"
							},
							null,
							null,
							null)
					}));
		}

		#endregion
	}

	#region Messages

	/// <summary>
	/// The inventory item data.
	/// </summary>
	public sealed partial class InventoryItemData : pb::IMessage<InventoryItemData>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "pokemon_data" field.</summary>
		public const int PokemonDataFieldNumber = 1;

		/// <summary>Field number for the "item" field.</summary>
		public const int ItemFieldNumber = 2;

		/// <summary>Field number for the "pokedex_entry" field.</summary>
		public const int PokedexEntryFieldNumber = 3;

		/// <summary>Field number for the "player_stats" field.</summary>
		public const int PlayerStatsFieldNumber = 4;

		/// <summary>Field number for the "player_currency" field.</summary>
		public const int PlayerCurrencyFieldNumber = 5;

		/// <summary>Field number for the "player_camera" field.</summary>
		public const int PlayerCameraFieldNumber = 6;

		/// <summary>Field number for the "inventory_upgrades" field.</summary>
		public const int InventoryUpgradesFieldNumber = 7;

		/// <summary>Field number for the "applied_items" field.</summary>
		public const int AppliedItemsFieldNumber = 8;

		/// <summary>Field number for the "egg_incubators" field.</summary>
		public const int EggIncubatorsFieldNumber = 9;

		/// <summary>Field number for the "pokemon_family" field.</summary>
		public const int PokemonFamilyFieldNumber = 10;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<InventoryItemData> _parser =
			new pb::MessageParser<InventoryItemData>(() => new InventoryItemData());

		#endregion

		#region  Fields

		/// <summary>
		/// The applied items_.
		/// </summary>
		private AppliedItems appliedItems_;

		/// <summary>
		/// The egg incubators_.
		/// </summary>
		private EggIncubators eggIncubators_;

		/// <summary>
		/// The inventory upgrades_.
		/// </summary>
		private InventoryUpgrades inventoryUpgrades_;

		/// <summary>
		/// The item_.
		/// </summary>
		private ItemData item_;

		/// <summary>
		/// The player camera_.
		/// </summary>
		private PlayerCamera playerCamera_;

		/// <summary>
		/// The player currency_.
		/// </summary>
		private PlayerCurrency playerCurrency_;

		/// <summary>
		/// The player stats_.
		/// </summary>
		private PlayerStats playerStats_;

		/// <summary>
		/// The pokedex entry_.
		/// </summary>
		private PokedexEntry pokedexEntry_;

		/// <summary>
		/// The pokemon data_.
		/// </summary>
		private PokemonData pokemonData_;

		/// <summary>
		/// The pokemon family_.
		/// </summary>
		private PokemonFamily pokemonFamily_;

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="InventoryItemData"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public InventoryItemData()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="InventoryItemData"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public InventoryItemData(InventoryItemData other) : this()
		{
			PokemonData = other.pokemonData_ != null ? other.PokemonData.Clone() : null;
			Item = other.item_ != null ? other.Item.Clone() : null;
			PokedexEntry = other.pokedexEntry_ != null ? other.PokedexEntry.Clone() : null;
			PlayerStats = other.playerStats_ != null ? other.PlayerStats.Clone() : null;
			PlayerCurrency = other.playerCurrency_ != null ? other.PlayerCurrency.Clone() : null;
			PlayerCamera = other.playerCamera_ != null ? other.PlayerCamera.Clone() : null;
			InventoryUpgrades = other.inventoryUpgrades_ != null ? other.InventoryUpgrades.Clone() : null;
			AppliedItems = other.appliedItems_ != null ? other.AppliedItems.Clone() : null;
			EggIncubators = other.eggIncubators_ != null ? other.EggIncubators.Clone() : null;
			PokemonFamily = other.pokemonFamily_ != null ? other.PokemonFamily.Clone() : null;
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<InventoryItemData> Parser
		{
			get
			{
				return _parser;
			}
		}

		/// <summary>
		/// Gets the descriptor.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pbr.MessageDescriptor Descriptor
		{
			get
			{
				return global::POGOProtos.Inventory.InventoryItemDataReflection.Descriptor.MessageTypes[0];
			}
		}

		/// <summary>
		/// Gets the descriptor.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		pbr.MessageDescriptor pb::IMessage.Descriptor
		{
			get
			{
				return Descriptor;
			}
		}

		/// <summary>
		/// Gets or sets the pokemon data.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public PokemonData PokemonData
		{
			get
			{
				return pokemonData_;
			}

			set
			{
				pokemonData_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the item.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public ItemData Item
		{
			get
			{
				return item_;
			}

			set
			{
				item_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the pokedex entry.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public PokedexEntry PokedexEntry
		{
			get
			{
				return pokedexEntry_;
			}

			set
			{
				pokedexEntry_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the player stats.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public PlayerStats PlayerStats
		{
			get
			{
				return playerStats_;
			}

			set
			{
				playerStats_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the player currency.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public PlayerCurrency PlayerCurrency
		{
			get
			{
				return playerCurrency_;
			}

			set
			{
				playerCurrency_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the player camera.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public PlayerCamera PlayerCamera
		{
			get
			{
				return playerCamera_;
			}

			set
			{
				playerCamera_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the inventory upgrades.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public InventoryUpgrades InventoryUpgrades
		{
			get
			{
				return inventoryUpgrades_;
			}

			set
			{
				inventoryUpgrades_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the applied items.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public AppliedItems AppliedItems
		{
			get
			{
				return appliedItems_;
			}

			set
			{
				appliedItems_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the egg incubators.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public EggIncubators EggIncubators
		{
			get
			{
				return eggIncubators_;
			}

			set
			{
				eggIncubators_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the pokemon family.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public PokemonFamily PokemonFamily
		{
			get
			{
				return pokemonFamily_;
			}

			set
			{
				pokemonFamily_ = value;
			}
		}

		#endregion

		#region  Interface Implementations

		/// <summary>
		/// The clone.
		/// </summary>
		/// <returns>
		/// The <see cref="InventoryItemData"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public InventoryItemData Clone()
		{
			return new InventoryItemData(this);
		}

		/// <summary>
		/// The equals.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		/// <returns>
		/// The <see cref="bool"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public bool Equals(InventoryItemData other)
		{
			if (ReferenceEquals(other, null))
			{
				return false;
			}

			if (ReferenceEquals(other, this))
			{
				return true;
			}

			if (!object.Equals(PokemonData, other.PokemonData))
			{
				return false;
			}

			if (!object.Equals(Item, other.Item))
			{
				return false;
			}

			if (!object.Equals(PokedexEntry, other.PokedexEntry))
			{
				return false;
			}

			if (!object.Equals(PlayerStats, other.PlayerStats))
			{
				return false;
			}

			if (!object.Equals(PlayerCurrency, other.PlayerCurrency))
			{
				return false;
			}

			if (!object.Equals(PlayerCamera, other.PlayerCamera))
			{
				return false;
			}

			if (!object.Equals(InventoryUpgrades, other.InventoryUpgrades))
			{
				return false;
			}

			if (!object.Equals(AppliedItems, other.AppliedItems))
			{
				return false;
			}

			if (!object.Equals(EggIncubators, other.EggIncubators))
			{
				return false;
			}

			if (!object.Equals(PokemonFamily, other.PokemonFamily))
			{
				return false;
			}

			return true;
		}

		/// <summary>
		/// The write to.
		/// </summary>
		/// <param name="output">
		/// The output.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public void WriteTo(pb.CodedOutputStream output)
		{
			if (pokemonData_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(PokemonData);
			}

			if (item_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(Item);
			}

			if (pokedexEntry_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(PokedexEntry);
			}

			if (playerStats_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(PlayerStats);
			}

			if (playerCurrency_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(PlayerCurrency);
			}

			if (playerCamera_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(PlayerCamera);
			}

			if (inventoryUpgrades_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(InventoryUpgrades);
			}

			if (appliedItems_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(AppliedItems);
			}

			if (eggIncubators_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(EggIncubators);
			}

			if (pokemonFamily_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(PokemonFamily);
			}
		}

		/// <summary>
		/// The calculate size.
		/// </summary>
		/// <returns>
		/// The <see cref="int"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public int CalculateSize()
		{
			int size = 0;
			if (pokemonData_ != null)
			{
				size += 1 + pb::CodedOutputStream.ComputeMessageSize(PokemonData);
			}

			if (item_ != null)
			{
				size += 1 + pb::CodedOutputStream.ComputeMessageSize(Item);
			}

			if (pokedexEntry_ != null)
			{
				size += 1 + pb::CodedOutputStream.ComputeMessageSize(PokedexEntry);
			}

			if (playerStats_ != null)
			{
				size += 1 + pb::CodedOutputStream.ComputeMessageSize(PlayerStats);
			}

			if (playerCurrency_ != null)
			{
				size += 1 + pb::CodedOutputStream.ComputeMessageSize(PlayerCurrency);
			}

			if (playerCamera_ != null)
			{
				size += 1 + pb::CodedOutputStream.ComputeMessageSize(PlayerCamera);
			}

			if (inventoryUpgrades_ != null)
			{
				size += 1 + pb::CodedOutputStream.ComputeMessageSize(InventoryUpgrades);
			}

			if (appliedItems_ != null)
			{
				size += 1 + pb::CodedOutputStream.ComputeMessageSize(AppliedItems);
			}

			if (eggIncubators_ != null)
			{
				size += 1 + pb::CodedOutputStream.ComputeMessageSize(EggIncubators);
			}

			if (pokemonFamily_ != null)
			{
				size += 1 + pb::CodedOutputStream.ComputeMessageSize(PokemonFamily);
			}

			return size;
		}

		/// <summary>
		/// The merge from.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public void MergeFrom(InventoryItemData other)
		{
			if (other == null)
			{
				return;
			}

			if (other.pokemonData_ != null)
			{
				if (pokemonData_ == null)
				{
					pokemonData_ = new global::POGOProtos.Data.PokemonData();
				}

				PokemonData.MergeFrom(other.PokemonData);
			}

			if (other.item_ != null)
			{
				if (item_ == null)
				{
					item_ = new global::POGOProtos.Inventory.Item.ItemData();
				}

				Item.MergeFrom(other.Item);
			}

			if (other.pokedexEntry_ != null)
			{
				if (pokedexEntry_ == null)
				{
					pokedexEntry_ = new global::POGOProtos.Data.PokedexEntry();
				}

				PokedexEntry.MergeFrom(other.PokedexEntry);
			}

			if (other.playerStats_ != null)
			{
				if (playerStats_ == null)
				{
					playerStats_ = new global::POGOProtos.Data.Player.PlayerStats();
				}

				PlayerStats.MergeFrom(other.PlayerStats);
			}

			if (other.playerCurrency_ != null)
			{
				if (playerCurrency_ == null)
				{
					playerCurrency_ = new global::POGOProtos.Data.Player.PlayerCurrency();
				}

				PlayerCurrency.MergeFrom(other.PlayerCurrency);
			}

			if (other.playerCamera_ != null)
			{
				if (playerCamera_ == null)
				{
					playerCamera_ = new global::POGOProtos.Data.Player.PlayerCamera();
				}

				PlayerCamera.MergeFrom(other.PlayerCamera);
			}

			if (other.inventoryUpgrades_ != null)
			{
				if (inventoryUpgrades_ == null)
				{
					inventoryUpgrades_ = new global::POGOProtos.Inventory.InventoryUpgrades();
				}

				InventoryUpgrades.MergeFrom(other.InventoryUpgrades);
			}

			if (other.appliedItems_ != null)
			{
				if (appliedItems_ == null)
				{
					appliedItems_ = new global::POGOProtos.Inventory.AppliedItems();
				}

				AppliedItems.MergeFrom(other.AppliedItems);
			}

			if (other.eggIncubators_ != null)
			{
				if (eggIncubators_ == null)
				{
					eggIncubators_ = new global::POGOProtos.Inventory.EggIncubators();
				}

				EggIncubators.MergeFrom(other.EggIncubators);
			}

			if (other.pokemonFamily_ != null)
			{
				if (pokemonFamily_ == null)
				{
					pokemonFamily_ = new global::POGOProtos.Inventory.PokemonFamily();
				}

				PokemonFamily.MergeFrom(other.PokemonFamily);
			}
		}

		/// <summary>
		/// The merge from.
		/// </summary>
		/// <param name="input">
		/// The input.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public void MergeFrom(pb.CodedInputStream input)
		{
			uint tag;
			while ((tag = input.ReadTag()) != 0)
			{
				switch (tag)
				{
					default:
						input.SkipLastField();
						break;
					case 10:
					{
						if (pokemonData_ == null)
						{
							pokemonData_ = new global::POGOProtos.Data.PokemonData();
						}

						input.ReadMessage(pokemonData_);
						break;
					}

					case 18:
					{
						if (item_ == null)
						{
							item_ = new global::POGOProtos.Inventory.Item.ItemData();
						}

						input.ReadMessage(item_);
						break;
					}

					case 26:
					{
						if (pokedexEntry_ == null)
						{
							pokedexEntry_ = new global::POGOProtos.Data.PokedexEntry();
						}

						input.ReadMessage(pokedexEntry_);
						break;
					}

					case 34:
					{
						if (playerStats_ == null)
						{
							playerStats_ = new global::POGOProtos.Data.Player.PlayerStats();
						}

						input.ReadMessage(playerStats_);
						break;
					}

					case 42:
					{
						if (playerCurrency_ == null)
						{
							playerCurrency_ = new global::POGOProtos.Data.Player.PlayerCurrency();
						}

						input.ReadMessage(playerCurrency_);
						break;
					}

					case 50:
					{
						if (playerCamera_ == null)
						{
							playerCamera_ = new global::POGOProtos.Data.Player.PlayerCamera();
						}

						input.ReadMessage(playerCamera_);
						break;
					}

					case 58:
					{
						if (inventoryUpgrades_ == null)
						{
							inventoryUpgrades_ = new global::POGOProtos.Inventory.InventoryUpgrades();
						}

						input.ReadMessage(inventoryUpgrades_);
						break;
					}

					case 66:
					{
						if (appliedItems_ == null)
						{
							appliedItems_ = new global::POGOProtos.Inventory.AppliedItems();
						}

						input.ReadMessage(appliedItems_);
						break;
					}

					case 74:
					{
						if (eggIncubators_ == null)
						{
							eggIncubators_ = new global::POGOProtos.Inventory.EggIncubators();
						}

						input.ReadMessage(eggIncubators_);
						break;
					}

					case 82:
					{
						if (pokemonFamily_ == null)
						{
							pokemonFamily_ = new global::POGOProtos.Inventory.PokemonFamily();
						}

						input.ReadMessage(pokemonFamily_);
						break;
					}
				}
			}
		}

		#endregion

		#region  Methods - Public

		/// <summary>
		/// The equals.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		/// <returns>
		/// The <see cref="bool"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public override bool Equals(object other)
		{
			return Equals(other as InventoryItemData);
		}

		/// <summary>
		/// The get hash code.
		/// </summary>
		/// <returns>
		/// The <see cref="int"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public override int GetHashCode()
		{
			int hash = 1;
			if (pokemonData_ != null)
			{
				hash ^= PokemonData.GetHashCode();
			}

			if (item_ != null)
			{
				hash ^= Item.GetHashCode();
			}

			if (pokedexEntry_ != null)
			{
				hash ^= PokedexEntry.GetHashCode();
			}

			if (playerStats_ != null)
			{
				hash ^= PlayerStats.GetHashCode();
			}

			if (playerCurrency_ != null)
			{
				hash ^= PlayerCurrency.GetHashCode();
			}

			if (playerCamera_ != null)
			{
				hash ^= PlayerCamera.GetHashCode();
			}

			if (inventoryUpgrades_ != null)
			{
				hash ^= InventoryUpgrades.GetHashCode();
			}

			if (appliedItems_ != null)
			{
				hash ^= AppliedItems.GetHashCode();
			}

			if (eggIncubators_ != null)
			{
				hash ^= EggIncubators.GetHashCode();
			}

			if (pokemonFamily_ != null)
			{
				hash ^= PokemonFamily.GetHashCode();
			}

			return hash;
		}

		/// <summary>
		/// The to string.
		/// </summary>
		/// <returns>
		/// The <see cref="string"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public override string ToString()
		{
			return pb::JsonFormatter.ToDiagnosticString(this);
		}

		#endregion

		#region  Methods - Private

		/// <summary>
		/// The on construction.
		/// </summary>
		partial void OnConstruction();

		#endregion
	}

	#endregion
}

#endregion Designer generated code