// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EncounterAttributes.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Settings/Master/Pokemon/EncounterAttributes.proto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

#pragma warning disable 1591, 0612, 3021

#region Designer generated code

using POGOProtos.Enums;
using pb = Google.Protobuf;
using pbc = Google.Protobuf.Collections;
using pbr = Google.Protobuf.Reflection;
using scg = System.Collections.Generic;

namespace POGOProtos.Settings.Master.Pokemon
{
	/// <summary>Holder for reflection information generated from POGOProtos/Settings/Master/Pokemon/EncounterAttributes.proto</summary>
	public static partial class EncounterAttributesReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Settings/Master/Pokemon/EncounterAttributes.proto</summary>
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
		/// Initializes static members of the <see cref="EncounterAttributesReflection"/> class.
		/// </summary>
		static EncounterAttributesReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CjxQT0dPUHJvdG9zL1NldHRpbmdzL01hc3Rlci9Qb2tlbW9uL0VuY291bnRl",
						"ckF0dHJpYnV0ZXMucHJvdG8SIlBPR09Qcm90b3MuU2V0dGluZ3MuTWFzdGVy",
						"LlBva2Vtb24aKlBPR09Qcm90b3MvRW51bXMvUG9rZW1vbk1vdmVtZW50VHlw",
						"ZS5wcm90byKmAgoTRW5jb3VudGVyQXR0cmlidXRlcxIZChFiYXNlX2NhcHR1",
						"cmVfcmF0ZRgBIAEoAhIWCg5iYXNlX2ZsZWVfcmF0ZRgCIAEoAhIaChJjb2xs",
						"aXNpb25fcmFkaXVzX20YAyABKAISGgoSY29sbGlzaW9uX2hlaWdodF9tGAQg",
						"ASgCEh8KF2NvbGxpc2lvbl9oZWFkX3JhZGl1c19tGAUgASgCEjwKDW1vdmVt",
						"ZW50X3R5cGUYBiABKA4yJS5QT0dPUHJvdG9zLkVudW1zLlBva2Vtb25Nb3Zl",
						"bWVudFR5cGUSGAoQbW92ZW1lbnRfdGltZXJfcxgHIAEoAhITCgtqdW1wX3Rp",
						"bWVfcxgIIAEoAhIWCg5hdHRhY2tfdGltZXJfcxgJIAEoAmIGcHJvdG8z"));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new[] { global::POGOProtos.Enums.PokemonMovementTypeReflection.Descriptor, },
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Settings.Master.Pokemon.EncounterAttributes),
							global::POGOProtos.Settings.Master.Pokemon.EncounterAttributes.Parser,
							new[]
							{
								"BaseCaptureRate", "BaseFleeRate", "CollisionRadiusM", "CollisionHeightM", "CollisionHeadRadiusM",
								"MovementType", "MovementTimerS", "JumpTimeS", "AttackTimerS"
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
	/// The encounter attributes.
	/// </summary>
	public sealed partial class EncounterAttributes : pb::IMessage<EncounterAttributes>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "base_capture_rate" field.</summary>
		public const int BaseCaptureRateFieldNumber = 1;

		/// <summary>Field number for the "base_flee_rate" field.</summary>
		public const int BaseFleeRateFieldNumber = 2;

		/// <summary>Field number for the "collision_radius_m" field.</summary>
		public const int CollisionRadiusMFieldNumber = 3;

		/// <summary>Field number for the "collision_height_m" field.</summary>
		public const int CollisionHeightMFieldNumber = 4;

		/// <summary>Field number for the "collision_head_radius_m" field.</summary>
		public const int CollisionHeadRadiusMFieldNumber = 5;

		/// <summary>Field number for the "movement_type" field.</summary>
		public const int MovementTypeFieldNumber = 6;

		/// <summary>Field number for the "movement_timer_s" field.</summary>
		public const int MovementTimerSFieldNumber = 7;

		/// <summary>Field number for the "jump_time_s" field.</summary>
		public const int JumpTimeSFieldNumber = 8;

		/// <summary>Field number for the "attack_timer_s" field.</summary>
		public const int AttackTimerSFieldNumber = 9;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<EncounterAttributes> _parser =
			new pb::MessageParser<EncounterAttributes>(() => new EncounterAttributes());

		#endregion

		#region  Fields

		/// <summary>
		/// The attack timer s_.
		/// </summary>
		private float attackTimerS_;

		/// <summary>
		/// The base capture rate_.
		/// </summary>
		private float baseCaptureRate_;

		/// <summary>
		/// The base flee rate_.
		/// </summary>
		private float baseFleeRate_;

		/// <summary>
		/// The collision head radius m_.
		/// </summary>
		private float collisionHeadRadiusM_;

		/// <summary>
		/// The collision height m_.
		/// </summary>
		private float collisionHeightM_;

		/// <summary>
		/// The collision radius m_.
		/// </summary>
		private float collisionRadiusM_;

		/// <summary>
		/// The jump time s_.
		/// </summary>
		private float jumpTimeS_;

		/// <summary>
		/// The movement timer s_.
		/// </summary>
		private float movementTimerS_;

		/// <summary>
		/// The movement type_.
		/// </summary>
		private PokemonMovementType movementType_ = 0;

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="EncounterAttributes"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public EncounterAttributes()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="EncounterAttributes"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public EncounterAttributes(EncounterAttributes other) : this()
		{
			baseCaptureRate_ = other.baseCaptureRate_;
			baseFleeRate_ = other.baseFleeRate_;
			collisionRadiusM_ = other.collisionRadiusM_;
			collisionHeightM_ = other.collisionHeightM_;
			collisionHeadRadiusM_ = other.collisionHeadRadiusM_;
			movementType_ = other.movementType_;
			movementTimerS_ = other.movementTimerS_;
			jumpTimeS_ = other.jumpTimeS_;
			attackTimerS_ = other.attackTimerS_;
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<EncounterAttributes> Parser
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
				return global::POGOProtos.Settings.Master.Pokemon.EncounterAttributesReflection.Descriptor.MessageTypes[0];
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
		/// Gets or sets the base capture rate.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public float BaseCaptureRate
		{
			get
			{
				return baseCaptureRate_;
			}

			set
			{
				baseCaptureRate_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the base flee rate.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public float BaseFleeRate
		{
			get
			{
				return baseFleeRate_;
			}

			set
			{
				baseFleeRate_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the collision radius m.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public float CollisionRadiusM
		{
			get
			{
				return collisionRadiusM_;
			}

			set
			{
				collisionRadiusM_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the collision height m.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public float CollisionHeightM
		{
			get
			{
				return collisionHeightM_;
			}

			set
			{
				collisionHeightM_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the collision head radius m.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public float CollisionHeadRadiusM
		{
			get
			{
				return collisionHeadRadiusM_;
			}

			set
			{
				collisionHeadRadiusM_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the movement type.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public PokemonMovementType MovementType
		{
			get
			{
				return movementType_;
			}

			set
			{
				movementType_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the movement timer s.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public float MovementTimerS
		{
			get
			{
				return movementTimerS_;
			}

			set
			{
				movementTimerS_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the jump time s.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public float JumpTimeS
		{
			get
			{
				return jumpTimeS_;
			}

			set
			{
				jumpTimeS_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the attack timer s.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public float AttackTimerS
		{
			get
			{
				return attackTimerS_;
			}

			set
			{
				attackTimerS_ = value;
			}
		}

		#endregion

		#region  Interface Implementations

		/// <summary>
		/// The clone.
		/// </summary>
		/// <returns>
		/// The <see cref="EncounterAttributes"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public EncounterAttributes Clone()
		{
			return new EncounterAttributes(this);
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
		public bool Equals(EncounterAttributes other)
		{
			if (ReferenceEquals(other, null))
			{
				return false;
			}

			if (ReferenceEquals(other, this))
			{
				return true;
			}

			if (BaseCaptureRate != other.BaseCaptureRate)
			{
				return false;
			}

			if (BaseFleeRate != other.BaseFleeRate)
			{
				return false;
			}

			if (CollisionRadiusM != other.CollisionRadiusM)
			{
				return false;
			}

			if (CollisionHeightM != other.CollisionHeightM)
			{
				return false;
			}

			if (CollisionHeadRadiusM != other.CollisionHeadRadiusM)
			{
				return false;
			}

			if (MovementType != other.MovementType)
			{
				return false;
			}

			if (MovementTimerS != other.MovementTimerS)
			{
				return false;
			}

			if (JumpTimeS != other.JumpTimeS)
			{
				return false;
			}

			if (AttackTimerS != other.AttackTimerS)
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
			if (BaseCaptureRate != 0F)
			{
				output.WriteRawTag(13);
				output.WriteFloat(BaseCaptureRate);
			}

			if (BaseFleeRate != 0F)
			{
				output.WriteRawTag(21);
				output.WriteFloat(BaseFleeRate);
			}

			if (CollisionRadiusM != 0F)
			{
				output.WriteRawTag(29);
				output.WriteFloat(CollisionRadiusM);
			}

			if (CollisionHeightM != 0F)
			{
				output.WriteRawTag(37);
				output.WriteFloat(CollisionHeightM);
			}

			if (CollisionHeadRadiusM != 0F)
			{
				output.WriteRawTag(45);
				output.WriteFloat(CollisionHeadRadiusM);
			}

			if (MovementType != 0)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)MovementType);
			}

			if (MovementTimerS != 0F)
			{
				output.WriteRawTag(61);
				output.WriteFloat(MovementTimerS);
			}

			if (JumpTimeS != 0F)
			{
				output.WriteRawTag(69);
				output.WriteFloat(JumpTimeS);
			}

			if (AttackTimerS != 0F)
			{
				output.WriteRawTag(77);
				output.WriteFloat(AttackTimerS);
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
			if (BaseCaptureRate != 0F)
			{
				size += 1 + 4;
			}

			if (BaseFleeRate != 0F)
			{
				size += 1 + 4;
			}

			if (CollisionRadiusM != 0F)
			{
				size += 1 + 4;
			}

			if (CollisionHeightM != 0F)
			{
				size += 1 + 4;
			}

			if (CollisionHeadRadiusM != 0F)
			{
				size += 1 + 4;
			}

			if (MovementType != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeEnumSize((int)MovementType);
			}

			if (MovementTimerS != 0F)
			{
				size += 1 + 4;
			}

			if (JumpTimeS != 0F)
			{
				size += 1 + 4;
			}

			if (AttackTimerS != 0F)
			{
				size += 1 + 4;
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
		public void MergeFrom(EncounterAttributes other)
		{
			if (other == null)
			{
				return;
			}

			if (other.BaseCaptureRate != 0F)
			{
				BaseCaptureRate = other.BaseCaptureRate;
			}

			if (other.BaseFleeRate != 0F)
			{
				BaseFleeRate = other.BaseFleeRate;
			}

			if (other.CollisionRadiusM != 0F)
			{
				CollisionRadiusM = other.CollisionRadiusM;
			}

			if (other.CollisionHeightM != 0F)
			{
				CollisionHeightM = other.CollisionHeightM;
			}

			if (other.CollisionHeadRadiusM != 0F)
			{
				CollisionHeadRadiusM = other.CollisionHeadRadiusM;
			}

			if (other.MovementType != 0)
			{
				MovementType = other.MovementType;
			}

			if (other.MovementTimerS != 0F)
			{
				MovementTimerS = other.MovementTimerS;
			}

			if (other.JumpTimeS != 0F)
			{
				JumpTimeS = other.JumpTimeS;
			}

			if (other.AttackTimerS != 0F)
			{
				AttackTimerS = other.AttackTimerS;
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
					case 13:
					{
						BaseCaptureRate = input.ReadFloat();
						break;
					}

					case 21:
					{
						BaseFleeRate = input.ReadFloat();
						break;
					}

					case 29:
					{
						CollisionRadiusM = input.ReadFloat();
						break;
					}

					case 37:
					{
						CollisionHeightM = input.ReadFloat();
						break;
					}

					case 45:
					{
						CollisionHeadRadiusM = input.ReadFloat();
						break;
					}

					case 48:
					{
						movementType_ = (global::POGOProtos.Enums.PokemonMovementType)input.ReadEnum();
						break;
					}

					case 61:
					{
						MovementTimerS = input.ReadFloat();
						break;
					}

					case 69:
					{
						JumpTimeS = input.ReadFloat();
						break;
					}

					case 77:
					{
						AttackTimerS = input.ReadFloat();
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
			return Equals(other as EncounterAttributes);
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
			if (BaseCaptureRate != 0F)
			{
				hash ^= BaseCaptureRate.GetHashCode();
			}

			if (BaseFleeRate != 0F)
			{
				hash ^= BaseFleeRate.GetHashCode();
			}

			if (CollisionRadiusM != 0F)
			{
				hash ^= CollisionRadiusM.GetHashCode();
			}

			if (CollisionHeightM != 0F)
			{
				hash ^= CollisionHeightM.GetHashCode();
			}

			if (CollisionHeadRadiusM != 0F)
			{
				hash ^= CollisionHeadRadiusM.GetHashCode();
			}

			if (MovementType != 0)
			{
				hash ^= MovementType.GetHashCode();
			}

			if (MovementTimerS != 0F)
			{
				hash ^= MovementTimerS.GetHashCode();
			}

			if (JumpTimeS != 0F)
			{
				hash ^= JumpTimeS.GetHashCode();
			}

			if (AttackTimerS != 0F)
			{
				hash ^= AttackTimerS.GetHashCode();
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