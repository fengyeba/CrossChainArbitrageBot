﻿using Agents.Net;
using CrossChainArbitrageBot.Base.Models;

namespace CrossChainArbitrageBot.Base.Messages;

public class TransactionStarted : Message
{
    public TransactionStarted(Message predecessorMessage, double transactionAmount, BlockchainName chain, TransactionType type) : base(predecessorMessage)
    {
        TransactionAmount = transactionAmount;
        Chain = chain;
        Type = type;
    }

    public TransactionStarted(IEnumerable<Message> predecessorMessages, double transactionAmount, BlockchainName chain, TransactionType type) : base(predecessorMessages)
    {
        TransactionAmount = transactionAmount;
        Chain = chain;
        Type = type;
    }

    public double TransactionAmount { get; }
    public BlockchainName Chain { get; }
    public TransactionType Type { get; }

    protected override string DataToString()
    {
        return $"{nameof(TransactionAmount)}: {TransactionAmount}; {nameof(Chain)}: {Chain}; {nameof(Type)}: {Type}";
    }
}