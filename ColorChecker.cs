using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChecker : MonoBehaviour
{

    //public GameObject collisionObject;
    public GameObject confettiFx;

    [SerializeField]
    public Voicelines voicescript;


    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Kugle")
        {
            if (gameObject.name == "RødKurv")
            {
                if (collision.gameObject.GetComponent<Renderer>().material.color == Color.red)
                {

                    Destroy(collision.gameObject);

                    Debug.Log("Kuglen er röt");

                    GameObject ob = Instantiate(confettiFx);
                    ob.transform.position = new Vector3(0f, -0.5f, -3f);
                    Destroy(ob, 2.5f);

                    voicescript.RightCollision();
                }
                else
                {
                    voicescript.WrongCollision();

                    Debug.Log("Kuglen er ikke röt");
                }
            }

            if (gameObject.name == "GulKurv")
            {

                if (collision.gameObject.GetComponent<Renderer>().material.color == Color.yellow)
                {

                    Destroy(collision.gameObject);

                    Debug.Log("Kuglen er gelb");

                    GameObject ob = Instantiate(confettiFx);
                    ob.transform.position = new Vector3(2.5f, -0.5f, -3f);
                    Destroy(ob, 2.5f);

                    voicescript.RightCollision();
                }
                else
                {
                    voicescript.WrongCollision();

                    Debug.Log("Kuglen er ikke gelb");
                }
            }

            if (gameObject.name == "GrønKurv")
            {

                if (collision.gameObject.GetComponent<Renderer>().material.color == Color.green)
                {
                    Destroy(collision.gameObject);

                    Debug.Log("Kuglen er Grün");

                    GameObject ob = Instantiate(confettiFx);
                    ob.transform.position = new Vector3(-2.5f, -0.5f, -3f);
                    Destroy(ob, 2.5f);

                    voicescript.RightCollision();
                }
                else
                {
                    voicescript.WrongCollision();

                    Debug.Log("Kuglen er ikke Grün");
                }
            }
        }
    }
}
