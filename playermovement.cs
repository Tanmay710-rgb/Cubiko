using UnityEngine;

public class playermovement : MonoBehaviour
{   public Rigidbody Rigidbody;   
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    // Update is called once per frame
    void FixedUpdate()
    {   
        Rigidbody.AddForce(0, 0, forwardForce*Time.deltaTime);

        if (Input.GetKey("d")){
            Rigidbody.AddForce(sidewaysForce*Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a")){
            Rigidbody.AddForce(-sidewaysForce*Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Rigidbody.position.y < -1f){
            FindObjectOfType<gamemanager>().Endgame();
        }
    }
}
