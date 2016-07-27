// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ReviveAttributes.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Settings/Master/Item/ReviveAttributes.proto
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
	/// <summary>Holder for reflection information generated from POGOProtos/Settings/Master/Item/ReviveAttributes.proto</summary>
	public static partial class ReviveAttributesReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Settings/Master/Item/ReviveAttributes.proto</summary>
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
		/// Initializes static members of the <see cref="ReviveAttributesReflection"/> class.
		/// </summary>
		static ReviveAttributesReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CjZQT0dPUHJvdG9zL1NldHRpbmdzL01hc3Rlci9JdGVtL1Jldml2ZUF0dHJp",
						"YnV0ZXMucHJvdG8SH1BPR09Qcm90b3MuU2V0dGluZ3MuTWFzdGVyLkl0ZW0i",
						"JwoQUmV2aXZlQXR0cmlidXRlcxITCgtzdGFfcGVyY2VudBgBIAEoAmIGcHJv",
						"dG8z"));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new pbr.FileDescriptor[] { },
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Settings.Master.Item.ReviveAttributes),
							global::POGOProtos.Settings.Master.Item.ReviveAttributes.Parser,
							new[] { "StaPercent" },
							null,
							null,
							null)
					}));
		}

		#endregion
	}

	#region Messages

	/// <summary>
	/// The revive attributes.
	/// </summary>
	public sealed partial class ReviveAttributes : pb::IMessage<ReviveAttributes>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "sta_percent" field.</summary>
		public const int StaPercentFieldNumber = 1;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<ReviveAttributes> _parser =
			new pb::MessageParser<ReviveAttributes>(() => new ReviveAttributes());

		#endregion

		#region  Fields

		/// <summary>
		/// The sta percent_.
		/// </summary>
		private float staPercent_;

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="ReviveAttributes"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public ReviveAttributes()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="ReviveAttributes"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public ReviveAttributes(ReviveAttributes other) : this()
		{
			staPercent_ = other.staPercent_;
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<ReviveAttributes> Parser
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
				return global::POGOProtos.Settings.Master.Item.ReviveAttributesReflection.Descriptor.MessageTypes[0];
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

		#endregion

		#region  Interface Implementations

		/// <summary>
		/// The clone.
		/// </summary>
		/// <returns>
		/// The <see cref="ReviveAttributes"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public ReviveAttributes Clone()
		{
			return new ReviveAttributes(this);
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
		public bool Equals(ReviveAttributes other)
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

			return size;
		}

		/// <summary>
		/// The merge from.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public void MergeFrom(ReviveAttributes other)
		{
			if (other == null)
			{
				return;
			}

			if (other.StaPercent != 0F)
			{
				StaPercent = other.StaPercent;
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
			return Equals(other as ReviveAttributes);
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