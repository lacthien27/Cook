using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;
using UnityEngine.Video;

public class KittchenScreening : KittchenAbs
{


    [SerializeField] private List<FoodType> listTypeIngre = new List<FoodType>();

    [SerializeField] public List<FoodType> ListTypeIngre => listTypeIngre;


    public virtual void ScreeningFood(Transform obj)
    {
        var objCtrl = obj.GetComponent<FoodCookCtrl>();
        var objPro = objCtrl.FoodCookPro;
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
        var objCtrl = obj.GetComponent<FoodCookCtrl>();
         objCtrl.FoodCookTurnOff.TurnOffWhenCook();

        Debug.LogWarning("loai bo nguyen lieu khong hop le: " + obj.name);
    }
    



}
