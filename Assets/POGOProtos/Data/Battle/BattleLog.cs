// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BattleLog.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Data/Battle/BattleLog.proto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

#pragma warning disable 1591, 0612, 3021

#region Designer generated code

using pb = Google.Protobuf;
using pbc = Google.Protobuf.Collections;
using pbr = Google.Protobuf.Reflection;
using scg = System.Collections.Generic;

namespace POGOProtos.Data.Battle
{
	/// <summary>Holder for reflection information generated from POGOProtos/Data/Battle/BattleLog.proto</summary>
	public static partial class BattleLogReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Data/Battle/BattleLog.proto</summary>
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
		/// Initializes static members of the <see cref="BattleLogReflection"/> class.
		/// </summary>
		static BattleLogReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CiZQT0dPUHJvdG9zL0RhdGEvQmF0dGxlL0JhdHRsZUxvZy5wcm90bxIWUE9H",
						"T1Byb3Rvcy5EYXRhLkJhdHRsZRooUE9HT1Byb3Rvcy9EYXRhL0JhdHRsZS9C",
						"YXR0bGVTdGF0ZS5wcm90bxonUE9HT1Byb3Rvcy9EYXRhL0JhdHRsZS9CYXR0",
						"bGVUeXBlLnByb3RvGilQT0dPUHJvdG9zL0RhdGEvQmF0dGxlL0JhdHRsZUFj",
						"dGlvbi5wcm90byKNAgoJQmF0dGxlTG9nEjIKBXN0YXRlGAEgASgOMiMuUE9H",
						"T1Byb3Rvcy5EYXRhLkJhdHRsZS5CYXR0bGVTdGF0ZRI3CgtiYXR0bGVfdHlw",
						"ZRgCIAEoDjIiLlBPR09Qcm90b3MuRGF0YS5CYXR0bGUuQmF0dGxlVHlwZRIR",
						"CglzZXJ2ZXJfbXMYAyABKAMSPAoOYmF0dGxlX2FjdGlvbnMYBCADKAsyJC5Q",
						"T0dPUHJvdG9zLkRhdGEuQmF0dGxlLkJhdHRsZUFjdGlvbhIhChliYXR0bGVf",
						"c3RhcnRfdGltZXN0YW1wX21zGAUgASgDEh8KF2JhdHRsZV9lbmRfdGltZXN0",
						"YW1wX21zGAYgASgDYgZwcm90bzM="));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new[]
				{
					global::POGOProtos.Data.Battle.BattleStateReflection.Descriptor,
					global::POGOProtos.Data.Battle.BattleTypeReflection.Descriptor,
					global::POGOProtos.Data.Battle.BattleActionReflection.Descriptor,
				},
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Data.Battle.BattleLog),
							global::POGOProtos.Data.Battle.BattleLog.Parser,
							new[] { "State", "BattleType", "ServerMs", "BattleActions", "BattleStartTimestampMs", "BattleEndTimestampMs" },
							null,
							null,
							null)
					}));
		}

		#endregion
	}

	#region Messages

	/// <summary>
	/// The battle log.
	/// </summary>
	public sealed partial class BattleLog : pb::IMessage<BattleLog>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "state" field.</summary>
		public const int StateFieldNumber = 1;

		/// <summary>Field number for the "battle_type" field.</summary>
		public const int BattleTypeFieldNumber = 2;

		/// <summary>Field number for the "server_ms" field.</summary>
		public const int ServerMsFieldNumber = 3;

		/// <summary>Field number for the "battle_actions" field.</summary>
		public const int BattleActionsFieldNumber = 4;

		/// <summary>Field number for the "battle_start_timestamp_ms" field.</summary>
		public const int BattleStartTimestampMsFieldNumber = 5;

		/// <summary>Field number for the "battle_end_timestamp_ms" field.</summary>
		public const int BattleEndTimestampMsFieldNumber = 6;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<BattleLog> _parser = new pb::MessageParser<BattleLog>(() => new BattleLog());

		/// <summary>
		/// The _repeated_battle actions_codec.
		/// </summary>
		private static readonly pb.FieldCodec<BattleAction> _repeated_battleActions_codec = pb::FieldCodec.ForMessage(
			34,
			global::POGOProtos.Data.Battle.BattleAction.Parser);

		#endregion

		#region  Fields

		/// <summary>
		/// The battle actions_.
		/// </summary>
		private readonly pbc.RepeatedField<BattleAction> battleActions_ = new pbc::RepeatedField<BattleAction>();

		/// <summary>
		/// The battle end timestamp ms_.
		/// </summary>
		private long battleEndTimestampMs_;

		/// <summary>
		/// The battle start timestamp ms_.
		/// </summary>
		private long battleStartTimestampMs_;

		/// <summary>
		/// The battle type_.
		/// </summary>
		private BattleType battleType_ = 0;

		/// <summary>
		/// The server ms_.
		/// </summary>
		private long serverMs_;

		/// <summary>
		/// The state_.
		/// </summary>
		private BattleState state_ = 0;

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="BattleLog"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public BattleLog()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="BattleLog"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public BattleLog(BattleLog other) : this()
		{
			state_ = other.state_;
			battleType_ = other.battleType_;
			serverMs_ = other.serverMs_;
			battleActions_ = other.battleActions_.Clone();
			battleStartTimestampMs_ = other.battleStartTimestampMs_;
			battleEndTimestampMs_ = other.battleEndTimestampMs_;
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<BattleLog> Parser
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
				return global::POGOProtos.Data.Battle.BattleLogReflection.Descriptor.MessageTypes[0];
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
		/// Gets or sets the state.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public BattleState State
		{
			get
			{
				return state_;
			}

			set
			{
				state_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the battle type.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public BattleType BattleType
		{
			get
			{
				return battleType_;
			}

			set
			{
				battleType_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the server ms.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public long ServerMs
		{
			get
			{
				return serverMs_;
			}

			set
			{
				serverMs_ = value;
			}
		}

		/// <summary>
		/// Gets the battle actions.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public pbc.RepeatedField<BattleAction> BattleActions
		{
			get
			{
				return battleActions_;
			}
		}

		/// <summary>
		/// Gets or sets the battle start timestamp ms.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public long BattleStartTimestampMs
		{
			get
			{
				return battleStartTimestampMs_;
			}

			set
			{
				battleStartTimestampMs_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the battle end timestamp ms.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public long BattleEndTimestampMs
		{
			get
			{
				return battleEndTimestampMs_;
			}

			set
			{
				battleEndTimestampMs_ = value;
			}
		}

		#endregion

		#region  Interface Implementations

		/// <summary>
		/// The clone.
		/// </summary>
		/// <returns>
		/// The <see cref="BattleLog"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public BattleLog Clone()
		{
			return new BattleLog(this);
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
		public bool Equals(BattleLog other)
		{
			if (ReferenceEquals(other, null))
			{
				return false;
			}

			if (ReferenceEquals(other, this))
			{
				return true;
			}

			if (State != other.State)
			{
				return false;
			}

			if (BattleType != other.BattleType)
			{
				return false;
			}

			if (ServerMs != other.ServerMs)
			{
				return false;
			}

			if (!battleActions_.Equals(other.battleActions_))
			{
				return false;
			}

			if (BattleStartTimestampMs != other.BattleStartTimestampMs)
			{
				return false;
			}

			if (BattleEndTimestampMs != other.BattleEndTimestampMs)
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
			if (State != 0)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)State);
			}

			if (BattleType != 0)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)BattleType);
			}

			if (ServerMs != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(ServerMs);
			}

			battleActions_.WriteTo(output, _repeated_battleActions_codec);
			if (BattleStartTimestampMs != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(BattleStartTimestampMs);
			}

			if (BattleEndTimestampMs != 0L)
			{
				output.WriteRawTag(48);
				output.WriteInt64(BattleEndTimestampMs);
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
			if (State != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeEnumSize((int)State);
			}

			if (BattleType != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeEnumSize((int)BattleType);
			}

			if (ServerMs != 0L)
			{
				size += 1 + pb::CodedOutputStream.ComputeInt64Size(ServerMs);
			}

			size += battleActions_.CalculateSize(_repeated_battleActions_codec);
			if (BattleStartTimestampMs != 0L)
			{
				size += 1 + pb::CodedOutputStream.ComputeInt64Size(BattleStartTimestampMs);
			}

			if (BattleEndTimestampMs != 0L)
			{
				size += 1 + pb::CodedOutputStream.ComputeInt64Size(BattleEndTimestampMs);
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
		public void MergeFrom(BattleLog other)
		{
			if (other == null)
			{
				return;
			}

			if (other.State != 0)
			{
				State = other.State;
			}

			if (other.BattleType != 0)
			{
				BattleType = other.BattleType;
			}

			if (other.ServerMs != 0L)
			{
				ServerMs = other.ServerMs;
			}

			battleActions_.Add(other.battleActions_);
			if (other.BattleStartTimestampMs != 0L)
			{
				BattleStartTimestampMs = other.BattleStartTimestampMs;
			}

			if (other.BattleEndTimestampMs != 0L)
			{
				BattleEndTimestampMs = other.BattleEndTimestampMs;
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
						state_ = (global::POGOProtos.Data.Battle.BattleState)input.ReadEnum();
						break;
					}

					case 16:
					{
						battleType_ = (global::POGOProtos.Data.Battle.BattleType)input.ReadEnum();
						break;
					}

					case 24:
					{
						ServerMs = input.ReadInt64();
						break;
					}

					case 34:
					{
						battleActions_.AddEntriesFrom(input, _repeated_battleActions_codec);
						break;
					}

					case 40:
					{
						BattleStartTimestampMs = input.ReadInt64();
						break;
					}

					case 48:
					{
						BattleEndTimestampMs = input.ReadInt64();
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
			return Equals(other as BattleLog);
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
			if (State != 0)
			{
				hash ^= State.GetHashCode();
			}

			if (BattleType != 0)
			{
				hash ^= BattleType.GetHashCode();
			}

			if (ServerMs != 0L)
			{
				hash ^= ServerMs.GetHashCode();
			}

			hash ^= battleActions_.GetHashCode();
			if (BattleStartTimestampMs != 0L)
			{
				hash ^= BattleStartTimestampMs.GetHashCode();
			}

			if (BattleEndTimestampMs != 0L)
			{
				hash ^= BattleEndTimestampMs.GetHashCode();
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