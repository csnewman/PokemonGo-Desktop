// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CaptureProbability.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Data/Capture/CaptureProbability.proto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

#pragma warning disable 1591, 0612, 3021

#region Designer generated code

using POGOProtos.Inventory.Item;
using pb = Google.Protobuf;
using pbc = Google.Protobuf.Collections;
using pbr = Google.Protobuf.Reflection;
using scg = System.Collections.Generic;

namespace POGOProtos.Data.Capture
{
	/// <summary>Holder for reflection information generated from POGOProtos/Data/Capture/CaptureProbability.proto</summary>
	public static partial class CaptureProbabilityReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Data/Capture/CaptureProbability.proto</summary>
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
		/// Initializes static members of the <see cref="CaptureProbabilityReflection"/> class.
		/// </summary>
		static CaptureProbabilityReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CjBQT0dPUHJvdG9zL0RhdGEvQ2FwdHVyZS9DYXB0dXJlUHJvYmFiaWxpdHku",
						"cHJvdG8SF1BPR09Qcm90b3MuRGF0YS5DYXB0dXJlGiZQT0dPUHJvdG9zL0lu",
						"dmVudG9yeS9JdGVtL0l0ZW1JZC5wcm90byKNAQoSQ2FwdHVyZVByb2JhYmls",
						"aXR5EjgKDXBva2ViYWxsX3R5cGUYASADKA4yIS5QT0dPUHJvdG9zLkludmVu",
						"dG9yeS5JdGVtLkl0ZW1JZBIbChNjYXB0dXJlX3Byb2JhYmlsaXR5GAIgAygC",
						"EiAKGHJldGljbGVfZGlmZmljdWx0eV9zY2FsZRgMIAEoAWIGcHJvdG8z"));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new[] { global::POGOProtos.Inventory.Item.ItemIdReflection.Descriptor, },
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Data.Capture.CaptureProbability),
							global::POGOProtos.Data.Capture.CaptureProbability.Parser,
							new[] { "PokeballType", "CaptureProbability_", "ReticleDifficultyScale" },
							null,
							null,
							null)
					}));
		}

		#endregion
	}

	#region Messages

	/// <summary>
	/// The capture probability.
	/// </summary>
	public sealed partial class CaptureProbability : pb::IMessage<CaptureProbability>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "pokeball_type" field.</summary>
		public const int PokeballTypeFieldNumber = 1;

		/// <summary>Field number for the "capture_probability" field.</summary>
		public const int CaptureProbability_FieldNumber = 2;

		/// <summary>Field number for the "reticle_difficulty_scale" field.</summary>
		public const int ReticleDifficultyScaleFieldNumber = 12;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<CaptureProbability> _parser =
			new pb::MessageParser<CaptureProbability>(() => new CaptureProbability());

		/// <summary>
		/// The _repeated_pokeball type_codec.
		/// </summary>
		private static readonly pb.FieldCodec<ItemId> _repeated_pokeballType_codec = pb::FieldCodec.ForEnum(
			10,
			x => (int)x,
			x => (global::POGOProtos.Inventory.Item.ItemId)x);

		/// <summary>
		/// The _repeated_capture probability_codec.
		/// </summary>
		private static readonly pb.FieldCodec<float> _repeated_captureProbability_codec = pb::FieldCodec.ForFloat(18);

		#endregion

		#region  Fields

		/// <summary>
		/// The capture probability_.
		/// </summary>
		private readonly pbc.RepeatedField<float> captureProbability_ = new pbc::RepeatedField<float>();

		/// <summary>
		/// The pokeball type_.
		/// </summary>
		private readonly pbc.RepeatedField<ItemId> pokeballType_ = new pbc::RepeatedField<ItemId>();

		/// <summary>
		/// The reticle difficulty scale_.
		/// </summary>
		private double reticleDifficultyScale_;

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="CaptureProbability"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public CaptureProbability()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="CaptureProbability"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public CaptureProbability(CaptureProbability other) : this()
		{
			pokeballType_ = other.pokeballType_.Clone();
			captureProbability_ = other.captureProbability_.Clone();
			reticleDifficultyScale_ = other.reticleDifficultyScale_;
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<CaptureProbability> Parser
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
				return global::POGOProtos.Data.Capture.CaptureProbabilityReflection.Descriptor.MessageTypes[0];
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
		/// Gets the pokeball type.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public pbc.RepeatedField<ItemId> PokeballType
		{
			get
			{
				return pokeballType_;
			}
		}

		/// <summary>
		/// Gets the capture probability_.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public pbc.RepeatedField<float> CaptureProbability_
		{
			get
			{
				return captureProbability_;
			}
		}

		/// <summary>
		/// Gets or sets the reticle difficulty scale.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public double ReticleDifficultyScale
		{
			get
			{
				return reticleDifficultyScale_;
			}

			set
			{
				reticleDifficultyScale_ = value;
			}
		}

		#endregion

		#region  Interface Implementations

		/// <summary>
		/// The clone.
		/// </summary>
		/// <returns>
		/// The <see cref="CaptureProbability"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public CaptureProbability Clone()
		{
			return new CaptureProbability(this);
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
		public bool Equals(CaptureProbability other)
		{
			if (ReferenceEquals(other, null))
			{
				return false;
			}

			if (ReferenceEquals(other, this))
			{
				return true;
			}

			if (!pokeballType_.Equals(other.pokeballType_))
			{
				return false;
			}

			if (!captureProbability_.Equals(other.captureProbability_))
			{
				return false;
			}

			if (ReticleDifficultyScale != other.ReticleDifficultyScale)
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
			pokeballType_.WriteTo(output, _repeated_pokeballType_codec);
			captureProbability_.WriteTo(output, _repeated_captureProbability_codec);
			if (ReticleDifficultyScale != 0D)
			{
				output.WriteRawTag(97);
				output.WriteDouble(ReticleDifficultyScale);
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
			size += pokeballType_.CalculateSize(_repeated_pokeballType_codec);
			size += captureProbability_.CalculateSize(_repeated_captureProbability_codec);
			if (ReticleDifficultyScale != 0D)
			{
				size += 1 + 8;
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
		public void MergeFrom(CaptureProbability other)
		{
			if (other == null)
			{
				return;
			}

			pokeballType_.Add(other.pokeballType_);
			captureProbability_.Add(other.captureProbability_);
			if (other.ReticleDifficultyScale != 0D)
			{
				ReticleDifficultyScale = other.ReticleDifficultyScale;
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
					case 8:
					{
						pokeballType_.AddEntriesFrom(input, _repeated_pokeballType_codec);
						break;
					}

					case 18:
					case 21:
					{
						captureProbability_.AddEntriesFrom(input, _repeated_captureProbability_codec);
						break;
					}

					case 97:
					{
						ReticleDifficultyScale = input.ReadDouble();
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
			return Equals(other as CaptureProbability);
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
			hash ^= pokeballType_.GetHashCode();
			hash ^= captureProbability_.GetHashCode();
			if (ReticleDifficultyScale != 0D)
			{
				hash ^= ReticleDifficultyScale.GetHashCode();
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