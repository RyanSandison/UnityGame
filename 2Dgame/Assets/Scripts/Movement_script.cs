using UnityEngine;
using System.Collections;

public class Movement_script : MonoBehaviour {

	// Use this for initialization
	void Start () {
     
    }

   public int speed;
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.A))
        {
            Vector3 position = this.transform.position;
            this.transform.position += Vector3.left * speed * Time.deltaTime; 
        }
        if (Input.GetKey(KeyCode.D))
        {
            Vector3 position = this.transform.position;
            this.transform.position += Vector3.right * speed * Time.deltaTime; 
        }
    }
}
