// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PokeballAttributes.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Settings/Master/Item/PokeballAttributes.proto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

#pragma warning disable 1591, 0612, 3021

#region Designer generated code

using POGOProtos.Enums;
using pb = Google.Protobuf;
using pbc = Google.Protobuf.Collections;
using pbr = Google.Protobuf.Reflection;
using scg = System.Collections.Generic;

namespace POGOProtos.Settings.Master.Item
{
	/// <summary>Holder for reflection information generated from POGOProtos/Settings/Master/Item/PokeballAttributes.proto</summary>
	public static partial class PokeballAttributesReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Settings/Master/Item/PokeballAttributes.proto</summary>
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
		/// Initializes static members of the <see cref="PokeballAttributesReflection"/> class.
		/// </summary>
		static PokeballAttributesReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CjhQT0dPUHJvdG9zL1NldHRpbmdzL01hc3Rlci9JdGVtL1Bva2ViYWxsQXR0",
						"cmlidXRlcy5wcm90bxIfUE9HT1Byb3Rvcy5TZXR0aW5ncy5NYXN0ZXIuSXRl",
						"bRohUE9HT1Byb3Rvcy9FbnVtcy9JdGVtRWZmZWN0LnByb3RvIpUBChJQb2tl",
						"YmFsbEF0dHJpYnV0ZXMSMQoLaXRlbV9lZmZlY3QYASABKA4yHC5QT0dPUHJv",
						"dG9zLkVudW1zLkl0ZW1FZmZlY3QSFQoNY2FwdHVyZV9tdWx0aRgCIAEoAhIc",
						"ChRjYXB0dXJlX211bHRpX2VmZmVjdBgDIAEoAhIXCg9pdGVtX2VmZmVjdF9t",
						"b2QYBCABKAJiBnByb3RvMw=="));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new[] { global::POGOProtos.Enums.ItemEffectReflection.Descriptor, },
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Settings.Master.Item.PokeballAttributes),
							global::POGOProtos.Settings.Master.Item.PokeballAttributes.Parser,
							new[] { "ItemEffect", "CaptureMulti", "CaptureMultiEffect", "ItemEffectMod" },
							null,
							null,
							null)
					}));
		}

		#endregion
	}

	#region Messages

	/// <summary>
	/// The pokeball attributes.
	/// </summary>
	public sealed partial class PokeballAttributes : pb::IMessage<PokeballAttributes>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "item_effect" field.</summary>
		public const int ItemEffectFieldNumber = 1;

		/// <summary>Field number for the "capture_multi" field.</summary>
		public const int CaptureMultiFieldNumber = 2;

		/// <summary>Field number for the "capture_multi_effect" field.</summary>
		public const int CaptureMultiEffectFieldNumber = 3;

		/// <summary>Field number for the "item_effect_mod" field.</summary>
		public const int ItemEffectModFieldNumber = 4;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<PokeballAttributes> _parser =
			new pb::MessageParser<PokeballAttributes>(() => new PokeballAttributes());

		#endregion

		#region  Fields

		/// <summary>
		/// The capture multi_.
		/// </summary>
		private float captureMulti_;

		/// <summary>
		/// The capture multi effect_.
		/// </summary>
		private float captureMultiEffect_;

		/// <summary>
		/// The item effect_.
		/// </summary>
		private ItemEffect itemEffect_ = 0;

		/// <summary>
		/// The item effect mod_.
		/// </summary>
		private float itemEffectMod_;

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="PokeballAttributes"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public PokeballAttributes()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="PokeballAttributes"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public PokeballAttributes(PokeballAttributes other) : this()
		{
			itemEffect_ = other.itemEffect_;
			captureMulti_ = other.captureMulti_;
			captureMultiEffect_ = other.captureMultiEffect_;
			itemEffectMod_ = other.itemEffectMod_;
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<PokeballAttributes> Parser
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
				return global::POGOProtos.Settings.Master.Item.PokeballAttributesReflection.Descriptor.MessageTypes[0];
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
		/// Gets or sets the item effect.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public ItemEffect ItemEffect
		{
			get
			{
				return itemEffect_;
			}

			set
			{
				itemEffect_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the capture multi.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public float CaptureMulti
		{
			get
			{
				return captureMulti_;
			}

			set
			{
				captureMulti_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the capture multi effect.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public float CaptureMultiEffect
		{
			get
			{
				return captureMultiEffect_;
			}

			set
			{
				captureMultiEffect_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the item effect mod.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public float ItemEffectMod
		{
			get
			{
				return itemEffectMod_;
			}

			set
			{
				itemEffectMod_ = value;
			}
		}

		#endregion

		#region  Interface Implementations

		/// <summary>
		/// The clone.
		/// </summary>
		/// <returns>
		/// The <see cref="PokeballAttributes"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public PokeballAttributes Clone()
		{
			return new PokeballAttributes(this);
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
		public bool Equals(PokeballAttributes other)
		{
			if (ReferenceEquals(other, null))
			{
				return false;
			}

			if (ReferenceEquals(other, this))
			{
				return true;
			}

			if (ItemEffect != other.ItemEffect)
			{
				return false;
			}

			if (CaptureMulti != other.CaptureMulti)
			{
				return false;
			}

			if (CaptureMultiEffect != other.CaptureMultiEffect)
			{
				return false;
			}

			if (ItemEffectMod != other.ItemEffectMod)
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
			if (ItemEffect != 0)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)ItemEffect);
			}

			if (CaptureMulti != 0F)
			{
				output.WriteRawTag(21);
				output.WriteFloat(CaptureMulti);
			}

			if (CaptureMultiEffect != 0F)
			{
				output.WriteRawTag(29);
				output.WriteFloat(CaptureMultiEffect);
			}

			if (ItemEffectMod != 0F)
			{
				output.WriteRawTag(37);
				output.WriteFloat(ItemEffectMod);
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
			if (ItemEffect != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeEnumSize((int)ItemEffect);
			}

			if (CaptureMulti != 0F)
			{
				size += 1 + 4;
			}

			if (CaptureMultiEffect != 0F)
			{
				size += 1 + 4;
			}

			if (ItemEffectMod != 0F)
			{
				size += 1 + 4;
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
		public void MergeFrom(PokeballAttributes other)
		{
			if (other == null)
			{
				return;
			}

			if (other.ItemEffect != 0)
			{
				ItemEffect = other.ItemEffect;
			}

			if (other.CaptureMulti != 0F)
			{
				CaptureMulti = other.CaptureMulti;
			}

			if (other.CaptureMultiEffect != 0F)
			{
				CaptureMultiEffect = other.CaptureMultiEffect;
			}

			if (other.ItemEffectMod != 0F)
			{
				ItemEffectMod = other.ItemEffectMod;
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
						itemEffect_ = (global::POGOProtos.Enums.ItemEffect)input.ReadEnum();
						break;
					}

					case 21:
					{
						CaptureMulti = input.ReadFloat();
						break;
					}

					case 29:
					{
						CaptureMultiEffect = input.ReadFloat();
						break;
					}

					case 37:
					{
						ItemEffectMod = input.ReadFloat();
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
			return Equals(other as PokeballAttributes);
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
			if (ItemEffect != 0)
			{
				hash ^= ItemEffect.GetHashCode();
			}

			if (CaptureMulti != 0F)
			{
				hash ^= CaptureMulti.GetHashCode();
			}

			if (CaptureMultiEffect != 0F)
			{
				hash ^= CaptureMultiEffect.GetHashCode();
			}

			if (ItemEffectMod != 0F)
			{
				hash ^= ItemEffectMod.GetHashCode();
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