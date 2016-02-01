using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

    //public Clock Clock;
    public float moveSpeed;
    public GameObject b1;
    public GameObject player;
    public GameObject b2;
    public GameObject b3;
    public GameObject b4;
    public GameObject b5;
    public GameObject b6;
    public GameObject b7;
    private int count;
    private int count2;//counts for cube 2
    private int count3;//counts for cube 3
    private int count4;
    private int count5;
    private int count6;
    private int count7;
    private int num;
    private int num_2;//count for cube 2
    private int num_3;//count for cube 3
    private int num_4;//count for cube 4
    private int num_5;
    private int num_6;
    private int num_7;
    private bool flag;
    private bool flag2;//for cube 2
    private bool flag3;//for cube 3
    private bool flag4;
    private bool flag5;
    private bool flag6;
    private bool flag7;
    private bool contact;
    private bool contact2;
    private bool contact3;
    private bool contact4;
    private bool contact5;
    private bool contact6;
    private bool contact7;
    private float x, y, z;
    private Vector3 b1_pos;//marks the position of cube 1
    private Vector3 b2_pos;//marks the position of cube 2
    private Vector3 b3_pos;//marks the position for cube 3
    private Vector3 b4_pos;
    private Vector3 b5_pos;
    private Vector3 b6_pos;

    private Vector3 i1, i2, i3, i4, i5, i6, i7, sphere;

    //these are for the clock

    public GameObject one, two, three, four, five, six, seven, eight, nine, ten, eleven, twelve;
    public bool times_up;
    private int counting;
    private int time;
    private int number;

    // Use this for initialization

    void Start () {
        //flag = true;
        /*count = 0;
        up = false;*/
        moveSpeed = 4f;
        b1 = GameObject.Find("Cube");
        b2 = GameObject.Find("cube1");
        b3 = GameObject.Find("cube2");
        b4 = GameObject.Find("cube4");
        b5 = GameObject.Find("cube5");
        b6 = GameObject.Find("cube6");
        b7 = GameObject.Find("cube7");
        player = GameObject.Find("Sphere");
        i1 = b1.transform.position;
        i2 = b2.transform.position;
        i3 = b3.transform.position;
        i4 = b4.transform.position;
        i5 = b5.transform.position;
        i6 = b6.transform.position;
        i7 = b7.transform.position;
        sphere = player.transform.position;
        count = 0;
        count2 = 0;
        count3 = 0;
        count4 = 0;
        count5 = 0;
        count6 = 0;
        count7 = 0;
        flag = true;
        flag2 = true;//for cube 2
        flag3 = true;
        flag4 = true;
        flag5 = true;
        flag6 = true;
        flag7 = true;
        contact = false;
        contact2 = false;
        contact3 = false;
        contact4 = false;
        contact5 = false;
        contact6 = false;
        contact7 = false;
        x = -18.73f;
        y = 0.94f;
        z = -0.57f;
        num = 0;
        num_2 = 0;
        num_3 = 0;
        num_4 = 0;
        num_5 = 0;
        num_6 = 0;
        num_7 = 0;

        //this is for the clock
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
        number = 230;
        times_up = false;
    }
	
	// Update is called once per frame
	void Update () {

        //player.transform.Translate(moveSpeed * (Input.acceleration.x) * Time.deltaTime, 0f, moveSpeed * (-Input.acceleration.z) * Time.deltaTime);
        if (times_up == true)
        {
            if(player.transform.position.x >= 12.7f && player.transform.position.x <= 17.97f)
            {
                if(player.transform.position.z >= 1.1f && player.transform.position.z <= 7.1f)
                {
                    Vector3 home = GameObject.Find("Home").transform.position;
                    home.y = -1f;
                    GameObject.Find("Home").transform.position = home;
                    Vector3 win = GameObject.Find("Win").transform.position;
                    win.y = 0.5f;
                    GameObject.Find("Win").transform.position = win;
                }
            }

            else
            {
                sphere = player.transform.position;
                b1.transform.position = i1;
                b2.transform.position = i2;
                b3.transform.position = i3;
                b4.transform.position = i4;
                b5.transform.position = i5;
                b6.transform.position = i6;
                b7.transform.position = i7;
            }
        }

        else
        {
            if (player.transform.position.z > -1f || contact == true)
            {
                contact = true;
                Vector3 position = new Vector3(x, y, z);
                if (num == 20)
                {
                    b1.transform.position = position;
                    num = 0;
                }

                if (num == 0)
                {
                    x = player.transform.position.x;
                    y = player.transform.position.y;
                    z = player.transform.position.z;
                }

                num++;
            }

            else if (contact == false)
            {
                Vector3 b1_pos = b1.transform.position;

                if (count <= 20 && flag == true)
                {
                    b1_pos.y += 0.001f;
                    b1.transform.position = b1_pos;
                    count++;
                    if (count == 20)
                    {
                        flag = false;
                    }
                }

                else
                {
                    b1_pos.y -= 0.001f;
                    b1.transform.position = b1_pos;
                    count--;
                    if (count == 0)
                    {
                        flag = true;
                    }
                }

            }

            c2_move();
            c3_move();
            c4_move();
            c5_move();
            c6_move();
            c7_move();
            clock();
        }
        
    }

    void clock()
    {
        Vector3 pos_prev, pos;


        switch (counting)
        {
            case 0:
                counting++;
                break;

            case 1:

                if (time == number)
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
                if (time == number)
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

                if (time == number)
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
                if (time == number)
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
                if (time == number)
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
                if (time == number)
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
                if (time == number)
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
                if (time == number)
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
                if (time == number)
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
                if (time == number)
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
                if (time == number)
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

                if (time == number)
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

                else
                {
                    time++;
                }

                break;

            default:
                break;
        }//end of switch
}

    void c2_move()
    {
        if( player.transform.position.x >= -14.5f && player.transform.position.x <= -12.5f )
        {
            if(player.transform.position.z >= 2f && player.transform.position.z <= 3.2f)
            {
                contact2 = true;
            }
        }

        if( contact2 == true )
        {
            if(num_2 == 20)
            {
                b2.transform.position = b1_pos;
                num_2 = 0;
            }

            if(num_2 == 0)
            {
                b1_pos = b1.transform.position;
            }

            num_2++;
        }

        else if( contact2 == false )
        {
            Vector3 b2_pos = b2.transform.position;//position of cube 2

            if (count <= 40 && flag2 == true)
            {
                b2_pos.y += 0.0006f;
                b2.transform.position = b2_pos;
                count2++;
                if (count2 == 40)
                {
                    flag2 = false;
                }
            }

            else
            {
                b2_pos.y -= 0.0006f;
                b2.transform.position = b2_pos;
                count2--;
                if (count2 == 0)
                {
                    flag2 = true;
                }
            }
        }
    }//end of c2_move

    void c3_move()
    {
        if( player.transform.position.x >= -11.8f && player.transform.position.x <= -11.2f) //tests the position of the player
        {
            if( player.transform.position.z >= -2.3f && player.transform.position.z <= -1.7f )
            {
                contact3 = true;
            }
        }

        if( contact3 == true ) //collision occured
        {
            if( num_3 == 20 )
            {
                b3.transform.position = b2_pos;
                num_3 = 0;
            }

            if( num_3 == 0 )
            {
                b2_pos = b2.transform.position;
            }

            num_3++;
        }

        else if(contact3 == false )
        {
            Vector3 p_3 = b3.transform.position;//marks the position of cube 3
            if(count3 <= 40 && flag3 == true )
            {
                p_3.z += 0.0005f;
                b3.transform.position = p_3;
                count3++;
                if( count3 == 40 )
                {
                    flag3 = false;
                }
            }

            else
            {
                p_3.z -= 0.0005f;
                b3.transform.position = p_3;
                count3--;
                if( count3 == 0 )
                {
                    flag3 = true;
                }
            }
        }
            
    }//end of move 3

    void c4_move()
    {
        if (player.transform.position.x >= -2.8f && player.transform.position.x <= -2.2f) //tests the position of the player
        {
            if (player.transform.position.z >= -11.2f && player.transform.position.z <= -10.8f)
            {
                contact4 = true;
            }
        }

        if (contact4 == true) //collision occured
        {
            if (num_4 == 15)
            {
                b4.transform.position = b3_pos;
                num_4 = 0;
            }

            if (num_4 == 0)
            {
                b3_pos = b3.transform.position;
            }

            num_4++;
        }

        else if (contact4 == false)
        {
            Vector3 p_4 = b4.transform.position;//marks the position of cube 3
            if (count4 <= 40 && flag4 == true)
            {
                p_4.x -= 0.0007f;
                b4.transform.position = p_4;
                count4++;
                if (count4 == 40)
                {
                    flag4 = false;
                }
            }

            else
            {
                p_4.x += 0.0007f;
                b4.transform.position = p_4;
                count4--;
                if (count4 == 0)
                {
                    flag4 = true;
                }
            }
        }

    }//end of move 4

    void c5_move()
    {
        if (player.transform.position.x >= -8.8f && player.transform.position.x <= -8.4f) //tests the position of the player
        {
            if (player.transform.position.z >= -5f && player.transform.position.z <= 0.3f)
            {
                contact5 = true;
            }
        }

        if (contact5 == true) //collision occured
        {
            if (num_5 == 15)
            {
                b5.transform.position = b4_pos;
                num_5 = 0;
            }

            if (num_5 == 0)
            {
                b4_pos = b4.transform.position;
            }

            num_5++;
        }

        else if (contact5 == false)
        {
            Vector3 p_5 = b5.transform.position;//marks the position of cube 5
            if (count5 <= 40 && flag5 == true)
            {
                p_5.z += 0.0007f;
                b5.transform.position = p_5;
                count5++;
                if (count5 == 40)
                {
                    flag5 = false;
                }
            }

            else
            {
                p_5.z -= 0.0007f;
                b5.transform.position = p_5;
                count5--;
                if (count5 == 0)
                {
                    flag5 = true;
                }
            }
        }
    }//end of move 5

    void c6_move()
    {
        if (player.transform.position.x >= -1.3f && player.transform.position.x <= -0.16f) //tests the position of the player
        {
            if (player.transform.position.z >= 4.64f && player.transform.position.z <= 5.06f)
            {
                contact6 = true;
            }
        }

        if (contact6 == true) //collision occured
        {
            if (num_6 == 15)
            {
                b6.transform.position = b5_pos;
                num_6 = 0;
            }

            if (num_6 == 0)
            {
                b5_pos = b5.transform.position;
            }

            num_6++;
        }

        else if (contact6 == false)
        {
            Vector3 p_6 = b6.transform.position;//marks the position of cube 5
            if (count6 <= 40 && flag6 == true)
            {
                p_6.x += 0.0007f;
                b6.transform.position = p_6;
                count6++;
                if (count6 == 40)
                {
                    flag6 = false;
                }
            }

            else
            {
                p_6.x -= 0.0007f;
                b6.transform.position = p_6;
                count6--;
                if (count6 == 0)
                {
                    flag6 = true;
                }
            }
        }
    }//end of 6

    void c7_move()
    {
        if (player.transform.position.x >= 5.67f && player.transform.position.x <= 7.78f) //tests the position of the player
        {
            if (player.transform.position.z >= 0f && player.transform.position.z <= 0.3f)
            {
                contact7 = true;
            }
        }

        if (contact7 == true) //collision occured
        {
            if (num_7 == 10)
            {
                b7.transform.position = b6_pos;
                num_7 = 0;
            }

            if (num_7 == 0)
            {
                b6_pos = b6.transform.position;
            }

            num_7++;
        }

        else if (contact7 == false)
        {
            Vector3 p_7 = b7.transform.position;//marks the position of cube 5
            if (count7 <= 80 && flag7 == true)
            {
                p_7.x += 0.0003f;
                b7.transform.position = p_7;
                count7++;
                if (count7 == 80)
                {
                    flag7 = false;
                }
            }

            else
            {
                p_7.x -= 0.0003f;
                b7.transform.position = p_7;
                count7--;
                if (count7 == 0)
                {
                    flag7 = true;
                }
            }
        }
    }//end of move 7
}
