/* Generated SBE (Simple Binary Encoding) message codec */

#pragma warning disable 1591 // disable warning on missing comments
using System;
using Org.SbeTool.Sbe.Dll;

namespace Sbe
{
    public enum RetransmitRejectCode : byte
    {
        OUT_OF_RANGE = 0,
        INVALID_SESSION = 1,
        REQUEST_LIMIT_EXCEEDED = 2,
        NULL_VALUE = 255
    }
}
