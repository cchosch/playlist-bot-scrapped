﻿using System;
using Discord.WebSocket;
using Discord;

namespace playlistbot { 
    public class Commands
    {
        public static async Task commandHandler(SocketSlashCommand cmd)
        {
            foreach (SlashCommand s in Global.bot.slashCommands) {
                if (cmd.CommandName == s.builder.Name)
                    s.impl(cmd);
            }
        }
    }
}
