using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameControl : MonoBehaviour {

    public GameObject[] ObsteclePrefabs;
    public GameObject Spawned;
    public GameObject Ground;
    Rigidbody Srb;
    Rigidbody Grb;
    float tilevelocity = 20f;
    float startZpos = 8.8f;
    float Xpos = 9.733349f;
    float Ypos = 4.546875f;
    public bool gameHasEnded = false;
    public float RestartDelay = 2f;
    // Use this for initialization
    void Start () {
        Grb = Ground.GetComponent<Rigidbody>();
        Grb.velocity = new Vector3(0,0 , -tilevelocity);
        for(int i = 1; i <= 5; i++)
        {
            float spawnlocZ = startZpos + (40 * i);
            SpawnObstecle(spawnlocZ);
        }
    }

    private float timetospawn = 2f;

    GameObject[] tilestop;

    void Update()
    {
        // To generate new tiles
           if (Spawned.transform.position.z <= 168.8f && Time.time>=timetospawn)
           {
            SpawnObstecle(208.8f);
           }
        if (gameHasEnded == true)
        {
            tilestop = GameObject.FindGameObjectsWithTag("clone");
            foreach (GameObject clone in tilestop)
            {
                clone.GetComponent<Rigidbody>().velocity = new Vector3(0,0,0);
            }
        }
    }
    
  
        // Pick random tile from prefab folder

    public void SpawnObstecle(float Zpos)
    {
        int ObstecleNum = Random.Range(0, 5);
       
        Spawned = (GameObject) Instantiate(ObsteclePrefabs[ObstecleNum], new Vector3(Xpos, Ypos, Zpos), Quaternion.identity);
        Srb = Spawned.GetComponent<Rigidbody>();
        Srb.velocity = new Vector3(0, 0, -tilevelocity);

    }

    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game Over");
            Invoke("Restart", RestartDelay);
        }
        
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
