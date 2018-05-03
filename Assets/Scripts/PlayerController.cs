using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {
    private Vector3 fp;
    private Vector3 lp;
    private float dragDistance;
    public Text txt;

    private void Start()
    {
        dragDistance = Screen.height * 15 / 100;
    }

    // Update is called once per frame
    void Update () {
		if (Input.touchCount == 1)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                fp = touch.position;
                lp = touch.position;
            }
            else if (touch.phase == TouchPhase.Moved)
            {
                lp = touch.position;
            }
            else if (touch.phase == TouchPhase.Ended)
            {
                lp = touch.position;
            }
        }
        if (Mathf.Abs(lp.x - fp.x) > dragDistance || Mathf.Abs(lp.y - fp.y) > dragDistance)
        {//It's a drag
         //check if the drag is vertical or horizontal
            if (Mathf.Abs(lp.x - fp.x) > Mathf.Abs(lp.y - fp.y))
            {   //If the horizontal movement is greater than the vertical movement...
                if ((lp.x > fp.x))  //If the movement was to the right)
                {   //Right swipe
                    Debug.Log("Right Swipe");
                    txt.text = "Right Swipe";
                }
                else
                {   //Left swipe
                    Debug.Log("Left Swipe");
                    txt.text = "Left Swipe";
                }
            }
            else
            {   //the vertical movement is greater than the horizontal movement
                if (lp.y > fp.y)  //If the movement was up
                {   //Up swipe
                    Debug.Log("Up Swipe");
                    txt.text = "Up Swipe";
                }
                else
                {   //Down swipe
                    Debug.Log("Down Swipe");
                    txt.text = "Down Swipe";
                }
            }
        }
        else
        {   //It's a tap as the drag distance is less than 20% of the screen height
            Debug.Log("Tap");
            txt.text = "Tap";
        }
    }
}
