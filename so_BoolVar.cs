using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[CreateAssetMenu(fileName = "Boolean Variable", menuName = "Scriptable Objects/Boolean Variable")]
public class so_BoolVar : ScriptableObject, ISerializationCallbackReceiver
{
	public bool InitialValue;

	[NonSerialized]
	public bool RuntimeValue;

	public void OnAfterDeserialize()
	{
		RuntimeValue = InitialValue;
	}

	public void OnBeforeSerialize() { }

}
