using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class Particleassignation : MonoBehaviour
{
    //Defines the output labels
    public Text blueRadiusText;
    public Text redRadiusText;
    public Text greenRadiusText;
    public Text magneticFieldText;
    public Text distanceText;
    public Text voltageText;
    public Text particlesSpeedText;
    public Text selectedParticleInfoText;


    private double particleProtonMass;
    private double particleElectronMass;
    private double particleMass;
    private double particleCharge;

    private double blueRadius = 1;
    private double redRadius = 1;
    private double greenRadius = 1;

    private double magneticField = 0.035;
    private double distance = 0.1;
    private double voltage = 250;
    private double particlesSpeed = 71428;

    private int particle1Index;
    private int particle2Index;
    private int particle3Index;

    public GameObject inputVoltage;
    public GameObject inputBlueParticle;
    public GameObject inputRedParticle;
    public GameObject inputGreenParticle;


    private const double fundamentalCharge = 0.0000000000000000001602;
    private const double electronMass = 0.00000000000000000000911;
    private const double protonMass = 0.00000000000000000000000000167;
 

    void Start()
    {

    }

    void Update()
    {
        RefreshText();
    }

    public void readParticles()
    {
        string particleInput1 = inputBlueParticle.GetComponent<Text>().text;
        particle1Index = int.Parse(particleInput1);

        string particleInput2 = inputRedParticle.GetComponent<Text>().text;
        particle2Index = int.Parse(particleInput2);

        string particleInput3 = inputGreenParticle.GetComponent<Text>().text;
        particle3Index = int.Parse(particleInput3);

    }

   public void displaySelectedParticle(int index)
    {

        selectedParticleInfoText.text = "Charge : " + index + " (C) \n" + "Mass : " +index +"kg";

    }

    public void setProtonMass(int protonMultiplier)
    {
        particleProtonMass = (protonMultiplier * protonMass);
        combineMasses();
    }

    public void setElectronMass(int electronMultiplier)
    {
        particleElectronMass = (electronMultiplier * electronMass);
        combineMasses();

    }

    private void combineMasses()
    {
        particleMass = particleProtonMass + particleElectronMass;
        RefreshText();
    }

    public void readVoltage()
    {
        try {
            string voltageInput1 = inputVoltage.GetComponent<Text>().text;
            voltage = float.Parse(voltageInput1);
        }
        catch 
        {
            voltage = 250; 
        }
       
        
    }

    void RefreshText() {
        blueRadiusText.text = "RADIUS : " + blueRadius + " m";
        redRadiusText.text = "RADIUS : " + redRadius + " m";
        greenRadiusText.text = "RADIUS : " + greenRadius + " m";

        magneticFieldText.text = "CAMPO MAGNETICO : " + magneticField + " T";
        particlesSpeedText.text = "VELOCIDAD DE LAS PARTICULAS : "+ particlesSpeed + " m/s";
        voltageText.text = "VOLTAJE : " + voltage + " V";
        distanceText.text = "DISTANCIA : " + distance + " m";
    }

}
