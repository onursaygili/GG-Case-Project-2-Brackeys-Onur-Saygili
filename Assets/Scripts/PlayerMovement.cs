using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;
    
    public float sidewayForce = 100f; //side movement force

    // Use this for initialization
    void Start () {
		
	}
	 
	// Update is called once per frame
	void FixedUpdate () {

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewayForce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }
        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameControl>().EndGame();
        }
    }
}
