// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GetPlayerProfileResponse.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Networking/Responses/GetPlayerProfileResponse.proto
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
	/// <summary>Holder for reflection information generated from POGOProtos/Networking/Responses/GetPlayerProfileResponse.proto</summary>
	public static partial class GetPlayerProfileResponseReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Networking/Responses/GetPlayerProfileResponse.proto</summary>
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
		/// Initializes static members of the <see cref="GetPlayerProfileResponseReflection"/> class.
		/// </summary>
		static GetPlayerProfileResponseReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"Cj5QT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVzcG9uc2VzL0dldFBsYXllclBy",
						"b2ZpbGVSZXNwb25zZS5wcm90bxIfUE9HT1Byb3Rvcy5OZXR3b3JraW5nLlJl",
						"c3BvbnNlcxohUE9HT1Byb3Rvcy9EYXRhL1BsYXllckJhZGdlLnByb3RvItAB",
						"ChhHZXRQbGF5ZXJQcm9maWxlUmVzcG9uc2USUAoGcmVzdWx0GAEgASgOMkAu",
						"UE9HT1Byb3Rvcy5OZXR3b3JraW5nLlJlc3BvbnNlcy5HZXRQbGF5ZXJQcm9m",
						"aWxlUmVzcG9uc2UuUmVzdWx0EhIKCnN0YXJ0X3RpbWUYAiABKAMSLAoGYmFk",
						"Z2VzGAMgAygLMhwuUE9HT1Byb3Rvcy5EYXRhLlBsYXllckJhZGdlIiAKBlJl",
						"c3VsdBIJCgVVTlNFVBAAEgsKB1NVQ0NFU1MQAWIGcHJvdG8z"));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new[] { global::POGOProtos.Data.PlayerBadgeReflection.Descriptor, },
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Networking.Responses.GetPlayerProfileResponse),
							global::POGOProtos.Networking.Responses.GetPlayerProfileResponse.Parser,
							new[] { "Result", "StartTime", "Badges" },
							null,
							new[] { typeof(global::POGOProtos.Networking.Responses.GetPlayerProfileResponse.Types.Result) },
							null)
					}));
		}

		#endregion
	}

	#region Messages

	/// <summary>
	/// The get player profile response.
	/// </summary>
	public sealed partial class GetPlayerProfileResponse : pb::IMessage<GetPlayerProfileResponse>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "result" field.</summary>
		public const int ResultFieldNumber = 1;

		/// <summary>Field number for the "start_time" field.</summary>
		public const int StartTimeFieldNumber = 2;

		/// <summary>Field number for the "badges" field.</summary>
		public const int BadgesFieldNumber = 3;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<GetPlayerProfileResponse> _parser =
			new pb::MessageParser<GetPlayerProfileResponse>(() => new GetPlayerProfileResponse());

		/// <summary>
		/// The _repeated_badges_codec.
		/// </summary>
		private static readonly pb.FieldCodec<PlayerBadge> _repeated_badges_codec = pb::FieldCodec.ForMessage(
			26,
			global::POGOProtos.Data.PlayerBadge.Parser);

		#endregion

		#region  Fields

		/// <summary>
		/// The badges_.
		/// </summary>
		private readonly pbc.RepeatedField<PlayerBadge> badges_ = new pbc::RepeatedField<PlayerBadge>();

		/// <summary>
		/// The result_.
		/// </summary>
		private Types.Result result_ = 0;

		/// <summary>
		/// The start time_.
		/// </summary>
		private long startTime_;

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="GetPlayerProfileResponse"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public GetPlayerProfileResponse()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="GetPlayerProfileResponse"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public GetPlayerProfileResponse(GetPlayerProfileResponse other) : this()
		{
			result_ = other.result_;
			startTime_ = other.startTime_;
			badges_ = other.badges_.Clone();
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<GetPlayerProfileResponse> Parser
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
				return global::POGOProtos.Networking.Responses.GetPlayerProfileResponseReflection.Descriptor.MessageTypes[0];
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
		/// Gets or sets the start time.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public long StartTime
		{
			get
			{
				return startTime_;
			}

			set
			{
				startTime_ = value;
			}
		}

		/// <summary>
		/// Gets the badges.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public pbc.RepeatedField<PlayerBadge> Badges
		{
			get
			{
				return badges_;
			}
		}

		#endregion

		#region  Interface Implementations

		/// <summary>
		/// The clone.
		/// </summary>
		/// <returns>
		/// The <see cref="GetPlayerProfileResponse"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public GetPlayerProfileResponse Clone()
		{
			return new GetPlayerProfileResponse(this);
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
		public bool Equals(GetPlayerProfileResponse other)
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

			if (StartTime != other.StartTime)
			{
				return false;
			}

			if (!badges_.Equals(other.badges_))
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

			if (StartTime != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(StartTime);
			}

			badges_.WriteTo(output, _repeated_badges_codec);
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

			if (StartTime != 0L)
			{
				size += 1 + pb::CodedOutputStream.ComputeInt64Size(StartTime);
			}

			size += badges_.CalculateSize(_repeated_badges_codec);
			return size;
		}

		/// <summary>
		/// The merge from.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public void MergeFrom(GetPlayerProfileResponse other)
		{
			if (other == null)
			{
				return;
			}

			if (other.Result != 0)
			{
				Result = other.Result;
			}

			if (other.StartTime != 0L)
			{
				StartTime = other.StartTime;
			}

			badges_.Add(other.badges_);
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
						result_ = (global::POGOProtos.Networking.Responses.GetPlayerProfileResponse.Types.Result)input.ReadEnum();
						break;
					}

					case 16:
					{
						StartTime = input.ReadInt64();
						break;
					}

					case 26:
					{
						badges_.AddEntriesFrom(input, _repeated_badges_codec);
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
			return Equals(other as GetPlayerProfileResponse);
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

			if (StartTime != 0L)
			{
				hash ^= StartTime.GetHashCode();
			}

			hash ^= badges_.GetHashCode();
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

		/// <summary>Container for nested types declared in the GetPlayerProfileResponse message type.</summary>
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
			}

			#endregion
		}

		#endregion
	}

	#endregion
}

#endregion Designer generated code