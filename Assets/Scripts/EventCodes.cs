using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventCodes : MonoBehaviour
{
    public int eventcode = 999;
    public int target = 9;
    private void FixedUpdate() {

        EventCodeHandeler(eventcode,target);
        eventcode = 999;
        
    }
    public void EventCodeHandeler(int eventcode, int target){
        
        switch(eventcode)
        {
            case 999:
                // print(eventcode);
                // print(Time.time * 1000);
                break;

            case 111:
                print(eventcode);
                // eventcode = 999;
                break;

            case 222:
                print(eventcode);
                // eventcode = 999;
                break;

            case 333:
                print(eventcode);
                // eventcode = 999;
                break;

            case 444:
                print(eventcode);
                // eventcode = 999;
                break;
            
            case 555:
                print(eventcode);
                // eventcode = 999;
                break;
        }

    }
    // // Start is called before the first frame update
    // void Start()
    // {
        
    // }


}
