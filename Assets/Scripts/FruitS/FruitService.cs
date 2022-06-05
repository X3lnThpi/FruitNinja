using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitService : Singleton<FruitService>
{
    public FruitView fruitView;
    public FruitsScriptableObject fruitScriptableObject;
    private FruitController fruitController;
    [SerializeField]
    private FruitView[] fruitPrefabs;
    FruitTypes x;

    //Spawns specified type of fruit and return fruit controller
    private FruitController CreateFruitController(FruitTypes fruitType)
    {

        FruitsModel fruitModel = new FruitsModel(fruitScriptableObject);
        FruitController fruitController = new FruitController(fruitModel, fruitPrefabs[Random.Range(0,4)]); // This fruit prefab gets Instantiated
        return fruitController;
    }

    void SpawnFruit()
    {
        int x = Random.Range(0, 3);
        CreateFruitController((FruitTypes)x);
    }
    private void Start()
    {
        InvokeRepeating("SpawnFruit", 3, Random.Range(3, 6));
    }
    private void Update()
    {
        
      
    }

}
