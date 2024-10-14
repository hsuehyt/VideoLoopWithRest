using System.Collections;
using UnityEngine;
using UnityEngine.Video;

public class VideoLoopWithRest : MonoBehaviour
{
    public VideoPlayer videoPlayer;   // The video player component.
    public float restTime = 5f;       // The rest time in seconds between loops.

    private void Start()
    {
        if (videoPlayer == null)
        {
            videoPlayer = GetComponent<VideoPlayer>();
        }

        // Subscribe to the video end event.
        videoPlayer.loopPointReached += OnVideoEnded;
    }

    // Called when the video finishes playing.
    private void OnVideoEnded(VideoPlayer vp)
    {
        StartCoroutine(RestAndPlay());
    }

    // Coroutine that waits for the rest time and then restarts the video.
    private IEnumerator RestAndPlay()
    {
        yield return new WaitForSeconds(restTime);   // Wait for the specified rest time.
        videoPlayer.Play();  // Restart the video.
    }
}
