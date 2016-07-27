// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DailyBonus.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Data/Player/DailyBonus.proto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

#pragma warning disable 1591, 0612, 3021

#region Designer generated code

using pb = Google.Protobuf;
using pbc = Google.Protobuf.Collections;
using pbr = Google.Protobuf.Reflection;
using scg = System.Collections.Generic;

namespace POGOProtos.Data.Player
{
	/// <summary>Holder for reflection information generated from POGOProtos/Data/Player/DailyBonus.proto</summary>
	public static partial class DailyBonusReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Data/Player/DailyBonus.proto</summary>
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
		/// Initializes static members of the <see cref="DailyBonusReflection"/> class.
		/// </summary>
		static DailyBonusReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CidQT0dPUHJvdG9zL0RhdGEvUGxheWVyL0RhaWx5Qm9udXMucHJvdG8SFlBP",
						"R09Qcm90b3MuRGF0YS5QbGF5ZXIiYwoKRGFpbHlCb251cxIjChtuZXh0X2Nv",
						"bGxlY3RlZF90aW1lc3RhbXBfbXMYASABKAMSMAoobmV4dF9kZWZlbmRlcl9i",
						"b251c19jb2xsZWN0X3RpbWVzdGFtcF9tcxgCIAEoA2IGcHJvdG8z"));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new pbr.FileDescriptor[] { },
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Data.Player.DailyBonus),
							global::POGOProtos.Data.Player.DailyBonus.Parser,
							new[] { "NextCollectedTimestampMs", "NextDefenderBonusCollectTimestampMs" },
							null,
							null,
							null)
					}));
		}

		#endregion
	}

	#region Messages

	/// <summary>
	/// The daily bonus.
	/// </summary>
	public sealed partial class DailyBonus : pb::IMessage<DailyBonus>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "next_collected_timestamp_ms" field.</summary>
		public const int NextCollectedTimestampMsFieldNumber = 1;

		/// <summary>Field number for the "next_defender_bonus_collect_timestamp_ms" field.</summary>
		public const int NextDefenderBonusCollectTimestampMsFieldNumber = 2;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<DailyBonus> _parser =
			new pb::MessageParser<DailyBonus>(() => new DailyBonus());

		#endregion

		#region  Fields

		/// <summary>
		/// The next collected timestamp ms_.
		/// </summary>
		private long nextCollectedTimestampMs_;

		/// <summary>
		/// The next defender bonus collect timestamp ms_.
		/// </summary>
		private long nextDefenderBonusCollectTimestampMs_;

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="DailyBonus"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public DailyBonus()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="DailyBonus"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public DailyBonus(DailyBonus other) : this()
		{
			nextCollectedTimestampMs_ = other.nextCollectedTimestampMs_;
			nextDefenderBonusCollectTimestampMs_ = other.nextDefenderBonusCollectTimestampMs_;
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<DailyBonus> Parser
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
				return global::POGOProtos.Data.Player.DailyBonusReflection.Descriptor.MessageTypes[0];
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
		/// Gets or sets the next collected timestamp ms.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public long NextCollectedTimestampMs
		{
			get
			{
				return nextCollectedTimestampMs_;
			}

			set
			{
				nextCollectedTimestampMs_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the next defender bonus collect timestamp ms.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public long NextDefenderBonusCollectTimestampMs
		{
			get
			{
				return nextDefenderBonusCollectTimestampMs_;
			}

			set
			{
				nextDefenderBonusCollectTimestampMs_ = value;
			}
		}

		#endregion

		#region  Interface Implementations

		/// <summary>
		/// The clone.
		/// </summary>
		/// <returns>
		/// The <see cref="DailyBonus"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public DailyBonus Clone()
		{
			return new DailyBonus(this);
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
		public bool Equals(DailyBonus other)
		{
			if (ReferenceEquals(other, null))
			{
				return false;
			}

			if (ReferenceEquals(other, this))
			{
				return true;
			}

			if (NextCollectedTimestampMs != other.NextCollectedTimestampMs)
			{
				return false;
			}

			if (NextDefenderBonusCollectTimestampMs != other.NextDefenderBonusCollectTimestampMs)
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
			if (NextCollectedTimestampMs != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(NextCollectedTimestampMs);
			}

			if (NextDefenderBonusCollectTimestampMs != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(NextDefenderBonusCollectTimestampMs);
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
			if (NextCollectedTimestampMs != 0L)
			{
				size += 1 + pb::CodedOutputStream.ComputeInt64Size(NextCollectedTimestampMs);
			}

			if (NextDefenderBonusCollectTimestampMs != 0L)
			{
				size += 1 + pb::CodedOutputStream.ComputeInt64Size(NextDefenderBonusCollectTimestampMs);
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
		public void MergeFrom(DailyBonus other)
		{
			if (other == null)
			{
				return;
			}

			if (other.NextCollectedTimestampMs != 0L)
			{
				NextCollectedTimestampMs = other.NextCollectedTimestampMs;
			}

			if (other.NextDefenderBonusCollectTimestampMs != 0L)
			{
				NextDefenderBonusCollectTimestampMs = other.NextDefenderBonusCollectTimestampMs;
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
						NextCollectedTimestampMs = input.ReadInt64();
						break;
					}

					case 16:
					{
						NextDefenderBonusCollectTimestampMs = input.ReadInt64();
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
			return Equals(other as DailyBonus);
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
			if (NextCollectedTimestampMs != 0L)
			{
				hash ^= NextCollectedTimestampMs.GetHashCode();
			}

			if (NextDefenderBonusCollectTimestampMs != 0L)
			{
				hash ^= NextDefenderBonusCollectTimestampMs.GetHashCode();
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