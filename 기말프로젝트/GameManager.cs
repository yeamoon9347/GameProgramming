using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject CoverImage;

    public void OnClickStartButton()
    {
        CoverImage.SetActive(false);
    }
}