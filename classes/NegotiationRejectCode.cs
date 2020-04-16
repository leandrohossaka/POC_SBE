/* Generated SBE (Simple Binary Encoding) message codec */

#pragma warning disable 1591 // disable warning on missing comments
using System;
using Org.SbeTool.Sbe.Dll;

namespace Sbe
{
    public enum NegotiationRejectCode : byte
    {
        UNSPECIFIED = 0,
        CREDENTIALS = 1,
        FLOWTYPE_NOT_SUPPORTED = 2,
        DUPLICATE_ID = 3,
        NULL_VALUE = 255
    }
}
