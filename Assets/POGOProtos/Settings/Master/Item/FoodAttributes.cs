// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FoodAttributes.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Settings/Master/Item/FoodAttributes.proto
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
	/// <summary>Holder for reflection information generated from POGOProtos/Settings/Master/Item/FoodAttributes.proto</summary>
	public static partial class FoodAttributesReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Settings/Master/Item/FoodAttributes.proto</summary>
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
		/// Initializes static members of the <see cref="FoodAttributesReflection"/> class.
		/// </summary>
		static FoodAttributesReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CjRQT0dPUHJvdG9zL1NldHRpbmdzL01hc3Rlci9JdGVtL0Zvb2RBdHRyaWJ1",
						"dGVzLnByb3RvEh9QT0dPUHJvdG9zLlNldHRpbmdzLk1hc3Rlci5JdGVtGiFQ",
						"T0dPUHJvdG9zL0VudW1zL0l0ZW1FZmZlY3QucHJvdG8ieAoORm9vZEF0dHJp",
						"YnV0ZXMSMQoLaXRlbV9lZmZlY3QYASADKA4yHC5QT0dPUHJvdG9zLkVudW1z",
						"Lkl0ZW1FZmZlY3QSGwoTaXRlbV9lZmZlY3RfcGVyY2VudBgCIAMoAhIWCg5n",
						"cm93dGhfcGVyY2VudBgDIAEoAmIGcHJvdG8z"));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new[] { global::POGOProtos.Enums.ItemEffectReflection.Descriptor, },
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Settings.Master.Item.FoodAttributes),
							global::POGOProtos.Settings.Master.Item.FoodAttributes.Parser,
							new[] { "ItemEffect", "ItemEffectPercent", "GrowthPercent" },
							null,
							null,
							null)
					}));
		}

		#endregion
	}

	#region Messages

	/// <summary>
	/// The food attributes.
	/// </summary>
	public sealed partial class FoodAttributes : pb::IMessage<FoodAttributes>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "item_effect" field.</summary>
		public const int ItemEffectFieldNumber = 1;

		/// <summary>Field number for the "item_effect_percent" field.</summary>
		public const int ItemEffectPercentFieldNumber = 2;

		/// <summary>Field number for the "growth_percent" field.</summary>
		public const int GrowthPercentFieldNumber = 3;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<FoodAttributes> _parser =
			new pb::MessageParser<FoodAttributes>(() => new FoodAttributes());

		/// <summary>
		/// The _repeated_item effect_codec.
		/// </summary>
		private static readonly pb.FieldCodec<ItemEffect> _repeated_itemEffect_codec = pb::FieldCodec.ForEnum(
			10,
			x => (int)x,
			x => (global::POGOProtos.Enums.ItemEffect)x);

		/// <summary>
		/// The _repeated_item effect percent_codec.
		/// </summary>
		private static readonly pb.FieldCodec<float> _repeated_itemEffectPercent_codec = pb::FieldCodec.ForFloat(18);

		#endregion

		#region  Fields

		/// <summary>
		/// The growth percent_.
		/// </summary>
		private float growthPercent_;

		/// <summary>
		/// The item effect_.
		/// </summary>
		private readonly pbc.RepeatedField<ItemEffect> itemEffect_ = new pbc::RepeatedField<ItemEffect>();

		/// <summary>
		/// The item effect percent_.
		/// </summary>
		private readonly pbc.RepeatedField<float> itemEffectPercent_ = new pbc::RepeatedField<float>();

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="FoodAttributes"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public FoodAttributes()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="FoodAttributes"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public FoodAttributes(FoodAttributes other) : this()
		{
			itemEffect_ = other.itemEffect_.Clone();
			itemEffectPercent_ = other.itemEffectPercent_.Clone();
			growthPercent_ = other.growthPercent_;
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<FoodAttributes> Parser
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
				return global::POGOProtos.Settings.Master.Item.FoodAttributesReflection.Descriptor.MessageTypes[0];
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
		/// Gets the item effect.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public pbc.RepeatedField<ItemEffect> ItemEffect
		{
			get
			{
				return itemEffect_;
			}
		}

		/// <summary>
		/// Gets the item effect percent.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public pbc.RepeatedField<float> ItemEffectPercent
		{
			get
			{
				return itemEffectPercent_;
			}
		}

		/// <summary>
		/// Gets or sets the growth percent.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public float GrowthPercent
		{
			get
			{
				return growthPercent_;
			}

			set
			{
				growthPercent_ = value;
			}
		}

		#endregion

		#region  Interface Implementations

		/// <summary>
		/// The clone.
		/// </summary>
		/// <returns>
		/// The <see cref="FoodAttributes"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public FoodAttributes Clone()
		{
			return new FoodAttributes(this);
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
		public bool Equals(FoodAttributes other)
		{
			if (ReferenceEquals(other, null))
			{
				return false;
			}

			if (ReferenceEquals(other, this))
			{
				return true;
			}

			if (!itemEffect_.Equals(other.itemEffect_))
			{
				return false;
			}

			if (!itemEffectPercent_.Equals(other.itemEffectPercent_))
			{
				return false;
			}

			if (GrowthPercent != other.GrowthPercent)
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
			itemEffect_.WriteTo(output, _repeated_itemEffect_codec);
			itemEffectPercent_.WriteTo(output, _repeated_itemEffectPercent_codec);
			if (GrowthPercent != 0F)
			{
				output.WriteRawTag(29);
				output.WriteFloat(GrowthPercent);
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
			size += itemEffect_.CalculateSize(_repeated_itemEffect_codec);
			size += itemEffectPercent_.CalculateSize(_repeated_itemEffectPercent_codec);
			if (GrowthPercent != 0F)
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
		public void MergeFrom(FoodAttributes other)
		{
			if (other == null)
			{
				return;
			}

			itemEffect_.Add(other.itemEffect_);
			itemEffectPercent_.Add(other.itemEffectPercent_);
			if (other.GrowthPercent != 0F)
			{
				GrowthPercent = other.GrowthPercent;
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
					case 8:
					{
						itemEffect_.AddEntriesFrom(input, _repeated_itemEffect_codec);
						break;
					}

					case 18:
					case 21:
					{
						itemEffectPercent_.AddEntriesFrom(input, _repeated_itemEffectPercent_codec);
						break;
					}

					case 29:
					{
						GrowthPercent = input.ReadFloat();
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
			return Equals(other as FoodAttributes);
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
			hash ^= itemEffect_.GetHashCode();
			hash ^= itemEffectPercent_.GetHashCode();
			if (GrowthPercent != 0F)
			{
				hash ^= GrowthPercent.GetHashCode();
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