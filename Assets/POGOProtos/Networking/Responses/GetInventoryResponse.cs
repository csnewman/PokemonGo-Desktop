// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GetInventoryResponse.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Networking/Responses/GetInventoryResponse.proto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

#pragma warning disable 1591, 0612, 3021

#region Designer generated code

using POGOProtos.Inventory;
using pb = Google.Protobuf;
using pbc = Google.Protobuf.Collections;
using pbr = Google.Protobuf.Reflection;
using scg = System.Collections.Generic;

namespace POGOProtos.Networking.Responses
{
	/// <summary>Holder for reflection information generated from POGOProtos/Networking/Responses/GetInventoryResponse.proto</summary>
	public static partial class GetInventoryResponseReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Networking/Responses/GetInventoryResponse.proto</summary>
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
		/// Initializes static members of the <see cref="GetInventoryResponseReflection"/> class.
		/// </summary>
		static GetInventoryResponseReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CjpQT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVzcG9uc2VzL0dldEludmVudG9y",
						"eVJlc3BvbnNlLnByb3RvEh9QT0dPUHJvdG9zLk5ldHdvcmtpbmcuUmVzcG9u",
						"c2VzGilQT0dPUHJvdG9zL0ludmVudG9yeS9JbnZlbnRvcnlEZWx0YS5wcm90",
						"byJmChRHZXRJbnZlbnRvcnlSZXNwb25zZRIPCgdzdWNjZXNzGAEgASgIEj0K",
						"D2ludmVudG9yeV9kZWx0YRgCIAEoCzIkLlBPR09Qcm90b3MuSW52ZW50b3J5",
						"LkludmVudG9yeURlbHRhYgZwcm90bzM="));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new[] { global::POGOProtos.Inventory.InventoryDeltaReflection.Descriptor, },
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Networking.Responses.GetInventoryResponse),
							global::POGOProtos.Networking.Responses.GetInventoryResponse.Parser,
							new[] { "Success", "InventoryDelta" },
							null,
							null,
							null)
					}));
		}

		#endregion
	}

	#region Messages

	/// <summary>
	/// The get inventory response.
	/// </summary>
	public sealed partial class GetInventoryResponse : pb::IMessage<GetInventoryResponse>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "success" field.</summary>
		public const int SuccessFieldNumber = 1;

		/// <summary>Field number for the "inventory_delta" field.</summary>
		public const int InventoryDeltaFieldNumber = 2;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<GetInventoryResponse> _parser =
			new pb::MessageParser<GetInventoryResponse>(() => new GetInventoryResponse());

		#endregion

		#region  Fields

		/// <summary>
		/// The inventory delta_.
		/// </summary>
		private InventoryDelta inventoryDelta_;

		/// <summary>
		/// The success_.
		/// </summary>
		private bool success_;

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="GetInventoryResponse"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public GetInventoryResponse()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="GetInventoryResponse"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public GetInventoryResponse(GetInventoryResponse other) : this()
		{
			success_ = other.success_;
			InventoryDelta = other.inventoryDelta_ != null ? other.InventoryDelta.Clone() : null;
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<GetInventoryResponse> Parser
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
				return global::POGOProtos.Networking.Responses.GetInventoryResponseReflection.Descriptor.MessageTypes[0];
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
		/// Gets or sets the inventory delta.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public InventoryDelta InventoryDelta
		{
			get
			{
				return inventoryDelta_;
			}

			set
			{
				inventoryDelta_ = value;
			}
		}

		#endregion

		#region  Interface Implementations

		/// <summary>
		/// The clone.
		/// </summary>
		/// <returns>
		/// The <see cref="GetInventoryResponse"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public GetInventoryResponse Clone()
		{
			return new GetInventoryResponse(this);
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
		public bool Equals(GetInventoryResponse other)
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

			if (!object.Equals(InventoryDelta, other.InventoryDelta))
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

			if (inventoryDelta_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(InventoryDelta);
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

			if (inventoryDelta_ != null)
			{
				size += 1 + pb::CodedOutputStream.ComputeMessageSize(InventoryDelta);
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
		public void MergeFrom(GetInventoryResponse other)
		{
			if (other == null)
			{
				return;
			}

			if (other.Success != false)
			{
				Success = other.Success;
			}

			if (other.inventoryDelta_ != null)
			{
				if (inventoryDelta_ == null)
				{
					inventoryDelta_ = new global::POGOProtos.Inventory.InventoryDelta();
				}

				InventoryDelta.MergeFrom(other.InventoryDelta);
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
						if (inventoryDelta_ == null)
						{
							inventoryDelta_ = new global::POGOProtos.Inventory.InventoryDelta();
						}

						input.ReadMessage(inventoryDelta_);
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
			return Equals(other as GetInventoryResponse);
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

			if (inventoryDelta_ != null)
			{
				hash ^= InventoryDelta.GetHashCode();
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