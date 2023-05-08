using UnityEngine;

public class playercollision : MonoBehaviour
{   
   public playermovement Movement; 
   void OnCollisionEnter(Collision collisioninfo){
        if (collisioninfo.collider.tag == "obstacle"){
                Movement.enabled = false;
                Debug.Log("MADARCHOD!!! isme bhi har gaya.....hahahahahah");
                FindObjectOfType<gamemanager>().Endgame();
        }
   }
}
