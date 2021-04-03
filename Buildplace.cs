using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Buildplace : MonoBehaviour
{
    public GameObject towerPrefab;

    // value subject to change 
    public static int maxTowers = 5;
    public static int currTowers = 0;

    // access the remaining towers UI text element
    public Text towersRemaining;

    // displays the maximum number of placeable towers;
    private void Start()
    {
        DisplayTowerCount();
    }

    private void OnMouseUpAsButton()
    {
        // check if the player has exceeded their maximum number of towers
        if (currTowers < maxTowers)
        {
            // increment and display currTowers 
            currTowers++;
            DisplayTowerCount();

            GameObject g = (GameObject)Instantiate(towerPrefab);
            g.transform.position = transform.position + Vector3.up;
        }
    }

    // displays the number of placeable towers remaining 
    private void DisplayTowerCount()
    {
        towersRemaining.text = "Towers Remaining: " + (maxTowers - currTowers);
    }
}
