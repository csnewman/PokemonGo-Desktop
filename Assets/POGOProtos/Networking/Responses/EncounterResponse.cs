// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EncounterResponse.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Networking/Responses/EncounterResponse.proto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

#pragma warning disable 1591, 0612, 3021

#region Designer generated code

using POGOProtos.Data.Capture;
using POGOProtos.Map.Pokemon;
using pb = Google.Protobuf;
using pbc = Google.Protobuf.Collections;
using pbr = Google.Protobuf.Reflection;
using scg = System.Collections.Generic;

namespace POGOProtos.Networking.Responses
{
	/// <summary>Holder for reflection information generated from POGOProtos/Networking/Responses/EncounterResponse.proto</summary>
	public static partial class EncounterResponseReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Networking/Responses/EncounterResponse.proto</summary>
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
		/// Initializes static members of the <see cref="EncounterResponseReflection"/> class.
		/// </summary>
		static EncounterResponseReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CjdQT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVzcG9uc2VzL0VuY291bnRlclJl",
						"c3BvbnNlLnByb3RvEh9QT0dPUHJvdG9zLk5ldHdvcmtpbmcuUmVzcG9uc2Vz",
						"GjBQT0dPUHJvdG9zL0RhdGEvQ2FwdHVyZS9DYXB0dXJlUHJvYmFiaWxpdHku",
						"cHJvdG8aKFBPR09Qcm90b3MvTWFwL1Bva2Vtb24vV2lsZFBva2Vtb24ucHJv",
						"dG8itAQKEUVuY291bnRlclJlc3BvbnNlEjkKDHdpbGRfcG9rZW1vbhgBIAEo",
						"CzIjLlBPR09Qcm90b3MuTWFwLlBva2Vtb24uV2lsZFBva2Vtb24SUQoKYmFj",
						"a2dyb3VuZBgCIAEoDjI9LlBPR09Qcm90b3MuTmV0d29ya2luZy5SZXNwb25z",
						"ZXMuRW5jb3VudGVyUmVzcG9uc2UuQmFja2dyb3VuZBJJCgZzdGF0dXMYAyAB",
						"KA4yOS5QT0dPUHJvdG9zLk5ldHdvcmtpbmcuUmVzcG9uc2VzLkVuY291bnRl",
						"clJlc3BvbnNlLlN0YXR1cxJIChNjYXB0dXJlX3Byb2JhYmlsaXR5GAQgASgL",
						"MisuUE9HT1Byb3Rvcy5EYXRhLkNhcHR1cmUuQ2FwdHVyZVByb2JhYmlsaXR5",
						"IiIKCkJhY2tncm91bmQSCAoEUEFSSxAAEgoKBkRFU0VSVBABItcBCgZTdGF0",
						"dXMSEwoPRU5DT1VOVEVSX0VSUk9SEAASFQoRRU5DT1VOVEVSX1NVQ0NFU1MQ",
						"ARIXChNFTkNPVU5URVJfTk9UX0ZPVU5EEAISFAoQRU5DT1VOVEVSX0NMT1NF",
						"RBADEhoKFkVOQ09VTlRFUl9QT0tFTU9OX0ZMRUQQBBIaChZFTkNPVU5URVJf",
						"Tk9UX0lOX1JBTkdFEAUSHgoaRU5DT1VOVEVSX0FMUkVBRFlfSEFQUEVORUQQ",
						"BhIaChZQT0tFTU9OX0lOVkVOVE9SWV9GVUxMEAdiBnByb3RvMw=="));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new[]
				{
					global::POGOProtos.Data.Capture.CaptureProbabilityReflection.Descriptor,
					global::POGOProtos.Map.Pokemon.WildPokemonReflection.Descriptor,
				},
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Networking.Responses.EncounterResponse),
							global::POGOProtos.Networking.Responses.EncounterResponse.Parser,
							new[] { "WildPokemon", "Background", "Status", "CaptureProbability" },
							null,
							new[]
							{
								typeof(global::POGOProtos.Networking.Responses.EncounterResponse.Types.Background),
								typeof(global::POGOProtos.Networking.Responses.EncounterResponse.Types.Status)
							},
							null)
					}));
		}

		#endregion
	}

	#region Messages

	/// <summary>
	/// The encounter response.
	/// </summary>
	public sealed partial class EncounterResponse : pb::IMessage<EncounterResponse>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "wild_pokemon" field.</summary>
		public const int WildPokemonFieldNumber = 1;

		/// <summary>Field number for the "background" field.</summary>
		public const int BackgroundFieldNumber = 2;

		/// <summary>Field number for the "status" field.</summary>
		public const int StatusFieldNumber = 3;

		/// <summary>Field number for the "capture_probability" field.</summary>
		public const int CaptureProbabilityFieldNumber = 4;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<EncounterResponse> _parser =
			new pb::MessageParser<EncounterResponse>(() => new EncounterResponse());

		#endregion

		#region  Fields

		/// <summary>
		/// The background_.
		/// </summary>
		private Types.Background background_ = 0;

		/// <summary>
		/// The capture probability_.
		/// </summary>
		private CaptureProbability captureProbability_;

		/// <summary>
		/// The status_.
		/// </summary>
		private Types.Status status_ = 0;

		/// <summary>
		/// The wild pokemon_.
		/// </summary>
		private WildPokemon wildPokemon_;

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="EncounterResponse"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public EncounterResponse()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="EncounterResponse"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public EncounterResponse(EncounterResponse other) : this()
		{
			WildPokemon = other.wildPokemon_ != null ? other.WildPokemon.Clone() : null;
			background_ = other.background_;
			status_ = other.status_;
			CaptureProbability = other.captureProbability_ != null ? other.CaptureProbability.Clone() : null;
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<EncounterResponse> Parser
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
				return global::POGOProtos.Networking.Responses.EncounterResponseReflection.Descriptor.MessageTypes[0];
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
		/// Gets or sets the wild pokemon.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public WildPokemon WildPokemon
		{
			get
			{
				return wildPokemon_;
			}

			set
			{
				wildPokemon_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the background.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public Types.Background Background
		{
			get
			{
				return background_;
			}

			set
			{
				background_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the status.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public Types.Status Status
		{
			get
			{
				return status_;
			}

			set
			{
				status_ = value;
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
		/// The <see cref="EncounterResponse"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public EncounterResponse Clone()
		{
			return new EncounterResponse(this);
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
		public bool Equals(EncounterResponse other)
		{
			if (ReferenceEquals(other, null))
			{
				return false;
			}

			if (ReferenceEquals(other, this))
			{
				return true;
			}

			if (!object.Equals(WildPokemon, other.WildPokemon))
			{
				return false;
			}

			if (Background != other.Background)
			{
				return false;
			}

			if (Status != other.Status)
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
			if (wildPokemon_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(WildPokemon);
			}

			if (Background != 0)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)Background);
			}

			if (Status != 0)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)Status);
			}

			if (captureProbability_ != null)
			{
				output.WriteRawTag(34);
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
			if (wildPokemon_ != null)
			{
				size += 1 + pb::CodedOutputStream.ComputeMessageSize(WildPokemon);
			}

			if (Background != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeEnumSize((int)Background);
			}

			if (Status != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeEnumSize((int)Status);
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
		public void MergeFrom(EncounterResponse other)
		{
			if (other == null)
			{
				return;
			}

			if (other.wildPokemon_ != null)
			{
				if (wildPokemon_ == null)
				{
					wildPokemon_ = new global::POGOProtos.Map.Pokemon.WildPokemon();
				}

				WildPokemon.MergeFrom(other.WildPokemon);
			}

			if (other.Background != 0)
			{
				Background = other.Background;
			}

			if (other.Status != 0)
			{
				Status = other.Status;
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
					case 10:
					{
						if (wildPokemon_ == null)
						{
							wildPokemon_ = new global::POGOProtos.Map.Pokemon.WildPokemon();
						}

						input.ReadMessage(wildPokemon_);
						break;
					}

					case 16:
					{
						background_ = (global::POGOProtos.Networking.Responses.EncounterResponse.Types.Background)input.ReadEnum();
						break;
					}

					case 24:
					{
						status_ = (global::POGOProtos.Networking.Responses.EncounterResponse.Types.Status)input.ReadEnum();
						break;
					}

					case 34:
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
			return Equals(other as EncounterResponse);
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
			if (wildPokemon_ != null)
			{
				hash ^= WildPokemon.GetHashCode();
			}

			if (Background != 0)
			{
				hash ^= Background.GetHashCode();
			}

			if (Status != 0)
			{
				hash ^= Status.GetHashCode();
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

		/// <summary>Container for nested types declared in the EncounterResponse message type.</summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static partial class Types
		{
			#region Enums

			/// <summary>
			/// The background.
			/// </summary>
			public enum Background
			{
				/// <summary>
				/// The park.
				/// </summary>
				[pbr::OriginalName("PARK")] Park = 0,

				/// <summary>
				/// The desert.
				/// </summary>
				[pbr::OriginalName("DESERT")] Desert = 1,
			}

			/// <summary>
			/// The status.
			/// </summary>
			public enum Status
			{
				/// <summary>
				/// The encounter error.
				/// </summary>
				[pbr::OriginalName("ENCOUNTER_ERROR")] EncounterError = 0,

				/// <summary>
				/// The encounter success.
				/// </summary>
				[pbr::OriginalName("ENCOUNTER_SUCCESS")] EncounterSuccess = 1,

				/// <summary>
				/// The encounter not found.
				/// </summary>
				[pbr::OriginalName("ENCOUNTER_NOT_FOUND")] EncounterNotFound = 2,

				/// <summary>
				/// The encounter closed.
				/// </summary>
				[pbr::OriginalName("ENCOUNTER_CLOSED")] EncounterClosed = 3,

				/// <summary>
				/// The encounter pokemon fled.
				/// </summary>
				[pbr::OriginalName("ENCOUNTER_POKEMON_FLED")] EncounterPokemonFled = 4,

				/// <summary>
				/// The encounter not in range.
				/// </summary>
				[pbr::OriginalName("ENCOUNTER_NOT_IN_RANGE")] EncounterNotInRange = 5,

				/// <summary>
				/// The encounter already happened.
				/// </summary>
				[pbr::OriginalName("ENCOUNTER_ALREADY_HAPPENED")] EncounterAlreadyHappened = 6,

				/// <summary>
				/// The pokemon inventory full.
				/// </summary>
				[pbr::OriginalName("POKEMON_INVENTORY_FULL")] PokemonInventoryFull = 7,
			}

			#endregion
		}

		#endregion
	}

	#endregion
}

#endregion Designer generated code