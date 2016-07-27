// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PlayerUpdateMessage.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Networking/Requests/Messages/PlayerUpdateMessage.proto
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
	/// <summary>Holder for reflection information generated from POGOProtos/Networking/Requests/Messages/PlayerUpdateMessage.proto</summary>
	public static partial class PlayerUpdateMessageReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Networking/Requests/Messages/PlayerUpdateMessage.proto</summary>
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
		/// Initializes static members of the <see cref="PlayerUpdateMessageReflection"/> class.
		/// </summary>
		static PlayerUpdateMessageReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CkFQT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVxdWVzdHMvTWVzc2FnZXMvUGxh",
						"eWVyVXBkYXRlTWVzc2FnZS5wcm90bxInUE9HT1Byb3Rvcy5OZXR3b3JraW5n",
						"LlJlcXVlc3RzLk1lc3NhZ2VzIjoKE1BsYXllclVwZGF0ZU1lc3NhZ2USEAoI",
						"bGF0aXR1ZGUYASABKAESEQoJbG9uZ2l0dWRlGAIgASgBYgZwcm90bzM="));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new pbr.FileDescriptor[] { },
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Networking.Requests.Messages.PlayerUpdateMessage),
							global::POGOProtos.Networking.Requests.Messages.PlayerUpdateMessage.Parser,
							new[] { "Latitude", "Longitude" },
							null,
							null,
							null)
					}));
		}

		#endregion
	}

	#region Messages

	/// <summary>
	/// The player update message.
	/// </summary>
	public sealed partial class PlayerUpdateMessage : pb::IMessage<PlayerUpdateMessage>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "latitude" field.</summary>
		public const int LatitudeFieldNumber = 1;

		/// <summary>Field number for the "longitude" field.</summary>
		public const int LongitudeFieldNumber = 2;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<PlayerUpdateMessage> _parser =
			new pb::MessageParser<PlayerUpdateMessage>(() => new PlayerUpdateMessage());

		#endregion

		#region  Fields

		/// <summary>
		/// The latitude_.
		/// </summary>
		private double latitude_;

		/// <summary>
		/// The longitude_.
		/// </summary>
		private double longitude_;

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="PlayerUpdateMessage"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public PlayerUpdateMessage()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="PlayerUpdateMessage"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public PlayerUpdateMessage(PlayerUpdateMessage other) : this()
		{
			latitude_ = other.latitude_;
			longitude_ = other.longitude_;
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<PlayerUpdateMessage> Parser
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
				return global::POGOProtos.Networking.Requests.Messages.PlayerUpdateMessageReflection.Descriptor.MessageTypes[0];
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
		/// Gets or sets the latitude.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public double Latitude
		{
			get
			{
				return latitude_;
			}

			set
			{
				latitude_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the longitude.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public double Longitude
		{
			get
			{
				return longitude_;
			}

			set
			{
				longitude_ = value;
			}
		}

		#endregion

		#region  Interface Implementations

		/// <summary>
		/// The clone.
		/// </summary>
		/// <returns>
		/// The <see cref="PlayerUpdateMessage"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public PlayerUpdateMessage Clone()
		{
			return new PlayerUpdateMessage(this);
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
		public bool Equals(PlayerUpdateMessage other)
		{
			if (ReferenceEquals(other, null))
			{
				return false;
			}

			if (ReferenceEquals(other, this))
			{
				return true;
			}

			if (Latitude != other.Latitude)
			{
				return false;
			}

			if (Longitude != other.Longitude)
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
			if (Latitude != 0D)
			{
				output.WriteRawTag(9);
				output.WriteDouble(Latitude);
			}

			if (Longitude != 0D)
			{
				output.WriteRawTag(17);
				output.WriteDouble(Longitude);
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
			if (Latitude != 0D)
			{
				size += 1 + 8;
			}

			if (Longitude != 0D)
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
		public void MergeFrom(PlayerUpdateMessage other)
		{
			if (other == null)
			{
				return;
			}

			if (other.Latitude != 0D)
			{
				Latitude = other.Latitude;
			}

			if (other.Longitude != 0D)
			{
				Longitude = other.Longitude;
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
					case 9:
					{
						Latitude = input.ReadDouble();
						break;
					}

					case 17:
					{
						Longitude = input.ReadDouble();
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
			return Equals(other as PlayerUpdateMessage);
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
			if (Latitude != 0D)
			{
				hash ^= Latitude.GetHashCode();
			}

			if (Longitude != 0D)
			{
				hash ^= Longitude.GetHashCode();
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