﻿using System.Diagnostics.CodeAnalysis;
using System.IO;
using MHR_Editor.Common.Models;

namespace MHR_Editor.Common.Structs;

[SuppressMessage("ReSharper", "UnusedAutoPropertyAccessor.Global")]
public class Vec2 : RszObject, IViaType {
    public float X { get; set; }
    public float Y { get; set; }

    public void Read(BinaryReader reader) {
        X = reader.ReadSingle();
        Y = reader.ReadSingle();
        reader.ReadSingle();
        reader.ReadSingle();
    }
}