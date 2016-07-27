// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EggIncubatorAttributes.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Settings/Master/Item/EggIncubatorAttributes.proto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

#pragma warning disable 1591, 0612, 3021

#region Designer generated code

using POGOProtos.Inventory;
using pb = Google.Protobuf;
using pbc = Google.Protobuf.Collections;
using pbr = Google.Protobuf.Reflection;
using scg = System.Collections.Generic;

namespace POGOProtos.Settings.Master.Item
{
	/// <summary>Holder for reflection information generated from POGOProtos/Settings/Master/Item/EggIncubatorAttributes.proto</summary>
	public static partial class EggIncubatorAttributesReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Settings/Master/Item/EggIncubatorAttributes.proto</summary>
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
		/// Initializes static members of the <see cref="EggIncubatorAttributesReflection"/> class.
		/// </summary>
		static EggIncubatorAttributesReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CjxQT0dPUHJvdG9zL1NldHRpbmdzL01hc3Rlci9JdGVtL0VnZ0luY3ViYXRv",
						"ckF0dHJpYnV0ZXMucHJvdG8SH1BPR09Qcm90b3MuU2V0dGluZ3MuTWFzdGVy",
						"Lkl0ZW0aK1BPR09Qcm90b3MvSW52ZW50b3J5L0VnZ0luY3ViYXRvclR5cGUu",
						"cHJvdG8igwEKFkVnZ0luY3ViYXRvckF0dHJpYnV0ZXMSPgoOaW5jdWJhdG9y",
						"X3R5cGUYASABKA4yJi5QT0dPUHJvdG9zLkludmVudG9yeS5FZ2dJbmN1YmF0",
						"b3JUeXBlEgwKBHVzZXMYAiABKAUSGwoTZGlzdGFuY2VfbXVsdGlwbGllchgD",
						"IAEoAmIGcHJvdG8z"));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new[] { global::POGOProtos.Inventory.EggIncubatorTypeReflection.Descriptor, },
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Settings.Master.Item.EggIncubatorAttributes),
							global::POGOProtos.Settings.Master.Item.EggIncubatorAttributes.Parser,
							new[] { "IncubatorType", "Uses", "DistanceMultiplier" },
							null,
							null,
							null)
					}));
		}

		#endregion
	}

	#region Messages

	/// <summary>
	/// The egg incubator attributes.
	/// </summary>
	public sealed partial class EggIncubatorAttributes : pb::IMessage<EggIncubatorAttributes>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "incubator_type" field.</summary>
		public const int IncubatorTypeFieldNumber = 1;

		/// <summary>Field number for the "uses" field.</summary>
		public const int UsesFieldNumber = 2;

		/// <summary>Field number for the "distance_multiplier" field.</summary>
		public const int DistanceMultiplierFieldNumber = 3;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<EggIncubatorAttributes> _parser =
			new pb::MessageParser<EggIncubatorAttributes>(() => new EggIncubatorAttributes());

		#endregion

		#region  Fields

		/// <summary>
		/// The distance multiplier_.
		/// </summary>
		private float distanceMultiplier_;

		/// <summary>
		/// The incubator type_.
		/// </summary>
		private EggIncubatorType incubatorType_ = 0;

		/// <summary>
		/// The uses_.
		/// </summary>
		private int uses_;

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="EggIncubatorAttributes"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public EggIncubatorAttributes()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="EggIncubatorAttributes"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public EggIncubatorAttributes(EggIncubatorAttributes other) : this()
		{
			incubatorType_ = other.incubatorType_;
			uses_ = other.uses_;
			distanceMultiplier_ = other.distanceMultiplier_;
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<EggIncubatorAttributes> Parser
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
				return global::POGOProtos.Settings.Master.Item.EggIncubatorAttributesReflection.Descriptor.MessageTypes[0];
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
		/// Gets or sets the incubator type.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public EggIncubatorType IncubatorType
		{
			get
			{
				return incubatorType_;
			}

			set
			{
				incubatorType_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the uses.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public int Uses
		{
			get
			{
				return uses_;
			}

			set
			{
				uses_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the distance multiplier.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public float DistanceMultiplier
		{
			get
			{
				return distanceMultiplier_;
			}

			set
			{
				distanceMultiplier_ = value;
			}
		}

		#endregion

		#region  Interface Implementations

		/// <summary>
		/// The clone.
		/// </summary>
		/// <returns>
		/// The <see cref="EggIncubatorAttributes"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public EggIncubatorAttributes Clone()
		{
			return new EggIncubatorAttributes(this);
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
		public bool Equals(EggIncubatorAttributes other)
		{
			if (ReferenceEquals(other, null))
			{
				return false;
			}

			if (ReferenceEquals(other, this))
			{
				return true;
			}

			if (IncubatorType != other.IncubatorType)
			{
				return false;
			}

			if (Uses != other.Uses)
			{
				return false;
			}

			if (DistanceMultiplier != other.DistanceMultiplier)
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
			if (IncubatorType != 0)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)IncubatorType);
			}

			if (Uses != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(Uses);
			}

			if (DistanceMultiplier != 0F)
			{
				output.WriteRawTag(29);
				output.WriteFloat(DistanceMultiplier);
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
			if (IncubatorType != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeEnumSize((int)IncubatorType);
			}

			if (Uses != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeInt32Size(Uses);
			}

			if (DistanceMultiplier != 0F)
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
		public void MergeFrom(EggIncubatorAttributes other)
		{
			if (other == null)
			{
				return;
			}

			if (other.IncubatorType != 0)
			{
				IncubatorType = other.IncubatorType;
			}

			if (other.Uses != 0)
			{
				Uses = other.Uses;
			}

			if (other.DistanceMultiplier != 0F)
			{
				DistanceMultiplier = other.DistanceMultiplier;
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
						incubatorType_ = (global::POGOProtos.Inventory.EggIncubatorType)input.ReadEnum();
						break;
					}

					case 16:
					{
						Uses = input.ReadInt32();
						break;
					}

					case 29:
					{
						DistanceMultiplier = input.ReadFloat();
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
			return Equals(other as EggIncubatorAttributes);
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
			if (IncubatorType != 0)
			{
				hash ^= IncubatorType.GetHashCode();
			}

			if (Uses != 0)
			{
				hash ^= Uses.GetHashCode();
			}

			if (DistanceMultiplier != 0F)
			{
				hash ^= DistanceMultiplier.GetHashCode();
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