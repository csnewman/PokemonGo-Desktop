// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PokemonUpgradeSettings.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Settings/Master/PokemonUpgradeSettings.proto
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
	/// <summary>Holder for reflection information generated from POGOProtos/Settings/Master/PokemonUpgradeSettings.proto</summary>
	public static partial class PokemonUpgradeSettingsReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Settings/Master/PokemonUpgradeSettings.proto</summary>
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
		/// Initializes static members of the <see cref="PokemonUpgradeSettingsReflection"/> class.
		/// </summary>
		static PokemonUpgradeSettingsReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CjdQT0dPUHJvdG9zL1NldHRpbmdzL01hc3Rlci9Qb2tlbW9uVXBncmFkZVNl",
						"dHRpbmdzLnByb3RvEhpQT0dPUHJvdG9zLlNldHRpbmdzLk1hc3RlciKEAQoW",
						"UG9rZW1vblVwZ3JhZGVTZXR0aW5ncxIaChJ1cGdyYWRlc19wZXJfbGV2ZWwY",
						"ASABKAUSIwobYWxsb3dlZF9sZXZlbHNfYWJvdmVfcGxheWVyGAIgASgFEhIK",
						"CmNhbmR5X2Nvc3QYAyADKAUSFQoNc3RhcmR1c3RfY29zdBgEIAMoBWIGcHJv",
						"dG8z"));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new pbr.FileDescriptor[] { },
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Settings.Master.PokemonUpgradeSettings),
							global::POGOProtos.Settings.Master.PokemonUpgradeSettings.Parser,
							new[] { "UpgradesPerLevel", "AllowedLevelsAbovePlayer", "CandyCost", "StardustCost" },
							null,
							null,
							null)
					}));
		}

		#endregion
	}

	#region Messages

	/// <summary>
	/// The pokemon upgrade settings.
	/// </summary>
	public sealed partial class PokemonUpgradeSettings : pb::IMessage<PokemonUpgradeSettings>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "upgrades_per_level" field.</summary>
		public const int UpgradesPerLevelFieldNumber = 1;

		/// <summary>Field number for the "allowed_levels_above_player" field.</summary>
		public const int AllowedLevelsAbovePlayerFieldNumber = 2;

		/// <summary>Field number for the "candy_cost" field.</summary>
		public const int CandyCostFieldNumber = 3;

		/// <summary>Field number for the "stardust_cost" field.</summary>
		public const int StardustCostFieldNumber = 4;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<PokemonUpgradeSettings> _parser =
			new pb::MessageParser<PokemonUpgradeSettings>(() => new PokemonUpgradeSettings());

		/// <summary>
		/// The _repeated_candy cost_codec.
		/// </summary>
		private static readonly pb.FieldCodec<int> _repeated_candyCost_codec = pb::FieldCodec.ForInt32(26);

		/// <summary>
		/// The _repeated_stardust cost_codec.
		/// </summary>
		private static readonly pb.FieldCodec<int> _repeated_stardustCost_codec = pb::FieldCodec.ForInt32(34);

		#endregion

		#region  Fields

		/// <summary>
		/// The allowed levels above player_.
		/// </summary>
		private int allowedLevelsAbovePlayer_;

		/// <summary>
		/// The candy cost_.
		/// </summary>
		private readonly pbc.RepeatedField<int> candyCost_ = new pbc::RepeatedField<int>();

		/// <summary>
		/// The stardust cost_.
		/// </summary>
		private readonly pbc.RepeatedField<int> stardustCost_ = new pbc::RepeatedField<int>();

		/// <summary>
		/// The upgrades per level_.
		/// </summary>
		private int upgradesPerLevel_;

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="PokemonUpgradeSettings"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public PokemonUpgradeSettings()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="PokemonUpgradeSettings"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public PokemonUpgradeSettings(PokemonUpgradeSettings other) : this()
		{
			upgradesPerLevel_ = other.upgradesPerLevel_;
			allowedLevelsAbovePlayer_ = other.allowedLevelsAbovePlayer_;
			candyCost_ = other.candyCost_.Clone();
			stardustCost_ = other.stardustCost_.Clone();
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<PokemonUpgradeSettings> Parser
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
				return global::POGOProtos.Settings.Master.PokemonUpgradeSettingsReflection.Descriptor.MessageTypes[0];
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
		/// Gets or sets the upgrades per level.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public int UpgradesPerLevel
		{
			get
			{
				return upgradesPerLevel_;
			}

			set
			{
				upgradesPerLevel_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the allowed levels above player.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public int AllowedLevelsAbovePlayer
		{
			get
			{
				return allowedLevelsAbovePlayer_;
			}

			set
			{
				allowedLevelsAbovePlayer_ = value;
			}
		}

		/// <summary>
		/// Gets the candy cost.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public pbc.RepeatedField<int> CandyCost
		{
			get
			{
				return candyCost_;
			}
		}

		/// <summary>
		/// Gets the stardust cost.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public pbc.RepeatedField<int> StardustCost
		{
			get
			{
				return stardustCost_;
			}
		}

		#endregion

		#region  Interface Implementations

		/// <summary>
		/// The clone.
		/// </summary>
		/// <returns>
		/// The <see cref="PokemonUpgradeSettings"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public PokemonUpgradeSettings Clone()
		{
			return new PokemonUpgradeSettings(this);
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
		public bool Equals(PokemonUpgradeSettings other)
		{
			if (ReferenceEquals(other, null))
			{
				return false;
			}

			if (ReferenceEquals(other, this))
			{
				return true;
			}

			if (UpgradesPerLevel != other.UpgradesPerLevel)
			{
				return false;
			}

			if (AllowedLevelsAbovePlayer != other.AllowedLevelsAbovePlayer)
			{
				return false;
			}

			if (!candyCost_.Equals(other.candyCost_))
			{
				return false;
			}

			if (!stardustCost_.Equals(other.stardustCost_))
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
			if (UpgradesPerLevel != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(UpgradesPerLevel);
			}

			if (AllowedLevelsAbovePlayer != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(AllowedLevelsAbovePlayer);
			}

			candyCost_.WriteTo(output, _repeated_candyCost_codec);
			stardustCost_.WriteTo(output, _repeated_stardustCost_codec);
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
			if (UpgradesPerLevel != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeInt32Size(UpgradesPerLevel);
			}

			if (AllowedLevelsAbovePlayer != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeInt32Size(AllowedLevelsAbovePlayer);
			}

			size += candyCost_.CalculateSize(_repeated_candyCost_codec);
			size += stardustCost_.CalculateSize(_repeated_stardustCost_codec);
			return size;
		}

		/// <summary>
		/// The merge from.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public void MergeFrom(PokemonUpgradeSettings other)
		{
			if (other == null)
			{
				return;
			}

			if (other.UpgradesPerLevel != 0)
			{
				UpgradesPerLevel = other.UpgradesPerLevel;
			}

			if (other.AllowedLevelsAbovePlayer != 0)
			{
				AllowedLevelsAbovePlayer = other.AllowedLevelsAbovePlayer;
			}

			candyCost_.Add(other.candyCost_);
			stardustCost_.Add(other.stardustCost_);
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
						UpgradesPerLevel = input.ReadInt32();
						break;
					}

					case 16:
					{
						AllowedLevelsAbovePlayer = input.ReadInt32();
						break;
					}

					case 26:
					case 24:
					{
						candyCost_.AddEntriesFrom(input, _repeated_candyCost_codec);
						break;
					}

					case 34:
					case 32:
					{
						stardustCost_.AddEntriesFrom(input, _repeated_stardustCost_codec);
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
			return Equals(other as PokemonUpgradeSettings);
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
			if (UpgradesPerLevel != 0)
			{
				hash ^= UpgradesPerLevel.GetHashCode();
			}

			if (AllowedLevelsAbovePlayer != 0)
			{
				hash ^= AllowedLevelsAbovePlayer.GetHashCode();
			}

			hash ^= candyCost_.GetHashCode();
			hash ^= stardustCost_.GetHashCode();
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