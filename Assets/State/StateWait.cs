using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class StateWait : StateAbs
{

    [SerializeField] public float timer = 0;

     protected override void OnUpdate()
    {

        this.ExecuteLogic();
    }
    protected virtual void ExecuteLogic()
    {
        this.timer += Time.deltaTime;
        if (timer <1000f && this.stateMachineCtrl.NpcCtrl.NpcReceiveFood.CorrectOrder)  //dưới 4 giây và phải has enough food
        {
        this.stateMachineCtrl.ChangeState(this.stateMachineCtrl.StatePayed);
        this.timer = 0; // reset timer after changing state
        }
        else if(timer>1000f)
        {
            this.timer = 0; // reset timer after changing state
            this.stateMachineCtrl.ChangeState(this.stateMachineCtrl.StateAngry);
        }   

    }
    



}
 
 
 
 







 
 

 

 /**   [SerializeField]  protected  bool isNotifying = false;

                                  public static event Action OnImpactSignal;  //only 1 signal give to  Raycast


                                  protected override void Awake() 
                                  {
                                          this.listIngredientImpact = this.stateMachineCtrl.BrickCtrl.ModelCompleteCtrl.ingredientImpacts;

                                  }

                               protected override void OnEnter()  //  it call 3 time  -> call 1 time
                               {
                                   this.ChangeAttributeWhenStop();          
                                    OnImpactSignal?.Invoke();  // give signal for raycast 

                               }


                               protected  virtual void  ChangeAttributeWhenStop()
                               {
                                   if(listIngredientImpact==null) return;
                                   foreach (IngredientImpact impact in this.listIngredientImpact)
                                   {  
                                     impact.Collider2D.isTrigger=false;  // raycast not fire object that isTrigger==true
                                     impact.Collider2D.gameObject.layer=LayerMask.NameToLayer("impacted");
                                    
                                   }
                                   


                            
                                 
                               }



                            **/


    /**  protected override void OnUpdate() //place implement  logic
      
      {
          
          foreach (IngredientImpact impact in this.listIngredientImpact)
          {  
              if(impact.listObjImpact!=null) return;
              Debug.LogWarning("fall");
           
          }
          this.OnStateExit();
      }

      protected override void OnExit()
      {
          //place effect
          // signal due to stop rotation object

     this.ChangeAttributeWhenFall();
      } 



       protected  virtual void  ChangeAttributeWhenFall()
      {
         foreach (IngredientImpact impact in this.listIngredientImpact)
          {
                  
            if(listIngredientImpact==null) return;
            impact.Collider2D.isTrigger=true;  // raycast not fire object that isTrigger==true
              impact.Collider2D.gameObject.layer=LayerMask.NameToLayer("Default");

          }
      }

}**/



