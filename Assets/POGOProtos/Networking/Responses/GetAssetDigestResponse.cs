// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GetAssetDigestResponse.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Networking/Responses/GetAssetDigestResponse.proto
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
	/// <summary>Holder for reflection information generated from POGOProtos/Networking/Responses/GetAssetDigestResponse.proto</summary>
	public static partial class GetAssetDigestResponseReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Networking/Responses/GetAssetDigestResponse.proto</summary>
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
		/// Initializes static members of the <see cref="GetAssetDigestResponseReflection"/> class.
		/// </summary>
		static GetAssetDigestResponseReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CjxQT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVzcG9uc2VzL0dldEFzc2V0RGln",
						"ZXN0UmVzcG9uc2UucHJvdG8SH1BPR09Qcm90b3MuTmV0d29ya2luZy5SZXNw",
						"b25zZXMaJlBPR09Qcm90b3MvRGF0YS9Bc3NldERpZ2VzdEVudHJ5LnByb3Rv",
						"ImEKFkdldEFzc2V0RGlnZXN0UmVzcG9uc2USMQoGZGlnZXN0GAEgAygLMiEu",
						"UE9HT1Byb3Rvcy5EYXRhLkFzc2V0RGlnZXN0RW50cnkSFAoMdGltZXN0YW1w",
						"X21zGAIgASgEYgZwcm90bzM="));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new[] { global::POGOProtos.Data.AssetDigestEntryReflection.Descriptor, },
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Networking.Responses.GetAssetDigestResponse),
							global::POGOProtos.Networking.Responses.GetAssetDigestResponse.Parser,
							new[] { "Digest", "TimestampMs" },
							null,
							null,
							null)
					}));
		}

		#endregion
	}

	#region Messages

	/// <summary>
	/// The get asset digest response.
	/// </summary>
	public sealed partial class GetAssetDigestResponse : pb::IMessage<GetAssetDigestResponse>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "digest" field.</summary>
		public const int DigestFieldNumber = 1;

		/// <summary>Field number for the "timestamp_ms" field.</summary>
		public const int TimestampMsFieldNumber = 2;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<GetAssetDigestResponse> _parser =
			new pb::MessageParser<GetAssetDigestResponse>(() => new GetAssetDigestResponse());

		/// <summary>
		/// The _repeated_digest_codec.
		/// </summary>
		private static readonly pb.FieldCodec<AssetDigestEntry> _repeated_digest_codec = pb::FieldCodec.ForMessage(
			10,
			global::POGOProtos.Data.AssetDigestEntry.Parser);

		#endregion

		#region  Fields

		/// <summary>
		/// The digest_.
		/// </summary>
		private readonly pbc.RepeatedField<AssetDigestEntry> digest_ = new pbc::RepeatedField<AssetDigestEntry>();

		/// <summary>
		/// The timestamp ms_.
		/// </summary>
		private ulong timestampMs_;

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="GetAssetDigestResponse"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public GetAssetDigestResponse()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="GetAssetDigestResponse"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public GetAssetDigestResponse(GetAssetDigestResponse other) : this()
		{
			digest_ = other.digest_.Clone();
			timestampMs_ = other.timestampMs_;
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<GetAssetDigestResponse> Parser
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
				return global::POGOProtos.Networking.Responses.GetAssetDigestResponseReflection.Descriptor.MessageTypes[0];
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
		/// Gets the digest.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public pbc.RepeatedField<AssetDigestEntry> Digest
		{
			get
			{
				return digest_;
			}
		}

		/// <summary>
		/// Gets or sets the timestamp ms.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public ulong TimestampMs
		{
			get
			{
				return timestampMs_;
			}

			set
			{
				timestampMs_ = value;
			}
		}

		#endregion

		#region  Interface Implementations

		/// <summary>
		/// The clone.
		/// </summary>
		/// <returns>
		/// The <see cref="GetAssetDigestResponse"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public GetAssetDigestResponse Clone()
		{
			return new GetAssetDigestResponse(this);
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
		public bool Equals(GetAssetDigestResponse other)
		{
			if (ReferenceEquals(other, null))
			{
				return false;
			}

			if (ReferenceEquals(other, this))
			{
				return true;
			}

			if (!digest_.Equals(other.digest_))
			{
				return false;
			}

			if (TimestampMs != other.TimestampMs)
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
			digest_.WriteTo(output, _repeated_digest_codec);
			if (TimestampMs != 0UL)
			{
				output.WriteRawTag(16);
				output.WriteUInt64(TimestampMs);
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
			size += digest_.CalculateSize(_repeated_digest_codec);
			if (TimestampMs != 0UL)
			{
				size += 1 + pb::CodedOutputStream.ComputeUInt64Size(TimestampMs);
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
		public void MergeFrom(GetAssetDigestResponse other)
		{
			if (other == null)
			{
				return;
			}

			digest_.Add(other.digest_);
			if (other.TimestampMs != 0UL)
			{
				TimestampMs = other.TimestampMs;
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
						digest_.AddEntriesFrom(input, _repeated_digest_codec);
						break;
					}

					case 16:
					{
						TimestampMs = input.ReadUInt64();
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
			return Equals(other as GetAssetDigestResponse);
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
			hash ^= digest_.GetHashCode();
			if (TimestampMs != 0UL)
			{
				hash ^= TimestampMs.GetHashCode();
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

	#endregion
}

#endregion Designer generated code