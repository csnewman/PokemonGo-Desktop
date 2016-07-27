// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ActionLogEntry.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Data/Logs/ActionLogEntry.proto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

#pragma warning disable 1591, 0612, 3021

#region Designer generated code

using pb = Google.Protobuf;
using pbc = Google.Protobuf.Collections;
using pbr = Google.Protobuf.Reflection;
using scg = System.Collections.Generic;

namespace POGOProtos.Data.Logs
{
	/// <summary>Holder for reflection information generated from POGOProtos/Data/Logs/ActionLogEntry.proto</summary>
	public static partial class ActionLogEntryReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Data/Logs/ActionLogEntry.proto</summary>
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
		/// Initializes static members of the <see cref="ActionLogEntryReflection"/> class.
		/// </summary>
		static ActionLogEntryReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CilQT0dPUHJvdG9zL0RhdGEvTG9ncy9BY3Rpb25Mb2dFbnRyeS5wcm90bxIU",
						"UE9HT1Byb3Rvcy5EYXRhLkxvZ3MaL1BPR09Qcm90b3MvRGF0YS9Mb2dzL0Nh",
						"dGNoUG9rZW1vbkxvZ0VudHJ5LnByb3RvGi1QT0dPUHJvdG9zL0RhdGEvTG9n",
						"cy9Gb3J0U2VhcmNoTG9nRW50cnkucHJvdG8ixQEKDkFjdGlvbkxvZ0VudHJ5",
						"EhQKDHRpbWVzdGFtcF9tcxgBIAEoAxINCgVzZmlkYRgCIAEoCBJDCg1jYXRj",
						"aF9wb2tlbW9uGAMgASgLMiouUE9HT1Byb3Rvcy5EYXRhLkxvZ3MuQ2F0Y2hQ",
						"b2tlbW9uTG9nRW50cnlIABI/Cgtmb3J0X3NlYXJjaBgEIAEoCzIoLlBPR09Q",
						"cm90b3MuRGF0YS5Mb2dzLkZvcnRTZWFyY2hMb2dFbnRyeUgAQggKBkFjdGlv",
						"bmIGcHJvdG8z"));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new[]
				{
					global::POGOProtos.Data.Logs.CatchPokemonLogEntryReflection.Descriptor,
					global::POGOProtos.Data.Logs.FortSearchLogEntryReflection.Descriptor,
				},
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Data.Logs.ActionLogEntry),
							global::POGOProtos.Data.Logs.ActionLogEntry.Parser,
							new[] { "TimestampMs", "Sfida", "CatchPokemon", "FortSearch" },
							new[] { "Action" },
							null,
							null)
					}));
		}

		#endregion
	}

	#region Messages

	/// <summary>
	/// The action log entry.
	/// </summary>
	public sealed partial class ActionLogEntry : pb::IMessage<ActionLogEntry>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "timestamp_ms" field.</summary>
		public const int TimestampMsFieldNumber = 1;

		/// <summary>Field number for the "sfida" field.</summary>
		public const int SfidaFieldNumber = 2;

		/// <summary>Field number for the "catch_pokemon" field.</summary>
		public const int CatchPokemonFieldNumber = 3;

		/// <summary>Field number for the "fort_search" field.</summary>
		public const int FortSearchFieldNumber = 4;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<ActionLogEntry> _parser =
			new pb::MessageParser<ActionLogEntry>(() => new ActionLogEntry());

		#endregion

		#region  Fields

		/// <summary>
		/// The action_.
		/// </summary>
		private object action_;

		/// <summary>
		/// The action case_.
		/// </summary>
		private ActionOneofCase actionCase_ = ActionOneofCase.None;

		/// <summary>
		/// The sfida_.
		/// </summary>
		private bool sfida_;

		/// <summary>
		/// The timestamp ms_.
		/// </summary>
		private long timestampMs_;

		#endregion

		#region Enums

		/// <summary>Enum of possible cases for the "Action" oneof.</summary>
		public enum ActionOneofCase
		{
			/// <summary>
			/// The none.
			/// </summary>
			None = 0,

			/// <summary>
			/// The catch pokemon.
			/// </summary>
			CatchPokemon = 3,

			/// <summary>
			/// The fort search.
			/// </summary>
			FortSearch = 4,
		}

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="ActionLogEntry"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public ActionLogEntry()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="ActionLogEntry"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public ActionLogEntry(ActionLogEntry other) : this()
		{
			timestampMs_ = other.timestampMs_;
			sfida_ = other.sfida_;
			switch (other.ActionCase)
			{
				case ActionOneofCase.CatchPokemon:
					CatchPokemon = other.CatchPokemon.Clone();
					break;
				case ActionOneofCase.FortSearch:
					FortSearch = other.FortSearch.Clone();
					break;
			}
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<ActionLogEntry> Parser
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
				return global::POGOProtos.Data.Logs.ActionLogEntryReflection.Descriptor.MessageTypes[0];
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
		/// Gets or sets the timestamp ms.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public long TimestampMs
		{
			get
			{
				return timestampMs_;
			}

			set
			{
				timestampMs_ = value;
			}
		}

		/// <summary>
		/// Gets or sets a value indicating whether sfida.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public bool Sfida
		{
			get
			{
				return sfida_;
			}

			set
			{
				sfida_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the catch pokemon.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public CatchPokemonLogEntry CatchPokemon
		{
			get
			{
				return actionCase_ == ActionOneofCase.CatchPokemon
					? (global::POGOProtos.Data.Logs.CatchPokemonLogEntry)action_
					: null;
			}

			set
			{
				action_ = value;
				actionCase_ = value == null ? ActionOneofCase.None : ActionOneofCase.CatchPokemon;
			}
		}

		/// <summary>
		/// Gets or sets the fort search.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public FortSearchLogEntry FortSearch
		{
			get
			{
				return actionCase_ == ActionOneofCase.FortSearch ? (global::POGOProtos.Data.Logs.FortSearchLogEntry)action_ : null;
			}

			set
			{
				action_ = value;
				actionCase_ = value == null ? ActionOneofCase.None : ActionOneofCase.FortSearch;
			}
		}

		/// <summary>
		/// Gets the action case.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public ActionOneofCase ActionCase
		{
			get
			{
				return actionCase_;
			}
		}

		#endregion

		#region  Interface Implementations

		/// <summary>
		/// The clone.
		/// </summary>
		/// <returns>
		/// The <see cref="ActionLogEntry"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public ActionLogEntry Clone()
		{
			return new ActionLogEntry(this);
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
		public bool Equals(ActionLogEntry other)
		{
			if (ReferenceEquals(other, null))
			{
				return false;
			}

			if (ReferenceEquals(other, this))
			{
				return true;
			}

			if (TimestampMs != other.TimestampMs)
			{
				return false;
			}

			if (Sfida != other.Sfida)
			{
				return false;
			}

			if (!object.Equals(CatchPokemon, other.CatchPokemon))
			{
				return false;
			}

			if (!object.Equals(FortSearch, other.FortSearch))
			{
				return false;
			}

			if (ActionCase != other.ActionCase)
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
			if (TimestampMs != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(TimestampMs);
			}

			if (Sfida != false)
			{
				output.WriteRawTag(16);
				output.WriteBool(Sfida);
			}

			if (actionCase_ == ActionOneofCase.CatchPokemon)
			{
				output.WriteRawTag(26);
				output.WriteMessage(CatchPokemon);
			}

			if (actionCase_ == ActionOneofCase.FortSearch)
			{
				output.WriteRawTag(34);
				output.WriteMessage(FortSearch);
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
			if (TimestampMs != 0L)
			{
				size += 1 + pb::CodedOutputStream.ComputeInt64Size(TimestampMs);
			}

			if (Sfida != false)
			{
				size += 1 + 1;
			}

			if (actionCase_ == ActionOneofCase.CatchPokemon)
			{
				size += 1 + pb::CodedOutputStream.ComputeMessageSize(CatchPokemon);
			}

			if (actionCase_ == ActionOneofCase.FortSearch)
			{
				size += 1 + pb::CodedOutputStream.ComputeMessageSize(FortSearch);
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
		public void MergeFrom(ActionLogEntry other)
		{
			if (other == null)
			{
				return;
			}

			if (other.TimestampMs != 0L)
			{
				TimestampMs = other.TimestampMs;
			}

			if (other.Sfida != false)
			{
				Sfida = other.Sfida;
			}

			switch (other.ActionCase)
			{
				case ActionOneofCase.CatchPokemon:
					CatchPokemon = other.CatchPokemon;
					break;
				case ActionOneofCase.FortSearch:
					FortSearch = other.FortSearch;
					break;
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
						TimestampMs = input.ReadInt64();
						break;
					}

					case 16:
					{
						Sfida = input.ReadBool();
						break;
					}

					case 26:
					{
						CatchPokemonLogEntry subBuilder = new global::POGOProtos.Data.Logs.CatchPokemonLogEntry();
						if (actionCase_ == ActionOneofCase.CatchPokemon)
						{
							subBuilder.MergeFrom(CatchPokemon);
						}

						input.ReadMessage(subBuilder);
						CatchPokemon = subBuilder;
						break;
					}

					case 34:
					{
						FortSearchLogEntry subBuilder = new global::POGOProtos.Data.Logs.FortSearchLogEntry();
						if (actionCase_ == ActionOneofCase.FortSearch)
						{
							subBuilder.MergeFrom(FortSearch);
						}

						input.ReadMessage(subBuilder);
						FortSearch = subBuilder;
						break;
					}
				}
			}
		}

		#endregion

		#region  Methods - Public

		/// <summary>
		/// The clear action.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public void ClearAction()
		{
			actionCase_ = ActionOneofCase.None;
			action_ = null;
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
		public override bool Equals(object other)
		{
			return Equals(other as ActionLogEntry);
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
			if (TimestampMs != 0L)
			{
				hash ^= TimestampMs.GetHashCode();
			}

			if (Sfida != false)
			{
				hash ^= Sfida.GetHashCode();
			}

			if (actionCase_ == ActionOneofCase.CatchPokemon)
			{
				hash ^= CatchPokemon.GetHashCode();
			}

			if (actionCase_ == ActionOneofCase.FortSearch)
			{
				hash ^= FortSearch.GetHashCode();
			}

			hash ^= (int)actionCase_;
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