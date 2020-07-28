using System;

/// <summary> Class that doesn't inherit </summary>
/// <typeparam name="T"> parameter </typeparam>
class Queue<T> {

    /// <summary>Function to check the type of Queue</summary>
    /// <returns></returns>

    public Type CheckType () {
        return typeof (T);
    }
}