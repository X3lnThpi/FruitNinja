using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitController : MonoBehaviour
{
    public FruitsModel fruitsModel;
    public FruitView fruitView { get; }
    Rigidbody fruitRBD; //Fruit RigidBody Reference
    Vector3 forceDirection = new Vector3(Random.Range(-3,6), 11, 0);
    
    public FruitController(FruitsModel fruitsModel, FruitView fruitPrefab)
    {
        this.fruitsModel = fruitsModel;
        fruitView = GameObject.Instantiate<FruitView>(fruitPrefab);

        fruitRBD = fruitView.GetComponent<Rigidbody>();
        fruitView.SetFruitControllerReference(this);
        fruitRBD.AddForce(forceDirection, ForceMode.Impulse);
    }

}
