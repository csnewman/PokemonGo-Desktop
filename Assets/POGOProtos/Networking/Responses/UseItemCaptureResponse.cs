// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UseItemCaptureResponse.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Networking/Responses/UseItemCaptureResponse.proto
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
	/// <summary>Holder for reflection information generated from POGOProtos/Networking/Responses/UseItemCaptureResponse.proto</summary>
	public static partial class UseItemCaptureResponseReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Networking/Responses/UseItemCaptureResponse.proto</summary>
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
		/// Initializes static members of the <see cref="UseItemCaptureResponseReflection"/> class.
		/// </summary>
		static UseItemCaptureResponseReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CjxQT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVzcG9uc2VzL1VzZUl0ZW1DYXB0",
						"dXJlUmVzcG9uc2UucHJvdG8SH1BPR09Qcm90b3MuTmV0d29ya2luZy5SZXNw",
						"b25zZXMisQEKFlVzZUl0ZW1DYXB0dXJlUmVzcG9uc2USDwoHc3VjY2VzcxgB",
						"IAEoCBIZChFpdGVtX2NhcHR1cmVfbXVsdBgCIAEoARIWCg5pdGVtX2ZsZWVf",
						"bXVsdBgDIAEoARIVCg1zdG9wX21vdmVtZW50GAQgASgIEhMKC3N0b3BfYXR0",
						"YWNrGAUgASgIEhIKCnRhcmdldF9tYXgYBiABKAgSEwoLdGFyZ2V0X3Nsb3cY",
						"ByABKAhiBnByb3RvMw=="));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new pbr.FileDescriptor[] { },
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Networking.Responses.UseItemCaptureResponse),
							global::POGOProtos.Networking.Responses.UseItemCaptureResponse.Parser,
							new[] { "Success", "ItemCaptureMult", "ItemFleeMult", "StopMovement", "StopAttack", "TargetMax", "TargetSlow" },
							null,
							null,
							null)
					}));
		}

		#endregion
	}

	#region Messages

	/// <summary>
	/// The use item capture response.
	/// </summary>
	public sealed partial class UseItemCaptureResponse : pb::IMessage<UseItemCaptureResponse>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "success" field.</summary>
		public const int SuccessFieldNumber = 1;

		/// <summary>Field number for the "item_capture_mult" field.</summary>
		public const int ItemCaptureMultFieldNumber = 2;

		/// <summary>Field number for the "item_flee_mult" field.</summary>
		public const int ItemFleeMultFieldNumber = 3;

		/// <summary>Field number for the "stop_movement" field.</summary>
		public const int StopMovementFieldNumber = 4;

		/// <summary>Field number for the "stop_attack" field.</summary>
		public const int StopAttackFieldNumber = 5;

		/// <summary>Field number for the "target_max" field.</summary>
		public const int TargetMaxFieldNumber = 6;

		/// <summary>Field number for the "target_slow" field.</summary>
		public const int TargetSlowFieldNumber = 7;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<UseItemCaptureResponse> _parser =
			new pb::MessageParser<UseItemCaptureResponse>(() => new UseItemCaptureResponse());

		#endregion

		#region  Fields

		/// <summary>
		/// The item capture mult_.
		/// </summary>
		private double itemCaptureMult_;

		/// <summary>
		/// The item flee mult_.
		/// </summary>
		private double itemFleeMult_;

		/// <summary>
		/// The stop attack_.
		/// </summary>
		private bool stopAttack_;

		/// <summary>
		/// The stop movement_.
		/// </summary>
		private bool stopMovement_;

		/// <summary>
		/// The success_.
		/// </summary>
		private bool success_;

		/// <summary>
		/// The target max_.
		/// </summary>
		private bool targetMax_;

		/// <summary>
		/// The target slow_.
		/// </summary>
		private bool targetSlow_;

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="UseItemCaptureResponse"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public UseItemCaptureResponse()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="UseItemCaptureResponse"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public UseItemCaptureResponse(UseItemCaptureResponse other) : this()
		{
			success_ = other.success_;
			itemCaptureMult_ = other.itemCaptureMult_;
			itemFleeMult_ = other.itemFleeMult_;
			stopMovement_ = other.stopMovement_;
			stopAttack_ = other.stopAttack_;
			targetMax_ = other.targetMax_;
			targetSlow_ = other.targetSlow_;
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<UseItemCaptureResponse> Parser
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
				return global::POGOProtos.Networking.Responses.UseItemCaptureResponseReflection.Descriptor.MessageTypes[0];
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
		/// Gets or sets the item capture mult.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public double ItemCaptureMult
		{
			get
			{
				return itemCaptureMult_;
			}

			set
			{
				itemCaptureMult_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the item flee mult.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public double ItemFleeMult
		{
			get
			{
				return itemFleeMult_;
			}

			set
			{
				itemFleeMult_ = value;
			}
		}

		/// <summary>
		/// Gets or sets a value indicating whether stop movement.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public bool StopMovement
		{
			get
			{
				return stopMovement_;
			}

			set
			{
				stopMovement_ = value;
			}
		}

		/// <summary>
		/// Gets or sets a value indicating whether stop attack.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public bool StopAttack
		{
			get
			{
				return stopAttack_;
			}

			set
			{
				stopAttack_ = value;
			}
		}

		/// <summary>
		/// Gets or sets a value indicating whether target max.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public bool TargetMax
		{
			get
			{
				return targetMax_;
			}

			set
			{
				targetMax_ = value;
			}
		}

		/// <summary>
		/// Gets or sets a value indicating whether target slow.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public bool TargetSlow
		{
			get
			{
				return targetSlow_;
			}

			set
			{
				targetSlow_ = value;
			}
		}

		#endregion

		#region  Interface Implementations

		/// <summary>
		/// The clone.
		/// </summary>
		/// <returns>
		/// The <see cref="UseItemCaptureResponse"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public UseItemCaptureResponse Clone()
		{
			return new UseItemCaptureResponse(this);
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
		public bool Equals(UseItemCaptureResponse other)
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

			if (ItemCaptureMult != other.ItemCaptureMult)
			{
				return false;
			}

			if (ItemFleeMult != other.ItemFleeMult)
			{
				return false;
			}

			if (StopMovement != other.StopMovement)
			{
				return false;
			}

			if (StopAttack != other.StopAttack)
			{
				return false;
			}

			if (TargetMax != other.TargetMax)
			{
				return false;
			}

			if (TargetSlow != other.TargetSlow)
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

			if (ItemCaptureMult != 0D)
			{
				output.WriteRawTag(17);
				output.WriteDouble(ItemCaptureMult);
			}

			if (ItemFleeMult != 0D)
			{
				output.WriteRawTag(25);
				output.WriteDouble(ItemFleeMult);
			}

			if (StopMovement != false)
			{
				output.WriteRawTag(32);
				output.WriteBool(StopMovement);
			}

			if (StopAttack != false)
			{
				output.WriteRawTag(40);
				output.WriteBool(StopAttack);
			}

			if (TargetMax != false)
			{
				output.WriteRawTag(48);
				output.WriteBool(TargetMax);
			}

			if (TargetSlow != false)
			{
				output.WriteRawTag(56);
				output.WriteBool(TargetSlow);
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

			if (ItemCaptureMult != 0D)
			{
				size += 1 + 8;
			}

			if (ItemFleeMult != 0D)
			{
				size += 1 + 8;
			}

			if (StopMovement != false)
			{
				size += 1 + 1;
			}

			if (StopAttack != false)
			{
				size += 1 + 1;
			}

			if (TargetMax != false)
			{
				size += 1 + 1;
			}

			if (TargetSlow != false)
			{
				size += 1 + 1;
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
		public void MergeFrom(UseItemCaptureResponse other)
		{
			if (other == null)
			{
				return;
			}

			if (other.Success != false)
			{
				Success = other.Success;
			}

			if (other.ItemCaptureMult != 0D)
			{
				ItemCaptureMult = other.ItemCaptureMult;
			}

			if (other.ItemFleeMult != 0D)
			{
				ItemFleeMult = other.ItemFleeMult;
			}

			if (other.StopMovement != false)
			{
				StopMovement = other.StopMovement;
			}

			if (other.StopAttack != false)
			{
				StopAttack = other.StopAttack;
			}

			if (other.TargetMax != false)
			{
				TargetMax = other.TargetMax;
			}

			if (other.TargetSlow != false)
			{
				TargetSlow = other.TargetSlow;
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

					case 17:
					{
						ItemCaptureMult = input.ReadDouble();
						break;
					}

					case 25:
					{
						ItemFleeMult = input.ReadDouble();
						break;
					}

					case 32:
					{
						StopMovement = input.ReadBool();
						break;
					}

					case 40:
					{
						StopAttack = input.ReadBool();
						break;
					}

					case 48:
					{
						TargetMax = input.ReadBool();
						break;
					}

					case 56:
					{
						TargetSlow = input.ReadBool();
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
			return Equals(other as UseItemCaptureResponse);
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

			if (ItemCaptureMult != 0D)
			{
				hash ^= ItemCaptureMult.GetHashCode();
			}

			if (ItemFleeMult != 0D)
			{
				hash ^= ItemFleeMult.GetHashCode();
			}

			if (StopMovement != false)
			{
				hash ^= StopMovement.GetHashCode();
			}

			if (StopAttack != false)
			{
				hash ^= StopAttack.GetHashCode();
			}

			if (TargetMax != false)
			{
				hash ^= TargetMax.GetHashCode();
			}

			if (TargetSlow != false)
			{
				hash ^= TargetSlow.GetHashCode();
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