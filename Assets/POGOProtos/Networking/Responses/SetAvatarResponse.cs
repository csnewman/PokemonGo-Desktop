// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SetAvatarResponse.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Networking/Responses/SetAvatarResponse.proto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

#pragma warning disable 1591, 0612, 3021

#region Designer generated code

using POGOProtos.Data;
using pb = Google.Protobuf;
using pbc = Google.Protobuf.Collections;
using pbr = Google.Protobuf.Reflection;
using scg = System.Collections.Generic;

namespace POGOProtos.Networking.Responses
{
	/// <summary>Holder for reflection information generated from POGOProtos/Networking/Responses/SetAvatarResponse.proto</summary>
	public static partial class SetAvatarResponseReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Networking/Responses/SetAvatarResponse.proto</summary>
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
		/// Initializes static members of the <see cref="SetAvatarResponseReflection"/> class.
		/// </summary>
		static SetAvatarResponseReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CjdQT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVzcG9uc2VzL1NldEF2YXRhclJl",
						"c3BvbnNlLnByb3RvEh9QT0dPUHJvdG9zLk5ldHdvcmtpbmcuUmVzcG9uc2Vz",
						"GiBQT0dPUHJvdG9zL0RhdGEvUGxheWVyRGF0YS5wcm90byLXAQoRU2V0QXZh",
						"dGFyUmVzcG9uc2USSQoGc3RhdHVzGAEgASgOMjkuUE9HT1Byb3Rvcy5OZXR3",
						"b3JraW5nLlJlc3BvbnNlcy5TZXRBdmF0YXJSZXNwb25zZS5TdGF0dXMSMAoL",
						"cGxheWVyX2RhdGEYAiABKAsyGy5QT0dPUHJvdG9zLkRhdGEuUGxheWVyRGF0",
						"YSJFCgZTdGF0dXMSCQoFVU5TRVQQABILCgdTVUNDRVNTEAESFgoSQVZBVEFS",
						"X0FMUkVBRFlfU0VUEAISCwoHRkFJTFVSRRADYgZwcm90bzM="));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new[] { global::POGOProtos.Data.PlayerDataReflection.Descriptor, },
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Networking.Responses.SetAvatarResponse),
							global::POGOProtos.Networking.Responses.SetAvatarResponse.Parser,
							new[] { "Status", "PlayerData" },
							null,
							new[] { typeof(global::POGOProtos.Networking.Responses.SetAvatarResponse.Types.Status) },
							null)
					}));
		}

		#endregion
	}

	#region Messages

	/// <summary>
	/// The set avatar response.
	/// </summary>
	public sealed partial class SetAvatarResponse : pb::IMessage<SetAvatarResponse>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "status" field.</summary>
		public const int StatusFieldNumber = 1;

		/// <summary>Field number for the "player_data" field.</summary>
		public const int PlayerDataFieldNumber = 2;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<SetAvatarResponse> _parser =
			new pb::MessageParser<SetAvatarResponse>(() => new SetAvatarResponse());

		#endregion

		#region  Fields

		/// <summary>
		/// The player data_.
		/// </summary>
		private PlayerData playerData_;

		/// <summary>
		/// The status_.
		/// </summary>
		private Types.Status status_ = 0;

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="SetAvatarResponse"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public SetAvatarResponse()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="SetAvatarResponse"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public SetAvatarResponse(SetAvatarResponse other) : this()
		{
			status_ = other.status_;
			PlayerData = other.playerData_ != null ? other.PlayerData.Clone() : null;
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<SetAvatarResponse> Parser
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
				return global::POGOProtos.Networking.Responses.SetAvatarResponseReflection.Descriptor.MessageTypes[0];
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
		public Types.Status Status
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
		/// Gets or sets the player data.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public PlayerData PlayerData
		{
			get
			{
				return playerData_;
			}

			set
			{
				playerData_ = value;
			}
		}

		#endregion

		#region  Interface Implementations

		/// <summary>
		/// The clone.
		/// </summary>
		/// <returns>
		/// The <see cref="SetAvatarResponse"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public SetAvatarResponse Clone()
		{
			return new SetAvatarResponse(this);
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
		public bool Equals(SetAvatarResponse other)
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

			if (!object.Equals(PlayerData, other.PlayerData))
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

			if (playerData_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(PlayerData);
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

			if (playerData_ != null)
			{
				size += 1 + pb::CodedOutputStream.ComputeMessageSize(PlayerData);
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
		public void MergeFrom(SetAvatarResponse other)
		{
			if (other == null)
			{
				return;
			}

			if (other.Status != 0)
			{
				Status = other.Status;
			}

			if (other.playerData_ != null)
			{
				if (playerData_ == null)
				{
					playerData_ = new global::POGOProtos.Data.PlayerData();
				}

				PlayerData.MergeFrom(other.PlayerData);
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
						status_ = (global::POGOProtos.Networking.Responses.SetAvatarResponse.Types.Status)input.ReadEnum();
						break;
					}

					case 18:
					{
						if (playerData_ == null)
						{
							playerData_ = new global::POGOProtos.Data.PlayerData();
						}

						input.ReadMessage(playerData_);
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
			return Equals(other as SetAvatarResponse);
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

			if (playerData_ != null)
			{
				hash ^= PlayerData.GetHashCode();
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

		/// <summary>Container for nested types declared in the SetAvatarResponse message type.</summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static partial class Types
		{
			#region Enums

			/// <summary>
			/// The status.
			/// </summary>
			public enum Status
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
				/// The avatar already set.
				/// </summary>
				[pbr::OriginalName("AVATAR_ALREADY_SET")] AvatarAlreadySet = 2,

				/// <summary>
				/// The failure.
				/// </summary>
				[pbr::OriginalName("FAILURE")] Failure = 3,
			}

			#endregion
		}

		#endregion
	}

	#endregion
}

#endregion Designer generated code