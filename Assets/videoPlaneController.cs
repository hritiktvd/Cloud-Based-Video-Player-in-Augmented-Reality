using UnityEngine;
using UnityEngine.Video;

public class videoPlaneController : MonoBehaviour {

    public VideoPlayer vp;
    public Texture defaultTex;
    public RenderTexture renderTex;

    private void OnEnable()
    {
        if (vp != null) vp.Play();
    }

    private void OnDisable()
    {
        if (vp != null)
        {
            vp.Stop();
            Graphics.Blit(defaultTex, renderTex);
        }
    }


}
