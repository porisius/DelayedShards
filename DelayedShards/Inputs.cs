﻿using CG.Input;
using CG;
using Photon.Pun;
using VoidManager.Utilities;

namespace DelayedShards
{
    internal class Inputs
    {
        internal static void HandleInputs()
        {
            if (!Helper.IsInPilotsSeat(PhotonNetwork.LocalPlayer))
            {
                if (Tools.PlayerShipExists && !ServiceBase<InputService>.Instance.CursorVisibilityControl.IsCursorShown &&
                    (Helper.ButtonPressed(Configs.SummonEscortConfig.Value) || Helper.ButtonPressed(Configs.SummonMinefieldConfig.Value)))
                {
                    Messaging.Notification("You must be in the pilot's seat to activate data shards", Helper.messageTimeout);
                }
                return;
            }

            if (!ServiceBase<InputService>.Instance.CursorVisibilityControl.IsCursorShown &&
                Helper.ButtonPressed(Configs.SummonEscortConfig.Value))
            {
                if (PhotonNetwork.IsMasterClient)
                {
                    Helper.RejectReason reason = Helper.SummonEscort();
                    if (reason != Helper.RejectReason.None)
                        Helper.DisplayLocalMessage(reason);
                }
                else
                {
                    ShardMessageHandler.ActivateShard("escort");
                }
            }

            if (!ServiceBase<InputService>.Instance.CursorVisibilityControl.IsCursorShown &&
                Helper.ButtonPressed(Configs.SummonMinefieldConfig.Value))
            {
                if (PhotonNetwork.IsMasterClient)
                {
                    Helper.RejectReason reason = Helper.SummonMinefield();
                    if (reason != Helper.RejectReason.None)
                        Helper.DisplayLocalMessage(reason);
                }
                else
                {
                    ShardMessageHandler.ActivateShard("minefield");
                }
            }
        }
    }
}
