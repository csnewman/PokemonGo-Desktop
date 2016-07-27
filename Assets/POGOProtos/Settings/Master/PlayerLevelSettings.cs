// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PlayerLevelSettings.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Settings/Master/PlayerLevelSettings.proto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

#pragma warning disable 1591, 0612, 3021

#region Designer generated code

using pb = Google.Protobuf;
using pbc = Google.Protobuf.Collections;
using pbr = Google.Protobuf.Reflection;
using scg = System.Collections.Generic;

namespace POGOProtos.Settings.Master
{
	/// <summary>Holder for reflection information generated from POGOProtos/Settings/Master/PlayerLevelSettings.proto</summary>
	public static partial class PlayerLevelSettingsReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Settings/Master/PlayerLevelSettings.proto</summary>
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
		/// Initializes static members of the <see cref="PlayerLevelSettingsReflection"/> class.
		/// </summary>
		static PlayerLevelSettingsReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CjRQT0dPUHJvdG9zL1NldHRpbmdzL01hc3Rlci9QbGF5ZXJMZXZlbFNldHRp",
						"bmdzLnByb3RvEhpQT0dPUHJvdG9zLlNldHRpbmdzLk1hc3RlciKdAQoTUGxh",
						"eWVyTGV2ZWxTZXR0aW5ncxIQCghyYW5rX251bRgBIAMoBRIbChNyZXF1aXJl",
						"ZF9leHBlcmllbmNlGAIgAygFEhUKDWNwX211bHRpcGxpZXIYAyADKAISHAoU",
						"bWF4X2VnZ19wbGF5ZXJfbGV2ZWwYBCABKAUSIgoabWF4X2VuY291bnRlcl9w",
						"bGF5ZXJfbGV2ZWwYBSABKAViBnByb3RvMw=="));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new pbr.FileDescriptor[] { },
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Settings.Master.PlayerLevelSettings),
							global::POGOProtos.Settings.Master.PlayerLevelSettings.Parser,
							new[] { "RankNum", "RequiredExperience", "CpMultiplier", "MaxEggPlayerLevel", "MaxEncounterPlayerLevel" },
							null,
							null,
							null)
					}));
		}

		#endregion
	}

	#region Messages

	/// <summary>
	/// The player level settings.
	/// </summary>
	public sealed partial class PlayerLevelSettings : pb::IMessage<PlayerLevelSettings>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "rank_num" field.</summary>
		public const int RankNumFieldNumber = 1;

		/// <summary>Field number for the "required_experience" field.</summary>
		public const int RequiredExperienceFieldNumber = 2;

		/// <summary>Field number for the "cp_multiplier" field.</summary>
		public const int CpMultiplierFieldNumber = 3;

		/// <summary>Field number for the "max_egg_player_level" field.</summary>
		public const int MaxEggPlayerLevelFieldNumber = 4;

		/// <summary>Field number for the "max_encounter_player_level" field.</summary>
		public const int MaxEncounterPlayerLevelFieldNumber = 5;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<PlayerLevelSettings> _parser =
			new pb::MessageParser<PlayerLevelSettings>(() => new PlayerLevelSettings());

		/// <summary>
		/// The _repeated_rank num_codec.
		/// </summary>
		private static readonly pb.FieldCodec<int> _repeated_rankNum_codec = pb::FieldCodec.ForInt32(10);

		/// <summary>
		/// The _repeated_required experience_codec.
		/// </summary>
		private static readonly pb.FieldCodec<int> _repeated_requiredExperience_codec = pb::FieldCodec.ForInt32(18);

		/// <summary>
		/// The _repeated_cp multiplier_codec.
		/// </summary>
		private static readonly pb.FieldCodec<float> _repeated_cpMultiplier_codec = pb::FieldCodec.ForFloat(26);

		#endregion

		#region  Fields

		/// <summary>
		/// The cp multiplier_.
		/// </summary>
		private readonly pbc.RepeatedField<float> cpMultiplier_ = new pbc::RepeatedField<float>();

		/// <summary>
		/// The max egg player level_.
		/// </summary>
		private int maxEggPlayerLevel_;

		/// <summary>
		/// The max encounter player level_.
		/// </summary>
		private int maxEncounterPlayerLevel_;

		/// <summary>
		/// The rank num_.
		/// </summary>
		private readonly pbc.RepeatedField<int> rankNum_ = new pbc::RepeatedField<int>();

		/// <summary>
		/// The required experience_.
		/// </summary>
		private readonly pbc.RepeatedField<int> requiredExperience_ = new pbc::RepeatedField<int>();

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="PlayerLevelSettings"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public PlayerLevelSettings()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="PlayerLevelSettings"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public PlayerLevelSettings(PlayerLevelSettings other) : this()
		{
			rankNum_ = other.rankNum_.Clone();
			requiredExperience_ = other.requiredExperience_.Clone();
			cpMultiplier_ = other.cpMultiplier_.Clone();
			maxEggPlayerLevel_ = other.maxEggPlayerLevel_;
			maxEncounterPlayerLevel_ = other.maxEncounterPlayerLevel_;
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<PlayerLevelSettings> Parser
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
				return global::POGOProtos.Settings.Master.PlayerLevelSettingsReflection.Descriptor.MessageTypes[0];
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
		/// Gets the rank num.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public pbc.RepeatedField<int> RankNum
		{
			get
			{
				return rankNum_;
			}
		}

		/// <summary>
		/// Gets the required experience.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public pbc.RepeatedField<int> RequiredExperience
		{
			get
			{
				return requiredExperience_;
			}
		}

		/// <summary>
		/// Gets the cp multiplier.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public pbc.RepeatedField<float> CpMultiplier
		{
			get
			{
				return cpMultiplier_;
			}
		}

		/// <summary>
		/// Gets or sets the max egg player level.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public int MaxEggPlayerLevel
		{
			get
			{
				return maxEggPlayerLevel_;
			}

			set
			{
				maxEggPlayerLevel_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the max encounter player level.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public int MaxEncounterPlayerLevel
		{
			get
			{
				return maxEncounterPlayerLevel_;
			}

			set
			{
				maxEncounterPlayerLevel_ = value;
			}
		}

		#endregion

		#region  Interface Implementations

		/// <summary>
		/// The clone.
		/// </summary>
		/// <returns>
		/// The <see cref="PlayerLevelSettings"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public PlayerLevelSettings Clone()
		{
			return new PlayerLevelSettings(this);
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
		public bool Equals(PlayerLevelSettings other)
		{
			if (ReferenceEquals(other, null))
			{
				return false;
			}

			if (ReferenceEquals(other, this))
			{
				return true;
			}

			if (!rankNum_.Equals(other.rankNum_))
			{
				return false;
			}

			if (!requiredExperience_.Equals(other.requiredExperience_))
			{
				return false;
			}

			if (!cpMultiplier_.Equals(other.cpMultiplier_))
			{
				return false;
			}

			if (MaxEggPlayerLevel != other.MaxEggPlayerLevel)
			{
				return false;
			}

			if (MaxEncounterPlayerLevel != other.MaxEncounterPlayerLevel)
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
			rankNum_.WriteTo(output, _repeated_rankNum_codec);
			requiredExperience_.WriteTo(output, _repeated_requiredExperience_codec);
			cpMultiplier_.WriteTo(output, _repeated_cpMultiplier_codec);
			if (MaxEggPlayerLevel != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(MaxEggPlayerLevel);
			}

			if (MaxEncounterPlayerLevel != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(MaxEncounterPlayerLevel);
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
			size += rankNum_.CalculateSize(_repeated_rankNum_codec);
			size += requiredExperience_.CalculateSize(_repeated_requiredExperience_codec);
			size += cpMultiplier_.CalculateSize(_repeated_cpMultiplier_codec);
			if (MaxEggPlayerLevel != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeInt32Size(MaxEggPlayerLevel);
			}

			if (MaxEncounterPlayerLevel != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeInt32Size(MaxEncounterPlayerLevel);
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
		public void MergeFrom(PlayerLevelSettings other)
		{
			if (other == null)
			{
				return;
			}

			rankNum_.Add(other.rankNum_);
			requiredExperience_.Add(other.requiredExperience_);
			cpMultiplier_.Add(other.cpMultiplier_);
			if (other.MaxEggPlayerLevel != 0)
			{
				MaxEggPlayerLevel = other.MaxEggPlayerLevel;
			}

			if (other.MaxEncounterPlayerLevel != 0)
			{
				MaxEncounterPlayerLevel = other.MaxEncounterPlayerLevel;
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
					case 8:
					{
						rankNum_.AddEntriesFrom(input, _repeated_rankNum_codec);
						break;
					}

					case 18:
					case 16:
					{
						requiredExperience_.AddEntriesFrom(input, _repeated_requiredExperience_codec);
						break;
					}

					case 26:
					case 29:
					{
						cpMultiplier_.AddEntriesFrom(input, _repeated_cpMultiplier_codec);
						break;
					}

					case 32:
					{
						MaxEggPlayerLevel = input.ReadInt32();
						break;
					}

					case 40:
					{
						MaxEncounterPlayerLevel = input.ReadInt32();
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
			return Equals(other as PlayerLevelSettings);
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
			hash ^= rankNum_.GetHashCode();
			hash ^= requiredExperience_.GetHashCode();
			hash ^= cpMultiplier_.GetHashCode();
			if (MaxEggPlayerLevel != 0)
			{
				hash ^= MaxEggPlayerLevel.GetHashCode();
			}

			if (MaxEncounterPlayerLevel != 0)
			{
				hash ^= MaxEncounterPlayerLevel.GetHashCode();
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