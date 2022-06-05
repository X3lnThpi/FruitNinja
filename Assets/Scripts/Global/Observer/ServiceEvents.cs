using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ServiceEvents 
{
    public ServiceEvents serviceInstance;
    public event Action<Collision> OnGroundHit;

    //Subscription
    public void CallEvent()
    {
        OnGroundHit?.DynamicInvoke();
    }
}
