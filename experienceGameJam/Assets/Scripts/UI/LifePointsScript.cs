using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifePointsScript : MonoBehaviour {
    [SerializeField]
    public Sprite[] LifeSprites = new Sprite[6];

    [SerializeField]
    GameManager gameManager;

    int MaxLifePoints;
    int LifePoints;
    [SerializeField]
    public Image CurrentImage;

    // Use this for initialization
    void Start()
    {
        MaxLifePoints = gameManager.getLifePoints();
        LifePoints = gameManager.getLifePoints();
    }

    // Update is called once per frame
    void Update()
    {
        LifePoints = gameManager.getLifePoints();
        float criteria = LifePoints / MaxLifePoints;

        if (criteria < 0)
        {
            CurrentImage.sprite = LifeSprites[0];
        }
        if (criteria > 0 && criteria <= 0.20f) {
            CurrentImage.sprite = LifeSprites[1];
        }
        if (criteria > 0.20f && criteria <= 0.40f)
        {
            CurrentImage.sprite = LifeSprites[2];
        }
        if (criteria > 0.40f && criteria <= 0.60f)
        {
            CurrentImage.sprite = LifeSprites[3];
        }
        if (criteria > 0.60f && criteria <= 0.80f)
        {
            CurrentImage.sprite = LifeSprites[4];
        }
        if (criteria > 0.80f )
        {
            CurrentImage.sprite = LifeSprites[5];
        }
    }
}
