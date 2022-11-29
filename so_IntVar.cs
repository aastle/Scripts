using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[CreateAssetMenu(fileName = "Int Variable", menuName = "Scriptable Objects/Int Variable")]
public class so_IntVar : ScriptableObject, ISerializationCallbackReceiver
{
	public Int32 InitialValue;

	[NonSerialized]
	public Int32 RuntimeValue;

	public void OnAfterDeserialize()
	{
		RuntimeValue = InitialValue;
	}

	public void OnBeforeSerialize() { }

}
