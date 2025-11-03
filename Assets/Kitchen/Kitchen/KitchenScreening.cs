using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;
using UnityEngine.Video;

public class KitchenScreening : KitchenAbs
{


    [SerializeField] private List<FoodType> listTypeIngre = new List<FoodType>();

    [SerializeField] public List<FoodType> ListTypeIngre => listTypeIngre;


    public virtual void ScreeningFood(Transform obj)
    {
        var objCtrl = obj.GetComponent<FoodCtrl>();
        var objPro = objCtrl.FoodPro;
        foreach (var type in listTypeIngre)
        {
            if (objPro.FoodData.FoodType == type)
            {
                //       return obj;
                return;

            }
        }

        this.RemoveIngre(objCtrl.transform);
    }

    protected virtual void RemoveIngre(Transform obj)
    {
        var objCtrl = obj.GetComponent<FoodCtrl>();
         objCtrl.FoodTurnOff.TurnOffWhenCook();

        Debug.LogWarning("loai bo nguyen lieu khong hop le: " + obj.name);
    }
    



}
