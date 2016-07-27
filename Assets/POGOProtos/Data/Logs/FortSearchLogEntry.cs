// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FortSearchLogEntry.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Data/Logs/FortSearchLogEntry.proto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

#pragma warning disable 1591, 0612, 3021

#region Designer generated code

using POGOProtos.Inventory.Item;
using pb = Google.Protobuf;
using pbc = Google.Protobuf.Collections;
using pbr = Google.Protobuf.Reflection;
using scg = System.Collections.Generic;

namespace POGOProtos.Data.Logs
{
	/// <summary>Holder for reflection information generated from POGOProtos/Data/Logs/FortSearchLogEntry.proto</summary>
	public static partial class FortSearchLogEntryReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Data/Logs/FortSearchLogEntry.proto</summary>
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
		/// Initializes static members of the <see cref="FortSearchLogEntryReflection"/> class.
		/// </summary>
		static FortSearchLogEntryReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"Ci1QT0dPUHJvdG9zL0RhdGEvTG9ncy9Gb3J0U2VhcmNoTG9nRW50cnkucHJv",
						"dG8SFFBPR09Qcm90b3MuRGF0YS5Mb2dzGihQT0dPUHJvdG9zL0ludmVudG9y",
						"eS9JdGVtL0l0ZW1EYXRhLnByb3RvGiBQT0dPUHJvdG9zL0VudW1zL1Bva2Vt",
						"b25JZC5wcm90byLKAQoSRm9ydFNlYXJjaExvZ0VudHJ5Ej8KBnJlc3VsdBgB",
						"IAEoDjIvLlBPR09Qcm90b3MuRGF0YS5Mb2dzLkZvcnRTZWFyY2hMb2dFbnRy",
						"eS5SZXN1bHQSDwoHZm9ydF9pZBgCIAEoCRIyCgVpdGVtcxgDIAMoCzIjLlBP",
						"R09Qcm90b3MuSW52ZW50b3J5Lkl0ZW0uSXRlbURhdGESDAoEZWdncxgEIAEo",
						"BSIgCgZSZXN1bHQSCQoFVU5TRVQQABILCgdTVUNDRVNTEAFiBnByb3RvMw=="));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new[]
				{
					global::POGOProtos.Inventory.Item.ItemDataReflection.Descriptor,
					global::POGOProtos.Enums.PokemonIdReflection.Descriptor,
				},
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Data.Logs.FortSearchLogEntry),
							global::POGOProtos.Data.Logs.FortSearchLogEntry.Parser,
							new[] { "Result", "FortId", "Items", "Eggs" },
							null,
							new[] { typeof(global::POGOProtos.Data.Logs.FortSearchLogEntry.Types.Result) },
							null)
					}));
		}

		#endregion
	}

	#region Messages

	/// <summary>
	/// The fort search log entry.
	/// </summary>
	public sealed partial class FortSearchLogEntry : pb::IMessage<FortSearchLogEntry>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "result" field.</summary>
		public const int ResultFieldNumber = 1;

		/// <summary>Field number for the "fort_id" field.</summary>
		public const int FortIdFieldNumber = 2;

		/// <summary>Field number for the "items" field.</summary>
		public const int ItemsFieldNumber = 3;

		/// <summary>Field number for the "eggs" field.</summary>
		public const int EggsFieldNumber = 4;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<FortSearchLogEntry> _parser =
			new pb::MessageParser<FortSearchLogEntry>(() => new FortSearchLogEntry());

		/// <summary>
		/// The _repeated_items_codec.
		/// </summary>
		private static readonly pb.FieldCodec<ItemData> _repeated_items_codec = pb::FieldCodec.ForMessage(
			26,
			global::POGOProtos.Inventory.Item.ItemData.Parser);

		#endregion

		#region  Fields

		/// <summary>
		/// The eggs_.
		/// </summary>
		private int eggs_;

		/// <summary>
		/// The fort id_.
		/// </summary>
		private string fortId_ = string.Empty;

		/// <summary>
		/// The items_.
		/// </summary>
		private readonly pbc.RepeatedField<ItemData> items_ = new pbc::RepeatedField<ItemData>();

		/// <summary>
		/// The result_.
		/// </summary>
		private Types.Result result_ = 0;

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="FortSearchLogEntry"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public FortSearchLogEntry()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="FortSearchLogEntry"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public FortSearchLogEntry(FortSearchLogEntry other) : this()
		{
			result_ = other.result_;
			fortId_ = other.fortId_;
			items_ = other.items_.Clone();
			eggs_ = other.eggs_;
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<FortSearchLogEntry> Parser
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
				return global::POGOProtos.Data.Logs.FortSearchLogEntryReflection.Descriptor.MessageTypes[0];
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
		/// Gets or sets the fort id.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public string FortId
		{
			get
			{
				return fortId_;
			}

			set
			{
				fortId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
			}
		}

		/// <summary>
		/// Gets the items.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public pbc.RepeatedField<ItemData> Items
		{
			get
			{
				return items_;
			}
		}

		/// <summary>
		/// Gets or sets the eggs.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public int Eggs
		{
			get
			{
				return eggs_;
			}

			set
			{
				eggs_ = value;
			}
		}

		#endregion

		#region  Interface Implementations

		/// <summary>
		/// The clone.
		/// </summary>
		/// <returns>
		/// The <see cref="FortSearchLogEntry"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public FortSearchLogEntry Clone()
		{
			return new FortSearchLogEntry(this);
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
		public bool Equals(FortSearchLogEntry other)
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

			if (FortId != other.FortId)
			{
				return false;
			}

			if (!items_.Equals(other.items_))
			{
				return false;
			}

			if (Eggs != other.Eggs)
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

			if (FortId.Length != 0)
			{
				output.WriteRawTag(18);
				output.WriteString(FortId);
			}

			items_.WriteTo(output, _repeated_items_codec);
			if (Eggs != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(Eggs);
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

			if (FortId.Length != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeStringSize(FortId);
			}

			size += items_.CalculateSize(_repeated_items_codec);
			if (Eggs != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeInt32Size(Eggs);
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
		public void MergeFrom(FortSearchLogEntry other)
		{
			if (other == null)
			{
				return;
			}

			if (other.Result != 0)
			{
				Result = other.Result;
			}

			if (other.FortId.Length != 0)
			{
				FortId = other.FortId;
			}

			items_.Add(other.items_);
			if (other.Eggs != 0)
			{
				Eggs = other.Eggs;
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
						result_ = (global::POGOProtos.Data.Logs.FortSearchLogEntry.Types.Result)input.ReadEnum();
						break;
					}

					case 18:
					{
						FortId = input.ReadString();
						break;
					}

					case 26:
					{
						items_.AddEntriesFrom(input, _repeated_items_codec);
						break;
					}

					case 32:
					{
						Eggs = input.ReadInt32();
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
			return Equals(other as FortSearchLogEntry);
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

			if (FortId.Length != 0)
			{
				hash ^= FortId.GetHashCode();
			}

			hash ^= items_.GetHashCode();
			if (Eggs != 0)
			{
				hash ^= Eggs.GetHashCode();
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

		/// <summary>Container for nested types declared in the FortSearchLogEntry message type.</summary>
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