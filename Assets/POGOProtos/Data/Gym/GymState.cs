// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GymState.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Data/Gym/GymState.proto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

#pragma warning disable 1591, 0612, 3021

#region Designer generated code

using POGOProtos.Map.Fort;
using pb = Google.Protobuf;
using pbc = Google.Protobuf.Collections;
using pbr = Google.Protobuf.Reflection;
using scg = System.Collections.Generic;

namespace POGOProtos.Data.Gym
{
	/// <summary>Holder for reflection information generated from POGOProtos/Data/Gym/GymState.proto</summary>
	public static partial class GymStateReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Data/Gym/GymState.proto</summary>
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
		/// Initializes static members of the <see cref="GymStateReflection"/> class.
		/// </summary>
		static GymStateReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CiJQT0dPUHJvdG9zL0RhdGEvR3ltL0d5bVN0YXRlLnByb3RvEhNQT0dPUHJv",
						"dG9zLkRhdGEuR3ltGiJQT0dPUHJvdG9zL01hcC9Gb3J0L0ZvcnREYXRhLnBy",
						"b3RvGidQT0dPUHJvdG9zL0RhdGEvR3ltL0d5bU1lbWJlcnNoaXAucHJvdG8i",
						"dQoIR3ltU3RhdGUSMAoJZm9ydF9kYXRhGAEgASgLMh0uUE9HT1Byb3Rvcy5N",
						"YXAuRm9ydC5Gb3J0RGF0YRI3CgttZW1iZXJzaGlwcxgCIAMoCzIiLlBPR09Q",
						"cm90b3MuRGF0YS5HeW0uR3ltTWVtYmVyc2hpcGIGcHJvdG8z"));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new[]
				{
					global::POGOProtos.Map.Fort.FortDataReflection.Descriptor,
					global::POGOProtos.Data.Gym.GymMembershipReflection.Descriptor,
				},
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Data.Gym.GymState),
							global::POGOProtos.Data.Gym.GymState.Parser,
							new[] { "FortData", "Memberships" },
							null,
							null,
							null)
					}));
		}

		#endregion
	}

	#region Messages

	/// <summary>
	/// The gym state.
	/// </summary>
	public sealed partial class GymState : pb::IMessage<GymState>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "fort_data" field.</summary>
		public const int FortDataFieldNumber = 1;

		/// <summary>Field number for the "memberships" field.</summary>
		public const int MembershipsFieldNumber = 2;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<GymState> _parser = new pb::MessageParser<GymState>(() => new GymState());

		/// <summary>
		/// The _repeated_memberships_codec.
		/// </summary>
		private static readonly pb.FieldCodec<GymMembership> _repeated_memberships_codec = pb::FieldCodec.ForMessage(
			18,
			global::POGOProtos.Data.Gym.GymMembership.Parser);

		#endregion

		#region  Fields

		/// <summary>
		/// The fort data_.
		/// </summary>
		private FortData fortData_;

		/// <summary>
		/// The memberships_.
		/// </summary>
		private readonly pbc.RepeatedField<GymMembership> memberships_ = new pbc::RepeatedField<GymMembership>();

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="GymState"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public GymState()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="GymState"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public GymState(GymState other) : this()
		{
			FortData = other.fortData_ != null ? other.FortData.Clone() : null;
			memberships_ = other.memberships_.Clone();
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<GymState> Parser
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
				return global::POGOProtos.Data.Gym.GymStateReflection.Descriptor.MessageTypes[0];
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
		/// Gets or sets the fort data.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public FortData FortData
		{
			get
			{
				return fortData_;
			}

			set
			{
				fortData_ = value;
			}
		}

		/// <summary>
		/// Gets the memberships.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public pbc.RepeatedField<GymMembership> Memberships
		{
			get
			{
				return memberships_;
			}
		}

		#endregion

		#region  Interface Implementations

		/// <summary>
		/// The clone.
		/// </summary>
		/// <returns>
		/// The <see cref="GymState"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public GymState Clone()
		{
			return new GymState(this);
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
		public bool Equals(GymState other)
		{
			if (ReferenceEquals(other, null))
			{
				return false;
			}

			if (ReferenceEquals(other, this))
			{
				return true;
			}

			if (!object.Equals(FortData, other.FortData))
			{
				return false;
			}

			if (!memberships_.Equals(other.memberships_))
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
			if (fortData_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(FortData);
			}

			memberships_.WriteTo(output, _repeated_memberships_codec);
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
			if (fortData_ != null)
			{
				size += 1 + pb::CodedOutputStream.ComputeMessageSize(FortData);
			}

			size += memberships_.CalculateSize(_repeated_memberships_codec);
			return size;
		}

		/// <summary>
		/// The merge from.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public void MergeFrom(GymState other)
		{
			if (other == null)
			{
				return;
			}

			if (other.fortData_ != null)
			{
				if (fortData_ == null)
				{
					fortData_ = new global::POGOProtos.Map.Fort.FortData();
				}

				FortData.MergeFrom(other.FortData);
			}

			memberships_.Add(other.memberships_);
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
						if (fortData_ == null)
						{
							fortData_ = new global::POGOProtos.Map.Fort.FortData();
						}

						input.ReadMessage(fortData_);
						break;
					}

					case 18:
					{
						memberships_.AddEntriesFrom(input, _repeated_memberships_codec);
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
			return Equals(other as GymState);
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
			if (fortData_ != null)
			{
				hash ^= FortData.GetHashCode();
			}

			hash ^= memberships_.GetHashCode();
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