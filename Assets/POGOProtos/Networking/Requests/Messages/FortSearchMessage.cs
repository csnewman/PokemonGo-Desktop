// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FortSearchMessage.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Networking/Requests/Messages/FortSearchMessage.proto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

#pragma warning disable 1591, 0612, 3021

#region Designer generated code

using pb = Google.Protobuf;
using pbc = Google.Protobuf.Collections;
using pbr = Google.Protobuf.Reflection;
using scg = System.Collections.Generic;

namespace POGOProtos.Networking.Requests.Messages
{
	/// <summary>Holder for reflection information generated from POGOProtos/Networking/Requests/Messages/FortSearchMessage.proto</summary>
	public static partial class FortSearchMessageReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Networking/Requests/Messages/FortSearchMessage.proto</summary>
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
		/// Initializes static members of the <see cref="FortSearchMessageReflection"/> class.
		/// </summary>
		static FortSearchMessageReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"Cj9QT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVxdWVzdHMvTWVzc2FnZXMvRm9y",
						"dFNlYXJjaE1lc3NhZ2UucHJvdG8SJ1BPR09Qcm90b3MuTmV0d29ya2luZy5S",
						"ZXF1ZXN0cy5NZXNzYWdlcyKGAQoRRm9ydFNlYXJjaE1lc3NhZ2USDwoHZm9y",
						"dF9pZBgBIAEoCRIXCg9wbGF5ZXJfbGF0aXR1ZGUYAiABKAESGAoQcGxheWVy",
						"X2xvbmdpdHVkZRgDIAEoARIVCg1mb3J0X2xhdGl0dWRlGAQgASgBEhYKDmZv",
						"cnRfbG9uZ2l0dWRlGAUgASgBYgZwcm90bzM="));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new pbr.FileDescriptor[] { },
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Networking.Requests.Messages.FortSearchMessage),
							global::POGOProtos.Networking.Requests.Messages.FortSearchMessage.Parser,
							new[] { "FortId", "PlayerLatitude", "PlayerLongitude", "FortLatitude", "FortLongitude" },
							null,
							null,
							null)
					}));
		}

		#endregion
	}

	#region Messages

	/// <summary>
	/// The fort search message.
	/// </summary>
	public sealed partial class FortSearchMessage : pb::IMessage<FortSearchMessage>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "fort_id" field.</summary>
		public const int FortIdFieldNumber = 1;

		/// <summary>Field number for the "player_latitude" field.</summary>
		public const int PlayerLatitudeFieldNumber = 2;

		/// <summary>Field number for the "player_longitude" field.</summary>
		public const int PlayerLongitudeFieldNumber = 3;

		/// <summary>Field number for the "fort_latitude" field.</summary>
		public const int FortLatitudeFieldNumber = 4;

		/// <summary>Field number for the "fort_longitude" field.</summary>
		public const int FortLongitudeFieldNumber = 5;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<FortSearchMessage> _parser =
			new pb::MessageParser<FortSearchMessage>(() => new FortSearchMessage());

		#endregion

		#region  Fields

		/// <summary>
		/// The fort id_.
		/// </summary>
		private string fortId_ = string.Empty;

		/// <summary>
		/// The fort latitude_.
		/// </summary>
		private double fortLatitude_;

		/// <summary>
		/// The fort longitude_.
		/// </summary>
		private double fortLongitude_;

		/// <summary>
		/// The player latitude_.
		/// </summary>
		private double playerLatitude_;

		/// <summary>
		/// The player longitude_.
		/// </summary>
		private double playerLongitude_;

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="FortSearchMessage"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public FortSearchMessage()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="FortSearchMessage"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public FortSearchMessage(FortSearchMessage other) : this()
		{
			fortId_ = other.fortId_;
			playerLatitude_ = other.playerLatitude_;
			playerLongitude_ = other.playerLongitude_;
			fortLatitude_ = other.fortLatitude_;
			fortLongitude_ = other.fortLongitude_;
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<FortSearchMessage> Parser
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
				return global::POGOProtos.Networking.Requests.Messages.FortSearchMessageReflection.Descriptor.MessageTypes[0];
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
		/// Gets or sets the fort id.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public string FortId
		{
			get
			{
				return fortId_;
			}

			set
			{
				fortId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
			}
		}

		/// <summary>
		/// Gets or sets the player latitude.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public double PlayerLatitude
		{
			get
			{
				return playerLatitude_;
			}

			set
			{
				playerLatitude_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the player longitude.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public double PlayerLongitude
		{
			get
			{
				return playerLongitude_;
			}

			set
			{
				playerLongitude_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the fort latitude.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public double FortLatitude
		{
			get
			{
				return fortLatitude_;
			}

			set
			{
				fortLatitude_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the fort longitude.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public double FortLongitude
		{
			get
			{
				return fortLongitude_;
			}

			set
			{
				fortLongitude_ = value;
			}
		}

		#endregion

		#region  Interface Implementations

		/// <summary>
		/// The clone.
		/// </summary>
		/// <returns>
		/// The <see cref="FortSearchMessage"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public FortSearchMessage Clone()
		{
			return new FortSearchMessage(this);
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
		public bool Equals(FortSearchMessage other)
		{
			if (ReferenceEquals(other, null))
			{
				return false;
			}

			if (ReferenceEquals(other, this))
			{
				return true;
			}

			if (FortId != other.FortId)
			{
				return false;
			}

			if (PlayerLatitude != other.PlayerLatitude)
			{
				return false;
			}

			if (PlayerLongitude != other.PlayerLongitude)
			{
				return false;
			}

			if (FortLatitude != other.FortLatitude)
			{
				return false;
			}

			if (FortLongitude != other.FortLongitude)
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
			if (FortId.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(FortId);
			}

			if (PlayerLatitude != 0D)
			{
				output.WriteRawTag(17);
				output.WriteDouble(PlayerLatitude);
			}

			if (PlayerLongitude != 0D)
			{
				output.WriteRawTag(25);
				output.WriteDouble(PlayerLongitude);
			}

			if (FortLatitude != 0D)
			{
				output.WriteRawTag(33);
				output.WriteDouble(FortLatitude);
			}

			if (FortLongitude != 0D)
			{
				output.WriteRawTag(41);
				output.WriteDouble(FortLongitude);
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
			if (FortId.Length != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeStringSize(FortId);
			}

			if (PlayerLatitude != 0D)
			{
				size += 1 + 8;
			}

			if (PlayerLongitude != 0D)
			{
				size += 1 + 8;
			}

			if (FortLatitude != 0D)
			{
				size += 1 + 8;
			}

			if (FortLongitude != 0D)
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
		public void MergeFrom(FortSearchMessage other)
		{
			if (other == null)
			{
				return;
			}

			if (other.FortId.Length != 0)
			{
				FortId = other.FortId;
			}

			if (other.PlayerLatitude != 0D)
			{
				PlayerLatitude = other.PlayerLatitude;
			}

			if (other.PlayerLongitude != 0D)
			{
				PlayerLongitude = other.PlayerLongitude;
			}

			if (other.FortLatitude != 0D)
			{
				FortLatitude = other.FortLatitude;
			}

			if (other.FortLongitude != 0D)
			{
				FortLongitude = other.FortLongitude;
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
					case 10:
					{
						FortId = input.ReadString();
						break;
					}

					case 17:
					{
						PlayerLatitude = input.ReadDouble();
						break;
					}

					case 25:
					{
						PlayerLongitude = input.ReadDouble();
						break;
					}

					case 33:
					{
						FortLatitude = input.ReadDouble();
						break;
					}

					case 41:
					{
						FortLongitude = input.ReadDouble();
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
			return Equals(other as FortSearchMessage);
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
			if (FortId.Length != 0)
			{
				hash ^= FortId.GetHashCode();
			}

			if (PlayerLatitude != 0D)
			{
				hash ^= PlayerLatitude.GetHashCode();
			}

			if (PlayerLongitude != 0D)
			{
				hash ^= PlayerLongitude.GetHashCode();
			}

			if (FortLatitude != 0D)
			{
				hash ^= FortLatitude.GetHashCode();
			}

			if (FortLongitude != 0D)
			{
				hash ^= FortLongitude.GetHashCode();
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