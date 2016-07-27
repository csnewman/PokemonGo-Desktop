// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ResponseEnvelope.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Networking/Envelopes/ResponseEnvelope.proto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

#pragma warning disable 1591, 0612, 3021

#region Designer generated code

using pb = Google.Protobuf;
using pbc = Google.Protobuf.Collections;
using pbr = Google.Protobuf.Reflection;
using scg = System.Collections.Generic;

namespace POGOProtos.Networking.Envelopes
{
	/// <summary>Holder for reflection information generated from POGOProtos/Networking/Envelopes/ResponseEnvelope.proto</summary>
	public static partial class ResponseEnvelopeReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Networking/Envelopes/ResponseEnvelope.proto</summary>
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
		/// Initializes static members of the <see cref="ResponseEnvelopeReflection"/> class.
		/// </summary>
		static ResponseEnvelopeReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CjZQT0dPUHJvdG9zL05ldHdvcmtpbmcvRW52ZWxvcGVzL1Jlc3BvbnNlRW52",
						"ZWxvcGUucHJvdG8SH1BPR09Qcm90b3MuTmV0d29ya2luZy5FbnZlbG9wZXMa",
						"MFBPR09Qcm90b3MvTmV0d29ya2luZy9FbnZlbG9wZXMvQXV0aFRpY2tldC5w",
						"cm90bxo2UE9HT1Byb3Rvcy9OZXR3b3JraW5nL0VudmVsb3Blcy9Vbmtub3du",
						"NlJlc3BvbnNlLnByb3RvIrgCChBSZXNwb25zZUVudmVsb3BlEhMKC3N0YXR1",
						"c19jb2RlGAEgASgFEhIKCnJlcXVlc3RfaWQYAiABKAQSDwoHYXBpX3VybBgD",
						"IAEoCRJDCgh1bmtub3duNhgGIAEoCzIxLlBPR09Qcm90b3MuTmV0d29ya2lu",
						"Zy5FbnZlbG9wZXMuVW5rbm93bjZSZXNwb25zZRJACgthdXRoX3RpY2tldBgH",
						"IAEoCzIrLlBPR09Qcm90b3MuTmV0d29ya2luZy5FbnZlbG9wZXMuQXV0aFRp",
						"Y2tldBIPCgdyZXR1cm5zGGQgAygMEg0KBWVycm9yGGUgASgJGkMKCFVua25v",
						"d243EhEKCXVua25vd243MRgBIAEoDBIRCgl1bmtub3duNzIYAiABKAMSEQoJ",
						"dW5rbm93bjczGAMgASgMYgZwcm90bzM="));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new[]
				{
					global::POGOProtos.Networking.Envelopes.AuthTicketReflection.Descriptor,
					global::POGOProtos.Networking.Envelopes.Unknown6ResponseReflection.Descriptor,
				},
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Networking.Envelopes.ResponseEnvelope),
							global::POGOProtos.Networking.Envelopes.ResponseEnvelope.Parser,
							new[] { "StatusCode", "RequestId", "ApiUrl", "Unknown6", "AuthTicket", "Returns", "Error" },
							null,
							null,
							new[]
							{
								new pbr::GeneratedClrTypeInfo(
									typeof(global::POGOProtos.Networking.Envelopes.ResponseEnvelope.Types.Unknown7),
									global::POGOProtos.Networking.Envelopes.ResponseEnvelope.Types.Unknown7.Parser,
									new[] { "Unknown71", "Unknown72", "Unknown73" },
									null,
									null,
									null)
							})
					}));
		}

		#endregion
	}

	#region Messages

	/// <summary>
	/// The response envelope.
	/// </summary>
	public sealed partial class ResponseEnvelope : pb::IMessage<ResponseEnvelope>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "status_code" field.</summary>
		public const int StatusCodeFieldNumber = 1;

		/// <summary>Field number for the "request_id" field.</summary>
		public const int RequestIdFieldNumber = 2;

		/// <summary>Field number for the "api_url" field.</summary>
		public const int ApiUrlFieldNumber = 3;

		/// <summary>Field number for the "unknown6" field.</summary>
		public const int Unknown6FieldNumber = 6;

		/// <summary>Field number for the "auth_ticket" field.</summary>
		public const int AuthTicketFieldNumber = 7;

		/// <summary>Field number for the "returns" field.</summary>
		public const int ReturnsFieldNumber = 100;

		/// <summary>Field number for the "error" field.</summary>
		public const int ErrorFieldNumber = 101;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<ResponseEnvelope> _parser =
			new pb::MessageParser<ResponseEnvelope>(() => new ResponseEnvelope());

		/// <summary>
		/// The _repeated_returns_codec.
		/// </summary>
		private static readonly pb.FieldCodec<pb.ByteString> _repeated_returns_codec = pb::FieldCodec.ForBytes(802);

		#endregion

		#region  Fields

		/// <summary>
		/// The api url_.
		/// </summary>
		private string apiUrl_ = string.Empty;

		/// <summary>
		/// The auth ticket_.
		/// </summary>
		private AuthTicket authTicket_;

		/// <summary>
		/// The error_.
		/// </summary>
		private string error_ = string.Empty;

		/// <summary>
		/// The request id_.
		/// </summary>
		private ulong requestId_;

		/// <summary>
		/// The returns_.
		/// </summary>
		private readonly pbc.RepeatedField<pb.ByteString> returns_ = new pbc::RepeatedField<pb.ByteString>();

		/// <summary>
		/// The status code_.
		/// </summary>
		private int statusCode_;

		/// <summary>
		/// The unknown 6_.
		/// </summary>
		private Unknown6Response unknown6_;

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="ResponseEnvelope"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public ResponseEnvelope()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="ResponseEnvelope"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public ResponseEnvelope(ResponseEnvelope other) : this()
		{
			statusCode_ = other.statusCode_;
			requestId_ = other.requestId_;
			apiUrl_ = other.apiUrl_;
			Unknown6 = other.unknown6_ != null ? other.Unknown6.Clone() : null;
			AuthTicket = other.authTicket_ != null ? other.AuthTicket.Clone() : null;
			returns_ = other.returns_.Clone();
			error_ = other.error_;
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<ResponseEnvelope> Parser
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
				return global::POGOProtos.Networking.Envelopes.ResponseEnvelopeReflection.Descriptor.MessageTypes[0];
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
		/// Gets or sets the status code.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public int StatusCode
		{
			get
			{
				return statusCode_;
			}

			set
			{
				statusCode_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the request id.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public ulong RequestId
		{
			get
			{
				return requestId_;
			}

			set
			{
				requestId_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the api url.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public string ApiUrl
		{
			get
			{
				return apiUrl_;
			}

			set
			{
				apiUrl_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
			}
		}

		/// <summary>
		/// Gets or sets the unknown 6.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public Unknown6Response Unknown6
		{
			get
			{
				return unknown6_;
			}

			set
			{
				unknown6_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the auth ticket.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public AuthTicket AuthTicket
		{
			get
			{
				return authTicket_;
			}

			set
			{
				authTicket_ = value;
			}
		}

		/// <summary>
		/// Gets the returns.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public pbc.RepeatedField<pb.ByteString> Returns
		{
			get
			{
				return returns_;
			}
		}

		/// <summary>
		/// Gets or sets the error.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public string Error
		{
			get
			{
				return error_;
			}

			set
			{
				error_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
			}
		}

		#endregion

		#region  Interface Implementations

		/// <summary>
		/// The clone.
		/// </summary>
		/// <returns>
		/// The <see cref="ResponseEnvelope"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public ResponseEnvelope Clone()
		{
			return new ResponseEnvelope(this);
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
		public bool Equals(ResponseEnvelope other)
		{
			if (ReferenceEquals(other, null))
			{
				return false;
			}

			if (ReferenceEquals(other, this))
			{
				return true;
			}

			if (StatusCode != other.StatusCode)
			{
				return false;
			}

			if (RequestId != other.RequestId)
			{
				return false;
			}

			if (ApiUrl != other.ApiUrl)
			{
				return false;
			}

			if (!object.Equals(Unknown6, other.Unknown6))
			{
				return false;
			}

			if (!object.Equals(AuthTicket, other.AuthTicket))
			{
				return false;
			}

			if (!returns_.Equals(other.returns_))
			{
				return false;
			}

			if (Error != other.Error)
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
			if (StatusCode != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(StatusCode);
			}

			if (RequestId != 0UL)
			{
				output.WriteRawTag(16);
				output.WriteUInt64(RequestId);
			}

			if (ApiUrl.Length != 0)
			{
				output.WriteRawTag(26);
				output.WriteString(ApiUrl);
			}

			if (unknown6_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(Unknown6);
			}

			if (authTicket_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(AuthTicket);
			}

			returns_.WriteTo(output, _repeated_returns_codec);
			if (Error.Length != 0)
			{
				output.WriteRawTag(170, 6);
				output.WriteString(Error);
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
			if (StatusCode != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeInt32Size(StatusCode);
			}

			if (RequestId != 0UL)
			{
				size += 1 + pb::CodedOutputStream.ComputeUInt64Size(RequestId);
			}

			if (ApiUrl.Length != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeStringSize(ApiUrl);
			}

			if (unknown6_ != null)
			{
				size += 1 + pb::CodedOutputStream.ComputeMessageSize(Unknown6);
			}

			if (authTicket_ != null)
			{
				size += 1 + pb::CodedOutputStream.ComputeMessageSize(AuthTicket);
			}

			size += returns_.CalculateSize(_repeated_returns_codec);
			if (Error.Length != 0)
			{
				size += 2 + pb::CodedOutputStream.ComputeStringSize(Error);
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
		public void MergeFrom(ResponseEnvelope other)
		{
			if (other == null)
			{
				return;
			}

			if (other.StatusCode != 0)
			{
				StatusCode = other.StatusCode;
			}

			if (other.RequestId != 0UL)
			{
				RequestId = other.RequestId;
			}

			if (other.ApiUrl.Length != 0)
			{
				ApiUrl = other.ApiUrl;
			}

			if (other.unknown6_ != null)
			{
				if (unknown6_ == null)
				{
					unknown6_ = new global::POGOProtos.Networking.Envelopes.Unknown6Response();
				}

				Unknown6.MergeFrom(other.Unknown6);
			}

			if (other.authTicket_ != null)
			{
				if (authTicket_ == null)
				{
					authTicket_ = new global::POGOProtos.Networking.Envelopes.AuthTicket();
				}

				AuthTicket.MergeFrom(other.AuthTicket);
			}

			returns_.Add(other.returns_);
			if (other.Error.Length != 0)
			{
				Error = other.Error;
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
						StatusCode = input.ReadInt32();
						break;
					}

					case 16:
					{
						RequestId = input.ReadUInt64();
						break;
					}

					case 26:
					{
						ApiUrl = input.ReadString();
						break;
					}

					case 50:
					{
						if (unknown6_ == null)
						{
							unknown6_ = new global::POGOProtos.Networking.Envelopes.Unknown6Response();
						}

						input.ReadMessage(unknown6_);
						break;
					}

					case 58:
					{
						if (authTicket_ == null)
						{
							authTicket_ = new global::POGOProtos.Networking.Envelopes.AuthTicket();
						}

						input.ReadMessage(authTicket_);
						break;
					}

					case 802:
					{
						returns_.AddEntriesFrom(input, _repeated_returns_codec);
						break;
					}

					case 810:
					{
						Error = input.ReadString();
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
			return Equals(other as ResponseEnvelope);
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
			if (StatusCode != 0)
			{
				hash ^= StatusCode.GetHashCode();
			}

			if (RequestId != 0UL)
			{
				hash ^= RequestId.GetHashCode();
			}

			if (ApiUrl.Length != 0)
			{
				hash ^= ApiUrl.GetHashCode();
			}

			if (unknown6_ != null)
			{
				hash ^= Unknown6.GetHashCode();
			}

			if (authTicket_ != null)
			{
				hash ^= AuthTicket.GetHashCode();
			}

			hash ^= returns_.GetHashCode();
			if (Error.Length != 0)
			{
				hash ^= Error.GetHashCode();
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

		/// <summary>Container for nested types declared in the ResponseEnvelope message type.</summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static partial class Types
		{
			/// <summary>
			/// The unknown 7.
			/// </summary>
			public sealed partial class Unknown7 : pb::IMessage<Unknown7>
			{
				#region Static Fields and Constants

				/// <summary>Field number for the "unknown71" field.</summary>
				public const int Unknown71FieldNumber = 1;

				/// <summary>Field number for the "unknown72" field.</summary>
				public const int Unknown72FieldNumber = 2;

				/// <summary>Field number for the "unknown73" field.</summary>
				public const int Unknown73FieldNumber = 3;

				/// <summary>
				/// The _parser.
				/// </summary>
				private static readonly pb.MessageParser<Unknown7> _parser = new pb::MessageParser<Unknown7>(() => new Unknown7());

				#endregion

				#region  Fields

				/// <summary>
				/// The unknown 71_.
				/// </summary>
				private pb.ByteString unknown71_ = pb::ByteString.Empty;

				/// <summary>
				/// The unknown 72_.
				/// </summary>
				private long unknown72_;

				/// <summary>
				/// The unknown 73_.
				/// </summary>
				private pb.ByteString unknown73_ = pb::ByteString.Empty;

				#endregion

				#region  Constructors

				/// <summary>
				/// Initializes a new instance of the <see cref="Unknown7"/> class.
				/// </summary>
				[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
				public Unknown7()
				{
					OnConstruction();
				}

				/// <summary>
				/// Initializes a new instance of the <see cref="Unknown7"/> class.
				/// </summary>
				/// <param name="other">
				/// The other.
				/// </param>
				[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
				public Unknown7(Unknown7 other) : this()
				{
					unknown71_ = other.unknown71_;
					unknown72_ = other.unknown72_;
					unknown73_ = other.unknown73_;
				}

				#endregion

				#region  Properties - Public

				/// <summary>
				/// Gets the parser.
				/// </summary>
				[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
				public static pb.MessageParser<Unknown7> Parser
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
						return global::POGOProtos.Networking.Envelopes.ResponseEnvelope.Descriptor.NestedTypes[0];
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
				/// Gets or sets the unknown 71.
				/// </summary>
				[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
				public pb.ByteString Unknown71
				{
					get
					{
						return unknown71_;
					}

					set
					{
						unknown71_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
					}
				}

				/// <summary>
				/// Gets or sets the unknown 72.
				/// </summary>
				[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
				public long Unknown72
				{
					get
					{
						return unknown72_;
					}

					set
					{
						unknown72_ = value;
					}
				}

				/// <summary>
				/// Gets or sets the unknown 73.
				/// </summary>
				[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
				public pb.ByteString Unknown73
				{
					get
					{
						return unknown73_;
					}

					set
					{
						unknown73_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
					}
				}

				#endregion

				#region  Interface Implementations

				/// <summary>
				/// The clone.
				/// </summary>
				/// <returns>
				/// The <see cref="Unknown7"/>.
				/// </returns>
				[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
				public Unknown7 Clone()
				{
					return new Unknown7(this);
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
				public bool Equals(Unknown7 other)
				{
					if (ReferenceEquals(other, null))
					{
						return false;
					}

					if (ReferenceEquals(other, this))
					{
						return true;
					}

					if (Unknown71 != other.Unknown71)
					{
						return false;
					}

					if (Unknown72 != other.Unknown72)
					{
						return false;
					}

					if (Unknown73 != other.Unknown73)
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
					if (Unknown71.Length != 0)
					{
						output.WriteRawTag(10);
						output.WriteBytes(Unknown71);
					}

					if (Unknown72 != 0L)
					{
						output.WriteRawTag(16);
						output.WriteInt64(Unknown72);
					}

					if (Unknown73.Length != 0)
					{
						output.WriteRawTag(26);
						output.WriteBytes(Unknown73);
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
					if (Unknown71.Length != 0)
					{
						size += 1 + pb::CodedOutputStream.ComputeBytesSize(Unknown71);
					}

					if (Unknown72 != 0L)
					{
						size += 1 + pb::CodedOutputStream.ComputeInt64Size(Unknown72);
					}

					if (Unknown73.Length != 0)
					{
						size += 1 + pb::CodedOutputStream.ComputeBytesSize(Unknown73);
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
				public void MergeFrom(Unknown7 other)
				{
					if (other == null)
					{
						return;
					}

					if (other.Unknown71.Length != 0)
					{
						Unknown71 = other.Unknown71;
					}

					if (other.Unknown72 != 0L)
					{
						Unknown72 = other.Unknown72;
					}

					if (other.Unknown73.Length != 0)
					{
						Unknown73 = other.Unknown73;
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
								Unknown71 = input.ReadBytes();
								break;
							}

							case 16:
							{
								Unknown72 = input.ReadInt64();
								break;
							}

							case 26:
							{
								Unknown73 = input.ReadBytes();
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
					return Equals(other as Unknown7);
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
					if (Unknown71.Length != 0)
					{
						hash ^= Unknown71.GetHashCode();
					}

					if (Unknown72 != 0L)
					{
						hash ^= Unknown72.GetHashCode();
					}

					if (Unknown73.Length != 0)
					{
						hash ^= Unknown73.GetHashCode();
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
		}

		#endregion
	}

	#endregion
}

#endregion Designer generated code