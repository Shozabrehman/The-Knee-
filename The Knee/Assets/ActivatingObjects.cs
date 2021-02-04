using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;
public class ActivatingObjects : MonoBehaviour {

    public GameObject femur;
    public GameObject patella;
    public GameObject atricartilage;
    public GameObject patellacart;
    public GameObject meniscus;
    public GameObject tinficar;
    public GameObject tinfi;
    public GameObject acl;
    public GameObject pcl;
   

    bool activatefemur, activatepatella, activateatricartilage, activatepatellacart, activatemeniscus, activatetinfi, activatetinficar, activateacl, activatepcl = true;


    public void ActivateFemur()
    {   
        activatefemur = !activatefemur;
        femur.SetActive(activatefemur);
    }
    public void ActivePatella()
    {
        activatepatella = !activatepatella;
        patella.SetActive(activatepatella);
    }
    public void Activeatricartilage()
    {
        activateatricartilage = !activateatricartilage;
        atricartilage.SetActive(activateatricartilage);
    }
    public void Activatepatellacart()
    {
        activatepatellacart = !activatepatellacart;
        patellacart.SetActive(activatepatellacart);
    }
    public void Activatemeniscus()
    {
        activatemeniscus = !activatemeniscus;
        meniscus.SetActive(activatemeniscus);
    }
    public void Activatetinfi()
    {
        activatetinfi = !activatetinfi;
        tinfi.SetActive(activatetinfi);
    }
    public void Activatetinficar()
    {
        activatetinficar = !activatetinficar;
        tinficar.SetActive(activatetinficar);
    }
    public void Activateacl()
    {
        activateacl = !activateacl;
        acl.SetActive(activateacl);
    }
    public void Áctivatepcl()
    {
        activatepcl = !activatepcl;
        pcl.SetActive(activatepcl);
    }

}
