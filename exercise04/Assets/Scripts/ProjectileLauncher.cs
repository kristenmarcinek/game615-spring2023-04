using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileLauncher : MonoBehaviour {
    public GameObject fire;
    public Vector3 positionOffset;
    public AudioSource sfx;

    //public GameObject SphereObj;
    //public Renderer SphereRend;

    //public Color ColorToUse;

    //public Material MatToUse;

    // Start is called before the first frame update
    void Start() {
        // These lines of code aren't relevant to the exmaple, but I am not deleting them in case
        // anyone wanted to see them again. They pretty much show how we can modify GameObjects
        // and their component's properties from a different GameObject and component.

        //GameObject sphereObj = GameObject.Find("Sphere");
        //SphereObj.transform.position = new Vector3(SphereObj.transform.position.x, 0, SphereObj.transform.position.z);

        //Renderer sphereRend = sphereObj.GetComponent<Renderer>();
        //SphereRend.material.color = ColorToUse;

        //Rigidbody rb = SphereObj.GetComponent<Rigidbody>();
        //rb.useGravity = true;
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            sfx.Play();
        }
        if (Input.GetKey(KeyCode.Space)) {
            // This will instantiate and launch 100 prefabs of the banana car.
            for (int i = 0; i < 1; i++) {
                GameObject fireParticle = Instantiate(fire, gameObject.transform.position + positionOffset + 2 * transform.forward, transform.rotation);
                float rotXAmount = Random.Range(-10, 10);
                float rotYAmount = Random.Range(-20, 20);
                fireParticle.transform.Rotate(rotXAmount, rotYAmount, 0);
                Rigidbody rb = fireParticle.GetComponent<Rigidbody>();
                rb.AddForce(fireParticle.transform.forward * 700);

                Destroy(fireParticle, 1f);
            }

            /*
            // This will instantiate 100 spheres of random colors
            for (int i = 0; i < 100; i++)
            {
                GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                sphere.name = "sphere" + i;
                Renderer sRend = sphere.GetComponent<Renderer>();
                sRend.material.color = new Color(Random.value, Random.value, Random.value);
                sphere.transform.position = gameObject.transform.position;
                float rotXAmount = Random.Range(-89, -10);
                float rotYAmount = Random.Range(0, 360);
                sphere.transform.Rotate(rotXAmount, rotYAmount, 0);
                Rigidbody sphereRB = sphere.AddComponent<Rigidbody>();
                sphereRB.AddForce(sphere.transform.forward * 1000);
                Destroy(sphere, 2f);
            }
            */
        }
    }
}