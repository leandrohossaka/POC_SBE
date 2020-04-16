/* Generated SBE (Simple Binary Encoding) message codec */

#pragma warning disable 1591 // disable warning on missing comments
using System;
using Org.SbeTool.Sbe.Dll;

namespace Sbe
{
    public enum MassActionRejectReason : byte
    {
        MASS_ACTION_NOT_SUPPORTED = 0,
        INVALID_OR_UNKNOWN_MARKET_SEGMENT = 8,
        OTHER = 99,
        NULL_VALUE = 255
    }
}
