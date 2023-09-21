using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager: MonoBehaviour
{
    public GUISkin layout;
    public static int PlayerScore = 0;
    public static int Vidas = 5;
    GameObject ball;
    private KeyCode start = KeyCode.I;


    void OnGUI () {
        GUI.skin = layout;
        Scene scene = SceneManager.GetActiveScene();

        if(scene.name == "Game"){
            GUI.Label(new Rect(Screen.width / 2 - 180, 20, 100, 100), "Score: " + PlayerScore);
            GUI.Label(new Rect(Screen.width / 2 - 180, 5, 100, 100), "Vidas: " + Vidas);
        }
        
    }

    public static void Score(){
        PlayerScore++;
    }

    public static void PerderVida(){
        Vidas--;
    }

    void EndGame(){
        //Confere se a pontuação é maior ou igual que a quantidade de blocos
        if(PlayerScore >= 14 * 5)
            SceneManager.LoadScene("Win");
        
        if(Vidas <= 0)
            SceneManager.LoadScene("Lose");
    }

    // Start is called before the first frame update
    void Start()
    {
        ball = GameObject.FindWithTag("Ball");
    }

    // Update is called once per frame
    void Update()
    {
        Scene scene = SceneManager.GetActiveScene();
           // Check if the name of the current Active Scene is your first Scene.
        if (scene.name == "Start")
        {
            if(Input.GetKey(start))
                SceneManager.LoadScene("Game");
        }
        if (scene.name == "Game"){
            EndGame();
        }
    }
}
