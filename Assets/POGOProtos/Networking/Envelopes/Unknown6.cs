// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Unknown6.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Networking/Envelopes/Unknown6.proto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

#pragma warning disable 1591, 0612, 3021

#region Designer generated code

using pb = Google.Protobuf;
using pbc = Google.Protobuf.Collections;
using pbr = Google.Protobuf.Reflection;
using scg = System.Collections.Generic;

namespace POGOProtos.Networking.Envelopes
{
	/// <summary>Holder for reflection information generated from POGOProtos/Networking/Envelopes/Unknown6.proto</summary>
	public static partial class Unknown6Reflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Networking/Envelopes/Unknown6.proto</summary>
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
		/// Initializes static members of the <see cref="Unknown6Reflection"/> class.
		/// </summary>
		static Unknown6Reflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"Ci5QT0dPUHJvdG9zL05ldHdvcmtpbmcvRW52ZWxvcGVzL1Vua25vd242LnBy",
						"b3RvEh9QT0dPUHJvdG9zLk5ldHdvcmtpbmcuRW52ZWxvcGVzIoABCghVbmtu",
						"b3duNhIQCgh1bmtub3duMRgBIAEoBRJECgh1bmtub3duMhgCIAEoCzIyLlBP",
						"R09Qcm90b3MuTmV0d29ya2luZy5FbnZlbG9wZXMuVW5rbm93bjYuVW5rbm93",
						"bjIaHAoIVW5rbm93bjISEAoIdW5rbm93bjEYASABKAxiBnByb3RvMw=="));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new pbr.FileDescriptor[] { },
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Networking.Envelopes.Unknown6),
							global::POGOProtos.Networking.Envelopes.Unknown6.Parser,
							new[] { "Unknown1", "Unknown2" },
							null,
							null,
							new[]
							{
								new pbr::GeneratedClrTypeInfo(
									typeof(global::POGOProtos.Networking.Envelopes.Unknown6.Types.Unknown2),
									global::POGOProtos.Networking.Envelopes.Unknown6.Types.Unknown2.Parser,
									new[] { "Unknown1" },
									null,
									null,
									null)
							})
					}));
		}

		#endregion
	}

	#region Messages

	/// <summary>
	/// The unknown 6.
	/// </summary>
	public sealed partial class Unknown6 : pb::IMessage<Unknown6>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "unknown1" field.</summary>
		public const int Unknown1FieldNumber = 1;

		/// <summary>Field number for the "unknown2" field.</summary>
		public const int Unknown2FieldNumber = 2;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<Unknown6> _parser = new pb::MessageParser<Unknown6>(() => new Unknown6());

		#endregion

		#region  Fields

		/// <summary>
		/// The unknown 1_.
		/// </summary>
		private int unknown1_;

		/// <summary>
		/// The unknown 2_.
		/// </summary>
		private Types.Unknown2 unknown2_;

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="Unknown6"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public Unknown6()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="Unknown6"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public Unknown6(Unknown6 other) : this()
		{
			unknown1_ = other.unknown1_;
			Unknown2 = other.unknown2_ != null ? other.Unknown2.Clone() : null;
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<Unknown6> Parser
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
				return global::POGOProtos.Networking.Envelopes.Unknown6Reflection.Descriptor.MessageTypes[0];
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
		/// 6
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public int Unknown1
		{
			get
			{
				return unknown1_;
			}

			set
			{
				unknown1_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the unknown 2.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public Types.Unknown2 Unknown2
		{
			get
			{
				return unknown2_;
			}

			set
			{
				unknown2_ = value;
			}
		}

		#endregion

		#region  Interface Implementations

		/// <summary>
		/// The clone.
		/// </summary>
		/// <returns>
		/// The <see cref="Unknown6"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public Unknown6 Clone()
		{
			return new Unknown6(this);
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
		public bool Equals(Unknown6 other)
		{
			if (ReferenceEquals(other, null))
			{
				return false;
			}

			if (ReferenceEquals(other, this))
			{
				return true;
			}

			if (Unknown1 != other.Unknown1)
			{
				return false;
			}

			if (!object.Equals(Unknown2, other.Unknown2))
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
			if (Unknown1 != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(Unknown1);
			}

			if (unknown2_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(Unknown2);
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
			if (Unknown1 != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeInt32Size(Unknown1);
			}

			if (unknown2_ != null)
			{
				size += 1 + pb::CodedOutputStream.ComputeMessageSize(Unknown2);
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
		public void MergeFrom(Unknown6 other)
		{
			if (other == null)
			{
				return;
			}

			if (other.Unknown1 != 0)
			{
				Unknown1 = other.Unknown1;
			}

			if (other.unknown2_ != null)
			{
				if (unknown2_ == null)
				{
					unknown2_ = new global::POGOProtos.Networking.Envelopes.Unknown6.Types.Unknown2();
				}

				Unknown2.MergeFrom(other.Unknown2);
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
						Unknown1 = input.ReadInt32();
						break;
					}

					case 18:
					{
						if (unknown2_ == null)
						{
							unknown2_ = new global::POGOProtos.Networking.Envelopes.Unknown6.Types.Unknown2();
						}

						input.ReadMessage(unknown2_);
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
			return Equals(other as Unknown6);
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
			if (Unknown1 != 0)
			{
				hash ^= Unknown1.GetHashCode();
			}

			if (unknown2_ != null)
			{
				hash ^= Unknown2.GetHashCode();
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

		#region Nested types

		/// <summary>Container for nested types declared in the Unknown6 message type.</summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static partial class Types
		{
			/// <summary>
			/// The unknown 2.
			/// </summary>
			public sealed partial class Unknown2 : pb::IMessage<Unknown2>
			{
				#region Static Fields and Constants

				/// <summary>Field number for the "unknown1" field.</summary>
				public const int Unknown1FieldNumber = 1;

				/// <summary>
				/// The _parser.
				/// </summary>
				private static readonly pb.MessageParser<Unknown2> _parser = new pb::MessageParser<Unknown2>(() => new Unknown2());

				#endregion

				#region  Fields

				/// <summary>
				/// The unknown 1_.
				/// </summary>
				private pb.ByteString unknown1_ = pb::ByteString.Empty;

				#endregion

				#region  Constructors

				/// <summary>
				/// Initializes a new instance of the <see cref="Unknown2"/> class.
				/// </summary>
				[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
				public Unknown2()
				{
					OnConstruction();
				}

				/// <summary>
				/// Initializes a new instance of the <see cref="Unknown2"/> class.
				/// </summary>
				/// <param name="other">
				/// The other.
				/// </param>
				[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
				public Unknown2(Unknown2 other) : this()
				{
					unknown1_ = other.unknown1_;
				}

				#endregion

				#region  Properties - Public

				/// <summary>
				/// Gets the parser.
				/// </summary>
				[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
				public static pb.MessageParser<Unknown2> Parser
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
						return global::POGOProtos.Networking.Envelopes.Unknown6.Descriptor.NestedTypes[0];
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
				/// Gets or sets the unknown 1.
				/// </summary>
				[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
				public pb.ByteString Unknown1
				{
					get
					{
						return unknown1_;
					}

					set
					{
						unknown1_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
					}
				}

				#endregion

				#region  Interface Implementations

				/// <summary>
				/// The clone.
				/// </summary>
				/// <returns>
				/// The <see cref="Unknown2"/>.
				/// </returns>
				[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
				public Unknown2 Clone()
				{
					return new Unknown2(this);
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
				public bool Equals(Unknown2 other)
				{
					if (ReferenceEquals(other, null))
					{
						return false;
					}

					if (ReferenceEquals(other, this))
					{
						return true;
					}

					if (Unknown1 != other.Unknown1)
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
					if (Unknown1.Length != 0)
					{
						output.WriteRawTag(10);
						output.WriteBytes(Unknown1);
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
					if (Unknown1.Length != 0)
					{
						size += 1 + pb::CodedOutputStream.ComputeBytesSize(Unknown1);
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
				public void MergeFrom(Unknown2 other)
				{
					if (other == null)
					{
						return;
					}

					if (other.Unknown1.Length != 0)
					{
						Unknown1 = other.Unknown1;
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
							{
								Unknown1 = input.ReadBytes();
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
					return Equals(other as Unknown2);
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
					if (Unknown1.Length != 0)
					{
						hash ^= Unknown1.GetHashCode();
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
		}

		#endregion
	}

	#endregion
}

#endregion Designer generated code