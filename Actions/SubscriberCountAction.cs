﻿using Google.Apis.YouTube.v3.Data;
using StreamDeckLib;
using System.Threading.Tasks;

namespace streamdeckyoutube.Actions
{
    [ActionUuid(Uuid = "ch.claudiobernasconi.streamdeckyoutube.SubscriberCount.DefaultPluginAction")]
    public class SubscriberCountAction : YouTubeDataAPIAction 
    { 
        protected override async Task OnChannelStatisticsReceived(string context, ChannelListResponse channelData)
        {
            var subscriberCount = channelData.Items[0].Statistics.SubscriberCount;
            await Manager.SetTitleAsync(context, subscriberCount.ToString());
        }
    }
}