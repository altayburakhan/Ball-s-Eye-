using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Options : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void low()
    { 
        QualitySettings.SetQualityLevel(1);  
    }
    public void med() {

        QualitySettings.SetQualityLevel(3);
        
    }
    public void high() {
    
        QualitySettings.SetQualityLevel(6);
    
    } 
    public void shadowclose() {

         QualitySettings.shadows = ShadowQuality.Disable;
    }
    public void shadowopen() {

        QualitySettings.shadows = ShadowQuality.All;
    }
}
    
