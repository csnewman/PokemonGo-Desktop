// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BadgeSettings.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Settings/Master/BadgeSettings.proto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

#pragma warning disable 1591, 0612, 3021

#region Designer generated code

using POGOProtos.Enums;
using pb = Google.Protobuf;
using pbc = Google.Protobuf.Collections;
using pbr = Google.Protobuf.Reflection;
using scg = System.Collections.Generic;

namespace POGOProtos.Settings.Master
{
	/// <summary>Holder for reflection information generated from POGOProtos/Settings/Master/BadgeSettings.proto</summary>
	public static partial class BadgeSettingsReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Settings/Master/BadgeSettings.proto</summary>
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
		/// Initializes static members of the <see cref="BadgeSettingsReflection"/> class.
		/// </summary>
		static BadgeSettingsReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"Ci5QT0dPUHJvdG9zL1NldHRpbmdzL01hc3Rlci9CYWRnZVNldHRpbmdzLnBy",
						"b3RvEhpQT0dPUHJvdG9zLlNldHRpbmdzLk1hc3RlchogUE9HT1Byb3Rvcy9F",
						"bnVtcy9CYWRnZVR5cGUucHJvdG8iZQoNQmFkZ2VTZXR0aW5ncxIvCgpiYWRn",
						"ZV90eXBlGAEgASgOMhsuUE9HT1Byb3Rvcy5FbnVtcy5CYWRnZVR5cGUSEgoK",
						"YmFkZ2VfcmFuaxgCIAEoBRIPCgd0YXJnZXRzGAMgAygFYgZwcm90bzM="));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new[] { global::POGOProtos.Enums.BadgeTypeReflection.Descriptor, },
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Settings.Master.BadgeSettings),
							global::POGOProtos.Settings.Master.BadgeSettings.Parser,
							new[] { "BadgeType", "BadgeRank", "Targets" },
							null,
							null,
							null)
					}));
		}

		#endregion
	}

	#region Messages

	/// <summary>
	/// The badge settings.
	/// </summary>
	public sealed partial class BadgeSettings : pb::IMessage<BadgeSettings>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "badge_type" field.</summary>
		public const int BadgeTypeFieldNumber = 1;

		/// <summary>Field number for the "badge_rank" field.</summary>
		public const int BadgeRankFieldNumber = 2;

		/// <summary>Field number for the "targets" field.</summary>
		public const int TargetsFieldNumber = 3;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<BadgeSettings> _parser =
			new pb::MessageParser<BadgeSettings>(() => new BadgeSettings());

		/// <summary>
		/// The _repeated_targets_codec.
		/// </summary>
		private static readonly pb.FieldCodec<int> _repeated_targets_codec = pb::FieldCodec.ForInt32(26);

		#endregion

		#region  Fields

		/// <summary>
		/// The badge rank_.
		/// </summary>
		private int badgeRank_;

		/// <summary>
		/// The badge type_.
		/// </summary>
		private BadgeType badgeType_ = 0;

		/// <summary>
		/// The targets_.
		/// </summary>
		private readonly pbc.RepeatedField<int> targets_ = new pbc::RepeatedField<int>();

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="BadgeSettings"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public BadgeSettings()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="BadgeSettings"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public BadgeSettings(BadgeSettings other) : this()
		{
			badgeType_ = other.badgeType_;
			badgeRank_ = other.badgeRank_;
			targets_ = other.targets_.Clone();
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<BadgeSettings> Parser
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
				return global::POGOProtos.Settings.Master.BadgeSettingsReflection.Descriptor.MessageTypes[0];
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
		/// Gets or sets the badge rank.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public int BadgeRank
		{
			get
			{
				return badgeRank_;
			}

			set
			{
				badgeRank_ = value;
			}
		}

		/// <summary>
		/// Gets the targets.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public pbc.RepeatedField<int> Targets
		{
			get
			{
				return targets_;
			}
		}

		#endregion

		#region  Interface Implementations

		/// <summary>
		/// The clone.
		/// </summary>
		/// <returns>
		/// The <see cref="BadgeSettings"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public BadgeSettings Clone()
		{
			return new BadgeSettings(this);
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
		public bool Equals(BadgeSettings other)
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

			if (BadgeRank != other.BadgeRank)
			{
				return false;
			}

			if (!targets_.Equals(other.targets_))
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

			if (BadgeRank != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(BadgeRank);
			}

			targets_.WriteTo(output, _repeated_targets_codec);
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

			if (BadgeRank != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeInt32Size(BadgeRank);
			}

			size += targets_.CalculateSize(_repeated_targets_codec);
			return size;
		}

		/// <summary>
		/// The merge from.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public void MergeFrom(BadgeSettings other)
		{
			if (other == null)
			{
				return;
			}

			if (other.BadgeType != 0)
			{
				BadgeType = other.BadgeType;
			}

			if (other.BadgeRank != 0)
			{
				BadgeRank = other.BadgeRank;
			}

			targets_.Add(other.targets_);
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
						BadgeRank = input.ReadInt32();
						break;
					}

					case 26:
					case 24:
					{
						targets_.AddEntriesFrom(input, _repeated_targets_codec);
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
			return Equals(other as BadgeSettings);
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

			if (BadgeRank != 0)
			{
				hash ^= BadgeRank.GetHashCode();
			}

			hash ^= targets_.GetHashCode();
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