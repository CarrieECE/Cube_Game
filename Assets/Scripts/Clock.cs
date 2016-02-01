using UnityEngine;
using System.Collections;

public class Clock : MonoBehaviour {

    public GameObject one, two, three, four, five, six, seven, eight, nine, ten, eleven, twelve;
    public bool times_up;
    private int counting;
    private int time;
    private int number;
    

	// Use this for initialization
	void Start () {

        one = GameObject.Find("p1");
        two = GameObject.Find("p2");
        three = GameObject.Find("p3");
        four = GameObject.Find("p4");
        five = GameObject.Find("p5");
        six = GameObject.Find("p6");
        seven = GameObject.Find("p7");
        eight = GameObject.Find("p8");
        nine = GameObject.Find("p9");
        ten = GameObject.Find("p10");
        eleven = GameObject.Find("p11");
        twelve = GameObject.Find("p12");

        counting = 0;
        time = 0;//counts the time
        number = 100;
        times_up = false;
    }
	
	// Update is called once per frame
	void Update () {

        Vector3 pos_prev, pos;


        switch( counting )
        {
            case 0:
                counting++;
            break;

            case 1:

                if( time == number )
                {
                    pos_prev = twelve.transform.position;
                    pos_prev.y = -1f;
                    twelve.transform.position = pos_prev;
                    pos = one.transform.position;
                    pos.y = 0.5f;
                    one.transform.position = pos;
                    counting++;
                    time = 0;
                }

                else
                {
                    time++;
                }
                
            break;

            case 2:
                if( time == number )
                {
                    pos_prev = one.transform.position;
                    pos_prev.y = -1f;
                    one.transform.position = pos_prev;
                    pos = two.transform.position;
                    pos.y = 0.5f;
                    two.transform.position = pos;
                    counting++;
                    time = 0;
                }

                else
                {
                    time++;
                }
                
            break;

            case 3:

                if( time == number )
                {
                    pos_prev = two.transform.position;
                    pos_prev.y = -1f;
                    two.transform.position = pos_prev;
                    pos = three.transform.position;
                    pos.y = 0.5f;
                    three.transform.position = pos;
                    counting++;
                    time = 0;
                }

                else
                {
                    time++;
                }
                
            break;

            case 4:
                if( time == number)
                {
                    pos_prev = three.transform.position;
                    pos_prev.y = -1f;
                    three.transform.position = pos_prev;
                    pos = four.transform.position;
                    pos.y = 0.5f;
                    four.transform.position = pos;
                    counting++;
                    time = 0;
                }

                else
                {
                    time++;
                }
                
                break;

            case 5:
                if( time == number)
                {
                    pos_prev = four.transform.position;
                    pos_prev.y = -1f;
                    four.transform.position = pos_prev;
                    pos = five.transform.position;
                    pos.y = 0.5f;
                    five.transform.position = pos;
                    counting++;
                    time = 0;
                }
                
                else
                {
                    time++;
                }
                break;

            case 6:
                if( time == number)
                {
                    pos_prev = five.transform.position;
                    pos_prev.y = -1f;
                    five.transform.position = pos_prev;
                    pos = six.transform.position;
                    pos.y = 0.5f;
                    six.transform.position = pos;
                    counting++;
                    time = 0;
                }

                else
                {
                    time++;
                }
                
                break;

            case 7:
                if( time == number)
                {
                    pos_prev = six.transform.position;
                    pos_prev.y = -1f;
                    six.transform.position = pos_prev;
                    pos = seven.transform.position;
                    pos.y = 0.5f;
                    seven.transform.position = pos;
                    counting++;
                    time = 0;
                }

                else
                {
                    time++;
                }
                
                break;

            case 8:
                if( time == number)
                {
                    pos_prev = seven.transform.position;
                    pos_prev.y = -1f;
                    seven.transform.position = pos_prev;
                    pos = eight.transform.position;
                    pos.y = 0.5f;
                    eight.transform.position = pos;
                    counting++;
                    time = 0;
                }
                
                else
                {
                    time++;
                }
                break;

            case 9:
                if( time == number)
                {
                    pos_prev = eight.transform.position;
                    pos_prev.y = -1f;
                    eight.transform.position = pos_prev;
                    pos = nine.transform.position;
                    pos.y = 0.5f;
                    nine.transform.position = pos;
                    counting++;
                    time = 0;
                }

                else
                {
                    time++;
                }
                
                break;

            case 10:
                if( time == number)
                {
                    pos_prev = nine.transform.position;
                    pos_prev.y = -1f;
                    nine.transform.position = pos_prev;
                    pos = ten.transform.position;
                    pos.y = 0.5f;
                    ten.transform.position = pos;
                    counting++;
                    time = 0;
                }
                
                else
                {
                    time++;
                }
                break;

            case 11:
                if( time == number)
                {
                    pos_prev = ten.transform.position;
                    pos_prev.y = -1f;
                    ten.transform.position = pos_prev;
                    pos = eleven.transform.position;
                    pos.y = 0.5f;
                    eleven.transform.position = pos;
                    counting++;
                    time = 0;
                }
                
                else
                {
                    time++;
                }
                break;

            case 12:

                if( time == number)
                {
                    pos_prev = eleven.transform.position;
                    pos_prev.y = -1f;
                    eleven.transform.position = pos_prev;
                    pos = twelve.transform.position;
                    pos.y = 0.5f;
                    twelve.transform.position = pos;
                    //count = 1;
                    time = 0;
                    times_up = true;
                }
                
            break;

            default:
            break;
        }
	
	}//end of update
}
