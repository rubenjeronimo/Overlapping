using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

public class Camara : IComparable<Camara> {
    public string modelo;
    public string marca;
    public float sensorHmm;
    public float sensorVmm;
    public int sensorHpx;
    public int sensorVpx;
    public float circuloConfusion;
    public bool fullFrame;
/*
    public Camara(string newModelo, string newMarca, float newSensorHmm, float newSensorVmm, int newSensorHpx, int newSensorVpx, float newCirculoConfusion,bool newFullFrame)
    {
        modelo = newModelo;
        marca = newMarca;
        sensorHmm = newSensorHmm;
        sensorVmm = newSensorVmm;
        sensorHpx = newSensorHpx;
        sensorVpx = newSensorVpx;
        circuloConfusion = newCirculoConfusion;
        fullFrame = newFullFrame;
    }
    */


    public int CompareTo(Camara other)
    {
        if (other == null)
        {
            return 1;
        }
        return 2;
    }
   
}
