using System.Collections.Generic;
using Agents.Net;
using CrossChainArbitrageBot.Base.Messages;

namespace CrossChainArbitrageBot.Simulation.Messages;

public class SimulatedDataUpdated : MessageDecorator
{
    private SimulatedDataUpdated(Message decoratedMessage) : base(decoratedMessage)
    {
    }

    public static SimulatedDataUpdated Decorate(DataUpdated dataUpdated)
    {
        return new SimulatedDataUpdated(dataUpdated);
    }

    protected override string DataToString()
    {
        return string.Empty;
    }
}