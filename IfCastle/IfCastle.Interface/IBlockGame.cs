﻿using Orleans;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace IfCastle.Interface
{
    public interface IBlockGame : IGrainWithGuidKey
    {
        Task<Guid> Start();

        Task Move(Direction direction);

        Task PauseOrResume();

        Task Close();
        Task Restart();
    }

    public enum Direction
    {
        Up, Down, Left, Right
    }
}
