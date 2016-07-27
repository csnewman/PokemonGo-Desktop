// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DownloadUrlEntry.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Data/DownloadUrlEntry.proto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

#pragma warning disable 1591, 0612, 3021

#region Designer generated code

using pb = Google.Protobuf;
using pbc = Google.Protobuf.Collections;
using pbr = Google.Protobuf.Reflection;
using scg = System.Collections.Generic;

namespace POGOProtos.Data
{
	/// <summary>Holder for reflection information generated from POGOProtos/Data/DownloadUrlEntry.proto</summary>
	public static partial class DownloadUrlEntryReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Data/DownloadUrlEntry.proto</summary>
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
		/// Initializes static members of the <see cref="DownloadUrlEntryReflection"/> class.
		/// </summary>
		static DownloadUrlEntryReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CiZQT0dPUHJvdG9zL0RhdGEvRG93bmxvYWRVcmxFbnRyeS5wcm90bxIPUE9H",
						"T1Byb3Rvcy5EYXRhIlEKEERvd25sb2FkVXJsRW50cnkSEAoIYXNzZXRfaWQY",
						"ASABKAkSCwoDdXJsGAIgASgJEgwKBHNpemUYAyABKAUSEAoIY2hlY2tzdW0Y",
						"BCABKA1iBnByb3RvMw=="));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new pbr.FileDescriptor[] { },
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Data.DownloadUrlEntry),
							global::POGOProtos.Data.DownloadUrlEntry.Parser,
							new[] { "AssetId", "Url", "Size", "Checksum" },
							null,
							null,
							null)
					}));
		}

		#endregion
	}

	#region Messages

	/// <summary>
	/// The download url entry.
	/// </summary>
	public sealed partial class DownloadUrlEntry : pb::IMessage<DownloadUrlEntry>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "asset_id" field.</summary>
		public const int AssetIdFieldNumber = 1;

		/// <summary>Field number for the "url" field.</summary>
		public const int UrlFieldNumber = 2;

		/// <summary>Field number for the "size" field.</summary>
		public const int SizeFieldNumber = 3;

		/// <summary>Field number for the "checksum" field.</summary>
		public const int ChecksumFieldNumber = 4;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<DownloadUrlEntry> _parser =
			new pb::MessageParser<DownloadUrlEntry>(() => new DownloadUrlEntry());

		#endregion

		#region  Fields

		/// <summary>
		/// The asset id_.
		/// </summary>
		private string assetId_ = string.Empty;

		/// <summary>
		/// The checksum_.
		/// </summary>
		private uint checksum_;

		/// <summary>
		/// The size_.
		/// </summary>
		private int size_;

		/// <summary>
		/// The url_.
		/// </summary>
		private string url_ = string.Empty;

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="DownloadUrlEntry"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public DownloadUrlEntry()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="DownloadUrlEntry"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public DownloadUrlEntry(DownloadUrlEntry other) : this()
		{
			assetId_ = other.assetId_;
			url_ = other.url_;
			size_ = other.size_;
			checksum_ = other.checksum_;
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<DownloadUrlEntry> Parser
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
				return global::POGOProtos.Data.DownloadUrlEntryReflection.Descriptor.MessageTypes[0];
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
		/// Gets or sets the asset id.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public string AssetId
		{
			get
			{
				return assetId_;
			}

			set
			{
				assetId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
			}
		}

		/// <summary>
		/// Gets or sets the url.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public string Url
		{
			get
			{
				return url_;
			}

			set
			{
				url_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
			}
		}

		/// <summary>
		/// Gets or sets the size.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public int Size
		{
			get
			{
				return size_;
			}

			set
			{
				size_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the checksum.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public uint Checksum
		{
			get
			{
				return checksum_;
			}

			set
			{
				checksum_ = value;
			}
		}

		#endregion

		#region  Interface Implementations

		/// <summary>
		/// The clone.
		/// </summary>
		/// <returns>
		/// The <see cref="DownloadUrlEntry"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public DownloadUrlEntry Clone()
		{
			return new DownloadUrlEntry(this);
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
		public bool Equals(DownloadUrlEntry other)
		{
			if (ReferenceEquals(other, null))
			{
				return false;
			}

			if (ReferenceEquals(other, this))
			{
				return true;
			}

			if (AssetId != other.AssetId)
			{
				return false;
			}

			if (Url != other.Url)
			{
				return false;
			}

			if (Size != other.Size)
			{
				return false;
			}

			if (Checksum != other.Checksum)
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
			if (AssetId.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(AssetId);
			}

			if (Url.Length != 0)
			{
				output.WriteRawTag(18);
				output.WriteString(Url);
			}

			if (Size != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(Size);
			}

			if (Checksum != 0)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(Checksum);
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
			if (AssetId.Length != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeStringSize(AssetId);
			}

			if (Url.Length != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeStringSize(Url);
			}

			if (Size != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeInt32Size(Size);
			}

			if (Checksum != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Checksum);
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
		public void MergeFrom(DownloadUrlEntry other)
		{
			if (other == null)
			{
				return;
			}

			if (other.AssetId.Length != 0)
			{
				AssetId = other.AssetId;
			}

			if (other.Url.Length != 0)
			{
				Url = other.Url;
			}

			if (other.Size != 0)
			{
				Size = other.Size;
			}

			if (other.Checksum != 0)
			{
				Checksum = other.Checksum;
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
						AssetId = input.ReadString();
						break;
					}

					case 18:
					{
						Url = input.ReadString();
						break;
					}

					case 24:
					{
						Size = input.ReadInt32();
						break;
					}

					case 32:
					{
						Checksum = input.ReadUInt32();
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
			return Equals(other as DownloadUrlEntry);
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
			if (AssetId.Length != 0)
			{
				hash ^= AssetId.GetHashCode();
			}

			if (Url.Length != 0)
			{
				hash ^= Url.GetHashCode();
			}

			if (Size != 0)
			{
				hash ^= Size.GetHashCode();
			}

			if (Checksum != 0)
			{
				hash ^= Checksum.GetHashCode();
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