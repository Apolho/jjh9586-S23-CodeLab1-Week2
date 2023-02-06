using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public static float score = 0;

    public static bool game = false;

    public TextMeshProUGUI scoretext;
    public GameObject canvas;
    
    // Start is called before the first frame update
    void Awake()
    {
        if (Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            DontDestroyOnLoad(canvas);
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (game == false && score == 4) //if the bool is false and score reaches 4
        {
            score = 0; //will reset score
            game = true; //will turn bool true
            SceneManager.LoadScene("Level 2"); //will load new scene
        }

        scoretext.text = "Score: " + score; //make the text say the score
    }
}
