// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StatsAttributes.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Settings/Master/Pokemon/StatsAttributes.proto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

#pragma warning disable 1591, 0612, 3021

#region Designer generated code

using pb = Google.Protobuf;
using pbc = Google.Protobuf.Collections;
using pbr = Google.Protobuf.Reflection;
using scg = System.Collections.Generic;

namespace POGOProtos.Settings.Master.Pokemon
{
	/// <summary>Holder for reflection information generated from POGOProtos/Settings/Master/Pokemon/StatsAttributes.proto</summary>
	public static partial class StatsAttributesReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Settings/Master/Pokemon/StatsAttributes.proto</summary>
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
		/// Initializes static members of the <see cref="StatsAttributesReflection"/> class.
		/// </summary>
		static StatsAttributesReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CjhQT0dPUHJvdG9zL1NldHRpbmdzL01hc3Rlci9Qb2tlbW9uL1N0YXRzQXR0",
						"cmlidXRlcy5wcm90bxIiUE9HT1Byb3Rvcy5TZXR0aW5ncy5NYXN0ZXIuUG9r",
						"ZW1vbiJuCg9TdGF0c0F0dHJpYnV0ZXMSFAoMYmFzZV9zdGFtaW5hGAEgASgF",
						"EhMKC2Jhc2VfYXR0YWNrGAIgASgFEhQKDGJhc2VfZGVmZW5zZRgDIAEoBRIa",
						"ChJkb2RnZV9lbmVyZ3lfZGVsdGEYCCABKAViBnByb3RvMw=="));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new pbr.FileDescriptor[] { },
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Settings.Master.Pokemon.StatsAttributes),
							global::POGOProtos.Settings.Master.Pokemon.StatsAttributes.Parser,
							new[] { "BaseStamina", "BaseAttack", "BaseDefense", "DodgeEnergyDelta" },
							null,
							null,
							null)
					}));
		}

		#endregion
	}

	#region Messages

	/// <summary>
	/// The stats attributes.
	/// </summary>
	public sealed partial class StatsAttributes : pb::IMessage<StatsAttributes>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "base_stamina" field.</summary>
		public const int BaseStaminaFieldNumber = 1;

		/// <summary>Field number for the "base_attack" field.</summary>
		public const int BaseAttackFieldNumber = 2;

		/// <summary>Field number for the "base_defense" field.</summary>
		public const int BaseDefenseFieldNumber = 3;

		/// <summary>Field number for the "dodge_energy_delta" field.</summary>
		public const int DodgeEnergyDeltaFieldNumber = 8;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<StatsAttributes> _parser =
			new pb::MessageParser<StatsAttributes>(() => new StatsAttributes());

		#endregion

		#region  Fields

		/// <summary>
		/// The base attack_.
		/// </summary>
		private int baseAttack_;

		/// <summary>
		/// The base defense_.
		/// </summary>
		private int baseDefense_;

		/// <summary>
		/// The base stamina_.
		/// </summary>
		private int baseStamina_;

		/// <summary>
		/// The dodge energy delta_.
		/// </summary>
		private int dodgeEnergyDelta_;

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="StatsAttributes"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public StatsAttributes()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="StatsAttributes"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public StatsAttributes(StatsAttributes other) : this()
		{
			baseStamina_ = other.baseStamina_;
			baseAttack_ = other.baseAttack_;
			baseDefense_ = other.baseDefense_;
			dodgeEnergyDelta_ = other.dodgeEnergyDelta_;
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<StatsAttributes> Parser
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
				return global::POGOProtos.Settings.Master.Pokemon.StatsAttributesReflection.Descriptor.MessageTypes[0];
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
		/// Gets or sets the base stamina.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public int BaseStamina
		{
			get
			{
				return baseStamina_;
			}

			set
			{
				baseStamina_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the base attack.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public int BaseAttack
		{
			get
			{
				return baseAttack_;
			}

			set
			{
				baseAttack_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the base defense.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public int BaseDefense
		{
			get
			{
				return baseDefense_;
			}

			set
			{
				baseDefense_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the dodge energy delta.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public int DodgeEnergyDelta
		{
			get
			{
				return dodgeEnergyDelta_;
			}

			set
			{
				dodgeEnergyDelta_ = value;
			}
		}

		#endregion

		#region  Interface Implementations

		/// <summary>
		/// The clone.
		/// </summary>
		/// <returns>
		/// The <see cref="StatsAttributes"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public StatsAttributes Clone()
		{
			return new StatsAttributes(this);
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
		public bool Equals(StatsAttributes other)
		{
			if (ReferenceEquals(other, null))
			{
				return false;
			}

			if (ReferenceEquals(other, this))
			{
				return true;
			}

			if (BaseStamina != other.BaseStamina)
			{
				return false;
			}

			if (BaseAttack != other.BaseAttack)
			{
				return false;
			}

			if (BaseDefense != other.BaseDefense)
			{
				return false;
			}

			if (DodgeEnergyDelta != other.DodgeEnergyDelta)
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
			if (BaseStamina != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(BaseStamina);
			}

			if (BaseAttack != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(BaseAttack);
			}

			if (BaseDefense != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(BaseDefense);
			}

			if (DodgeEnergyDelta != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(DodgeEnergyDelta);
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
			if (BaseStamina != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeInt32Size(BaseStamina);
			}

			if (BaseAttack != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeInt32Size(BaseAttack);
			}

			if (BaseDefense != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeInt32Size(BaseDefense);
			}

			if (DodgeEnergyDelta != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeInt32Size(DodgeEnergyDelta);
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
		public void MergeFrom(StatsAttributes other)
		{
			if (other == null)
			{
				return;
			}

			if (other.BaseStamina != 0)
			{
				BaseStamina = other.BaseStamina;
			}

			if (other.BaseAttack != 0)
			{
				BaseAttack = other.BaseAttack;
			}

			if (other.BaseDefense != 0)
			{
				BaseDefense = other.BaseDefense;
			}

			if (other.DodgeEnergyDelta != 0)
			{
				DodgeEnergyDelta = other.DodgeEnergyDelta;
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
						BaseStamina = input.ReadInt32();
						break;
					}

					case 16:
					{
						BaseAttack = input.ReadInt32();
						break;
					}

					case 24:
					{
						BaseDefense = input.ReadInt32();
						break;
					}

					case 64:
					{
						DodgeEnergyDelta = input.ReadInt32();
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
			return Equals(other as StatsAttributes);
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
			if (BaseStamina != 0)
			{
				hash ^= BaseStamina.GetHashCode();
			}

			if (BaseAttack != 0)
			{
				hash ^= BaseAttack.GetHashCode();
			}

			if (BaseDefense != 0)
			{
				hash ^= BaseDefense.GetHashCode();
			}

			if (DodgeEnergyDelta != 0)
			{
				hash ^= DodgeEnergyDelta.GetHashCode();
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