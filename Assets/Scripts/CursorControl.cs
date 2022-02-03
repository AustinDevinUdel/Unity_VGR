using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorControl : MonoBehaviour
{
    // private Touch theTouch;
    // private Rigidbody2D myRigidBody;
    private Vector3 cursorCoords;

    private bool wasCursorInitiallyHit = false;
    GameObject refEventCode;
    

    // Start is called before the first frame update
    void Start()
    {
        // myRigidBody = GetComponent<Rigidbody2D>();
        refEventCode = GameObject.Find("EventCodesObj");
        
    }

    // Update is called once per frame


    void Update()
    {

    if (Input.touchCount > 0) 
    {
        Touch touch = Input.GetTouch(0); // get first touch since touch count is greater than zero
        
        if ((touch.phase == TouchPhase.Stationary || touch.phase == TouchPhase.Moved) &&  (wasCursorInitiallyHit == true))
        {
            // get the touch position from the screen touch to world point
            // Vector3 touchedPos = Camera.main.ScreenToWorldPoint(new Vector3(touch.position.x, touch.position.y, 0));
            // lerp and set the position of the current object to that of the touch, but smoothly over time.
            // transform.position = Vector3.Lerp(transform.position, touchedPos, Time.deltaTime);
            Vector3 touchPosition = new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y);
            transform.position = touchPosition;
            // transform.position = Vector3.Lerp(transform.position, touchedPos, Time.deltaTime);

        }

        if (touch.phase == TouchPhase.Ended)
        {
            wasCursorInitiallyHit = false;
        }
    }
        
    }

    void OnMouseDown() 
    {
        wasCursorInitiallyHit = true;
        Debug.Log("Hit");
    }

    void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.CompareTag("PeripheralTarget"))
        {
            Debug.Log("Enter Peri Target");
            refEventCode.GetComponent<EventCodes>().eventcode = 333;
        }
        
    }

    private void OnTriggerExit2D(Collider2D other) {
        if(other.gameObject.CompareTag("PeripheralTarget"))
        {
            Debug.Log("Exit Peri Target");
            refEventCode.GetComponent<EventCodes>().eventcode = 555;
        }
        
    }
}
