using UnityEngine;

public class CanvasFader : MonoBehaviour
{
    public float waitTime;
    public float fadeInTime;
    public float activeTime;
    public float fadeOutTime;

    float fadeInCount;
    float fadeOutCount;
    float waitTimeCount;
    float activeTimeCount;
    CanvasGroup canvas;

    void Awake()
    {
        fadeInCount = fadeInTime;
        fadeOutCount = fadeOutTime;
        waitTimeCount = waitTime;
        activeTimeCount = activeTime;
        canvas = gameObject.GetComponent<CanvasGroup>();
    }

    void Update ()
    {
        if (waitTimeCount >= 0)
        {
            waitTimeCount -= Time.deltaTime;
        }
		else if (fadeInCount >= 0)
        {
            canvas.alpha = (fadeInCount / fadeInTime);
            fadeInCount -= Time.deltaTime;
        }
        else if (activeTimeCount >= 0)
        {
            activeTimeCount -= Time.deltaTime;
            canvas.alpha = 1;
        }
        else if (fadeOutCount >= 0)
        {
            canvas.alpha = fadeOutCount / fadeOutTime;
            fadeOutCount -= Time.deltaTime;
        }
    }

    public void resetValues()
    {
        waitTimeCount = waitTime;
        fadeInCount = fadeInTime;
        activeTimeCount = activeTime;
        fadeOutCount = fadeOutTime;
        canvas.alpha = 1;
    }
}
