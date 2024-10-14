# VideoLoopWithRest

A Unity script that allows you to play a video on loop with a defined rest period between each loop. The script lets you control how long the video pauses before starting again after it reaches the end.

## Features
- Plays a video clip using Unity's `VideoPlayer` component.
- Allows you to define a custom rest time (in seconds) between each loop.
- Automatically restarts the video after the specified rest time.

## Installation

1. Clone or download this repository and import it into your Unity project.
2. Attach the `VideoLoopWithRest` script to a GameObject that has a `VideoPlayer` component.
3. In the Inspector:
   - Assign the `VideoPlayer` component reference.
   - Set your desired `restTime` (default is 5 seconds).

## How to Use

1. Create a GameObject in your Unity scene.
2. Add a `VideoPlayer` component to the GameObject.
3. Drag your video clip to the `VideoPlayer`'s `Video Clip` field.
4. Attach the `VideoLoopWithRest` script to the same GameObject.
5. Set the `restTime` (the number of seconds to pause between loops).
6. Ensure that the `Loop` option in the `VideoPlayer` is **unchecked** since the script handles the looping and rest time.

### Example Usage

```csharp
public VideoPlayer videoPlayer;   // Reference to the VideoPlayer component
public float restTime = 5f;       // Rest time between loops, default is 5 seconds
```

The video will play once, then wait for the defined `restTime` before starting over.

## License

This project is licensed under the MIT License - see the [LICENSE](https://github.com/hsuehyt/VideoLoopWithRest/blob/main/LICENSE) file for details.