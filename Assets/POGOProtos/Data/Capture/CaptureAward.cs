// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CaptureAward.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Data/Capture/CaptureAward.proto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

#pragma warning disable 1591, 0612, 3021

#region Designer generated code

using POGOProtos.Enums;
using pb = Google.Protobuf;
using pbc = Google.Protobuf.Collections;
using pbr = Google.Protobuf.Reflection;
using scg = System.Collections.Generic;

namespace POGOProtos.Data.Capture
{
	/// <summary>Holder for reflection information generated from POGOProtos/Data/Capture/CaptureAward.proto</summary>
	public static partial class CaptureAwardReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Data/Capture/CaptureAward.proto</summary>
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
		/// Initializes static members of the <see cref="CaptureAwardReflection"/> class.
		/// </summary>
		static CaptureAwardReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CipQT0dPUHJvdG9zL0RhdGEvQ2FwdHVyZS9DYXB0dXJlQXdhcmQucHJvdG8S",
						"F1BPR09Qcm90b3MuRGF0YS5DYXB0dXJlGiNQT0dPUHJvdG9zL0VudW1zL0Fj",
						"dGl2aXR5VHlwZS5wcm90byJyCgxDYXB0dXJlQXdhcmQSNQoNYWN0aXZpdHlf",
						"dHlwZRgBIAMoDjIeLlBPR09Qcm90b3MuRW51bXMuQWN0aXZpdHlUeXBlEgoK",
						"AnhwGAIgAygFEg0KBWNhbmR5GAMgAygFEhAKCHN0YXJkdXN0GAQgAygFYgZw",
						"cm90bzM="));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new[] { global::POGOProtos.Enums.ActivityTypeReflection.Descriptor, },
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Data.Capture.CaptureAward),
							global::POGOProtos.Data.Capture.CaptureAward.Parser,
							new[] { "ActivityType", "Xp", "Candy", "Stardust" },
							null,
							null,
							null)
					}));
		}

		#endregion
	}

	#region Messages

	/// <summary>
	/// The capture award.
	/// </summary>
	public sealed partial class CaptureAward : pb::IMessage<CaptureAward>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "activity_type" field.</summary>
		public const int ActivityTypeFieldNumber = 1;

		/// <summary>Field number for the "xp" field.</summary>
		public const int XpFieldNumber = 2;

		/// <summary>Field number for the "candy" field.</summary>
		public const int CandyFieldNumber = 3;

		/// <summary>Field number for the "stardust" field.</summary>
		public const int StardustFieldNumber = 4;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<CaptureAward> _parser =
			new pb::MessageParser<CaptureAward>(() => new CaptureAward());

		/// <summary>
		/// The _repeated_activity type_codec.
		/// </summary>
		private static readonly pb.FieldCodec<ActivityType> _repeated_activityType_codec = pb::FieldCodec.ForEnum(
			10,
			x => (int)x,
			x => (global::POGOProtos.Enums.ActivityType)x);

		/// <summary>
		/// The _repeated_xp_codec.
		/// </summary>
		private static readonly pb.FieldCodec<int> _repeated_xp_codec = pb::FieldCodec.ForInt32(18);

		/// <summary>
		/// The _repeated_candy_codec.
		/// </summary>
		private static readonly pb.FieldCodec<int> _repeated_candy_codec = pb::FieldCodec.ForInt32(26);

		/// <summary>
		/// The _repeated_stardust_codec.
		/// </summary>
		private static readonly pb.FieldCodec<int> _repeated_stardust_codec = pb::FieldCodec.ForInt32(34);

		#endregion

		#region  Fields

		/// <summary>
		/// The activity type_.
		/// </summary>
		private readonly pbc.RepeatedField<ActivityType> activityType_ = new pbc::RepeatedField<ActivityType>();

		/// <summary>
		/// The candy_.
		/// </summary>
		private readonly pbc.RepeatedField<int> candy_ = new pbc::RepeatedField<int>();

		/// <summary>
		/// The stardust_.
		/// </summary>
		private readonly pbc.RepeatedField<int> stardust_ = new pbc::RepeatedField<int>();

		/// <summary>
		/// The xp_.
		/// </summary>
		private readonly pbc.RepeatedField<int> xp_ = new pbc::RepeatedField<int>();

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="CaptureAward"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public CaptureAward()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="CaptureAward"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public CaptureAward(CaptureAward other) : this()
		{
			activityType_ = other.activityType_.Clone();
			xp_ = other.xp_.Clone();
			candy_ = other.candy_.Clone();
			stardust_ = other.stardust_.Clone();
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<CaptureAward> Parser
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
				return global::POGOProtos.Data.Capture.CaptureAwardReflection.Descriptor.MessageTypes[0];
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
		/// Gets the activity type.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public pbc.RepeatedField<ActivityType> ActivityType
		{
			get
			{
				return activityType_;
			}
		}

		/// <summary>
		/// Gets the xp.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public pbc.RepeatedField<int> Xp
		{
			get
			{
				return xp_;
			}
		}

		/// <summary>
		/// Gets the candy.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public pbc.RepeatedField<int> Candy
		{
			get
			{
				return candy_;
			}
		}

		/// <summary>
		/// Gets the stardust.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public pbc.RepeatedField<int> Stardust
		{
			get
			{
				return stardust_;
			}
		}

		#endregion

		#region  Interface Implementations

		/// <summary>
		/// The clone.
		/// </summary>
		/// <returns>
		/// The <see cref="CaptureAward"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public CaptureAward Clone()
		{
			return new CaptureAward(this);
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
		public bool Equals(CaptureAward other)
		{
			if (ReferenceEquals(other, null))
			{
				return false;
			}

			if (ReferenceEquals(other, this))
			{
				return true;
			}

			if (!activityType_.Equals(other.activityType_))
			{
				return false;
			}

			if (!xp_.Equals(other.xp_))
			{
				return false;
			}

			if (!candy_.Equals(other.candy_))
			{
				return false;
			}

			if (!stardust_.Equals(other.stardust_))
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
			activityType_.WriteTo(output, _repeated_activityType_codec);
			xp_.WriteTo(output, _repeated_xp_codec);
			candy_.WriteTo(output, _repeated_candy_codec);
			stardust_.WriteTo(output, _repeated_stardust_codec);
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
			size += activityType_.CalculateSize(_repeated_activityType_codec);
			size += xp_.CalculateSize(_repeated_xp_codec);
			size += candy_.CalculateSize(_repeated_candy_codec);
			size += stardust_.CalculateSize(_repeated_stardust_codec);
			return size;
		}

		/// <summary>
		/// The merge from.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public void MergeFrom(CaptureAward other)
		{
			if (other == null)
			{
				return;
			}

			activityType_.Add(other.activityType_);
			xp_.Add(other.xp_);
			candy_.Add(other.candy_);
			stardust_.Add(other.stardust_);
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
						activityType_.AddEntriesFrom(input, _repeated_activityType_codec);
						break;
					}

					case 18:
					case 16:
					{
						xp_.AddEntriesFrom(input, _repeated_xp_codec);
						break;
					}

					case 26:
					case 24:
					{
						candy_.AddEntriesFrom(input, _repeated_candy_codec);
						break;
					}

					case 34:
					case 32:
					{
						stardust_.AddEntriesFrom(input, _repeated_stardust_codec);
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
			return Equals(other as CaptureAward);
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
			hash ^= activityType_.GetHashCode();
			hash ^= xp_.GetHashCode();
			hash ^= candy_.GetHashCode();
			hash ^= stardust_.GetHashCode();
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