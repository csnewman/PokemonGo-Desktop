// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EggIncubators.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Inventory/EggIncubators.proto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

#pragma warning disable 1591, 0612, 3021

#region Designer generated code

using pb = Google.Protobuf;
using pbc = Google.Protobuf.Collections;
using pbr = Google.Protobuf.Reflection;
using scg = System.Collections.Generic;

namespace POGOProtos.Inventory
{
	/// <summary>Holder for reflection information generated from POGOProtos/Inventory/EggIncubators.proto</summary>
	public static partial class EggIncubatorsReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Inventory/EggIncubators.proto</summary>
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
		/// Initializes static members of the <see cref="EggIncubatorsReflection"/> class.
		/// </summary>
		static EggIncubatorsReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CihQT0dPUHJvdG9zL0ludmVudG9yeS9FZ2dJbmN1YmF0b3JzLnByb3RvEhRQ",
						"T0dPUHJvdG9zLkludmVudG9yeRonUE9HT1Byb3Rvcy9JbnZlbnRvcnkvRWdn",
						"SW5jdWJhdG9yLnByb3RvIkoKDUVnZ0luY3ViYXRvcnMSOQoNZWdnX2luY3Vi",
						"YXRvchgBIAMoCzIiLlBPR09Qcm90b3MuSW52ZW50b3J5LkVnZ0luY3ViYXRv",
						"cmIGcHJvdG8z"));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new[] { global::POGOProtos.Inventory.EggIncubatorReflection.Descriptor, },
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Inventory.EggIncubators),
							global::POGOProtos.Inventory.EggIncubators.Parser,
							new[] { "EggIncubator" },
							null,
							null,
							null)
					}));
		}

		#endregion
	}

	#region Messages

	/// <summary>
	/// The egg incubators.
	/// </summary>
	public sealed partial class EggIncubators : pb::IMessage<EggIncubators>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "egg_incubator" field.</summary>
		public const int EggIncubatorFieldNumber = 1;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<EggIncubators> _parser =
			new pb::MessageParser<EggIncubators>(() => new EggIncubators());

		/// <summary>
		/// The _repeated_egg incubator_codec.
		/// </summary>
		private static readonly pb.FieldCodec<EggIncubator> _repeated_eggIncubator_codec = pb::FieldCodec.ForMessage(
			10,
			global::POGOProtos.Inventory.EggIncubator.Parser);

		#endregion

		#region  Fields

		/// <summary>
		/// The egg incubator_.
		/// </summary>
		private readonly pbc.RepeatedField<EggIncubator> eggIncubator_ = new pbc::RepeatedField<EggIncubator>();

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="EggIncubators"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public EggIncubators()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="EggIncubators"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public EggIncubators(EggIncubators other) : this()
		{
			eggIncubator_ = other.eggIncubator_.Clone();
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<EggIncubators> Parser
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
				return global::POGOProtos.Inventory.EggIncubatorsReflection.Descriptor.MessageTypes[0];
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
		/// Gets the egg incubator.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public pbc.RepeatedField<EggIncubator> EggIncubator
		{
			get
			{
				return eggIncubator_;
			}
		}

		#endregion

		#region  Interface Implementations

		/// <summary>
		/// The clone.
		/// </summary>
		/// <returns>
		/// The <see cref="EggIncubators"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public EggIncubators Clone()
		{
			return new EggIncubators(this);
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
		public bool Equals(EggIncubators other)
		{
			if (ReferenceEquals(other, null))
			{
				return false;
			}

			if (ReferenceEquals(other, this))
			{
				return true;
			}

			if (!eggIncubator_.Equals(other.eggIncubator_))
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
			eggIncubator_.WriteTo(output, _repeated_eggIncubator_codec);
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
			size += eggIncubator_.CalculateSize(_repeated_eggIncubator_codec);
			return size;
		}

		/// <summary>
		/// The merge from.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public void MergeFrom(EggIncubators other)
		{
			if (other == null)
			{
				return;
			}

			eggIncubator_.Add(other.eggIncubator_);
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
						eggIncubator_.AddEntriesFrom(input, _repeated_eggIncubator_codec);
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
			return Equals(other as EggIncubators);
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
			hash ^= eggIncubator_.GetHashCode();
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