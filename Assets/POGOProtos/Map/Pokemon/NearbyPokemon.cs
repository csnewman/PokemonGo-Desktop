// --------------------------------------------------------------------------------------------------------------------
// <copyright file="NearbyPokemon.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Map/Pokemon/NearbyPokemon.proto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

#pragma warning disable 1591, 0612, 3021

#region Designer generated code

using POGOProtos.Enums;
using pb = Google.Protobuf;
using pbc = Google.Protobuf.Collections;
using pbr = Google.Protobuf.Reflection;
using scg = System.Collections.Generic;

namespace POGOProtos.Map.Pokemon
{
	/// <summary>Holder for reflection information generated from POGOProtos/Map/Pokemon/NearbyPokemon.proto</summary>
	public static partial class NearbyPokemonReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Map/Pokemon/NearbyPokemon.proto</summary>
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
		/// Initializes static members of the <see cref="NearbyPokemonReflection"/> class.
		/// </summary>
		static NearbyPokemonReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CipQT0dPUHJvdG9zL01hcC9Qb2tlbW9uL05lYXJieVBva2Vtb24ucHJvdG8S",
						"FlBPR09Qcm90b3MuTWFwLlBva2Vtb24aIFBPR09Qcm90b3MvRW51bXMvUG9r",
						"ZW1vbklkLnByb3RvInIKDU5lYXJieVBva2Vtb24SLwoKcG9rZW1vbl9pZBgB",
						"IAEoDjIbLlBPR09Qcm90b3MuRW51bXMuUG9rZW1vbklkEhoKEmRpc3RhbmNl",
						"X2luX21ldGVycxgCIAEoAhIUCgxlbmNvdW50ZXJfaWQYAyABKAZiBnByb3Rv",
						"Mw=="));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new[] { global::POGOProtos.Enums.PokemonIdReflection.Descriptor, },
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Map.Pokemon.NearbyPokemon),
							global::POGOProtos.Map.Pokemon.NearbyPokemon.Parser,
							new[] { "PokemonId", "DistanceInMeters", "EncounterId" },
							null,
							null,
							null)
					}));
		}

		#endregion
	}

	#region Messages

	/// <summary>
	/// The nearby pokemon.
	/// </summary>
	public sealed partial class NearbyPokemon : pb::IMessage<NearbyPokemon>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "pokemon_id" field.</summary>
		public const int PokemonIdFieldNumber = 1;

		/// <summary>Field number for the "distance_in_meters" field.</summary>
		public const int DistanceInMetersFieldNumber = 2;

		/// <summary>Field number for the "encounter_id" field.</summary>
		public const int EncounterIdFieldNumber = 3;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<NearbyPokemon> _parser =
			new pb::MessageParser<NearbyPokemon>(() => new NearbyPokemon());

		#endregion

		#region  Fields

		/// <summary>
		/// The distance in meters_.
		/// </summary>
		private float distanceInMeters_;

		/// <summary>
		/// The encounter id_.
		/// </summary>
		private ulong encounterId_;

		/// <summary>
		/// The pokemon id_.
		/// </summary>
		private PokemonId pokemonId_ = 0;

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="NearbyPokemon"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public NearbyPokemon()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="NearbyPokemon"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public NearbyPokemon(NearbyPokemon other) : this()
		{
			pokemonId_ = other.pokemonId_;
			distanceInMeters_ = other.distanceInMeters_;
			encounterId_ = other.encounterId_;
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<NearbyPokemon> Parser
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
				return global::POGOProtos.Map.Pokemon.NearbyPokemonReflection.Descriptor.MessageTypes[0];
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
		/// Gets or sets the distance in meters.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public float DistanceInMeters
		{
			get
			{
				return distanceInMeters_;
			}

			set
			{
				distanceInMeters_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the encounter id.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public ulong EncounterId
		{
			get
			{
				return encounterId_;
			}

			set
			{
				encounterId_ = value;
			}
		}

		#endregion

		#region  Interface Implementations

		/// <summary>
		/// The clone.
		/// </summary>
		/// <returns>
		/// The <see cref="NearbyPokemon"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public NearbyPokemon Clone()
		{
			return new NearbyPokemon(this);
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
		public bool Equals(NearbyPokemon other)
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

			if (DistanceInMeters != other.DistanceInMeters)
			{
				return false;
			}

			if (EncounterId != other.EncounterId)
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

			if (DistanceInMeters != 0F)
			{
				output.WriteRawTag(21);
				output.WriteFloat(DistanceInMeters);
			}

			if (EncounterId != 0UL)
			{
				output.WriteRawTag(25);
				output.WriteFixed64(EncounterId);
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

			if (DistanceInMeters != 0F)
			{
				size += 1 + 4;
			}

			if (EncounterId != 0UL)
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
		public void MergeFrom(NearbyPokemon other)
		{
			if (other == null)
			{
				return;
			}

			if (other.PokemonId != 0)
			{
				PokemonId = other.PokemonId;
			}

			if (other.DistanceInMeters != 0F)
			{
				DistanceInMeters = other.DistanceInMeters;
			}

			if (other.EncounterId != 0UL)
			{
				EncounterId = other.EncounterId;
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

					case 21:
					{
						DistanceInMeters = input.ReadFloat();
						break;
					}

					case 25:
					{
						EncounterId = input.ReadFixed64();
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
			return Equals(other as NearbyPokemon);
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

			if (DistanceInMeters != 0F)
			{
				hash ^= DistanceInMeters.GetHashCode();
			}

			if (EncounterId != 0UL)
			{
				hash ^= EncounterId.GetHashCode();
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