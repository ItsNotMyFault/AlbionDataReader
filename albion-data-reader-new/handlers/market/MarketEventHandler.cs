using Albion.Network;
using albion_data_reader_new.applicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace albion_data_reader_new.handlers.market
{
    public class MarketEventHandler : EventPacketHandler<MarketEvent>
    {
        private readonly MarketApiService marketApiService;

        private static readonly List<int> evetnCodes = new List<int>() {
            (int)EventCodes.evSplitItemStack,
            (int)EventCodes.evLeftChatChannel,
            (int)EventCodes.evNewSimpleItem,
            (int)EventCodes.evDetachItemContainer,
            (int)EventCodes.evMovedItemInInventory,
            (int)EventCodes.evDebugDiminishingReturnInfo,
            (int)EventCodes.evTrashItem,
            (int)EventCodes.evPlayerZoneInTheMap,
            (int)EventCodes.evNewEquipmentItem,
            (int)EventCodes.evRegenerationCraftingChanged,
            (int)EventCodes.evNewPortalEntrance,
            (int)EventCodes.evNewPortalExit,
        };
        public MarketEventHandler(MarketApiService marketApiService) : base(evetnCodes)
        {
            this.marketApiService = marketApiService;
        }

        protected override async Task OnActionAsync(MarketEvent value)
        {
            //throw new NotImplementedException();
            await Task.CompletedTask;
        }
    }
}
