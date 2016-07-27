// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FortModifier.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Map/Fort/FortModifier.proto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

#pragma warning disable 1591, 0612, 3021

#region Designer generated code

using POGOProtos.Inventory.Item;
using pb = Google.Protobuf;
using pbc = Google.Protobuf.Collections;
using pbr = Google.Protobuf.Reflection;
using scg = System.Collections.Generic;

namespace POGOProtos.Map.Fort
{
	/// <summary>Holder for reflection information generated from POGOProtos/Map/Fort/FortModifier.proto</summary>
	public static partial class FortModifierReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Map/Fort/FortModifier.proto</summary>
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
		/// Initializes static members of the <see cref="FortModifierReflection"/> class.
		/// </summary>
		static FortModifierReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CiZQT0dPUHJvdG9zL01hcC9Gb3J0L0ZvcnRNb2RpZmllci5wcm90bxITUE9H",
						"T1Byb3Rvcy5NYXAuRm9ydBomUE9HT1Byb3Rvcy9JbnZlbnRvcnkvSXRlbS9J",
						"dGVtSWQucHJvdG8ihQEKDEZvcnRNb2RpZmllchIyCgdpdGVtX2lkGAEgASgO",
						"MiEuUE9HT1Byb3Rvcy5JbnZlbnRvcnkuSXRlbS5JdGVtSWQSHwoXZXhwaXJh",
						"dGlvbl90aW1lc3RhbXBfbXMYAiABKAMSIAoYZGVwbG95ZXJfcGxheWVyX2Nv",
						"ZGVuYW1lGAMgASgJYgZwcm90bzM="));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new[] { global::POGOProtos.Inventory.Item.ItemIdReflection.Descriptor, },
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Map.Fort.FortModifier),
							global::POGOProtos.Map.Fort.FortModifier.Parser,
							new[] { "ItemId", "ExpirationTimestampMs", "DeployerPlayerCodename" },
							null,
							null,
							null)
					}));
		}

		#endregion
	}

	#region Messages

	/// <summary>
	/// The fort modifier.
	/// </summary>
	public sealed partial class FortModifier : pb::IMessage<FortModifier>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "item_id" field.</summary>
		public const int ItemIdFieldNumber = 1;

		/// <summary>Field number for the "expiration_timestamp_ms" field.</summary>
		public const int ExpirationTimestampMsFieldNumber = 2;

		/// <summary>Field number for the "deployer_player_codename" field.</summary>
		public const int DeployerPlayerCodenameFieldNumber = 3;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<FortModifier> _parser =
			new pb::MessageParser<FortModifier>(() => new FortModifier());

		#endregion

		#region  Fields

		/// <summary>
		/// The deployer player codename_.
		/// </summary>
		private string deployerPlayerCodename_ = string.Empty;

		/// <summary>
		/// The expiration timestamp ms_.
		/// </summary>
		private long expirationTimestampMs_;

		/// <summary>
		/// The item id_.
		/// </summary>
		private ItemId itemId_ = 0;

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="FortModifier"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public FortModifier()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="FortModifier"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public FortModifier(FortModifier other) : this()
		{
			itemId_ = other.itemId_;
			expirationTimestampMs_ = other.expirationTimestampMs_;
			deployerPlayerCodename_ = other.deployerPlayerCodename_;
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<FortModifier> Parser
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
				return global::POGOProtos.Map.Fort.FortModifierReflection.Descriptor.MessageTypes[0];
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
		/// Gets or sets the item id.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public ItemId ItemId
		{
			get
			{
				return itemId_;
			}

			set
			{
				itemId_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the expiration timestamp ms.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public long ExpirationTimestampMs
		{
			get
			{
				return expirationTimestampMs_;
			}

			set
			{
				expirationTimestampMs_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the deployer player codename.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public string DeployerPlayerCodename
		{
			get
			{
				return deployerPlayerCodename_;
			}

			set
			{
				deployerPlayerCodename_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
			}
		}

		#endregion

		#region  Interface Implementations

		/// <summary>
		/// The clone.
		/// </summary>
		/// <returns>
		/// The <see cref="FortModifier"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public FortModifier Clone()
		{
			return new FortModifier(this);
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
		public bool Equals(FortModifier other)
		{
			if (ReferenceEquals(other, null))
			{
				return false;
			}

			if (ReferenceEquals(other, this))
			{
				return true;
			}

			if (ItemId != other.ItemId)
			{
				return false;
			}

			if (ExpirationTimestampMs != other.ExpirationTimestampMs)
			{
				return false;
			}

			if (DeployerPlayerCodename != other.DeployerPlayerCodename)
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
			if (ItemId != 0)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)ItemId);
			}

			if (ExpirationTimestampMs != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(ExpirationTimestampMs);
			}

			if (DeployerPlayerCodename.Length != 0)
			{
				output.WriteRawTag(26);
				output.WriteString(DeployerPlayerCodename);
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
			if (ItemId != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeEnumSize((int)ItemId);
			}

			if (ExpirationTimestampMs != 0L)
			{
				size += 1 + pb::CodedOutputStream.ComputeInt64Size(ExpirationTimestampMs);
			}

			if (DeployerPlayerCodename.Length != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeStringSize(DeployerPlayerCodename);
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
		public void MergeFrom(FortModifier other)
		{
			if (other == null)
			{
				return;
			}

			if (other.ItemId != 0)
			{
				ItemId = other.ItemId;
			}

			if (other.ExpirationTimestampMs != 0L)
			{
				ExpirationTimestampMs = other.ExpirationTimestampMs;
			}

			if (other.DeployerPlayerCodename.Length != 0)
			{
				DeployerPlayerCodename = other.DeployerPlayerCodename;
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
						itemId_ = (global::POGOProtos.Inventory.Item.ItemId)input.ReadEnum();
						break;
					}

					case 16:
					{
						ExpirationTimestampMs = input.ReadInt64();
						break;
					}

					case 26:
					{
						DeployerPlayerCodename = input.ReadString();
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
			return Equals(other as FortModifier);
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
			if (ItemId != 0)
			{
				hash ^= ItemId.GetHashCode();
			}

			if (ExpirationTimestampMs != 0L)
			{
				hash ^= ExpirationTimestampMs.GetHashCode();
			}

			if (DeployerPlayerCodename.Length != 0)
			{
				hash ^= DeployerPlayerCodename.GetHashCode();
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