// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DownloadRemoteConfigVersionResponse.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Networking/Responses/DownloadRemoteConfigVersionResponse.proto
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
	/// <summary>Holder for reflection information generated from POGOProtos/Networking/Responses/DownloadRemoteConfigVersionResponse.proto</summary>
	public static partial class DownloadRemoteConfigVersionResponseReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Networking/Responses/DownloadRemoteConfigVersionResponse.proto</summary>
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
		/// Initializes static members of the <see cref="DownloadRemoteConfigVersionResponseReflection"/> class.
		/// </summary>
		static DownloadRemoteConfigVersionResponseReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CklQT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVzcG9uc2VzL0Rvd25sb2FkUmVt",
						"b3RlQ29uZmlnVmVyc2lvblJlc3BvbnNlLnByb3RvEh9QT0dPUHJvdG9zLk5l",
						"dHdvcmtpbmcuUmVzcG9uc2VzIuwBCiNEb3dubG9hZFJlbW90ZUNvbmZpZ1Zl",
						"cnNpb25SZXNwb25zZRJbCgZyZXN1bHQYASABKA4ySy5QT0dPUHJvdG9zLk5l",
						"dHdvcmtpbmcuUmVzcG9uc2VzLkRvd25sb2FkUmVtb3RlQ29uZmlnVmVyc2lv",
						"blJlc3BvbnNlLlJlc3VsdBIjChtpdGVtX3RlbXBsYXRlc190aW1lc3RhbXBf",
						"bXMYAiABKAQSIQoZYXNzZXRfZGlnZXN0X3RpbWVzdGFtcF9tcxgDIAEoBCIg",
						"CgZSZXN1bHQSCQoFVU5TRVQQABILCgdTVUNDRVNTEAFiBnByb3RvMw=="));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new pbr.FileDescriptor[] { },
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Networking.Responses.DownloadRemoteConfigVersionResponse),
							global::POGOProtos.Networking.Responses.DownloadRemoteConfigVersionResponse.Parser,
							new[] { "Result", "ItemTemplatesTimestampMs", "AssetDigestTimestampMs" },
							null,
							new[] { typeof(global::POGOProtos.Networking.Responses.DownloadRemoteConfigVersionResponse.Types.Result) },
							null)
					}));
		}

		#endregion
	}

	#region Messages

	/// <summary>
	/// The download remote config version response.
	/// </summary>
	public sealed partial class DownloadRemoteConfigVersionResponse : pb::IMessage<DownloadRemoteConfigVersionResponse>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "result" field.</summary>
		public const int ResultFieldNumber = 1;

		/// <summary>Field number for the "item_templates_timestamp_ms" field.</summary>
		public const int ItemTemplatesTimestampMsFieldNumber = 2;

		/// <summary>Field number for the "asset_digest_timestamp_ms" field.</summary>
		public const int AssetDigestTimestampMsFieldNumber = 3;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<DownloadRemoteConfigVersionResponse> _parser =
			new pb::MessageParser<DownloadRemoteConfigVersionResponse>(() => new DownloadRemoteConfigVersionResponse());

		#endregion

		#region  Fields

		/// <summary>
		/// The asset digest timestamp ms_.
		/// </summary>
		private ulong assetDigestTimestampMs_;

		/// <summary>
		/// The item templates timestamp ms_.
		/// </summary>
		private ulong itemTemplatesTimestampMs_;

		/// <summary>
		/// The result_.
		/// </summary>
		private Types.Result result_ = 0;

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="DownloadRemoteConfigVersionResponse"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public DownloadRemoteConfigVersionResponse()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="DownloadRemoteConfigVersionResponse"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public DownloadRemoteConfigVersionResponse(DownloadRemoteConfigVersionResponse other) : this()
		{
			result_ = other.result_;
			itemTemplatesTimestampMs_ = other.itemTemplatesTimestampMs_;
			assetDigestTimestampMs_ = other.assetDigestTimestampMs_;
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<DownloadRemoteConfigVersionResponse> Parser
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
				return
					global::POGOProtos.Networking.Responses.DownloadRemoteConfigVersionResponseReflection.Descriptor.MessageTypes[0];
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
		///  Latest available?
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public ulong ItemTemplatesTimestampMs
		{
			get
			{
				return itemTemplatesTimestampMs_;
			}

			set
			{
				itemTemplatesTimestampMs_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the asset digest timestamp ms.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public ulong AssetDigestTimestampMs
		{
			get
			{
				return assetDigestTimestampMs_;
			}

			set
			{
				assetDigestTimestampMs_ = value;
			}
		}

		#endregion

		#region  Interface Implementations

		/// <summary>
		/// The clone.
		/// </summary>
		/// <returns>
		/// The <see cref="DownloadRemoteConfigVersionResponse"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public DownloadRemoteConfigVersionResponse Clone()
		{
			return new DownloadRemoteConfigVersionResponse(this);
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
		public bool Equals(DownloadRemoteConfigVersionResponse other)
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

			if (ItemTemplatesTimestampMs != other.ItemTemplatesTimestampMs)
			{
				return false;
			}

			if (AssetDigestTimestampMs != other.AssetDigestTimestampMs)
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

			if (ItemTemplatesTimestampMs != 0UL)
			{
				output.WriteRawTag(16);
				output.WriteUInt64(ItemTemplatesTimestampMs);
			}

			if (AssetDigestTimestampMs != 0UL)
			{
				output.WriteRawTag(24);
				output.WriteUInt64(AssetDigestTimestampMs);
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

			if (ItemTemplatesTimestampMs != 0UL)
			{
				size += 1 + pb::CodedOutputStream.ComputeUInt64Size(ItemTemplatesTimestampMs);
			}

			if (AssetDigestTimestampMs != 0UL)
			{
				size += 1 + pb::CodedOutputStream.ComputeUInt64Size(AssetDigestTimestampMs);
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
		public void MergeFrom(DownloadRemoteConfigVersionResponse other)
		{
			if (other == null)
			{
				return;
			}

			if (other.Result != 0)
			{
				Result = other.Result;
			}

			if (other.ItemTemplatesTimestampMs != 0UL)
			{
				ItemTemplatesTimestampMs = other.ItemTemplatesTimestampMs;
			}

			if (other.AssetDigestTimestampMs != 0UL)
			{
				AssetDigestTimestampMs = other.AssetDigestTimestampMs;
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
						result_ =
							(global::POGOProtos.Networking.Responses.DownloadRemoteConfigVersionResponse.Types.Result)input.ReadEnum();
						break;
					}

					case 16:
					{
						ItemTemplatesTimestampMs = input.ReadUInt64();
						break;
					}

					case 24:
					{
						AssetDigestTimestampMs = input.ReadUInt64();
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
			return Equals(other as DownloadRemoteConfigVersionResponse);
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

			if (ItemTemplatesTimestampMs != 0UL)
			{
				hash ^= ItemTemplatesTimestampMs.GetHashCode();
			}

			if (AssetDigestTimestampMs != 0UL)
			{
				hash ^= AssetDigestTimestampMs.GetHashCode();
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

		/// <summary>Container for nested types declared in the DownloadRemoteConfigVersionResponse message type.</summary>
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