/* Generated SBE (Simple Binary Encoding) message codec */

#pragma warning disable 1591 // disable warning on missing comments
using System;
using Org.SbeTool.Sbe.Dll;

namespace Sbe
{
    public enum EstablishRejectCode : byte
    {
        UNSPECIFIED = 0,
        CREDENTIALS = 1,
        UNNEGOTIATED = 2,
        ALREADY_ESTABLISHED = 3,
        SESSION_BLOCKED = 4,
        KEEPALIVE_INTERVAL = 5,
        NULL_VALUE = 255
    }
}
