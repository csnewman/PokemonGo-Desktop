// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FortRecallPokemonResponse.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Networking/Responses/FortRecallPokemonResponse.proto
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
	/// <summary>Holder for reflection information generated from POGOProtos/Networking/Responses/FortRecallPokemonResponse.proto</summary>
	public static partial class FortRecallPokemonResponseReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Networking/Responses/FortRecallPokemonResponse.proto</summary>
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
		/// Initializes static members of the <see cref="FortRecallPokemonResponseReflection"/> class.
		/// </summary>
		static FortRecallPokemonResponseReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"Cj9QT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVzcG9uc2VzL0ZvcnRSZWNhbGxQ",
						"b2tlbW9uUmVzcG9uc2UucHJvdG8SH1BPR09Qcm90b3MuTmV0d29ya2luZy5S",
						"ZXNwb25zZXMaOVBPR09Qcm90b3MvTmV0d29ya2luZy9SZXNwb25zZXMvRm9y",
						"dERldGFpbHNSZXNwb25zZS5wcm90byKwAgoZRm9ydFJlY2FsbFBva2Vtb25S",
						"ZXNwb25zZRJRCgZyZXN1bHQYASABKA4yQS5QT0dPUHJvdG9zLk5ldHdvcmtp",
						"bmcuUmVzcG9uc2VzLkZvcnRSZWNhbGxQb2tlbW9uUmVzcG9uc2UuUmVzdWx0",
						"EkoKDGZvcnRfZGV0YWlscxgCIAEoCzI0LlBPR09Qcm90b3MuTmV0d29ya2lu",
						"Zy5SZXNwb25zZXMuRm9ydERldGFpbHNSZXNwb25zZSJ0CgZSZXN1bHQSEQoN",
						"Tk9fUkVTVUxUX1NFVBAAEgsKB1NVQ0NFU1MQARIWChJFUlJPUl9OT1RfSU5f",
						"UkFOR0UQAhIdChlFUlJPUl9QT0tFTU9OX05PVF9PTl9GT1JUEAMSEwoPRVJS",
						"T1JfTk9fUExBWUVSEARiBnByb3RvMw=="));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new[] { global::POGOProtos.Networking.Responses.FortDetailsResponseReflection.Descriptor, },
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Networking.Responses.FortRecallPokemonResponse),
							global::POGOProtos.Networking.Responses.FortRecallPokemonResponse.Parser,
							new[] { "Result", "FortDetails" },
							null,
							new[] { typeof(global::POGOProtos.Networking.Responses.FortRecallPokemonResponse.Types.Result) },
							null)
					}));
		}

		#endregion
	}

	#region Messages

	/// <summary>
	/// The fort recall pokemon response.
	/// </summary>
	public sealed partial class FortRecallPokemonResponse : pb::IMessage<FortRecallPokemonResponse>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "result" field.</summary>
		public const int ResultFieldNumber = 1;

		/// <summary>Field number for the "fort_details" field.</summary>
		public const int FortDetailsFieldNumber = 2;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<FortRecallPokemonResponse> _parser =
			new pb::MessageParser<FortRecallPokemonResponse>(() => new FortRecallPokemonResponse());

		#endregion

		#region  Fields

		/// <summary>
		/// The fort details_.
		/// </summary>
		private FortDetailsResponse fortDetails_;

		/// <summary>
		/// The result_.
		/// </summary>
		private Types.Result result_ = 0;

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="FortRecallPokemonResponse"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public FortRecallPokemonResponse()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="FortRecallPokemonResponse"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public FortRecallPokemonResponse(FortRecallPokemonResponse other) : this()
		{
			result_ = other.result_;
			FortDetails = other.fortDetails_ != null ? other.FortDetails.Clone() : null;
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<FortRecallPokemonResponse> Parser
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
				return global::POGOProtos.Networking.Responses.FortRecallPokemonResponseReflection.Descriptor.MessageTypes[0];
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
		/// Gets or sets the fort details.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public FortDetailsResponse FortDetails
		{
			get
			{
				return fortDetails_;
			}

			set
			{
				fortDetails_ = value;
			}
		}

		#endregion

		#region  Interface Implementations

		/// <summary>
		/// The clone.
		/// </summary>
		/// <returns>
		/// The <see cref="FortRecallPokemonResponse"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public FortRecallPokemonResponse Clone()
		{
			return new FortRecallPokemonResponse(this);
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
		public bool Equals(FortRecallPokemonResponse other)
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

			if (!object.Equals(FortDetails, other.FortDetails))
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

			if (fortDetails_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(FortDetails);
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

			if (fortDetails_ != null)
			{
				size += 1 + pb::CodedOutputStream.ComputeMessageSize(FortDetails);
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
		public void MergeFrom(FortRecallPokemonResponse other)
		{
			if (other == null)
			{
				return;
			}

			if (other.Result != 0)
			{
				Result = other.Result;
			}

			if (other.fortDetails_ != null)
			{
				if (fortDetails_ == null)
				{
					fortDetails_ = new global::POGOProtos.Networking.Responses.FortDetailsResponse();
				}

				FortDetails.MergeFrom(other.FortDetails);
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
						result_ = (global::POGOProtos.Networking.Responses.FortRecallPokemonResponse.Types.Result)input.ReadEnum();
						break;
					}

					case 18:
					{
						if (fortDetails_ == null)
						{
							fortDetails_ = new global::POGOProtos.Networking.Responses.FortDetailsResponse();
						}

						input.ReadMessage(fortDetails_);
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
			return Equals(other as FortRecallPokemonResponse);
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

			if (fortDetails_ != null)
			{
				hash ^= FortDetails.GetHashCode();
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

		/// <summary>Container for nested types declared in the FortRecallPokemonResponse message type.</summary>
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
				/// The error not in range.
				/// </summary>
				[pbr::OriginalName("ERROR_NOT_IN_RANGE")] ErrorNotInRange = 2,

				/// <summary>
				/// The error pokemon not on fort.
				/// </summary>
				[pbr::OriginalName("ERROR_POKEMON_NOT_ON_FORT")] ErrorPokemonNotOnFort = 3,

				/// <summary>
				/// The error no player.
				/// </summary>
				[pbr::OriginalName("ERROR_NO_PLAYER")] ErrorNoPlayer = 4,
			}

			#endregion
		}

		#endregion
	}

	#endregion
}

#endregion Designer generated code