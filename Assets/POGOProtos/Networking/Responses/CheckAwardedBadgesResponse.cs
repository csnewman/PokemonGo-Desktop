// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CheckAwardedBadgesResponse.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Networking/Responses/CheckAwardedBadgesResponse.proto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

#pragma warning disable 1591, 0612, 3021

#region Designer generated code

using POGOProtos.Enums;
using pb = Google.Protobuf;
using pbc = Google.Protobuf.Collections;
using pbr = Google.Protobuf.Reflection;
using scg = System.Collections.Generic;

namespace POGOProtos.Networking.Responses
{
	/// <summary>Holder for reflection information generated from POGOProtos/Networking/Responses/CheckAwardedBadgesResponse.proto</summary>
	public static partial class CheckAwardedBadgesResponseReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Networking/Responses/CheckAwardedBadgesResponse.proto</summary>
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
		/// Initializes static members of the <see cref="CheckAwardedBadgesResponseReflection"/> class.
		/// </summary>
		static CheckAwardedBadgesResponseReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CkBQT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVzcG9uc2VzL0NoZWNrQXdhcmRl",
						"ZEJhZGdlc1Jlc3BvbnNlLnByb3RvEh9QT0dPUHJvdG9zLk5ldHdvcmtpbmcu",
						"UmVzcG9uc2VzGiBQT0dPUHJvdG9zL0VudW1zL0JhZGdlVHlwZS5wcm90byKA",
						"AQoaQ2hlY2tBd2FyZGVkQmFkZ2VzUmVzcG9uc2USDwoHc3VjY2VzcxgBIAEo",
						"CBIzCg5hd2FyZGVkX2JhZGdlcxgCIAMoDjIbLlBPR09Qcm90b3MuRW51bXMu",
						"QmFkZ2VUeXBlEhwKFGF3YXJkZWRfYmFkZ2VfbGV2ZWxzGAMgAygFYgZwcm90",
						"bzM="));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new[] { global::POGOProtos.Enums.BadgeTypeReflection.Descriptor, },
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Networking.Responses.CheckAwardedBadgesResponse),
							global::POGOProtos.Networking.Responses.CheckAwardedBadgesResponse.Parser,
							new[] { "Success", "AwardedBadges", "AwardedBadgeLevels" },
							null,
							null,
							null)
					}));
		}

		#endregion
	}

	#region Messages

	/// <summary>
	/// The check awarded badges response.
	/// </summary>
	public sealed partial class CheckAwardedBadgesResponse : pb::IMessage<CheckAwardedBadgesResponse>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "success" field.</summary>
		public const int SuccessFieldNumber = 1;

		/// <summary>Field number for the "awarded_badges" field.</summary>
		public const int AwardedBadgesFieldNumber = 2;

		/// <summary>Field number for the "awarded_badge_levels" field.</summary>
		public const int AwardedBadgeLevelsFieldNumber = 3;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<CheckAwardedBadgesResponse> _parser =
			new pb::MessageParser<CheckAwardedBadgesResponse>(() => new CheckAwardedBadgesResponse());

		/// <summary>
		/// The _repeated_awarded badges_codec.
		/// </summary>
		private static readonly pb.FieldCodec<BadgeType> _repeated_awardedBadges_codec = pb::FieldCodec.ForEnum(
			18,
			x => (int)x,
			x => (global::POGOProtos.Enums.BadgeType)x);

		/// <summary>
		/// The _repeated_awarded badge levels_codec.
		/// </summary>
		private static readonly pb.FieldCodec<int> _repeated_awardedBadgeLevels_codec = pb::FieldCodec.ForInt32(26);

		#endregion

		#region  Fields

		/// <summary>
		/// The awarded badge levels_.
		/// </summary>
		private readonly pbc.RepeatedField<int> awardedBadgeLevels_ = new pbc::RepeatedField<int>();

		/// <summary>
		/// The awarded badges_.
		/// </summary>
		private readonly pbc.RepeatedField<BadgeType> awardedBadges_ = new pbc::RepeatedField<BadgeType>();

		/// <summary>
		/// The success_.
		/// </summary>
		private bool success_;

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="CheckAwardedBadgesResponse"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public CheckAwardedBadgesResponse()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="CheckAwardedBadgesResponse"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public CheckAwardedBadgesResponse(CheckAwardedBadgesResponse other) : this()
		{
			success_ = other.success_;
			awardedBadges_ = other.awardedBadges_.Clone();
			awardedBadgeLevels_ = other.awardedBadgeLevels_.Clone();
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<CheckAwardedBadgesResponse> Parser
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
				return global::POGOProtos.Networking.Responses.CheckAwardedBadgesResponseReflection.Descriptor.MessageTypes[0];
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
		/// Gets or sets a value indicating whether success.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public bool Success
		{
			get
			{
				return success_;
			}

			set
			{
				success_ = value;
			}
		}

		/// <summary>
		/// Gets the awarded badges.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public pbc.RepeatedField<BadgeType> AwardedBadges
		{
			get
			{
				return awardedBadges_;
			}
		}

		/// <summary>
		/// Gets the awarded badge levels.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public pbc.RepeatedField<int> AwardedBadgeLevels
		{
			get
			{
				return awardedBadgeLevels_;
			}
		}

		#endregion

		#region  Interface Implementations

		/// <summary>
		/// The clone.
		/// </summary>
		/// <returns>
		/// The <see cref="CheckAwardedBadgesResponse"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public CheckAwardedBadgesResponse Clone()
		{
			return new CheckAwardedBadgesResponse(this);
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
		public bool Equals(CheckAwardedBadgesResponse other)
		{
			if (ReferenceEquals(other, null))
			{
				return false;
			}

			if (ReferenceEquals(other, this))
			{
				return true;
			}

			if (Success != other.Success)
			{
				return false;
			}

			if (!awardedBadges_.Equals(other.awardedBadges_))
			{
				return false;
			}

			if (!awardedBadgeLevels_.Equals(other.awardedBadgeLevels_))
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
			if (Success != false)
			{
				output.WriteRawTag(8);
				output.WriteBool(Success);
			}

			awardedBadges_.WriteTo(output, _repeated_awardedBadges_codec);
			awardedBadgeLevels_.WriteTo(output, _repeated_awardedBadgeLevels_codec);
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
			if (Success != false)
			{
				size += 1 + 1;
			}

			size += awardedBadges_.CalculateSize(_repeated_awardedBadges_codec);
			size += awardedBadgeLevels_.CalculateSize(_repeated_awardedBadgeLevels_codec);
			return size;
		}

		/// <summary>
		/// The merge from.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public void MergeFrom(CheckAwardedBadgesResponse other)
		{
			if (other == null)
			{
				return;
			}

			if (other.Success != false)
			{
				Success = other.Success;
			}

			awardedBadges_.Add(other.awardedBadges_);
			awardedBadgeLevels_.Add(other.awardedBadgeLevels_);
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
						Success = input.ReadBool();
						break;
					}

					case 18:
					case 16:
					{
						awardedBadges_.AddEntriesFrom(input, _repeated_awardedBadges_codec);
						break;
					}

					case 26:
					case 24:
					{
						awardedBadgeLevels_.AddEntriesFrom(input, _repeated_awardedBadgeLevels_codec);
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
			return Equals(other as CheckAwardedBadgesResponse);
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
			if (Success != false)
			{
				hash ^= Success.GetHashCode();
			}

			hash ^= awardedBadges_.GetHashCode();
			hash ^= awardedBadgeLevels_.GetHashCode();
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