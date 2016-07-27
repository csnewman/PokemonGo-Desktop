// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AssetDigestEntry.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Data/AssetDigestEntry.proto
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
	/// <summary>Holder for reflection information generated from POGOProtos/Data/AssetDigestEntry.proto</summary>
	public static partial class AssetDigestEntryReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Data/AssetDigestEntry.proto</summary>
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
		/// Initializes static members of the <see cref="AssetDigestEntryReflection"/> class.
		/// </summary>
		static AssetDigestEntryReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CiZQT0dPUHJvdG9zL0RhdGEvQXNzZXREaWdlc3RFbnRyeS5wcm90bxIPUE9H",
						"T1Byb3Rvcy5EYXRhIncKEEFzc2V0RGlnZXN0RW50cnkSEAoIYXNzZXRfaWQY",
						"ASABKAkSEwoLYnVuZGxlX25hbWUYAiABKAkSDwoHdmVyc2lvbhgDIAEoAxIQ",
						"CghjaGVja3N1bRgEIAEoDRIMCgRzaXplGAUgASgFEgsKA2tleRgGIAEoDGIG",
						"cHJvdG8z"));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new pbr.FileDescriptor[] { },
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Data.AssetDigestEntry),
							global::POGOProtos.Data.AssetDigestEntry.Parser,
							new[] { "AssetId", "BundleName", "Version", "Checksum", "Size", "Key" },
							null,
							null,
							null)
					}));
		}

		#endregion
	}

	#region Messages

	/// <summary>
	/// The asset digest entry.
	/// </summary>
	public sealed partial class AssetDigestEntry : pb::IMessage<AssetDigestEntry>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "asset_id" field.</summary>
		public const int AssetIdFieldNumber = 1;

		/// <summary>Field number for the "bundle_name" field.</summary>
		public const int BundleNameFieldNumber = 2;

		/// <summary>Field number for the "version" field.</summary>
		public const int VersionFieldNumber = 3;

		/// <summary>Field number for the "checksum" field.</summary>
		public const int ChecksumFieldNumber = 4;

		/// <summary>Field number for the "size" field.</summary>
		public const int SizeFieldNumber = 5;

		/// <summary>Field number for the "key" field.</summary>
		public const int KeyFieldNumber = 6;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<AssetDigestEntry> _parser =
			new pb::MessageParser<AssetDigestEntry>(() => new AssetDigestEntry());

		#endregion

		#region  Fields

		/// <summary>
		/// The asset id_.
		/// </summary>
		private string assetId_ = string.Empty;

		/// <summary>
		/// The bundle name_.
		/// </summary>
		private string bundleName_ = string.Empty;

		/// <summary>
		/// The checksum_.
		/// </summary>
		private uint checksum_;

		/// <summary>
		/// The key_.
		/// </summary>
		private pb.ByteString key_ = pb::ByteString.Empty;

		/// <summary>
		/// The size_.
		/// </summary>
		private int size_;

		/// <summary>
		/// The version_.
		/// </summary>
		private long version_;

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="AssetDigestEntry"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public AssetDigestEntry()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="AssetDigestEntry"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public AssetDigestEntry(AssetDigestEntry other) : this()
		{
			assetId_ = other.assetId_;
			bundleName_ = other.bundleName_;
			version_ = other.version_;
			checksum_ = other.checksum_;
			size_ = other.size_;
			key_ = other.key_;
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<AssetDigestEntry> Parser
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
				return global::POGOProtos.Data.AssetDigestEntryReflection.Descriptor.MessageTypes[0];
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
		/// Gets or sets the bundle name.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public string BundleName
		{
			get
			{
				return bundleName_;
			}

			set
			{
				bundleName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
			}
		}

		/// <summary>
		/// Gets or sets the version.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public long Version
		{
			get
			{
				return version_;
			}

			set
			{
				version_ = value;
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
		/// Gets or sets the key.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public pb.ByteString Key
		{
			get
			{
				return key_;
			}

			set
			{
				key_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
			}
		}

		#endregion

		#region  Interface Implementations

		/// <summary>
		/// The clone.
		/// </summary>
		/// <returns>
		/// The <see cref="AssetDigestEntry"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public AssetDigestEntry Clone()
		{
			return new AssetDigestEntry(this);
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
		public bool Equals(AssetDigestEntry other)
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

			if (BundleName != other.BundleName)
			{
				return false;
			}

			if (Version != other.Version)
			{
				return false;
			}

			if (Checksum != other.Checksum)
			{
				return false;
			}

			if (Size != other.Size)
			{
				return false;
			}

			if (Key != other.Key)
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

			if (BundleName.Length != 0)
			{
				output.WriteRawTag(18);
				output.WriteString(BundleName);
			}

			if (Version != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(Version);
			}

			if (Checksum != 0)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(Checksum);
			}

			if (Size != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(Size);
			}

			if (Key.Length != 0)
			{
				output.WriteRawTag(50);
				output.WriteBytes(Key);
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

			if (BundleName.Length != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeStringSize(BundleName);
			}

			if (Version != 0L)
			{
				size += 1 + pb::CodedOutputStream.ComputeInt64Size(Version);
			}

			if (Checksum != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Checksum);
			}

			if (Size != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeInt32Size(Size);
			}

			if (Key.Length != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeBytesSize(Key);
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
		public void MergeFrom(AssetDigestEntry other)
		{
			if (other == null)
			{
				return;
			}

			if (other.AssetId.Length != 0)
			{
				AssetId = other.AssetId;
			}

			if (other.BundleName.Length != 0)
			{
				BundleName = other.BundleName;
			}

			if (other.Version != 0L)
			{
				Version = other.Version;
			}

			if (other.Checksum != 0)
			{
				Checksum = other.Checksum;
			}

			if (other.Size != 0)
			{
				Size = other.Size;
			}

			if (other.Key.Length != 0)
			{
				Key = other.Key;
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
						BundleName = input.ReadString();
						break;
					}

					case 24:
					{
						Version = input.ReadInt64();
						break;
					}

					case 32:
					{
						Checksum = input.ReadUInt32();
						break;
					}

					case 40:
					{
						Size = input.ReadInt32();
						break;
					}

					case 50:
					{
						Key = input.ReadBytes();
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
			return Equals(other as AssetDigestEntry);
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

			if (BundleName.Length != 0)
			{
				hash ^= BundleName.GetHashCode();
			}

			if (Version != 0L)
			{
				hash ^= Version.GetHashCode();
			}

			if (Checksum != 0)
			{
				hash ^= Checksum.GetHashCode();
			}

			if (Size != 0)
			{
				hash ^= Size.GetHashCode();
			}

			if (Key.Length != 0)
			{
				hash ^= Key.GetHashCode();
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