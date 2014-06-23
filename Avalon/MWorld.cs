﻿using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using TAPI;
using PoroCYon.MCT;
using PoroCYon.MCT.Net;

namespace Avalon
{
    /// <summary>
    /// Global world stuff
    /// </summary>
    public sealed class MWorld : ModWorld
    {
        internal static bool oldNight;
        internal static Item[/* player ID */][/* item index */] accessories;
        internal static Item[] loacalAccessories
        {
            get
            {
                return accessories[Main.myPlayer];
            }
            set
            {
                accessories[Main.myPlayer] = value;
            }
        }

        /// <summary>
        /// Creates a new instance of the MWorld class
        /// </summary>
        /// <param name="base">The ModBase which belongs to the ModWorld instance</param>
        /// <remarks>Called by the mod loader</remarks>
        public MWorld(ModBase @base)
            : base(@base)
        {

        }

        /// <summary>
        /// Called when the world is opened on this client or server
        /// </summary>
        public override void Initialize()
        {
            base.Initialize();


        }
        /// <summary>
        /// Called after the world is updated
        /// </summary>
        public override void PostUpdate()
        {
            base.PostUpdate();


        }

        /// <summary>
        /// Called when a Player joins the sever
        /// </summary>
        /// <param name="index">The whoAmI of the Player who is joining</param>
        public override void PlayerConnected(int index)
        {
            base.PlayerConnected(index);


        }

        /// <summary>
        /// Called when the world is loaded.
        /// </summary>
        /// <param name="bb"></param>
        public override void Load(BinBuffer bb)
        {
            base.Load(bb);

            accessories = new Item[NetHelper.CurrentMode == NetMode.Singleplayer ? 1 : Main.numPlayers][];

            for (int i = 0; i < accessories.Length; i++)
            {
                accessories[i] = new Item[Mod.ExtraSlots];

                for (int j = 0; j < Mod.ExtraSlots; j++)
                    accessories[i][j] = new Item();
            }
        }

        /// <summary>
        /// Called after the world is generated
        /// </summary>
        public override void WorldGenPostInit()
        {
            base.WorldGenPostInit();


        }
        /// <summary>
        /// Used to modify the worldgen task list (insert additional tasks)
        /// </summary>
        /// <param name="list">The task list to modify</param>
        public override void WorldGenModifyTaskList(List<WorldGenTask> list)
        {
            base.WorldGenModifyTaskList(list);


        }
        /// <summary>
        /// Used to modify the hardmode task list (when the WoF is defeated)
        /// </summary>
        /// <param name="list">The task list to modify</param>
        public override void WorldGenModifyHardmodeTaskList(List<WorldGenTask> list)
        {
            base.WorldGenModifyHardmodeTaskList(list);


        }

        /// <summary>
        /// Gets wether a boss is active or not.
        /// </summary>
        /// <returns>true if a boss is active, false otherwise.</returns>
        public static bool CheckForBosses()
        {
            return Main.npc.Count(n => n.boss) > 0; // LINQ++. again.
        }
    }
}
