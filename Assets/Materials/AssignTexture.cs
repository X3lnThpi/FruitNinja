using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssignTexture : MonoBehaviour
{
    public ComputeShader shader;
    public int texresolution = 256;
    Renderer rend;
    RenderTexture outputTexture;
    int kernelHandle;
    // Start is called before the first frame update
    void Start()
    {
        outputTexture = new RenderTexture(texresolution, texresolution, 0);
        outputTexture.enableRandomWrite = true;
        outputTexture.Create();

        rend = GetComponent<Renderer>();
        rend.enabled = true;

        InitShader();
    }

    private void InitShader()
    {
        kernelHandle = shader.FindKernel("CSMain");
        shader.SetTexture(kernelHandle, "Result", outputTexture);
        rend.material.SetTexture("_MainTex", outputTexture);

        DispatchShader(texresolution / 16, texresolution / 16);
    }

    private void DispatchShader(int x, int y)
    {
        shader.Dispatch(kernelHandle, x, y, 1);
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.U)){
            DispatchShader(texresolution / 8, texresolution / 8);
        }
    }
}
