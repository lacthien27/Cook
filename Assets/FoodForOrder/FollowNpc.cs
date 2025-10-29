using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class FollowNpc : FoodOrderAbs


{

    public virtual void FollowTarget(Transform NpcTarget, float offSetY)
    {

        transform.parent.position = new Vector3(NpcTarget.transform.position.x, NpcTarget.transform.position.y + offSetY, 0);

    }
    
    
    
}
