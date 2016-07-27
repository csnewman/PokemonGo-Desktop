// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PlayerBadge.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Data/PlayerBadge.proto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

#pragma warning disable 1591, 0612, 3021

#region Designer generated code

using POGOProtos.Enums;
using pb = Google.Protobuf;
using pbc = Google.Protobuf.Collections;
using pbr = Google.Protobuf.Reflection;
using scg = System.Collections.Generic;

namespace POGOProtos.Data
{
	/// <summary>Holder for reflection information generated from POGOProtos/Data/PlayerBadge.proto</summary>
	public static partial class PlayerBadgeReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Data/PlayerBadge.proto</summary>
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
		/// Initializes static members of the <see cref="PlayerBadgeReflection"/> class.
		/// </summary>
		static PlayerBadgeReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CiFQT0dPUHJvdG9zL0RhdGEvUGxheWVyQmFkZ2UucHJvdG8SD1BPR09Qcm90",
						"b3MuRGF0YRogUE9HT1Byb3Rvcy9FbnVtcy9CYWRnZVR5cGUucHJvdG8iiwEK",
						"C1BsYXllckJhZGdlEi8KCmJhZGdlX3R5cGUYASABKA4yGy5QT0dPUHJvdG9z",
						"LkVudW1zLkJhZGdlVHlwZRIMCgRyYW5rGAIgASgFEhMKC3N0YXJ0X3ZhbHVl",
						"GAMgASgFEhEKCWVuZF92YWx1ZRgEIAEoBRIVCg1jdXJyZW50X3ZhbHVlGAUg",
						"ASgBYgZwcm90bzM="));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new[] { global::POGOProtos.Enums.BadgeTypeReflection.Descriptor, },
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Data.PlayerBadge),
							global::POGOProtos.Data.PlayerBadge.Parser,
							new[] { "BadgeType", "Rank", "StartValue", "EndValue", "CurrentValue" },
							null,
							null,
							null)
					}));
		}

		#endregion
	}

	#region Messages

	/// <summary>
	/// The player badge.
	/// </summary>
	public sealed partial class PlayerBadge : pb::IMessage<PlayerBadge>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "badge_type" field.</summary>
		public const int BadgeTypeFieldNumber = 1;

		/// <summary>Field number for the "rank" field.</summary>
		public const int RankFieldNumber = 2;

		/// <summary>Field number for the "start_value" field.</summary>
		public const int StartValueFieldNumber = 3;

		/// <summary>Field number for the "end_value" field.</summary>
		public const int EndValueFieldNumber = 4;

		/// <summary>Field number for the "current_value" field.</summary>
		public const int CurrentValueFieldNumber = 5;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<PlayerBadge> _parser =
			new pb::MessageParser<PlayerBadge>(() => new PlayerBadge());

		#endregion

		#region  Fields

		/// <summary>
		/// The badge type_.
		/// </summary>
		private BadgeType badgeType_ = 0;

		/// <summary>
		/// The current value_.
		/// </summary>
		private double currentValue_;

		/// <summary>
		/// The end value_.
		/// </summary>
		private int endValue_;

		/// <summary>
		/// The rank_.
		/// </summary>
		private int rank_;

		/// <summary>
		/// The start value_.
		/// </summary>
		private int startValue_;

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="PlayerBadge"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public PlayerBadge()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="PlayerBadge"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public PlayerBadge(PlayerBadge other) : this()
		{
			badgeType_ = other.badgeType_;
			rank_ = other.rank_;
			startValue_ = other.startValue_;
			endValue_ = other.endValue_;
			currentValue_ = other.currentValue_;
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<PlayerBadge> Parser
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
				return global::POGOProtos.Data.PlayerBadgeReflection.Descriptor.MessageTypes[0];
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
		/// Gets or sets the badge type.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public BadgeType BadgeType
		{
			get
			{
				return badgeType_;
			}

			set
			{
				badgeType_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the rank.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public int Rank
		{
			get
			{
				return rank_;
			}

			set
			{
				rank_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the start value.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public int StartValue
		{
			get
			{
				return startValue_;
			}

			set
			{
				startValue_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the end value.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public int EndValue
		{
			get
			{
				return endValue_;
			}

			set
			{
				endValue_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the current value.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public double CurrentValue
		{
			get
			{
				return currentValue_;
			}

			set
			{
				currentValue_ = value;
			}
		}

		#endregion

		#region  Interface Implementations

		/// <summary>
		/// The clone.
		/// </summary>
		/// <returns>
		/// The <see cref="PlayerBadge"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public PlayerBadge Clone()
		{
			return new PlayerBadge(this);
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
		public bool Equals(PlayerBadge other)
		{
			if (ReferenceEquals(other, null))
			{
				return false;
			}

			if (ReferenceEquals(other, this))
			{
				return true;
			}

			if (BadgeType != other.BadgeType)
			{
				return false;
			}

			if (Rank != other.Rank)
			{
				return false;
			}

			if (StartValue != other.StartValue)
			{
				return false;
			}

			if (EndValue != other.EndValue)
			{
				return false;
			}

			if (CurrentValue != other.CurrentValue)
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
			if (BadgeType != 0)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)BadgeType);
			}

			if (Rank != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(Rank);
			}

			if (StartValue != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(StartValue);
			}

			if (EndValue != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(EndValue);
			}

			if (CurrentValue != 0D)
			{
				output.WriteRawTag(41);
				output.WriteDouble(CurrentValue);
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
			if (BadgeType != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeEnumSize((int)BadgeType);
			}

			if (Rank != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeInt32Size(Rank);
			}

			if (StartValue != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeInt32Size(StartValue);
			}

			if (EndValue != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeInt32Size(EndValue);
			}

			if (CurrentValue != 0D)
			{
				size += 1 + 8;
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
		public void MergeFrom(PlayerBadge other)
		{
			if (other == null)
			{
				return;
			}

			if (other.BadgeType != 0)
			{
				BadgeType = other.BadgeType;
			}

			if (other.Rank != 0)
			{
				Rank = other.Rank;
			}

			if (other.StartValue != 0)
			{
				StartValue = other.StartValue;
			}

			if (other.EndValue != 0)
			{
				EndValue = other.EndValue;
			}

			if (other.CurrentValue != 0D)
			{
				CurrentValue = other.CurrentValue;
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
						badgeType_ = (global::POGOProtos.Enums.BadgeType)input.ReadEnum();
						break;
					}

					case 16:
					{
						Rank = input.ReadInt32();
						break;
					}

					case 24:
					{
						StartValue = input.ReadInt32();
						break;
					}

					case 32:
					{
						EndValue = input.ReadInt32();
						break;
					}

					case 41:
					{
						CurrentValue = input.ReadDouble();
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
			return Equals(other as PlayerBadge);
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
			if (BadgeType != 0)
			{
				hash ^= BadgeType.GetHashCode();
			}

			if (Rank != 0)
			{
				hash ^= Rank.GetHashCode();
			}

			if (StartValue != 0)
			{
				hash ^= StartValue.GetHashCode();
			}

			if (EndValue != 0)
			{
				hash ^= EndValue.GetHashCode();
			}

			if (CurrentValue != 0D)
			{
				hash ^= CurrentValue.GetHashCode();
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