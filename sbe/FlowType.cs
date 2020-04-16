/* Generated SBE (Simple Binary Encoding) message codec */

#pragma warning disable 1591 // disable warning on missing comments
using System;
using Org.SbeTool.Sbe.Dll;

namespace Sbe
{
    public enum FlowType : byte
    {
        NONE = 0,
        RECOVERABLE = 1,
        UNSEQUENCED = 2,
        IDEMPOTENT = 3,
        NULL_VALUE = 255
    }
}
