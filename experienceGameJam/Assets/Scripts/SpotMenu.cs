using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpotMenu : MonoBehaviour {

    public GameObject towerMenu;

    private void OnMouseDown()
    {
        GameObject gameObject = Instantiate(towerMenu);
        gameObject.transform.SetParent(transform, false);
        gameObject.transform.position = Input.mousePosition;

    }
}
