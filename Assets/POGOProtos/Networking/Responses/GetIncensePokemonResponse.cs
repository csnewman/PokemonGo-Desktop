// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GetIncensePokemonResponse.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Networking/Responses/GetIncensePokemonResponse.proto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

#pragma warning disable 1591, 0612, 3021

#region Designer generated code

using pb = Google.Protobuf;
using pbc = Google.Protobuf.Collections;
using pbr = Google.Protobuf.Reflection;
using scg = System.Collections.Generic;

namespace POGOProtos.Networking.Responses
{
	/// <summary>Holder for reflection information generated from POGOProtos/Networking/Responses/GetIncensePokemonResponse.proto</summary>
	public static partial class GetIncensePokemonResponseReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Networking/Responses/GetIncensePokemonResponse.proto</summary>
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
		/// Initializes static members of the <see cref="GetIncensePokemonResponseReflection"/> class.
		/// </summary>
		static GetIncensePokemonResponseReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"Cj9QT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVzcG9uc2VzL0dldEluY2Vuc2VQ",
						"b2tlbW9uUmVzcG9uc2UucHJvdG8SH1BPR09Qcm90b3MuTmV0d29ya2luZy5S",
						"ZXNwb25zZXMi7QIKGUdldEluY2Vuc2VQb2tlbW9uUmVzcG9uc2USUQoGcmVz",
						"dWx0GAEgASgOMkEuUE9HT1Byb3Rvcy5OZXR3b3JraW5nLlJlc3BvbnNlcy5H",
						"ZXRJbmNlbnNlUG9rZW1vblJlc3BvbnNlLlJlc3VsdBIXCg9wb2tlbW9uX3R5",
						"cGVfaWQYAiABKAUSEAoIbGF0aXR1ZGUYAyABKAESEQoJbG9uZ2l0dWRlGAQg",
						"ASgBEhoKEmVuY291bnRlcl9sb2NhdGlvbhgFIAEoCRIUCgxlbmNvdW50ZXJf",
						"aWQYBiABKAQSHgoWZGlzYXBwZWFyX3RpbWVzdGFtcF9tcxgHIAEoAyJtCgZS",
						"ZXN1bHQSHQoZSU5DRU5TRV9FTkNPVU5URVJfVU5LTk9XThAAEh8KG0lOQ0VO",
						"U0VfRU5DT1VOVEVSX0FWQUlMQUJMRRABEiMKH0lOQ0VOU0VfRU5DT1VOVEVS",
						"X05PVF9BVkFJTEFCTEUQAmIGcHJvdG8z"));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new pbr.FileDescriptor[] { },
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Networking.Responses.GetIncensePokemonResponse),
							global::POGOProtos.Networking.Responses.GetIncensePokemonResponse.Parser,
							new[]
							{
								"Result", "PokemonTypeId", "Latitude", "Longitude", "EncounterLocation", "EncounterId", "DisappearTimestampMs"
							},
							null,
							new[] { typeof(global::POGOProtos.Networking.Responses.GetIncensePokemonResponse.Types.Result) },
							null)
					}));
		}

		#endregion
	}

	#region Messages

	/// <summary>
	/// The get incense pokemon response.
	/// </summary>
	public sealed partial class GetIncensePokemonResponse : pb::IMessage<GetIncensePokemonResponse>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "result" field.</summary>
		public const int ResultFieldNumber = 1;

		/// <summary>Field number for the "pokemon_type_id" field.</summary>
		public const int PokemonTypeIdFieldNumber = 2;

		/// <summary>Field number for the "latitude" field.</summary>
		public const int LatitudeFieldNumber = 3;

		/// <summary>Field number for the "longitude" field.</summary>
		public const int LongitudeFieldNumber = 4;

		/// <summary>Field number for the "encounter_location" field.</summary>
		public const int EncounterLocationFieldNumber = 5;

		/// <summary>Field number for the "encounter_id" field.</summary>
		public const int EncounterIdFieldNumber = 6;

		/// <summary>Field number for the "disappear_timestamp_ms" field.</summary>
		public const int DisappearTimestampMsFieldNumber = 7;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<GetIncensePokemonResponse> _parser =
			new pb::MessageParser<GetIncensePokemonResponse>(() => new GetIncensePokemonResponse());

		#endregion

		#region  Fields

		/// <summary>
		/// The disappear timestamp ms_.
		/// </summary>
		private long disappearTimestampMs_;

		/// <summary>
		/// The encounter id_.
		/// </summary>
		private ulong encounterId_;

		/// <summary>
		/// The encounter location_.
		/// </summary>
		private string encounterLocation_ = string.Empty;

		/// <summary>
		/// The latitude_.
		/// </summary>
		private double latitude_;

		/// <summary>
		/// The longitude_.
		/// </summary>
		private double longitude_;

		/// <summary>
		/// The pokemon type id_.
		/// </summary>
		private int pokemonTypeId_;

		/// <summary>
		/// The result_.
		/// </summary>
		private Types.Result result_ = 0;

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="GetIncensePokemonResponse"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public GetIncensePokemonResponse()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="GetIncensePokemonResponse"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public GetIncensePokemonResponse(GetIncensePokemonResponse other) : this()
		{
			result_ = other.result_;
			pokemonTypeId_ = other.pokemonTypeId_;
			latitude_ = other.latitude_;
			longitude_ = other.longitude_;
			encounterLocation_ = other.encounterLocation_;
			encounterId_ = other.encounterId_;
			disappearTimestampMs_ = other.disappearTimestampMs_;
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<GetIncensePokemonResponse> Parser
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
				return global::POGOProtos.Networking.Responses.GetIncensePokemonResponseReflection.Descriptor.MessageTypes[0];
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
		///  TODO: PokemonType.proto or PokemonId.proto
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public int PokemonTypeId
		{
			get
			{
				return pokemonTypeId_;
			}

			set
			{
				pokemonTypeId_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the latitude.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public double Latitude
		{
			get
			{
				return latitude_;
			}

			set
			{
				latitude_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the longitude.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public double Longitude
		{
			get
			{
				return longitude_;
			}

			set
			{
				longitude_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the encounter location.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public string EncounterLocation
		{
			get
			{
				return encounterLocation_;
			}

			set
			{
				encounterLocation_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
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

		/// <summary>
		/// Gets or sets the disappear timestamp ms.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public long DisappearTimestampMs
		{
			get
			{
				return disappearTimestampMs_;
			}

			set
			{
				disappearTimestampMs_ = value;
			}
		}

		#endregion

		#region  Interface Implementations

		/// <summary>
		/// The clone.
		/// </summary>
		/// <returns>
		/// The <see cref="GetIncensePokemonResponse"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public GetIncensePokemonResponse Clone()
		{
			return new GetIncensePokemonResponse(this);
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
		public bool Equals(GetIncensePokemonResponse other)
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

			if (PokemonTypeId != other.PokemonTypeId)
			{
				return false;
			}

			if (Latitude != other.Latitude)
			{
				return false;
			}

			if (Longitude != other.Longitude)
			{
				return false;
			}

			if (EncounterLocation != other.EncounterLocation)
			{
				return false;
			}

			if (EncounterId != other.EncounterId)
			{
				return false;
			}

			if (DisappearTimestampMs != other.DisappearTimestampMs)
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

			if (PokemonTypeId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(PokemonTypeId);
			}

			if (Latitude != 0D)
			{
				output.WriteRawTag(25);
				output.WriteDouble(Latitude);
			}

			if (Longitude != 0D)
			{
				output.WriteRawTag(33);
				output.WriteDouble(Longitude);
			}

			if (EncounterLocation.Length != 0)
			{
				output.WriteRawTag(42);
				output.WriteString(EncounterLocation);
			}

			if (EncounterId != 0UL)
			{
				output.WriteRawTag(48);
				output.WriteUInt64(EncounterId);
			}

			if (DisappearTimestampMs != 0L)
			{
				output.WriteRawTag(56);
				output.WriteInt64(DisappearTimestampMs);
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

			if (PokemonTypeId != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeInt32Size(PokemonTypeId);
			}

			if (Latitude != 0D)
			{
				size += 1 + 8;
			}

			if (Longitude != 0D)
			{
				size += 1 + 8;
			}

			if (EncounterLocation.Length != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeStringSize(EncounterLocation);
			}

			if (EncounterId != 0UL)
			{
				size += 1 + pb::CodedOutputStream.ComputeUInt64Size(EncounterId);
			}

			if (DisappearTimestampMs != 0L)
			{
				size += 1 + pb::CodedOutputStream.ComputeInt64Size(DisappearTimestampMs);
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
		public void MergeFrom(GetIncensePokemonResponse other)
		{
			if (other == null)
			{
				return;
			}

			if (other.Result != 0)
			{
				Result = other.Result;
			}

			if (other.PokemonTypeId != 0)
			{
				PokemonTypeId = other.PokemonTypeId;
			}

			if (other.Latitude != 0D)
			{
				Latitude = other.Latitude;
			}

			if (other.Longitude != 0D)
			{
				Longitude = other.Longitude;
			}

			if (other.EncounterLocation.Length != 0)
			{
				EncounterLocation = other.EncounterLocation;
			}

			if (other.EncounterId != 0UL)
			{
				EncounterId = other.EncounterId;
			}

			if (other.DisappearTimestampMs != 0L)
			{
				DisappearTimestampMs = other.DisappearTimestampMs;
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
						result_ = (global::POGOProtos.Networking.Responses.GetIncensePokemonResponse.Types.Result)input.ReadEnum();
						break;
					}

					case 16:
					{
						PokemonTypeId = input.ReadInt32();
						break;
					}

					case 25:
					{
						Latitude = input.ReadDouble();
						break;
					}

					case 33:
					{
						Longitude = input.ReadDouble();
						break;
					}

					case 42:
					{
						EncounterLocation = input.ReadString();
						break;
					}

					case 48:
					{
						EncounterId = input.ReadUInt64();
						break;
					}

					case 56:
					{
						DisappearTimestampMs = input.ReadInt64();
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
			return Equals(other as GetIncensePokemonResponse);
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

			if (PokemonTypeId != 0)
			{
				hash ^= PokemonTypeId.GetHashCode();
			}

			if (Latitude != 0D)
			{
				hash ^= Latitude.GetHashCode();
			}

			if (Longitude != 0D)
			{
				hash ^= Longitude.GetHashCode();
			}

			if (EncounterLocation.Length != 0)
			{
				hash ^= EncounterLocation.GetHashCode();
			}

			if (EncounterId != 0UL)
			{
				hash ^= EncounterId.GetHashCode();
			}

			if (DisappearTimestampMs != 0L)
			{
				hash ^= DisappearTimestampMs.GetHashCode();
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

		/// <summary>Container for nested types declared in the GetIncensePokemonResponse message type.</summary>
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
				/// The incense encounter available.
				/// </summary>
				[pbr::OriginalName("INCENSE_ENCOUNTER_AVAILABLE")] IncenseEncounterAvailable = 1,

				/// <summary>
				/// The incense encounter not available.
				/// </summary>
				[pbr::OriginalName("INCENSE_ENCOUNTER_NOT_AVAILABLE")] IncenseEncounterNotAvailable = 2,
			}

			#endregion
		}

		#endregion
	}

	#endregion
}

#endregion Designer generated code