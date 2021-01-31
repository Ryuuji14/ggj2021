using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fragment : MonoBehaviour
{

    public static int fragmentsCount = 0;
  //  public AudioSource fragmentsource;
  //  public AudioClip clipfragment;
   // public AudioClip clipfirework;

    // Use this for initialization
    void Start()
    {
        Fragment.fragmentsCount++;
        //Debug.Log ("hola");
       // fragmentsource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("Player"))
        {
           // AudioSource.PlayClipAtPoint(clipfragment, transform.position);
            Debug.Log("Te faltan por recolectar " + (fragmentsCount - 1).ToString() + " fragmentos.");
            Destroy(gameObject);
        }
    }
    void OnDestroy()
    {
        Fragment.fragmentsCount--;
        if (Fragment.fragmentsCount <= 0)
        {
            GameObject timer = GameObject.Find("GameTimer");



            Debug.Log("Ganaste!! :)");
            SceneManager.LoadScene(2);
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            /*GameObject[] fireworks = GameObject.FindGameObjectsWithTag ("Firework");
			foreach (GameObject firework in fireworks) {
				firework.GetComponent<ParticleSystem> ().Play ();
			}*/
            Destroy(timer);
        }

    }

}
