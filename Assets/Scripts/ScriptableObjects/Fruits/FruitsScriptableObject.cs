using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="FruitScriptableobject", menuName = "FruitsModel/New-Fruit")]
public class FruitsScriptableObject : ScriptableObject
{
    [Header("Fruit Types")]
    public FruitTypes FruitType;
    public string FruitName;

}
