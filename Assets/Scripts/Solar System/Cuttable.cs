using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cuttable : MonoBehaviour
{
    public GameObject disablableGO;
   public   float   healthPoints    =   100f;
   public void DealDamage(float damage){
        healthPoints -= damage;
        if (healthPoints <= 0){
            ObjectCut();
        }
    }

   public void ObjectCut(){
        // play animation
        // play sound
        disablableGO.SetActive(false);
   }
}
