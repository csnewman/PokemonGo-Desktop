// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DownloadItemTemplatesResponse.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Networking/Responses/DownloadItemTemplatesResponse.proto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

#pragma warning disable 1591, 0612, 3021

#region Designer generated code

using POGOProtos.Settings.Master;
using pb = Google.Protobuf;
using pbc = Google.Protobuf.Collections;
using pbr = Google.Protobuf.Reflection;
using scg = System.Collections.Generic;

namespace POGOProtos.Networking.Responses
{
	/// <summary>Holder for reflection information generated from POGOProtos/Networking/Responses/DownloadItemTemplatesResponse.proto</summary>
	public static partial class DownloadItemTemplatesResponseReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Networking/Responses/DownloadItemTemplatesResponse.proto</summary>
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
		/// Initializes static members of the <see cref="DownloadItemTemplatesResponseReflection"/> class.
		/// </summary>
		static DownloadItemTemplatesResponseReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CkNQT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVzcG9uc2VzL0Rvd25sb2FkSXRl",
						"bVRlbXBsYXRlc1Jlc3BvbnNlLnByb3RvEh9QT0dPUHJvdG9zLk5ldHdvcmtp",
						"bmcuUmVzcG9uc2VzGi1QT0dPUHJvdG9zL1NldHRpbmdzL01hc3Rlci9JdGVt",
						"U2V0dGluZ3MucHJvdG8aLVBPR09Qcm90b3MvU2V0dGluZ3MvTWFzdGVyL01v",
						"dmVTZXR0aW5ncy5wcm90bxouUE9HT1Byb3Rvcy9TZXR0aW5ncy9NYXN0ZXIv",
						"QmFkZ2VTZXR0aW5ncy5wcm90bxowUE9HT1Byb3Rvcy9TZXR0aW5ncy9NYXN0",
						"ZXIvUG9rZW1vblNldHRpbmdzLnByb3RvGjVQT0dPUHJvdG9zL1NldHRpbmdz",
						"L01hc3Rlci9Nb3ZlU2VxdWVuY2VTZXR0aW5ncy5wcm90bxo2UE9HT1Byb3Rv",
						"cy9TZXR0aW5ncy9NYXN0ZXIvVHlwZUVmZmVjdGl2ZVNldHRpbmdzLnByb3Rv",
						"Gi9QT0dPUHJvdG9zL1NldHRpbmdzL01hc3Rlci9DYW1lcmFTZXR0aW5ncy5w",
						"cm90bxo0UE9HT1Byb3Rvcy9TZXR0aW5ncy9NYXN0ZXIvUGxheWVyTGV2ZWxT",
						"ZXR0aW5ncy5wcm90bxoxUE9HT1Byb3Rvcy9TZXR0aW5ncy9NYXN0ZXIvR3lt",
						"TGV2ZWxTZXR0aW5ncy5wcm90bxoyUE9HT1Byb3Rvcy9TZXR0aW5ncy9NYXN0",
						"ZXIvR3ltQmF0dGxlU2V0dGluZ3MucHJvdG8aMlBPR09Qcm90b3MvU2V0dGlu",
						"Z3MvTWFzdGVyL0VuY291bnRlclNldHRpbmdzLnByb3RvGi9QT0dPUHJvdG9z",
						"L1NldHRpbmdzL01hc3Rlci9JYXBJdGVtRGlzcGxheS5wcm90bxosUE9HT1By",
						"b3Rvcy9TZXR0aW5ncy9NYXN0ZXIvSWFwU2V0dGluZ3MucHJvdG8aN1BPR09Q",
						"cm90b3MvU2V0dGluZ3MvTWFzdGVyL1Bva2Vtb25VcGdyYWRlU2V0dGluZ3Mu",
						"cHJvdG8aNlBPR09Qcm90b3MvU2V0dGluZ3MvTWFzdGVyL0VxdWlwcGVkQmFk",
						"Z2VTZXR0aW5ncy5wcm90byLwCQodRG93bmxvYWRJdGVtVGVtcGxhdGVzUmVz",
						"cG9uc2USDwoHc3VjY2VzcxgBIAEoCBJjCg5pdGVtX3RlbXBsYXRlcxgCIAMo",
						"CzJLLlBPR09Qcm90b3MuTmV0d29ya2luZy5SZXNwb25zZXMuRG93bmxvYWRJ",
						"dGVtVGVtcGxhdGVzUmVzcG9uc2UuSXRlbVRlbXBsYXRlEhQKDHRpbWVzdGFt",
						"cF9tcxgDIAEoBBrCCAoMSXRlbVRlbXBsYXRlEhMKC3RlbXBsYXRlX2lkGAEg",
						"ASgJEkUKEHBva2Vtb25fc2V0dGluZ3MYAiABKAsyKy5QT0dPUHJvdG9zLlNl",
						"dHRpbmdzLk1hc3Rlci5Qb2tlbW9uU2V0dGluZ3MSPwoNaXRlbV9zZXR0aW5n",
						"cxgDIAEoCzIoLlBPR09Qcm90b3MuU2V0dGluZ3MuTWFzdGVyLkl0ZW1TZXR0",
						"aW5ncxI/Cg1tb3ZlX3NldHRpbmdzGAQgASgLMiguUE9HT1Byb3Rvcy5TZXR0",
						"aW5ncy5NYXN0ZXIuTW92ZVNldHRpbmdzElAKFm1vdmVfc2VxdWVuY2Vfc2V0",
						"dGluZ3MYBSABKAsyMC5QT0dPUHJvdG9zLlNldHRpbmdzLk1hc3Rlci5Nb3Zl",
						"U2VxdWVuY2VTZXR0aW5ncxJJCg50eXBlX2VmZmVjdGl2ZRgIIAEoCzIxLlBP",
						"R09Qcm90b3MuU2V0dGluZ3MuTWFzdGVyLlR5cGVFZmZlY3RpdmVTZXR0aW5n",
						"cxJBCg5iYWRnZV9zZXR0aW5ncxgKIAEoCzIpLlBPR09Qcm90b3MuU2V0dGlu",
						"Z3MuTWFzdGVyLkJhZGdlU2V0dGluZ3MSOgoGY2FtZXJhGAsgASgLMiouUE9H",
						"T1Byb3Rvcy5TZXR0aW5ncy5NYXN0ZXIuQ2FtZXJhU2V0dGluZ3MSRQoMcGxh",
						"eWVyX2xldmVsGAwgASgLMi8uUE9HT1Byb3Rvcy5TZXR0aW5ncy5NYXN0ZXIu",
						"UGxheWVyTGV2ZWxTZXR0aW5ncxI/CglneW1fbGV2ZWwYDSABKAsyLC5QT0dP",
						"UHJvdG9zLlNldHRpbmdzLk1hc3Rlci5HeW1MZXZlbFNldHRpbmdzEkYKD2Jh",
						"dHRsZV9zZXR0aW5ncxgOIAEoCzItLlBPR09Qcm90b3MuU2V0dGluZ3MuTWFz",
						"dGVyLkd5bUJhdHRsZVNldHRpbmdzEkkKEmVuY291bnRlcl9zZXR0aW5ncxgP",
						"IAEoCzItLlBPR09Qcm90b3MuU2V0dGluZ3MuTWFzdGVyLkVuY291bnRlclNl",
						"dHRpbmdzEkQKEGlhcF9pdGVtX2Rpc3BsYXkYECABKAsyKi5QT0dPUHJvdG9z",
						"LlNldHRpbmdzLk1hc3Rlci5JYXBJdGVtRGlzcGxheRI9CgxpYXBfc2V0dGlu",
						"Z3MYESABKAsyJy5QT0dPUHJvdG9zLlNldHRpbmdzLk1hc3Rlci5JYXBTZXR0",
						"aW5ncxJMChBwb2tlbW9uX3VwZ3JhZGVzGBIgASgLMjIuUE9HT1Byb3Rvcy5T",
						"ZXR0aW5ncy5NYXN0ZXIuUG9rZW1vblVwZ3JhZGVTZXR0aW5ncxJKCg9lcXVp",
						"cHBlZF9iYWRnZXMYEyABKAsyMS5QT0dPUHJvdG9zLlNldHRpbmdzLk1hc3Rl",
						"ci5FcXVpcHBlZEJhZGdlU2V0dGluZ3NiBnByb3RvMw=="));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new[]
				{
					global::POGOProtos.Settings.Master.ItemSettingsReflection.Descriptor,
					global::POGOProtos.Settings.Master.MoveSettingsReflection.Descriptor,
					global::POGOProtos.Settings.Master.BadgeSettingsReflection.Descriptor,
					global::POGOProtos.Settings.Master.PokemonSettingsReflection.Descriptor,
					global::POGOProtos.Settings.Master.MoveSequenceSettingsReflection.Descriptor,
					global::POGOProtos.Settings.Master.TypeEffectiveSettingsReflection.Descriptor,
					global::POGOProtos.Settings.Master.CameraSettingsReflection.Descriptor,
					global::POGOProtos.Settings.Master.PlayerLevelSettingsReflection.Descriptor,
					global::POGOProtos.Settings.Master.GymLevelSettingsReflection.Descriptor,
					global::POGOProtos.Settings.Master.GymBattleSettingsReflection.Descriptor,
					global::POGOProtos.Settings.Master.EncounterSettingsReflection.Descriptor,
					global::POGOProtos.Settings.Master.IapItemDisplayReflection.Descriptor,
					global::POGOProtos.Settings.Master.IapSettingsReflection.Descriptor,
					global::POGOProtos.Settings.Master.PokemonUpgradeSettingsReflection.Descriptor,
					global::POGOProtos.Settings.Master.EquippedBadgeSettingsReflection.Descriptor,
				},
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Networking.Responses.DownloadItemTemplatesResponse),
							global::POGOProtos.Networking.Responses.DownloadItemTemplatesResponse.Parser,
							new[] { "Success", "ItemTemplates", "TimestampMs" },
							null,
							null,
							new[]
							{
								new pbr::GeneratedClrTypeInfo(
									typeof(global::POGOProtos.Networking.Responses.DownloadItemTemplatesResponse.Types.ItemTemplate),
									global::POGOProtos.Networking.Responses.DownloadItemTemplatesResponse.Types.ItemTemplate.Parser,
									new[]
									{
										"TemplateId", "PokemonSettings", "ItemSettings", "MoveSettings", "MoveSequenceSettings", "TypeEffective",
										"BadgeSettings", "Camera", "PlayerLevel", "GymLevel", "BattleSettings", "EncounterSettings", "IapItemDisplay",
										"IapSettings", "PokemonUpgrades", "EquippedBadges"
									},
									null,
									null,
									null)
							})
					}));
		}

		#endregion
	}

	#region Messages

	/// <summary>
	/// The download item templates response.
	/// </summary>
	public sealed partial class DownloadItemTemplatesResponse : pb::IMessage<DownloadItemTemplatesResponse>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "success" field.</summary>
		public const int SuccessFieldNumber = 1;

		/// <summary>Field number for the "item_templates" field.</summary>
		public const int ItemTemplatesFieldNumber = 2;

		/// <summary>Field number for the "timestamp_ms" field.</summary>
		public const int TimestampMsFieldNumber = 3;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<DownloadItemTemplatesResponse> _parser =
			new pb::MessageParser<DownloadItemTemplatesResponse>(() => new DownloadItemTemplatesResponse());

		/// <summary>
		/// The _repeated_item templates_codec.
		/// </summary>
		private static readonly pb.FieldCodec<Types.ItemTemplate> _repeated_itemTemplates_codec = pb::FieldCodec.ForMessage(
			18,
			global::POGOProtos.Networking.Responses.DownloadItemTemplatesResponse.Types.ItemTemplate.Parser);

		#endregion

		#region  Fields

		/// <summary>
		/// The item templates_.
		/// </summary>
		private readonly pbc.RepeatedField<Types.ItemTemplate> itemTemplates_ = new pbc::RepeatedField<Types.ItemTemplate>();

		/// <summary>
		/// The success_.
		/// </summary>
		private bool success_;

		/// <summary>
		/// The timestamp ms_.
		/// </summary>
		private ulong timestampMs_;

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="DownloadItemTemplatesResponse"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public DownloadItemTemplatesResponse()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="DownloadItemTemplatesResponse"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public DownloadItemTemplatesResponse(DownloadItemTemplatesResponse other) : this()
		{
			success_ = other.success_;
			itemTemplates_ = other.itemTemplates_.Clone();
			timestampMs_ = other.timestampMs_;
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<DownloadItemTemplatesResponse> Parser
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
				return global::POGOProtos.Networking.Responses.DownloadItemTemplatesResponseReflection.Descriptor.MessageTypes[0];
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
		/// Gets or sets a value indicating whether success.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public bool Success
		{
			get
			{
				return success_;
			}

			set
			{
				success_ = value;
			}
		}

		/// <summary>
		/// Gets the item templates.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public pbc.RepeatedField<Types.ItemTemplate> ItemTemplates
		{
			get
			{
				return itemTemplates_;
			}
		}

		/// <summary>
		/// Gets or sets the timestamp ms.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public ulong TimestampMs
		{
			get
			{
				return timestampMs_;
			}

			set
			{
				timestampMs_ = value;
			}
		}

		#endregion

		#region  Interface Implementations

		/// <summary>
		/// The clone.
		/// </summary>
		/// <returns>
		/// The <see cref="DownloadItemTemplatesResponse"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public DownloadItemTemplatesResponse Clone()
		{
			return new DownloadItemTemplatesResponse(this);
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
		public bool Equals(DownloadItemTemplatesResponse other)
		{
			if (ReferenceEquals(other, null))
			{
				return false;
			}

			if (ReferenceEquals(other, this))
			{
				return true;
			}

			if (Success != other.Success)
			{
				return false;
			}

			if (!itemTemplates_.Equals(other.itemTemplates_))
			{
				return false;
			}

			if (TimestampMs != other.TimestampMs)
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
			if (Success != false)
			{
				output.WriteRawTag(8);
				output.WriteBool(Success);
			}

			itemTemplates_.WriteTo(output, _repeated_itemTemplates_codec);
			if (TimestampMs != 0UL)
			{
				output.WriteRawTag(24);
				output.WriteUInt64(TimestampMs);
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
			if (Success != false)
			{
				size += 1 + 1;
			}

			size += itemTemplates_.CalculateSize(_repeated_itemTemplates_codec);
			if (TimestampMs != 0UL)
			{
				size += 1 + pb::CodedOutputStream.ComputeUInt64Size(TimestampMs);
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
		public void MergeFrom(DownloadItemTemplatesResponse other)
		{
			if (other == null)
			{
				return;
			}

			if (other.Success != false)
			{
				Success = other.Success;
			}

			itemTemplates_.Add(other.itemTemplates_);
			if (other.TimestampMs != 0UL)
			{
				TimestampMs = other.TimestampMs;
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
					case 8:
					{
						Success = input.ReadBool();
						break;
					}

					case 18:
					{
						itemTemplates_.AddEntriesFrom(input, _repeated_itemTemplates_codec);
						break;
					}

					case 24:
					{
						TimestampMs = input.ReadUInt64();
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
			return Equals(other as DownloadItemTemplatesResponse);
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
			if (Success != false)
			{
				hash ^= Success.GetHashCode();
			}

			hash ^= itemTemplates_.GetHashCode();
			if (TimestampMs != 0UL)
			{
				hash ^= TimestampMs.GetHashCode();
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

		#region Nested types

		/// <summary>Container for nested types declared in the DownloadItemTemplatesResponse message type.</summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static partial class Types
		{
			/// <summary>
			/// The item template.
			/// </summary>
			public sealed partial class ItemTemplate : pb::IMessage<ItemTemplate>
			{
				#region Static Fields and Constants

				/// <summary>Field number for the "template_id" field.</summary>
				public const int TemplateIdFieldNumber = 1;

				/// <summary>Field number for the "pokemon_settings" field.</summary>
				public const int PokemonSettingsFieldNumber = 2;

				/// <summary>Field number for the "item_settings" field.</summary>
				public const int ItemSettingsFieldNumber = 3;

				/// <summary>Field number for the "move_settings" field.</summary>
				public const int MoveSettingsFieldNumber = 4;

				/// <summary>Field number for the "move_sequence_settings" field.</summary>
				public const int MoveSequenceSettingsFieldNumber = 5;

				/// <summary>Field number for the "type_effective" field.</summary>
				public const int TypeEffectiveFieldNumber = 8;

				/// <summary>Field number for the "badge_settings" field.</summary>
				public const int BadgeSettingsFieldNumber = 10;

				/// <summary>Field number for the "camera" field.</summary>
				public const int CameraFieldNumber = 11;

				/// <summary>Field number for the "player_level" field.</summary>
				public const int PlayerLevelFieldNumber = 12;

				/// <summary>Field number for the "gym_level" field.</summary>
				public const int GymLevelFieldNumber = 13;

				/// <summary>Field number for the "battle_settings" field.</summary>
				public const int BattleSettingsFieldNumber = 14;

				/// <summary>Field number for the "encounter_settings" field.</summary>
				public const int EncounterSettingsFieldNumber = 15;

				/// <summary>Field number for the "iap_item_display" field.</summary>
				public const int IapItemDisplayFieldNumber = 16;

				/// <summary>Field number for the "iap_settings" field.</summary>
				public const int IapSettingsFieldNumber = 17;

				/// <summary>Field number for the "pokemon_upgrades" field.</summary>
				public const int PokemonUpgradesFieldNumber = 18;

				/// <summary>Field number for the "equipped_badges" field.</summary>
				public const int EquippedBadgesFieldNumber = 19;

				/// <summary>
				/// The _parser.
				/// </summary>
				private static readonly pb.MessageParser<ItemTemplate> _parser =
					new pb::MessageParser<ItemTemplate>(() => new ItemTemplate());

				#endregion

				#region  Fields

				/// <summary>
				/// The badge settings_.
				/// </summary>
				private BadgeSettings badgeSettings_;

				/// <summary>
				/// The battle settings_.
				/// </summary>
				private GymBattleSettings battleSettings_;

				/// <summary>
				/// The camera_.
				/// </summary>
				private CameraSettings camera_;

				/// <summary>
				/// The encounter settings_.
				/// </summary>
				private EncounterSettings encounterSettings_;

				/// <summary>
				/// The equipped badges_.
				/// </summary>
				private EquippedBadgeSettings equippedBadges_;

				/// <summary>
				/// The gym level_.
				/// </summary>
				private GymLevelSettings gymLevel_;

				/// <summary>
				/// The iap item display_.
				/// </summary>
				private IapItemDisplay iapItemDisplay_;

				/// <summary>
				/// The iap settings_.
				/// </summary>
				private IapSettings iapSettings_;

				/// <summary>
				/// The item settings_.
				/// </summary>
				private ItemSettings itemSettings_;

				/// <summary>
				/// The move sequence settings_.
				/// </summary>
				private MoveSequenceSettings moveSequenceSettings_;

				/// <summary>
				/// The move settings_.
				/// </summary>
				private MoveSettings moveSettings_;

				/// <summary>
				/// The player level_.
				/// </summary>
				private PlayerLevelSettings playerLevel_;

				/// <summary>
				/// The pokemon settings_.
				/// </summary>
				private PokemonSettings pokemonSettings_;

				/// <summary>
				/// The pokemon upgrades_.
				/// </summary>
				private PokemonUpgradeSettings pokemonUpgrades_;

				/// <summary>
				/// The template id_.
				/// </summary>
				private string templateId_ = string.Empty;

				/// <summary>
				/// The type effective_.
				/// </summary>
				private TypeEffectiveSettings typeEffective_;

				#endregion

				#region  Constructors

				/// <summary>
				/// Initializes a new instance of the <see cref="ItemTemplate"/> class.
				/// </summary>
				[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
				public ItemTemplate()
				{
					OnConstruction();
				}

				/// <summary>
				/// Initializes a new instance of the <see cref="ItemTemplate"/> class.
				/// </summary>
				/// <param name="other">
				/// The other.
				/// </param>
				[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
				public ItemTemplate(ItemTemplate other) : this()
				{
					templateId_ = other.templateId_;
					PokemonSettings = other.pokemonSettings_ != null ? other.PokemonSettings.Clone() : null;
					ItemSettings = other.itemSettings_ != null ? other.ItemSettings.Clone() : null;
					MoveSettings = other.moveSettings_ != null ? other.MoveSettings.Clone() : null;
					MoveSequenceSettings = other.moveSequenceSettings_ != null ? other.MoveSequenceSettings.Clone() : null;
					TypeEffective = other.typeEffective_ != null ? other.TypeEffective.Clone() : null;
					BadgeSettings = other.badgeSettings_ != null ? other.BadgeSettings.Clone() : null;
					Camera = other.camera_ != null ? other.Camera.Clone() : null;
					PlayerLevel = other.playerLevel_ != null ? other.PlayerLevel.Clone() : null;
					GymLevel = other.gymLevel_ != null ? other.GymLevel.Clone() : null;
					BattleSettings = other.battleSettings_ != null ? other.BattleSettings.Clone() : null;
					EncounterSettings = other.encounterSettings_ != null ? other.EncounterSettings.Clone() : null;
					IapItemDisplay = other.iapItemDisplay_ != null ? other.IapItemDisplay.Clone() : null;
					IapSettings = other.iapSettings_ != null ? other.IapSettings.Clone() : null;
					PokemonUpgrades = other.pokemonUpgrades_ != null ? other.PokemonUpgrades.Clone() : null;
					EquippedBadges = other.equippedBadges_ != null ? other.EquippedBadges.Clone() : null;
				}

				#endregion

				#region  Properties - Public

				/// <summary>
				/// Gets the parser.
				/// </summary>
				[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
				public static pb.MessageParser<ItemTemplate> Parser
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
						return global::POGOProtos.Networking.Responses.DownloadItemTemplatesResponse.Descriptor.NestedTypes[0];
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
				/// Gets or sets the template id.
				/// </summary>
				[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
				public string TemplateId
				{
					get
					{
						return templateId_;
					}

					set
					{
						templateId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
					}
				}

				/// <summary>
				/// Gets or sets the pokemon settings.
				/// </summary>
				[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
				public PokemonSettings PokemonSettings
				{
					get
					{
						return pokemonSettings_;
					}

					set
					{
						pokemonSettings_ = value;
					}
				}

				/// <summary>
				/// Gets or sets the item settings.
				/// </summary>
				[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
				public ItemSettings ItemSettings
				{
					get
					{
						return itemSettings_;
					}

					set
					{
						itemSettings_ = value;
					}
				}

				/// <summary>
				/// Gets or sets the move settings.
				/// </summary>
				[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
				public MoveSettings MoveSettings
				{
					get
					{
						return moveSettings_;
					}

					set
					{
						moveSettings_ = value;
					}
				}

				/// <summary>
				/// Gets or sets the move sequence settings.
				/// </summary>
				[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
				public MoveSequenceSettings MoveSequenceSettings
				{
					get
					{
						return moveSequenceSettings_;
					}

					set
					{
						moveSequenceSettings_ = value;
					}
				}

				/// <summary>
				/// Gets or sets the type effective.
				/// </summary>
				[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
				public TypeEffectiveSettings TypeEffective
				{
					get
					{
						return typeEffective_;
					}

					set
					{
						typeEffective_ = value;
					}
				}

				/// <summary>
				/// Gets or sets the badge settings.
				/// </summary>
				[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
				public BadgeSettings BadgeSettings
				{
					get
					{
						return badgeSettings_;
					}

					set
					{
						badgeSettings_ = value;
					}
				}

				/// <summary>
				/// Gets or sets the camera.
				/// </summary>
				[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
				public CameraSettings Camera
				{
					get
					{
						return camera_;
					}

					set
					{
						camera_ = value;
					}
				}

				/// <summary>
				/// Gets or sets the player level.
				/// </summary>
				[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
				public PlayerLevelSettings PlayerLevel
				{
					get
					{
						return playerLevel_;
					}

					set
					{
						playerLevel_ = value;
					}
				}

				/// <summary>
				/// Gets or sets the gym level.
				/// </summary>
				[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
				public GymLevelSettings GymLevel
				{
					get
					{
						return gymLevel_;
					}

					set
					{
						gymLevel_ = value;
					}
				}

				/// <summary>
				/// Gets or sets the battle settings.
				/// </summary>
				[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
				public GymBattleSettings BattleSettings
				{
					get
					{
						return battleSettings_;
					}

					set
					{
						battleSettings_ = value;
					}
				}

				/// <summary>
				/// Gets or sets the encounter settings.
				/// </summary>
				[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
				public EncounterSettings EncounterSettings
				{
					get
					{
						return encounterSettings_;
					}

					set
					{
						encounterSettings_ = value;
					}
				}

				/// <summary>
				/// Gets or sets the iap item display.
				/// </summary>
				[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
				public IapItemDisplay IapItemDisplay
				{
					get
					{
						return iapItemDisplay_;
					}

					set
					{
						iapItemDisplay_ = value;
					}
				}

				/// <summary>
				/// Gets or sets the iap settings.
				/// </summary>
				[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
				public IapSettings IapSettings
				{
					get
					{
						return iapSettings_;
					}

					set
					{
						iapSettings_ = value;
					}
				}

				/// <summary>
				/// Gets or sets the pokemon upgrades.
				/// </summary>
				[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
				public PokemonUpgradeSettings PokemonUpgrades
				{
					get
					{
						return pokemonUpgrades_;
					}

					set
					{
						pokemonUpgrades_ = value;
					}
				}

				/// <summary>
				/// Gets or sets the equipped badges.
				/// </summary>
				[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
				public EquippedBadgeSettings EquippedBadges
				{
					get
					{
						return equippedBadges_;
					}

					set
					{
						equippedBadges_ = value;
					}
				}

				#endregion

				#region  Interface Implementations

				/// <summary>
				/// The clone.
				/// </summary>
				/// <returns>
				/// The <see cref="ItemTemplate"/>.
				/// </returns>
				[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
				public ItemTemplate Clone()
				{
					return new ItemTemplate(this);
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
				public bool Equals(ItemTemplate other)
				{
					if (ReferenceEquals(other, null))
					{
						return false;
					}

					if (ReferenceEquals(other, this))
					{
						return true;
					}

					if (TemplateId != other.TemplateId)
					{
						return false;
					}

					if (!object.Equals(PokemonSettings, other.PokemonSettings))
					{
						return false;
					}

					if (!object.Equals(ItemSettings, other.ItemSettings))
					{
						return false;
					}

					if (!object.Equals(MoveSettings, other.MoveSettings))
					{
						return false;
					}

					if (!object.Equals(MoveSequenceSettings, other.MoveSequenceSettings))
					{
						return false;
					}

					if (!object.Equals(TypeEffective, other.TypeEffective))
					{
						return false;
					}

					if (!object.Equals(BadgeSettings, other.BadgeSettings))
					{
						return false;
					}

					if (!object.Equals(Camera, other.Camera))
					{
						return false;
					}

					if (!object.Equals(PlayerLevel, other.PlayerLevel))
					{
						return false;
					}

					if (!object.Equals(GymLevel, other.GymLevel))
					{
						return false;
					}

					if (!object.Equals(BattleSettings, other.BattleSettings))
					{
						return false;
					}

					if (!object.Equals(EncounterSettings, other.EncounterSettings))
					{
						return false;
					}

					if (!object.Equals(IapItemDisplay, other.IapItemDisplay))
					{
						return false;
					}

					if (!object.Equals(IapSettings, other.IapSettings))
					{
						return false;
					}

					if (!object.Equals(PokemonUpgrades, other.PokemonUpgrades))
					{
						return false;
					}

					if (!object.Equals(EquippedBadges, other.EquippedBadges))
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
					if (TemplateId.Length != 0)
					{
						output.WriteRawTag(10);
						output.WriteString(TemplateId);
					}

					if (pokemonSettings_ != null)
					{
						output.WriteRawTag(18);
						output.WriteMessage(PokemonSettings);
					}

					if (itemSettings_ != null)
					{
						output.WriteRawTag(26);
						output.WriteMessage(ItemSettings);
					}

					if (moveSettings_ != null)
					{
						output.WriteRawTag(34);
						output.WriteMessage(MoveSettings);
					}

					if (moveSequenceSettings_ != null)
					{
						output.WriteRawTag(42);
						output.WriteMessage(MoveSequenceSettings);
					}

					if (typeEffective_ != null)
					{
						output.WriteRawTag(66);
						output.WriteMessage(TypeEffective);
					}

					if (badgeSettings_ != null)
					{
						output.WriteRawTag(82);
						output.WriteMessage(BadgeSettings);
					}

					if (camera_ != null)
					{
						output.WriteRawTag(90);
						output.WriteMessage(Camera);
					}

					if (playerLevel_ != null)
					{
						output.WriteRawTag(98);
						output.WriteMessage(PlayerLevel);
					}

					if (gymLevel_ != null)
					{
						output.WriteRawTag(106);
						output.WriteMessage(GymLevel);
					}

					if (battleSettings_ != null)
					{
						output.WriteRawTag(114);
						output.WriteMessage(BattleSettings);
					}

					if (encounterSettings_ != null)
					{
						output.WriteRawTag(122);
						output.WriteMessage(EncounterSettings);
					}

					if (iapItemDisplay_ != null)
					{
						output.WriteRawTag(130, 1);
						output.WriteMessage(IapItemDisplay);
					}

					if (iapSettings_ != null)
					{
						output.WriteRawTag(138, 1);
						output.WriteMessage(IapSettings);
					}

					if (pokemonUpgrades_ != null)
					{
						output.WriteRawTag(146, 1);
						output.WriteMessage(PokemonUpgrades);
					}

					if (equippedBadges_ != null)
					{
						output.WriteRawTag(154, 1);
						output.WriteMessage(EquippedBadges);
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
					if (TemplateId.Length != 0)
					{
						size += 1 + pb::CodedOutputStream.ComputeStringSize(TemplateId);
					}

					if (pokemonSettings_ != null)
					{
						size += 1 + pb::CodedOutputStream.ComputeMessageSize(PokemonSettings);
					}

					if (itemSettings_ != null)
					{
						size += 1 + pb::CodedOutputStream.ComputeMessageSize(ItemSettings);
					}

					if (moveSettings_ != null)
					{
						size += 1 + pb::CodedOutputStream.ComputeMessageSize(MoveSettings);
					}

					if (moveSequenceSettings_ != null)
					{
						size += 1 + pb::CodedOutputStream.ComputeMessageSize(MoveSequenceSettings);
					}

					if (typeEffective_ != null)
					{
						size += 1 + pb::CodedOutputStream.ComputeMessageSize(TypeEffective);
					}

					if (badgeSettings_ != null)
					{
						size += 1 + pb::CodedOutputStream.ComputeMessageSize(BadgeSettings);
					}

					if (camera_ != null)
					{
						size += 1 + pb::CodedOutputStream.ComputeMessageSize(Camera);
					}

					if (playerLevel_ != null)
					{
						size += 1 + pb::CodedOutputStream.ComputeMessageSize(PlayerLevel);
					}

					if (gymLevel_ != null)
					{
						size += 1 + pb::CodedOutputStream.ComputeMessageSize(GymLevel);
					}

					if (battleSettings_ != null)
					{
						size += 1 + pb::CodedOutputStream.ComputeMessageSize(BattleSettings);
					}

					if (encounterSettings_ != null)
					{
						size += 1 + pb::CodedOutputStream.ComputeMessageSize(EncounterSettings);
					}

					if (iapItemDisplay_ != null)
					{
						size += 2 + pb::CodedOutputStream.ComputeMessageSize(IapItemDisplay);
					}

					if (iapSettings_ != null)
					{
						size += 2 + pb::CodedOutputStream.ComputeMessageSize(IapSettings);
					}

					if (pokemonUpgrades_ != null)
					{
						size += 2 + pb::CodedOutputStream.ComputeMessageSize(PokemonUpgrades);
					}

					if (equippedBadges_ != null)
					{
						size += 2 + pb::CodedOutputStream.ComputeMessageSize(EquippedBadges);
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
				public void MergeFrom(ItemTemplate other)
				{
					if (other == null)
					{
						return;
					}

					if (other.TemplateId.Length != 0)
					{
						TemplateId = other.TemplateId;
					}

					if (other.pokemonSettings_ != null)
					{
						if (pokemonSettings_ == null)
						{
							pokemonSettings_ = new global::POGOProtos.Settings.Master.PokemonSettings();
						}

						PokemonSettings.MergeFrom(other.PokemonSettings);
					}

					if (other.itemSettings_ != null)
					{
						if (itemSettings_ == null)
						{
							itemSettings_ = new global::POGOProtos.Settings.Master.ItemSettings();
						}

						ItemSettings.MergeFrom(other.ItemSettings);
					}

					if (other.moveSettings_ != null)
					{
						if (moveSettings_ == null)
						{
							moveSettings_ = new global::POGOProtos.Settings.Master.MoveSettings();
						}

						MoveSettings.MergeFrom(other.MoveSettings);
					}

					if (other.moveSequenceSettings_ != null)
					{
						if (moveSequenceSettings_ == null)
						{
							moveSequenceSettings_ = new global::POGOProtos.Settings.Master.MoveSequenceSettings();
						}

						MoveSequenceSettings.MergeFrom(other.MoveSequenceSettings);
					}

					if (other.typeEffective_ != null)
					{
						if (typeEffective_ == null)
						{
							typeEffective_ = new global::POGOProtos.Settings.Master.TypeEffectiveSettings();
						}

						TypeEffective.MergeFrom(other.TypeEffective);
					}

					if (other.badgeSettings_ != null)
					{
						if (badgeSettings_ == null)
						{
							badgeSettings_ = new global::POGOProtos.Settings.Master.BadgeSettings();
						}

						BadgeSettings.MergeFrom(other.BadgeSettings);
					}

					if (other.camera_ != null)
					{
						if (camera_ == null)
						{
							camera_ = new global::POGOProtos.Settings.Master.CameraSettings();
						}

						Camera.MergeFrom(other.Camera);
					}

					if (other.playerLevel_ != null)
					{
						if (playerLevel_ == null)
						{
							playerLevel_ = new global::POGOProtos.Settings.Master.PlayerLevelSettings();
						}

						PlayerLevel.MergeFrom(other.PlayerLevel);
					}

					if (other.gymLevel_ != null)
					{
						if (gymLevel_ == null)
						{
							gymLevel_ = new global::POGOProtos.Settings.Master.GymLevelSettings();
						}

						GymLevel.MergeFrom(other.GymLevel);
					}

					if (other.battleSettings_ != null)
					{
						if (battleSettings_ == null)
						{
							battleSettings_ = new global::POGOProtos.Settings.Master.GymBattleSettings();
						}

						BattleSettings.MergeFrom(other.BattleSettings);
					}

					if (other.encounterSettings_ != null)
					{
						if (encounterSettings_ == null)
						{
							encounterSettings_ = new global::POGOProtos.Settings.Master.EncounterSettings();
						}

						EncounterSettings.MergeFrom(other.EncounterSettings);
					}

					if (other.iapItemDisplay_ != null)
					{
						if (iapItemDisplay_ == null)
						{
							iapItemDisplay_ = new global::POGOProtos.Settings.Master.IapItemDisplay();
						}

						IapItemDisplay.MergeFrom(other.IapItemDisplay);
					}

					if (other.iapSettings_ != null)
					{
						if (iapSettings_ == null)
						{
							iapSettings_ = new global::POGOProtos.Settings.Master.IapSettings();
						}

						IapSettings.MergeFrom(other.IapSettings);
					}

					if (other.pokemonUpgrades_ != null)
					{
						if (pokemonUpgrades_ == null)
						{
							pokemonUpgrades_ = new global::POGOProtos.Settings.Master.PokemonUpgradeSettings();
						}

						PokemonUpgrades.MergeFrom(other.PokemonUpgrades);
					}

					if (other.equippedBadges_ != null)
					{
						if (equippedBadges_ == null)
						{
							equippedBadges_ = new global::POGOProtos.Settings.Master.EquippedBadgeSettings();
						}

						EquippedBadges.MergeFrom(other.EquippedBadges);
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
								TemplateId = input.ReadString();
								break;
							}

							case 18:
							{
								if (pokemonSettings_ == null)
								{
									pokemonSettings_ = new global::POGOProtos.Settings.Master.PokemonSettings();
								}

								input.ReadMessage(pokemonSettings_);
								break;
							}

							case 26:
							{
								if (itemSettings_ == null)
								{
									itemSettings_ = new global::POGOProtos.Settings.Master.ItemSettings();
								}

								input.ReadMessage(itemSettings_);
								break;
							}

							case 34:
							{
								if (moveSettings_ == null)
								{
									moveSettings_ = new global::POGOProtos.Settings.Master.MoveSettings();
								}

								input.ReadMessage(moveSettings_);
								break;
							}

							case 42:
							{
								if (moveSequenceSettings_ == null)
								{
									moveSequenceSettings_ = new global::POGOProtos.Settings.Master.MoveSequenceSettings();
								}

								input.ReadMessage(moveSequenceSettings_);
								break;
							}

							case 66:
							{
								if (typeEffective_ == null)
								{
									typeEffective_ = new global::POGOProtos.Settings.Master.TypeEffectiveSettings();
								}

								input.ReadMessage(typeEffective_);
								break;
							}

							case 82:
							{
								if (badgeSettings_ == null)
								{
									badgeSettings_ = new global::POGOProtos.Settings.Master.BadgeSettings();
								}

								input.ReadMessage(badgeSettings_);
								break;
							}

							case 90:
							{
								if (camera_ == null)
								{
									camera_ = new global::POGOProtos.Settings.Master.CameraSettings();
								}

								input.ReadMessage(camera_);
								break;
							}

							case 98:
							{
								if (playerLevel_ == null)
								{
									playerLevel_ = new global::POGOProtos.Settings.Master.PlayerLevelSettings();
								}

								input.ReadMessage(playerLevel_);
								break;
							}

							case 106:
							{
								if (gymLevel_ == null)
								{
									gymLevel_ = new global::POGOProtos.Settings.Master.GymLevelSettings();
								}

								input.ReadMessage(gymLevel_);
								break;
							}

							case 114:
							{
								if (battleSettings_ == null)
								{
									battleSettings_ = new global::POGOProtos.Settings.Master.GymBattleSettings();
								}

								input.ReadMessage(battleSettings_);
								break;
							}

							case 122:
							{
								if (encounterSettings_ == null)
								{
									encounterSettings_ = new global::POGOProtos.Settings.Master.EncounterSettings();
								}

								input.ReadMessage(encounterSettings_);
								break;
							}

							case 130:
							{
								if (iapItemDisplay_ == null)
								{
									iapItemDisplay_ = new global::POGOProtos.Settings.Master.IapItemDisplay();
								}

								input.ReadMessage(iapItemDisplay_);
								break;
							}

							case 138:
							{
								if (iapSettings_ == null)
								{
									iapSettings_ = new global::POGOProtos.Settings.Master.IapSettings();
								}

								input.ReadMessage(iapSettings_);
								break;
							}

							case 146:
							{
								if (pokemonUpgrades_ == null)
								{
									pokemonUpgrades_ = new global::POGOProtos.Settings.Master.PokemonUpgradeSettings();
								}

								input.ReadMessage(pokemonUpgrades_);
								break;
							}

							case 154:
							{
								if (equippedBadges_ == null)
								{
									equippedBadges_ = new global::POGOProtos.Settings.Master.EquippedBadgeSettings();
								}

								input.ReadMessage(equippedBadges_);
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
					return Equals(other as ItemTemplate);
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
					if (TemplateId.Length != 0)
					{
						hash ^= TemplateId.GetHashCode();
					}

					if (pokemonSettings_ != null)
					{
						hash ^= PokemonSettings.GetHashCode();
					}

					if (itemSettings_ != null)
					{
						hash ^= ItemSettings.GetHashCode();
					}

					if (moveSettings_ != null)
					{
						hash ^= MoveSettings.GetHashCode();
					}

					if (moveSequenceSettings_ != null)
					{
						hash ^= MoveSequenceSettings.GetHashCode();
					}

					if (typeEffective_ != null)
					{
						hash ^= TypeEffective.GetHashCode();
					}

					if (badgeSettings_ != null)
					{
						hash ^= BadgeSettings.GetHashCode();
					}

					if (camera_ != null)
					{
						hash ^= Camera.GetHashCode();
					}

					if (playerLevel_ != null)
					{
						hash ^= PlayerLevel.GetHashCode();
					}

					if (gymLevel_ != null)
					{
						hash ^= GymLevel.GetHashCode();
					}

					if (battleSettings_ != null)
					{
						hash ^= BattleSettings.GetHashCode();
					}

					if (encounterSettings_ != null)
					{
						hash ^= EncounterSettings.GetHashCode();
					}

					if (iapItemDisplay_ != null)
					{
						hash ^= IapItemDisplay.GetHashCode();
					}

					if (iapSettings_ != null)
					{
						hash ^= IapSettings.GetHashCode();
					}

					if (pokemonUpgrades_ != null)
					{
						hash ^= PokemonUpgrades.GetHashCode();
					}

					if (equippedBadges_ != null)
					{
						hash ^= EquippedBadges.GetHashCode();
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
		}

		#endregion
	}

	#endregion
}

#endregion Designer generated code