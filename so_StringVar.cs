using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[CreateAssetMenu(fileName = "Text Variable", menuName = "Scriptable Objects/Text Variable")]
public class so_StringVar : ScriptableObject, ISerializationCallbackReceiver
{
	public string InitialValue;

	[NonSerialized]
	public string RuntimeValue;

	public void OnAfterDeserialize()
	{
		RuntimeValue = InitialValue;
	}

	public void OnBeforeSerialize() { }

}
