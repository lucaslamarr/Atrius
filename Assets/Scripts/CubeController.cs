using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    [SerializeField] private List<Material> _renderTextureMaterials;
    [SerializeField] private List<Renderer> _cubeSideRenderers;

    private void Start()
    {
        List<Material> usableRenderTextures = _renderTextureMaterials;
        int nextRenderTextureIndex;

        for (int counter = 0; counter < _cubeSideRenderers.Count; counter++)
        {
            nextRenderTextureIndex = Random.Range(0, usableRenderTextures.Count);
            _cubeSideRenderers[counter].material = _renderTextureMaterials[nextRenderTextureIndex];
            usableRenderTextures.RemoveAt(nextRenderTextureIndex);
        }
    }
}

