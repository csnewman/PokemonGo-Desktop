// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PotionAttributes.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Settings/Master/Item/PotionAttributes.proto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

#pragma warning disable 1591, 0612, 3021

#region Designer generated code

using pb = Google.Protobuf;
using pbc = Google.Protobuf.Collections;
using pbr = Google.Protobuf.Reflection;
using scg = System.Collections.Generic;

namespace POGOProtos.Settings.Master.Item
{
	/// <summary>Holder for reflection information generated from POGOProtos/Settings/Master/Item/PotionAttributes.proto</summary>
	public static partial class PotionAttributesReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Settings/Master/Item/PotionAttributes.proto</summary>
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
		/// Initializes static members of the <see cref="PotionAttributesReflection"/> class.
		/// </summary>
		static PotionAttributesReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CjZQT0dPUHJvdG9zL1NldHRpbmdzL01hc3Rlci9JdGVtL1BvdGlvbkF0dHJp",
						"YnV0ZXMucHJvdG8SH1BPR09Qcm90b3MuU2V0dGluZ3MuTWFzdGVyLkl0ZW0i",
						"OwoQUG90aW9uQXR0cmlidXRlcxITCgtzdGFfcGVyY2VudBgBIAEoAhISCgpz",
						"dGFfYW1vdW50GAIgASgFYgZwcm90bzM="));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new pbr.FileDescriptor[] { },
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Settings.Master.Item.PotionAttributes),
							global::POGOProtos.Settings.Master.Item.PotionAttributes.Parser,
							new[] { "StaPercent", "StaAmount" },
							null,
							null,
							null)
					}));
		}

		#endregion
	}

	#region Messages

	/// <summary>
	/// The potion attributes.
	/// </summary>
	public sealed partial class PotionAttributes : pb::IMessage<PotionAttributes>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "sta_percent" field.</summary>
		public const int StaPercentFieldNumber = 1;

		/// <summary>Field number for the "sta_amount" field.</summary>
		public const int StaAmountFieldNumber = 2;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<PotionAttributes> _parser =
			new pb::MessageParser<PotionAttributes>(() => new PotionAttributes());

		#endregion

		#region  Fields

		/// <summary>
		/// The sta amount_.
		/// </summary>
		private int staAmount_;

		/// <summary>
		/// The sta percent_.
		/// </summary>
		private float staPercent_;

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="PotionAttributes"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public PotionAttributes()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="PotionAttributes"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public PotionAttributes(PotionAttributes other) : this()
		{
			staPercent_ = other.staPercent_;
			staAmount_ = other.staAmount_;
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<PotionAttributes> Parser
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
				return global::POGOProtos.Settings.Master.Item.PotionAttributesReflection.Descriptor.MessageTypes[0];
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
		/// Gets or sets the sta percent.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public float StaPercent
		{
			get
			{
				return staPercent_;
			}

			set
			{
				staPercent_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the sta amount.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public int StaAmount
		{
			get
			{
				return staAmount_;
			}

			set
			{
				staAmount_ = value;
			}
		}

		#endregion

		#region  Interface Implementations

		/// <summary>
		/// The clone.
		/// </summary>
		/// <returns>
		/// The <see cref="PotionAttributes"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public PotionAttributes Clone()
		{
			return new PotionAttributes(this);
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
		public bool Equals(PotionAttributes other)
		{
			if (ReferenceEquals(other, null))
			{
				return false;
			}

			if (ReferenceEquals(other, this))
			{
				return true;
			}

			if (StaPercent != other.StaPercent)
			{
				return false;
			}

			if (StaAmount != other.StaAmount)
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
			if (StaPercent != 0F)
			{
				output.WriteRawTag(13);
				output.WriteFloat(StaPercent);
			}

			if (StaAmount != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(StaAmount);
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
			if (StaPercent != 0F)
			{
				size += 1 + 4;
			}

			if (StaAmount != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeInt32Size(StaAmount);
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
		public void MergeFrom(PotionAttributes other)
		{
			if (other == null)
			{
				return;
			}

			if (other.StaPercent != 0F)
			{
				StaPercent = other.StaPercent;
			}

			if (other.StaAmount != 0)
			{
				StaAmount = other.StaAmount;
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
						StaPercent = input.ReadFloat();
						break;
					}

					case 16:
					{
						StaAmount = input.ReadInt32();
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
			return Equals(other as PotionAttributes);
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
			if (StaPercent != 0F)
			{
				hash ^= StaPercent.GetHashCode();
			}

			if (StaAmount != 0)
			{
				hash ^= StaAmount.GetHashCode();
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