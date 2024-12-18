using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodThrower : MonoBehaviour
{
    [SerializeField] private float foodSpeed = 2f;
    public GameObject firstFood;

    private GameObject newFood;
    private float nextFood = 1f;
    private float myTimer = 0f;

    void Update()
    {
        myTimer = myTimer + Time.deltaTime;

        if(Input.GetButton("Fire1") &&  myTimer > nextFood)
        {
            nextFood = myTimer + foodSpeed;
            
            newFood = Instantiate(firstFood, transform.position, transform.rotation) as GameObject;

            nextFood = nextFood - myTimer;
            myTimer = 0f;

            Destroy(newFood, 5f);
        }
    }
}
