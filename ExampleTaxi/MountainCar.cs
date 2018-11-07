﻿using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using DeepQL.Agents;
using DeepQL.Environments;
using DeepQL.Gyms;
using DeepQL.Misc;
using Neuro.Tensors;

namespace Examples
{
    class MountainCar
    {
        static void Main(string[] args)
        {
            Env env = new MountainCarEnv();

            env.Reset();

            while (!env.Step((int)env.ActionSpace.Sample()[0], out var nextState, out var reward))
            {
                env.Render();
                Thread.Sleep(50);
            }

            return;
        }
    }
}
