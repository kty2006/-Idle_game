using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;


[Serializable]
public struct Item_Data
{
    public int Item_Lv;
    public int Power;
    public Image Item_Image;

}
public class Item : MonoBehaviour
{
    [SerializeField] Item_Data item_Data;
    public static int Start_Lv = GameManager.Instance.Start_Item_Lv;
}
