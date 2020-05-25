using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System;

public class ChangeText : MonoBehaviour
{
   public Text price = null;
   public Text destination = null;
   public Text departureTime = null;
   public Text company = null;

    void Start()
    {
        price.text = "Spin to win (but still pay)";
        // string json = File.ReadAllText("Assets/Scripts/Resources/flights.json");
        // Flights flights = JsonUtility.FromJson<Flights>(json);
        // Debug.Log("List of Flights: " + flights.Flight.Length);
        // for(int i=0;i<flights.Flight.Length;i++)
        // {
        //     Debug.Log(flights.Flight[i].price);
        // }
    }

    void Update()
    {
        string json = File.ReadAllText("Assets/Scripts/Resources/flights.json");
        Flights flights = JsonUtility.FromJson<Flights>(json);
        Debug.Log("List of Flights: " + flights.Flight.Length);
                for(int i=0;i<flights.Flight.Length;i++)
        {
            Debug.Log(flights.Flight[i].price);
  
        if (spinSpeed.totalDegrees > 0 & spinSpeed.totalDegrees < 100)
        {
            price.text = flights.Flight[0].price.ToString() + " Dkk";
            destination.text = flights.Flight[0].destination;
            departureTime.text = flights.Flight[0].departureTime;
            company.text = flights.Flight[0].company;

        } else if(spinSpeed.totalDegrees > 101 & spinSpeed.totalDegrees < 200)
        {
            price.text = flights.Flight[1].price.ToString() + " Dkk";
            destination.text = flights.Flight[1].destination;
            departureTime.text = flights.Flight[1].departureTime;
            company.text = flights.Flight[1].company;

        }else if(spinSpeed.totalDegrees > 201 & spinSpeed.totalDegrees < 400)
        {
            price.text = flights.Flight[2].price.ToString() + " Dkk";
            destination.text = flights.Flight[2].destination;
            departureTime.text = flights.Flight[2].departureTime;
            company.text = flights.Flight[2].company;

        }else if(spinSpeed.totalDegrees > 401 & spinSpeed.totalDegrees < 500)
        {
            price.text = flights.Flight[3].price.ToString() + " Dkk";
            destination.text = flights.Flight[3].destination;
            departureTime.text = flights.Flight[3].departureTime;
            company.text = flights.Flight[3].company;

        }else if(spinSpeed.totalDegrees > 501 & spinSpeed.totalDegrees < 800)
        {
            price.text = flights.Flight[4].price.ToString() + " Dkk";
            destination.text = flights.Flight[4].destination;
            departureTime.text = flights.Flight[4].departureTime;
            company.text = flights.Flight[4].company;
            
        }else if(spinSpeed.totalDegrees > 801 & spinSpeed.totalDegrees < 1000)
        {
            price.text = flights.Flight[5].price.ToString() + " Dkk";
            destination.text = flights.Flight[5].destination;
            departureTime.text = flights.Flight[5].departureTime;
            company.text = flights.Flight[5].company;

        }else if(spinSpeed.totalDegrees > 1001 & spinSpeed.totalDegrees < 1200)
        {
            price.text = flights.Flight[6].price.ToString() + " Dkk";
            destination.text = flights.Flight[6].destination;
            departureTime.text = flights.Flight[6].departureTime;
            company.text = flights.Flight[6].company;

        }else if(spinSpeed.totalDegrees > 1201 & spinSpeed.totalDegrees < 1500)
        {
            price.text = flights.Flight[7].price.ToString() + " Dkk";
            destination.text = flights.Flight[7].destination;
            departureTime.text = flights.Flight[7].departureTime;
            company.text = flights.Flight[7].company;

        }else if(spinSpeed.totalDegrees > 1501 & spinSpeed.totalDegrees < 2100)
        {
            price.text = flights.Flight[8].price.ToString() + " Dkk";
            destination.text = flights.Flight[8].destination;
            departureTime.text = flights.Flight[8].departureTime;
            company.text = flights.Flight[8].company;
            
        }else if(spinSpeed.totalDegrees > 2101)
        {
            price.text = flights.Flight[9].price.ToString() + " Dkk";
            destination.text = flights.Flight[9].destination;
            departureTime.text = flights.Flight[9].departureTime;
            company.text = flights.Flight[9].company;
        }
        }
    }
}
