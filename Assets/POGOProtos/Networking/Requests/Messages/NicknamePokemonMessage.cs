// --------------------------------------------------------------------------------------------------------------------
// <copyright file="NicknamePokemonMessage.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Networking/Requests/Messages/NicknamePokemonMessage.proto
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
	/// <summary>Holder for reflection information generated from POGOProtos/Networking/Requests/Messages/NicknamePokemonMessage.proto</summary>
	public static partial class NicknamePokemonMessageReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Networking/Requests/Messages/NicknamePokemonMessage.proto</summary>
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
		/// Initializes static members of the <see cref="NicknamePokemonMessageReflection"/> class.
		/// </summary>
		static NicknamePokemonMessageReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CkRQT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVxdWVzdHMvTWVzc2FnZXMvTmlj",
						"a25hbWVQb2tlbW9uTWVzc2FnZS5wcm90bxInUE9HT1Byb3Rvcy5OZXR3b3Jr",
						"aW5nLlJlcXVlc3RzLk1lc3NhZ2VzIj4KFk5pY2tuYW1lUG9rZW1vbk1lc3Nh",
						"Z2USEgoKcG9rZW1vbl9pZBgBIAEoBhIQCghuaWNrbmFtZRgCIAEoCWIGcHJv",
						"dG8z"));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new pbr.FileDescriptor[] { },
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Networking.Requests.Messages.NicknamePokemonMessage),
							global::POGOProtos.Networking.Requests.Messages.NicknamePokemonMessage.Parser,
							new[] { "PokemonId", "Nickname" },
							null,
							null,
							null)
					}));
		}

		#endregion
	}

	#region Messages

	/// <summary>
	/// The nickname pokemon message.
	/// </summary>
	public sealed partial class NicknamePokemonMessage : pb::IMessage<NicknamePokemonMessage>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "pokemon_id" field.</summary>
		public const int PokemonIdFieldNumber = 1;

		/// <summary>Field number for the "nickname" field.</summary>
		public const int NicknameFieldNumber = 2;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<NicknamePokemonMessage> _parser =
			new pb::MessageParser<NicknamePokemonMessage>(() => new NicknamePokemonMessage());

		#endregion

		#region  Fields

		/// <summary>
		/// The nickname_.
		/// </summary>
		private string nickname_ = string.Empty;

		/// <summary>
		/// The pokemon id_.
		/// </summary>
		private ulong pokemonId_;

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="NicknamePokemonMessage"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public NicknamePokemonMessage()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="NicknamePokemonMessage"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public NicknamePokemonMessage(NicknamePokemonMessage other) : this()
		{
			pokemonId_ = other.pokemonId_;
			nickname_ = other.nickname_;
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<NicknamePokemonMessage> Parser
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
				return global::POGOProtos.Networking.Requests.Messages.NicknamePokemonMessageReflection.Descriptor.MessageTypes[0];
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
		/// Gets or sets the pokemon id.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public ulong PokemonId
		{
			get
			{
				return pokemonId_;
			}

			set
			{
				pokemonId_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the nickname.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public string Nickname
		{
			get
			{
				return nickname_;
			}

			set
			{
				nickname_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
			}
		}

		#endregion

		#region  Interface Implementations

		/// <summary>
		/// The clone.
		/// </summary>
		/// <returns>
		/// The <see cref="NicknamePokemonMessage"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public NicknamePokemonMessage Clone()
		{
			return new NicknamePokemonMessage(this);
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
		public bool Equals(NicknamePokemonMessage other)
		{
			if (ReferenceEquals(other, null))
			{
				return false;
			}

			if (ReferenceEquals(other, this))
			{
				return true;
			}

			if (PokemonId != other.PokemonId)
			{
				return false;
			}

			if (Nickname != other.Nickname)
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
			if (PokemonId != 0UL)
			{
				output.WriteRawTag(9);
				output.WriteFixed64(PokemonId);
			}

			if (Nickname.Length != 0)
			{
				output.WriteRawTag(18);
				output.WriteString(Nickname);
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
			if (PokemonId != 0UL)
			{
				size += 1 + 8;
			}

			if (Nickname.Length != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeStringSize(Nickname);
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
		public void MergeFrom(NicknamePokemonMessage other)
		{
			if (other == null)
			{
				return;
			}

			if (other.PokemonId != 0UL)
			{
				PokemonId = other.PokemonId;
			}

			if (other.Nickname.Length != 0)
			{
				Nickname = other.Nickname;
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
						PokemonId = input.ReadFixed64();
						break;
					}

					case 18:
					{
						Nickname = input.ReadString();
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
			return Equals(other as NicknamePokemonMessage);
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
			if (PokemonId != 0UL)
			{
				hash ^= PokemonId.GetHashCode();
			}

			if (Nickname.Length != 0)
			{
				hash ^= Nickname.GetHashCode();
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