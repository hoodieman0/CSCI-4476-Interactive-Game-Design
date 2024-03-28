using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Equipment", menuName = "Pickups/Equipment")]
public class EquipmentSO : PickupSO
{
    public enum EquipmentSlots {HEAD, TORSO, ARMS, LEGS};
    public EquipmentSlots slot;
    public Vector3 posOffset;
    public Vector3 rotOffeset;
}
