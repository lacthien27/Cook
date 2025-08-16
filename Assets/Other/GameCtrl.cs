using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCtrl : ThienMonoBehaviour
{

  [SerializeField] private static GameCtrl instance;
  public static GameCtrl Instance => instance;// thứ đc lấy ra sài


  [SerializeField] protected SpawnerFoodOrder spawnerFoodOrder;
  public SpawnerFoodOrder SpawnerFoodOrder => spawnerFoodOrder;

  [SerializeField] protected SpawnerNpc spawnerNpc;
  public SpawnerNpc SpawnerNpc => spawnerNpc;


  [SerializeField] protected KitChenCabinet kitChenCabinet;
  public KitChenCabinet KitChenCabinet => kitChenCabinet;

 [SerializeField] protected MouseCtrl  mouseCtrl;
  public MouseCtrl MouseCtrl => mouseCtrl;


[SerializeField] protected SpawnerFoodForCook spawnerFoodForCook;
  public SpawnerFoodForCook SpawnerFoodForCook => spawnerFoodForCook;
[SerializeField ] protected SystemCombineFoodCtrl systemCombineFoodCtrl;
  public SystemCombineFoodCtrl SystemCombineFoodCtrl => systemCombineFoodCtrl;



  protected override void Awake()
  {
    base.Awake();
    if (GameCtrl.instance != null) Debug.LogError("Only 1 GameCtrl allow to exist");
    GameCtrl.instance = this;
  }


  protected override void LoadComponents()
  {
    base.LoadComponents();
    this.LoadSpawnerFoodOrder();
    this.LoadSpawnerNpc();
    this.LoadKitChenCabinet();
    this.LoadMouseCtrl();
    this.LoadSpawnerFoodForCook();
    this.LoadSystemCombineFoodCtrl();


  }

protected virtual void LoadSystemCombineFoodCtrl()
  {

    if (this.systemCombineFoodCtrl != null) return;
    this.systemCombineFoodCtrl = GameCtrl.FindObjectOfType<SystemCombineFoodCtrl>();
    Debug.Log(transform.name + "Load SystemCombineFoodCtrl", gameObject);

  }


  protected virtual void LoadSpawnerFoodForCook()
  {

    if (this.spawnerFoodForCook != null) return;
    this.spawnerFoodForCook = GameCtrl.FindObjectOfType<SpawnerFoodForCook>();
    Debug.Log(transform.name + "Load SpawnerFoodForCook", gameObject);

  }
 
  protected virtual void LoadMouseCtrl()
  {

    if (this.mouseCtrl != null) return;
    this.mouseCtrl = GameCtrl.FindObjectOfType<MouseCtrl>();
    // Debug.Log(transform.name + "Load MouseCtrl", gameObject);

  }
  protected virtual void LoadSpawnerFoodOrder()
  {

    if (this.spawnerFoodOrder != null) return;
    this.spawnerFoodOrder = GameCtrl.FindObjectOfType<SpawnerFoodOrder>();
    Debug.Log(transform.name + "Load SpawnerFoodOrder", gameObject);

  }


  protected virtual void LoadSpawnerNpc()
  {

    if (this.spawnerNpc != null) return;
    this.spawnerNpc = GameCtrl.FindObjectOfType<SpawnerNpc>();
    Debug.Log(transform.name + "Load SpawnerNpc", gameObject);

  }

  protected virtual void LoadKitChenCabinet()
  {

    if (this.kitChenCabinet != null) return;
    this.kitChenCabinet = GameCtrl.FindObjectOfType<KitChenCabinet>();
    Debug.Log(transform.name + "Load KitChenCabinet", gameObject);

  }







}


