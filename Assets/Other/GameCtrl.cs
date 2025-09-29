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


[SerializeField] protected SpawnerIngredient spawnerIngredient;
  public SpawnerIngredient SpawnerIngredient => spawnerIngredient;
[SerializeField ] protected SystemCombineFoodCtrl systemCombineFoodCtrl;
  public SystemCombineFoodCtrl SystemCombineFoodCtrl => systemCombineFoodCtrl;

[SerializeField ] protected  Transform storageIngredients;
  public Transform  StorageIngredients => storageIngredients;

  [SerializeField] protected SpawnerDish spawnerDish;

  public SpawnerDish SpawnerDish => spawnerDish;


  [SerializeField] protected SpawnerSpice spawnerSpice;

  public SpawnerSpice SpawnerSpice => spawnerSpice;


  [SerializeField] protected ArrangeNpc arrangeNpc;
  public ArrangeNpc ArrangeNpc => arrangeNpc; 



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
    this.LoadSpawnerIngredient();
    this.LoadSystemCombineFoodCtrl();
    this.LoadStorageIngredients();
    this.LoadSpawnerDish();
    this.LoadSpawnerSpice();
    this.LoadArrangeNpc();
    


  }

  protected virtual void LoadArrangeNpc()
  {
    if (arrangeNpc != null) return;
    this.arrangeNpc = GameCtrl.FindObjectOfType<ArrangeNpc>();
    Debug.Log(transform.name + "Load ArrangeNpc", gameObject);
  }

  protected virtual void LoadSpawnerSpice()
  {
    if (spawnerSpice != null) return;
    this.spawnerSpice = GameCtrl.FindObjectOfType<SpawnerSpice>();
    Debug.Log(transform.name + "Load SpawnerSpice", gameObject);
  }


  protected virtual void LoadSpawnerDish()
  {
    if (spawnerDish != null) return;
    this.spawnerDish = GameCtrl.FindObjectOfType<SpawnerDish>();
    Debug.Log(transform.name + "Load SpawnerDish", gameObject);
  }

  protected virtual void LoadStorageIngredients()
  {

    if (storageIngredients != null) return;
    storageIngredients = GameObject.Find("StorageIngredients").transform;
    Debug.Log(transform.name + "Load StorageIngredients", gameObject);


  }


  protected virtual void LoadSystemCombineFoodCtrl()
  {

    if (this.systemCombineFoodCtrl != null) return;
    this.systemCombineFoodCtrl = GameCtrl.FindObjectOfType<SystemCombineFoodCtrl>();
    Debug.Log(transform.name + "Load SystemCombineFoodCtrl", gameObject);

  }


  protected virtual void LoadSpawnerIngredient()
  {

    if (this.spawnerIngredient != null) return;
    this.spawnerIngredient = GameCtrl.FindObjectOfType<SpawnerIngredient>();
    Debug.Log(transform.name + "Load SpawnerIngredient", gameObject);

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


