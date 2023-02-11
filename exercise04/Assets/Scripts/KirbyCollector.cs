using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KirbyCollector : MonoBehaviour
{
    int number;
    public TextMeshProUGUI display;

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
        }
    }
}
