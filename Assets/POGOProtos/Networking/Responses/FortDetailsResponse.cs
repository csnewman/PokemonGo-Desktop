// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FortDetailsResponse.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Networking/Responses/FortDetailsResponse.proto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

#pragma warning disable 1591, 0612, 3021

#region Designer generated code

using POGOProtos.Data;
using POGOProtos.Enums;
using POGOProtos.Map.Fort;
using pb = Google.Protobuf;
using pbc = Google.Protobuf.Collections;
using pbr = Google.Protobuf.Reflection;
using scg = System.Collections.Generic;

namespace POGOProtos.Networking.Responses
{
	/// <summary>Holder for reflection information generated from POGOProtos/Networking/Responses/FortDetailsResponse.proto</summary>
	public static partial class FortDetailsResponseReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Networking/Responses/FortDetailsResponse.proto</summary>
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
		/// Initializes static members of the <see cref="FortDetailsResponseReflection"/> class.
		/// </summary>
		static FortDetailsResponseReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CjlQT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVzcG9uc2VzL0ZvcnREZXRhaWxz",
						"UmVzcG9uc2UucHJvdG8SH1BPR09Qcm90b3MuTmV0d29ya2luZy5SZXNwb25z",
						"ZXMaIVBPR09Qcm90b3MvRGF0YS9Qb2tlbW9uRGF0YS5wcm90bxogUE9HT1By",
						"b3Rvcy9FbnVtcy9UZWFtQ29sb3IucHJvdG8aIlBPR09Qcm90b3MvTWFwL0Zv",
						"cnQvRm9ydFR5cGUucHJvdG8aJlBPR09Qcm90b3MvTWFwL0ZvcnQvRm9ydE1v",
						"ZGlmaWVyLnByb3RvIvwCChNGb3J0RGV0YWlsc1Jlc3BvbnNlEg8KB2ZvcnRf",
						"aWQYASABKAkSLwoKdGVhbV9jb2xvchgCIAEoDjIbLlBPR09Qcm90b3MuRW51",
						"bXMuVGVhbUNvbG9yEjIKDHBva2Vtb25fZGF0YRgDIAEoCzIcLlBPR09Qcm90",
						"b3MuRGF0YS5Qb2tlbW9uRGF0YRIMCgRuYW1lGAQgASgJEhIKCmltYWdlX3Vy",
						"bHMYBSADKAkSCgoCZnAYBiABKAUSDwoHc3RhbWluYRgHIAEoBRITCgttYXhf",
						"c3RhbWluYRgIIAEoBRIrCgR0eXBlGAkgASgOMh0uUE9HT1Byb3Rvcy5NYXAu",
						"Rm9ydC5Gb3J0VHlwZRIQCghsYXRpdHVkZRgKIAEoARIRCglsb25naXR1ZGUY",
						"CyABKAESEwoLZGVzY3JpcHRpb24YDCABKAkSNAoJbW9kaWZpZXJzGA0gAygL",
						"MiEuUE9HT1Byb3Rvcy5NYXAuRm9ydC5Gb3J0TW9kaWZpZXJiBnByb3RvMw=="));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new[]
				{
					global::POGOProtos.Data.PokemonDataReflection.Descriptor, global::POGOProtos.Enums.TeamColorReflection.Descriptor,
					global::POGOProtos.Map.Fort.FortTypeReflection.Descriptor,
					global::POGOProtos.Map.Fort.FortModifierReflection.Descriptor,
				},
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Networking.Responses.FortDetailsResponse),
							global::POGOProtos.Networking.Responses.FortDetailsResponse.Parser,
							new[]
							{
								"FortId", "TeamColor", "PokemonData", "Name", "ImageUrls", "Fp", "Stamina", "MaxStamina", "Type", "Latitude",
								"Longitude", "Description", "Modifiers"
							},
							null,
							null,
							null)
					}));
		}

		#endregion
	}

	#region Messages

	/// <summary>
	/// The fort details response.
	/// </summary>
	public sealed partial class FortDetailsResponse : pb::IMessage<FortDetailsResponse>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "fort_id" field.</summary>
		public const int FortIdFieldNumber = 1;

		/// <summary>Field number for the "team_color" field.</summary>
		public const int TeamColorFieldNumber = 2;

		/// <summary>Field number for the "pokemon_data" field.</summary>
		public const int PokemonDataFieldNumber = 3;

		/// <summary>Field number for the "name" field.</summary>
		public const int NameFieldNumber = 4;

		/// <summary>Field number for the "image_urls" field.</summary>
		public const int ImageUrlsFieldNumber = 5;

		/// <summary>Field number for the "fp" field.</summary>
		public const int FpFieldNumber = 6;

		/// <summary>Field number for the "stamina" field.</summary>
		public const int StaminaFieldNumber = 7;

		/// <summary>Field number for the "max_stamina" field.</summary>
		public const int MaxStaminaFieldNumber = 8;

		/// <summary>Field number for the "type" field.</summary>
		public const int TypeFieldNumber = 9;

		/// <summary>Field number for the "latitude" field.</summary>
		public const int LatitudeFieldNumber = 10;

		/// <summary>Field number for the "longitude" field.</summary>
		public const int LongitudeFieldNumber = 11;

		/// <summary>Field number for the "description" field.</summary>
		public const int DescriptionFieldNumber = 12;

		/// <summary>Field number for the "modifiers" field.</summary>
		public const int ModifiersFieldNumber = 13;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<FortDetailsResponse> _parser =
			new pb::MessageParser<FortDetailsResponse>(() => new FortDetailsResponse());

		/// <summary>
		/// The _repeated_image urls_codec.
		/// </summary>
		private static readonly pb.FieldCodec<string> _repeated_imageUrls_codec = pb::FieldCodec.ForString(42);

		/// <summary>
		/// The _repeated_modifiers_codec.
		/// </summary>
		private static readonly pb.FieldCodec<FortModifier> _repeated_modifiers_codec = pb::FieldCodec.ForMessage(
			106,
			global::POGOProtos.Map.Fort.FortModifier.Parser);

		#endregion

		#region  Fields

		/// <summary>
		/// The description_.
		/// </summary>
		private string description_ = string.Empty;

		/// <summary>
		/// The fort id_.
		/// </summary>
		private string fortId_ = string.Empty;

		/// <summary>
		/// The fp_.
		/// </summary>
		private int fp_;

		/// <summary>
		/// The image urls_.
		/// </summary>
		private readonly pbc.RepeatedField<string> imageUrls_ = new pbc::RepeatedField<string>();

		/// <summary>
		/// The latitude_.
		/// </summary>
		private double latitude_;

		/// <summary>
		/// The longitude_.
		/// </summary>
		private double longitude_;

		/// <summary>
		/// The max stamina_.
		/// </summary>
		private int maxStamina_;

		/// <summary>
		/// The modifiers_.
		/// </summary>
		private readonly pbc.RepeatedField<FortModifier> modifiers_ = new pbc::RepeatedField<FortModifier>();

		/// <summary>
		/// The name_.
		/// </summary>
		private string name_ = string.Empty;

		/// <summary>
		/// The pokemon data_.
		/// </summary>
		private PokemonData pokemonData_;

		/// <summary>
		/// The stamina_.
		/// </summary>
		private int stamina_;

		/// <summary>
		/// The team color_.
		/// </summary>
		private TeamColor teamColor_ = 0;

		/// <summary>
		/// The type_.
		/// </summary>
		private FortType type_ = 0;

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="FortDetailsResponse"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public FortDetailsResponse()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="FortDetailsResponse"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public FortDetailsResponse(FortDetailsResponse other) : this()
		{
			fortId_ = other.fortId_;
			teamColor_ = other.teamColor_;
			PokemonData = other.pokemonData_ != null ? other.PokemonData.Clone() : null;
			name_ = other.name_;
			imageUrls_ = other.imageUrls_.Clone();
			fp_ = other.fp_;
			stamina_ = other.stamina_;
			maxStamina_ = other.maxStamina_;
			type_ = other.type_;
			latitude_ = other.latitude_;
			longitude_ = other.longitude_;
			description_ = other.description_;
			modifiers_ = other.modifiers_.Clone();
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<FortDetailsResponse> Parser
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
				return global::POGOProtos.Networking.Responses.FortDetailsResponseReflection.Descriptor.MessageTypes[0];
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
		/// Gets or sets the team color.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public TeamColor TeamColor
		{
			get
			{
				return teamColor_;
			}

			set
			{
				teamColor_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the pokemon data.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public PokemonData PokemonData
		{
			get
			{
				return pokemonData_;
			}

			set
			{
				pokemonData_ = value;
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
		/// Gets the image urls.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public pbc.RepeatedField<string> ImageUrls
		{
			get
			{
				return imageUrls_;
			}
		}

		/// <summary>
		/// Gets or sets the fp.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public int Fp
		{
			get
			{
				return fp_;
			}

			set
			{
				fp_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the stamina.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public int Stamina
		{
			get
			{
				return stamina_;
			}

			set
			{
				stamina_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the max stamina.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public int MaxStamina
		{
			get
			{
				return maxStamina_;
			}

			set
			{
				maxStamina_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the type.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public FortType Type
		{
			get
			{
				return type_;
			}

			set
			{
				type_ = value;
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

		/// <summary>
		/// Gets or sets the description.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public string Description
		{
			get
			{
				return description_;
			}

			set
			{
				description_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
			}
		}

		/// <summary>
		/// Gets the modifiers.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public pbc.RepeatedField<FortModifier> Modifiers
		{
			get
			{
				return modifiers_;
			}
		}

		#endregion

		#region  Interface Implementations

		/// <summary>
		/// The clone.
		/// </summary>
		/// <returns>
		/// The <see cref="FortDetailsResponse"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public FortDetailsResponse Clone()
		{
			return new FortDetailsResponse(this);
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
		public bool Equals(FortDetailsResponse other)
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

			if (TeamColor != other.TeamColor)
			{
				return false;
			}

			if (!object.Equals(PokemonData, other.PokemonData))
			{
				return false;
			}

			if (Name != other.Name)
			{
				return false;
			}

			if (!imageUrls_.Equals(other.imageUrls_))
			{
				return false;
			}

			if (Fp != other.Fp)
			{
				return false;
			}

			if (Stamina != other.Stamina)
			{
				return false;
			}

			if (MaxStamina != other.MaxStamina)
			{
				return false;
			}

			if (Type != other.Type)
			{
				return false;
			}

			if (Latitude != other.Latitude)
			{
				return false;
			}

			if (Longitude != other.Longitude)
			{
				return false;
			}

			if (Description != other.Description)
			{
				return false;
			}

			if (!modifiers_.Equals(other.modifiers_))
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

			if (TeamColor != 0)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)TeamColor);
			}

			if (pokemonData_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(PokemonData);
			}

			if (Name.Length != 0)
			{
				output.WriteRawTag(34);
				output.WriteString(Name);
			}

			imageUrls_.WriteTo(output, _repeated_imageUrls_codec);
			if (Fp != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(Fp);
			}

			if (Stamina != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(Stamina);
			}

			if (MaxStamina != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(MaxStamina);
			}

			if (Type != 0)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)Type);
			}

			if (Latitude != 0D)
			{
				output.WriteRawTag(81);
				output.WriteDouble(Latitude);
			}

			if (Longitude != 0D)
			{
				output.WriteRawTag(89);
				output.WriteDouble(Longitude);
			}

			if (Description.Length != 0)
			{
				output.WriteRawTag(98);
				output.WriteString(Description);
			}

			modifiers_.WriteTo(output, _repeated_modifiers_codec);
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

			if (TeamColor != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeEnumSize((int)TeamColor);
			}

			if (pokemonData_ != null)
			{
				size += 1 + pb::CodedOutputStream.ComputeMessageSize(PokemonData);
			}

			if (Name.Length != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
			}

			size += imageUrls_.CalculateSize(_repeated_imageUrls_codec);
			if (Fp != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeInt32Size(Fp);
			}

			if (Stamina != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeInt32Size(Stamina);
			}

			if (MaxStamina != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeInt32Size(MaxStamina);
			}

			if (Type != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeEnumSize((int)Type);
			}

			if (Latitude != 0D)
			{
				size += 1 + 8;
			}

			if (Longitude != 0D)
			{
				size += 1 + 8;
			}

			if (Description.Length != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeStringSize(Description);
			}

			size += modifiers_.CalculateSize(_repeated_modifiers_codec);
			return size;
		}

		/// <summary>
		/// The merge from.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public void MergeFrom(FortDetailsResponse other)
		{
			if (other == null)
			{
				return;
			}

			if (other.FortId.Length != 0)
			{
				FortId = other.FortId;
			}

			if (other.TeamColor != 0)
			{
				TeamColor = other.TeamColor;
			}

			if (other.pokemonData_ != null)
			{
				if (pokemonData_ == null)
				{
					pokemonData_ = new global::POGOProtos.Data.PokemonData();
				}

				PokemonData.MergeFrom(other.PokemonData);
			}

			if (other.Name.Length != 0)
			{
				Name = other.Name;
			}

			imageUrls_.Add(other.imageUrls_);
			if (other.Fp != 0)
			{
				Fp = other.Fp;
			}

			if (other.Stamina != 0)
			{
				Stamina = other.Stamina;
			}

			if (other.MaxStamina != 0)
			{
				MaxStamina = other.MaxStamina;
			}

			if (other.Type != 0)
			{
				Type = other.Type;
			}

			if (other.Latitude != 0D)
			{
				Latitude = other.Latitude;
			}

			if (other.Longitude != 0D)
			{
				Longitude = other.Longitude;
			}

			if (other.Description.Length != 0)
			{
				Description = other.Description;
			}

			modifiers_.Add(other.modifiers_);
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

					case 16:
					{
						teamColor_ = (global::POGOProtos.Enums.TeamColor)input.ReadEnum();
						break;
					}

					case 26:
					{
						if (pokemonData_ == null)
						{
							pokemonData_ = new global::POGOProtos.Data.PokemonData();
						}

						input.ReadMessage(pokemonData_);
						break;
					}

					case 34:
					{
						Name = input.ReadString();
						break;
					}

					case 42:
					{
						imageUrls_.AddEntriesFrom(input, _repeated_imageUrls_codec);
						break;
					}

					case 48:
					{
						Fp = input.ReadInt32();
						break;
					}

					case 56:
					{
						Stamina = input.ReadInt32();
						break;
					}

					case 64:
					{
						MaxStamina = input.ReadInt32();
						break;
					}

					case 72:
					{
						type_ = (global::POGOProtos.Map.Fort.FortType)input.ReadEnum();
						break;
					}

					case 81:
					{
						Latitude = input.ReadDouble();
						break;
					}

					case 89:
					{
						Longitude = input.ReadDouble();
						break;
					}

					case 98:
					{
						Description = input.ReadString();
						break;
					}

					case 106:
					{
						modifiers_.AddEntriesFrom(input, _repeated_modifiers_codec);
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
			return Equals(other as FortDetailsResponse);
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

			if (TeamColor != 0)
			{
				hash ^= TeamColor.GetHashCode();
			}

			if (pokemonData_ != null)
			{
				hash ^= PokemonData.GetHashCode();
			}

			if (Name.Length != 0)
			{
				hash ^= Name.GetHashCode();
			}

			hash ^= imageUrls_.GetHashCode();
			if (Fp != 0)
			{
				hash ^= Fp.GetHashCode();
			}

			if (Stamina != 0)
			{
				hash ^= Stamina.GetHashCode();
			}

			if (MaxStamina != 0)
			{
				hash ^= MaxStamina.GetHashCode();
			}

			if (Type != 0)
			{
				hash ^= Type.GetHashCode();
			}

			if (Latitude != 0D)
			{
				hash ^= Latitude.GetHashCode();
			}

			if (Longitude != 0D)
			{
				hash ^= Longitude.GetHashCode();
			}

			if (Description.Length != 0)
			{
				hash ^= Description.GetHashCode();
			}

			hash ^= modifiers_.GetHashCode();
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