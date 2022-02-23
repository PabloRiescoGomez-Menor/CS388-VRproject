using UnityEngine;
using UnityEngine.UI;

public class FishEyeEffectEditor : MonoBehaviour
{
    // Sliders
    public Slider sliderEffect;
    public Slider sliderSeparation;
    // Cameras
    public GameObject camera1;
    public GameObject camera2;
    // Fisheye components of the cameras
    public UnityStandardAssets.ImageEffects.Fisheye fishEye1;
    public UnityStandardAssets.ImageEffects.Fisheye fishEye2;

    // Initial positions of cameras
    private Vector3 initialPos1;
    private Vector3 initialPos2;

    // Initial values of the sliders
    public float initialFishEyeValue = 0.25f;
    public float initialSeparationValue = 0.25f;

    // Maximum values
    public float maxFishEyeValue = 1.5f;
    public float maxSeparationValue = 10.0f;    

    // Start is called before the first frame update
    void Start()
    {
        initialPos1 = camera1.transform.localPosition;
        initialPos2 = camera2.transform.localPosition;

        // Set initial slider values to the ones set
        sliderEffect.value = initialFishEyeValue;
        sliderSeparation.value = initialSeparationValue;
        UpdateSliderValues();
        UpdateSeparationValue();

        Debug.Log(camera1);
        Debug.Log(camera2);
        Debug.Log(fishEye1);
        Debug.Log(fishEye2);
    }

    // Update is called once per frame
    void Update()
    {
        sliderEffect.onValueChanged.AddListener(delegate { UpdateSliderValues(); });
        sliderSeparation.onValueChanged.AddListener(delegate { UpdateSeparationValue(); });
    }

    // Updates the value changed by the slider to the other objects
    void UpdateSliderValues()
    {
        // Camera 1 edit x and y values
        fishEye1.strengthX = maxFishEyeValue * sliderEffect.value;
        fishEye1.strengthY = maxFishEyeValue * sliderEffect.value;

        // Camera 2 edit x and y values
        fishEye2.strengthX = maxFishEyeValue * sliderEffect.value;
        fishEye2.strengthY = maxFishEyeValue * sliderEffect.value;
    }

    // Updates the separation changed by the slider to the other objects
    void UpdateSeparationValue()
    {
        // Edit offset of cameras
        camera1.transform.localPosition = new Vector3( sliderSeparation.value * maxSeparationValue, initialPos1.y, initialPos1.z);
        camera2.transform.localPosition = new Vector3(-sliderSeparation.value * maxSeparationValue, initialPos1.y, initialPos1.z);
    }
}
