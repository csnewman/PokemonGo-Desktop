// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GymLevelSettings.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Settings/Master/GymLevelSettings.proto
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
	/// <summary>Holder for reflection information generated from POGOProtos/Settings/Master/GymLevelSettings.proto</summary>
	public static partial class GymLevelSettingsReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Settings/Master/GymLevelSettings.proto</summary>
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
		/// Initializes static members of the <see cref="GymLevelSettingsReflection"/> class.
		/// </summary>
		static GymLevelSettingsReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CjFQT0dPUHJvdG9zL1NldHRpbmdzL01hc3Rlci9HeW1MZXZlbFNldHRpbmdz",
						"LnByb3RvEhpQT0dPUHJvdG9zLlNldHRpbmdzLk1hc3RlciJ3ChBHeW1MZXZl",
						"bFNldHRpbmdzEhsKE3JlcXVpcmVkX2V4cGVyaWVuY2UYASADKAUSFAoMbGVh",
						"ZGVyX3Nsb3RzGAIgAygFEhUKDXRyYWluZXJfc2xvdHMYAyADKAUSGQoRc2Vh",
						"cmNoX3JvbGxfYm9udXMYBCADKAViBnByb3RvMw=="));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new pbr.FileDescriptor[] { },
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Settings.Master.GymLevelSettings),
							global::POGOProtos.Settings.Master.GymLevelSettings.Parser,
							new[] { "RequiredExperience", "LeaderSlots", "TrainerSlots", "SearchRollBonus" },
							null,
							null,
							null)
					}));
		}

		#endregion
	}

	#region Messages

	/// <summary>
	/// The gym level settings.
	/// </summary>
	public sealed partial class GymLevelSettings : pb::IMessage<GymLevelSettings>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "required_experience" field.</summary>
		public const int RequiredExperienceFieldNumber = 1;

		/// <summary>Field number for the "leader_slots" field.</summary>
		public const int LeaderSlotsFieldNumber = 2;

		/// <summary>Field number for the "trainer_slots" field.</summary>
		public const int TrainerSlotsFieldNumber = 3;

		/// <summary>Field number for the "search_roll_bonus" field.</summary>
		public const int SearchRollBonusFieldNumber = 4;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<GymLevelSettings> _parser =
			new pb::MessageParser<GymLevelSettings>(() => new GymLevelSettings());

		/// <summary>
		/// The _repeated_required experience_codec.
		/// </summary>
		private static readonly pb.FieldCodec<int> _repeated_requiredExperience_codec = pb::FieldCodec.ForInt32(10);

		/// <summary>
		/// The _repeated_leader slots_codec.
		/// </summary>
		private static readonly pb.FieldCodec<int> _repeated_leaderSlots_codec = pb::FieldCodec.ForInt32(18);

		/// <summary>
		/// The _repeated_trainer slots_codec.
		/// </summary>
		private static readonly pb.FieldCodec<int> _repeated_trainerSlots_codec = pb::FieldCodec.ForInt32(26);

		/// <summary>
		/// The _repeated_search roll bonus_codec.
		/// </summary>
		private static readonly pb.FieldCodec<int> _repeated_searchRollBonus_codec = pb::FieldCodec.ForInt32(34);

		#endregion

		#region  Fields

		/// <summary>
		/// The leader slots_.
		/// </summary>
		private readonly pbc.RepeatedField<int> leaderSlots_ = new pbc::RepeatedField<int>();

		/// <summary>
		/// The required experience_.
		/// </summary>
		private readonly pbc.RepeatedField<int> requiredExperience_ = new pbc::RepeatedField<int>();

		/// <summary>
		/// The search roll bonus_.
		/// </summary>
		private readonly pbc.RepeatedField<int> searchRollBonus_ = new pbc::RepeatedField<int>();

		/// <summary>
		/// The trainer slots_.
		/// </summary>
		private readonly pbc.RepeatedField<int> trainerSlots_ = new pbc::RepeatedField<int>();

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="GymLevelSettings"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public GymLevelSettings()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="GymLevelSettings"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public GymLevelSettings(GymLevelSettings other) : this()
		{
			requiredExperience_ = other.requiredExperience_.Clone();
			leaderSlots_ = other.leaderSlots_.Clone();
			trainerSlots_ = other.trainerSlots_.Clone();
			searchRollBonus_ = other.searchRollBonus_.Clone();
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<GymLevelSettings> Parser
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
				return global::POGOProtos.Settings.Master.GymLevelSettingsReflection.Descriptor.MessageTypes[0];
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
		/// Gets the leader slots.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public pbc.RepeatedField<int> LeaderSlots
		{
			get
			{
				return leaderSlots_;
			}
		}

		/// <summary>
		/// Gets the trainer slots.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public pbc.RepeatedField<int> TrainerSlots
		{
			get
			{
				return trainerSlots_;
			}
		}

		/// <summary>
		/// Gets the search roll bonus.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public pbc.RepeatedField<int> SearchRollBonus
		{
			get
			{
				return searchRollBonus_;
			}
		}

		#endregion

		#region  Interface Implementations

		/// <summary>
		/// The clone.
		/// </summary>
		/// <returns>
		/// The <see cref="GymLevelSettings"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public GymLevelSettings Clone()
		{
			return new GymLevelSettings(this);
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
		public bool Equals(GymLevelSettings other)
		{
			if (ReferenceEquals(other, null))
			{
				return false;
			}

			if (ReferenceEquals(other, this))
			{
				return true;
			}

			if (!requiredExperience_.Equals(other.requiredExperience_))
			{
				return false;
			}

			if (!leaderSlots_.Equals(other.leaderSlots_))
			{
				return false;
			}

			if (!trainerSlots_.Equals(other.trainerSlots_))
			{
				return false;
			}

			if (!searchRollBonus_.Equals(other.searchRollBonus_))
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
			requiredExperience_.WriteTo(output, _repeated_requiredExperience_codec);
			leaderSlots_.WriteTo(output, _repeated_leaderSlots_codec);
			trainerSlots_.WriteTo(output, _repeated_trainerSlots_codec);
			searchRollBonus_.WriteTo(output, _repeated_searchRollBonus_codec);
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
			size += requiredExperience_.CalculateSize(_repeated_requiredExperience_codec);
			size += leaderSlots_.CalculateSize(_repeated_leaderSlots_codec);
			size += trainerSlots_.CalculateSize(_repeated_trainerSlots_codec);
			size += searchRollBonus_.CalculateSize(_repeated_searchRollBonus_codec);
			return size;
		}

		/// <summary>
		/// The merge from.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public void MergeFrom(GymLevelSettings other)
		{
			if (other == null)
			{
				return;
			}

			requiredExperience_.Add(other.requiredExperience_);
			leaderSlots_.Add(other.leaderSlots_);
			trainerSlots_.Add(other.trainerSlots_);
			searchRollBonus_.Add(other.searchRollBonus_);
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
						requiredExperience_.AddEntriesFrom(input, _repeated_requiredExperience_codec);
						break;
					}

					case 18:
					case 16:
					{
						leaderSlots_.AddEntriesFrom(input, _repeated_leaderSlots_codec);
						break;
					}

					case 26:
					case 24:
					{
						trainerSlots_.AddEntriesFrom(input, _repeated_trainerSlots_codec);
						break;
					}

					case 34:
					case 32:
					{
						searchRollBonus_.AddEntriesFrom(input, _repeated_searchRollBonus_codec);
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
			return Equals(other as GymLevelSettings);
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
			hash ^= requiredExperience_.GetHashCode();
			hash ^= leaderSlots_.GetHashCode();
			hash ^= trainerSlots_.GetHashCode();
			hash ^= searchRollBonus_.GetHashCode();
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