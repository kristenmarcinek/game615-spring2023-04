using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KirbyCollector : MonoBehaviour
{
    int number;
    public TextMeshProUGUI display;
    public GameObject kirbyStacker;
    public Vector3 stackOffset;
    public float yIncrement;
    public AudioSource sfx;

    // Start is called before the first frame update
    void Start()
    {
        number = 0;
    }

    // Update is called once per frame
    void Update()
    {
        display.text = "Kirbys rescued: " + number;
    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Collectible")) {
            //other.gameObject.SetActive(false);
            Destroy(other.gameObject);
            number += 1;
            sfx.Play();
            if (number < 20) {
                Instantiate(kirbyStacker, transform.position + stackOffset + 0 * transform.forward + new Vector3(0, number * yIncrement, 0), transform.rotation, transform);
            }
        }
    }
}
