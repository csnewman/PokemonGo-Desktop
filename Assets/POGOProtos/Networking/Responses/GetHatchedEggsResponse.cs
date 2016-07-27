// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GetHatchedEggsResponse.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Networking/Responses/GetHatchedEggsResponse.proto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

#pragma warning disable 1591, 0612, 3021

#region Designer generated code

using pb = Google.Protobuf;
using pbc = Google.Protobuf.Collections;
using pbr = Google.Protobuf.Reflection;
using scg = System.Collections.Generic;

namespace POGOProtos.Networking.Responses
{
	/// <summary>Holder for reflection information generated from POGOProtos/Networking/Responses/GetHatchedEggsResponse.proto</summary>
	public static partial class GetHatchedEggsResponseReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Networking/Responses/GetHatchedEggsResponse.proto</summary>
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
		/// Initializes static members of the <see cref="GetHatchedEggsResponseReflection"/> class.
		/// </summary>
		static GetHatchedEggsResponseReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CjxQT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVzcG9uc2VzL0dldEhhdGNoZWRF",
						"Z2dzUmVzcG9uc2UucHJvdG8SH1BPR09Qcm90b3MuTmV0d29ya2luZy5SZXNw",
						"b25zZXMijgEKFkdldEhhdGNoZWRFZ2dzUmVzcG9uc2USDwoHc3VjY2VzcxgB",
						"IAEoCBIWCgpwb2tlbW9uX2lkGAIgAygEQgIQARIaChJleHBlcmllbmNlX2F3",
						"YXJkZWQYAyADKAUSFQoNY2FuZHlfYXdhcmRlZBgEIAMoBRIYChBzdGFyZHVz",
						"dF9hd2FyZGVkGAUgAygFYgZwcm90bzM="));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new pbr.FileDescriptor[] { },
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Networking.Responses.GetHatchedEggsResponse),
							global::POGOProtos.Networking.Responses.GetHatchedEggsResponse.Parser,
							new[] { "Success", "PokemonId", "ExperienceAwarded", "CandyAwarded", "StardustAwarded" },
							null,
							null,
							null)
					}));
		}

		#endregion
	}

	#region Messages

	/// <summary>
	/// The get hatched eggs response.
	/// </summary>
	public sealed partial class GetHatchedEggsResponse : pb::IMessage<GetHatchedEggsResponse>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "success" field.</summary>
		public const int SuccessFieldNumber = 1;

		/// <summary>Field number for the "pokemon_id" field.</summary>
		public const int PokemonIdFieldNumber = 2;

		/// <summary>Field number for the "experience_awarded" field.</summary>
		public const int ExperienceAwardedFieldNumber = 3;

		/// <summary>Field number for the "candy_awarded" field.</summary>
		public const int CandyAwardedFieldNumber = 4;

		/// <summary>Field number for the "stardust_awarded" field.</summary>
		public const int StardustAwardedFieldNumber = 5;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<GetHatchedEggsResponse> _parser =
			new pb::MessageParser<GetHatchedEggsResponse>(() => new GetHatchedEggsResponse());

		/// <summary>
		/// The _repeated_pokemon id_codec.
		/// </summary>
		private static readonly pb.FieldCodec<ulong> _repeated_pokemonId_codec = pb::FieldCodec.ForUInt64(18);

		/// <summary>
		/// The _repeated_experience awarded_codec.
		/// </summary>
		private static readonly pb.FieldCodec<int> _repeated_experienceAwarded_codec = pb::FieldCodec.ForInt32(26);

		/// <summary>
		/// The _repeated_candy awarded_codec.
		/// </summary>
		private static readonly pb.FieldCodec<int> _repeated_candyAwarded_codec = pb::FieldCodec.ForInt32(34);

		/// <summary>
		/// The _repeated_stardust awarded_codec.
		/// </summary>
		private static readonly pb.FieldCodec<int> _repeated_stardustAwarded_codec = pb::FieldCodec.ForInt32(42);

		#endregion

		#region  Fields

		/// <summary>
		/// The candy awarded_.
		/// </summary>
		private readonly pbc.RepeatedField<int> candyAwarded_ = new pbc::RepeatedField<int>();

		/// <summary>
		/// The experience awarded_.
		/// </summary>
		private readonly pbc.RepeatedField<int> experienceAwarded_ = new pbc::RepeatedField<int>();

		/// <summary>
		/// The pokemon id_.
		/// </summary>
		private readonly pbc.RepeatedField<ulong> pokemonId_ = new pbc::RepeatedField<ulong>();

		/// <summary>
		/// The stardust awarded_.
		/// </summary>
		private readonly pbc.RepeatedField<int> stardustAwarded_ = new pbc::RepeatedField<int>();

		/// <summary>
		/// The success_.
		/// </summary>
		private bool success_;

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="GetHatchedEggsResponse"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public GetHatchedEggsResponse()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="GetHatchedEggsResponse"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public GetHatchedEggsResponse(GetHatchedEggsResponse other) : this()
		{
			success_ = other.success_;
			pokemonId_ = other.pokemonId_.Clone();
			experienceAwarded_ = other.experienceAwarded_.Clone();
			candyAwarded_ = other.candyAwarded_.Clone();
			stardustAwarded_ = other.stardustAwarded_.Clone();
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<GetHatchedEggsResponse> Parser
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
				return global::POGOProtos.Networking.Responses.GetHatchedEggsResponseReflection.Descriptor.MessageTypes[0];
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
		/// Gets the pokemon id.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public pbc.RepeatedField<ulong> PokemonId
		{
			get
			{
				return pokemonId_;
			}
		}

		/// <summary>
		/// Gets the experience awarded.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public pbc.RepeatedField<int> ExperienceAwarded
		{
			get
			{
				return experienceAwarded_;
			}
		}

		/// <summary>
		/// Gets the candy awarded.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public pbc.RepeatedField<int> CandyAwarded
		{
			get
			{
				return candyAwarded_;
			}
		}

		/// <summary>
		/// Gets the stardust awarded.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public pbc.RepeatedField<int> StardustAwarded
		{
			get
			{
				return stardustAwarded_;
			}
		}

		#endregion

		#region  Interface Implementations

		/// <summary>
		/// The clone.
		/// </summary>
		/// <returns>
		/// The <see cref="GetHatchedEggsResponse"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public GetHatchedEggsResponse Clone()
		{
			return new GetHatchedEggsResponse(this);
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
		public bool Equals(GetHatchedEggsResponse other)
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

			if (!pokemonId_.Equals(other.pokemonId_))
			{
				return false;
			}

			if (!experienceAwarded_.Equals(other.experienceAwarded_))
			{
				return false;
			}

			if (!candyAwarded_.Equals(other.candyAwarded_))
			{
				return false;
			}

			if (!stardustAwarded_.Equals(other.stardustAwarded_))
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

			pokemonId_.WriteTo(output, _repeated_pokemonId_codec);
			experienceAwarded_.WriteTo(output, _repeated_experienceAwarded_codec);
			candyAwarded_.WriteTo(output, _repeated_candyAwarded_codec);
			stardustAwarded_.WriteTo(output, _repeated_stardustAwarded_codec);
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

			size += pokemonId_.CalculateSize(_repeated_pokemonId_codec);
			size += experienceAwarded_.CalculateSize(_repeated_experienceAwarded_codec);
			size += candyAwarded_.CalculateSize(_repeated_candyAwarded_codec);
			size += stardustAwarded_.CalculateSize(_repeated_stardustAwarded_codec);
			return size;
		}

		/// <summary>
		/// The merge from.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public void MergeFrom(GetHatchedEggsResponse other)
		{
			if (other == null)
			{
				return;
			}

			if (other.Success != false)
			{
				Success = other.Success;
			}

			pokemonId_.Add(other.pokemonId_);
			experienceAwarded_.Add(other.experienceAwarded_);
			candyAwarded_.Add(other.candyAwarded_);
			stardustAwarded_.Add(other.stardustAwarded_);
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
					case 16:
					{
						pokemonId_.AddEntriesFrom(input, _repeated_pokemonId_codec);
						break;
					}

					case 26:
					case 24:
					{
						experienceAwarded_.AddEntriesFrom(input, _repeated_experienceAwarded_codec);
						break;
					}

					case 34:
					case 32:
					{
						candyAwarded_.AddEntriesFrom(input, _repeated_candyAwarded_codec);
						break;
					}

					case 42:
					case 40:
					{
						stardustAwarded_.AddEntriesFrom(input, _repeated_stardustAwarded_codec);
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
			return Equals(other as GetHatchedEggsResponse);
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

			hash ^= pokemonId_.GetHashCode();
			hash ^= experienceAwarded_.GetHashCode();
			hash ^= candyAwarded_.GetHashCode();
			hash ^= stardustAwarded_.GetHashCode();
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