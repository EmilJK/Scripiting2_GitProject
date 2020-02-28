using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NativeTouch : MonoBehaviour
{
    
    void Update()
    {
        if(Input.touchCount > 0)
        {
            Touch touch = Input.touches[0];
            print(touch.position);
            if(touch.phase == TouchPhase.Began)
            {
                //When the touch begins, stuff will happen
            }
            else if(touch.phase == TouchPhase.Ended)
            {
                //When the touch is ended, something will happen
            }

            Vector3 scenePos;
            scenePos = Camera.main.ScreenToViewportPoint(touch.position);
        }
    }
}
