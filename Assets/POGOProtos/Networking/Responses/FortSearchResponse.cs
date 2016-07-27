// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FortSearchResponse.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Networking/Responses/FortSearchResponse.proto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

#pragma warning disable 1591, 0612, 3021

#region Designer generated code

using POGOProtos.Data;
using POGOProtos.Inventory.Item;
using pb = Google.Protobuf;
using pbc = Google.Protobuf.Collections;
using pbr = Google.Protobuf.Reflection;
using scg = System.Collections.Generic;

namespace POGOProtos.Networking.Responses
{
	/// <summary>Holder for reflection information generated from POGOProtos/Networking/Responses/FortSearchResponse.proto</summary>
	public static partial class FortSearchResponseReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Networking/Responses/FortSearchResponse.proto</summary>
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
		/// Initializes static members of the <see cref="FortSearchResponseReflection"/> class.
		/// </summary>
		static FortSearchResponseReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CjhQT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVzcG9uc2VzL0ZvcnRTZWFyY2hS",
						"ZXNwb25zZS5wcm90bxIfUE9HT1Byb3Rvcy5OZXR3b3JraW5nLlJlc3BvbnNl",
						"cxohUE9HT1Byb3Rvcy9EYXRhL1Bva2Vtb25EYXRhLnByb3RvGilQT0dPUHJv",
						"dG9zL0ludmVudG9yeS9JdGVtL0l0ZW1Bd2FyZC5wcm90byK7AwoSRm9ydFNl",
						"YXJjaFJlc3BvbnNlEkoKBnJlc3VsdBgBIAEoDjI6LlBPR09Qcm90b3MuTmV0",
						"d29ya2luZy5SZXNwb25zZXMuRm9ydFNlYXJjaFJlc3BvbnNlLlJlc3VsdBI7",
						"Cg1pdGVtc19hd2FyZGVkGAIgAygLMiQuUE9HT1Byb3Rvcy5JbnZlbnRvcnku",
						"SXRlbS5JdGVtQXdhcmQSFAoMZ2Vtc19hd2FyZGVkGAMgASgFEjYKEHBva2Vt",
						"b25fZGF0YV9lZ2cYBCABKAsyHC5QT0dPUHJvdG9zLkRhdGEuUG9rZW1vbkRh",
						"dGESGgoSZXhwZXJpZW5jZV9hd2FyZGVkGAUgASgFEiYKHmNvb2xkb3duX2Nv",
						"bXBsZXRlX3RpbWVzdGFtcF9tcxgGIAEoAxIiChpjaGFpbl9oYWNrX3NlcXVl",
						"bmNlX251bWJlchgHIAEoBSJmCgZSZXN1bHQSEQoNTk9fUkVTVUxUX1NFVBAA",
						"EgsKB1NVQ0NFU1MQARIQCgxPVVRfT0ZfUkFOR0UQAhIWChJJTl9DT09MRE9X",
						"Tl9QRVJJT0QQAxISCg5JTlZFTlRPUllfRlVMTBAEYgZwcm90bzM="));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new[]
				{
					global::POGOProtos.Data.PokemonDataReflection.Descriptor,
					global::POGOProtos.Inventory.Item.ItemAwardReflection.Descriptor,
				},
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Networking.Responses.FortSearchResponse),
							global::POGOProtos.Networking.Responses.FortSearchResponse.Parser,
							new[]
							{
								"Result", "ItemsAwarded", "GemsAwarded", "PokemonDataEgg", "ExperienceAwarded", "CooldownCompleteTimestampMs",
								"ChainHackSequenceNumber"
							},
							null,
							new[] { typeof(global::POGOProtos.Networking.Responses.FortSearchResponse.Types.Result) },
							null)
					}));
		}

		#endregion
	}

	#region Messages

	/// <summary>
	/// The fort search response.
	/// </summary>
	public sealed partial class FortSearchResponse : pb::IMessage<FortSearchResponse>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "result" field.</summary>
		public const int ResultFieldNumber = 1;

		/// <summary>Field number for the "items_awarded" field.</summary>
		public const int ItemsAwardedFieldNumber = 2;

		/// <summary>Field number for the "gems_awarded" field.</summary>
		public const int GemsAwardedFieldNumber = 3;

		/// <summary>Field number for the "pokemon_data_egg" field.</summary>
		public const int PokemonDataEggFieldNumber = 4;

		/// <summary>Field number for the "experience_awarded" field.</summary>
		public const int ExperienceAwardedFieldNumber = 5;

		/// <summary>Field number for the "cooldown_complete_timestamp_ms" field.</summary>
		public const int CooldownCompleteTimestampMsFieldNumber = 6;

		/// <summary>Field number for the "chain_hack_sequence_number" field.</summary>
		public const int ChainHackSequenceNumberFieldNumber = 7;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<FortSearchResponse> _parser =
			new pb::MessageParser<FortSearchResponse>(() => new FortSearchResponse());

		/// <summary>
		/// The _repeated_items awarded_codec.
		/// </summary>
		private static readonly pb.FieldCodec<ItemAward> _repeated_itemsAwarded_codec = pb::FieldCodec.ForMessage(
			18,
			global::POGOProtos.Inventory.Item.ItemAward.Parser);

		#endregion

		#region  Fields

		/// <summary>
		/// The chain hack sequence number_.
		/// </summary>
		private int chainHackSequenceNumber_;

		/// <summary>
		/// The cooldown complete timestamp ms_.
		/// </summary>
		private long cooldownCompleteTimestampMs_;

		/// <summary>
		/// The experience awarded_.
		/// </summary>
		private int experienceAwarded_;

		/// <summary>
		/// The gems awarded_.
		/// </summary>
		private int gemsAwarded_;

		/// <summary>
		/// The items awarded_.
		/// </summary>
		private readonly pbc.RepeatedField<ItemAward> itemsAwarded_ = new pbc::RepeatedField<ItemAward>();

		/// <summary>
		/// The pokemon data egg_.
		/// </summary>
		private PokemonData pokemonDataEgg_;

		/// <summary>
		/// The result_.
		/// </summary>
		private Types.Result result_ = 0;

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="FortSearchResponse"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public FortSearchResponse()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="FortSearchResponse"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public FortSearchResponse(FortSearchResponse other) : this()
		{
			result_ = other.result_;
			itemsAwarded_ = other.itemsAwarded_.Clone();
			gemsAwarded_ = other.gemsAwarded_;
			PokemonDataEgg = other.pokemonDataEgg_ != null ? other.PokemonDataEgg.Clone() : null;
			experienceAwarded_ = other.experienceAwarded_;
			cooldownCompleteTimestampMs_ = other.cooldownCompleteTimestampMs_;
			chainHackSequenceNumber_ = other.chainHackSequenceNumber_;
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<FortSearchResponse> Parser
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
				return global::POGOProtos.Networking.Responses.FortSearchResponseReflection.Descriptor.MessageTypes[0];
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
		/// Gets the items awarded.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public pbc.RepeatedField<ItemAward> ItemsAwarded
		{
			get
			{
				return itemsAwarded_;
			}
		}

		/// <summary>
		/// Gets or sets the gems awarded.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public int GemsAwarded
		{
			get
			{
				return gemsAwarded_;
			}

			set
			{
				gemsAwarded_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the pokemon data egg.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public PokemonData PokemonDataEgg
		{
			get
			{
				return pokemonDataEgg_;
			}

			set
			{
				pokemonDataEgg_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the experience awarded.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public int ExperienceAwarded
		{
			get
			{
				return experienceAwarded_;
			}

			set
			{
				experienceAwarded_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the cooldown complete timestamp ms.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public long CooldownCompleteTimestampMs
		{
			get
			{
				return cooldownCompleteTimestampMs_;
			}

			set
			{
				cooldownCompleteTimestampMs_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the chain hack sequence number.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public int ChainHackSequenceNumber
		{
			get
			{
				return chainHackSequenceNumber_;
			}

			set
			{
				chainHackSequenceNumber_ = value;
			}
		}

		#endregion

		#region  Interface Implementations

		/// <summary>
		/// The clone.
		/// </summary>
		/// <returns>
		/// The <see cref="FortSearchResponse"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public FortSearchResponse Clone()
		{
			return new FortSearchResponse(this);
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
		public bool Equals(FortSearchResponse other)
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

			if (!itemsAwarded_.Equals(other.itemsAwarded_))
			{
				return false;
			}

			if (GemsAwarded != other.GemsAwarded)
			{
				return false;
			}

			if (!object.Equals(PokemonDataEgg, other.PokemonDataEgg))
			{
				return false;
			}

			if (ExperienceAwarded != other.ExperienceAwarded)
			{
				return false;
			}

			if (CooldownCompleteTimestampMs != other.CooldownCompleteTimestampMs)
			{
				return false;
			}

			if (ChainHackSequenceNumber != other.ChainHackSequenceNumber)
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

			itemsAwarded_.WriteTo(output, _repeated_itemsAwarded_codec);
			if (GemsAwarded != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(GemsAwarded);
			}

			if (pokemonDataEgg_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(PokemonDataEgg);
			}

			if (ExperienceAwarded != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(ExperienceAwarded);
			}

			if (CooldownCompleteTimestampMs != 0L)
			{
				output.WriteRawTag(48);
				output.WriteInt64(CooldownCompleteTimestampMs);
			}

			if (ChainHackSequenceNumber != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(ChainHackSequenceNumber);
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

			size += itemsAwarded_.CalculateSize(_repeated_itemsAwarded_codec);
			if (GemsAwarded != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeInt32Size(GemsAwarded);
			}

			if (pokemonDataEgg_ != null)
			{
				size += 1 + pb::CodedOutputStream.ComputeMessageSize(PokemonDataEgg);
			}

			if (ExperienceAwarded != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeInt32Size(ExperienceAwarded);
			}

			if (CooldownCompleteTimestampMs != 0L)
			{
				size += 1 + pb::CodedOutputStream.ComputeInt64Size(CooldownCompleteTimestampMs);
			}

			if (ChainHackSequenceNumber != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeInt32Size(ChainHackSequenceNumber);
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
		public void MergeFrom(FortSearchResponse other)
		{
			if (other == null)
			{
				return;
			}

			if (other.Result != 0)
			{
				Result = other.Result;
			}

			itemsAwarded_.Add(other.itemsAwarded_);
			if (other.GemsAwarded != 0)
			{
				GemsAwarded = other.GemsAwarded;
			}

			if (other.pokemonDataEgg_ != null)
			{
				if (pokemonDataEgg_ == null)
				{
					pokemonDataEgg_ = new global::POGOProtos.Data.PokemonData();
				}

				PokemonDataEgg.MergeFrom(other.PokemonDataEgg);
			}

			if (other.ExperienceAwarded != 0)
			{
				ExperienceAwarded = other.ExperienceAwarded;
			}

			if (other.CooldownCompleteTimestampMs != 0L)
			{
				CooldownCompleteTimestampMs = other.CooldownCompleteTimestampMs;
			}

			if (other.ChainHackSequenceNumber != 0)
			{
				ChainHackSequenceNumber = other.ChainHackSequenceNumber;
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
						result_ = (global::POGOProtos.Networking.Responses.FortSearchResponse.Types.Result)input.ReadEnum();
						break;
					}

					case 18:
					{
						itemsAwarded_.AddEntriesFrom(input, _repeated_itemsAwarded_codec);
						break;
					}

					case 24:
					{
						GemsAwarded = input.ReadInt32();
						break;
					}

					case 34:
					{
						if (pokemonDataEgg_ == null)
						{
							pokemonDataEgg_ = new global::POGOProtos.Data.PokemonData();
						}

						input.ReadMessage(pokemonDataEgg_);
						break;
					}

					case 40:
					{
						ExperienceAwarded = input.ReadInt32();
						break;
					}

					case 48:
					{
						CooldownCompleteTimestampMs = input.ReadInt64();
						break;
					}

					case 56:
					{
						ChainHackSequenceNumber = input.ReadInt32();
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
			return Equals(other as FortSearchResponse);
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

			hash ^= itemsAwarded_.GetHashCode();
			if (GemsAwarded != 0)
			{
				hash ^= GemsAwarded.GetHashCode();
			}

			if (pokemonDataEgg_ != null)
			{
				hash ^= PokemonDataEgg.GetHashCode();
			}

			if (ExperienceAwarded != 0)
			{
				hash ^= ExperienceAwarded.GetHashCode();
			}

			if (CooldownCompleteTimestampMs != 0L)
			{
				hash ^= CooldownCompleteTimestampMs.GetHashCode();
			}

			if (ChainHackSequenceNumber != 0)
			{
				hash ^= ChainHackSequenceNumber.GetHashCode();
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

		/// <summary>Container for nested types declared in the FortSearchResponse message type.</summary>
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
				/// The no result set.
				/// </summary>
				[pbr::OriginalName("NO_RESULT_SET")] NoResultSet = 0,

				/// <summary>
				/// The success.
				/// </summary>
				[pbr::OriginalName("SUCCESS")] Success = 1,

				/// <summary>
				/// The out of range.
				/// </summary>
				[pbr::OriginalName("OUT_OF_RANGE")] OutOfRange = 2,

				/// <summary>
				/// The in cooldown period.
				/// </summary>
				[pbr::OriginalName("IN_COOLDOWN_PERIOD")] InCooldownPeriod = 3,

				/// <summary>
				/// The inventory full.
				/// </summary>
				[pbr::OriginalName("INVENTORY_FULL")] InventoryFull = 4,
			}

			#endregion
		}

		#endregion
	}

	#endregion
}

#endregion Designer generated code