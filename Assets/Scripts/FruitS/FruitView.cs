using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitView : MonoBehaviour
{
    public FruitTypes fruitType;
    private FruitController fruitController;



    public void SetFruitControllerReference(FruitController fruitController)
    {
        this.fruitController = fruitController;
    }

}
