// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PlayerPublicProfile.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Data/Player/PlayerPublicProfile.proto
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
	/// <summary>Holder for reflection information generated from POGOProtos/Data/Player/PlayerPublicProfile.proto</summary>
	public static partial class PlayerPublicProfileReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Data/Player/PlayerPublicProfile.proto</summary>
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
		/// Initializes static members of the <see cref="PlayerPublicProfileReflection"/> class.
		/// </summary>
		static PlayerPublicProfileReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CjBQT0dPUHJvdG9zL0RhdGEvUGxheWVyL1BsYXllclB1YmxpY1Byb2ZpbGUu",
						"cHJvdG8SFlBPR09Qcm90b3MuRGF0YS5QbGF5ZXIaKVBPR09Qcm90b3MvRGF0",
						"YS9QbGF5ZXIvUGxheWVyQXZhdGFyLnByb3RvImgKE1BsYXllclB1YmxpY1By",
						"b2ZpbGUSDAoEbmFtZRgBIAEoCRINCgVsZXZlbBgCIAEoBRI0CgZhdmF0YXIY",
						"AyABKAsyJC5QT0dPUHJvdG9zLkRhdGEuUGxheWVyLlBsYXllckF2YXRhcmIG",
						"cHJvdG8z"));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new[] { global::POGOProtos.Data.Player.PlayerAvatarReflection.Descriptor, },
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Data.Player.PlayerPublicProfile),
							global::POGOProtos.Data.Player.PlayerPublicProfile.Parser,
							new[] { "Name", "Level", "Avatar" },
							null,
							null,
							null)
					}));
		}

		#endregion
	}

	#region Messages

	/// <summary>
	/// The player public profile.
	/// </summary>
	public sealed partial class PlayerPublicProfile : pb::IMessage<PlayerPublicProfile>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "name" field.</summary>
		public const int NameFieldNumber = 1;

		/// <summary>Field number for the "level" field.</summary>
		public const int LevelFieldNumber = 2;

		/// <summary>Field number for the "avatar" field.</summary>
		public const int AvatarFieldNumber = 3;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<PlayerPublicProfile> _parser =
			new pb::MessageParser<PlayerPublicProfile>(() => new PlayerPublicProfile());

		#endregion

		#region  Fields

		/// <summary>
		/// The avatar_.
		/// </summary>
		private PlayerAvatar avatar_;

		/// <summary>
		/// The level_.
		/// </summary>
		private int level_;

		/// <summary>
		/// The name_.
		/// </summary>
		private string name_ = string.Empty;

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="PlayerPublicProfile"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public PlayerPublicProfile()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="PlayerPublicProfile"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public PlayerPublicProfile(PlayerPublicProfile other) : this()
		{
			name_ = other.name_;
			level_ = other.level_;
			Avatar = other.avatar_ != null ? other.Avatar.Clone() : null;
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<PlayerPublicProfile> Parser
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
				return global::POGOProtos.Data.Player.PlayerPublicProfileReflection.Descriptor.MessageTypes[0];
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
		/// Gets or sets the name.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public string Name
		{
			get
			{
				return name_;
			}

			set
			{
				name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
			}
		}

		/// <summary>
		/// Gets or sets the level.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public int Level
		{
			get
			{
				return level_;
			}

			set
			{
				level_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the avatar.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public PlayerAvatar Avatar
		{
			get
			{
				return avatar_;
			}

			set
			{
				avatar_ = value;
			}
		}

		#endregion

		#region  Interface Implementations

		/// <summary>
		/// The clone.
		/// </summary>
		/// <returns>
		/// The <see cref="PlayerPublicProfile"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public PlayerPublicProfile Clone()
		{
			return new PlayerPublicProfile(this);
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
		public bool Equals(PlayerPublicProfile other)
		{
			if (ReferenceEquals(other, null))
			{
				return false;
			}

			if (ReferenceEquals(other, this))
			{
				return true;
			}

			if (Name != other.Name)
			{
				return false;
			}

			if (Level != other.Level)
			{
				return false;
			}

			if (!object.Equals(Avatar, other.Avatar))
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
			if (Name.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(Name);
			}

			if (Level != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(Level);
			}

			if (avatar_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(Avatar);
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
			if (Name.Length != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
			}

			if (Level != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeInt32Size(Level);
			}

			if (avatar_ != null)
			{
				size += 1 + pb::CodedOutputStream.ComputeMessageSize(Avatar);
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
		public void MergeFrom(PlayerPublicProfile other)
		{
			if (other == null)
			{
				return;
			}

			if (other.Name.Length != 0)
			{
				Name = other.Name;
			}

			if (other.Level != 0)
			{
				Level = other.Level;
			}

			if (other.avatar_ != null)
			{
				if (avatar_ == null)
				{
					avatar_ = new global::POGOProtos.Data.Player.PlayerAvatar();
				}

				Avatar.MergeFrom(other.Avatar);
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
						Name = input.ReadString();
						break;
					}

					case 16:
					{
						Level = input.ReadInt32();
						break;
					}

					case 26:
					{
						if (avatar_ == null)
						{
							avatar_ = new global::POGOProtos.Data.Player.PlayerAvatar();
						}

						input.ReadMessage(avatar_);
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
			return Equals(other as PlayerPublicProfile);
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
			if (Name.Length != 0)
			{
				hash ^= Name.GetHashCode();
			}

			if (Level != 0)
			{
				hash ^= Level.GetHashCode();
			}

			if (avatar_ != null)
			{
				hash ^= Avatar.GetHashCode();
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