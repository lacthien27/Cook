using System.Collections;
using System.Collections.Generic;
using Mono.Cecil.Cil;
using UnityEngine;

public class StateMachineCtrl : NpcAbs
{

    
    [SerializeField] public StateAbs  currentState;        //current state in real time
  [SerializeField] protected StatePayed statePayed;
  public StatePayed StatePayed=> statePayed;

  [SerializeField] protected StateWait stateWait;
  public StateWait StateWait=> stateWait;

   [SerializeField] protected StateOrder stateOrder;
  public StateOrder StateOrder=> stateOrder;
  
  [SerializeField] protected StateAngry stateAngry;
  public StateAngry StateAngry=> stateAngry;

 [SerializeField] protected StateLeave stateLeave;
  public StateLeave StateLeave=> stateLeave;

   [SerializeField] protected StateMove stateMove;
  public StateMove StateMove=> stateMove;
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadStateWait();
        this.LoadStatePayed();
        this.LoadStateOrder();
        this.LoadStateAngry();
        this.LoadStateLeave();
        this.LoadStateMove();
        this.LoadState();
    }

      protected virtual void LoadStateWait()
    {
        if(this.stateWait !=null) return;
        this.stateWait =transform.GetComponentInChildren<StateWait>();
        Debug.LogWarning(transform.name +" : LoadStateWait ",gameObject);
    }
    
       protected virtual void LoadStateOrder()
    {
        if(this.stateOrder !=null) return;
        this.stateOrder =transform.GetComponentInChildren<StateOrder>();
        Debug.LogWarning(transform.name +" : Load StateOrder ",gameObject);
    }

      protected virtual void LoadStatePayed()
    {
        if (this.statePayed != null) return;
        this.statePayed = transform.GetComponentInChildren<StatePayed>();
        Debug.LogWarning(transform.name + " : Load StatePayed ", gameObject);
    }
    
          protected virtual void LoadStateAngry()
    {
        if (this.stateAngry != null) return;
        this.stateAngry = transform.GetComponentInChildren<StateAngry>();
        Debug.LogWarning(transform.name + " : Load StateAngry ", gameObject);
    }
    
        protected virtual void LoadStateLeave()
    {
        if (this.stateLeave != null) return;
        this.stateLeave = transform.GetComponentInChildren<StateLeave>();
        Debug.LogWarning(transform.name + " : Load StateLeave ", gameObject);
    }

    protected virtual void LoadStateMove()
    {
        if (this.stateMove != null) return;
        this.stateMove = transform.GetComponentInChildren<StateMove>();
        Debug.LogWarning(transform.name + " : Load StateMove ", gameObject);
    }
    

    protected virtual void LoadState() // 
    {
        if (this.currentState != null) return;
    }

    protected override void Start()
    {
        ChangeState(stateMove);
    }

    protected virtual void Update()
    {

        if (currentState != null)
        {
            currentState.OnStateUpdate();
        }
    }

    public void ChangeState(StateAbs newState)
    {



        if (currentState != null)
        {
            currentState.OnStateExit();
        }
        currentState = newState;
        currentState.OnStateEnter(this);
//       Debug.LogWarning(currentState);
                      

       
    }

   

}

