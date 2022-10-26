using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goal_control : MonoBehaviour
{
    private bool is_collided = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionStay(Collision other)
    {
        is_collided = true;
        other.transform.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
    }

    void OnGUI()
    {
        if (is_collided)
        {
            GUI.Label(new Rect(Screen.width / 2 - 70, 80, 500, 20), "다시 시작하려면 아무 키나 누르세요");
            if (Input.anyKeyDown)
            {
                SceneManager.LoadScene("SampleScene");
            }
                

        }
            
        
    }

}
