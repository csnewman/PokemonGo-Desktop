// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SetContactSettingsResponse.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Networking/Responses/SetContactSettingsResponse.proto
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
	/// <summary>Holder for reflection information generated from POGOProtos/Networking/Responses/SetContactSettingsResponse.proto</summary>
	public static partial class SetContactSettingsResponseReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Networking/Responses/SetContactSettingsResponse.proto</summary>
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
		/// Initializes static members of the <see cref="SetContactSettingsResponseReflection"/> class.
		/// </summary>
		static SetContactSettingsResponseReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CkBQT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVzcG9uc2VzL1NldENvbnRhY3RT",
						"ZXR0aW5nc1Jlc3BvbnNlLnByb3RvEh9QT0dPUHJvdG9zLk5ldHdvcmtpbmcu",
						"UmVzcG9uc2VzGiBQT0dPUHJvdG9zL0RhdGEvUGxheWVyRGF0YS5wcm90byLR",
						"AQoaU2V0Q29udGFjdFNldHRpbmdzUmVzcG9uc2USUgoGc3RhdHVzGAEgASgO",
						"MkIuUE9HT1Byb3Rvcy5OZXR3b3JraW5nLlJlc3BvbnNlcy5TZXRDb250YWN0",
						"U2V0dGluZ3NSZXNwb25zZS5TdGF0dXMSMAoLcGxheWVyX2RhdGEYAiABKAsy",
						"Gy5QT0dPUHJvdG9zLkRhdGEuUGxheWVyRGF0YSItCgZTdGF0dXMSCQoFVU5T",
						"RVQQABILCgdTVUNDRVNTEAESCwoHRkFJTFVSRRACYgZwcm90bzM="));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new[] { global::POGOProtos.Data.PlayerDataReflection.Descriptor, },
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Networking.Responses.SetContactSettingsResponse),
							global::POGOProtos.Networking.Responses.SetContactSettingsResponse.Parser,
							new[] { "Status", "PlayerData" },
							null,
							new[] { typeof(global::POGOProtos.Networking.Responses.SetContactSettingsResponse.Types.Status) },
							null)
					}));
		}

		#endregion
	}

	#region Messages

	/// <summary>
	/// The set contact settings response.
	/// </summary>
	public sealed partial class SetContactSettingsResponse : pb::IMessage<SetContactSettingsResponse>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "status" field.</summary>
		public const int StatusFieldNumber = 1;

		/// <summary>Field number for the "player_data" field.</summary>
		public const int PlayerDataFieldNumber = 2;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<SetContactSettingsResponse> _parser =
			new pb::MessageParser<SetContactSettingsResponse>(() => new SetContactSettingsResponse());

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
		/// Initializes a new instance of the <see cref="SetContactSettingsResponse"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public SetContactSettingsResponse()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="SetContactSettingsResponse"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public SetContactSettingsResponse(SetContactSettingsResponse other) : this()
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
		public static pb.MessageParser<SetContactSettingsResponse> Parser
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
				return global::POGOProtos.Networking.Responses.SetContactSettingsResponseReflection.Descriptor.MessageTypes[0];
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
		/// The <see cref="SetContactSettingsResponse"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public SetContactSettingsResponse Clone()
		{
			return new SetContactSettingsResponse(this);
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
		public bool Equals(SetContactSettingsResponse other)
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
		public void MergeFrom(SetContactSettingsResponse other)
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
						status_ = (global::POGOProtos.Networking.Responses.SetContactSettingsResponse.Types.Status)input.ReadEnum();
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
			return Equals(other as SetContactSettingsResponse);
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

		/// <summary>Container for nested types declared in the SetContactSettingsResponse message type.</summary>
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
				/// The failure.
				/// </summary>
				[pbr::OriginalName("FAILURE")] Failure = 2,
			}

			#endregion
		}

		#endregion
	}

	#endregion
}

#endregion Designer generated code