using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class moving_player : MonoBehaviour
{
    private GameObject player;
    private float moveSpeed;

    // Use this for initialization
    void Start()
    {
        player = GameObject.Find("Sphere");
        moveSpeed = 2f;

    }

    // Update is called once per frame
    void Update()
    {

        //player.transform.Translate(moveSpeed * (Input.acceleration.x) * Time.deltaTime, 0f, moveSpeed * (-Input.acceleration.z));
        if (Input.anyKeyDown)
        {
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                Vector3 position = this.transform.position;
                position.x += 0.5f;
                this.transform.position = position;
                transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime, 0f, 0f);
            }

            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                Vector3 position = this.transform.position;
                position.x -= 0.5f;
                this.transform.position = position;
            }

            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                Vector3 position = this.transform.position;
                position.z += 0.5f;
                this.transform.position = position;
            }

            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                Vector3 position = this.transform.position;
                position.z -= 0.5f;
                this.transform.position = position;
            }
        }//end of any key down
    }//end of void update
}
