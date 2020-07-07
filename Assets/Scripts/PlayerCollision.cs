using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    public PlayerMovement Movement;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Obstecle")
        {
           //Debug.Log("Hit!");
            Movement.enabled = false;
            FindObjectOfType<GameControl>().EndGame();
        }
        
    }

}
