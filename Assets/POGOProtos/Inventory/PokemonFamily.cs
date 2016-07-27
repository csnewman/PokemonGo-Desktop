// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PokemonFamily.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Inventory/PokemonFamily.proto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

#pragma warning disable 1591, 0612, 3021

#region Designer generated code

using POGOProtos.Enums;
using pb = Google.Protobuf;
using pbc = Google.Protobuf.Collections;
using pbr = Google.Protobuf.Reflection;
using scg = System.Collections.Generic;

namespace POGOProtos.Inventory
{
	/// <summary>Holder for reflection information generated from POGOProtos/Inventory/PokemonFamily.proto</summary>
	public static partial class PokemonFamilyReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Inventory/PokemonFamily.proto</summary>
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
		/// Initializes static members of the <see cref="PokemonFamilyReflection"/> class.
		/// </summary>
		static PokemonFamilyReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CihQT0dPUHJvdG9zL0ludmVudG9yeS9Qb2tlbW9uRmFtaWx5LnByb3RvEhRQ",
						"T0dPUHJvdG9zLkludmVudG9yeRomUE9HT1Byb3Rvcy9FbnVtcy9Qb2tlbW9u",
						"RmFtaWx5SWQucHJvdG8iVAoNUG9rZW1vbkZhbWlseRI0CglmYW1pbHlfaWQY",
						"ASABKA4yIS5QT0dPUHJvdG9zLkVudW1zLlBva2Vtb25GYW1pbHlJZBINCgVj",
						"YW5keRgCIAEoBWIGcHJvdG8z"));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new[] { global::POGOProtos.Enums.PokemonFamilyIdReflection.Descriptor, },
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Inventory.PokemonFamily),
							global::POGOProtos.Inventory.PokemonFamily.Parser,
							new[] { "FamilyId", "Candy" },
							null,
							null,
							null)
					}));
		}

		#endregion
	}

	#region Messages

	/// <summary>
	/// The pokemon family.
	/// </summary>
	public sealed partial class PokemonFamily : pb::IMessage<PokemonFamily>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "family_id" field.</summary>
		public const int FamilyIdFieldNumber = 1;

		/// <summary>Field number for the "candy" field.</summary>
		public const int CandyFieldNumber = 2;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<PokemonFamily> _parser =
			new pb::MessageParser<PokemonFamily>(() => new PokemonFamily());

		#endregion

		#region  Fields

		/// <summary>
		/// The candy_.
		/// </summary>
		private int candy_;

		/// <summary>
		/// The family id_.
		/// </summary>
		private PokemonFamilyId familyId_ = 0;

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="PokemonFamily"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public PokemonFamily()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="PokemonFamily"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public PokemonFamily(PokemonFamily other) : this()
		{
			familyId_ = other.familyId_;
			candy_ = other.candy_;
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<PokemonFamily> Parser
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
				return global::POGOProtos.Inventory.PokemonFamilyReflection.Descriptor.MessageTypes[0];
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
		/// Gets or sets the family id.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public PokemonFamilyId FamilyId
		{
			get
			{
				return familyId_;
			}

			set
			{
				familyId_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the candy.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public int Candy
		{
			get
			{
				return candy_;
			}

			set
			{
				candy_ = value;
			}
		}

		#endregion

		#region  Interface Implementations

		/// <summary>
		/// The clone.
		/// </summary>
		/// <returns>
		/// The <see cref="PokemonFamily"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public PokemonFamily Clone()
		{
			return new PokemonFamily(this);
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
		public bool Equals(PokemonFamily other)
		{
			if (ReferenceEquals(other, null))
			{
				return false;
			}

			if (ReferenceEquals(other, this))
			{
				return true;
			}

			if (FamilyId != other.FamilyId)
			{
				return false;
			}

			if (Candy != other.Candy)
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
			if (FamilyId != 0)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)FamilyId);
			}

			if (Candy != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(Candy);
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
			if (FamilyId != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeEnumSize((int)FamilyId);
			}

			if (Candy != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeInt32Size(Candy);
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
		public void MergeFrom(PokemonFamily other)
		{
			if (other == null)
			{
				return;
			}

			if (other.FamilyId != 0)
			{
				FamilyId = other.FamilyId;
			}

			if (other.Candy != 0)
			{
				Candy = other.Candy;
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
						familyId_ = (global::POGOProtos.Enums.PokemonFamilyId)input.ReadEnum();
						break;
					}

					case 16:
					{
						Candy = input.ReadInt32();
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
			return Equals(other as PokemonFamily);
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
			if (FamilyId != 0)
			{
				hash ^= FamilyId.GetHashCode();
			}

			if (Candy != 0)
			{
				hash ^= Candy.GetHashCode();
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