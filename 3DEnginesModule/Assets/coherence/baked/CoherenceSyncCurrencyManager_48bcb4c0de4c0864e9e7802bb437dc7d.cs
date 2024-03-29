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

	public class Binding_48bcb4c0de4c0864e9e7802bb437dc7d_99379913_8d90_461d_aa3d_ecf57ffeec4a : PositionBinding
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

	public class Binding_48bcb4c0de4c0864e9e7802bb437dc7d_9c3e7dbe_7084_45bc_99f6_f6b33812f60b : IntBinding
	{
		private global::CurrencyManager CastedUnityComponent;

		protected override void OnBindingCloned()
		{
			CastedUnityComponent = (global::CurrencyManager)UnityComponent;
		}
		public override string CoherenceComponentName => "CurrencyManager_48bcb4c0de4c0864e9e7802bb437dc7d_CurrencyManager_509801874849245739";

		public override uint FieldMask => 0b00000000000000000000000000000001;

		public override int Value
		{
			get { return (System.Int32)(CastedUnityComponent.towerCredits); }
			set { CastedUnityComponent.towerCredits = (System.Int32)(value); }
		}

		protected override int ReadComponentData(ICoherenceComponentData coherenceComponent, Vector3 floatingOriginDelta)
		{
			var value = ((CurrencyManager_48bcb4c0de4c0864e9e7802bb437dc7d_CurrencyManager_509801874849245739)coherenceComponent).towerCredits;
			return value;
		}
		
		public override ICoherenceComponentData WriteComponentData(ICoherenceComponentData coherenceComponent, double time)
		{
			var update = (CurrencyManager_48bcb4c0de4c0864e9e7802bb437dc7d_CurrencyManager_509801874849245739)coherenceComponent;
			if (RuntimeInterpolationSettings.IsInterpolationNone) 
			{
				update.towerCredits = Value;
			}
			else 
			{
				update.towerCredits = GetInterpolatedAt(time);
			}
			return update;
		}

		public override ICoherenceComponentData CreateComponentData()
		{
			return new CurrencyManager_48bcb4c0de4c0864e9e7802bb437dc7d_CurrencyManager_509801874849245739();
		}
	}

	public class Binding_48bcb4c0de4c0864e9e7802bb437dc7d_6977c437_08da_4765_aa02_a70e97420f43 : IntBinding
	{
		private global::CurrencyManager CastedUnityComponent;

		protected override void OnBindingCloned()
		{
			CastedUnityComponent = (global::CurrencyManager)UnityComponent;
		}
		public override string CoherenceComponentName => "CurrencyManager_48bcb4c0de4c0864e9e7802bb437dc7d_CurrencyManager_509801874849245739";

		public override uint FieldMask => 0b00000000000000000000000000000010;

		public override int Value
		{
			get { return (System.Int32)(CastedUnityComponent.enemyCredits); }
			set { CastedUnityComponent.enemyCredits = (System.Int32)(value); }
		}

		protected override int ReadComponentData(ICoherenceComponentData coherenceComponent, Vector3 floatingOriginDelta)
		{
			var value = ((CurrencyManager_48bcb4c0de4c0864e9e7802bb437dc7d_CurrencyManager_509801874849245739)coherenceComponent).enemyCredits;
			return value;
		}
		
		public override ICoherenceComponentData WriteComponentData(ICoherenceComponentData coherenceComponent, double time)
		{
			var update = (CurrencyManager_48bcb4c0de4c0864e9e7802bb437dc7d_CurrencyManager_509801874849245739)coherenceComponent;
			if (RuntimeInterpolationSettings.IsInterpolationNone) 
			{
				update.enemyCredits = Value;
			}
			else 
			{
				update.enemyCredits = GetInterpolatedAt(time);
			}
			return update;
		}

		public override ICoherenceComponentData CreateComponentData()
		{
			return new CurrencyManager_48bcb4c0de4c0864e9e7802bb437dc7d_CurrencyManager_509801874849245739();
		}
	}


	[Preserve]
	public class CoherenceSyncCurrencyManager_48bcb4c0de4c0864e9e7802bb437dc7d : CoherenceSyncBaked
	{
		private SerializeEntityID entityId;
		private Logger logger = Log.GetLogger<CoherenceSyncCurrencyManager_48bcb4c0de4c0864e9e7802bb437dc7d>();

		// Cached targets for commands
		private InputBuffer<CurrencyManager_48bcb4c0de4c0864e9e7802bb437dc7d_Input> inputBuffer;
		private CurrencyManager_48bcb4c0de4c0864e9e7802bb437dc7d_Input currentInput;
		private long lastAddedFrame = -1;
		private CoherenceInput coherenceInput;
		private long currentSimulationFrame => coherenceInput.CurrentSimulationFrame;

		private IClient client;
		private CoherenceBridge bridge;

		private readonly Dictionary<string, Binding> bakedValueBindings = new Dictionary<string, Binding>()
		{
			["99379913-8d90-461d-aa3d-ecf57ffeec4a"] = new Binding_48bcb4c0de4c0864e9e7802bb437dc7d_99379913_8d90_461d_aa3d_ecf57ffeec4a(),
			["9c3e7dbe-7084-45bc-99f6-f6b33812f60b"] = new Binding_48bcb4c0de4c0864e9e7802bb437dc7d_9c3e7dbe_7084_45bc_99f6_f6b33812f60b(),
			["6977c437-08da-4765-aa02-a70e97420f43"] = new Binding_48bcb4c0de4c0864e9e7802bb437dc7d_6977c437_08da_4765_aa02_a70e97420f43(),
		};

		private Dictionary<string, Action<CommandBinding, CommandsHandler>> bakedCommandBindings =
			new Dictionary<string, Action<CommandBinding, CommandsHandler>>();

		public CoherenceSyncCurrencyManager_48bcb4c0de4c0864e9e7802bb437dc7d()
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
			this.logger = logger.With<CoherenceSyncCurrencyManager_48bcb4c0de4c0864e9e7802bb437dc7d>();
			this.bridge = bridge;
			this.entityId = entityId;
			this.client = client;
			coherenceInput = input;
			inputBuffer = new InputBuffer<CurrencyManager_48bcb4c0de4c0864e9e7802bb437dc7d_Input>(coherenceInput.InitialBufferSize, coherenceInput.InitialInputDelay, coherenceInput.UseFixedSimulationFrames);

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
					logger.Warning($"[CoherenceSyncCurrencyManager_48bcb4c0de4c0864e9e7802bb437dc7d] Unhandled command: {command.GetType()}.");
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

			while (inputBuffer.DequeueForSending(currentSimulationFrame, out long frameToSend, out CurrencyManager_48bcb4c0de4c0864e9e7802bb437dc7d_Input input, out bool differs))
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
			var input = (CurrencyManager_48bcb4c0de4c0864e9e7802bb437dc7d_Input)entityInput;
			coherenceInput.DebugOnInputReceived(frame, entityInput);
			inputBuffer.ReceiveInput(input, frame);
		}
	}
}
