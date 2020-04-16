/* Generated SBE (Simple Binary Encoding) message codec */

#pragma warning disable 1591 // disable warning on missing comments
using System;
using Org.SbeTool.Sbe.Dll;

namespace Sbe
{
    public enum RoutingInstruction : byte
    {
        NO_ADDITIONAL_INSTRUCTION = 0,
        RETAIL_LIQUIDITY_TAKER = 1,
        WAIVED_PRIORITY = 2,
        NULL_VALUE = 255
    }
}
