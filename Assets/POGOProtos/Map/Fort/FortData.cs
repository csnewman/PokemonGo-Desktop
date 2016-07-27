// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FortData.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Map/Fort/FortData.proto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

#pragma warning disable 1591, 0612, 3021

#region Designer generated code

using POGOProtos.Enums;
using pb = Google.Protobuf;
using pbc = Google.Protobuf.Collections;
using pbr = Google.Protobuf.Reflection;
using scg = System.Collections.Generic;

namespace POGOProtos.Map.Fort
{
	/// <summary>Holder for reflection information generated from POGOProtos/Map/Fort/FortData.proto</summary>
	public static partial class FortDataReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Map/Fort/FortData.proto</summary>
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
		/// Initializes static members of the <see cref="FortDataReflection"/> class.
		/// </summary>
		static FortDataReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CiJQT0dPUHJvdG9zL01hcC9Gb3J0L0ZvcnREYXRhLnByb3RvEhNQT0dPUHJv",
						"dG9zLk1hcC5Gb3J0GiBQT0dPUHJvdG9zL0VudW1zL1Bva2Vtb25JZC5wcm90",
						"bxogUE9HT1Byb3Rvcy9FbnVtcy9UZWFtQ29sb3IucHJvdG8aIlBPR09Qcm90",
						"b3MvTWFwL0ZvcnQvRm9ydFR5cGUucHJvdG8aJVBPR09Qcm90b3MvTWFwL0Zv",
						"cnQvRm9ydFNwb25zb3IucHJvdG8aK1BPR09Qcm90b3MvTWFwL0ZvcnQvRm9y",
						"dFJlbmRlcmluZ1R5cGUucHJvdG8aJlBPR09Qcm90b3MvTWFwL0ZvcnQvRm9y",
						"dEx1cmVJbmZvLnByb3RvIrsECghGb3J0RGF0YRIKCgJpZBgBIAEoCRIiChps",
						"YXN0X21vZGlmaWVkX3RpbWVzdGFtcF9tcxgCIAEoAxIQCghsYXRpdHVkZRgD",
						"IAEoARIRCglsb25naXR1ZGUYBCABKAESDwoHZW5hYmxlZBgIIAEoCBIrCgR0",
						"eXBlGAkgASgOMh0uUE9HT1Byb3Rvcy5NYXAuRm9ydC5Gb3J0VHlwZRIyCg1v",
						"d25lZF9ieV90ZWFtGAUgASgOMhsuUE9HT1Byb3Rvcy5FbnVtcy5UZWFtQ29s",
						"b3ISNQoQZ3VhcmRfcG9rZW1vbl9pZBgGIAEoDjIbLlBPR09Qcm90b3MuRW51",
						"bXMuUG9rZW1vbklkEhgKEGd1YXJkX3Bva2Vtb25fY3AYByABKAUSEgoKZ3lt",
						"X3BvaW50cxgKIAEoAxIUCgxpc19pbl9iYXR0bGUYCyABKAgSJgoeY29vbGRv",
						"d25fY29tcGxldGVfdGltZXN0YW1wX21zGA4gASgDEjEKB3Nwb25zb3IYDyAB",
						"KA4yIC5QT0dPUHJvdG9zLk1hcC5Gb3J0LkZvcnRTcG9uc29yEj4KDnJlbmRl",
						"cmluZ190eXBlGBAgASgOMiYuUE9HT1Byb3Rvcy5NYXAuRm9ydC5Gb3J0UmVu",
						"ZGVyaW5nVHlwZRIcChRhY3RpdmVfZm9ydF9tb2RpZmllchgMIAEoDBI0Cgls",
						"dXJlX2luZm8YDSABKAsyIS5QT0dPUHJvdG9zLk1hcC5Gb3J0LkZvcnRMdXJl",
						"SW5mb2IGcHJvdG8z"));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new[]
				{
					global::POGOProtos.Enums.PokemonIdReflection.Descriptor, global::POGOProtos.Enums.TeamColorReflection.Descriptor,
					global::POGOProtos.Map.Fort.FortTypeReflection.Descriptor,
					global::POGOProtos.Map.Fort.FortSponsorReflection.Descriptor,
					global::POGOProtos.Map.Fort.FortRenderingTypeReflection.Descriptor,
					global::POGOProtos.Map.Fort.FortLureInfoReflection.Descriptor,
				},
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Map.Fort.FortData),
							global::POGOProtos.Map.Fort.FortData.Parser,
							new[]
							{
								"Id", "LastModifiedTimestampMs", "Latitude", "Longitude", "Enabled", "Type", "OwnedByTeam", "GuardPokemonId",
								"GuardPokemonCp", "GymPoints", "IsInBattle", "CooldownCompleteTimestampMs", "Sponsor", "RenderingType",
								"ActiveFortModifier", "LureInfo"
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
	/// The fort data.
	/// </summary>
	public sealed partial class FortData : pb::IMessage<FortData>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "id" field.</summary>
		public const int IdFieldNumber = 1;

		/// <summary>Field number for the "last_modified_timestamp_ms" field.</summary>
		public const int LastModifiedTimestampMsFieldNumber = 2;

		/// <summary>Field number for the "latitude" field.</summary>
		public const int LatitudeFieldNumber = 3;

		/// <summary>Field number for the "longitude" field.</summary>
		public const int LongitudeFieldNumber = 4;

		/// <summary>Field number for the "enabled" field.</summary>
		public const int EnabledFieldNumber = 8;

		/// <summary>Field number for the "type" field.</summary>
		public const int TypeFieldNumber = 9;

		/// <summary>Field number for the "owned_by_team" field.</summary>
		public const int OwnedByTeamFieldNumber = 5;

		/// <summary>Field number for the "guard_pokemon_id" field.</summary>
		public const int GuardPokemonIdFieldNumber = 6;

		/// <summary>Field number for the "guard_pokemon_cp" field.</summary>
		public const int GuardPokemonCpFieldNumber = 7;

		/// <summary>Field number for the "gym_points" field.</summary>
		public const int GymPointsFieldNumber = 10;

		/// <summary>Field number for the "is_in_battle" field.</summary>
		public const int IsInBattleFieldNumber = 11;

		/// <summary>Field number for the "cooldown_complete_timestamp_ms" field.</summary>
		public const int CooldownCompleteTimestampMsFieldNumber = 14;

		/// <summary>Field number for the "sponsor" field.</summary>
		public const int SponsorFieldNumber = 15;

		/// <summary>Field number for the "rendering_type" field.</summary>
		public const int RenderingTypeFieldNumber = 16;

		/// <summary>Field number for the "active_fort_modifier" field.</summary>
		public const int ActiveFortModifierFieldNumber = 12;

		/// <summary>Field number for the "lure_info" field.</summary>
		public const int LureInfoFieldNumber = 13;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<FortData> _parser = new pb::MessageParser<FortData>(() => new FortData());

		#endregion

		#region  Fields

		/// <summary>
		/// The active fort modifier_.
		/// </summary>
		private pb.ByteString activeFortModifier_ = pb::ByteString.Empty;

		/// <summary>
		/// The cooldown complete timestamp ms_.
		/// </summary>
		private long cooldownCompleteTimestampMs_;

		/// <summary>
		/// The enabled_.
		/// </summary>
		private bool enabled_;

		/// <summary>
		/// The guard pokemon cp_.
		/// </summary>
		private int guardPokemonCp_;

		/// <summary>
		/// The guard pokemon id_.
		/// </summary>
		private PokemonId guardPokemonId_ = 0;

		/// <summary>
		/// The gym points_.
		/// </summary>
		private long gymPoints_;

		/// <summary>
		/// The id_.
		/// </summary>
		private string id_ = string.Empty;

		/// <summary>
		/// The is in battle_.
		/// </summary>
		private bool isInBattle_;

		/// <summary>
		/// The last modified timestamp ms_.
		/// </summary>
		private long lastModifiedTimestampMs_;

		/// <summary>
		/// The latitude_.
		/// </summary>
		private double latitude_;

		/// <summary>
		/// The longitude_.
		/// </summary>
		private double longitude_;

		/// <summary>
		/// The lure info_.
		/// </summary>
		private FortLureInfo lureInfo_;

		/// <summary>
		/// The owned by team_.
		/// </summary>
		private TeamColor ownedByTeam_ = 0;

		/// <summary>
		/// The rendering type_.
		/// </summary>
		private FortRenderingType renderingType_ = 0;

		/// <summary>
		/// The sponsor_.
		/// </summary>
		private FortSponsor sponsor_ = 0;

		/// <summary>
		/// The type_.
		/// </summary>
		private FortType type_ = 0;

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="FortData"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public FortData()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="FortData"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public FortData(FortData other) : this()
		{
			id_ = other.id_;
			lastModifiedTimestampMs_ = other.lastModifiedTimestampMs_;
			latitude_ = other.latitude_;
			longitude_ = other.longitude_;
			enabled_ = other.enabled_;
			type_ = other.type_;
			ownedByTeam_ = other.ownedByTeam_;
			guardPokemonId_ = other.guardPokemonId_;
			guardPokemonCp_ = other.guardPokemonCp_;
			gymPoints_ = other.gymPoints_;
			isInBattle_ = other.isInBattle_;
			cooldownCompleteTimestampMs_ = other.cooldownCompleteTimestampMs_;
			sponsor_ = other.sponsor_;
			renderingType_ = other.renderingType_;
			activeFortModifier_ = other.activeFortModifier_;
			LureInfo = other.lureInfo_ != null ? other.LureInfo.Clone() : null;
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<FortData> Parser
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
				return global::POGOProtos.Map.Fort.FortDataReflection.Descriptor.MessageTypes[0];
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
		/// Gets or sets the id.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public string Id
		{
			get
			{
				return id_;
			}

			set
			{
				id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
			}
		}

		/// <summary>
		/// Gets or sets the last modified timestamp ms.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public long LastModifiedTimestampMs
		{
			get
			{
				return lastModifiedTimestampMs_;
			}

			set
			{
				lastModifiedTimestampMs_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the latitude.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public double Latitude
		{
			get
			{
				return latitude_;
			}

			set
			{
				latitude_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the longitude.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public double Longitude
		{
			get
			{
				return longitude_;
			}

			set
			{
				longitude_ = value;
			}
		}

		/// <summary>
		/// Gets or sets a value indicating whether enabled.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public bool Enabled
		{
			get
			{
				return enabled_;
			}

			set
			{
				enabled_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the type.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public FortType Type
		{
			get
			{
				return type_;
			}

			set
			{
				type_ = value;
			}
		}

		/// <summary>
		///  Team that owns the gym
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public TeamColor OwnedByTeam
		{
			get
			{
				return ownedByTeam_;
			}

			set
			{
				ownedByTeam_ = value;
			}
		}

		/// <summary>
		///  Highest CP Pokemon at the gym
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public PokemonId GuardPokemonId
		{
			get
			{
				return guardPokemonId_;
			}

			set
			{
				guardPokemonId_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the guard pokemon cp.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public int GuardPokemonCp
		{
			get
			{
				return guardPokemonCp_;
			}

			set
			{
				guardPokemonCp_ = value;
			}
		}

		/// <summary>
		///  Prestigate / experience of the gym
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public long GymPoints
		{
			get
			{
				return gymPoints_;
			}

			set
			{
				gymPoints_ = value;
			}
		}

		/// <summary>
		///  Whether someone is battling at the gym currently
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public bool IsInBattle
		{
			get
			{
				return isInBattle_;
			}

			set
			{
				isInBattle_ = value;
			}
		}

		/// <summary>
		///  Timestamp when the pokestop can be activated again to get items / xp
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public long CooldownCompleteTimestampMs
		{
			get
			{
				return cooldownCompleteTimestampMs_;
			}

			set
			{
				cooldownCompleteTimestampMs_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the sponsor.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public FortSponsor Sponsor
		{
			get
			{
				return sponsor_;
			}

			set
			{
				sponsor_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the rendering type.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public FortRenderingType RenderingType
		{
			get
			{
				return renderingType_;
			}

			set
			{
				renderingType_ = value;
			}
		}

		/// <summary>
		///  Might represent the type of item applied to the pokestop, right now only lures can be applied
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public pb.ByteString ActiveFortModifier
		{
			get
			{
				return activeFortModifier_;
			}

			set
			{
				activeFortModifier_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
			}
		}

		/// <summary>
		/// Gets or sets the lure info.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public FortLureInfo LureInfo
		{
			get
			{
				return lureInfo_;
			}

			set
			{
				lureInfo_ = value;
			}
		}

		#endregion

		#region  Interface Implementations

		/// <summary>
		/// The clone.
		/// </summary>
		/// <returns>
		/// The <see cref="FortData"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public FortData Clone()
		{
			return new FortData(this);
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
		public bool Equals(FortData other)
		{
			if (ReferenceEquals(other, null))
			{
				return false;
			}

			if (ReferenceEquals(other, this))
			{
				return true;
			}

			if (Id != other.Id)
			{
				return false;
			}

			if (LastModifiedTimestampMs != other.LastModifiedTimestampMs)
			{
				return false;
			}

			if (Latitude != other.Latitude)
			{
				return false;
			}

			if (Longitude != other.Longitude)
			{
				return false;
			}

			if (Enabled != other.Enabled)
			{
				return false;
			}

			if (Type != other.Type)
			{
				return false;
			}

			if (OwnedByTeam != other.OwnedByTeam)
			{
				return false;
			}

			if (GuardPokemonId != other.GuardPokemonId)
			{
				return false;
			}

			if (GuardPokemonCp != other.GuardPokemonCp)
			{
				return false;
			}

			if (GymPoints != other.GymPoints)
			{
				return false;
			}

			if (IsInBattle != other.IsInBattle)
			{
				return false;
			}

			if (CooldownCompleteTimestampMs != other.CooldownCompleteTimestampMs)
			{
				return false;
			}

			if (Sponsor != other.Sponsor)
			{
				return false;
			}

			if (RenderingType != other.RenderingType)
			{
				return false;
			}

			if (ActiveFortModifier != other.ActiveFortModifier)
			{
				return false;
			}

			if (!object.Equals(LureInfo, other.LureInfo))
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
			if (Id.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(Id);
			}

			if (LastModifiedTimestampMs != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(LastModifiedTimestampMs);
			}

			if (Latitude != 0D)
			{
				output.WriteRawTag(25);
				output.WriteDouble(Latitude);
			}

			if (Longitude != 0D)
			{
				output.WriteRawTag(33);
				output.WriteDouble(Longitude);
			}

			if (OwnedByTeam != 0)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)OwnedByTeam);
			}

			if (GuardPokemonId != 0)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)GuardPokemonId);
			}

			if (GuardPokemonCp != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(GuardPokemonCp);
			}

			if (Enabled != false)
			{
				output.WriteRawTag(64);
				output.WriteBool(Enabled);
			}

			if (Type != 0)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)Type);
			}

			if (GymPoints != 0L)
			{
				output.WriteRawTag(80);
				output.WriteInt64(GymPoints);
			}

			if (IsInBattle != false)
			{
				output.WriteRawTag(88);
				output.WriteBool(IsInBattle);
			}

			if (ActiveFortModifier.Length != 0)
			{
				output.WriteRawTag(98);
				output.WriteBytes(ActiveFortModifier);
			}

			if (lureInfo_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(LureInfo);
			}

			if (CooldownCompleteTimestampMs != 0L)
			{
				output.WriteRawTag(112);
				output.WriteInt64(CooldownCompleteTimestampMs);
			}

			if (Sponsor != 0)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)Sponsor);
			}

			if (RenderingType != 0)
			{
				output.WriteRawTag(128, 1);
				output.WriteEnum((int)RenderingType);
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
			if (Id.Length != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
			}

			if (LastModifiedTimestampMs != 0L)
			{
				size += 1 + pb::CodedOutputStream.ComputeInt64Size(LastModifiedTimestampMs);
			}

			if (Latitude != 0D)
			{
				size += 1 + 8;
			}

			if (Longitude != 0D)
			{
				size += 1 + 8;
			}

			if (Enabled != false)
			{
				size += 1 + 1;
			}

			if (Type != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeEnumSize((int)Type);
			}

			if (OwnedByTeam != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeEnumSize((int)OwnedByTeam);
			}

			if (GuardPokemonId != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeEnumSize((int)GuardPokemonId);
			}

			if (GuardPokemonCp != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeInt32Size(GuardPokemonCp);
			}

			if (GymPoints != 0L)
			{
				size += 1 + pb::CodedOutputStream.ComputeInt64Size(GymPoints);
			}

			if (IsInBattle != false)
			{
				size += 1 + 1;
			}

			if (CooldownCompleteTimestampMs != 0L)
			{
				size += 1 + pb::CodedOutputStream.ComputeInt64Size(CooldownCompleteTimestampMs);
			}

			if (Sponsor != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeEnumSize((int)Sponsor);
			}

			if (RenderingType != 0)
			{
				size += 2 + pb::CodedOutputStream.ComputeEnumSize((int)RenderingType);
			}

			if (ActiveFortModifier.Length != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeBytesSize(ActiveFortModifier);
			}

			if (lureInfo_ != null)
			{
				size += 1 + pb::CodedOutputStream.ComputeMessageSize(LureInfo);
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
		public void MergeFrom(FortData other)
		{
			if (other == null)
			{
				return;
			}

			if (other.Id.Length != 0)
			{
				Id = other.Id;
			}

			if (other.LastModifiedTimestampMs != 0L)
			{
				LastModifiedTimestampMs = other.LastModifiedTimestampMs;
			}

			if (other.Latitude != 0D)
			{
				Latitude = other.Latitude;
			}

			if (other.Longitude != 0D)
			{
				Longitude = other.Longitude;
			}

			if (other.Enabled != false)
			{
				Enabled = other.Enabled;
			}

			if (other.Type != 0)
			{
				Type = other.Type;
			}

			if (other.OwnedByTeam != 0)
			{
				OwnedByTeam = other.OwnedByTeam;
			}

			if (other.GuardPokemonId != 0)
			{
				GuardPokemonId = other.GuardPokemonId;
			}

			if (other.GuardPokemonCp != 0)
			{
				GuardPokemonCp = other.GuardPokemonCp;
			}

			if (other.GymPoints != 0L)
			{
				GymPoints = other.GymPoints;
			}

			if (other.IsInBattle != false)
			{
				IsInBattle = other.IsInBattle;
			}

			if (other.CooldownCompleteTimestampMs != 0L)
			{
				CooldownCompleteTimestampMs = other.CooldownCompleteTimestampMs;
			}

			if (other.Sponsor != 0)
			{
				Sponsor = other.Sponsor;
			}

			if (other.RenderingType != 0)
			{
				RenderingType = other.RenderingType;
			}

			if (other.ActiveFortModifier.Length != 0)
			{
				ActiveFortModifier = other.ActiveFortModifier;
			}

			if (other.lureInfo_ != null)
			{
				if (lureInfo_ == null)
				{
					lureInfo_ = new global::POGOProtos.Map.Fort.FortLureInfo();
				}

				LureInfo.MergeFrom(other.LureInfo);
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
						Id = input.ReadString();
						break;
					}

					case 16:
					{
						LastModifiedTimestampMs = input.ReadInt64();
						break;
					}

					case 25:
					{
						Latitude = input.ReadDouble();
						break;
					}

					case 33:
					{
						Longitude = input.ReadDouble();
						break;
					}

					case 40:
					{
						ownedByTeam_ = (global::POGOProtos.Enums.TeamColor)input.ReadEnum();
						break;
					}

					case 48:
					{
						guardPokemonId_ = (global::POGOProtos.Enums.PokemonId)input.ReadEnum();
						break;
					}

					case 56:
					{
						GuardPokemonCp = input.ReadInt32();
						break;
					}

					case 64:
					{
						Enabled = input.ReadBool();
						break;
					}

					case 72:
					{
						type_ = (global::POGOProtos.Map.Fort.FortType)input.ReadEnum();
						break;
					}

					case 80:
					{
						GymPoints = input.ReadInt64();
						break;
					}

					case 88:
					{
						IsInBattle = input.ReadBool();
						break;
					}

					case 98:
					{
						ActiveFortModifier = input.ReadBytes();
						break;
					}

					case 106:
					{
						if (lureInfo_ == null)
						{
							lureInfo_ = new global::POGOProtos.Map.Fort.FortLureInfo();
						}

						input.ReadMessage(lureInfo_);
						break;
					}

					case 112:
					{
						CooldownCompleteTimestampMs = input.ReadInt64();
						break;
					}

					case 120:
					{
						sponsor_ = (global::POGOProtos.Map.Fort.FortSponsor)input.ReadEnum();
						break;
					}

					case 128:
					{
						renderingType_ = (global::POGOProtos.Map.Fort.FortRenderingType)input.ReadEnum();
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
			return Equals(other as FortData);
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
			if (Id.Length != 0)
			{
				hash ^= Id.GetHashCode();
			}

			if (LastModifiedTimestampMs != 0L)
			{
				hash ^= LastModifiedTimestampMs.GetHashCode();
			}

			if (Latitude != 0D)
			{
				hash ^= Latitude.GetHashCode();
			}

			if (Longitude != 0D)
			{
				hash ^= Longitude.GetHashCode();
			}

			if (Enabled != false)
			{
				hash ^= Enabled.GetHashCode();
			}

			if (Type != 0)
			{
				hash ^= Type.GetHashCode();
			}

			if (OwnedByTeam != 0)
			{
				hash ^= OwnedByTeam.GetHashCode();
			}

			if (GuardPokemonId != 0)
			{
				hash ^= GuardPokemonId.GetHashCode();
			}

			if (GuardPokemonCp != 0)
			{
				hash ^= GuardPokemonCp.GetHashCode();
			}

			if (GymPoints != 0L)
			{
				hash ^= GymPoints.GetHashCode();
			}

			if (IsInBattle != false)
			{
				hash ^= IsInBattle.GetHashCode();
			}

			if (CooldownCompleteTimestampMs != 0L)
			{
				hash ^= CooldownCompleteTimestampMs.GetHashCode();
			}

			if (Sponsor != 0)
			{
				hash ^= Sponsor.GetHashCode();
			}

			if (RenderingType != 0)
			{
				hash ^= RenderingType.GetHashCode();
			}

			if (ActiveFortModifier.Length != 0)
			{
				hash ^= ActiveFortModifier.GetHashCode();
			}

			if (lureInfo_ != null)
			{
				hash ^= LureInfo.GetHashCode();
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