// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RequestEnvelope.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Networking/Envelopes/RequestEnvelope.proto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

#pragma warning disable 1591, 0612, 3021

#region Designer generated code

using POGOProtos.Networking.Requests;
using pb = Google.Protobuf;
using pbc = Google.Protobuf.Collections;
using pbr = Google.Protobuf.Reflection;
using scg = System.Collections.Generic;

namespace POGOProtos.Networking.Envelopes
{
	/// <summary>Holder for reflection information generated from POGOProtos/Networking/Envelopes/RequestEnvelope.proto</summary>
	public static partial class RequestEnvelopeReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Networking/Envelopes/RequestEnvelope.proto</summary>
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
		/// Initializes static members of the <see cref="RequestEnvelopeReflection"/> class.
		/// </summary>
		static RequestEnvelopeReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CjVQT0dPUHJvdG9zL05ldHdvcmtpbmcvRW52ZWxvcGVzL1JlcXVlc3RFbnZl",
						"bG9wZS5wcm90bxIfUE9HT1Byb3Rvcy5OZXR3b3JraW5nLkVudmVsb3Blcxos",
						"UE9HT1Byb3Rvcy9OZXR3b3JraW5nL1JlcXVlc3RzL1JlcXVlc3QucHJvdG8a",
						"MFBPR09Qcm90b3MvTmV0d29ya2luZy9FbnZlbG9wZXMvQXV0aFRpY2tldC5w",
						"cm90bxouUE9HT1Byb3Rvcy9OZXR3b3JraW5nL0VudmVsb3Blcy9Vbmtub3du",
						"Ni5wcm90byKkBAoPUmVxdWVzdEVudmVsb3BlEhMKC3N0YXR1c19jb2RlGAEg",
						"ASgFEhIKCnJlcXVlc3RfaWQYAyABKAQSOQoIcmVxdWVzdHMYBCADKAsyJy5Q",
						"T0dPUHJvdG9zLk5ldHdvcmtpbmcuUmVxdWVzdHMuUmVxdWVzdBI7Cgh1bmtu",
						"b3duNhgGIAEoCzIpLlBPR09Qcm90b3MuTmV0d29ya2luZy5FbnZlbG9wZXMu",
						"VW5rbm93bjYSEAoIbGF0aXR1ZGUYByABKAESEQoJbG9uZ2l0dWRlGAggASgB",
						"EhAKCGFsdGl0dWRlGAkgASgBEkwKCWF1dGhfaW5mbxgKIAEoCzI5LlBPR09Q",
						"cm90b3MuTmV0d29ya2luZy5FbnZlbG9wZXMuUmVxdWVzdEVudmVsb3BlLkF1",
						"dGhJbmZvEkAKC2F1dGhfdGlja2V0GAsgASgLMisuUE9HT1Byb3Rvcy5OZXR3",
						"b3JraW5nLkVudmVsb3Blcy5BdXRoVGlja2V0EhEKCXVua25vd24xMhgMIAEo",
						"AxqVAQoIQXV0aEluZm8SEAoIcHJvdmlkZXIYASABKAkSTAoFdG9rZW4YAiAB",
						"KAsyPS5QT0dPUHJvdG9zLk5ldHdvcmtpbmcuRW52ZWxvcGVzLlJlcXVlc3RF",
						"bnZlbG9wZS5BdXRoSW5mby5KV1QaKQoDSldUEhAKCGNvbnRlbnRzGAEgASgJ",
						"EhAKCHVua25vd24yGAIgASgFYgZwcm90bzM="));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new[]
				{
					global::POGOProtos.Networking.Requests.RequestReflection.Descriptor,
					global::POGOProtos.Networking.Envelopes.AuthTicketReflection.Descriptor,
					global::POGOProtos.Networking.Envelopes.Unknown6Reflection.Descriptor,
				},
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Networking.Envelopes.RequestEnvelope),
							global::POGOProtos.Networking.Envelopes.RequestEnvelope.Parser,
							new[]
							{
								"StatusCode", "RequestId", "Requests", "Unknown6", "Latitude", "Longitude", "Altitude", "AuthInfo",
								"AuthTicket", "Unknown12"
							},
							null,
							null,
							new[]
							{
								new pbr::GeneratedClrTypeInfo(
									typeof(global::POGOProtos.Networking.Envelopes.RequestEnvelope.Types.AuthInfo),
									global::POGOProtos.Networking.Envelopes.RequestEnvelope.Types.AuthInfo.Parser,
									new[] { "Provider", "Token" },
									null,
									null,
									new[]
									{
										new pbr::GeneratedClrTypeInfo(
											typeof(global::POGOProtos.Networking.Envelopes.RequestEnvelope.Types.AuthInfo.Types.JWT),
											global::POGOProtos.Networking.Envelopes.RequestEnvelope.Types.AuthInfo.Types.JWT.Parser,
											new[] { "Contents", "Unknown2" },
											null,
											null,
											null)
									})
							})
					}));
		}

		#endregion
	}

	#region Messages

	/// <summary>
	/// The request envelope.
	/// </summary>
	public sealed partial class RequestEnvelope : pb::IMessage<RequestEnvelope>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "status_code" field.</summary>
		public const int StatusCodeFieldNumber = 1;

		/// <summary>Field number for the "request_id" field.</summary>
		public const int RequestIdFieldNumber = 3;

		/// <summary>Field number for the "requests" field.</summary>
		public const int RequestsFieldNumber = 4;

		/// <summary>Field number for the "unknown6" field.</summary>
		public const int Unknown6FieldNumber = 6;

		/// <summary>Field number for the "latitude" field.</summary>
		public const int LatitudeFieldNumber = 7;

		/// <summary>Field number for the "longitude" field.</summary>
		public const int LongitudeFieldNumber = 8;

		/// <summary>Field number for the "altitude" field.</summary>
		public const int AltitudeFieldNumber = 9;

		/// <summary>Field number for the "auth_info" field.</summary>
		public const int AuthInfoFieldNumber = 10;

		/// <summary>Field number for the "auth_ticket" field.</summary>
		public const int AuthTicketFieldNumber = 11;

		/// <summary>Field number for the "unknown12" field.</summary>
		public const int Unknown12FieldNumber = 12;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<RequestEnvelope> _parser =
			new pb::MessageParser<RequestEnvelope>(() => new RequestEnvelope());

		/// <summary>
		/// The _repeated_requests_codec.
		/// </summary>
		private static readonly pb.FieldCodec<Request> _repeated_requests_codec = pb::FieldCodec.ForMessage(
			34,
			global::POGOProtos.Networking.Requests.Request.Parser);

		#endregion

		#region  Fields

		/// <summary>
		/// The altitude_.
		/// </summary>
		private double altitude_;

		/// <summary>
		/// The auth info_.
		/// </summary>
		private Types.AuthInfo authInfo_;

		/// <summary>
		/// The auth ticket_.
		/// </summary>
		private AuthTicket authTicket_;

		/// <summary>
		/// The latitude_.
		/// </summary>
		private double latitude_;

		/// <summary>
		/// The longitude_.
		/// </summary>
		private double longitude_;

		/// <summary>
		/// The request id_.
		/// </summary>
		private ulong requestId_;

		/// <summary>
		/// The requests_.
		/// </summary>
		private readonly pbc.RepeatedField<Request> requests_ = new pbc::RepeatedField<Request>();

		/// <summary>
		/// The status code_.
		/// </summary>
		private int statusCode_;

		/// <summary>
		/// The unknown 12_.
		/// </summary>
		private long unknown12_;

		/// <summary>
		/// The unknown 6_.
		/// </summary>
		private Unknown6 unknown6_;

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="RequestEnvelope"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public RequestEnvelope()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="RequestEnvelope"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public RequestEnvelope(RequestEnvelope other) : this()
		{
			statusCode_ = other.statusCode_;
			requestId_ = other.requestId_;
			requests_ = other.requests_.Clone();
			Unknown6 = other.unknown6_ != null ? other.Unknown6.Clone() : null;
			latitude_ = other.latitude_;
			longitude_ = other.longitude_;
			altitude_ = other.altitude_;
			AuthInfo = other.authInfo_ != null ? other.AuthInfo.Clone() : null;
			AuthTicket = other.authTicket_ != null ? other.AuthTicket.Clone() : null;
			unknown12_ = other.unknown12_;
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<RequestEnvelope> Parser
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
				return global::POGOProtos.Networking.Envelopes.RequestEnvelopeReflection.Descriptor.MessageTypes[0];
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
		/// Gets the requests.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public pbc.RepeatedField<Request> Requests
		{
			get
			{
				return requests_;
			}
		}

		/// <summary>
		/// Gets or sets the unknown 6.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public Unknown6 Unknown6
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
		/// Gets or sets the altitude.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public double Altitude
		{
			get
			{
				return altitude_;
			}

			set
			{
				altitude_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the auth info.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public Types.AuthInfo AuthInfo
		{
			get
			{
				return authInfo_;
			}

			set
			{
				authInfo_ = value;
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
		/// Gets or sets the unknown 12.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public long Unknown12
		{
			get
			{
				return unknown12_;
			}

			set
			{
				unknown12_ = value;
			}
		}

		#endregion

		#region  Interface Implementations

		/// <summary>
		/// The clone.
		/// </summary>
		/// <returns>
		/// The <see cref="RequestEnvelope"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public RequestEnvelope Clone()
		{
			return new RequestEnvelope(this);
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
		public bool Equals(RequestEnvelope other)
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

			if (!requests_.Equals(other.requests_))
			{
				return false;
			}

			if (!object.Equals(Unknown6, other.Unknown6))
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

			if (Altitude != other.Altitude)
			{
				return false;
			}

			if (!object.Equals(AuthInfo, other.AuthInfo))
			{
				return false;
			}

			if (!object.Equals(AuthTicket, other.AuthTicket))
			{
				return false;
			}

			if (Unknown12 != other.Unknown12)
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
				output.WriteRawTag(24);
				output.WriteUInt64(RequestId);
			}

			requests_.WriteTo(output, _repeated_requests_codec);
			if (unknown6_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(Unknown6);
			}

			if (Latitude != 0D)
			{
				output.WriteRawTag(57);
				output.WriteDouble(Latitude);
			}

			if (Longitude != 0D)
			{
				output.WriteRawTag(65);
				output.WriteDouble(Longitude);
			}

			if (Altitude != 0D)
			{
				output.WriteRawTag(73);
				output.WriteDouble(Altitude);
			}

			if (authInfo_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(AuthInfo);
			}

			if (authTicket_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(AuthTicket);
			}

			if (Unknown12 != 0L)
			{
				output.WriteRawTag(96);
				output.WriteInt64(Unknown12);
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

			size += requests_.CalculateSize(_repeated_requests_codec);
			if (unknown6_ != null)
			{
				size += 1 + pb::CodedOutputStream.ComputeMessageSize(Unknown6);
			}

			if (Latitude != 0D)
			{
				size += 1 + 8;
			}

			if (Longitude != 0D)
			{
				size += 1 + 8;
			}

			if (Altitude != 0D)
			{
				size += 1 + 8;
			}

			if (authInfo_ != null)
			{
				size += 1 + pb::CodedOutputStream.ComputeMessageSize(AuthInfo);
			}

			if (authTicket_ != null)
			{
				size += 1 + pb::CodedOutputStream.ComputeMessageSize(AuthTicket);
			}

			if (Unknown12 != 0L)
			{
				size += 1 + pb::CodedOutputStream.ComputeInt64Size(Unknown12);
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
		public void MergeFrom(RequestEnvelope other)
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

			requests_.Add(other.requests_);
			if (other.unknown6_ != null)
			{
				if (unknown6_ == null)
				{
					unknown6_ = new global::POGOProtos.Networking.Envelopes.Unknown6();
				}

				Unknown6.MergeFrom(other.Unknown6);
			}

			if (other.Latitude != 0D)
			{
				Latitude = other.Latitude;
			}

			if (other.Longitude != 0D)
			{
				Longitude = other.Longitude;
			}

			if (other.Altitude != 0D)
			{
				Altitude = other.Altitude;
			}

			if (other.authInfo_ != null)
			{
				if (authInfo_ == null)
				{
					authInfo_ = new global::POGOProtos.Networking.Envelopes.RequestEnvelope.Types.AuthInfo();
				}

				AuthInfo.MergeFrom(other.AuthInfo);
			}

			if (other.authTicket_ != null)
			{
				if (authTicket_ == null)
				{
					authTicket_ = new global::POGOProtos.Networking.Envelopes.AuthTicket();
				}

				AuthTicket.MergeFrom(other.AuthTicket);
			}

			if (other.Unknown12 != 0L)
			{
				Unknown12 = other.Unknown12;
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

					case 24:
					{
						RequestId = input.ReadUInt64();
						break;
					}

					case 34:
					{
						requests_.AddEntriesFrom(input, _repeated_requests_codec);
						break;
					}

					case 50:
					{
						if (unknown6_ == null)
						{
							unknown6_ = new global::POGOProtos.Networking.Envelopes.Unknown6();
						}

						input.ReadMessage(unknown6_);
						break;
					}

					case 57:
					{
						Latitude = input.ReadDouble();
						break;
					}

					case 65:
					{
						Longitude = input.ReadDouble();
						break;
					}

					case 73:
					{
						Altitude = input.ReadDouble();
						break;
					}

					case 82:
					{
						if (authInfo_ == null)
						{
							authInfo_ = new global::POGOProtos.Networking.Envelopes.RequestEnvelope.Types.AuthInfo();
						}

						input.ReadMessage(authInfo_);
						break;
					}

					case 90:
					{
						if (authTicket_ == null)
						{
							authTicket_ = new global::POGOProtos.Networking.Envelopes.AuthTicket();
						}

						input.ReadMessage(authTicket_);
						break;
					}

					case 96:
					{
						Unknown12 = input.ReadInt64();
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
			return Equals(other as RequestEnvelope);
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

			hash ^= requests_.GetHashCode();
			if (unknown6_ != null)
			{
				hash ^= Unknown6.GetHashCode();
			}

			if (Latitude != 0D)
			{
				hash ^= Latitude.GetHashCode();
			}

			if (Longitude != 0D)
			{
				hash ^= Longitude.GetHashCode();
			}

			if (Altitude != 0D)
			{
				hash ^= Altitude.GetHashCode();
			}

			if (authInfo_ != null)
			{
				hash ^= AuthInfo.GetHashCode();
			}

			if (authTicket_ != null)
			{
				hash ^= AuthTicket.GetHashCode();
			}

			if (Unknown12 != 0L)
			{
				hash ^= Unknown12.GetHashCode();
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

		/// <summary>Container for nested types declared in the RequestEnvelope message type.</summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static partial class Types
		{
			/// <summary>
			/// The auth info.
			/// </summary>
			public sealed partial class AuthInfo : pb::IMessage<AuthInfo>
			{
				#region Static Fields and Constants

				/// <summary>Field number for the "provider" field.</summary>
				public const int ProviderFieldNumber = 1;

				/// <summary>Field number for the "token" field.</summary>
				public const int TokenFieldNumber = 2;

				/// <summary>
				/// The _parser.
				/// </summary>
				private static readonly pb.MessageParser<AuthInfo> _parser = new pb::MessageParser<AuthInfo>(() => new AuthInfo());

				#endregion

				#region  Fields

				/// <summary>
				/// The provider_.
				/// </summary>
				private string provider_ = string.Empty;

				/// <summary>
				/// The token_.
				/// </summary>
				private Types.JWT token_;

				#endregion

				#region  Constructors

				/// <summary>
				/// Initializes a new instance of the <see cref="AuthInfo"/> class.
				/// </summary>
				[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
				public AuthInfo()
				{
					OnConstruction();
				}

				/// <summary>
				/// Initializes a new instance of the <see cref="AuthInfo"/> class.
				/// </summary>
				/// <param name="other">
				/// The other.
				/// </param>
				[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
				public AuthInfo(AuthInfo other) : this()
				{
					provider_ = other.provider_;
					Token = other.token_ != null ? other.Token.Clone() : null;
				}

				#endregion

				#region  Properties - Public

				/// <summary>
				/// Gets the parser.
				/// </summary>
				[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
				public static pb.MessageParser<AuthInfo> Parser
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
						return global::POGOProtos.Networking.Envelopes.RequestEnvelope.Descriptor.NestedTypes[0];
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
				/// Gets or sets the provider.
				/// </summary>
				[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
				public string Provider
				{
					get
					{
						return provider_;
					}

					set
					{
						provider_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
					}
				}

				/// <summary>
				/// Gets or sets the token.
				/// </summary>
				[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
				public Types.JWT Token
				{
					get
					{
						return token_;
					}

					set
					{
						token_ = value;
					}
				}

				#endregion

				#region  Interface Implementations

				/// <summary>
				/// The clone.
				/// </summary>
				/// <returns>
				/// The <see cref="AuthInfo"/>.
				/// </returns>
				[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
				public AuthInfo Clone()
				{
					return new AuthInfo(this);
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
				public bool Equals(AuthInfo other)
				{
					if (ReferenceEquals(other, null))
					{
						return false;
					}

					if (ReferenceEquals(other, this))
					{
						return true;
					}

					if (Provider != other.Provider)
					{
						return false;
					}

					if (!object.Equals(Token, other.Token))
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
					if (Provider.Length != 0)
					{
						output.WriteRawTag(10);
						output.WriteString(Provider);
					}

					if (token_ != null)
					{
						output.WriteRawTag(18);
						output.WriteMessage(Token);
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
					if (Provider.Length != 0)
					{
						size += 1 + pb::CodedOutputStream.ComputeStringSize(Provider);
					}

					if (token_ != null)
					{
						size += 1 + pb::CodedOutputStream.ComputeMessageSize(Token);
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
				public void MergeFrom(AuthInfo other)
				{
					if (other == null)
					{
						return;
					}

					if (other.Provider.Length != 0)
					{
						Provider = other.Provider;
					}

					if (other.token_ != null)
					{
						if (token_ == null)
						{
							token_ = new global::POGOProtos.Networking.Envelopes.RequestEnvelope.Types.AuthInfo.Types.JWT();
						}

						Token.MergeFrom(other.Token);
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
								Provider = input.ReadString();
								break;
							}

							case 18:
							{
								if (token_ == null)
								{
									token_ = new global::POGOProtos.Networking.Envelopes.RequestEnvelope.Types.AuthInfo.Types.JWT();
								}

								input.ReadMessage(token_);
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
					return Equals(other as AuthInfo);
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
					if (Provider.Length != 0)
					{
						hash ^= Provider.GetHashCode();
					}

					if (token_ != null)
					{
						hash ^= Token.GetHashCode();
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

				/// <summary>Container for nested types declared in the AuthInfo message type.</summary>
				[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
				public static partial class Types
				{
					/// <summary>
					/// The jwt.
					/// </summary>
					public sealed partial class JWT : pb::IMessage<JWT>
					{
						#region Static Fields and Constants

						/// <summary>Field number for the "contents" field.</summary>
						public const int ContentsFieldNumber = 1;

						/// <summary>Field number for the "unknown2" field.</summary>
						public const int Unknown2FieldNumber = 2;

						/// <summary>
						/// The _parser.
						/// </summary>
						private static readonly pb.MessageParser<JWT> _parser = new pb::MessageParser<JWT>(() => new JWT());

						#endregion

						#region  Fields

						/// <summary>
						/// The contents_.
						/// </summary>
						private string contents_ = string.Empty;

						/// <summary>
						/// The unknown 2_.
						/// </summary>
						private int unknown2_;

						#endregion

						#region  Constructors

						/// <summary>
						/// Initializes a new instance of the <see cref="JWT"/> class.
						/// </summary>
						[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
						public JWT()
						{
							OnConstruction();
						}

						/// <summary>
						/// Initializes a new instance of the <see cref="JWT"/> class.
						/// </summary>
						/// <param name="other">
						/// The other.
						/// </param>
						[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
						public JWT(JWT other) : this()
						{
							contents_ = other.contents_;
							unknown2_ = other.unknown2_;
						}

						#endregion

						#region  Properties - Public

						/// <summary>
						/// Gets the parser.
						/// </summary>
						[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
						public static pb.MessageParser<JWT> Parser
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
								return global::POGOProtos.Networking.Envelopes.RequestEnvelope.Types.AuthInfo.Descriptor.NestedTypes[0];
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
						/// Gets or sets the contents.
						/// </summary>
						[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
						public string Contents
						{
							get
							{
								return contents_;
							}

							set
							{
								contents_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
							}
						}

						/// <summary>
						/// Gets or sets the unknown 2.
						/// </summary>
						[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
						public int Unknown2
						{
							get
							{
								return unknown2_;
							}

							set
							{
								unknown2_ = value;
							}
						}

						#endregion

						#region  Interface Implementations

						/// <summary>
						/// The clone.
						/// </summary>
						/// <returns>
						/// The <see cref="JWT"/>.
						/// </returns>
						[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
						public JWT Clone()
						{
							return new JWT(this);
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
						public bool Equals(JWT other)
						{
							if (ReferenceEquals(other, null))
							{
								return false;
							}

							if (ReferenceEquals(other, this))
							{
								return true;
							}

							if (Contents != other.Contents)
							{
								return false;
							}

							if (Unknown2 != other.Unknown2)
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
							if (Contents.Length != 0)
							{
								output.WriteRawTag(10);
								output.WriteString(Contents);
							}

							if (Unknown2 != 0)
							{
								output.WriteRawTag(16);
								output.WriteInt32(Unknown2);
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
							if (Contents.Length != 0)
							{
								size += 1 + pb::CodedOutputStream.ComputeStringSize(Contents);
							}

							if (Unknown2 != 0)
							{
								size += 1 + pb::CodedOutputStream.ComputeInt32Size(Unknown2);
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
						public void MergeFrom(JWT other)
						{
							if (other == null)
							{
								return;
							}

							if (other.Contents.Length != 0)
							{
								Contents = other.Contents;
							}

							if (other.Unknown2 != 0)
							{
								Unknown2 = other.Unknown2;
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
										Contents = input.ReadString();
										break;
									}

									case 16:
									{
										Unknown2 = input.ReadInt32();
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
							return Equals(other as JWT);
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
							if (Contents.Length != 0)
							{
								hash ^= Contents.GetHashCode();
							}

							if (Unknown2 != 0)
							{
								hash ^= Unknown2.GetHashCode();
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
		}

		#endregion
	}

	#endregion
}

#endregion Designer generated code