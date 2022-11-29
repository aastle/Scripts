using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[CreateAssetMenu(fileName = " Item Object", menuName = "Scriptable Objects/Item Object")]
public class ItemScriptableObject : ScriptableObject
{
	public string ItemName;

	public Sprite IconSprite;

	public bool Collected;
}
