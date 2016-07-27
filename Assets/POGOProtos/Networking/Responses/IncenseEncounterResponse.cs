// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IncenseEncounterResponse.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Networking/Responses/IncenseEncounterResponse.proto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

#pragma warning disable 1591, 0612, 3021

#region Designer generated code

using POGOProtos.Data;
using POGOProtos.Data.Capture;
using pb = Google.Protobuf;
using pbc = Google.Protobuf.Collections;
using pbr = Google.Protobuf.Reflection;
using scg = System.Collections.Generic;

namespace POGOProtos.Networking.Responses
{
	/// <summary>Holder for reflection information generated from POGOProtos/Networking/Responses/IncenseEncounterResponse.proto</summary>
	public static partial class IncenseEncounterResponseReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Networking/Responses/IncenseEncounterResponse.proto</summary>
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
		/// Initializes static members of the <see cref="IncenseEncounterResponseReflection"/> class.
		/// </summary>
		static IncenseEncounterResponseReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"Cj5QT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVzcG9uc2VzL0luY2Vuc2VFbmNv",
						"dW50ZXJSZXNwb25zZS5wcm90bxIfUE9HT1Byb3Rvcy5OZXR3b3JraW5nLlJl",
						"c3BvbnNlcxohUE9HT1Byb3Rvcy9EYXRhL1Bva2Vtb25EYXRhLnByb3RvGjBQ",
						"T0dPUHJvdG9zL0RhdGEvQ2FwdHVyZS9DYXB0dXJlUHJvYmFiaWxpdHkucHJv",
						"dG8i9AIKGEluY2Vuc2VFbmNvdW50ZXJSZXNwb25zZRJQCgZyZXN1bHQYASAB",
						"KA4yQC5QT0dPUHJvdG9zLk5ldHdvcmtpbmcuUmVzcG9uc2VzLkluY2Vuc2VF",
						"bmNvdW50ZXJSZXNwb25zZS5SZXN1bHQSMgoMcG9rZW1vbl9kYXRhGAIgASgL",
						"MhwuUE9HT1Byb3Rvcy5EYXRhLlBva2Vtb25EYXRhEkgKE2NhcHR1cmVfcHJv",
						"YmFiaWxpdHkYAyABKAsyKy5QT0dPUHJvdG9zLkRhdGEuQ2FwdHVyZS5DYXB0",
						"dXJlUHJvYmFiaWxpdHkihwEKBlJlc3VsdBIdChlJTkNFTlNFX0VOQ09VTlRF",
						"Ul9VTktOT1dOEAASHQoZSU5DRU5TRV9FTkNPVU5URVJfU1VDQ0VTUxABEiMK",
						"H0lOQ0VOU0VfRU5DT1VOVEVSX05PVF9BVkFJTEFCTEUQAhIaChZQT0tFTU9O",
						"X0lOVkVOVE9SWV9GVUxMEANiBnByb3RvMw=="));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new[]
				{
					global::POGOProtos.Data.PokemonDataReflection.Descriptor,
					global::POGOProtos.Data.Capture.CaptureProbabilityReflection.Descriptor,
				},
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Networking.Responses.IncenseEncounterResponse),
							global::POGOProtos.Networking.Responses.IncenseEncounterResponse.Parser,
							new[] { "Result", "PokemonData", "CaptureProbability" },
							null,
							new[] { typeof(global::POGOProtos.Networking.Responses.IncenseEncounterResponse.Types.Result) },
							null)
					}));
		}

		#endregion
	}

	#region Messages

	/// <summary>
	/// The incense encounter response.
	/// </summary>
	public sealed partial class IncenseEncounterResponse : pb::IMessage<IncenseEncounterResponse>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "result" field.</summary>
		public const int ResultFieldNumber = 1;

		/// <summary>Field number for the "pokemon_data" field.</summary>
		public const int PokemonDataFieldNumber = 2;

		/// <summary>Field number for the "capture_probability" field.</summary>
		public const int CaptureProbabilityFieldNumber = 3;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<IncenseEncounterResponse> _parser =
			new pb::MessageParser<IncenseEncounterResponse>(() => new IncenseEncounterResponse());

		#endregion

		#region  Fields

		/// <summary>
		/// The capture probability_.
		/// </summary>
		private CaptureProbability captureProbability_;

		/// <summary>
		/// The pokemon data_.
		/// </summary>
		private PokemonData pokemonData_;

		/// <summary>
		/// The result_.
		/// </summary>
		private Types.Result result_ = 0;

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="IncenseEncounterResponse"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public IncenseEncounterResponse()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="IncenseEncounterResponse"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public IncenseEncounterResponse(IncenseEncounterResponse other) : this()
		{
			result_ = other.result_;
			PokemonData = other.pokemonData_ != null ? other.PokemonData.Clone() : null;
			CaptureProbability = other.captureProbability_ != null ? other.CaptureProbability.Clone() : null;
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<IncenseEncounterResponse> Parser
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
				return global::POGOProtos.Networking.Responses.IncenseEncounterResponseReflection.Descriptor.MessageTypes[0];
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
		/// Gets or sets the pokemon data.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public PokemonData PokemonData
		{
			get
			{
				return pokemonData_;
			}

			set
			{
				pokemonData_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the capture probability.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public CaptureProbability CaptureProbability
		{
			get
			{
				return captureProbability_;
			}

			set
			{
				captureProbability_ = value;
			}
		}

		#endregion

		#region  Interface Implementations

		/// <summary>
		/// The clone.
		/// </summary>
		/// <returns>
		/// The <see cref="IncenseEncounterResponse"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public IncenseEncounterResponse Clone()
		{
			return new IncenseEncounterResponse(this);
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
		public bool Equals(IncenseEncounterResponse other)
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

			if (!object.Equals(PokemonData, other.PokemonData))
			{
				return false;
			}

			if (!object.Equals(CaptureProbability, other.CaptureProbability))
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

			if (pokemonData_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(PokemonData);
			}

			if (captureProbability_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(CaptureProbability);
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

			if (pokemonData_ != null)
			{
				size += 1 + pb::CodedOutputStream.ComputeMessageSize(PokemonData);
			}

			if (captureProbability_ != null)
			{
				size += 1 + pb::CodedOutputStream.ComputeMessageSize(CaptureProbability);
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
		public void MergeFrom(IncenseEncounterResponse other)
		{
			if (other == null)
			{
				return;
			}

			if (other.Result != 0)
			{
				Result = other.Result;
			}

			if (other.pokemonData_ != null)
			{
				if (pokemonData_ == null)
				{
					pokemonData_ = new global::POGOProtos.Data.PokemonData();
				}

				PokemonData.MergeFrom(other.PokemonData);
			}

			if (other.captureProbability_ != null)
			{
				if (captureProbability_ == null)
				{
					captureProbability_ = new global::POGOProtos.Data.Capture.CaptureProbability();
				}

				CaptureProbability.MergeFrom(other.CaptureProbability);
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
						result_ = (global::POGOProtos.Networking.Responses.IncenseEncounterResponse.Types.Result)input.ReadEnum();
						break;
					}

					case 18:
					{
						if (pokemonData_ == null)
						{
							pokemonData_ = new global::POGOProtos.Data.PokemonData();
						}

						input.ReadMessage(pokemonData_);
						break;
					}

					case 26:
					{
						if (captureProbability_ == null)
						{
							captureProbability_ = new global::POGOProtos.Data.Capture.CaptureProbability();
						}

						input.ReadMessage(captureProbability_);
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
			return Equals(other as IncenseEncounterResponse);
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

			if (pokemonData_ != null)
			{
				hash ^= PokemonData.GetHashCode();
			}

			if (captureProbability_ != null)
			{
				hash ^= CaptureProbability.GetHashCode();
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

		/// <summary>Container for nested types declared in the IncenseEncounterResponse message type.</summary>
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
				/// The incense encounter unknown.
				/// </summary>
				[pbr::OriginalName("INCENSE_ENCOUNTER_UNKNOWN")] IncenseEncounterUnknown = 0,

				/// <summary>
				/// The incense encounter success.
				/// </summary>
				[pbr::OriginalName("INCENSE_ENCOUNTER_SUCCESS")] IncenseEncounterSuccess = 1,

				/// <summary>
				/// The incense encounter not available.
				/// </summary>
				[pbr::OriginalName("INCENSE_ENCOUNTER_NOT_AVAILABLE")] IncenseEncounterNotAvailable = 2,

				/// <summary>
				/// The pokemon inventory full.
				/// </summary>
				[pbr::OriginalName("POKEMON_INVENTORY_FULL")] PokemonInventoryFull = 3,
			}

			#endregion
		}

		#endregion
	}

	#endregion
}

#endregion Designer generated code