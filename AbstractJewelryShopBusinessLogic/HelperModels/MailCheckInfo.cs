﻿using AbstractJewelryShopBusinessLogic.Interfaces;

namespace AbstractJewelryShopBusinessLogic.HelperModels
{
    public class MailCheckInfo
    {
        public string PopHost { get; set; }

        public int PopPort { get; set; }

        public IMessageInfoStorage MessageStorage { get; set; }

        public IClientStorage ClientStorage { get; set; }
    }
}
