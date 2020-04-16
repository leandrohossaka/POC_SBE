/* Generated SBE (Simple Binary Encoding) message codec */

#pragma warning disable 1591 // disable warning on missing comments
using System;
using Org.SbeTool.Sbe.Dll;

namespace Sbe
{
    public enum TimeInForce : byte
    {
        DAY = 48,
        GOOD_TILL_CANCEL = 49,
        IMMEDIATE_OR_CANCEL = 51,
        FILL_OR_KILL = 52,
        GOOD_TILL_DATE = 54,
        AT_THE_CLOSE = 55,
        GOOD_FOR_AUCTION = 65,
        NULL_VALUE = 0
    }
}
