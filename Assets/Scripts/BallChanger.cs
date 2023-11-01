using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallChanger : MonoBehaviour
{
    int index = 0;
    [SerializeField]List<PlayerMotor> balls;
    [SerializeField] Button nextBtn, privBtn;
    [SerializeField]CameraMotor cam;
    void Start()
    {
        nextBtn.onClick.AddListener(Next);
        privBtn.onClick.AddListener(Priv);
    }

     void Update()
    {
        privBtn.interactable = true ? index > 0 : false;
        nextBtn.interactable = true ? index < balls.Count-1 : false;
    }

    void Next()
    {
        balls[index].gameObject.SetActive(false);
        index = (index + 1) % balls.Count;
        balls[index].gameObject.SetActive(true);
        cam.lookAt = balls[index].transform;
    }
    void Priv()
    {
        balls[index].gameObject.SetActive(false);
        index = (index - 1) % balls.Count;
        balls[index].gameObject.SetActive(true);
        cam.lookAt = balls[index].transform;
    }
}
