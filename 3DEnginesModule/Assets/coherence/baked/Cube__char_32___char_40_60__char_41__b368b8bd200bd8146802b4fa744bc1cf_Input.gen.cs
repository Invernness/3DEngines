// Copyright (c) coherence ApS.
// For all coherence generated code, the coherence SDK license terms apply. See the license file in the coherence Package root folder for more information.

// <auto-generated>
// Generated file. DO NOT EDIT!
// </auto-generated>
namespace Coherence.Generated
{
	using Coherence.ProtocolDef;
	using Coherence.Serializer;
	using Coherence.Brook;
	using UnityEngine;

	public struct Cube__char_32___char_40_60__char_41__b368b8bd200bd8146802b4fa744bc1cf_Input : IEntityInput
	{
		public uint GetComponentType() => Definition.InternalCube__char_32___char_40_60__char_41__b368b8bd200bd8146802b4fa744bc1cf_Input;

		private readonly bool isRemoteInput;

		public Cube__char_32___char_40_60__char_41__b368b8bd200bd8146802b4fa744bc1cf_Input
		(
			bool isRemoteInput
		)
		{
			this.isRemoteInput = isRemoteInput;
		}

		public override string ToString()
		{
			return isRemoteInput
				? $""
				: $"";
		}

		public static void Serialize(Cube__char_32___char_40_60__char_41__b368b8bd200bd8146802b4fa744bc1cf_Input inputData, IOutProtocolBitStream bitStream)
		{
		}

		public static Cube__char_32___char_40_60__char_41__b368b8bd200bd8146802b4fa744bc1cf_Input Deserialize(IInProtocolBitStream bitStream)
		{

			return new Cube__char_32___char_40_60__char_41__b368b8bd200bd8146802b4fa744bc1cf_Input
			(
				true
			);
		}
	}
}
