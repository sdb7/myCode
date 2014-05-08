using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;


public static class RectExtension 
{
    public static Rect OffsetRectHorizontal(this Rect value, float padX)
    {
        if (padX == 0)
            padX = 1;

        Rect r = new Rect(value.xMax + padX, value.yMin , value.width, value.height);
        return r;
    }

    public static Rect OffsetRectVertical(this Rect value, float padY)
    {
        if (padY == 0)
            padY = 1;

        Rect r = new Rect(value.xMin, value.yMax + padY, value.width, value.height);
        return r;
    }

    public static Rect OffsetRect(this Rect value, float padX, float padY)
    {
        if (padX == 0)
            padX = 1;

        if (padY == 0)
            padY = 1;

        Rect r = new Rect(value.xMax + padX, value.yMax + padY, value.width, value.height);
        return r;
    }

    public static Rect[] MultiplyHorizontal(this Rect value, int count, float pad)
    {
        Rect[] r = new Rect[count];
        for (int i = 1; i < r.Length; i++)
        {
            r[i] = new Rect(i * (value.yMax + pad), value.yMin, value.width, value.height);
        }

        return r;
    }
}
