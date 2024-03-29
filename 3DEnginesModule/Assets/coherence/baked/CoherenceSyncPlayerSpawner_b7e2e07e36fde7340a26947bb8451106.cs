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

	public class Binding_b7e2e07e36fde7340a26947bb8451106_6140b0bb_19ee_4406_8b34_9a5650ca03d4 : PositionBinding
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
	public class CoherenceSyncPlayerSpawner_b7e2e07e36fde7340a26947bb8451106 : CoherenceSyncBaked
	{
		private SerializeEntityID entityId;
		private Logger logger = Log.GetLogger<CoherenceSyncPlayerSpawner_b7e2e07e36fde7340a26947bb8451106>();

		// Cached targets for commands
		private InputBuffer<PlayerSpawner_b7e2e07e36fde7340a26947bb8451106_Input> inputBuffer;
		private PlayerSpawner_b7e2e07e36fde7340a26947bb8451106_Input currentInput;
		private long lastAddedFrame = -1;
		private CoherenceInput coherenceInput;
		private long currentSimulationFrame => coherenceInput.CurrentSimulationFrame;

		private IClient client;
		private CoherenceBridge bridge;

		private readonly Dictionary<string, Binding> bakedValueBindings = new Dictionary<string, Binding>()
		{
			["6140b0bb-19ee-4406-8b34-9a5650ca03d4"] = new Binding_b7e2e07e36fde7340a26947bb8451106_6140b0bb_19ee_4406_8b34_9a5650ca03d4(),
		};

		private Dictionary<string, Action<CommandBinding, CommandsHandler>> bakedCommandBindings =
			new Dictionary<string, Action<CommandBinding, CommandsHandler>>();

		public CoherenceSyncPlayerSpawner_b7e2e07e36fde7340a26947bb8451106()
		{
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
			this.logger = logger.With<CoherenceSyncPlayerSpawner_b7e2e07e36fde7340a26947bb8451106>();
			this.bridge = bridge;
			this.entityId = entityId;
			this.client = client;
			coherenceInput = input;
			inputBuffer = new InputBuffer<PlayerSpawner_b7e2e07e36fde7340a26947bb8451106_Input>(coherenceInput.InitialBufferSize, coherenceInput.InitialInputDelay, coherenceInput.UseFixedSimulationFrames);

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

		public override void ReceiveCommand(IEntityCommand command)
		{
			switch(command)
			{
				default:
					logger.Warning($"[CoherenceSyncPlayerSpawner_b7e2e07e36fde7340a26947bb8451106] Unhandled command: {command.GetType()}.");
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

			while (inputBuffer.DequeueForSending(currentSimulationFrame, out long frameToSend, out PlayerSpawner_b7e2e07e36fde7340a26947bb8451106_Input input, out bool differs))
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
			var input = (PlayerSpawner_b7e2e07e36fde7340a26947bb8451106_Input)entityInput;
			coherenceInput.DebugOnInputReceived(frame, entityInput);
			inputBuffer.ReceiveInput(input, frame);
		}
	}
}
