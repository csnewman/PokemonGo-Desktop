// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CatchPokemonLogEntry.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Data/Logs/CatchPokemonLogEntry.proto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

#pragma warning disable 1591, 0612, 3021

#region Designer generated code

using POGOProtos.Enums;
using pb = Google.Protobuf;
using pbc = Google.Protobuf.Collections;
using pbr = Google.Protobuf.Reflection;
using scg = System.Collections.Generic;

namespace POGOProtos.Data.Logs
{
	/// <summary>Holder for reflection information generated from POGOProtos/Data/Logs/CatchPokemonLogEntry.proto</summary>
	public static partial class CatchPokemonLogEntryReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Data/Logs/CatchPokemonLogEntry.proto</summary>
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
		/// Initializes static members of the <see cref="CatchPokemonLogEntryReflection"/> class.
		/// </summary>
		static CatchPokemonLogEntryReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"Ci9QT0dPUHJvdG9zL0RhdGEvTG9ncy9DYXRjaFBva2Vtb25Mb2dFbnRyeS5w",
						"cm90bxIUUE9HT1Byb3Rvcy5EYXRhLkxvZ3MaIFBPR09Qcm90b3MvRW51bXMv",
						"UG9rZW1vbklkLnByb3RvIvcBChRDYXRjaFBva2Vtb25Mb2dFbnRyeRJBCgZy",
						"ZXN1bHQYASABKA4yMS5QT0dPUHJvdG9zLkRhdGEuTG9ncy5DYXRjaFBva2Vt",
						"b25Mb2dFbnRyeS5SZXN1bHQSLwoKcG9rZW1vbl9pZBgCIAEoDjIbLlBPR09Q",
						"cm90b3MuRW51bXMuUG9rZW1vbklkEhUKDWNvbWJhdF9wb2ludHMYAyABKAUS",
						"FwoPcG9rZW1vbl9kYXRhX2lkGAQgASgEIjsKBlJlc3VsdBIJCgVVTlNFVBAA",
						"EhQKEFBPS0VNT05fQ0FQVFVSRUQQARIQCgxQT0tFTU9OX0ZMRUQQAmIGcHJv",
						"dG8z"));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new[] { global::POGOProtos.Enums.PokemonIdReflection.Descriptor, },
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Data.Logs.CatchPokemonLogEntry),
							global::POGOProtos.Data.Logs.CatchPokemonLogEntry.Parser,
							new[] { "Result", "PokemonId", "CombatPoints", "PokemonDataId" },
							null,
							new[] { typeof(global::POGOProtos.Data.Logs.CatchPokemonLogEntry.Types.Result) },
							null)
					}));
		}

		#endregion
	}

	#region Messages

	/// <summary>
	/// The catch pokemon log entry.
	/// </summary>
	public sealed partial class CatchPokemonLogEntry : pb::IMessage<CatchPokemonLogEntry>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "result" field.</summary>
		public const int ResultFieldNumber = 1;

		/// <summary>Field number for the "pokemon_id" field.</summary>
		public const int PokemonIdFieldNumber = 2;

		/// <summary>Field number for the "combat_points" field.</summary>
		public const int CombatPointsFieldNumber = 3;

		/// <summary>Field number for the "pokemon_data_id" field.</summary>
		public const int PokemonDataIdFieldNumber = 4;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<CatchPokemonLogEntry> _parser =
			new pb::MessageParser<CatchPokemonLogEntry>(() => new CatchPokemonLogEntry());

		#endregion

		#region  Fields

		/// <summary>
		/// The combat points_.
		/// </summary>
		private int combatPoints_;

		/// <summary>
		/// The pokemon data id_.
		/// </summary>
		private ulong pokemonDataId_;

		/// <summary>
		/// The pokemon id_.
		/// </summary>
		private PokemonId pokemonId_ = 0;

		/// <summary>
		/// The result_.
		/// </summary>
		private Types.Result result_ = 0;

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="CatchPokemonLogEntry"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public CatchPokemonLogEntry()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="CatchPokemonLogEntry"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public CatchPokemonLogEntry(CatchPokemonLogEntry other) : this()
		{
			result_ = other.result_;
			pokemonId_ = other.pokemonId_;
			combatPoints_ = other.combatPoints_;
			pokemonDataId_ = other.pokemonDataId_;
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<CatchPokemonLogEntry> Parser
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
				return global::POGOProtos.Data.Logs.CatchPokemonLogEntryReflection.Descriptor.MessageTypes[0];
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
		/// Gets or sets the result.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public Types.Result Result
		{
			get
			{
				return result_;
			}

			set
			{
				result_ = value;
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
		/// Gets or sets the combat points.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public int CombatPoints
		{
			get
			{
				return combatPoints_;
			}

			set
			{
				combatPoints_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the pokemon data id.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public ulong PokemonDataId
		{
			get
			{
				return pokemonDataId_;
			}

			set
			{
				pokemonDataId_ = value;
			}
		}

		#endregion

		#region  Interface Implementations

		/// <summary>
		/// The clone.
		/// </summary>
		/// <returns>
		/// The <see cref="CatchPokemonLogEntry"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public CatchPokemonLogEntry Clone()
		{
			return new CatchPokemonLogEntry(this);
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
		public bool Equals(CatchPokemonLogEntry other)
		{
			if (ReferenceEquals(other, null))
			{
				return false;
			}

			if (ReferenceEquals(other, this))
			{
				return true;
			}

			if (Result != other.Result)
			{
				return false;
			}

			if (PokemonId != other.PokemonId)
			{
				return false;
			}

			if (CombatPoints != other.CombatPoints)
			{
				return false;
			}

			if (PokemonDataId != other.PokemonDataId)
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
			if (Result != 0)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)Result);
			}

			if (PokemonId != 0)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)PokemonId);
			}

			if (CombatPoints != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(CombatPoints);
			}

			if (PokemonDataId != 0UL)
			{
				output.WriteRawTag(32);
				output.WriteUInt64(PokemonDataId);
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
			if (Result != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeEnumSize((int)Result);
			}

			if (PokemonId != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeEnumSize((int)PokemonId);
			}

			if (CombatPoints != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeInt32Size(CombatPoints);
			}

			if (PokemonDataId != 0UL)
			{
				size += 1 + pb::CodedOutputStream.ComputeUInt64Size(PokemonDataId);
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
		public void MergeFrom(CatchPokemonLogEntry other)
		{
			if (other == null)
			{
				return;
			}

			if (other.Result != 0)
			{
				Result = other.Result;
			}

			if (other.PokemonId != 0)
			{
				PokemonId = other.PokemonId;
			}

			if (other.CombatPoints != 0)
			{
				CombatPoints = other.CombatPoints;
			}

			if (other.PokemonDataId != 0UL)
			{
				PokemonDataId = other.PokemonDataId;
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
						result_ = (global::POGOProtos.Data.Logs.CatchPokemonLogEntry.Types.Result)input.ReadEnum();
						break;
					}

					case 16:
					{
						pokemonId_ = (global::POGOProtos.Enums.PokemonId)input.ReadEnum();
						break;
					}

					case 24:
					{
						CombatPoints = input.ReadInt32();
						break;
					}

					case 32:
					{
						PokemonDataId = input.ReadUInt64();
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
			return Equals(other as CatchPokemonLogEntry);
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
			if (Result != 0)
			{
				hash ^= Result.GetHashCode();
			}

			if (PokemonId != 0)
			{
				hash ^= PokemonId.GetHashCode();
			}

			if (CombatPoints != 0)
			{
				hash ^= CombatPoints.GetHashCode();
			}

			if (PokemonDataId != 0UL)
			{
				hash ^= PokemonDataId.GetHashCode();
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

		/// <summary>Container for nested types declared in the CatchPokemonLogEntry message type.</summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static partial class Types
		{
			#region Enums

			/// <summary>
			/// The result.
			/// </summary>
			public enum Result
			{
				/// <summary>
				/// The unset.
				/// </summary>
				[pbr::OriginalName("UNSET")] Unset = 0,

				/// <summary>
				/// The pokemon captured.
				/// </summary>
				[pbr::OriginalName("POKEMON_CAPTURED")] PokemonCaptured = 1,

				/// <summary>
				/// The pokemon fled.
				/// </summary>
				[pbr::OriginalName("POKEMON_FLED")] PokemonFled = 2,
			}

			#endregion
		}

		#endregion
	}

	#endregion
}

#endregion Designer generated code