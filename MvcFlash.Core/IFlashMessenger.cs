﻿using MvcFlash.Core.Messages;

namespace MvcFlash.Core
{
    public interface IFlashMessenger 
        : IFlashPusher, IFlashPopper
    {
        int Count { get; }
        void Clear();
    }

    public interface IFlashPusher
    {
        MessageBase Push(MessageBase message);
    }

    public interface IFlashPopper
    {
        MessageBase Pop();
    }
}
