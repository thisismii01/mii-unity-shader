using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CameraMovement : MonoBehaviour
{
    public List<CameraMode> cameraModes;
    private int currentModeIndex = 0;
    private Coroutine movementCoroutine;

    void Start()
    {
        if (cameraModes.Count > 0)
            StartMode(currentModeIndex);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {   
            currentModeIndex = (currentModeIndex + 1) % cameraModes.Count;
            StartMode(currentModeIndex);
            Debug.Log("Switched to mode: " + cameraModes[currentModeIndex].name);
        }
    }

    public void StartMode(int index)
    {
        if (index < 0 || index >= cameraModes.Count) return;

        if (movementCoroutine != null)
            StopCoroutine(movementCoroutine);

        cameraModes[index].SetPosAndRot(transform);
        movementCoroutine = StartCoroutine(YoYoLoop(cameraModes[index], transform));
    }

    IEnumerator YoYoLoop(CameraMode mode, Transform camTransform)
    {
        Vector3 from = camTransform.localPosition + mode.offsetStart;
        Vector3 to = camTransform.localPosition + mode.offsetEnd;

        while (true)
        {
            yield return MoveSmooth(camTransform, from, to, mode.duration);
            yield return new WaitForSeconds(mode.pauseDuration);
            yield return MoveSmooth(camTransform, to, from, mode.duration);
            yield return new WaitForSeconds(mode.pauseDuration);
        }
    }

    IEnumerator MoveSmooth(Transform cam, Vector3 from, Vector3 to, float time)
    {
        float elapsed = 0f;
        while (elapsed < time)
        {
            float t = Mathf.SmoothStep(0f, 1f, elapsed / time);
            cam.localPosition = Vector3.Lerp(from, to, t);
            elapsed += Time.deltaTime;
            yield return null;
        }
        cam.localPosition = to;
    }
}


[System.Serializable]
public class CameraMode
{
    public string name;
    public Vector3 cameraPosition;
    public Vector3 cameraRotation;

    public Vector3 offsetStart = new Vector3(0, 0, -15f);
    public Vector3 offsetEnd = new Vector3(0, 0, -50f);

    public float duration = 3f;
    public float pauseDuration = 0.5f;

    public void SetPosAndRot(Transform transform)
    {
        transform.localPosition = cameraPosition;
        transform.localEulerAngles = cameraRotation;
    }
}

