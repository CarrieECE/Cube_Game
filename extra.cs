using System;

public class Class1
{
	public Class1()
	{
        transform.Translate(moveSpeed*Input.GetAxis("Horizontal")*Time.deltaTime, 0f, moveSpeed*Input.GetAxis("Vertical")*Time.deltaTime);

        Vector3 position = this.transform.position;

        if(Input.GetKeyDown(KeyCode.Space))
        {
            flag = true;//meaning that space was pressed
        }

        if (count!= 20 && flag == true)
        {
            position.y += 0.3f;
            this.transform.position = position;
            count++;
            if(count == 20)
            {
                flag = false;
                up = true;
            }
        }
        
        else if(up == true)
        {
            position.y -= 0.3f;
            this.transform.position = position;
            count--;
            if(count == 0)
            {
                up = false;
            }
        }

        //transform.Translate(0, 1f*Time.deltaTime, 0);//time.deltaTime means moves the same amount regardless of computer speed
        //print(Input.GetAxis("Vertical"));
        //transform.Translate(moveSpeed * Input.GetAxis("Horizontal") * Time.deltaTime, 0, moveSpeed * Input.GetAxis("Vertical") * Time.deltaTime);
        /*if(Input.anyKeyDown)
        {
            if(Input.GetKeyDown(KeyCode.RightArrow) ) {

                /*Vector3 position = this.transform.position;
                position.x += 0.5f;
                this.transform.position = position;
                transform.Translate(Input.GetAxis("Horizontal")*Time.deltaTime, 0f, 0f);
            }

            if(Input.GetKeyDown(KeyCode.LeftArrow))
            {
                Vector3 position = this.transform.position;
                position.x -= 0.5f;
                this.transform.position = position;
            }

            if(Input.GetKeyDown(KeyCode.UpArrow))
            {
                Vector3 position = this.transform.position;
                position.z += 0.5f;
                this.transform.position = position;
            }

            if(Input.GetKeyDown(KeyCode.DownArrow))
            {
                Vector3 position = this.transform.position;
                position.z -= 0.5f;
                this.transform.position = position;
            }
        }*/

        void c3_move()
    {
            if (player.transform.position.x >= -12.5f && player.transform.position.x <= -11.5f)
            {
                if (player.transform.position.z >= -3f && player.transform.position.z <= -1f)
                {
                    contact2 = true;
                }
            }

            if (contact2 == true)
            {
                if (num == 5)
                {
                    b3.transform.position = cube2;
                    num = 0;
                }

                if (num == 0)
                {
                    cube2 = b2.transform.position;
                }

                num++;
            }

            else if (contact2 == false)
            {
                Vector3 b3_pos = b3.transform.position;

                if (count <= 20 && flag == true)
                {
                    b3_pos.y += 0.015f;
                    b3.transform.position = b3_pos;
                    count2++;
                    if (count2 == 20)
                    {
                        flag2 = false;
                    }
                }

                else
                {
                    b3_pos.y -= 0.015f;
                    b3.transform.position = b3_pos;
                    count2--;
                    if (count2 == 0)
                    {
                        flag2 = true;
                    }
                }
            }
        }//end of void 3 move

        void c4_move()
    {
            if (player.transform.position.x >= -3f && player.transform.position.x <= -2.5f)
            {
                if (player.transform.position.z >= -10.3f && player.transform.position.z <= -9.3f)
                {
                    flag4 = true;
                }
            }

            if (flag4 == true)
            {
                if (num_4 == 5)
                {
                    b4.transform.position = pos_3;
                    num_4 = 0;
                }

                if (num_4 == 0)
                {
                    pos_3 = b3.transform.position;//position of cube 3
                }

                num_4++;
            }
        }
    }
}
