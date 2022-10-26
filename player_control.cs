using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player_control : MonoBehaviour
{
    private float power;
    public float power_plus = 300.0f;
    public GameObject prefab = null;
    public bool jump = false;
    // Start is called before the first frame update
    void Start()
    {
        GameObject goal = GameObject.Instantiate(prefab) as GameObject;
        float randomX = Random.Range(7.0f, 10.0f);
        float randomY = Random.Range(-3.0f, 2.0f);

        goal.transform.position = new Vector3(randomX, randomY, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            if (jump == false)
            {
                power += power_plus * Time.deltaTime;
            }
        }
        
            
        if (Input.GetMouseButtonUp(0))
        {
            jump=true;
            this.GetComponent<Rigidbody>().AddForce(new Vector3(power, power, 0));
            power = 0.0f;
        }
        if (this.transform.position.y < -5.0f || Input.GetMouseButtonDown(1))
        {
            SceneManager.LoadScene("SampleScene");

        }

    }
}
