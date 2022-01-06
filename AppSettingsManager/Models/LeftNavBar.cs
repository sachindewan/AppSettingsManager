using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppSettingsManager.Models
{
    public class LeftNavBar
    {
        public List<Item> Items { get; set; }
    }
    public class Item
    {
        /// <summary>
        /// display name
        /// </summary>
        public string DisplayName { get; set; }
        /// <summary>
        /// Url of icon
        /// </summary>
        public string IconUrl { get; set; }
        /// <summary>
        /// Area Lable
        /// </summary>
        public string AriaLabel { get; set; }
        /// <summary>
        /// URI
        /// </summary>
        public string URI { get; set; }
        /// <summary>
        /// Navigation type
        /// </summary>
        public string NavigationType { get; set; }

        /// <summary>
        /// acronym
        /// </summary>
        public string Acronym { get; set; }
        public List<Item> SubMenu { get; set; }
    }
}
