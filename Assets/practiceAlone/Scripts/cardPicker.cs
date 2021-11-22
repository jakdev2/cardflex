using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cardPicker : MonoBehaviour
{
    public int card;
    public int count = 0;
    public string shownCount;

    // Update is called once per frame
    void Update()
    {
        
        //spawn a random card when up
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            card = Random.Range(0, 13);
            count++;

            //if count is 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 or 13, make it say A, 2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, or K respectively.
            if (count == 1)
            {
                shownCount = "A";
            }
            else if (count == 2)
            {
                shownCount = "2";
            }
            else if (count == 3)
            {
                shownCount = "3";
            }
            else if (count == 4)
            {
                shownCount = "4";
            }
            else if (count == 5)
            {
                shownCount = "5";
            }
            else if (count == 6)
            {
                shownCount = "6";
            }
            else if (count == 7)
            {
                shownCount = "7";
            }
            else if (count == 8)
            {
                shownCount = "8";
            }
            else if (count == 9)
            {
                shownCount = "9";
            }
            else if (count == 10)
            {
                shownCount = "10";
            }
            else if (count == 11)
            {
                shownCount = "J";
            }
            else if (count == 12)
            {
                shownCount = "Q";
            }
            else if (count == 13)
            {
                shownCount = "K";
            }

            //and print the card value (a, 2, 3, 4, 5, 6, 7, 8, 9, 10, j, q, k)
            switch (card)
            {
                case 1:
                    Debug.Log("Count: " + shownCount + ", Card: A");
                    break;
                case 2:
                    Debug.Log("Count: " + shownCount + ", Card: 2");
                    break;
                case 3:
                    Debug.Log("Count: " + shownCount + ", Card: 3");
                    break;
                case 4:
                    Debug.Log("Count: " + shownCount + ", Card: 4");
                    break;
                case 5:
                    Debug.Log("Count: " + shownCount + ", Card: 5");
                    break;
                case 6:
                    Debug.Log("Count: " + shownCount + ", Card: 6");
                    break;
                case 7:
                    Debug.Log("Count: " + shownCount + ", Card: 7");
                    break;
                case 8:
                    Debug.Log("Count: " + shownCount + ", Card: 8");
                    break;
                case 9:
                    Debug.Log("Count: " + shownCount + ", Card: 9");
                    break;
                case 10:
                    Debug.Log("Count: " + shownCount + ", Card: 10");
                    break;
                case 11:
                    Debug.Log("Count: " + shownCount + ", Card: J");
                    break;
                case 12:
                    Debug.Log("Count: " + shownCount + ", Card: Q");
                    break;
                case 0:
                    Debug.Log("Count: " + shownCount + ", Card: K");
                    break;
            }
        }

        //when count is greater than 12, reset it to 0
        if (count > 12)
        {
            count = 0;
        }

        if (Input.GetKeyDown(KeyCode.Return) && Input.GetKeyDown(KeyCode.Space) && card == count)
        {
            Debug.Log("Correct");
            count = 0;
        }
        else if (Input.GetKeyDown(KeyCode.Return) && Input.GetKeyDown(KeyCode.Space) && card != count)
        {
            Debug.Log("Incorrect");
            count = 0;
        }
    }
}
