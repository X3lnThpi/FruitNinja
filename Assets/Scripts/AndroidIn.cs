using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AndroidIn : MonoBehaviour
{
    
    private void Start()
    {
        bool supportsMultiTouch = Input.multiTouchEnabled;
        Debug.Log("Multi Touch is " + supportsMultiTouch);
    }

    private void Update()
    {
        int nTouches = Input.touchCount;

        if(nTouches > 0)
        {
            Debug.Log(nTouches + "Touch Detected");

            for(int i = 0; i < nTouches; i++)
            {
                Touch touch = Input.GetTouch(i);
                //Debug.Log("Touch Index " + touch.fingerId + "detected at " + touch.position);
                Ray ray = Camera.main.ScreenPointToRay(Input.touches[0].position);
                RaycastHit hit;
                Debug.DrawRay(ray.origin, ray.direction * 100, Color.red, 100f);

                if(Physics.Raycast(ray, out hit))
                {
                    if(hit.transform.tag == "Apples")
                    {
                        GameObject temp = hit.transform.gameObject;
                        PlaneObserver.Score = PlaneObserver.Score + 1;
                        Destroy(temp);
                    }
                    else if (hit.transform.tag == "Banana" || hit.transform.tag == "Lemon")
                    {
                        GameObject temp = hit.transform.gameObject;
                       // PlaneObserver.Score = PlaneObserver.Score - 1;
                        Destroy(temp);
                    }
                    else if (hit.transform.tag == "Bomb")
                    {
                        GameObject temp = hit.transform.gameObject;
                        PlaneObserver.lives = 0;
                        Destroy(temp);
                    }
                }
            }
        }
    }
}
