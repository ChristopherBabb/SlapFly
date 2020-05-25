using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Flights {
    public Flight[] Flight;
}

[System.Serializable]
public class Flight
{
    public string id;
    public string company;
    public int duration;
    public string destination;
    public float latitude;
    public float longitude;
    public string departureTime;
    public string arrivalTime;
    public int price;
    public string stopdestination;

}