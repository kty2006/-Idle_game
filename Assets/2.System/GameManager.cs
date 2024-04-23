using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : SingleTone<GameManager>
{
    [SerializeField] private int start_Item_Lv;
    public int Start_Item_Lv => start_Item_Lv;
}
