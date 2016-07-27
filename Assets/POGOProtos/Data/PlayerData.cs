// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PlayerData.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Data/PlayerData.proto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

#pragma warning disable 1591, 0612, 3021

#region Designer generated code

using POGOProtos.Data.Player;
using POGOProtos.Enums;
using pb = Google.Protobuf;
using pbc = Google.Protobuf.Collections;
using pbr = Google.Protobuf.Reflection;
using scg = System.Collections.Generic;

namespace POGOProtos.Data
{
	/// <summary>Holder for reflection information generated from POGOProtos/Data/PlayerData.proto</summary>
	public static partial class PlayerDataReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Data/PlayerData.proto</summary>
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
		/// Initializes static members of the <see cref="PlayerDataReflection"/> class.
		/// </summary>
		static PlayerDataReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CiBQT0dPUHJvdG9zL0RhdGEvUGxheWVyRGF0YS5wcm90bxIPUE9HT1Byb3Rv",
						"cy5EYXRhGiRQT0dPUHJvdG9zL0VudW1zL1R1dG9yaWFsU3RhdGUucHJvdG8a",
						"KVBPR09Qcm90b3MvRGF0YS9QbGF5ZXIvUGxheWVyQXZhdGFyLnByb3RvGidQ",
						"T0dPUHJvdG9zL0RhdGEvUGxheWVyL0RhaWx5Qm9udXMucHJvdG8aKlBPR09Q",
						"cm90b3MvRGF0YS9QbGF5ZXIvRXF1aXBwZWRCYWRnZS5wcm90bxosUE9HT1By",
						"b3Rvcy9EYXRhL1BsYXllci9Db250YWN0U2V0dGluZ3MucHJvdG8aJVBPR09Q",
						"cm90b3MvRGF0YS9QbGF5ZXIvQ3VycmVuY3kucHJvdG8aIFBPR09Qcm90b3Mv",
						"RW51bXMvVGVhbUNvbG9yLnByb3RvIoMECgpQbGF5ZXJEYXRhEh0KFWNyZWF0",
						"aW9uX3RpbWVzdGFtcF9tcxgBIAEoAxIQCgh1c2VybmFtZRgCIAEoCRIpCgR0",
						"ZWFtGAUgASgOMhsuUE9HT1Byb3Rvcy5FbnVtcy5UZWFtQ29sb3ISOwoOdHV0",
						"b3JpYWxfc3RhdGUYByADKA4yHy5QT0dPUHJvdG9zLkVudW1zLlR1dG9yaWFs",
						"U3RhdGVCAhABEjQKBmF2YXRhchgIIAEoCzIkLlBPR09Qcm90b3MuRGF0YS5Q",
						"bGF5ZXIuUGxheWVyQXZhdGFyEhsKE21heF9wb2tlbW9uX3N0b3JhZ2UYCSAB",
						"KAUSGAoQbWF4X2l0ZW1fc3RvcmFnZRgKIAEoBRI3CgtkYWlseV9ib251cxgL",
						"IAEoCzIiLlBPR09Qcm90b3MuRGF0YS5QbGF5ZXIuRGFpbHlCb251cxI9Cg5l",
						"cXVpcHBlZF9iYWRnZRgMIAEoCzIlLlBPR09Qcm90b3MuRGF0YS5QbGF5ZXIu",
						"RXF1aXBwZWRCYWRnZRJBChBjb250YWN0X3NldHRpbmdzGA0gASgLMicuUE9H",
						"T1Byb3Rvcy5EYXRhLlBsYXllci5Db250YWN0U2V0dGluZ3MSNAoKY3VycmVu",
						"Y2llcxgOIAMoCzIgLlBPR09Qcm90b3MuRGF0YS5QbGF5ZXIuQ3VycmVuY3li",
						"BnByb3RvMw=="));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new[]
				{
					global::POGOProtos.Enums.TutorialStateReflection.Descriptor,
					global::POGOProtos.Data.Player.PlayerAvatarReflection.Descriptor,
					global::POGOProtos.Data.Player.DailyBonusReflection.Descriptor,
					global::POGOProtos.Data.Player.EquippedBadgeReflection.Descriptor,
					global::POGOProtos.Data.Player.ContactSettingsReflection.Descriptor,
					global::POGOProtos.Data.Player.CurrencyReflection.Descriptor,
					global::POGOProtos.Enums.TeamColorReflection.Descriptor,
				},
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Data.PlayerData),
							global::POGOProtos.Data.PlayerData.Parser,
							new[]
							{
								"CreationTimestampMs", "Username", "Team", "TutorialState", "Avatar", "MaxPokemonStorage", "MaxItemStorage",
								"DailyBonus", "EquippedBadge", "ContactSettings", "Currencies"
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
	/// The player data.
	/// </summary>
	public sealed partial class PlayerData : pb::IMessage<PlayerData>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "creation_timestamp_ms" field.</summary>
		public const int CreationTimestampMsFieldNumber = 1;

		/// <summary>Field number for the "username" field.</summary>
		public const int UsernameFieldNumber = 2;

		/// <summary>Field number for the "team" field.</summary>
		public const int TeamFieldNumber = 5;

		/// <summary>Field number for the "tutorial_state" field.</summary>
		public const int TutorialStateFieldNumber = 7;

		/// <summary>Field number for the "avatar" field.</summary>
		public const int AvatarFieldNumber = 8;

		/// <summary>Field number for the "max_pokemon_storage" field.</summary>
		public const int MaxPokemonStorageFieldNumber = 9;

		/// <summary>Field number for the "max_item_storage" field.</summary>
		public const int MaxItemStorageFieldNumber = 10;

		/// <summary>Field number for the "daily_bonus" field.</summary>
		public const int DailyBonusFieldNumber = 11;

		/// <summary>Field number for the "equipped_badge" field.</summary>
		public const int EquippedBadgeFieldNumber = 12;

		/// <summary>Field number for the "contact_settings" field.</summary>
		public const int ContactSettingsFieldNumber = 13;

		/// <summary>Field number for the "currencies" field.</summary>
		public const int CurrenciesFieldNumber = 14;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<PlayerData> _parser =
			new pb::MessageParser<PlayerData>(() => new PlayerData());

		/// <summary>
		/// The _repeated_tutorial state_codec.
		/// </summary>
		private static readonly pb.FieldCodec<TutorialState> _repeated_tutorialState_codec = pb::FieldCodec.ForEnum(
			58,
			x => (int)x,
			x => (global::POGOProtos.Enums.TutorialState)x);

		/// <summary>
		/// The _repeated_currencies_codec.
		/// </summary>
		private static readonly pb.FieldCodec<Currency> _repeated_currencies_codec = pb::FieldCodec.ForMessage(
			114,
			global::POGOProtos.Data.Player.Currency.Parser);

		#endregion

		#region  Fields

		/// <summary>
		/// The avatar_.
		/// </summary>
		private PlayerAvatar avatar_;

		/// <summary>
		/// The contact settings_.
		/// </summary>
		private ContactSettings contactSettings_;

		/// <summary>
		/// The creation timestamp ms_.
		/// </summary>
		private long creationTimestampMs_;

		/// <summary>
		/// The currencies_.
		/// </summary>
		private readonly pbc.RepeatedField<Currency> currencies_ = new pbc::RepeatedField<Currency>();

		/// <summary>
		/// The daily bonus_.
		/// </summary>
		private DailyBonus dailyBonus_;

		/// <summary>
		/// The equipped badge_.
		/// </summary>
		private EquippedBadge equippedBadge_;

		/// <summary>
		/// The max item storage_.
		/// </summary>
		private int maxItemStorage_;

		/// <summary>
		/// The max pokemon storage_.
		/// </summary>
		private int maxPokemonStorage_;

		/// <summary>
		/// The team_.
		/// </summary>
		private TeamColor team_ = 0;

		/// <summary>
		/// The tutorial state_.
		/// </summary>
		private readonly pbc.RepeatedField<TutorialState> tutorialState_ = new pbc::RepeatedField<TutorialState>();

		/// <summary>
		/// The username_.
		/// </summary>
		private string username_ = string.Empty;

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="PlayerData"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public PlayerData()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="PlayerData"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public PlayerData(PlayerData other) : this()
		{
			creationTimestampMs_ = other.creationTimestampMs_;
			username_ = other.username_;
			team_ = other.team_;
			tutorialState_ = other.tutorialState_.Clone();
			Avatar = other.avatar_ != null ? other.Avatar.Clone() : null;
			maxPokemonStorage_ = other.maxPokemonStorage_;
			maxItemStorage_ = other.maxItemStorage_;
			DailyBonus = other.dailyBonus_ != null ? other.DailyBonus.Clone() : null;
			EquippedBadge = other.equippedBadge_ != null ? other.EquippedBadge.Clone() : null;
			ContactSettings = other.contactSettings_ != null ? other.ContactSettings.Clone() : null;
			currencies_ = other.currencies_.Clone();
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<PlayerData> Parser
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
				return global::POGOProtos.Data.PlayerDataReflection.Descriptor.MessageTypes[0];
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
		/// Gets or sets the creation timestamp ms.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public long CreationTimestampMs
		{
			get
			{
				return creationTimestampMs_;
			}

			set
			{
				creationTimestampMs_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the username.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public string Username
		{
			get
			{
				return username_;
			}

			set
			{
				username_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
			}
		}

		/// <summary>
		/// Gets or sets the team.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public TeamColor Team
		{
			get
			{
				return team_;
			}

			set
			{
				team_ = value;
			}
		}

		/// <summary>
		/// Gets the tutorial state.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public pbc.RepeatedField<TutorialState> TutorialState
		{
			get
			{
				return tutorialState_;
			}
		}

		/// <summary>
		/// Gets or sets the avatar.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public PlayerAvatar Avatar
		{
			get
			{
				return avatar_;
			}

			set
			{
				avatar_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the max pokemon storage.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public int MaxPokemonStorage
		{
			get
			{
				return maxPokemonStorage_;
			}

			set
			{
				maxPokemonStorage_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the max item storage.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public int MaxItemStorage
		{
			get
			{
				return maxItemStorage_;
			}

			set
			{
				maxItemStorage_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the daily bonus.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public DailyBonus DailyBonus
		{
			get
			{
				return dailyBonus_;
			}

			set
			{
				dailyBonus_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the equipped badge.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public EquippedBadge EquippedBadge
		{
			get
			{
				return equippedBadge_;
			}

			set
			{
				equippedBadge_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the contact settings.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public ContactSettings ContactSettings
		{
			get
			{
				return contactSettings_;
			}

			set
			{
				contactSettings_ = value;
			}
		}

		/// <summary>
		/// Gets the currencies.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public pbc.RepeatedField<Currency> Currencies
		{
			get
			{
				return currencies_;
			}
		}

		#endregion

		#region  Interface Implementations

		/// <summary>
		/// The clone.
		/// </summary>
		/// <returns>
		/// The <see cref="PlayerData"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public PlayerData Clone()
		{
			return new PlayerData(this);
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
		public bool Equals(PlayerData other)
		{
			if (ReferenceEquals(other, null))
			{
				return false;
			}

			if (ReferenceEquals(other, this))
			{
				return true;
			}

			if (CreationTimestampMs != other.CreationTimestampMs)
			{
				return false;
			}

			if (Username != other.Username)
			{
				return false;
			}

			if (Team != other.Team)
			{
				return false;
			}

			if (!tutorialState_.Equals(other.tutorialState_))
			{
				return false;
			}

			if (!object.Equals(Avatar, other.Avatar))
			{
				return false;
			}

			if (MaxPokemonStorage != other.MaxPokemonStorage)
			{
				return false;
			}

			if (MaxItemStorage != other.MaxItemStorage)
			{
				return false;
			}

			if (!object.Equals(DailyBonus, other.DailyBonus))
			{
				return false;
			}

			if (!object.Equals(EquippedBadge, other.EquippedBadge))
			{
				return false;
			}

			if (!object.Equals(ContactSettings, other.ContactSettings))
			{
				return false;
			}

			if (!currencies_.Equals(other.currencies_))
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
			if (CreationTimestampMs != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(CreationTimestampMs);
			}

			if (Username.Length != 0)
			{
				output.WriteRawTag(18);
				output.WriteString(Username);
			}

			if (Team != 0)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)Team);
			}

			tutorialState_.WriteTo(output, _repeated_tutorialState_codec);
			if (avatar_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(Avatar);
			}

			if (MaxPokemonStorage != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(MaxPokemonStorage);
			}

			if (MaxItemStorage != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(MaxItemStorage);
			}

			if (dailyBonus_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(DailyBonus);
			}

			if (equippedBadge_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(EquippedBadge);
			}

			if (contactSettings_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(ContactSettings);
			}

			currencies_.WriteTo(output, _repeated_currencies_codec);
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
			if (CreationTimestampMs != 0L)
			{
				size += 1 + pb::CodedOutputStream.ComputeInt64Size(CreationTimestampMs);
			}

			if (Username.Length != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeStringSize(Username);
			}

			if (Team != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeEnumSize((int)Team);
			}

			size += tutorialState_.CalculateSize(_repeated_tutorialState_codec);
			if (avatar_ != null)
			{
				size += 1 + pb::CodedOutputStream.ComputeMessageSize(Avatar);
			}

			if (MaxPokemonStorage != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeInt32Size(MaxPokemonStorage);
			}

			if (MaxItemStorage != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeInt32Size(MaxItemStorage);
			}

			if (dailyBonus_ != null)
			{
				size += 1 + pb::CodedOutputStream.ComputeMessageSize(DailyBonus);
			}

			if (equippedBadge_ != null)
			{
				size += 1 + pb::CodedOutputStream.ComputeMessageSize(EquippedBadge);
			}

			if (contactSettings_ != null)
			{
				size += 1 + pb::CodedOutputStream.ComputeMessageSize(ContactSettings);
			}

			size += currencies_.CalculateSize(_repeated_currencies_codec);
			return size;
		}

		/// <summary>
		/// The merge from.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public void MergeFrom(PlayerData other)
		{
			if (other == null)
			{
				return;
			}

			if (other.CreationTimestampMs != 0L)
			{
				CreationTimestampMs = other.CreationTimestampMs;
			}

			if (other.Username.Length != 0)
			{
				Username = other.Username;
			}

			if (other.Team != 0)
			{
				Team = other.Team;
			}

			tutorialState_.Add(other.tutorialState_);
			if (other.avatar_ != null)
			{
				if (avatar_ == null)
				{
					avatar_ = new global::POGOProtos.Data.Player.PlayerAvatar();
				}

				Avatar.MergeFrom(other.Avatar);
			}

			if (other.MaxPokemonStorage != 0)
			{
				MaxPokemonStorage = other.MaxPokemonStorage;
			}

			if (other.MaxItemStorage != 0)
			{
				MaxItemStorage = other.MaxItemStorage;
			}

			if (other.dailyBonus_ != null)
			{
				if (dailyBonus_ == null)
				{
					dailyBonus_ = new global::POGOProtos.Data.Player.DailyBonus();
				}

				DailyBonus.MergeFrom(other.DailyBonus);
			}

			if (other.equippedBadge_ != null)
			{
				if (equippedBadge_ == null)
				{
					equippedBadge_ = new global::POGOProtos.Data.Player.EquippedBadge();
				}

				EquippedBadge.MergeFrom(other.EquippedBadge);
			}

			if (other.contactSettings_ != null)
			{
				if (contactSettings_ == null)
				{
					contactSettings_ = new global::POGOProtos.Data.Player.ContactSettings();
				}

				ContactSettings.MergeFrom(other.ContactSettings);
			}

			currencies_.Add(other.currencies_);
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
					case 8:
					{
						CreationTimestampMs = input.ReadInt64();
						break;
					}

					case 18:
					{
						Username = input.ReadString();
						break;
					}

					case 40:
					{
						team_ = (global::POGOProtos.Enums.TeamColor)input.ReadEnum();
						break;
					}

					case 58:
					case 56:
					{
						tutorialState_.AddEntriesFrom(input, _repeated_tutorialState_codec);
						break;
					}

					case 66:
					{
						if (avatar_ == null)
						{
							avatar_ = new global::POGOProtos.Data.Player.PlayerAvatar();
						}

						input.ReadMessage(avatar_);
						break;
					}

					case 72:
					{
						MaxPokemonStorage = input.ReadInt32();
						break;
					}

					case 80:
					{
						MaxItemStorage = input.ReadInt32();
						break;
					}

					case 90:
					{
						if (dailyBonus_ == null)
						{
							dailyBonus_ = new global::POGOProtos.Data.Player.DailyBonus();
						}

						input.ReadMessage(dailyBonus_);
						break;
					}

					case 98:
					{
						if (equippedBadge_ == null)
						{
							equippedBadge_ = new global::POGOProtos.Data.Player.EquippedBadge();
						}

						input.ReadMessage(equippedBadge_);
						break;
					}

					case 106:
					{
						if (contactSettings_ == null)
						{
							contactSettings_ = new global::POGOProtos.Data.Player.ContactSettings();
						}

						input.ReadMessage(contactSettings_);
						break;
					}

					case 114:
					{
						currencies_.AddEntriesFrom(input, _repeated_currencies_codec);
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
			return Equals(other as PlayerData);
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
			if (CreationTimestampMs != 0L)
			{
				hash ^= CreationTimestampMs.GetHashCode();
			}

			if (Username.Length != 0)
			{
				hash ^= Username.GetHashCode();
			}

			if (Team != 0)
			{
				hash ^= Team.GetHashCode();
			}

			hash ^= tutorialState_.GetHashCode();
			if (avatar_ != null)
			{
				hash ^= Avatar.GetHashCode();
			}

			if (MaxPokemonStorage != 0)
			{
				hash ^= MaxPokemonStorage.GetHashCode();
			}

			if (MaxItemStorage != 0)
			{
				hash ^= MaxItemStorage.GetHashCode();
			}

			if (dailyBonus_ != null)
			{
				hash ^= DailyBonus.GetHashCode();
			}

			if (equippedBadge_ != null)
			{
				hash ^= EquippedBadge.GetHashCode();
			}

			if (contactSettings_ != null)
			{
				hash ^= ContactSettings.GetHashCode();
			}

			hash ^= currencies_.GetHashCode();
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