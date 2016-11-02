using UnityEngine;
using System.Collections;

public class Goal : MonoBehaviour
{

  public Color mycolor;
  public GameObject mlight;
  public GameObject sphere;
  // Use this for initialization
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {

  }

  void OnCollisionEnter(Collision collision)
  {
    mlight.GetComponent<Renderer>().material.color = mycolor;
    mlight.GetComponent<Light>().enabled = true;

  }


  public void resetSphere()
  {
    sphere.transform.localPosition = new Vector3(3.5f, 14.75f, 7);
    sphere.transform.localRotation = new Quaternion(0, 0, 0,1);
    sphere.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
    sphere.GetComponent<Rigidbody>().angularVelocity = new Vector3(0, 0, 0);

  }
}
