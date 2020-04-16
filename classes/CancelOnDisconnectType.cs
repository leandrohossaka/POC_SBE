/* Generated SBE (Simple Binary Encoding) message codec */

#pragma warning disable 1591 // disable warning on missing comments
using System;
using Org.SbeTool.Sbe.Dll;

namespace Sbe
{
    public enum CancelOnDisconnectType : byte
    {
        DO_NOT_CANCEL_ON_DISCONNECT_OR_TERMINATE = 0,
        CANCEL_ON_DISCONNECT_ONLY = 1,
        CANCEL_ON_TERMINATE_ONLY = 2,
        CANCEL_ON_DISCONNECT_OR_TERMINATE = 3,
        NULL_VALUE = 255
    }
}
