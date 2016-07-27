// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CollectDailyDefenderBonusResponse.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Networking/Responses/CollectDailyDefenderBonusResponse.proto
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
	/// <summary>Holder for reflection information generated from POGOProtos/Networking/Responses/CollectDailyDefenderBonusResponse.proto</summary>
	public static partial class CollectDailyDefenderBonusResponseReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Networking/Responses/CollectDailyDefenderBonusResponse.proto</summary>
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
		/// Initializes static members of the <see cref="CollectDailyDefenderBonusResponseReflection"/> class.
		/// </summary>
		static CollectDailyDefenderBonusResponseReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CkdQT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVzcG9uc2VzL0NvbGxlY3REYWls",
						"eURlZmVuZGVyQm9udXNSZXNwb25zZS5wcm90bxIfUE9HT1Byb3Rvcy5OZXR3",
						"b3JraW5nLlJlc3BvbnNlcyKXAgohQ29sbGVjdERhaWx5RGVmZW5kZXJCb251",
						"c1Jlc3BvbnNlElkKBnJlc3VsdBgBIAEoDjJJLlBPR09Qcm90b3MuTmV0d29y",
						"a2luZy5SZXNwb25zZXMuQ29sbGVjdERhaWx5RGVmZW5kZXJCb251c1Jlc3Bv",
						"bnNlLlJlc3VsdBIVCg1jdXJyZW5jeV90eXBlGAIgAygJEhgKEGN1cnJlbmN5",
						"X2F3YXJkZWQYAyADKAUSFwoPZGVmZW5kZXJzX2NvdW50GAQgASgFIk0KBlJl",
						"c3VsdBIJCgVVTlNFVBAAEgsKB1NVQ0NFU1MQARILCgdGQUlMVVJFEAISDAoI",
						"VE9PX1NPT04QAxIQCgxOT19ERUZFTkRFUlMQBGIGcHJvdG8z"));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new pbr.FileDescriptor[] { },
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Networking.Responses.CollectDailyDefenderBonusResponse),
							global::POGOProtos.Networking.Responses.CollectDailyDefenderBonusResponse.Parser,
							new[] { "Result", "CurrencyType", "CurrencyAwarded", "DefendersCount" },
							null,
							new[] { typeof(global::POGOProtos.Networking.Responses.CollectDailyDefenderBonusResponse.Types.Result) },
							null)
					}));
		}

		#endregion
	}

	#region Messages

	/// <summary>
	/// The collect daily defender bonus response.
	/// </summary>
	public sealed partial class CollectDailyDefenderBonusResponse : pb::IMessage<CollectDailyDefenderBonusResponse>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "result" field.</summary>
		public const int ResultFieldNumber = 1;

		/// <summary>Field number for the "currency_type" field.</summary>
		public const int CurrencyTypeFieldNumber = 2;

		/// <summary>Field number for the "currency_awarded" field.</summary>
		public const int CurrencyAwardedFieldNumber = 3;

		/// <summary>Field number for the "defenders_count" field.</summary>
		public const int DefendersCountFieldNumber = 4;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<CollectDailyDefenderBonusResponse> _parser =
			new pb::MessageParser<CollectDailyDefenderBonusResponse>(() => new CollectDailyDefenderBonusResponse());

		/// <summary>
		/// The _repeated_currency type_codec.
		/// </summary>
		private static readonly pb.FieldCodec<string> _repeated_currencyType_codec = pb::FieldCodec.ForString(18);

		/// <summary>
		/// The _repeated_currency awarded_codec.
		/// </summary>
		private static readonly pb.FieldCodec<int> _repeated_currencyAwarded_codec = pb::FieldCodec.ForInt32(26);

		#endregion

		#region  Fields

		/// <summary>
		/// The currency awarded_.
		/// </summary>
		private readonly pbc.RepeatedField<int> currencyAwarded_ = new pbc::RepeatedField<int>();

		/// <summary>
		/// The currency type_.
		/// </summary>
		private readonly pbc.RepeatedField<string> currencyType_ = new pbc::RepeatedField<string>();

		/// <summary>
		/// The defenders count_.
		/// </summary>
		private int defendersCount_;

		/// <summary>
		/// The result_.
		/// </summary>
		private Types.Result result_ = 0;

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="CollectDailyDefenderBonusResponse"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public CollectDailyDefenderBonusResponse()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="CollectDailyDefenderBonusResponse"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public CollectDailyDefenderBonusResponse(CollectDailyDefenderBonusResponse other) : this()
		{
			result_ = other.result_;
			currencyType_ = other.currencyType_.Clone();
			currencyAwarded_ = other.currencyAwarded_.Clone();
			defendersCount_ = other.defendersCount_;
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<CollectDailyDefenderBonusResponse> Parser
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
					global::POGOProtos.Networking.Responses.CollectDailyDefenderBonusResponseReflection.Descriptor.MessageTypes[0];
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
		/// Gets the currency type.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public pbc.RepeatedField<string> CurrencyType
		{
			get
			{
				return currencyType_;
			}
		}

		/// <summary>
		/// Gets the currency awarded.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public pbc.RepeatedField<int> CurrencyAwarded
		{
			get
			{
				return currencyAwarded_;
			}
		}

		/// <summary>
		/// Gets or sets the defenders count.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public int DefendersCount
		{
			get
			{
				return defendersCount_;
			}

			set
			{
				defendersCount_ = value;
			}
		}

		#endregion

		#region  Interface Implementations

		/// <summary>
		/// The clone.
		/// </summary>
		/// <returns>
		/// The <see cref="CollectDailyDefenderBonusResponse"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public CollectDailyDefenderBonusResponse Clone()
		{
			return new CollectDailyDefenderBonusResponse(this);
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
		public bool Equals(CollectDailyDefenderBonusResponse other)
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

			if (!currencyType_.Equals(other.currencyType_))
			{
				return false;
			}

			if (!currencyAwarded_.Equals(other.currencyAwarded_))
			{
				return false;
			}

			if (DefendersCount != other.DefendersCount)
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

			currencyType_.WriteTo(output, _repeated_currencyType_codec);
			currencyAwarded_.WriteTo(output, _repeated_currencyAwarded_codec);
			if (DefendersCount != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(DefendersCount);
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

			size += currencyType_.CalculateSize(_repeated_currencyType_codec);
			size += currencyAwarded_.CalculateSize(_repeated_currencyAwarded_codec);
			if (DefendersCount != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeInt32Size(DefendersCount);
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
		public void MergeFrom(CollectDailyDefenderBonusResponse other)
		{
			if (other == null)
			{
				return;
			}

			if (other.Result != 0)
			{
				Result = other.Result;
			}

			currencyType_.Add(other.currencyType_);
			currencyAwarded_.Add(other.currencyAwarded_);
			if (other.DefendersCount != 0)
			{
				DefendersCount = other.DefendersCount;
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
						result_ = (global::POGOProtos.Networking.Responses.CollectDailyDefenderBonusResponse.Types.Result)input.ReadEnum();
						break;
					}

					case 18:
					{
						currencyType_.AddEntriesFrom(input, _repeated_currencyType_codec);
						break;
					}

					case 26:
					case 24:
					{
						currencyAwarded_.AddEntriesFrom(input, _repeated_currencyAwarded_codec);
						break;
					}

					case 32:
					{
						DefendersCount = input.ReadInt32();
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
			return Equals(other as CollectDailyDefenderBonusResponse);
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

			hash ^= currencyType_.GetHashCode();
			hash ^= currencyAwarded_.GetHashCode();
			if (DefendersCount != 0)
			{
				hash ^= DefendersCount.GetHashCode();
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

		/// <summary>Container for nested types declared in the CollectDailyDefenderBonusResponse message type.</summary>
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
				/// The failure.
				/// </summary>
				[pbr::OriginalName("FAILURE")] Failure = 2,

				/// <summary>
				/// The too soon.
				/// </summary>
				[pbr::OriginalName("TOO_SOON")] TooSoon = 3,

				/// <summary>
				/// The no defenders.
				/// </summary>
				[pbr::OriginalName("NO_DEFENDERS")] NoDefenders = 4,
			}

			#endregion
		}

		#endregion
	}

	#endregion
}

#endregion Designer generated code