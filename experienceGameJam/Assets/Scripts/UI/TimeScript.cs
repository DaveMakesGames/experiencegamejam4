using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeScript : MonoBehaviour
{
    [SerializeField]
    Text text;

    [SerializeField]
    GameManager gameManager;

    // Use this for initialization
    void Start()
    {
        text.text = gameManager.getTime().ToString();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = gameManager.getTime().ToString();
    }
}
