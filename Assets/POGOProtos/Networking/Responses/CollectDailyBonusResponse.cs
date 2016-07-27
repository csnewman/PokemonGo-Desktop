// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CollectDailyBonusResponse.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Networking/Responses/CollectDailyBonusResponse.proto
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
	/// <summary>Holder for reflection information generated from POGOProtos/Networking/Responses/CollectDailyBonusResponse.proto</summary>
	public static partial class CollectDailyBonusResponseReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Networking/Responses/CollectDailyBonusResponse.proto</summary>
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
		/// Initializes static members of the <see cref="CollectDailyBonusResponseReflection"/> class.
		/// </summary>
		static CollectDailyBonusResponseReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"Cj9QT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVzcG9uc2VzL0NvbGxlY3REYWls",
						"eUJvbnVzUmVzcG9uc2UucHJvdG8SH1BPR09Qcm90b3MuTmV0d29ya2luZy5S",
						"ZXNwb25zZXMiqwEKGUNvbGxlY3REYWlseUJvbnVzUmVzcG9uc2USUQoGcmVz",
						"dWx0GAEgASgOMkEuUE9HT1Byb3Rvcy5OZXR3b3JraW5nLlJlc3BvbnNlcy5D",
						"b2xsZWN0RGFpbHlCb251c1Jlc3BvbnNlLlJlc3VsdCI7CgZSZXN1bHQSCQoF",
						"VU5TRVQQABILCgdTVUNDRVNTEAESCwoHRkFJTFVSRRACEgwKCFRPT19TT09O",
						"EANiBnByb3RvMw=="));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new pbr.FileDescriptor[] { },
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Networking.Responses.CollectDailyBonusResponse),
							global::POGOProtos.Networking.Responses.CollectDailyBonusResponse.Parser,
							new[] { "Result" },
							null,
							new[] { typeof(global::POGOProtos.Networking.Responses.CollectDailyBonusResponse.Types.Result) },
							null)
					}));
		}

		#endregion
	}

	#region Messages

	/// <summary>
	/// The collect daily bonus response.
	/// </summary>
	public sealed partial class CollectDailyBonusResponse : pb::IMessage<CollectDailyBonusResponse>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "result" field.</summary>
		public const int ResultFieldNumber = 1;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<CollectDailyBonusResponse> _parser =
			new pb::MessageParser<CollectDailyBonusResponse>(() => new CollectDailyBonusResponse());

		#endregion

		#region  Fields

		/// <summary>
		/// The result_.
		/// </summary>
		private Types.Result result_ = 0;

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="CollectDailyBonusResponse"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public CollectDailyBonusResponse()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="CollectDailyBonusResponse"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public CollectDailyBonusResponse(CollectDailyBonusResponse other) : this()
		{
			result_ = other.result_;
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<CollectDailyBonusResponse> Parser
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
				return global::POGOProtos.Networking.Responses.CollectDailyBonusResponseReflection.Descriptor.MessageTypes[0];
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

		#endregion

		#region  Interface Implementations

		/// <summary>
		/// The clone.
		/// </summary>
		/// <returns>
		/// The <see cref="CollectDailyBonusResponse"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public CollectDailyBonusResponse Clone()
		{
			return new CollectDailyBonusResponse(this);
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
		public bool Equals(CollectDailyBonusResponse other)
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

			return size;
		}

		/// <summary>
		/// The merge from.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public void MergeFrom(CollectDailyBonusResponse other)
		{
			if (other == null)
			{
				return;
			}

			if (other.Result != 0)
			{
				Result = other.Result;
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
						result_ = (global::POGOProtos.Networking.Responses.CollectDailyBonusResponse.Types.Result)input.ReadEnum();
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
			return Equals(other as CollectDailyBonusResponse);
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

		/// <summary>Container for nested types declared in the CollectDailyBonusResponse message type.</summary>
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
				/// The failure.
				/// </summary>
				[pbr::OriginalName("FAILURE")] Failure = 2,

				/// <summary>
				/// The too soon.
				/// </summary>
				[pbr::OriginalName("TOO_SOON")] TooSoon = 3,
			}

			#endregion
		}

		#endregion
	}

	#endregion
}

#endregion Designer generated code