//script que controla la generacion de los prefabs del mundo
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class SC_PlatformTile : MonoBehaviour
{
    //variables que controlan el punto de inicio y el final 
    public Transform startPoint;
    public Transform endPoint;
    //array en el que almacenamos los obstaculos
    public GameObject[] obstacles; 

    //función para activar obstaculos
    public void ActivateRandomObstacle()
    {
        //desactivar todos los obstaculos
        DeactivateAllObstacles();
        //elegimos un obstaculo random dentro de la longitud del array de di
        System.Random random = new System.Random();
        int randomNumber = random.Next(0, obstacles.Length);
        obstacles[randomNumber].SetActive(true);
    }

    //función para desactivar todos los obstaculos
    public void DeactivateAllObstacles()
    {
        for (int i = 0; i < obstacles.Length; i++)
        {
            obstacles[i].SetActive(false);
        }
    }
}