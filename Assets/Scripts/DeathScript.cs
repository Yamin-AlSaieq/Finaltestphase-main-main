using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathScript : MonoBehaviour
{
    public GameObject startPoint;
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        
        //PlayerPrefs.DeleteKey("DeathCount");//use it if you want to reset the number
        print(PlayerPrefs.GetInt("DeathCount"));
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            PlayerPrefs.SetInt("DeathCount", PlayerPrefs.GetInt("DeathCount",0) + 1);
            print(PlayerPrefs.GetInt("DeathCount"));
            Player.transform.position = startPoint.transform.position;
        }
    }
}