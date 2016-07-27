// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GetPlayerResponse.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Networking/Responses/GetPlayerResponse.proto
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
	/// <summary>Holder for reflection information generated from POGOProtos/Networking/Responses/GetPlayerResponse.proto</summary>
	public static partial class GetPlayerResponseReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Networking/Responses/GetPlayerResponse.proto</summary>
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
		/// Initializes static members of the <see cref="GetPlayerResponseReflection"/> class.
		/// </summary>
		static GetPlayerResponseReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CjdQT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVzcG9uc2VzL0dldFBsYXllclJl",
						"c3BvbnNlLnByb3RvEh9QT0dPUHJvdG9zLk5ldHdvcmtpbmcuUmVzcG9uc2Vz",
						"GiBQT0dPUHJvdG9zL0RhdGEvUGxheWVyRGF0YS5wcm90byJWChFHZXRQbGF5",
						"ZXJSZXNwb25zZRIPCgdzdWNjZXNzGAEgASgIEjAKC3BsYXllcl9kYXRhGAIg",
						"ASgLMhsuUE9HT1Byb3Rvcy5EYXRhLlBsYXllckRhdGFiBnByb3RvMw=="));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new[] { global::POGOProtos.Data.PlayerDataReflection.Descriptor, },
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Networking.Responses.GetPlayerResponse),
							global::POGOProtos.Networking.Responses.GetPlayerResponse.Parser,
							new[] { "Success", "PlayerData" },
							null,
							null,
							null)
					}));
		}

		#endregion
	}

	#region Messages

	/// <summary>
	/// The get player response.
	/// </summary>
	public sealed partial class GetPlayerResponse : pb::IMessage<GetPlayerResponse>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "success" field.</summary>
		public const int SuccessFieldNumber = 1;

		/// <summary>Field number for the "player_data" field.</summary>
		public const int PlayerDataFieldNumber = 2;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<GetPlayerResponse> _parser =
			new pb::MessageParser<GetPlayerResponse>(() => new GetPlayerResponse());

		#endregion

		#region  Fields

		/// <summary>
		/// The player data_.
		/// </summary>
		private PlayerData playerData_;

		/// <summary>
		/// The success_.
		/// </summary>
		private bool success_;

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="GetPlayerResponse"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public GetPlayerResponse()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="GetPlayerResponse"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public GetPlayerResponse(GetPlayerResponse other) : this()
		{
			success_ = other.success_;
			PlayerData = other.playerData_ != null ? other.PlayerData.Clone() : null;
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<GetPlayerResponse> Parser
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
				return global::POGOProtos.Networking.Responses.GetPlayerResponseReflection.Descriptor.MessageTypes[0];
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
		/// The <see cref="GetPlayerResponse"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public GetPlayerResponse Clone()
		{
			return new GetPlayerResponse(this);
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
		public bool Equals(GetPlayerResponse other)
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
			if (Success != false)
			{
				output.WriteRawTag(8);
				output.WriteBool(Success);
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
			if (Success != false)
			{
				size += 1 + 1;
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
		public void MergeFrom(GetPlayerResponse other)
		{
			if (other == null)
			{
				return;
			}

			if (other.Success != false)
			{
				Success = other.Success;
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
						Success = input.ReadBool();
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
			return Equals(other as GetPlayerResponse);
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
	}

	#endregion
}

#endregion Designer generated code