// Copyright (c) 2018 Southrop. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

using TouchScript.Gestures;
using TouchScript.Gestures.TransformGestures.Base;
using UniRx;

public static class TouchScriptRxExtensions
{
    #region Gesture
    public static IObservable<EventPattern<EventArgs>> CancelledAsObservable(this Gesture gesture)
    {
        return Observable.FromEventPattern<EventHandler<EventArgs>, EventArgs>(
                h => h.Invoke,
                h => gesture.Cancelled += h,
                h => gesture.Cancelled -= h);
    }

    public static IObservable<EventPattern<GestureStateChangeEventArgs>> StateChangedAsObservable(this Gesture gesture)
    {
        return Observable.FromEventPattern<EventHandler<GestureStateChangeEventArgs>, GestureStateChangeEventArgs>(
                h => h.Invoke,
                h => gesture.StateChanged += h,
                h => gesture.StateChanged -= h);
    }
    #endregion

    #region TapGesture
    public static IObservable<EventPattern<EventArgs>> TappedAsObservable(this TapGesture gesture)
    {
        return Observable.FromEventPattern<EventHandler<EventArgs>, EventArgs>(
                h => h.Invoke,
                h => gesture.Tapped += h,
                h => gesture.Tapped -= h);
    }
    #endregion

    #region PressGesture
    public static IObservable<EventPattern<EventArgs>> PressedAsObservable(this PressGesture gesture)
    {
        return Observable.FromEventPattern<EventHandler<EventArgs>, EventArgs>(
                h => h.Invoke,
                h => gesture.Pressed += h,
                h => gesture.Pressed -= h);
    }
    #endregion

    #region ReleaseGesture
    public static IObservable<EventPattern<EventArgs>> ReleasedAsObservable(this ReleaseGesture gesture)
    {
        return Observable.FromEventPattern<EventHandler<EventArgs>, EventArgs>(
                h => h.Invoke,
                h => gesture.Released += h,
                h => gesture.Released -= h);
    }
    #endregion

    #region LongPressGesture
    public static IObservable<EventPattern<EventArgs>> LongPressedAsObservable(this LongPressGesture gesture)
    {
        return Observable.FromEventPattern<EventHandler<EventArgs>, EventArgs>(
                h => h.Invoke,
                h => gesture.LongPressed += h,
                h => gesture.LongPressed -= h);
    }
    #endregion

    #region FlickGesture
    public static IObservable<EventPattern<EventArgs>> FlickedAsObservable(this FlickGesture gesture)
    {
        return Observable.FromEventPattern<EventHandler<EventArgs>, EventArgs>(
                h => h.Invoke,
                h => gesture.Flicked += h,
                h => gesture.Flicked -= h);
    }
    #endregion

    #region TransformGestureBase
    public static IObservable<EventPattern<EventArgs>> TransformStartedAsObservable(this TransformGestureBase gesture)
    {
        return Observable.FromEventPattern<EventHandler<EventArgs>, EventArgs>(
                h => h.Invoke,
                h => gesture.TransformStarted += h,
                h => gesture.TransformStarted -= h);
    }

    public static IObservable<EventPattern<EventArgs>> TransformedAsObservable(this TransformGestureBase gesture)
    {
        return Observable.FromEventPattern<EventHandler<EventArgs>, EventArgs>(
                h => h.Invoke,
                h => gesture.Transformed += h,
                h => gesture.Transformed -= h);
    }

    public static IObservable<EventPattern<EventArgs>> TransformCompletedAsObservable(this TransformGestureBase gesture)
    {
        return Observable.FromEventPattern<EventHandler<EventArgs>, EventArgs>(
                h => h.Invoke,
                h => gesture.TransformCompleted += h,
                h => gesture.TransformCompleted -= h);
    }
    #endregion

    #region MetaGesture
    public static IObservable<EventPattern<MetaGestureEventArgs>> PointerPressedAsObservable(this MetaGesture gesture)
    {
        return Observable.FromEventPattern<EventHandler<MetaGestureEventArgs>, MetaGestureEventArgs>(
                h => h.Invoke,
                h => gesture.PointerPressed += h,
                h => gesture.PointerPressed -= h);
    }

    public static IObservable<EventPattern<MetaGestureEventArgs>> PointerUpdatedAsObservable(this MetaGesture gesture)
    {
        return Observable.FromEventPattern<EventHandler<MetaGestureEventArgs>, MetaGestureEventArgs>(
                h => h.Invoke,
                h => gesture.PointerUpdated += h,
                h => gesture.PointerUpdated -= h);
    }

    public static IObservable<EventPattern<MetaGestureEventArgs>> PointerReleasedAsObservable(this MetaGesture gesture)
    {
        return Observable.FromEventPattern<EventHandler<MetaGestureEventArgs>, MetaGestureEventArgs>(
                h => h.Invoke,
                h => gesture.PointerReleased += h,
                h => gesture.PointerReleased -= h);
    }

    public static IObservable<EventPattern<MetaGestureEventArgs>> PointerCancelledAsObservable(this MetaGesture gesture)
    {
        return Observable.FromEventPattern<EventHandler<MetaGestureEventArgs>, MetaGestureEventArgs>(
                h => h.Invoke,
                h => gesture.PointerCancelled += h,
                h => gesture.PointerCancelled -= h);
    }
    #endregion
}
