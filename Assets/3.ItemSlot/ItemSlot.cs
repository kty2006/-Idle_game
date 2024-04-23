using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;

public class ItemSlot : MonoBehaviour
{
    [SerializeField] private Image slotImg;
    [SerializeField] private int slotCount;
    [SerializeField] private int slotIndex;
    private void Awake()
    {
        CreateSlot();
    }
    private void  CreateSlot()
    {
        for (int i = 0; i < slotCount; i++) 
        {
           Instantiate(slotImg).gameObject.transform.SetParent(transform);
        }
    }
}
