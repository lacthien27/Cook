using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class FollowNpc : FoodOrderAbs


{

    public virtual void FollowTarget(Transform NpcTarget)
    {
     
        transform.parent.position = NpcTarget.transform.position;

    }
    
}
