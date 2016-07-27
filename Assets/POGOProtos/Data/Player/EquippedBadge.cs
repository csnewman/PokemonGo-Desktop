// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EquippedBadge.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Data/Player/EquippedBadge.proto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

#pragma warning disable 1591, 0612, 3021

#region Designer generated code

using POGOProtos.Enums;
using pb = Google.Protobuf;
using pbc = Google.Protobuf.Collections;
using pbr = Google.Protobuf.Reflection;
using scg = System.Collections.Generic;

namespace POGOProtos.Data.Player
{
	/// <summary>Holder for reflection information generated from POGOProtos/Data/Player/EquippedBadge.proto</summary>
	public static partial class EquippedBadgeReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Data/Player/EquippedBadge.proto</summary>
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
		/// Initializes static members of the <see cref="EquippedBadgeReflection"/> class.
		/// </summary>
		static EquippedBadgeReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CipQT0dPUHJvdG9zL0RhdGEvUGxheWVyL0VxdWlwcGVkQmFkZ2UucHJvdG8S",
						"FlBPR09Qcm90b3MuRGF0YS5QbGF5ZXIaIFBPR09Qcm90b3MvRW51bXMvQmFk",
						"Z2VUeXBlLnByb3RvIn8KDUVxdWlwcGVkQmFkZ2USLwoKYmFkZ2VfdHlwZRgB",
						"IAEoDjIbLlBPR09Qcm90b3MuRW51bXMuQmFkZ2VUeXBlEg0KBWxldmVsGAIg",
						"ASgFEi4KJm5leHRfZXF1aXBfY2hhbmdlX2FsbG93ZWRfdGltZXN0YW1wX21z",
						"GAMgASgDYgZwcm90bzM="));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new[] { global::POGOProtos.Enums.BadgeTypeReflection.Descriptor, },
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Data.Player.EquippedBadge),
							global::POGOProtos.Data.Player.EquippedBadge.Parser,
							new[] { "BadgeType", "Level", "NextEquipChangeAllowedTimestampMs" },
							null,
							null,
							null)
					}));
		}

		#endregion
	}

	#region Messages

	/// <summary>
	/// The equipped badge.
	/// </summary>
	public sealed partial class EquippedBadge : pb::IMessage<EquippedBadge>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "badge_type" field.</summary>
		public const int BadgeTypeFieldNumber = 1;

		/// <summary>Field number for the "level" field.</summary>
		public const int LevelFieldNumber = 2;

		/// <summary>Field number for the "next_equip_change_allowed_timestamp_ms" field.</summary>
		public const int NextEquipChangeAllowedTimestampMsFieldNumber = 3;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<EquippedBadge> _parser =
			new pb::MessageParser<EquippedBadge>(() => new EquippedBadge());

		#endregion

		#region  Fields

		/// <summary>
		/// The badge type_.
		/// </summary>
		private BadgeType badgeType_ = 0;

		/// <summary>
		/// The level_.
		/// </summary>
		private int level_;

		/// <summary>
		/// The next equip change allowed timestamp ms_.
		/// </summary>
		private long nextEquipChangeAllowedTimestampMs_;

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="EquippedBadge"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public EquippedBadge()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="EquippedBadge"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public EquippedBadge(EquippedBadge other) : this()
		{
			badgeType_ = other.badgeType_;
			level_ = other.level_;
			nextEquipChangeAllowedTimestampMs_ = other.nextEquipChangeAllowedTimestampMs_;
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<EquippedBadge> Parser
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
				return global::POGOProtos.Data.Player.EquippedBadgeReflection.Descriptor.MessageTypes[0];
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
		/// Gets or sets the badge type.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public BadgeType BadgeType
		{
			get
			{
				return badgeType_;
			}

			set
			{
				badgeType_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the level.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public int Level
		{
			get
			{
				return level_;
			}

			set
			{
				level_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the next equip change allowed timestamp ms.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public long NextEquipChangeAllowedTimestampMs
		{
			get
			{
				return nextEquipChangeAllowedTimestampMs_;
			}

			set
			{
				nextEquipChangeAllowedTimestampMs_ = value;
			}
		}

		#endregion

		#region  Interface Implementations

		/// <summary>
		/// The clone.
		/// </summary>
		/// <returns>
		/// The <see cref="EquippedBadge"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public EquippedBadge Clone()
		{
			return new EquippedBadge(this);
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
		public bool Equals(EquippedBadge other)
		{
			if (ReferenceEquals(other, null))
			{
				return false;
			}

			if (ReferenceEquals(other, this))
			{
				return true;
			}

			if (BadgeType != other.BadgeType)
			{
				return false;
			}

			if (Level != other.Level)
			{
				return false;
			}

			if (NextEquipChangeAllowedTimestampMs != other.NextEquipChangeAllowedTimestampMs)
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
			if (BadgeType != 0)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)BadgeType);
			}

			if (Level != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(Level);
			}

			if (NextEquipChangeAllowedTimestampMs != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(NextEquipChangeAllowedTimestampMs);
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
			if (BadgeType != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeEnumSize((int)BadgeType);
			}

			if (Level != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeInt32Size(Level);
			}

			if (NextEquipChangeAllowedTimestampMs != 0L)
			{
				size += 1 + pb::CodedOutputStream.ComputeInt64Size(NextEquipChangeAllowedTimestampMs);
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
		public void MergeFrom(EquippedBadge other)
		{
			if (other == null)
			{
				return;
			}

			if (other.BadgeType != 0)
			{
				BadgeType = other.BadgeType;
			}

			if (other.Level != 0)
			{
				Level = other.Level;
			}

			if (other.NextEquipChangeAllowedTimestampMs != 0L)
			{
				NextEquipChangeAllowedTimestampMs = other.NextEquipChangeAllowedTimestampMs;
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
						badgeType_ = (global::POGOProtos.Enums.BadgeType)input.ReadEnum();
						break;
					}

					case 16:
					{
						Level = input.ReadInt32();
						break;
					}

					case 24:
					{
						NextEquipChangeAllowedTimestampMs = input.ReadInt64();
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
			return Equals(other as EquippedBadge);
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
			if (BadgeType != 0)
			{
				hash ^= BadgeType.GetHashCode();
			}

			if (Level != 0)
			{
				hash ^= Level.GetHashCode();
			}

			if (NextEquipChangeAllowedTimestampMs != 0L)
			{
				hash ^= NextEquipChangeAllowedTimestampMs.GetHashCode();
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