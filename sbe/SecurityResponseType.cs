/* Generated SBE (Simple Binary Encoding) message codec */

#pragma warning disable 1591 // disable warning on missing comments
using System;
using Org.SbeTool.Sbe.Dll;

namespace Sbe
{
    public enum SecurityResponseType : byte
    {
        ACCEPT_SECURITY_PROPOSAL_AS_IS = 1,
        REJECT_SECURITY_PROPOSAL = 5,
        NULL_VALUE = 255
    }
}
