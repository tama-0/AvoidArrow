using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIdirector : MonoBehaviour
{
    GameObject points;
    GameObject lives;
    GameObject gameover;

    private void Start()
    {
        this.points = GameObject.Find("points");
        this.lives = GameObject.Find("lives");
        this.gameover = GameObject.Find("Gameover");
    }

    public void Addpoint(int count)
    {
        int POINT = count * 100;
        this.points.GetComponent<Text>().text = POINT.ToString("D");
    }

    public void Distlife(int life)
    {
        this.lives.GetComponent<Text>().text = life.ToString("D");
    }

    public void Gameover()
    {
        this.gameover.GetComponent<Text>().text = "GAME OVER";
    }
}
