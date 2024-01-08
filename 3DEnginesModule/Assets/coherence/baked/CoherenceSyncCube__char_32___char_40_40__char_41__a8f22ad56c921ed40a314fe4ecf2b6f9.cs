// Copyright (c) coherence ApS.
// For all coherence generated code, the coherence SDK license terms apply. See the license file in the coherence Package root folder for more information.

// <auto-generated>
// Generated file. DO NOT EDIT!
// </auto-generated>
namespace Coherence.Generated
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using UnityEngine;
	using Coherence.Toolkit;
	using Coherence.Toolkit.Bindings;
	using Coherence.Entity;
	using Coherence.ProtocolDef;
	using Coherence.Brook;
	using Coherence.Toolkit.Bindings.ValueBindings;
	using Coherence.Toolkit.Bindings.TransformBindings;
	using Coherence.Connection;
	using Coherence.Log;
	using Logger = Coherence.Log.Logger;
	using UnityEngine.Scripting;

	public class Binding_a8f22ad56c921ed40a314fe4ecf2b6f9_293fdce0_d03e_46ac_b70e_13d4bf97fb1c : PositionBinding
	{
		public override string CoherenceComponentName => "WorldPosition";

		public override uint FieldMask => 0b00000000000000000000000000000001;

		public override Vector3 Value
		{
			get { return (UnityEngine.Vector3)(coherenceSync.coherencePosition); }
			set { coherenceSync.coherencePosition = (UnityEngine.Vector3)(value); }
		}

		protected override Vector3 ReadComponentData(ICoherenceComponentData coherenceComponent, Vector3 floatingOriginDelta)
		{
			var value = ((WorldPosition)coherenceComponent).value;
			if (!coherenceSync.HasParentWithCoherenceSync)
            {
                value += floatingOriginDelta;
            }
			return value;
		}
		
		public override ICoherenceComponentData WriteComponentData(ICoherenceComponentData coherenceComponent, double time)
		{
			var update = (WorldPosition)coherenceComponent;
			if (RuntimeInterpolationSettings.IsInterpolationNone) 
			{
				update.value = Value;
			}
			else 
			{
				update.value = GetInterpolatedAt(time);
			}
			return update;
		}

		public override ICoherenceComponentData CreateComponentData()
		{
			return new WorldPosition();
		}
	}


	[Preserve]
	public class CoherenceSyncCube__char_32___char_40_40__char_41__a8f22ad56c921ed40a314fe4ecf2b6f9 : CoherenceSyncBaked
	{
		private SerializeEntityID entityId;
		private Logger logger = Log.GetLogger<CoherenceSyncCube__char_32___char_40_40__char_41__a8f22ad56c921ed40a314fe4ecf2b6f9>();

		// Cached targets for commands		
		private global::Cube Cube__char_32___char_40_40__char_41__a8f22ad56c921ed40a314fe4ecf2b6f9_Cube__char_46_NonHover_b40a91d1_bb2d_47e0_a792_5a2a43c88d29_CommandTarget;		
		private global::Cube Cube__char_32___char_40_40__char_41__a8f22ad56c921ed40a314fe4ecf2b6f9_Cube__char_46_OnHit_dc24ef4f_c4f8_4a19_9aa4_12ba9c996443_CommandTarget;		
		private global::Cube Cube__char_32___char_40_40__char_41__a8f22ad56c921ed40a314fe4ecf2b6f9_Cube__char_46_OnHover_d059d81d_990f_4266_9b43_28fdc813abbf_CommandTarget;
		private InputBuffer<Cube__char_32___char_40_40__char_41__a8f22ad56c921ed40a314fe4ecf2b6f9_Input> inputBuffer;
		private Cube__char_32___char_40_40__char_41__a8f22ad56c921ed40a314fe4ecf2b6f9_Input currentInput;
		private long lastAddedFrame = -1;
		private CoherenceInput coherenceInput;
		private long currentSimulationFrame => coherenceInput.CurrentSimulationFrame;

		private IClient client;
		private CoherenceBridge bridge;

		private readonly Dictionary<string, Binding> bakedValueBindings = new Dictionary<string, Binding>()
		{
			["293fdce0-d03e-46ac-b70e-13d4bf97fb1c"] = new Binding_a8f22ad56c921ed40a314fe4ecf2b6f9_293fdce0_d03e_46ac_b70e_13d4bf97fb1c(),
		};

		private Dictionary<string, Action<CommandBinding, CommandsHandler>> bakedCommandBindings =
			new Dictionary<string, Action<CommandBinding, CommandsHandler>>();

		public CoherenceSyncCube__char_32___char_40_40__char_41__a8f22ad56c921ed40a314fe4ecf2b6f9()
		{
			bakedCommandBindings.Add("b40a91d1-bb2d-47e0-a792-5a2a43c88d29", BakeCommandBinding_Cube__char_32___char_40_40__char_41__a8f22ad56c921ed40a314fe4ecf2b6f9_Cube__char_46_NonHover_b40a91d1_bb2d_47e0_a792_5a2a43c88d29);
			bakedCommandBindings.Add("dc24ef4f-c4f8-4a19-9aa4-12ba9c996443", BakeCommandBinding_Cube__char_32___char_40_40__char_41__a8f22ad56c921ed40a314fe4ecf2b6f9_Cube__char_46_OnHit_dc24ef4f_c4f8_4a19_9aa4_12ba9c996443);
			bakedCommandBindings.Add("d059d81d-990f-4266-9b43-28fdc813abbf", BakeCommandBinding_Cube__char_32___char_40_40__char_41__a8f22ad56c921ed40a314fe4ecf2b6f9_Cube__char_46_OnHover_d059d81d_990f_4266_9b43_28fdc813abbf);
		}

		public override Binding BakeValueBinding(Binding valueBinding)
		{
			if (bakedValueBindings.TryGetValue(valueBinding.guid, out var bakedBinding))
			{
				valueBinding.CloneTo(bakedBinding);
				return bakedBinding;
			}

			return null;
		}

		public override void BakeCommandBinding(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
			if (bakedCommandBindings.TryGetValue(commandBinding.guid, out var commandBindingBaker))
			{
				commandBindingBaker.Invoke(commandBinding, commandsHandler);
			}
		}
		private void BakeCommandBinding_Cube__char_32___char_40_40__char_41__a8f22ad56c921ed40a314fe4ecf2b6f9_Cube__char_46_NonHover_b40a91d1_bb2d_47e0_a792_5a2a43c88d29(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
			Cube__char_32___char_40_40__char_41__a8f22ad56c921ed40a314fe4ecf2b6f9_Cube__char_46_NonHover_b40a91d1_bb2d_47e0_a792_5a2a43c88d29_CommandTarget = (global::Cube)commandBinding.UnityComponent;
			commandsHandler.AddBakedCommand("Cube.NonHover", "()",
				SendCommand_Cube__char_32___char_40_40__char_41__a8f22ad56c921ed40a314fe4ecf2b6f9_Cube__char_46_NonHover_b40a91d1_bb2d_47e0_a792_5a2a43c88d29, ReceiveLocalCommand_Cube__char_32___char_40_40__char_41__a8f22ad56c921ed40a314fe4ecf2b6f9_Cube__char_46_NonHover_b40a91d1_bb2d_47e0_a792_5a2a43c88d29, MessageTarget.All, Cube__char_32___char_40_40__char_41__a8f22ad56c921ed40a314fe4ecf2b6f9_Cube__char_46_NonHover_b40a91d1_bb2d_47e0_a792_5a2a43c88d29_CommandTarget,false);
		}
		private void BakeCommandBinding_Cube__char_32___char_40_40__char_41__a8f22ad56c921ed40a314fe4ecf2b6f9_Cube__char_46_OnHit_dc24ef4f_c4f8_4a19_9aa4_12ba9c996443(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
			Cube__char_32___char_40_40__char_41__a8f22ad56c921ed40a314fe4ecf2b6f9_Cube__char_46_OnHit_dc24ef4f_c4f8_4a19_9aa4_12ba9c996443_CommandTarget = (global::Cube)commandBinding.UnityComponent;
			commandsHandler.AddBakedCommand("Cube.OnHit", "()",
				SendCommand_Cube__char_32___char_40_40__char_41__a8f22ad56c921ed40a314fe4ecf2b6f9_Cube__char_46_OnHit_dc24ef4f_c4f8_4a19_9aa4_12ba9c996443, ReceiveLocalCommand_Cube__char_32___char_40_40__char_41__a8f22ad56c921ed40a314fe4ecf2b6f9_Cube__char_46_OnHit_dc24ef4f_c4f8_4a19_9aa4_12ba9c996443, MessageTarget.All, Cube__char_32___char_40_40__char_41__a8f22ad56c921ed40a314fe4ecf2b6f9_Cube__char_46_OnHit_dc24ef4f_c4f8_4a19_9aa4_12ba9c996443_CommandTarget,false);
		}
		private void BakeCommandBinding_Cube__char_32___char_40_40__char_41__a8f22ad56c921ed40a314fe4ecf2b6f9_Cube__char_46_OnHover_d059d81d_990f_4266_9b43_28fdc813abbf(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
			Cube__char_32___char_40_40__char_41__a8f22ad56c921ed40a314fe4ecf2b6f9_Cube__char_46_OnHover_d059d81d_990f_4266_9b43_28fdc813abbf_CommandTarget = (global::Cube)commandBinding.UnityComponent;
			commandsHandler.AddBakedCommand("Cube.OnHover", "()",
				SendCommand_Cube__char_32___char_40_40__char_41__a8f22ad56c921ed40a314fe4ecf2b6f9_Cube__char_46_OnHover_d059d81d_990f_4266_9b43_28fdc813abbf, ReceiveLocalCommand_Cube__char_32___char_40_40__char_41__a8f22ad56c921ed40a314fe4ecf2b6f9_Cube__char_46_OnHover_d059d81d_990f_4266_9b43_28fdc813abbf, MessageTarget.All, Cube__char_32___char_40_40__char_41__a8f22ad56c921ed40a314fe4ecf2b6f9_Cube__char_46_OnHover_d059d81d_990f_4266_9b43_28fdc813abbf_CommandTarget,false);
		}

		public override List<ICoherenceComponentData> CreateEntity(bool usesLodsAtRuntime, string archetypeName)
		{
			if (!usesLodsAtRuntime)
			{
				return null;
			}

			if (Archetypes.IndexForName.TryGetValue(archetypeName, out int archetypeIndex))
			{
				var components = new List<ICoherenceComponentData>()
				{
					new ArchetypeComponent
					{
						index = archetypeIndex
					}
				};

				return components;
			}
	
			logger.Warning($"Unable to find archetype {archetypeName} in dictionary. Please, bake manually (coherence > Bake)");

			return null;
		}

		public override void Dispose()
		{
			if (bridge != null)
			{
				bridge.OnLateFixedNetworkUpdate -= SendInputState;
			}
		}

		public override void Initialize(SerializeEntityID entityId, CoherenceBridge bridge, IClient client, CoherenceInput input, Logger logger)
		{
			this.logger = logger.With<CoherenceSyncCube__char_32___char_40_40__char_41__a8f22ad56c921ed40a314fe4ecf2b6f9>();
			this.bridge = bridge;
			this.entityId = entityId;
			this.client = client;
			coherenceInput = input;
			inputBuffer = new InputBuffer<Cube__char_32___char_40_40__char_41__a8f22ad56c921ed40a314fe4ecf2b6f9_Input>(coherenceInput.InitialBufferSize, coherenceInput.InitialInputDelay, coherenceInput.UseFixedSimulationFrames);

			coherenceInput.internalSetButton = SetButton;
			coherenceInput.internalSetAxis = SetAxis;
			coherenceInput.internalSetAxis2D = SetAxis2D;
			coherenceInput.internalSetAxis3D = SetAxis3D;
			coherenceInput.internalSetRotation = SetRotation;
			coherenceInput.internalSetInteger = SetInteger;
			coherenceInput.internalSetString = SetString;
			coherenceInput.internalGetButton = GetButton;
			coherenceInput.internalGetAxis = GetAxis;
			coherenceInput.internalGetAxis2D = GetAxis2D;
			coherenceInput.internalGetAxis3D = GetAxis3D;
			coherenceInput.internalGetRotation = GetRotation;
			coherenceInput.internalGetInteger = GetInteger;
			coherenceInput.internalGetString = GetString;
			coherenceInput.internalRequestBuffer = () => inputBuffer;
			coherenceInput.internalOnInputReceived += OnInput;
			coherenceInput.internalRequestBuffer = () => inputBuffer;

			if (coherenceInput.UseFixedSimulationFrames)
			{
				bridge.OnLateFixedNetworkUpdate += SendInputState;
			}
		}
		void SendCommand_Cube__char_32___char_40_40__char_41__a8f22ad56c921ed40a314fe4ecf2b6f9_Cube__char_46_NonHover_b40a91d1_bb2d_47e0_a792_5a2a43c88d29(MessageTarget target, object[] args)
		{
			var command = new Cube__char_32___char_40_40__char_41__a8f22ad56c921ed40a314fe4ecf2b6f9_Cube__char_46_NonHover_b40a91d1_bb2d_47e0_a792_5a2a43c88d29();
			client.SendCommand(command, target, entityId);
		}

		void ReceiveLocalCommand_Cube__char_32___char_40_40__char_41__a8f22ad56c921ed40a314fe4ecf2b6f9_Cube__char_46_NonHover_b40a91d1_bb2d_47e0_a792_5a2a43c88d29(MessageTarget target, object[] args)
		{
			var command = new Cube__char_32___char_40_40__char_41__a8f22ad56c921ed40a314fe4ecf2b6f9_Cube__char_46_NonHover_b40a91d1_bb2d_47e0_a792_5a2a43c88d29();
			ReceiveCommand_Cube__char_32___char_40_40__char_41__a8f22ad56c921ed40a314fe4ecf2b6f9_Cube__char_46_NonHover_b40a91d1_bb2d_47e0_a792_5a2a43c88d29(command);
		}

		void ReceiveCommand_Cube__char_32___char_40_40__char_41__a8f22ad56c921ed40a314fe4ecf2b6f9_Cube__char_46_NonHover_b40a91d1_bb2d_47e0_a792_5a2a43c88d29(Cube__char_32___char_40_40__char_41__a8f22ad56c921ed40a314fe4ecf2b6f9_Cube__char_46_NonHover_b40a91d1_bb2d_47e0_a792_5a2a43c88d29 command)
		{
			var target = Cube__char_32___char_40_40__char_41__a8f22ad56c921ed40a314fe4ecf2b6f9_Cube__char_46_NonHover_b40a91d1_bb2d_47e0_a792_5a2a43c88d29_CommandTarget;
			target.NonHover();
		}
		void SendCommand_Cube__char_32___char_40_40__char_41__a8f22ad56c921ed40a314fe4ecf2b6f9_Cube__char_46_OnHit_dc24ef4f_c4f8_4a19_9aa4_12ba9c996443(MessageTarget target, object[] args)
		{
			var command = new Cube__char_32___char_40_40__char_41__a8f22ad56c921ed40a314fe4ecf2b6f9_Cube__char_46_OnHit_dc24ef4f_c4f8_4a19_9aa4_12ba9c996443();
			client.SendCommand(command, target, entityId);
		}

		void ReceiveLocalCommand_Cube__char_32___char_40_40__char_41__a8f22ad56c921ed40a314fe4ecf2b6f9_Cube__char_46_OnHit_dc24ef4f_c4f8_4a19_9aa4_12ba9c996443(MessageTarget target, object[] args)
		{
			var command = new Cube__char_32___char_40_40__char_41__a8f22ad56c921ed40a314fe4ecf2b6f9_Cube__char_46_OnHit_dc24ef4f_c4f8_4a19_9aa4_12ba9c996443();
			ReceiveCommand_Cube__char_32___char_40_40__char_41__a8f22ad56c921ed40a314fe4ecf2b6f9_Cube__char_46_OnHit_dc24ef4f_c4f8_4a19_9aa4_12ba9c996443(command);
		}

		void ReceiveCommand_Cube__char_32___char_40_40__char_41__a8f22ad56c921ed40a314fe4ecf2b6f9_Cube__char_46_OnHit_dc24ef4f_c4f8_4a19_9aa4_12ba9c996443(Cube__char_32___char_40_40__char_41__a8f22ad56c921ed40a314fe4ecf2b6f9_Cube__char_46_OnHit_dc24ef4f_c4f8_4a19_9aa4_12ba9c996443 command)
		{
			var target = Cube__char_32___char_40_40__char_41__a8f22ad56c921ed40a314fe4ecf2b6f9_Cube__char_46_OnHit_dc24ef4f_c4f8_4a19_9aa4_12ba9c996443_CommandTarget;
			target.OnHit();
		}
		void SendCommand_Cube__char_32___char_40_40__char_41__a8f22ad56c921ed40a314fe4ecf2b6f9_Cube__char_46_OnHover_d059d81d_990f_4266_9b43_28fdc813abbf(MessageTarget target, object[] args)
		{
			var command = new Cube__char_32___char_40_40__char_41__a8f22ad56c921ed40a314fe4ecf2b6f9_Cube__char_46_OnHover_d059d81d_990f_4266_9b43_28fdc813abbf();
			client.SendCommand(command, target, entityId);
		}

		void ReceiveLocalCommand_Cube__char_32___char_40_40__char_41__a8f22ad56c921ed40a314fe4ecf2b6f9_Cube__char_46_OnHover_d059d81d_990f_4266_9b43_28fdc813abbf(MessageTarget target, object[] args)
		{
			var command = new Cube__char_32___char_40_40__char_41__a8f22ad56c921ed40a314fe4ecf2b6f9_Cube__char_46_OnHover_d059d81d_990f_4266_9b43_28fdc813abbf();
			ReceiveCommand_Cube__char_32___char_40_40__char_41__a8f22ad56c921ed40a314fe4ecf2b6f9_Cube__char_46_OnHover_d059d81d_990f_4266_9b43_28fdc813abbf(command);
		}

		void ReceiveCommand_Cube__char_32___char_40_40__char_41__a8f22ad56c921ed40a314fe4ecf2b6f9_Cube__char_46_OnHover_d059d81d_990f_4266_9b43_28fdc813abbf(Cube__char_32___char_40_40__char_41__a8f22ad56c921ed40a314fe4ecf2b6f9_Cube__char_46_OnHover_d059d81d_990f_4266_9b43_28fdc813abbf command)
		{
			var target = Cube__char_32___char_40_40__char_41__a8f22ad56c921ed40a314fe4ecf2b6f9_Cube__char_46_OnHover_d059d81d_990f_4266_9b43_28fdc813abbf_CommandTarget;
			target.OnHover();
		}

		public override void ReceiveCommand(IEntityCommand command)
		{
			switch(command)
			{
				case Cube__char_32___char_40_40__char_41__a8f22ad56c921ed40a314fe4ecf2b6f9_Cube__char_46_NonHover_b40a91d1_bb2d_47e0_a792_5a2a43c88d29 castedCommand:
					ReceiveCommand_Cube__char_32___char_40_40__char_41__a8f22ad56c921ed40a314fe4ecf2b6f9_Cube__char_46_NonHover_b40a91d1_bb2d_47e0_a792_5a2a43c88d29(castedCommand);
					break;
				case Cube__char_32___char_40_40__char_41__a8f22ad56c921ed40a314fe4ecf2b6f9_Cube__char_46_OnHit_dc24ef4f_c4f8_4a19_9aa4_12ba9c996443 castedCommand:
					ReceiveCommand_Cube__char_32___char_40_40__char_41__a8f22ad56c921ed40a314fe4ecf2b6f9_Cube__char_46_OnHit_dc24ef4f_c4f8_4a19_9aa4_12ba9c996443(castedCommand);
					break;
				case Cube__char_32___char_40_40__char_41__a8f22ad56c921ed40a314fe4ecf2b6f9_Cube__char_46_OnHover_d059d81d_990f_4266_9b43_28fdc813abbf castedCommand:
					ReceiveCommand_Cube__char_32___char_40_40__char_41__a8f22ad56c921ed40a314fe4ecf2b6f9_Cube__char_46_OnHover_d059d81d_990f_4266_9b43_28fdc813abbf(castedCommand);
					break;
				default:
					logger.Warning($"[CoherenceSyncCube__char_32___char_40_40__char_41__a8f22ad56c921ed40a314fe4ecf2b6f9] Unhandled command: {command.GetType()}.");
					break;
			}
		}

		private void SetButton(string name, bool value)
		{
			switch(name)
			{
				default:
					logger.Error($"No input button of name: {name}");
					break;
			}
		}

		private void SetAxis(string name, float value)
		{
			switch(name)
			{
			default:
				logger.Error($"No input axis of name: {name}");
				break;
			}
		}

		private void SetAxis2D(string name, Vector2 value)
		{
			switch(name)
			{
			default:
				logger.Error($"No input axis2D of name: {name}");
				break;
			}
		}

		private void SetAxis3D(string name, Vector3 value)
		{
			switch(name)
			{
			default:
				logger.Error($"No input axis3D of name: {name}");
				break;
			}
		}

		private void SetRotation(string name, Quaternion value)
		{
			switch(name)
			{
			default:
				logger.Error($"No input rotation of name: {name}");
				break;
			}
		}

		private void SetInteger(string name, int value)
		{
			switch(name)
			{
			default:
				logger.Error($"No input integer of name: {name}");
				break;
			}
		}

		private void SetString(string name, string value)
		{
			switch(name)
			{
				default:
					logger.Error($"No input button of name: {name}");
					break;
			}
		}

		public override void SendInputState()
		{
			if (!coherenceInput.IsProducer || !coherenceInput.IsReadyToProcessInputs || !coherenceInput.IsInputOwner)
			{
				return;
			}

			if (lastAddedFrame != currentSimulationFrame)
			{
				inputBuffer.AddInput(currentInput, currentSimulationFrame);
				lastAddedFrame = currentSimulationFrame;
			}

			while (inputBuffer.DequeueForSending(currentSimulationFrame, out long frameToSend, out Cube__char_32___char_40_40__char_41__a8f22ad56c921ed40a314fe4ecf2b6f9_Input input, out bool differs))
			{
				coherenceInput.DebugOnInputSent(frameToSend, input);
				client.SendInput(input, frameToSend, entityId);
			}
		}

		private bool ShouldPollCurrentInput(long frame)
		{
			return coherenceInput.IsProducer && coherenceInput.Delay == 0 && frame == currentSimulationFrame;
		}

		private bool GetButton(string name, long? simulationFrame)
		{
			long frame = simulationFrame.GetValueOrDefault(currentSimulationFrame);

			switch(name)
			{
				default:
					logger.Error($"No input button of name: {name}");
					break;
			}

			return false;
		}

		private float GetAxis(string name, long? simulationFrame)
		{
			long frame = simulationFrame.GetValueOrDefault(currentSimulationFrame);

			switch(name)
			{
			default:
				logger.Error($"No input axis of name: {name}");
				break;
			}

			return 0f;
		}

		private Vector2 GetAxis2D(string name, long? simulationFrame)
		{
			long frame = simulationFrame.GetValueOrDefault(currentSimulationFrame);

			switch(name)
			{
			default:
				logger.Error($"No input axis2D of name: {name}");
				break;
			}

			return Vector2.zero;
		}

		private Vector3 GetAxis3D(string name, long? simulationFrame)
		{
			long frame = simulationFrame.GetValueOrDefault(currentSimulationFrame);

			switch(name)
			{
			default:
				logger.Error($"No input axis3D of name: {name}");
				break;
			}

			return Vector3.zero;
		}

		private Quaternion GetRotation(string name, long? simulationFrame)
		{
			long frame = simulationFrame.GetValueOrDefault(currentSimulationFrame);

			switch(name)
			{
			default:
				logger.Error($"No input rotation of name: {name}");
				break;
			}

			return Quaternion.identity;
		}

		private int GetInteger(string name, long? simulationFrame)
		{
			long frame = simulationFrame.GetValueOrDefault(currentSimulationFrame);

			switch(name)
			{
			default:
				logger.Error($"No input integer of name: {name}");
				break;
			}

			return default;
		}

		private string GetString(string name, long? simulationFrame)
		{
			long frame = simulationFrame.GetValueOrDefault(currentSimulationFrame);

			switch(name)
			{
				default:
					logger.Error($"No input button of name: {name}");
					break;
			}

			return null;
		}

		private void OnInput(IEntityInput entityInput, long frame)
		{
			var input = (Cube__char_32___char_40_40__char_41__a8f22ad56c921ed40a314fe4ecf2b6f9_Input)entityInput;
			coherenceInput.DebugOnInputReceived(frame, entityInput);
			inputBuffer.ReceiveInput(input, frame);
		}
	}
}
