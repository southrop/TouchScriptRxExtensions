# TouchScriptRxExtensions

A small extension class for using TouchScript gestures as Rx Observables in Unity.

### Prerequisites

* [TouchScript](https://github.com/TouchScript/TouchScript)
* [UniRx](https://github.com/neuecc/UniRx)

### Usage

1. Put the class somewhere in your project
2. That's it actually.

### Example

``` c#
tapGesture.TappedAsObservable().Subscribe(x =>
{
    HitData hit = ((TapGesture)x.Sender).GetScreenPositionHitData();
    cameraController.MoveCamera(hit.Point);
});

screenTransformGesture.TransformedAsObservable().Subscribe(x =>
{
    transform.position += screenTransformGesture.DeltaPosition;
});
```
