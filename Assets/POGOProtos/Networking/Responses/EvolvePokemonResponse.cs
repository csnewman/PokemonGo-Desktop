// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EvolvePokemonResponse.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Networking/Responses/EvolvePokemonResponse.proto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

#pragma warning disable 1591, 0612, 3021

#region Designer generated code

using POGOProtos.Data;
using pb = Google.Protobuf;
using pbc = Google.Protobuf.Collections;
using pbr = Google.Protobuf.Reflection;
using scg = System.Collections.Generic;

namespace POGOProtos.Networking.Responses
{
	/// <summary>Holder for reflection information generated from POGOProtos/Networking/Responses/EvolvePokemonResponse.proto</summary>
	public static partial class EvolvePokemonResponseReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Networking/Responses/EvolvePokemonResponse.proto</summary>
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
		/// Initializes static members of the <see cref="EvolvePokemonResponseReflection"/> class.
		/// </summary>
		static EvolvePokemonResponseReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CjtQT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVzcG9uc2VzL0V2b2x2ZVBva2Vt",
						"b25SZXNwb25zZS5wcm90bxIfUE9HT1Byb3Rvcy5OZXR3b3JraW5nLlJlc3Bv",
						"bnNlcxohUE9HT1Byb3Rvcy9EYXRhL1Bva2Vtb25EYXRhLnByb3RvIvkCChVF",
						"dm9sdmVQb2tlbW9uUmVzcG9uc2USTQoGcmVzdWx0GAEgASgOMj0uUE9HT1By",
						"b3Rvcy5OZXR3b3JraW5nLlJlc3BvbnNlcy5Fdm9sdmVQb2tlbW9uUmVzcG9u",
						"c2UuUmVzdWx0EjoKFGV2b2x2ZWRfcG9rZW1vbl9kYXRhGAIgASgLMhwuUE9H",
						"T1Byb3Rvcy5EYXRhLlBva2Vtb25EYXRhEhoKEmV4cGVyaWVuY2VfYXdhcmRl",
						"ZBgDIAEoBRIVCg1jYW5keV9hd2FyZGVkGAQgASgFIqEBCgZSZXN1bHQSCQoF",
						"VU5TRVQQABILCgdTVUNDRVNTEAESGgoWRkFJTEVEX1BPS0VNT05fTUlTU0lO",
						"RxACEiEKHUZBSUxFRF9JTlNVRkZJQ0lFTlRfUkVTT1VSQ0VTEAMSIAocRkFJ",
						"TEVEX1BPS0VNT05fQ0FOTk9UX0VWT0xWRRAEEh4KGkZBSUxFRF9QT0tFTU9O",
						"X0lTX0RFUExPWUVEEAViBnByb3RvMw=="));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new[] { global::POGOProtos.Data.PokemonDataReflection.Descriptor, },
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Networking.Responses.EvolvePokemonResponse),
							global::POGOProtos.Networking.Responses.EvolvePokemonResponse.Parser,
							new[] { "Result", "EvolvedPokemonData", "ExperienceAwarded", "CandyAwarded" },
							null,
							new[] { typeof(global::POGOProtos.Networking.Responses.EvolvePokemonResponse.Types.Result) },
							null)
					}));
		}

		#endregion
	}

	#region Messages

	/// <summary>
	/// The evolve pokemon response.
	/// </summary>
	public sealed partial class EvolvePokemonResponse : pb::IMessage<EvolvePokemonResponse>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "result" field.</summary>
		public const int ResultFieldNumber = 1;

		/// <summary>Field number for the "evolved_pokemon_data" field.</summary>
		public const int EvolvedPokemonDataFieldNumber = 2;

		/// <summary>Field number for the "experience_awarded" field.</summary>
		public const int ExperienceAwardedFieldNumber = 3;

		/// <summary>Field number for the "candy_awarded" field.</summary>
		public const int CandyAwardedFieldNumber = 4;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<EvolvePokemonResponse> _parser =
			new pb::MessageParser<EvolvePokemonResponse>(() => new EvolvePokemonResponse());

		#endregion

		#region  Fields

		/// <summary>
		/// The candy awarded_.
		/// </summary>
		private int candyAwarded_;

		/// <summary>
		/// The evolved pokemon data_.
		/// </summary>
		private PokemonData evolvedPokemonData_;

		/// <summary>
		/// The experience awarded_.
		/// </summary>
		private int experienceAwarded_;

		/// <summary>
		/// The result_.
		/// </summary>
		private Types.Result result_ = 0;

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="EvolvePokemonResponse"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public EvolvePokemonResponse()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="EvolvePokemonResponse"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public EvolvePokemonResponse(EvolvePokemonResponse other) : this()
		{
			result_ = other.result_;
			EvolvedPokemonData = other.evolvedPokemonData_ != null ? other.EvolvedPokemonData.Clone() : null;
			experienceAwarded_ = other.experienceAwarded_;
			candyAwarded_ = other.candyAwarded_;
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<EvolvePokemonResponse> Parser
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
				return global::POGOProtos.Networking.Responses.EvolvePokemonResponseReflection.Descriptor.MessageTypes[0];
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
		/// Gets or sets the evolved pokemon data.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public PokemonData EvolvedPokemonData
		{
			get
			{
				return evolvedPokemonData_;
			}

			set
			{
				evolvedPokemonData_ = value;
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
		/// Gets or sets the candy awarded.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public int CandyAwarded
		{
			get
			{
				return candyAwarded_;
			}

			set
			{
				candyAwarded_ = value;
			}
		}

		#endregion

		#region  Interface Implementations

		/// <summary>
		/// The clone.
		/// </summary>
		/// <returns>
		/// The <see cref="EvolvePokemonResponse"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public EvolvePokemonResponse Clone()
		{
			return new EvolvePokemonResponse(this);
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
		public bool Equals(EvolvePokemonResponse other)
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

			if (!object.Equals(EvolvedPokemonData, other.EvolvedPokemonData))
			{
				return false;
			}

			if (ExperienceAwarded != other.ExperienceAwarded)
			{
				return false;
			}

			if (CandyAwarded != other.CandyAwarded)
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

			if (evolvedPokemonData_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(EvolvedPokemonData);
			}

			if (ExperienceAwarded != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(ExperienceAwarded);
			}

			if (CandyAwarded != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(CandyAwarded);
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

			if (evolvedPokemonData_ != null)
			{
				size += 1 + pb::CodedOutputStream.ComputeMessageSize(EvolvedPokemonData);
			}

			if (ExperienceAwarded != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeInt32Size(ExperienceAwarded);
			}

			if (CandyAwarded != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeInt32Size(CandyAwarded);
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
		public void MergeFrom(EvolvePokemonResponse other)
		{
			if (other == null)
			{
				return;
			}

			if (other.Result != 0)
			{
				Result = other.Result;
			}

			if (other.evolvedPokemonData_ != null)
			{
				if (evolvedPokemonData_ == null)
				{
					evolvedPokemonData_ = new global::POGOProtos.Data.PokemonData();
				}

				EvolvedPokemonData.MergeFrom(other.EvolvedPokemonData);
			}

			if (other.ExperienceAwarded != 0)
			{
				ExperienceAwarded = other.ExperienceAwarded;
			}

			if (other.CandyAwarded != 0)
			{
				CandyAwarded = other.CandyAwarded;
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
						result_ = (global::POGOProtos.Networking.Responses.EvolvePokemonResponse.Types.Result)input.ReadEnum();
						break;
					}

					case 18:
					{
						if (evolvedPokemonData_ == null)
						{
							evolvedPokemonData_ = new global::POGOProtos.Data.PokemonData();
						}

						input.ReadMessage(evolvedPokemonData_);
						break;
					}

					case 24:
					{
						ExperienceAwarded = input.ReadInt32();
						break;
					}

					case 32:
					{
						CandyAwarded = input.ReadInt32();
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
			return Equals(other as EvolvePokemonResponse);
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

			if (evolvedPokemonData_ != null)
			{
				hash ^= EvolvedPokemonData.GetHashCode();
			}

			if (ExperienceAwarded != 0)
			{
				hash ^= ExperienceAwarded.GetHashCode();
			}

			if (CandyAwarded != 0)
			{
				hash ^= CandyAwarded.GetHashCode();
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

		/// <summary>Container for nested types declared in the EvolvePokemonResponse message type.</summary>
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
				/// The success.
				/// </summary>
				[pbr::OriginalName("SUCCESS")] Success = 1,

				/// <summary>
				/// The failed pokemon missing.
				/// </summary>
				[pbr::OriginalName("FAILED_POKEMON_MISSING")] FailedPokemonMissing = 2,

				/// <summary>
				/// The failed insufficient resources.
				/// </summary>
				[pbr::OriginalName("FAILED_INSUFFICIENT_RESOURCES")] FailedInsufficientResources = 3,

				/// <summary>
				/// The failed pokemon cannot evolve.
				/// </summary>
				[pbr::OriginalName("FAILED_POKEMON_CANNOT_EVOLVE")] FailedPokemonCannotEvolve = 4,

				/// <summary>
				/// The failed pokemon is deployed.
				/// </summary>
				[pbr::OriginalName("FAILED_POKEMON_IS_DEPLOYED")] FailedPokemonIsDeployed = 5,
			}

			#endregion
		}

		#endregion
	}

	#endregion
}

#endregion Designer generated code