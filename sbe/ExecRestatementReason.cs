/* Generated SBE (Simple Binary Encoding) message codec */

#pragma warning disable 1591 // disable warning on missing comments
using System;
using Org.SbeTool.Sbe.Dll;

namespace Sbe
{
    public enum ExecRestatementReason : byte
    {
        MARKET_OPTION = 8,
        CANCEL_ON_HARD_DISCONNECTION = 100,
        CANCEL_ON_TERMINATE = 101,
        CANCEL_ON_DISCONNECT_AND_TERMINATE = 102,
        SELF_TRADING_PREVENTION = 103,
        MARKET_MAKER_PROTECTION = 200,
        RISK_MANAGEMENT_CANCELLATION = 201,
        ORDER_MASS_ACTION_FROM_CLIENT_REQUEST = 202,
        NULL_VALUE = 255
    }
}
