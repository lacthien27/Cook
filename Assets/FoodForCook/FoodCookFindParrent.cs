using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Video;

public class FoodCookFindParrent : FoodCookAbs
{

  public virtual void FindParrent(Transform obj)
  {
    var objCtrl = obj.GetComponent<FoodCookCtrl>();
    var objPro = objCtrl.FoodCookPro.FoodData;

    foreach (Transform Storage in GameCtrl.Instance.StorageIngredients)
    {
      var StorageCtrl = Storage.transform.GetComponent<StorageIgdCtrl>();
      var StoragePro = StorageCtrl.StorageIgdPro.FoodData;

      if (objPro == StoragePro)
      {
        obj.transform.position = Storage.transform.position;
        Debug.LogWarning("Tìm thấy cha phù hợp: " + Storage.name);
      //  var objMove = objCtrl.FoodCookMove.isCombinedArea = true; // đúng vị trí thì thoy ko quay về chỗ cũ
      
        break;  // thoát khỏi vòng lặp sau khi tìm thấy cha phù hợp
      }

    }
}

  
  






}
