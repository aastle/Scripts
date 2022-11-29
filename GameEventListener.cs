using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Events;

public class GameEventListener : MonoBehaviour
{
    public so_Event ScrObjEvent;
    public UnityEvent Response;

    private void OnEnable()
    { ScrObjEvent.RegisterListener(this); }

    private void OnDisable()
    { ScrObjEvent.UnregisterListener(this); }

    public void OnEventRaised()
    { Response.Invoke(); }
}