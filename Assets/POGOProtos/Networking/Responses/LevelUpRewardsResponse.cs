// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LevelUpRewardsResponse.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Networking/Responses/LevelUpRewardsResponse.proto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

#pragma warning disable 1591, 0612, 3021

#region Designer generated code

using POGOProtos.Inventory.Item;
using pb = Google.Protobuf;
using pbc = Google.Protobuf.Collections;
using pbr = Google.Protobuf.Reflection;
using scg = System.Collections.Generic;

namespace POGOProtos.Networking.Responses
{
	/// <summary>Holder for reflection information generated from POGOProtos/Networking/Responses/LevelUpRewardsResponse.proto</summary>
	public static partial class LevelUpRewardsResponseReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Networking/Responses/LevelUpRewardsResponse.proto</summary>
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
		/// Initializes static members of the <see cref="LevelUpRewardsResponseReflection"/> class.
		/// </summary>
		static LevelUpRewardsResponseReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CjxQT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVzcG9uc2VzL0xldmVsVXBSZXdh",
						"cmRzUmVzcG9uc2UucHJvdG8SH1BPR09Qcm90b3MuTmV0d29ya2luZy5SZXNw",
						"b25zZXMaJlBPR09Qcm90b3MvSW52ZW50b3J5L0l0ZW0vSXRlbUlkLnByb3Rv",
						"GilQT0dPUHJvdG9zL0ludmVudG9yeS9JdGVtL0l0ZW1Bd2FyZC5wcm90byKX",
						"AgoWTGV2ZWxVcFJld2FyZHNSZXNwb25zZRJOCgZyZXN1bHQYASABKA4yPi5Q",
						"T0dPUHJvdG9zLk5ldHdvcmtpbmcuUmVzcG9uc2VzLkxldmVsVXBSZXdhcmRz",
						"UmVzcG9uc2UuUmVzdWx0EjsKDWl0ZW1zX2F3YXJkZWQYAiADKAsyJC5QT0dP",
						"UHJvdG9zLkludmVudG9yeS5JdGVtLkl0ZW1Bd2FyZBI5Cg5pdGVtc191bmxv",
						"Y2tlZBgEIAMoDjIhLlBPR09Qcm90b3MuSW52ZW50b3J5Lkl0ZW0uSXRlbUlk",
						"IjUKBlJlc3VsdBIJCgVVTlNFVBAAEgsKB1NVQ0NFU1MQARITCg9BV0FSREVE",
						"X0FMUkVBRFkQAmIGcHJvdG8z"));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new[]
				{
					global::POGOProtos.Inventory.Item.ItemIdReflection.Descriptor,
					global::POGOProtos.Inventory.Item.ItemAwardReflection.Descriptor,
				},
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Networking.Responses.LevelUpRewardsResponse),
							global::POGOProtos.Networking.Responses.LevelUpRewardsResponse.Parser,
							new[] { "Result", "ItemsAwarded", "ItemsUnlocked" },
							null,
							new[] { typeof(global::POGOProtos.Networking.Responses.LevelUpRewardsResponse.Types.Result) },
							null)
					}));
		}

		#endregion
	}

	#region Messages

	/// <summary>
	/// The level up rewards response.
	/// </summary>
	public sealed partial class LevelUpRewardsResponse : pb::IMessage<LevelUpRewardsResponse>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "result" field.</summary>
		public const int ResultFieldNumber = 1;

		/// <summary>Field number for the "items_awarded" field.</summary>
		public const int ItemsAwardedFieldNumber = 2;

		/// <summary>Field number for the "items_unlocked" field.</summary>
		public const int ItemsUnlockedFieldNumber = 4;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<LevelUpRewardsResponse> _parser =
			new pb::MessageParser<LevelUpRewardsResponse>(() => new LevelUpRewardsResponse());

		/// <summary>
		/// The _repeated_items awarded_codec.
		/// </summary>
		private static readonly pb.FieldCodec<ItemAward> _repeated_itemsAwarded_codec = pb::FieldCodec.ForMessage(
			18,
			global::POGOProtos.Inventory.Item.ItemAward.Parser);

		/// <summary>
		/// The _repeated_items unlocked_codec.
		/// </summary>
		private static readonly pb.FieldCodec<ItemId> _repeated_itemsUnlocked_codec = pb::FieldCodec.ForEnum(
			34,
			x => (int)x,
			x => (global::POGOProtos.Inventory.Item.ItemId)x);

		#endregion

		#region  Fields

		/// <summary>
		/// The items awarded_.
		/// </summary>
		private readonly pbc.RepeatedField<ItemAward> itemsAwarded_ = new pbc::RepeatedField<ItemAward>();

		/// <summary>
		/// The items unlocked_.
		/// </summary>
		private readonly pbc.RepeatedField<ItemId> itemsUnlocked_ = new pbc::RepeatedField<ItemId>();

		/// <summary>
		/// The result_.
		/// </summary>
		private Types.Result result_ = 0;

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="LevelUpRewardsResponse"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public LevelUpRewardsResponse()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="LevelUpRewardsResponse"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public LevelUpRewardsResponse(LevelUpRewardsResponse other) : this()
		{
			result_ = other.result_;
			itemsAwarded_ = other.itemsAwarded_.Clone();
			itemsUnlocked_ = other.itemsUnlocked_.Clone();
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<LevelUpRewardsResponse> Parser
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
				return global::POGOProtos.Networking.Responses.LevelUpRewardsResponseReflection.Descriptor.MessageTypes[0];
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
		/// Gets the items awarded.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public pbc.RepeatedField<ItemAward> ItemsAwarded
		{
			get
			{
				return itemsAwarded_;
			}
		}

		/// <summary>
		/// Gets the items unlocked.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public pbc.RepeatedField<ItemId> ItemsUnlocked
		{
			get
			{
				return itemsUnlocked_;
			}
		}

		#endregion

		#region  Interface Implementations

		/// <summary>
		/// The clone.
		/// </summary>
		/// <returns>
		/// The <see cref="LevelUpRewardsResponse"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public LevelUpRewardsResponse Clone()
		{
			return new LevelUpRewardsResponse(this);
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
		public bool Equals(LevelUpRewardsResponse other)
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

			if (!itemsAwarded_.Equals(other.itemsAwarded_))
			{
				return false;
			}

			if (!itemsUnlocked_.Equals(other.itemsUnlocked_))
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

			itemsAwarded_.WriteTo(output, _repeated_itemsAwarded_codec);
			itemsUnlocked_.WriteTo(output, _repeated_itemsUnlocked_codec);
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

			size += itemsAwarded_.CalculateSize(_repeated_itemsAwarded_codec);
			size += itemsUnlocked_.CalculateSize(_repeated_itemsUnlocked_codec);
			return size;
		}

		/// <summary>
		/// The merge from.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public void MergeFrom(LevelUpRewardsResponse other)
		{
			if (other == null)
			{
				return;
			}

			if (other.Result != 0)
			{
				Result = other.Result;
			}

			itemsAwarded_.Add(other.itemsAwarded_);
			itemsUnlocked_.Add(other.itemsUnlocked_);
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
						result_ = (global::POGOProtos.Networking.Responses.LevelUpRewardsResponse.Types.Result)input.ReadEnum();
						break;
					}

					case 18:
					{
						itemsAwarded_.AddEntriesFrom(input, _repeated_itemsAwarded_codec);
						break;
					}

					case 34:
					case 32:
					{
						itemsUnlocked_.AddEntriesFrom(input, _repeated_itemsUnlocked_codec);
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
			return Equals(other as LevelUpRewardsResponse);
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

			hash ^= itemsAwarded_.GetHashCode();
			hash ^= itemsUnlocked_.GetHashCode();
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

		/// <summary>Container for nested types declared in the LevelUpRewardsResponse message type.</summary>
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

				/// <summary>
				/// The awarded already.
				/// </summary>
				[pbr::OriginalName("AWARDED_ALREADY")] AwardedAlready = 2,
			}

			#endregion
		}

		#endregion
	}

	#endregion
}

#endregion Designer generated code