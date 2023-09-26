using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager: MonoBehaviour
{
    public static int PlayerScore = 0;
    public static int Vidas = 5;
    GameObject ball;
    private KeyCode start = KeyCode.I;


    public static void Score(){
        PlayerScore++;
    }

    public static void PerderVida(){
        Vidas--;
    }

    public void MudaFase(){
        //Confere se a pontuação é maior ou igual que a quantidade de blocos
        if(PlayerScore >= 45){
            SceneManager.LoadScene("Fase2");
            ball.gameObject.SendMessage("ResetBall", 1.0f, SendMessageOptions.RequireReceiver);
        }
            
        if(Vidas <= 0)
            SceneManager.LoadScene("Lose");
    }
    void EndGame(){
        //Pontos da fase 1 + pontos da fase 2
        if(PlayerScore >= 45 + (14 * 5) )
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
                SceneManager.LoadScene("Fase1");
        }
        if (scene.name == "Fase1"){
            MudaFase();
        }
        if (scene.name == "Fase2"){
            EndGame();
        }
    }
}
