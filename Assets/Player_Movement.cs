using UnityEngine;

public class Player_Movement : MonoBehaviour
{

    public Rigidbody player;
    public float movement_speed = 1000f;
    public float rotation_speed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey("w")) {
            player.AddForce(0, 0, movement_speed*Time.deltaTime);
        } 
        if (Input.GetKey("s")) {
            player.AddForce(0, 0, -movement_speed*Time.deltaTime);
        }
        if (Input.GetKey("a")) {
            player.AddForce(-movement_speed*Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("d")) {
            player.AddForce(movement_speed*Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("e")) {
            player.AddTorque(0, rotation_speed*Time.deltaTime, 0);
        } 
        if (Input.GetKey("q")) {
            player.AddTorque(0, -rotation_speed*Time.deltaTime, 0);
        } 
        
    }
}
