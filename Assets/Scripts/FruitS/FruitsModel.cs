using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitsModel
{
    //Holds all data related to fruits
    public FruitTypes fruitType { get; }
    public string fruitName { get; private set; }
    private FruitsScriptableObject fruitsScriptableObject;

    public FruitsModel(FruitsScriptableObject fruitsScriptableObject)
    {
        fruitType = fruitsScriptableObject.FruitType;
        fruitName = fruitsScriptableObject.FruitName;
    }

}
