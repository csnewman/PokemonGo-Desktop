// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CatchPokemonResponse.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Networking/Responses/CatchPokemonResponse.proto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

#pragma warning disable 1591, 0612, 3021

#region Designer generated code

using POGOProtos.Data.Capture;
using pb = Google.Protobuf;
using pbc = Google.Protobuf.Collections;
using pbr = Google.Protobuf.Reflection;
using scg = System.Collections.Generic;

namespace POGOProtos.Networking.Responses
{
	/// <summary>Holder for reflection information generated from POGOProtos/Networking/Responses/CatchPokemonResponse.proto</summary>
	public static partial class CatchPokemonResponseReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Networking/Responses/CatchPokemonResponse.proto</summary>
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
		/// Initializes static members of the <see cref="CatchPokemonResponseReflection"/> class.
		/// </summary>
		static CatchPokemonResponseReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CjpQT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVzcG9uc2VzL0NhdGNoUG9rZW1v",
						"blJlc3BvbnNlLnByb3RvEh9QT0dPUHJvdG9zLk5ldHdvcmtpbmcuUmVzcG9u",
						"c2VzGipQT0dPUHJvdG9zL0RhdGEvQ2FwdHVyZS9DYXB0dXJlQXdhcmQucHJv",
						"dG8iwQIKFENhdGNoUG9rZW1vblJlc3BvbnNlElEKBnN0YXR1cxgBIAEoDjJB",
						"LlBPR09Qcm90b3MuTmV0d29ya2luZy5SZXNwb25zZXMuQ2F0Y2hQb2tlbW9u",
						"UmVzcG9uc2UuQ2F0Y2hTdGF0dXMSFAoMbWlzc19wZXJjZW50GAIgASgBEhsK",
						"E2NhcHR1cmVkX3Bva2Vtb25faWQYAyABKAYSPAoNY2FwdHVyZV9hd2FyZBgE",
						"IAEoCzIlLlBPR09Qcm90b3MuRGF0YS5DYXB0dXJlLkNhcHR1cmVBd2FyZCJl",
						"CgtDYXRjaFN0YXR1cxIPCgtDQVRDSF9FUlJPUhAAEhEKDUNBVENIX1NVQ0NF",
						"U1MQARIQCgxDQVRDSF9FU0NBUEUQAhIOCgpDQVRDSF9GTEVFEAMSEAoMQ0FU",
						"Q0hfTUlTU0VEEARiBnByb3RvMw=="));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new[] { global::POGOProtos.Data.Capture.CaptureAwardReflection.Descriptor, },
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Networking.Responses.CatchPokemonResponse),
							global::POGOProtos.Networking.Responses.CatchPokemonResponse.Parser,
							new[] { "Status", "MissPercent", "CapturedPokemonId", "CaptureAward" },
							null,
							new[] { typeof(global::POGOProtos.Networking.Responses.CatchPokemonResponse.Types.CatchStatus) },
							null)
					}));
		}

		#endregion
	}

	#region Messages

	/// <summary>
	/// The catch pokemon response.
	/// </summary>
	public sealed partial class CatchPokemonResponse : pb::IMessage<CatchPokemonResponse>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "status" field.</summary>
		public const int StatusFieldNumber = 1;

		/// <summary>Field number for the "miss_percent" field.</summary>
		public const int MissPercentFieldNumber = 2;

		/// <summary>Field number for the "captured_pokemon_id" field.</summary>
		public const int CapturedPokemonIdFieldNumber = 3;

		/// <summary>Field number for the "capture_award" field.</summary>
		public const int CaptureAwardFieldNumber = 4;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<CatchPokemonResponse> _parser =
			new pb::MessageParser<CatchPokemonResponse>(() => new CatchPokemonResponse());

		#endregion

		#region  Fields

		/// <summary>
		/// The capture award_.
		/// </summary>
		private CaptureAward captureAward_;

		/// <summary>
		/// The captured pokemon id_.
		/// </summary>
		private ulong capturedPokemonId_;

		/// <summary>
		/// The miss percent_.
		/// </summary>
		private double missPercent_;

		/// <summary>
		/// The status_.
		/// </summary>
		private Types.CatchStatus status_ = 0;

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="CatchPokemonResponse"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public CatchPokemonResponse()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="CatchPokemonResponse"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public CatchPokemonResponse(CatchPokemonResponse other) : this()
		{
			status_ = other.status_;
			missPercent_ = other.missPercent_;
			capturedPokemonId_ = other.capturedPokemonId_;
			CaptureAward = other.captureAward_ != null ? other.CaptureAward.Clone() : null;
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<CatchPokemonResponse> Parser
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
				return global::POGOProtos.Networking.Responses.CatchPokemonResponseReflection.Descriptor.MessageTypes[0];
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
		/// Gets or sets the status.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public Types.CatchStatus Status
		{
			get
			{
				return status_;
			}

			set
			{
				status_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the miss percent.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public double MissPercent
		{
			get
			{
				return missPercent_;
			}

			set
			{
				missPercent_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the captured pokemon id.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public ulong CapturedPokemonId
		{
			get
			{
				return capturedPokemonId_;
			}

			set
			{
				capturedPokemonId_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the capture award.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public CaptureAward CaptureAward
		{
			get
			{
				return captureAward_;
			}

			set
			{
				captureAward_ = value;
			}
		}

		#endregion

		#region  Interface Implementations

		/// <summary>
		/// The clone.
		/// </summary>
		/// <returns>
		/// The <see cref="CatchPokemonResponse"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public CatchPokemonResponse Clone()
		{
			return new CatchPokemonResponse(this);
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
		public bool Equals(CatchPokemonResponse other)
		{
			if (ReferenceEquals(other, null))
			{
				return false;
			}

			if (ReferenceEquals(other, this))
			{
				return true;
			}

			if (Status != other.Status)
			{
				return false;
			}

			if (MissPercent != other.MissPercent)
			{
				return false;
			}

			if (CapturedPokemonId != other.CapturedPokemonId)
			{
				return false;
			}

			if (!object.Equals(CaptureAward, other.CaptureAward))
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
			if (Status != 0)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)Status);
			}

			if (MissPercent != 0D)
			{
				output.WriteRawTag(17);
				output.WriteDouble(MissPercent);
			}

			if (CapturedPokemonId != 0UL)
			{
				output.WriteRawTag(25);
				output.WriteFixed64(CapturedPokemonId);
			}

			if (captureAward_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(CaptureAward);
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
			if (Status != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeEnumSize((int)Status);
			}

			if (MissPercent != 0D)
			{
				size += 1 + 8;
			}

			if (CapturedPokemonId != 0UL)
			{
				size += 1 + 8;
			}

			if (captureAward_ != null)
			{
				size += 1 + pb::CodedOutputStream.ComputeMessageSize(CaptureAward);
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
		public void MergeFrom(CatchPokemonResponse other)
		{
			if (other == null)
			{
				return;
			}

			if (other.Status != 0)
			{
				Status = other.Status;
			}

			if (other.MissPercent != 0D)
			{
				MissPercent = other.MissPercent;
			}

			if (other.CapturedPokemonId != 0UL)
			{
				CapturedPokemonId = other.CapturedPokemonId;
			}

			if (other.captureAward_ != null)
			{
				if (captureAward_ == null)
				{
					captureAward_ = new global::POGOProtos.Data.Capture.CaptureAward();
				}

				CaptureAward.MergeFrom(other.CaptureAward);
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
						status_ = (global::POGOProtos.Networking.Responses.CatchPokemonResponse.Types.CatchStatus)input.ReadEnum();
						break;
					}

					case 17:
					{
						MissPercent = input.ReadDouble();
						break;
					}

					case 25:
					{
						CapturedPokemonId = input.ReadFixed64();
						break;
					}

					case 34:
					{
						if (captureAward_ == null)
						{
							captureAward_ = new global::POGOProtos.Data.Capture.CaptureAward();
						}

						input.ReadMessage(captureAward_);
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
			return Equals(other as CatchPokemonResponse);
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
			if (Status != 0)
			{
				hash ^= Status.GetHashCode();
			}

			if (MissPercent != 0D)
			{
				hash ^= MissPercent.GetHashCode();
			}

			if (CapturedPokemonId != 0UL)
			{
				hash ^= CapturedPokemonId.GetHashCode();
			}

			if (captureAward_ != null)
			{
				hash ^= CaptureAward.GetHashCode();
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

		/// <summary>Container for nested types declared in the CatchPokemonResponse message type.</summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static partial class Types
		{
			#region Enums

			/// <summary>
			/// The catch status.
			/// </summary>
			public enum CatchStatus
			{
				/// <summary>
				/// The catch error.
				/// </summary>
				[pbr::OriginalName("CATCH_ERROR")] CatchError = 0,

				/// <summary>
				/// The catch success.
				/// </summary>
				[pbr::OriginalName("CATCH_SUCCESS")] CatchSuccess = 1,

				/// <summary>
				/// The catch escape.
				/// </summary>
				[pbr::OriginalName("CATCH_ESCAPE")] CatchEscape = 2,

				/// <summary>
				/// The catch flee.
				/// </summary>
				[pbr::OriginalName("CATCH_FLEE")] CatchFlee = 3,

				/// <summary>
				/// The catch missed.
				/// </summary>
				[pbr::OriginalName("CATCH_MISSED")] CatchMissed = 4,
			}

			#endregion
		}

		#endregion
	}

	#endregion
}

#endregion Designer generated code