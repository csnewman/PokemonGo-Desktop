// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ExperienceBoostAttributes.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Settings/Master/Item/ExperienceBoostAttributes.proto
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
	/// <summary>Holder for reflection information generated from POGOProtos/Settings/Master/Item/ExperienceBoostAttributes.proto</summary>
	public static partial class ExperienceBoostAttributesReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Settings/Master/Item/ExperienceBoostAttributes.proto</summary>
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
		/// Initializes static members of the <see cref="ExperienceBoostAttributesReflection"/> class.
		/// </summary>
		static ExperienceBoostAttributesReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"Cj9QT0dPUHJvdG9zL1NldHRpbmdzL01hc3Rlci9JdGVtL0V4cGVyaWVuY2VC",
						"b29zdEF0dHJpYnV0ZXMucHJvdG8SH1BPR09Qcm90b3MuU2V0dGluZ3MuTWFz",
						"dGVyLkl0ZW0iTQoZRXhwZXJpZW5jZUJvb3N0QXR0cmlidXRlcxIVCg14cF9t",
						"dWx0aXBsaWVyGAEgASgCEhkKEWJvb3N0X2R1cmF0aW9uX21zGAIgASgFYgZw",
						"cm90bzM="));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new pbr.FileDescriptor[] { },
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Settings.Master.Item.ExperienceBoostAttributes),
							global::POGOProtos.Settings.Master.Item.ExperienceBoostAttributes.Parser,
							new[] { "XpMultiplier", "BoostDurationMs" },
							null,
							null,
							null)
					}));
		}

		#endregion
	}

	#region Messages

	/// <summary>
	/// The experience boost attributes.
	/// </summary>
	public sealed partial class ExperienceBoostAttributes : pb::IMessage<ExperienceBoostAttributes>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "xp_multiplier" field.</summary>
		public const int XpMultiplierFieldNumber = 1;

		/// <summary>Field number for the "boost_duration_ms" field.</summary>
		public const int BoostDurationMsFieldNumber = 2;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<ExperienceBoostAttributes> _parser =
			new pb::MessageParser<ExperienceBoostAttributes>(() => new ExperienceBoostAttributes());

		#endregion

		#region  Fields

		/// <summary>
		/// The boost duration ms_.
		/// </summary>
		private int boostDurationMs_;

		/// <summary>
		/// The xp multiplier_.
		/// </summary>
		private float xpMultiplier_;

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="ExperienceBoostAttributes"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public ExperienceBoostAttributes()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="ExperienceBoostAttributes"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public ExperienceBoostAttributes(ExperienceBoostAttributes other) : this()
		{
			xpMultiplier_ = other.xpMultiplier_;
			boostDurationMs_ = other.boostDurationMs_;
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<ExperienceBoostAttributes> Parser
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
				return global::POGOProtos.Settings.Master.Item.ExperienceBoostAttributesReflection.Descriptor.MessageTypes[0];
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
		/// Gets or sets the xp multiplier.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public float XpMultiplier
		{
			get
			{
				return xpMultiplier_;
			}

			set
			{
				xpMultiplier_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the boost duration ms.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public int BoostDurationMs
		{
			get
			{
				return boostDurationMs_;
			}

			set
			{
				boostDurationMs_ = value;
			}
		}

		#endregion

		#region  Interface Implementations

		/// <summary>
		/// The clone.
		/// </summary>
		/// <returns>
		/// The <see cref="ExperienceBoostAttributes"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public ExperienceBoostAttributes Clone()
		{
			return new ExperienceBoostAttributes(this);
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
		public bool Equals(ExperienceBoostAttributes other)
		{
			if (ReferenceEquals(other, null))
			{
				return false;
			}

			if (ReferenceEquals(other, this))
			{
				return true;
			}

			if (XpMultiplier != other.XpMultiplier)
			{
				return false;
			}

			if (BoostDurationMs != other.BoostDurationMs)
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
			if (XpMultiplier != 0F)
			{
				output.WriteRawTag(13);
				output.WriteFloat(XpMultiplier);
			}

			if (BoostDurationMs != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(BoostDurationMs);
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
			if (XpMultiplier != 0F)
			{
				size += 1 + 4;
			}

			if (BoostDurationMs != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeInt32Size(BoostDurationMs);
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
		public void MergeFrom(ExperienceBoostAttributes other)
		{
			if (other == null)
			{
				return;
			}

			if (other.XpMultiplier != 0F)
			{
				XpMultiplier = other.XpMultiplier;
			}

			if (other.BoostDurationMs != 0)
			{
				BoostDurationMs = other.BoostDurationMs;
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
						XpMultiplier = input.ReadFloat();
						break;
					}

					case 16:
					{
						BoostDurationMs = input.ReadInt32();
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
			return Equals(other as ExperienceBoostAttributes);
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
			if (XpMultiplier != 0F)
			{
				hash ^= XpMultiplier.GetHashCode();
			}

			if (BoostDurationMs != 0)
			{
				hash ^= BoostDurationMs.GetHashCode();
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