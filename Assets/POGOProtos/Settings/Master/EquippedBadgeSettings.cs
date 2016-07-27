// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EquippedBadgeSettings.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Settings/Master/EquippedBadgeSettings.proto
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
	/// <summary>Holder for reflection information generated from POGOProtos/Settings/Master/EquippedBadgeSettings.proto</summary>
	public static partial class EquippedBadgeSettingsReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Settings/Master/EquippedBadgeSettings.proto</summary>
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
		/// Initializes static members of the <see cref="EquippedBadgeSettingsReflection"/> class.
		/// </summary>
		static EquippedBadgeSettingsReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CjZQT0dPUHJvdG9zL1NldHRpbmdzL01hc3Rlci9FcXVpcHBlZEJhZGdlU2V0",
						"dGluZ3MucHJvdG8SGlBPR09Qcm90b3MuU2V0dGluZ3MuTWFzdGVyInkKFUVx",
						"dWlwcGVkQmFkZ2VTZXR0aW5ncxIfChdlcXVpcF9iYWRnZV9jb29sZG93bl9t",
						"cxgBIAEoAxIfChdjYXRjaF9wcm9iYWJpbGl0eV9ib251cxgCIAMoAhIeChZm",
						"bGVlX3Byb2JhYmlsaXR5X2JvbnVzGAMgAygCYgZwcm90bzM="));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new pbr.FileDescriptor[] { },
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Settings.Master.EquippedBadgeSettings),
							global::POGOProtos.Settings.Master.EquippedBadgeSettings.Parser,
							new[] { "EquipBadgeCooldownMs", "CatchProbabilityBonus", "FleeProbabilityBonus" },
							null,
							null,
							null)
					}));
		}

		#endregion
	}

	#region Messages

	/// <summary>
	/// The equipped badge settings.
	/// </summary>
	public sealed partial class EquippedBadgeSettings : pb::IMessage<EquippedBadgeSettings>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "equip_badge_cooldown_ms" field.</summary>
		public const int EquipBadgeCooldownMsFieldNumber = 1;

		/// <summary>Field number for the "catch_probability_bonus" field.</summary>
		public const int CatchProbabilityBonusFieldNumber = 2;

		/// <summary>Field number for the "flee_probability_bonus" field.</summary>
		public const int FleeProbabilityBonusFieldNumber = 3;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<EquippedBadgeSettings> _parser =
			new pb::MessageParser<EquippedBadgeSettings>(() => new EquippedBadgeSettings());

		/// <summary>
		/// The _repeated_catch probability bonus_codec.
		/// </summary>
		private static readonly pb.FieldCodec<float> _repeated_catchProbabilityBonus_codec = pb::FieldCodec.ForFloat(18);

		/// <summary>
		/// The _repeated_flee probability bonus_codec.
		/// </summary>
		private static readonly pb.FieldCodec<float> _repeated_fleeProbabilityBonus_codec = pb::FieldCodec.ForFloat(26);

		#endregion

		#region  Fields

		/// <summary>
		/// The catch probability bonus_.
		/// </summary>
		private readonly pbc.RepeatedField<float> catchProbabilityBonus_ = new pbc::RepeatedField<float>();

		/// <summary>
		/// The equip badge cooldown ms_.
		/// </summary>
		private long equipBadgeCooldownMs_;

		/// <summary>
		/// The flee probability bonus_.
		/// </summary>
		private readonly pbc.RepeatedField<float> fleeProbabilityBonus_ = new pbc::RepeatedField<float>();

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="EquippedBadgeSettings"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public EquippedBadgeSettings()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="EquippedBadgeSettings"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public EquippedBadgeSettings(EquippedBadgeSettings other) : this()
		{
			equipBadgeCooldownMs_ = other.equipBadgeCooldownMs_;
			catchProbabilityBonus_ = other.catchProbabilityBonus_.Clone();
			fleeProbabilityBonus_ = other.fleeProbabilityBonus_.Clone();
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<EquippedBadgeSettings> Parser
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
				return global::POGOProtos.Settings.Master.EquippedBadgeSettingsReflection.Descriptor.MessageTypes[0];
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
		/// Gets or sets the equip badge cooldown ms.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public long EquipBadgeCooldownMs
		{
			get
			{
				return equipBadgeCooldownMs_;
			}

			set
			{
				equipBadgeCooldownMs_ = value;
			}
		}

		/// <summary>
		/// Gets the catch probability bonus.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public pbc.RepeatedField<float> CatchProbabilityBonus
		{
			get
			{
				return catchProbabilityBonus_;
			}
		}

		/// <summary>
		/// Gets the flee probability bonus.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public pbc.RepeatedField<float> FleeProbabilityBonus
		{
			get
			{
				return fleeProbabilityBonus_;
			}
		}

		#endregion

		#region  Interface Implementations

		/// <summary>
		/// The clone.
		/// </summary>
		/// <returns>
		/// The <see cref="EquippedBadgeSettings"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public EquippedBadgeSettings Clone()
		{
			return new EquippedBadgeSettings(this);
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
		public bool Equals(EquippedBadgeSettings other)
		{
			if (ReferenceEquals(other, null))
			{
				return false;
			}

			if (ReferenceEquals(other, this))
			{
				return true;
			}

			if (EquipBadgeCooldownMs != other.EquipBadgeCooldownMs)
			{
				return false;
			}

			if (!catchProbabilityBonus_.Equals(other.catchProbabilityBonus_))
			{
				return false;
			}

			if (!fleeProbabilityBonus_.Equals(other.fleeProbabilityBonus_))
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
			if (EquipBadgeCooldownMs != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(EquipBadgeCooldownMs);
			}

			catchProbabilityBonus_.WriteTo(output, _repeated_catchProbabilityBonus_codec);
			fleeProbabilityBonus_.WriteTo(output, _repeated_fleeProbabilityBonus_codec);
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
			if (EquipBadgeCooldownMs != 0L)
			{
				size += 1 + pb::CodedOutputStream.ComputeInt64Size(EquipBadgeCooldownMs);
			}

			size += catchProbabilityBonus_.CalculateSize(_repeated_catchProbabilityBonus_codec);
			size += fleeProbabilityBonus_.CalculateSize(_repeated_fleeProbabilityBonus_codec);
			return size;
		}

		/// <summary>
		/// The merge from.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public void MergeFrom(EquippedBadgeSettings other)
		{
			if (other == null)
			{
				return;
			}

			if (other.EquipBadgeCooldownMs != 0L)
			{
				EquipBadgeCooldownMs = other.EquipBadgeCooldownMs;
			}

			catchProbabilityBonus_.Add(other.catchProbabilityBonus_);
			fleeProbabilityBonus_.Add(other.fleeProbabilityBonus_);
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
						EquipBadgeCooldownMs = input.ReadInt64();
						break;
					}

					case 18:
					case 21:
					{
						catchProbabilityBonus_.AddEntriesFrom(input, _repeated_catchProbabilityBonus_codec);
						break;
					}

					case 26:
					case 29:
					{
						fleeProbabilityBonus_.AddEntriesFrom(input, _repeated_fleeProbabilityBonus_codec);
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
			return Equals(other as EquippedBadgeSettings);
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
			if (EquipBadgeCooldownMs != 0L)
			{
				hash ^= EquipBadgeCooldownMs.GetHashCode();
			}

			hash ^= catchProbabilityBonus_.GetHashCode();
			hash ^= fleeProbabilityBonus_.GetHashCode();
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