/* Generated SBE (Simple Binary Encoding) message codec */

#pragma warning disable 1591 // disable warning on missing comments

namespace SbeFIX
{
    public enum MessageType : byte
    {
        Negotiate = 0,
        NegotiateResponse = 1,
        NegotiateReject = 2,
        Establish = 3,
        EstablishAck = 4,
        EstablishReject = 5,
        Terminate = 6,
        FinishedSending = 7,
        FinishedReceiving = 8,
        NotApplied = 9,
        RestransmitRequest = 10,
        Restransmission = 11,
        RestransmitReject = 12,
        Sequence = 13,
        BusinessMessageReject = 14,
        SimpleNewOrder = 15,
        SimpleReplaceOrder = 16,
        NewOrderSingle = 17,
        OrderCancelReplaceRequest = 18,
        OrderCancelRequest = 19,
        NewOrderCross = 20,
        ExecutionReport_New = 21,
        ExecutionReport_Modify = 22,
        ExecutionReport_Cancel = 23,
        ExecutionReport_Trade = 24,
        ExecutionReport_Reject = 25,
        ExecutionReport_Forward = 26,
        SecurityDefinitionRequest = 27,
        SecurityDefinition = 28,
        OrderMassActionRequest = 29,
        OrderMassActionReport = 30,
        NULL_VALUE = 255
    }
}
