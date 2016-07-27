// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PokedexEntry.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Data/PokedexEntry.proto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

#pragma warning disable 1591, 0612, 3021

#region Designer generated code

using POGOProtos.Enums;
using pb = Google.Protobuf;
using pbc = Google.Protobuf.Collections;
using pbr = Google.Protobuf.Reflection;
using scg = System.Collections.Generic;

namespace POGOProtos.Data
{
	/// <summary>Holder for reflection information generated from POGOProtos/Data/PokedexEntry.proto</summary>
	public static partial class PokedexEntryReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Data/PokedexEntry.proto</summary>
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
		/// Initializes static members of the <see cref="PokedexEntryReflection"/> class.
		/// </summary>
		static PokedexEntryReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CiJQT0dPUHJvdG9zL0RhdGEvUG9rZWRleEVudHJ5LnByb3RvEg9QT0dPUHJv",
						"dG9zLkRhdGEaIFBPR09Qcm90b3MvRW51bXMvUG9rZW1vbklkLnByb3RvIqwB",
						"CgxQb2tlZGV4RW50cnkSLwoKcG9rZW1vbl9pZBgBIAEoDjIbLlBPR09Qcm90",
						"b3MuRW51bXMuUG9rZW1vbklkEhkKEXRpbWVzX2VuY291bnRlcmVkGAIgASgF",
						"EhYKDnRpbWVzX2NhcHR1cmVkGAMgASgFEh4KFmV2b2x1dGlvbl9zdG9uZV9w",
						"aWVjZXMYBCABKAUSGAoQZXZvbHV0aW9uX3N0b25lcxgFIAEoBWIGcHJvdG8z"));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new[] { global::POGOProtos.Enums.PokemonIdReflection.Descriptor, },
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Data.PokedexEntry),
							global::POGOProtos.Data.PokedexEntry.Parser,
							new[] { "PokemonId", "TimesEncountered", "TimesCaptured", "EvolutionStonePieces", "EvolutionStones" },
							null,
							null,
							null)
					}));
		}

		#endregion
	}

	#region Messages

	/// <summary>
	/// The pokedex entry.
	/// </summary>
	public sealed partial class PokedexEntry : pb::IMessage<PokedexEntry>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "pokemon_id" field.</summary>
		public const int PokemonIdFieldNumber = 1;

		/// <summary>Field number for the "times_encountered" field.</summary>
		public const int TimesEncounteredFieldNumber = 2;

		/// <summary>Field number for the "times_captured" field.</summary>
		public const int TimesCapturedFieldNumber = 3;

		/// <summary>Field number for the "evolution_stone_pieces" field.</summary>
		public const int EvolutionStonePiecesFieldNumber = 4;

		/// <summary>Field number for the "evolution_stones" field.</summary>
		public const int EvolutionStonesFieldNumber = 5;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<PokedexEntry> _parser =
			new pb::MessageParser<PokedexEntry>(() => new PokedexEntry());

		#endregion

		#region  Fields

		/// <summary>
		/// The evolution stone pieces_.
		/// </summary>
		private int evolutionStonePieces_;

		/// <summary>
		/// The evolution stones_.
		/// </summary>
		private int evolutionStones_;

		/// <summary>
		/// The pokemon id_.
		/// </summary>
		private PokemonId pokemonId_ = 0;

		/// <summary>
		/// The times captured_.
		/// </summary>
		private int timesCaptured_;

		/// <summary>
		/// The times encountered_.
		/// </summary>
		private int timesEncountered_;

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="PokedexEntry"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public PokedexEntry()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="PokedexEntry"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public PokedexEntry(PokedexEntry other) : this()
		{
			pokemonId_ = other.pokemonId_;
			timesEncountered_ = other.timesEncountered_;
			timesCaptured_ = other.timesCaptured_;
			evolutionStonePieces_ = other.evolutionStonePieces_;
			evolutionStones_ = other.evolutionStones_;
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<PokedexEntry> Parser
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
				return global::POGOProtos.Data.PokedexEntryReflection.Descriptor.MessageTypes[0];
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
		/// Gets or sets the pokemon id.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public PokemonId PokemonId
		{
			get
			{
				return pokemonId_;
			}

			set
			{
				pokemonId_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the times encountered.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public int TimesEncountered
		{
			get
			{
				return timesEncountered_;
			}

			set
			{
				timesEncountered_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the times captured.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public int TimesCaptured
		{
			get
			{
				return timesCaptured_;
			}

			set
			{
				timesCaptured_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the evolution stone pieces.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public int EvolutionStonePieces
		{
			get
			{
				return evolutionStonePieces_;
			}

			set
			{
				evolutionStonePieces_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the evolution stones.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public int EvolutionStones
		{
			get
			{
				return evolutionStones_;
			}

			set
			{
				evolutionStones_ = value;
			}
		}

		#endregion

		#region  Interface Implementations

		/// <summary>
		/// The clone.
		/// </summary>
		/// <returns>
		/// The <see cref="PokedexEntry"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public PokedexEntry Clone()
		{
			return new PokedexEntry(this);
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
		public bool Equals(PokedexEntry other)
		{
			if (ReferenceEquals(other, null))
			{
				return false;
			}

			if (ReferenceEquals(other, this))
			{
				return true;
			}

			if (PokemonId != other.PokemonId)
			{
				return false;
			}

			if (TimesEncountered != other.TimesEncountered)
			{
				return false;
			}

			if (TimesCaptured != other.TimesCaptured)
			{
				return false;
			}

			if (EvolutionStonePieces != other.EvolutionStonePieces)
			{
				return false;
			}

			if (EvolutionStones != other.EvolutionStones)
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
			if (PokemonId != 0)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)PokemonId);
			}

			if (TimesEncountered != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(TimesEncountered);
			}

			if (TimesCaptured != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(TimesCaptured);
			}

			if (EvolutionStonePieces != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(EvolutionStonePieces);
			}

			if (EvolutionStones != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(EvolutionStones);
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
			if (PokemonId != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeEnumSize((int)PokemonId);
			}

			if (TimesEncountered != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeInt32Size(TimesEncountered);
			}

			if (TimesCaptured != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeInt32Size(TimesCaptured);
			}

			if (EvolutionStonePieces != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeInt32Size(EvolutionStonePieces);
			}

			if (EvolutionStones != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeInt32Size(EvolutionStones);
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
		public void MergeFrom(PokedexEntry other)
		{
			if (other == null)
			{
				return;
			}

			if (other.PokemonId != 0)
			{
				PokemonId = other.PokemonId;
			}

			if (other.TimesEncountered != 0)
			{
				TimesEncountered = other.TimesEncountered;
			}

			if (other.TimesCaptured != 0)
			{
				TimesCaptured = other.TimesCaptured;
			}

			if (other.EvolutionStonePieces != 0)
			{
				EvolutionStonePieces = other.EvolutionStonePieces;
			}

			if (other.EvolutionStones != 0)
			{
				EvolutionStones = other.EvolutionStones;
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
						pokemonId_ = (global::POGOProtos.Enums.PokemonId)input.ReadEnum();
						break;
					}

					case 16:
					{
						TimesEncountered = input.ReadInt32();
						break;
					}

					case 24:
					{
						TimesCaptured = input.ReadInt32();
						break;
					}

					case 32:
					{
						EvolutionStonePieces = input.ReadInt32();
						break;
					}

					case 40:
					{
						EvolutionStones = input.ReadInt32();
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
			return Equals(other as PokedexEntry);
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
			if (PokemonId != 0)
			{
				hash ^= PokemonId.GetHashCode();
			}

			if (TimesEncountered != 0)
			{
				hash ^= TimesEncountered.GetHashCode();
			}

			if (TimesCaptured != 0)
			{
				hash ^= TimesCaptured.GetHashCode();
			}

			if (EvolutionStonePieces != 0)
			{
				hash ^= EvolutionStonePieces.GetHashCode();
			}

			if (EvolutionStones != 0)
			{
				hash ^= EvolutionStones.GetHashCode();
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