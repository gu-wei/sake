﻿namespace Sake.Engine.Logging
{
    public interface ILog
    {
        void Info(object value);
        void Warn(object value);
        void Verbose(object value);
    }
}